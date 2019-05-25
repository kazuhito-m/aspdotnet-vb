Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Logging
Imports Microsoft.Extensions.Options
 
Public Class Startup
    Public Sub New(configuration As IConfiguration)
        _Configuration = configuration
    End Sub
    Private _Configuration As IConfiguration
    Public ReadOnly Property Configuration As IConfiguration
        Get
            Return _Configuration
        End Get
    End Property
    Public Sub ConfigureServices(services As IServiceCollection)
        services.AddMvc()
    End Sub
    Public Sub Configure(app As IApplicationBuilder, env As IHostingEnvironment)
        If env.IsDevelopment() Then
            app.UseDeveloperExceptionPage()
        End If
        app.UseMvc()
    End Sub
End Class   