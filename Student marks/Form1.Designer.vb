<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        resultBtn = New Button()
        markLabel = New Label()
        txtmark = New TextBox()
        SuspendLayout()
        ' 
        ' resultBtn
        ' 
        resultBtn.Location = New Point(552, 203)
        resultBtn.Name = "resultBtn"
        resultBtn.Size = New Size(75, 23)
        resultBtn.TabIndex = 0
        resultBtn.Text = "Result"
        resultBtn.UseVisualStyleBackColor = True
        ' 
        ' markLabel
        ' 
        markLabel.AutoSize = True
        markLabel.Location = New Point(376, 119)
        markLabel.Name = "markLabel"
        markLabel.Size = New Size(34, 15)
        markLabel.TabIndex = 1
        markLabel.Text = "Mark"
        ' 
        ' txtmark
        ' 
        txtmark.Location = New Point(552, 119)
        txtmark.Name = "txtmark"
        txtmark.Size = New Size(100, 23)
        txtmark.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtmark)
        Controls.Add(markLabel)
        Controls.Add(resultBtn)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents resultBtn As Button
    Friend WithEvents markLabel As Label
    Friend WithEvents txtmark As TextBox
End Class
