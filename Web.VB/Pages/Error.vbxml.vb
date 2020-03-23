﻿Namespace Pages

    Partial Public Class ErrorModel
        Private Function GetVbXml() As XElement

            Return _
<zml xmlns:z="zml">
    <z:model type="ErrorModel" />

    <h1 class="text-danger">Error</h1>
    <h2 class="text-danger">An error occurred while processing your request.</h2>

    <z:if condition="Model.ShowRequestId">
        <p>
            <strong>Request ID:</strong><code>@Model.RequestId</code>
        </p>
    </z:if>

    <h3>Development Mode</h3>
    <p>Swapping to the <strong>Development</strong> environment displays detailed information about the error that occurred.</p>
    <p>
        <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
        It can result in displaying sensitive information from exceptions to end users.
        For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
        and restarting the app.
    </p>
</zml>
        End Function
    End Class
End Namespace