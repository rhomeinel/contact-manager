<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newForm8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newForm8))
        Dim C_IDLabel As System.Windows.Forms.Label
        Dim Caller_IDLabel As System.Windows.Forms.Label
        Dim StartTimeLabel As System.Windows.Forms.Label
        Dim EndTimeLabel As System.Windows.Forms.Label
        Dim CallDataLabel As System.Windows.Forms.Label
        Me.Contact_DBDataSet = New ContactManager.Contact_DBDataSet()
        Me.Call_TBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_TBTableAdapter = New ContactManager.Contact_DBDataSetTableAdapters.Call_TBTableAdapter()
        Me.TableAdapterManager = New ContactManager.Contact_DBDataSetTableAdapters.TableAdapterManager()
        Me.Call_TBBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Call_TBBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.C_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Caller_IDTextBox = New System.Windows.Forms.TextBox()
        Me.StartTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EndTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CallDataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        C_IDLabel = New System.Windows.Forms.Label()
        Caller_IDLabel = New System.Windows.Forms.Label()
        StartTimeLabel = New System.Windows.Forms.Label()
        EndTimeLabel = New System.Windows.Forms.Label()
        CallDataLabel = New System.Windows.Forms.Label()
        CType(Me.Contact_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_TBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_TBBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Call_TBBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Contact_DBDataSet
        '
        Me.Contact_DBDataSet.DataSetName = "Contact_DBDataSet"
        Me.Contact_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Call_TBBindingSource
        '
        Me.Call_TBBindingSource.DataMember = "Call_TB"
        Me.Call_TBBindingSource.DataSource = Me.Contact_DBDataSet
        '
        'Call_TBTableAdapter
        '
        Me.Call_TBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Call_TBTableAdapter = Me.Call_TBTableAdapter
        Me.TableAdapterManager.Message_TBTableAdapter = Nothing
        Me.TableAdapterManager.Person_TBTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ContactManager.Contact_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Call_TBBindingNavigator
        '
        Me.Call_TBBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Call_TBBindingNavigator.BindingSource = Me.Call_TBBindingSource
        Me.Call_TBBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Call_TBBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Call_TBBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Call_TBBindingNavigatorSaveItem})
        Me.Call_TBBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Call_TBBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Call_TBBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Call_TBBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Call_TBBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Call_TBBindingNavigator.Name = "Call_TBBindingNavigator"
        Me.Call_TBBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Call_TBBindingNavigator.Size = New System.Drawing.Size(301, 25)
        Me.Call_TBBindingNavigator.TabIndex = 0
        Me.Call_TBBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Call_TBBindingNavigatorSaveItem
        '
        Me.Call_TBBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Call_TBBindingNavigatorSaveItem.Image = CType(resources.GetObject("Call_TBBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Call_TBBindingNavigatorSaveItem.Name = "Call_TBBindingNavigatorSaveItem"
        Me.Call_TBBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Call_TBBindingNavigatorSaveItem.Text = "Save Data"
        '
        'C_IDLabel
        '
        C_IDLabel.AutoSize = True
        C_IDLabel.Location = New System.Drawing.Point(6, 46)
        C_IDLabel.Name = "C_IDLabel"
        C_IDLabel.Size = New System.Drawing.Size(31, 13)
        C_IDLabel.TabIndex = 1
        C_IDLabel.Text = "C ID:"
        AddHandler C_IDLabel.Click, AddressOf Me.C_IDLabel_Click
        '
        'C_IDTextBox
        '
        Me.C_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "C_ID", True))
        Me.C_IDTextBox.Location = New System.Drawing.Point(70, 43)
        Me.C_IDTextBox.Name = "C_IDTextBox"
        Me.C_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.C_IDTextBox.TabIndex = 2
        '
        'Caller_IDLabel
        '
        Caller_IDLabel.AutoSize = True
        Caller_IDLabel.Location = New System.Drawing.Point(6, 72)
        Caller_IDLabel.Name = "Caller_IDLabel"
        Caller_IDLabel.Size = New System.Drawing.Size(50, 13)
        Caller_IDLabel.TabIndex = 3
        Caller_IDLabel.Text = "Caller ID:"
        AddHandler Caller_IDLabel.Click, AddressOf Me.Caller_IDLabel_Click
        '
        'Caller_IDTextBox
        '
        Me.Caller_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Call_TBBindingSource, "Caller_ID", True))
        Me.Caller_IDTextBox.Location = New System.Drawing.Point(70, 69)
        Me.Caller_IDTextBox.Name = "Caller_IDTextBox"
        Me.Caller_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Caller_IDTextBox.TabIndex = 4
        '
        'StartTimeLabel
        '
        StartTimeLabel.AutoSize = True
        StartTimeLabel.Location = New System.Drawing.Point(6, 99)
        StartTimeLabel.Name = "StartTimeLabel"
        StartTimeLabel.Size = New System.Drawing.Size(58, 13)
        StartTimeLabel.TabIndex = 5
        StartTimeLabel.Text = "Start Time:"
        AddHandler StartTimeLabel.Click, AddressOf Me.StartTimeLabel_Click
        '
        'StartTimeDateTimePicker
        '
        Me.StartTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Call_TBBindingSource, "StartTime", True))
        Me.StartTimeDateTimePicker.Location = New System.Drawing.Point(70, 95)
        Me.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker"
        Me.StartTimeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.StartTimeDateTimePicker.TabIndex = 6
        '
        'EndTimeLabel
        '
        EndTimeLabel.AutoSize = True
        EndTimeLabel.Location = New System.Drawing.Point(6, 125)
        EndTimeLabel.Name = "EndTimeLabel"
        EndTimeLabel.Size = New System.Drawing.Size(55, 13)
        EndTimeLabel.TabIndex = 7
        EndTimeLabel.Text = "End Time:"
        AddHandler EndTimeLabel.Click, AddressOf Me.EndTimeLabel_Click
        '
        'EndTimeDateTimePicker
        '
        Me.EndTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Call_TBBindingSource, "EndTime", True))
        Me.EndTimeDateTimePicker.Location = New System.Drawing.Point(70, 121)
        Me.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker"
        Me.EndTimeDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.EndTimeDateTimePicker.TabIndex = 8
        '
        'CallDataLabel
        '
        CallDataLabel.AutoSize = True
        CallDataLabel.Location = New System.Drawing.Point(6, 151)
        CallDataLabel.Name = "CallDataLabel"
        CallDataLabel.Size = New System.Drawing.Size(53, 13)
        CallDataLabel.TabIndex = 9
        CallDataLabel.Text = "Call Data:"
        AddHandler CallDataLabel.Click, AddressOf Me.CallDataLabel_Click
        '
        'CallDataDateTimePicker
        '
        Me.CallDataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Call_TBBindingSource, "CallData", True))
        Me.CallDataDateTimePicker.Location = New System.Drawing.Point(70, 147)
        Me.CallDataDateTimePicker.Name = "CallDataDateTimePicker"
        Me.CallDataDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.CallDataDateTimePicker.TabIndex = 10
        '
        'newForm8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOliveGreen
        Me.ClientSize = New System.Drawing.Size(301, 198)
        Me.Controls.Add(C_IDLabel)
        Me.Controls.Add(Me.C_IDTextBox)
        Me.Controls.Add(Caller_IDLabel)
        Me.Controls.Add(Me.Caller_IDTextBox)
        Me.Controls.Add(StartTimeLabel)
        Me.Controls.Add(Me.StartTimeDateTimePicker)
        Me.Controls.Add(EndTimeLabel)
        Me.Controls.Add(Me.EndTimeDateTimePicker)
        Me.Controls.Add(CallDataLabel)
        Me.Controls.Add(Me.CallDataDateTimePicker)
        Me.Controls.Add(Me.Call_TBBindingNavigator)
        Me.Name = "newForm8"
        Me.Text = "newForm8"
        CType(Me.Contact_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Call_TBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Call_TBBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Call_TBBindingNavigator.ResumeLayout(False)
        Me.Call_TBBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Contact_DBDataSet As ContactManager.Contact_DBDataSet
    Friend WithEvents Call_TBBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Call_TBTableAdapter As ContactManager.Contact_DBDataSetTableAdapters.Call_TBTableAdapter
    Friend WithEvents TableAdapterManager As ContactManager.Contact_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Call_TBBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Call_TBBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents C_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Caller_IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents EndTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents CallDataDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
