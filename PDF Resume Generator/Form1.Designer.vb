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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.generate_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.filename = New System.Windows.Forms.Label()
        Me.fullname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(456, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PDF Resume Generator"
        '
        'generate_btn
        '
        Me.generate_btn.Location = New System.Drawing.Point(120, 209)
        Me.generate_btn.Name = "generate_btn"
        Me.generate_btn.Size = New System.Drawing.Size(221, 48)
        Me.generate_btn.TabIndex = 1
        Me.generate_btn.Text = "Generate Resume"
        Me.generate_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 35)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "File Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 35)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Full Name:"
        '
        'filename
        '
        Me.filename.AutoSize = True
        Me.filename.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.filename.Location = New System.Drawing.Point(149, 96)
        Me.filename.Name = "filename"
        Me.filename.Size = New System.Drawing.Size(145, 35)
        Me.filename.TabIndex = 4
        Me.filename.Text = "Resume.pdf"
        '
        'fullname
        '
        Me.fullname.AutoSize = True
        Me.fullname.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fullname.Location = New System.Drawing.Point(149, 136)
        Me.fullname.Name = "fullname"
        Me.fullname.Size = New System.Drawing.Size(127, 35)
        Me.fullname.TabIndex = 5
        Me.fullname.Text = "Full Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 297)
        Me.Controls.Add(Me.fullname)
        Me.Controls.Add(Me.filename)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.generate_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents generate_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents filename As Label
    Friend WithEvents fullname As Label
End Class
