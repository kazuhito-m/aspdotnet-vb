Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Mvc
Imports Aspdotnetvb.Models

Namespace Aspdotnetvb.Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As IActionResult
            Return View()
        End Function

        Public Function Privacy() As IActionResult
            Return View()
        End Function

        ' <ResponseCache(Duration :=0 , Location := ResponseCacheLocation.None, NoStore := True)> _
        ' Public Function WhenError() As IActionResult
        '     Dim viewModel As ErrorViewModel = New ErrorViewModel()
        '     If Activity.Current.Id Is Nothing Then
        '         viewModel.RequestId = HttpContext.TraceIdentifier
        '     Else
        '         viewModel.RequestId = Activity.Current.Id
        '     End If
        '     Return View(viewModel)
        ' End Function
    End Class
End Namespace