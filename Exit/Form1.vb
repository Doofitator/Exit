Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width
        Me.Top = 0
        Me.Left = 0

        Dim x As Integer
        Dim y As Integer
        x = Screen.PrimaryScreen.WorkingArea.Width - TabHolder.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - TabHolder.Height
        TabHolder.Location = New Point(x, y)
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Timer1_Tick(sender, e)
    End Sub

    Private Sub Quit_Active(sender As Object, e As EventArgs) Handles Quit.GotFocus
        TabHolder.Select()
    End Sub

    Private Sub Quit_KeyPress(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles TabHolder.KeyDown

        Console.WriteLine(e.KeyCode)

        If e.KeyCode = Keys.KeyCode.E Then 'if you hit 'e', exit.
            Application.Exit()
        End If

    End Sub

    Public Function MouseIsOverControl(ByVal c As Control) As Boolean
        Return c.ClientRectangle.Contains(c.PointToClient(Control.MousePosition))
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim screenH As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Dim screenW As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim no1 As Integer = CInt(Math.Ceiling(Rnd() * 99)) + 1
        Dim no2 As Integer = CInt(Math.Ceiling(Rnd() * 99)) + 1
        If MouseIsOverControl(Quit) Then
            Quit.Location = New Point(screenW - ((no1 / 100) * screenW), screenH - ((no2 / 100) * screenH))
        End If
    End Sub
End Class
