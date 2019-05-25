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
        Console.WriteLine("Hello ASP.NET MVC and VB World!")
        Dim host = WebHost.CreateDefaultBuilder(args).
            UseStartup(Of Startup)().
            UseUrls("http://*:5000").Build()
        host.Run()
    End Sub
End Module
