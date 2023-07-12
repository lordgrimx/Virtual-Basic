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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.lstOccupation = New System.Windows.Forms.ListBox()
        Me.intNumber1 = New System.Windows.Forms.TextBox()
        Me.intNumber2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnStart.Location = New System.Drawing.Point(12, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(127, 81)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Press Here"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Location = New System.Drawing.Point(170, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 81)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Data Type"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtFirstName.Location = New System.Drawing.Point(322, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 22)
        Me.txtFirstName.TabIndex = 2
        Me.txtFirstName.Text = "Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(322, 41)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(200, 22)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.Text = "Surname"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(322, 70)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(100, 22)
        Me.txtGender.TabIndex = 4
        Me.txtGender.Text = "Gender"
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.SystemColors.Info
        Me.btnInput.Location = New System.Drawing.Point(681, 11)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(107, 81)
        Me.btnInput.TabIndex = 5
        Me.btnInput.Text = "Send Input"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'lstOccupation
        '
        Me.lstOccupation.FormattingEnabled = True
        Me.lstOccupation.ItemHeight = 16
        Me.lstOccupation.Items.AddRange(New Object() {"Preparition Year", "1st Year", "2nd Year", "3th Year", "4th Year", "5th Year (Doctor-Dentist)", "6th Year(Doctor)"})
        Me.lstOccupation.Location = New System.Drawing.Point(541, 12)
        Me.lstOccupation.Name = "lstOccupation"
        Me.lstOccupation.Size = New System.Drawing.Size(120, 116)
        Me.lstOccupation.TabIndex = 6
        '
        'intNumber1
        '
        Me.intNumber1.Location = New System.Drawing.Point(80, 109)
        Me.intNumber1.Name = "intNumber1"
        Me.intNumber1.Size = New System.Drawing.Size(100, 22)
        Me.intNumber1.TabIndex = 7
        '
        'intNumber2
        '
        Me.intNumber2.Location = New System.Drawing.Point(80, 136)
        Me.intNumber2.Name = "intNumber2"
        Me.intNumber2.Size = New System.Drawing.Size(100, 22)
        Me.intNumber2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Number 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Number 2"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(197, 106)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(93, 52)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intNumber2)
        Me.Controls.Add(Me.intNumber1)
        Me.Controls.Add(Me.lstOccupation)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents lstOccupation As ListBox
    Friend WithEvents intNumber1 As TextBox
    Friend WithEvents intNumber2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
End Class
