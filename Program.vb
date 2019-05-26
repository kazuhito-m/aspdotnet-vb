Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore
Imports Microsoft.AspNetCore.Hosting
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.Logging

Module Program
    Sub Main(args As String())
        CreateWebHostBuilder(args).Build.Run()
    End Sub

    Function CreateWebHostBuilder(args As String()) As IWebHostBuilder
        return WebHost.CreateDefaultBuilder(args).
            UseStartup(Of Startup)()
    End Function
End Module
