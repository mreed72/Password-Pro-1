Public Class Form1
    Dim FL As String = My.Application.Info.DirectoryPath & "\Data\fav.txt"

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'CLEAR
        Try
            labWordCount.Text = "Character Count: "
            txResults.Clear()
            dgv.Rows.Clear()
            txPrefix.Clear()
            cbUpper.Checked = False
            cbLower.Checked = False
            cbSymbol.Checked = False
            cbNumber.Checked = False
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'CALCULATE
        SetLocation()
        Dim PrFix As String = txPrefix.Text
        Dim word1, word2 As String
        word1 = getword(My.Settings.WdList)
        word2 = getword(My.Settings.WdList)

        Dim enu As Integer
        If rbA1.Checked = True Then
            enu = 1
        ElseIf rbA2.Checked = True Then
            enu = 2
        ElseIf rbA3.Checked = True Then
            enu = 3
        ElseIf rbA4.Checked = True Then
            enu = 4
        ElseIf rbA5.Checked = True Then
            enu = 5
        Else
            enu = 1
        End If

        txResults.Text = PrFix & word1 & word2 & GRn(enu) & GRz(1)
        Clipboard.SetText(txResults.Text)
        dgv.Rows.Add(txResults.Text)
        labWordCount.Text = "Character Count: " & txResults.Text.Count & " chars."
        cbUpper.Checked = True
        cbLower.Checked = True
        cbSymbol.Checked = True
        cbNumber.Checked = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
          Me.Text = "Password Pro"

        My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\3w.txt"
        My.Settings.Save()

    End Sub

    Function SetLocation()
        If rb3.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\3w.txt"
        ElseIf rb4.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\4w.txt"
        ElseIf rb5.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\5w.txt"
        ElseIf rb6.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\6w.txt"
        ElseIf rb7.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\7w.txt"
        ElseIf rb8.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\8w.txt"
        ElseIf rb9.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\9w.txt"
        ElseIf rb10.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\10w.txt"
        ElseIf rb11.Checked = True Then
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\10PW.txt"
        Else
            My.Settings.WdList = My.Application.Info.DirectoryPath & "\Data\3w.txt"
        End If
        My.Settings.Save()
    End Function

    Function getword(xLOC As String)
        Randomize()
        Dim sr As System.IO.StreamReader
        Dim ri As Integer = 0
        Dim wa As New ArrayList
        If System.IO.File.Exists(xLOC) = True Then 'x4 is location of text file
            sr = New IO.StreamReader(xLOC)
            Do While sr.Peek > -1
                wa.Add(sr.ReadLine)
            Loop
            ri = CInt((wa.Count - 1) * Rnd())
            Return wa(ri) 'The random word, use as needed.
            sr.Close()
        Else
            sr.Close()
            MsgBox("Error attempting to open Word list")
        End If
    End Function

    Function GRn(ByRef length As Integer) As String
        Randomize()
        Dim ac As String
        ac = "123456789"
        Dim i As Integer
        For i = 1 To length
            GRn = GRn & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
        Next
    End Function

    Function GRz(ByRef length As Integer) As String
        Randomize()
        Dim ac As String
        ac = "@#$%"
        Dim i As Integer
        For i = 1 To length
            GRz = GRz & Mid(ac, Int(Rnd() * Len(ac) + 1), 1)
        Next
    End Function

    Function FWE(msg As String)
        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(FL, True)
        file.WriteLine(msg)
        file.Close()
    End Function

    Private Sub AddToFavoritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToFavoritesToolStripMenuItem.Click
        Try
            Dim JRT As String
            JRT = dgv.CurrentCell.Value
            FWE(JRT)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Diagnostics.Process.Start(FL)

    End Sub

     Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
          frmAbout.Show()

     End Sub
End Class