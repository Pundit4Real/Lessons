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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnMsBox = New System.Windows.Forms.Button()
        Me.btnVariable = New System.Windows.Forms.Button()
        Me.btnDataTypes = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lbFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lbGender = New System.Windows.Forms.Label()
        Me.lbLastName = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnStart.Location = New System.Drawing.Point(71, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(163, 123)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Press Here"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnMsBox
        '
        Me.btnMsBox.Location = New System.Drawing.Point(797, 12)
        Me.btnMsBox.Name = "btnMsBox"
        Me.btnMsBox.Size = New System.Drawing.Size(165, 123)
        Me.btnMsBox.TabIndex = 1
        Me.btnMsBox.Text = "Different box to show data"
        Me.btnMsBox.UseVisualStyleBackColor = True
        '
        'btnVariable
        '
        Me.btnVariable.Location = New System.Drawing.Point(627, 12)
        Me.btnVariable.Name = "btnVariable"
        Me.btnVariable.Size = New System.Drawing.Size(164, 123)
        Me.btnVariable.TabIndex = 2
        Me.btnVariable.Text = "Variable Demonstrations"
        Me.btnVariable.UseVisualStyleBackColor = True
        '
        'btnDataTypes
        '
        Me.btnDataTypes.Location = New System.Drawing.Point(249, 12)
        Me.btnDataTypes.Name = "btnDataTypes"
        Me.btnDataTypes.Size = New System.Drawing.Size(158, 126)
        Me.btnDataTypes.TabIndex = 3
        Me.btnDataTypes.Text = "Data Types in VB.net"
        Me.btnDataTypes.UseVisualStyleBackColor = True
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(430, 12)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(175, 123)
        Me.btnInput.TabIndex = 4
        Me.btnInput.Text = "Simple way to get Input from the user"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'lbFirstName
        '
        Me.lbFirstName.AutoSize = True
        Me.lbFirstName.Location = New System.Drawing.Point(67, 374)
        Me.lbFirstName.Name = "lbFirstName"
        Me.lbFirstName.Size = New System.Drawing.Size(86, 20)
        Me.lbFirstName.TabIndex = 5
        Me.lbFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(189, 348)
        Me.txtFirstName.Multiline = True
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(218, 44)
        Me.txtFirstName.TabIndex = 6
        '
        'lbGender
        '
        Me.lbGender.AutoSize = True
        Me.lbGender.Location = New System.Drawing.Point(67, 550)
        Me.lbGender.Name = "lbGender"
        Me.lbGender.Size = New System.Drawing.Size(63, 20)
        Me.lbGender.TabIndex = 7
        Me.lbGender.Text = "Gender"
        '
        'lbLastName
        '
        Me.lbLastName.AutoSize = True
        Me.lbLastName.Location = New System.Drawing.Point(67, 459)
        Me.lbLastName.Name = "lbLastName"
        Me.lbLastName.Size = New System.Drawing.Size(86, 20)
        Me.lbLastName.TabIndex = 8
        Me.lbLastName.Text = "Last Name"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(189, 532)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(218, 44)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(189, 435)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(218, 44)
        Me.TextBox2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(502, 518)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 73)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 673)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbLastName)
        Me.Controls.Add(Me.lbGender)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lbFirstName)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.btnDataTypes)
        Me.Controls.Add(Me.btnVariable)
        Me.Controls.Add(Me.btnMsBox)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnMsBox As Button
    Friend WithEvents btnVariable As Button
    Friend WithEvents btnDataTypes As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents lbFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lbGender As Label
    Friend WithEvents lbLastName As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
