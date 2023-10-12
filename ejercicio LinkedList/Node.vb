Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Friend Class Node
    Private _dato As Integer
    Private _name As String
    Private _siguiente As Node

    Public Property Dato As Integer
        Get
            Return _dato
        End Get
        Set(value As Integer)
            _dato = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Siguiente As Node
        Get
            Return _siguiente
        End Get
        Set(value As Node)
            _siguiente = value
        End Set
    End Property

    Public Sub New()
        _dato = 0
        _name = ""
        _siguiente = Nothing
    End Sub

    Public Sub New(d As Integer)
        _dato = d
        _name = ""
        _siguiente = Nothing
    End Sub

    Public Sub New(d As Integer, n As String, s As Node)
        _dato = d
        _name = n
        _siguiente = s
    End Sub

    Public Overridable Function ToString2() As String
        Return _dato.ToString() & " " & _name
    End Function
End Class
