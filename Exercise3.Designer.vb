<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise3
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
        OkButton = New Button()
        EndButton = New Button()
        ResultLabel = New Label()
        NumTextBox = New TextBox()
        NumLabel = New Label()
        SuspendLayout()
        ' 
        ' OkButton
        ' 
        OkButton.BackColor = Color.Salmon
        OkButton.Location = New Point(120, 138)
        OkButton.Name = "OkButton"
        OkButton.Size = New Size(117, 43)
        OkButton.TabIndex = 0
        OkButton.Text = "تایید"
        OkButton.UseVisualStyleBackColor = False
        ' 
        ' EndButton
        ' 
        EndButton.BackColor = Color.Salmon
        EndButton.Location = New Point(244, 223)
        EndButton.Name = "EndButton"
        EndButton.Size = New Size(80, 30)
        EndButton.TabIndex = 1
        EndButton.Text = "خروج"
        EndButton.UseVisualStyleBackColor = False
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        ResultLabel.ForeColor = Color.DarkRed
        ResultLabel.Location = New Point(176, 42)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(0, 33)
        ResultLabel.TabIndex = 2
        ' 
        ' NumTextBox
        ' 
        NumTextBox.Location = New Point(120, 92)
        NumTextBox.Multiline = True
        NumTextBox.Name = "NumTextBox"
        NumTextBox.Size = New Size(117, 40)
        NumTextBox.TabIndex = 3
        ' 
        ' NumLabel
        ' 
        NumLabel.AutoSize = True
        NumLabel.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        NumLabel.ForeColor = Color.Red
        NumLabel.Location = New Point(42, 101)
        NumLabel.Name = "NumLabel"
        NumLabel.Size = New Size(47, 21)
        NumLabel.TabIndex = 4
        NumLabel.Text = "عدد  :"
        ' 
        ' Exercise3
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RosyBrown
        ClientSize = New Size(357, 286)
        Controls.Add(NumLabel)
        Controls.Add(NumTextBox)
        Controls.Add(ResultLabel)
        Controls.Add(EndButton)
        Controls.Add(OkButton)
        Name = "Exercise3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "مثبت و منفی"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OkButton As Button
    Friend WithEvents EndButton As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents NumTextBox As TextBox
    Friend WithEvents NumLabel As Label
End Class
