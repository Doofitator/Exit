<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Quit = New System.Windows.Forms.Button()
        Me.TabHolder = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Quit
        '
        Me.Quit.Location = New System.Drawing.Point(42, 30)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(75, 23)
        Me.Quit.TabIndex = 1
        Me.Quit.Text = "Click to exit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'TabHolder
        '
        Me.TabHolder.AutoSize = True
        Me.TabHolder.Location = New System.Drawing.Point(220, 186)
        Me.TabHolder.Name = "TabHolder"
        Me.TabHolder.Size = New System.Drawing.Size(89, 17)
        Me.TabHolder.TabIndex = 0
        Me.TabHolder.TabStop = True
        Me.TabHolder.Text = "You can't exit"
        Me.TabHolder.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabHolder)
        Me.Controls.Add(Me.Quit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Exit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Quit As Button
    Friend WithEvents TabHolder As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
