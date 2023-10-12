Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Threading.Tasks
Friend Class LinkedList
    Inherits Node
    Private cima As Node
    Private NodeCount As Integer = 0

    Public Function ToArray() As String()
        Dim result(Count() - 1) As String
        Dim index As Integer = 0
        Dim node As Node = cima
        While node IsNot Nothing
            result(index) = node.Dato.ToString()
            node = node.Siguiente
            index += 1
        End While
        Return result
    End Function

    Public Property Head As Node
        Get
            Return cima
        End Get
        Set(value As Node)
            cima = value
        End Set
    End Property
 
    Public Sub New()
        cima = Nothing
    End Sub

    Public Sub Push(Dato As Integer)
        Dim nuevoNodo As New Node(Dato)
        nuevoNodo.Siguiente = cima
        cima = nuevoNodo
        NodeCount += 1
    End Sub

    Public Function Pop() As String
        If cima Is Nothing Then
            MessageBox.Show("No existen datos para mostrar.")
        End If

        Dim valor As Integer = cima.Dato
        cima = cima.Siguiente
        NodeCount -= 1
        Return valor.ToString()
    End Function

    Public Function Peek() As String
        If cima Is Nothing Then
            MessageBox.Show("El stack está vacío.")
            Return ""
        End If
        Return cima.Dato.ToString()
    End Function

    Public Function IsEmpty() As Boolean
        Return cima Is Nothing
    End Function

    Public Function Count() As Integer
        Dim c As Integer = 0
        Dim h As Node = cima
        While h IsNot Nothing
            c += 1
            h = h.Siguiente
        End While
        Return c
    End Function

    Public Overrides Function ToString() As String
        Dim c As Node = cima
        Dim r As String = ""
        While c IsNot Nothing
            r += c.Dato & " "
            c = c.Siguiente
        End While
        Return r
    End Function

    Public Overrides Function ToString2() As String
        Dim h As Node = cima
        Dim r As String = ""
        While h IsNot Nothing
            r += h.ToString2() & Name & " "
            h = h.Siguiente
        End While
        Return r
    End Function
End Class
