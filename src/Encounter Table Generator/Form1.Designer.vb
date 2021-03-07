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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pg_Input = New System.Windows.Forms.TabPage()
        Me.pg_Output = New System.Windows.Forms.TabPage()
        Me.pg_About = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pg_Input)
        Me.TabControl1.Controls.Add(Me.pg_Output)
        Me.TabControl1.Controls.Add(Me.pg_About)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(476, 399)
        Me.TabControl1.TabIndex = 0
        '
        'pg_Input
        '
        Me.pg_Input.Location = New System.Drawing.Point(4, 22)
        Me.pg_Input.Name = "pg_Input"
        Me.pg_Input.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_Input.Size = New System.Drawing.Size(468, 373)
        Me.pg_Input.TabIndex = 0
        Me.pg_Input.Text = "Input"
        Me.pg_Input.UseVisualStyleBackColor = True
        '
        'pg_Output
        '
        Me.pg_Output.Location = New System.Drawing.Point(4, 22)
        Me.pg_Output.Name = "pg_Output"
        Me.pg_Output.Padding = New System.Windows.Forms.Padding(3)
        Me.pg_Output.Size = New System.Drawing.Size(468, 373)
        Me.pg_Output.TabIndex = 1
        Me.pg_Output.Text = "Output"
        Me.pg_Output.UseVisualStyleBackColor = True
        '
        'pg_About
        '
        Me.pg_About.Location = New System.Drawing.Point(4, 22)
        Me.pg_About.Name = "pg_About"
        Me.pg_About.Size = New System.Drawing.Size(468, 373)
        Me.pg_About.TabIndex = 2
        Me.pg_About.Text = "About"
        Me.pg_About.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 399)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(492, 438)
        Me.MinimumSize = New System.Drawing.Size(492, 438)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encounter Table Generator"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents pg_Input As TabPage
    Friend WithEvents pg_Output As TabPage
    Friend WithEvents pg_About As TabPage
End Class
