Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.AspNetCore.Http
Imports Microsoft.AspNetCore.HttpsPolicy
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection

Public Class Startup
    Private _Configuration As IConfiguration

    Public Sub New(configuration As IConfiguration)
        _Configuration = configuration
    End Sub

    Public ReadOnly Property Configuration As IConfiguration
        Get
            Return _Configuration
        End Get
    End Property

    Public Sub ConfigureServices(services As IServiceCollection)
        services.Configure(Of CookiePolicyOptions)(
            Sub(options As CookiePolicyOptions)
                options.CheckConsentNeeded = Function(context) True
                options.MinimumSameSitePolicy = SameSiteMode.None
            End Sub
        )
        services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
    End Sub

    Public Sub Configure(app As IApplicationBuilder, env As IHostingEnvironment)
        If env.IsDevelopment() Then
            app.UseDeveloperExceptionPage()
        Else
            app.UseExceptionHandler("/Home/Error")
            ' The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts()
        End If

        app.UseHttpsRedirection()
        app.UseStaticFiles()
        app.UseCookiePolicy()

        app.UseMvc(
            Sub(routes)
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}")
            End sub
        )
    End Sub
End Class