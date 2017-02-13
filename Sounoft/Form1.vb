Imports MaterialSkin

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Skin
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.DARK
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        'INTO > dem
        dem()
    End Sub

    Private Sub SélectionnerUnNomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SélectionnerUnNomToolStripMenuItem.Click
        Dim OSD As New OpenFileDialog
        OSD.Filter = "Wav sound (.wav)|*.wav"
        If OSD.ShowDialog = DialogResult.OK Then
            Dim Change As String() = My.Settings.VarBut.Split("-SOUNOFT-")
            My.Settings.VarBut = My.Settings.VarBut.Replace(Change(1), OSD.FileName)
        End If
    End Sub

    Sub dem()
        Dim Loadm As String() = My.Settings.VarBut.Split("-SOUNOFT-")
        ToolStripTextBox1.Text = Loadm(2)
        MaterialRaisedButton1.Text = Loadm(2)
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        Try
            Dim Loadm As String() = My.Settings.VarBut.Split("-SOUNOFT-")
            Dim son = New System.Media.SoundPlayer(Loadm(1))
            son.Play()
        Catch ex As Exception
            Dim Loadm As String() = My.Settings.VarBut.Split("-SOUNOFT-")
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripTextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ToolStripTextBox1.KeyUp
        Dim Loadm As String() = My.Settings.VarBut.Split("-SOUNOFT-")
        My.Settings.VarBut = My.Settings.VarBut.Replace(Loadm(2), ToolStripTextBox1.Text)
        MaterialRaisedButton1.Text = Loadm(2)
    End Sub

    Private Sub LireLaudioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LireLaudioToolStripMenuItem.Click
        Try
            Dim Loadm As String() = My.Settings.VarBut.Split("-SOUNOFT-")
            Dim son = New System.Media.SoundPlayer(Loadm(1))
            son.Play()
        Catch ex As Exception
            Dim Loadm As String() = My.Settings.VarBut.Split("-SOUNOFT-")
            MsgBox(ex.Message)
        End Try
    End Sub
End Class