Public Class Form1
     Dim WdList As String

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Application.Exit()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        If MessageBox.Show("Would you like to clear the FAVORITES file?  this will delete all your saved favorites!!!" & vbNewLine & "Click NO to clear the form without deleting FAVs.", "Delete Favorites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim myfile As String = "C:\Mighty Apps\fav.txt"
            My.Computer.FileSystem.DeleteFile(myfile)
            My.Computer.FileSystem.WriteAllText(myfile, "", True)
        End If

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
          word1 = getword(WdList)
          word2 = getword(WdList)

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

          Dim c As Boolean
          c = My.Computer.FileSystem.DirectoryExists("C:\Mighty Apps\")
          If c = False Then
               MessageBox.Show("Data File Error, folder not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
          End If

    End Sub

    Function SetLocation()
        If rb3.Checked = True Then
               WdList = "C:\Mighty Apps\3w.txt"
        ElseIf rb4.Checked = True Then
               WdList = "C:\Mighty Apps\4w.txt"
        ElseIf rb5.Checked = True Then
               WdList = "C:\Mighty Apps\5w.txt"
        ElseIf rb6.Checked = True Then
               WdList = "C:\Mighty Apps\6w.txt"
        ElseIf rb7.Checked = True Then
               WdList = "C:\Mighty Apps\7w.txt"
        ElseIf rb8.Checked = True Then
               WdList = "C:\Mighty Apps\8w.txt"
        ElseIf rb9.Checked = True Then
               WdList = "C:\Mighty Apps\9w.txt"
        ElseIf rb10.Checked = True Then
               WdList = "C:\Mighty Apps\10w.txt"
        ElseIf rb11.Checked = True Then
               WdList = "C:\Mighty Apps\10PW.txt"
        Else
               WdList = "C:\Mighty Apps\3w.txt"
          End If
    End Function

    Function getword(xLOC As String)
        Randomize()
        Dim sr As System.IO.StreamReader
        Dim ri As Integer = 0
        Dim wa As New ArrayList
          If System.IO.File.Exists(xLOC) = True Then
               sr = New IO.StreamReader(xLOC)
               Do While sr.Peek > -1
                    wa.Add(sr.ReadLine)
               Loop
               ri = CInt((wa.Count - 1) * Rnd())
               Return wa(ri)
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

    Private Sub AddToFavoritesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToFavoritesToolStripMenuItem.Click
        Try
            Dim JRT As String
            JRT = dgv.CurrentCell.Value

               Dim myfile As String = "C:\Mighty Apps\fav.txt"
               Dim itxt As New TextBox
               If IO.File.Exists(myfile) Then
                    itxt.Text = IO.File.ReadAllText(myfile)
               End If
               Dim vt As String = vbCrLf & Date.Now & " --- " & JRT & itxt.Text
               My.Computer.FileSystem.WriteAllText(myfile, vt, False)
               itxt.Clear()

          Catch ex As Exception
               MsgBox(ex.Message)
          End Try

    End Sub

     Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
          frmAbout.Show()

     End Sub

     Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
          Try
               Diagnostics.Process.Start("C:\Mighty Apps\fav.txt")
          Catch ex As Exception

          End Try
     End Sub
End Class