Imports Newtonsoft.Json.Linq

Public Class frmAbout

    Private Sub frmAbout_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            Label1.Text = "Password Pro v1.6"
            Label2.Text = "©2024 / Mighty Apps Software"
            LinkLabel1.Text = "mreed1972@gmail.com"
        Catch ex As Exception
        End Try
        CheckVersion()





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

    Function CheckVersion()

        Dim client As New Net.WebClient()
        Dim latestReleaseUrl As String = "https://api.github.com/repos/mreed72/Password-Pro-1/releases/latest"
        client.Headers.Add("User-Agent", "Password-Pro-1")

        Try
            Dim jsonResponse As String = client.DownloadString(latestReleaseUrl)

            ' Parse JSON (you may need a JSON library like Newtonsoft.Json for this)
            Dim latestVersion As String = ExtractVersionFromJson(jsonResponse)
            Dim currentVersion As String = "v1.0" ' Your application's current version

            If latestVersion > currentVersion Then
                MsgBox("A new version is available: " & latestVersion)
                Dim xv As String = "https://github.com/mreed72/Password-Pro-1/releases"
                Diagnostics.Process.Start(xv)
                Label3.Text = "NEWER VERSION AVAILABLE!!!"
            Else
                Label3.Text = "Congrats! You have the latest version!"
            End If
        Catch ex As Exception
            MsgBox("Failed to check for updates: " & ex.Message)
        End Try



    End Function




    Function ExtractVersionFromJson(json As String) As String
        Dim jsonObj As JObject = JObject.Parse(json)
        Return jsonObj("tag_name").ToString()
    End Function



End Class