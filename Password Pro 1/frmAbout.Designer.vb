<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
          Me.PictureBox1 = New System.Windows.Forms.PictureBox()
          Me.Label1 = New System.Windows.Forms.Label()
          Me.Label2 = New System.Windows.Forms.Label()
          Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
          Me.Button1 = New System.Windows.Forms.Button()
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
          Me.SuspendLayout()
          '
          'PictureBox1
          '
          Me.PictureBox1.Image = Global.Password_Pro_1.My.Resources.Resources.LogoIcon
          Me.PictureBox1.Location = New System.Drawing.Point(57, 12)
          Me.PictureBox1.Name = "PictureBox1"
          Me.PictureBox1.Size = New System.Drawing.Size(169, 154)
          Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
          Me.PictureBox1.TabIndex = 0
          Me.PictureBox1.TabStop = False
          '
          'Label1
          '
          Me.Label1.AutoSize = True
          Me.Label1.Location = New System.Drawing.Point(12, 177)
          Me.Label1.Name = "Label1"
          Me.Label1.Size = New System.Drawing.Size(39, 13)
          Me.Label1.TabIndex = 1
          Me.Label1.Text = "Label1"
          '
          'Label2
          '
          Me.Label2.AutoSize = True
          Me.Label2.Location = New System.Drawing.Point(12, 202)
          Me.Label2.Name = "Label2"
          Me.Label2.Size = New System.Drawing.Size(39, 13)
          Me.Label2.TabIndex = 2
          Me.Label2.Text = "Label2"
          '
          'LinkLabel1
          '
          Me.LinkLabel1.AutoSize = True
          Me.LinkLabel1.Location = New System.Drawing.Point(12, 227)
          Me.LinkLabel1.Name = "LinkLabel1"
          Me.LinkLabel1.Size = New System.Drawing.Size(59, 13)
          Me.LinkLabel1.TabIndex = 3
          Me.LinkLabel1.TabStop = True
          Me.LinkLabel1.Text = "LinkLabel1"
          '
          'Button1
          '
          Me.Button1.Image = Global.Password_Pro_1.My.Resources.Resources.weIMAGE058
          Me.Button1.Location = New System.Drawing.Point(237, 12)
          Me.Button1.Name = "Button1"
          Me.Button1.Size = New System.Drawing.Size(35, 43)
          Me.Button1.TabIndex = 4
          Me.Button1.UseVisualStyleBackColor = True
          '
          'frmAbout
          '
          Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
          Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
          Me.ClientSize = New System.Drawing.Size(284, 261)
          Me.Controls.Add(Me.Button1)
          Me.Controls.Add(Me.LinkLabel1)
          Me.Controls.Add(Me.Label2)
          Me.Controls.Add(Me.Label1)
          Me.Controls.Add(Me.PictureBox1)
          Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
          Me.Name = "frmAbout"
          Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
          Me.Text = "About"
          CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
          Me.ResumeLayout(False)
          Me.PerformLayout()

     End Sub
     Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
     Friend WithEvents Label1 As System.Windows.Forms.Label
     Friend WithEvents Label2 As System.Windows.Forms.Label
     Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
     Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
