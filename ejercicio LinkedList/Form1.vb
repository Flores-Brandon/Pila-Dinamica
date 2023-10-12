Partial Public Class Form1
    Inherits Form
    Private List1 As LinkedList

    Public Sub New()
        InitializeComponent()
        List1 = New LinkedList()
    End Sub

    Private Sub Crearnodo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub StringToListBox(dataArray As String(), list1 As Label)
        list1.Text = String.Empty
        For i As Integer = 0 To dataArray.Length - 1
            If dataArray(i) Is Nothing Then
                MessageBox.Show("Item array is null")
                Continue For
            End If
            list1.Text = dataArray(i)
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnCrear_Click_1(sender As Object, e As EventArgs) Handles btnCrear.Click
        List1.Push(Integer.Parse(txtDato.Text))
        Label2.Text = List1.ToString()
        txtDato.Clear()
        txtDato.Focus()
        lblCima.Text = ""
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        List1.Pop()
        Label2.Text = List1.ToString()
        lblCima.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lblCima.Text = "" Then
            lblCima.Text = "Cima = " & List1.Peek()
        Else
            lblCima.Text = ""
        End If
    End Sub
End Class
