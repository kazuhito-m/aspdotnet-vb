Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Mvc
 
<Route("api/[controller]")>
Public Class ValuesController
    Inherits Controller
 
    <HttpGet>
    Public Function [Get]() As IEnumerable(Of String)
        Return New String() {"value1", "value2"}
    End Function
 
    <HttpGet("{id}")>
    Public Function [Get](id As Integer) As String
        Return "value"
    End Function
 
    <HttpPost>
    Public Sub Post(<FromBody> value As String)
 
    End Sub
 
    <HttpPut("{id}")>
    Public Sub Put(id As Integer, <FromBody> value As String)
 
    End Sub
 
    <HttpDelete("{id}")>
    Public Sub Delete(id As Integer)
 
    End Sub
End Class