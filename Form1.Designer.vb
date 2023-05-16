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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.netPayTextBox = New System.Windows.Forms.TextBox()
        Me.deductionTextBox = New System.Windows.Forms.TextBox()
        Me.taxTextBox = New System.Windows.Forms.TextBox()
        Me.grossPayTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.carCheckBox = New System.Windows.Forms.CheckBox()
        Me.lifeCheckBox = New System.Windows.Forms.CheckBox()
        Me.healthCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.noPensionRadioButton = New System.Windows.Forms.RadioButton()
        Me.privateRadioButton = New System.Windows.Forms.RadioButton()
        Me.ssnitRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.deptTextBox = New System.Windows.Forms.TextBox()
        Me.payRateTextBox = New System.Windows.Forms.TextBox()
        Me.hoursTextBox = New System.Windows.Forms.TextBox()
        Me.nameTextBox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.computeButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.closeButton = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VIEWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ACTIONSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComputeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.netPayTextBox)
        Me.GroupBox1.Controls.Add(Me.deductionTextBox)
        Me.GroupBox1.Controls.Add(Me.taxTextBox)
        Me.GroupBox1.Controls.Add(Me.grossPayTextBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 152)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(215, 197)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'netPayTextBox
        '
        Me.netPayTextBox.Location = New System.Drawing.Point(91, 153)
        Me.netPayTextBox.Name = "netPayTextBox"
        Me.netPayTextBox.ReadOnly = True
        Me.netPayTextBox.Size = New System.Drawing.Size(108, 23)
        Me.netPayTextBox.TabIndex = 3
        Me.netPayTextBox.TabStop = False
        '
        'deductionTextBox
        '
        Me.deductionTextBox.Location = New System.Drawing.Point(91, 117)
        Me.deductionTextBox.Name = "deductionTextBox"
        Me.deductionTextBox.ReadOnly = True
        Me.deductionTextBox.Size = New System.Drawing.Size(108, 23)
        Me.deductionTextBox.TabIndex = 3
        Me.deductionTextBox.TabStop = False
        '
        'taxTextBox
        '
        Me.taxTextBox.Location = New System.Drawing.Point(91, 75)
        Me.taxTextBox.Name = "taxTextBox"
        Me.taxTextBox.ReadOnly = True
        Me.taxTextBox.Size = New System.Drawing.Size(108, 23)
        Me.taxTextBox.TabIndex = 3
        Me.taxTextBox.TabStop = False
        '
        'grossPayTextBox
        '
        Me.grossPayTextBox.Location = New System.Drawing.Point(91, 33)
        Me.grossPayTextBox.Name = "grossPayTextBox"
        Me.grossPayTextBox.ReadOnly = True
        Me.grossPayTextBox.Size = New System.Drawing.Size(108, 23)
        Me.grossPayTextBox.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Deductions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Net Pay"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tax"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Gross Pay"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.carCheckBox)
        Me.GroupBox2.Controls.Add(Me.lifeCheckBox)
        Me.GroupBox2.Controls.Add(Me.healthCheckBox)
        Me.GroupBox2.Location = New System.Drawing.Point(234, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 111)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'carCheckBox
        '
        Me.carCheckBox.AutoSize = True
        Me.carCheckBox.Location = New System.Drawing.Point(6, 77)
        Me.carCheckBox.Name = "carCheckBox"
        Me.carCheckBox.Size = New System.Drawing.Size(98, 19)
        Me.carCheckBox.TabIndex = 1
        Me.carCheckBox.Text = "Car Insurance"
        Me.carCheckBox.UseVisualStyleBackColor = True
        '
        'lifeCheckBox
        '
        Me.lifeCheckBox.AutoSize = True
        Me.lifeCheckBox.Location = New System.Drawing.Point(6, 52)
        Me.lifeCheckBox.Name = "lifeCheckBox"
        Me.lifeCheckBox.Size = New System.Drawing.Size(102, 19)
        Me.lifeCheckBox.TabIndex = 1
        Me.lifeCheckBox.Text = "Life Assurance"
        Me.lifeCheckBox.UseVisualStyleBackColor = True
        '
        'healthCheckBox
        '
        Me.healthCheckBox.AutoSize = True
        Me.healthCheckBox.Location = New System.Drawing.Point(6, 22)
        Me.healthCheckBox.Name = "healthCheckBox"
        Me.healthCheckBox.Size = New System.Drawing.Size(115, 19)
        Me.healthCheckBox.TabIndex = 1
        Me.healthCheckBox.Text = "Health Insurance"
        Me.healthCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.noPensionRadioButton)
        Me.GroupBox3.Controls.Add(Me.privateRadioButton)
        Me.GroupBox3.Controls.Add(Me.ssnitRadioButton)
        Me.GroupBox3.Location = New System.Drawing.Point(234, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(169, 80)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'noPensionRadioButton
        '
        Me.noPensionRadioButton.AutoSize = True
        Me.noPensionRadioButton.Location = New System.Drawing.Point(6, 55)
        Me.noPensionRadioButton.Name = "noPensionRadioButton"
        Me.noPensionRadioButton.Size = New System.Drawing.Size(86, 19)
        Me.noPensionRadioButton.TabIndex = 2
        Me.noPensionRadioButton.Text = "No Pension"
        Me.noPensionRadioButton.UseVisualStyleBackColor = True
        '
        'privateRadioButton
        '
        Me.privateRadioButton.AutoSize = True
        Me.privateRadioButton.Location = New System.Drawing.Point(6, 34)
        Me.privateRadioButton.Name = "privateRadioButton"
        Me.privateRadioButton.Size = New System.Drawing.Size(106, 19)
        Me.privateRadioButton.TabIndex = 2
        Me.privateRadioButton.Text = "Private Pension"
        Me.privateRadioButton.UseVisualStyleBackColor = True
        '
        'ssnitRadioButton
        '
        Me.ssnitRadioButton.AutoSize = True
        Me.ssnitRadioButton.Location = New System.Drawing.Point(6, 13)
        Me.ssnitRadioButton.Name = "ssnitRadioButton"
        Me.ssnitRadioButton.Size = New System.Drawing.Size(100, 19)
        Me.ssnitRadioButton.TabIndex = 2
        Me.ssnitRadioButton.Text = "SSNIT Pension"
        Me.ssnitRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.deptTextBox)
        Me.GroupBox4.Controls.Add(Me.payRateTextBox)
        Me.GroupBox4.Controls.Add(Me.hoursTextBox)
        Me.GroupBox4.Controls.Add(Me.nameTextBox)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(409, 95)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'deptTextBox
        '
        Me.deptTextBox.Location = New System.Drawing.Point(65, 61)
        Me.deptTextBox.Name = "deptTextBox"
        Me.deptTextBox.Size = New System.Drawing.Size(140, 23)
        Me.deptTextBox.TabIndex = 3
        '
        'payRateTextBox
        '
        Me.payRateTextBox.Location = New System.Drawing.Point(291, 64)
        Me.payRateTextBox.Name = "payRateTextBox"
        Me.payRateTextBox.Size = New System.Drawing.Size(97, 23)
        Me.payRateTextBox.TabIndex = 3
        '
        'hoursTextBox
        '
        Me.hoursTextBox.Location = New System.Drawing.Point(291, 29)
        Me.hoursTextBox.Name = "hoursTextBox"
        Me.hoursTextBox.Size = New System.Drawing.Size(97, 23)
        Me.hoursTextBox.TabIndex = 3
        '
        'nameTextBox
        '
        Me.nameTextBox.Location = New System.Drawing.Point(65, 26)
        Me.nameTextBox.Name = "nameTextBox"
        Me.nameTextBox.Size = New System.Drawing.Size(140, 23)
        Me.nameTextBox.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(233, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Pay Rate"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dept"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Hours"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'computeButton
        '
        Me.computeButton.Location = New System.Drawing.Point(25, 372)
        Me.computeButton.Name = "computeButton"
        Me.computeButton.Size = New System.Drawing.Size(105, 44)
        Me.computeButton.TabIndex = 0
        Me.computeButton.Text = "COMPUTE"
        Me.computeButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(164, 372)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(105, 44)
        Me.resetButton.TabIndex = 0
        Me.resetButton.Text = "RESET"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'closeButton
        '
        Me.closeButton.Location = New System.Drawing.Point(298, 372)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Size = New System.Drawing.Size(105, 44)
        Me.closeButton.TabIndex = 0
        Me.closeButton.Text = "CLOSE"
        Me.closeButton.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.VIEWToolStripMenuItem, Me.EDITToolStripMenuItem, Me.ABOUTToolStripMenuItem, Me.ACTIONSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(427, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.OpenToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveAsToolStripMenuItem.Text = "&Save As"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'VIEWToolStripMenuItem
        '
        Me.VIEWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem})
        Me.VIEWToolStripMenuItem.Name = "VIEWToolStripMenuItem"
        Me.VIEWToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.VIEWToolStripMenuItem.Text = "VIEW"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ColorToolStripMenuItem.Text = "&Color"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.FontToolStripMenuItem.Text = "&Font"
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'ACTIONSToolStripMenuItem
        '
        Me.ACTIONSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComputeToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ResetToolStripMenuItem})
        Me.ACTIONSToolStripMenuItem.Name = "ACTIONSToolStripMenuItem"
        Me.ACTIONSToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.ACTIONSToolStripMenuItem.Text = "ACTIONS"
        '
        'ComputeToolStripMenuItem
        '
        Me.ComputeToolStripMenuItem.Name = "ComputeToolStripMenuItem"
        Me.ComputeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.ComputeToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ComputeToolStripMenuItem.Text = "&Compute"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.DeleteToolStripMenuItem.Text = "&Delete"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.ResetToolStripMenuItem.Text = "&Reset"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 428)
        Me.Controls.Add(Me.closeButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.computeButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "PAYROLL"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents netPayTextBox As TextBox
    Friend WithEvents deductionTextBox As TextBox
    Friend WithEvents taxTextBox As TextBox
    Friend WithEvents grossPayTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents carCheckBox As CheckBox
    Friend WithEvents lifeCheckBox As CheckBox
    Friend WithEvents healthCheckBox As CheckBox
    Friend WithEvents privateRadioButton As RadioButton
    Friend WithEvents ssnitRadioButton As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents deptTextBox As TextBox
    Friend WithEvents nameTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents computeButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents closeButton As Button
    Friend WithEvents payRateTextBox As TextBox
    Friend WithEvents hoursTextBox As TextBox
    Friend WithEvents noPensionRadioButton As RadioButton
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VIEWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ACTIONSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComputeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
