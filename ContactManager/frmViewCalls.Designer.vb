<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewCalls
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
        Me.txtcCaller = New System.Windows.Forms.TextBox()
        Me.txtcCallerID = New System.Windows.Forms.TextBox()
        Me.txtStartTime = New System.Windows.Forms.TextBox()
        Me.txtEndTime = New System.Windows.Forms.TextBox()
        Me.txtcDate = New System.Windows.Forms.TextBox()
        Me.txtCaller = New System.Windows.Forms.Label()
        Me.txtCallerID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtcCaller
        '
        Me.txtcCaller.Location = New System.Drawing.Point(66, 31)
        Me.txtcCaller.Name = "txtcCaller"
        Me.txtcCaller.Size = New System.Drawing.Size(144, 20)
        Me.txtcCaller.TabIndex = 0
        '
        'txtcCallerID
        '
        Me.txtcCallerID.Location = New System.Drawing.Point(85, 67)
        Me.txtcCallerID.Name = "txtcCallerID"
        Me.txtcCallerID.Size = New System.Drawing.Size(125, 20)
        Me.txtcCallerID.TabIndex = 1
        '
        'txtStartTime
        '
        Me.txtStartTime.Location = New System.Drawing.Point(85, 99)
        Me.txtStartTime.Name = "txtStartTime"
        Me.txtStartTime.Size = New System.Drawing.Size(125, 20)
        Me.txtStartTime.TabIndex = 2
        '
        'txtEndTime
        '
        Me.txtEndTime.Location = New System.Drawing.Point(85, 134)
        Me.txtEndTime.Name = "txtEndTime"
        Me.txtEndTime.Size = New System.Drawing.Size(125, 20)
        Me.txtEndTime.TabIndex = 3
        '
        'txtcDate
        '
        Me.txtcDate.Location = New System.Drawing.Point(66, 169)
        Me.txtcDate.Name = "txtcDate"
        Me.txtcDate.Size = New System.Drawing.Size(144, 20)
        Me.txtcDate.TabIndex = 4
        '
        'txtCaller
        '
        Me.txtCaller.AutoSize = True
        Me.txtCaller.Location = New System.Drawing.Point(27, 34)
        Me.txtCaller.Name = "txtCaller"
        Me.txtCaller.Size = New System.Drawing.Size(33, 13)
        Me.txtCaller.TabIndex = 5
        Me.txtCaller.Text = "Caller"
        '
        'txtCallerID
        '
        Me.txtCallerID.AutoSize = True
        Me.txtCallerID.Location = New System.Drawing.Point(27, 67)
        Me.txtCallerID.Name = "txtCallerID"
        Me.txtCallerID.Size = New System.Drawing.Size(47, 13)
        Me.txtCallerID.TabIndex = 6
        Me.txtCallerID.Text = "Caller ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Start Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "End Time"
        '
        'txtDate
        '
        Me.txtDate.AutoSize = True
        Me.txtDate.Location = New System.Drawing.Point(27, 172)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(30, 13)
        Me.txtDate.TabIndex = 9
        Me.txtDate.Text = "Date"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmViewCalls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(314, 318)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCallerID)
        Me.Controls.Add(Me.txtCaller)
        Me.Controls.Add(Me.txtcDate)
        Me.Controls.Add(Me.txtEndTime)
        Me.Controls.Add(Me.txtStartTime)
        Me.Controls.Add(Me.txtcCallerID)
        Me.Controls.Add(Me.txtcCaller)
        Me.Name = "frmViewCalls"
        Me.Text = "View Calls"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtcCaller As System.Windows.Forms.TextBox
    Friend WithEvents txtcCallerID As System.Windows.Forms.TextBox
    Friend WithEvents txtStartTime As System.Windows.Forms.TextBox
    Friend WithEvents txtEndTime As System.Windows.Forms.TextBox
    Friend WithEvents txtcDate As System.Windows.Forms.TextBox
    Friend WithEvents txtCaller As System.Windows.Forms.Label
    Friend WithEvents txtCallerID As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
