Public Class frmAbout

     Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
          Try
               Dim xv As String = My.Application.Info.Version.ToString
               Label1.Text = "Password Pro v" & xv
               Label2.Text = "© 2019 - Mighty Apps Software"
               LinkLabel1.Text = "mreed1972@gmail.com"
          Catch ex As Exception
          End Try
     End Sub

     Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
          Try
               Dim xc As String = "mailto:mreed1972@gmail.com"
               Diagnostics.Process.Start(xc)
          Catch ex As Exception
          End Try

     End Sub

     Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
          Me.Close()

     End Sub
End Class