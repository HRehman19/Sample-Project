<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invoice_Purchase
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
        Me.Tab_Control = New System.Windows.Forms.TabControl()
        Me.TP_Add = New System.Windows.Forms.TabPage()
        Me.Btn_Clrall = New System.Windows.Forms.Button()
        Me.GB_Realize = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_SName = New CRMS.CharMinusSpaceTB()
        Me.TB_CName = New CRMS.CharMinusSpaceTB()
        Me.Lbl_InvCred = New System.Windows.Forms.Label()
        Me.TB_RCredit = New CRMS.MathsTB()
        Me.Lbl_RBalance = New System.Windows.Forms.Label()
        Me.TB_TBalance = New CRMS.MathsTB()
        Me.Lbl_GRN = New System.Windows.Forms.Label()
        Me.TB_InvID = New CRMS.IntegerTB()
        Me.Lbl_PCred = New System.Windows.Forms.Label()
        Me.TB_PCred = New CRMS.MathsTB()
        Me.Lbl_PNo = New System.Windows.Forms.Label()
        Me.GB_PmntMethod = New System.Windows.Forms.GroupBox()
        Me.RB_CshNChqNCred = New System.Windows.Forms.RadioButton()
        Me.RB_ChqNCred = New System.Windows.Forms.RadioButton()
        Me.RB_CashNCred = New System.Windows.Forms.RadioButton()
        Me.RB_CashNChq = New System.Windows.Forms.RadioButton()
        Me.RB_Cheque = New System.Windows.Forms.RadioButton()
        Me.RB_Cash = New System.Windows.Forms.RadioButton()
        Me.Lbl_Chq_Paid = New System.Windows.Forms.Label()
        Me.DTP_PDD = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DTP_PDD = New System.Windows.Forms.Label()
        Me.DTP_ChqDate = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_BN = New System.Windows.Forms.Label()
        Me.Lbl_CD = New System.Windows.Forms.Label()
        Me.Lbl_CN = New System.Windows.Forms.Label()
        Me.Lbl_RN = New System.Windows.Forms.Label()
        Me.Lbl_AP = New System.Windows.Forms.Label()
        Me.Lbl_GRNTA = New System.Windows.Forms.Label()
        Me.TB_PmntID = New CRMS.IntegerTB()
        Me.TB_ChqPad = New CRMS.MathsTB()
        Me.TB_AmntPad = New CRMS.MathsTB()
        Me.TB_GRNTA = New CRMS.MathsTB()
        Me.TB_BnkNam = New CRMS.CharMinusSpaceTB()
        Me.TB_ChqNo = New CRMS.IntegerTB()
        Me.TB_RecName = New CRMS.CharMinusSpaceTB()
        Me.GB_GRN_Selection = New System.Windows.Forms.GroupBox()
        Me.TB_DGV_Filter = New System.Windows.Forms.TextBox()
        Me.RB_BySup = New System.Windows.Forms.RadioButton()
        Me.RB_ByInvNo = New System.Windows.Forms.RadioButton()
        Me.RB_ByGRN = New System.Windows.Forms.RadioButton()
        Me.DGV_Realize = New System.Windows.Forms.DataGridView()
        Me.DGV_Realize_TB_SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_GRNNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_Invoice_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_PNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_GRNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_InvoiceCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_TB_TBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Realize_Btn_Realize = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.TP_Update = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.UD_GB_Realize = New System.Windows.Forms.GroupBox()
        Me.UD_Lbl_PCred = New System.Windows.Forms.Label()
        Me.UD_TB_TBalance = New CRMS.MathsTB()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UD_TB_SName = New CRMS.CharMinusSpaceTB()
        Me.UD_TB_CName = New CRMS.CharMinusSpaceTB()
        Me.UD_Lbl_GRN = New System.Windows.Forms.Label()
        Me.UD_TB_InvID = New CRMS.IntegerTB()
        Me.UD_Lbl_InvCred = New System.Windows.Forms.Label()
        Me.UD_Lbl_RBalance = New System.Windows.Forms.Label()
        Me.UD_TB_PCred = New CRMS.MathsTB()
        Me.UD_Lbl_PNo = New System.Windows.Forms.Label()
        Me.UD_GB_PmntMethod = New System.Windows.Forms.GroupBox()
        Me.UD_RB_CshNChqNCred = New System.Windows.Forms.RadioButton()
        Me.UD_RB_ChqNCred = New System.Windows.Forms.RadioButton()
        Me.UD_RB_CashNCred = New System.Windows.Forms.RadioButton()
        Me.UD_RB_CashNChq = New System.Windows.Forms.RadioButton()
        Me.UD_RB_Cheque = New System.Windows.Forms.RadioButton()
        Me.UD_RB_Cash = New System.Windows.Forms.RadioButton()
        Me.UD_Lbl_Chq_Paid = New System.Windows.Forms.Label()
        Me.UD_DTP_PDD = New System.Windows.Forms.DateTimePicker()
        Me.UD_Lbl_DTP_PDD = New System.Windows.Forms.Label()
        Me.UD_DTP_ChqDate = New System.Windows.Forms.DateTimePicker()
        Me.UD_Lbl_BN = New System.Windows.Forms.Label()
        Me.UD_Lbl_CD = New System.Windows.Forms.Label()
        Me.UD_Lbl_CN = New System.Windows.Forms.Label()
        Me.UD_Lbl_RN = New System.Windows.Forms.Label()
        Me.UD_Lbl_AP = New System.Windows.Forms.Label()
        Me.UD_Lbl_GRNTA = New System.Windows.Forms.Label()
        Me.UD_TB_PmntID = New CRMS.IntegerTB()
        Me.UD_TB_ChqPad = New CRMS.MathsTB()
        Me.UD_TB_RCredit = New CRMS.MathsTB()
        Me.UD_TB_AmntPad = New CRMS.MathsTB()
        Me.UD_TB_GRNTA = New CRMS.MathsTB()
        Me.UD_TB_BnkNam = New CRMS.CharMinusSpaceTB()
        Me.UD_TB_ChqNo = New CRMS.IntegerTB()
        Me.UD_TB_RecName = New CRMS.CharMinusSpaceTB()
        Me.UD_GB_GRN_Selection = New System.Windows.Forms.GroupBox()
        Me.UD_New_DGV_Realize = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_New_DGV_Realize_Btn_realize = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UD_TB_DGV_Filter = New System.Windows.Forms.TextBox()
        Me.UD_RB_BySup = New System.Windows.Forms.RadioButton()
        Me.UD_RB_ByInvNo = New System.Windows.Forms.RadioButton()
        Me.UD_RB_ByGRN = New System.Windows.Forms.RadioButton()
        Me.UD_DGV_Realize = New System.Windows.Forms.DataGridView()
        Me.UD_DGV_Realize_TB_SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_GRNNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_Invoice_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_PNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_GRNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_InvoiceCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_TB_RBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Realize_Btn_Realize = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UD_Btn_Clrall = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.TP_Delete = New System.Windows.Forms.TabPage()
        Me.D_Lbl_Credit_Status = New System.Windows.Forms.Label()
        Me.D_GB_Realize = New System.Windows.Forms.GroupBox()
        Me.D_TB_TBalance = New CRMS.MathsTB()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.D_TB_PCred = New CRMS.MathsTB()
        Me.D_TB_SName = New CRMS.CharMinusSpaceTB()
        Me.D_TB_CName = New CRMS.CharMinusSpaceTB()
        Me.D_TB_RecName = New CRMS.CharMinusSpaceTB()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.D_Lbl_GRN = New System.Windows.Forms.Label()
        Me.D_TB_GRN = New CRMS.IntegerTB()
        Me.D_Lbl_PNo = New System.Windows.Forms.Label()
        Me.D_GB_PmntMethod = New System.Windows.Forms.GroupBox()
        Me.D_RB_CshNChqNCred = New System.Windows.Forms.RadioButton()
        Me.D_RB_ChqNCred = New System.Windows.Forms.RadioButton()
        Me.D_RB_CashNCred = New System.Windows.Forms.RadioButton()
        Me.D_RB_CashNChq = New System.Windows.Forms.RadioButton()
        Me.D_RB_Cheque = New System.Windows.Forms.RadioButton()
        Me.D_RB_Cash = New System.Windows.Forms.RadioButton()
        Me.D_Lbl_Chq_Paid = New System.Windows.Forms.Label()
        Me.D_Lbl_RCredit = New System.Windows.Forms.Label()
        Me.D_DTP_PDD = New System.Windows.Forms.DateTimePicker()
        Me.D_Lbl_DTP_PDD = New System.Windows.Forms.Label()
        Me.D_DTP_ChqDate = New System.Windows.Forms.DateTimePicker()
        Me.D_Lbl_BN = New System.Windows.Forms.Label()
        Me.D_Lbl_CD = New System.Windows.Forms.Label()
        Me.D_Lbl_CN = New System.Windows.Forms.Label()
        Me.D_Lbl_RN = New System.Windows.Forms.Label()
        Me.D_Lbl_AP = New System.Windows.Forms.Label()
        Me.D_Lbl_GRNTA = New System.Windows.Forms.Label()
        Me.D_TB_PNo = New CRMS.IntegerTB()
        Me.D_TB_ChqPad = New CRMS.MathsTB()
        Me.D_TB_RCredit = New CRMS.MathsTB()
        Me.D_TB_AmntPad = New CRMS.MathsTB()
        Me.D_TB_GRNTA = New CRMS.MathsTB()
        Me.D_TB_BnkNam = New CRMS.CharMinusSpaceTB()
        Me.D_TB_ChqNo = New CRMS.IntegerTB()
        Me.D_GB_GRN_Selection = New System.Windows.Forms.GroupBox()
        Me.D_TB_DGV_Filter = New System.Windows.Forms.TextBox()
        Me.D_RB_BySup = New System.Windows.Forms.RadioButton()
        Me.D_RB_ByInvNo = New System.Windows.Forms.RadioButton()
        Me.D_RB_ByGRN = New System.Windows.Forms.RadioButton()
        Me.D_DGV_Realize = New System.Windows.Forms.DataGridView()
        Me.D_DGV_Realize_TB_SNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_GRNNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_Invoice_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_PNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_Company = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_GRNTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_InvoiceCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_TB_RBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Realize_Btn_Realize = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.D_CStatus = New System.Windows.Forms.Label()
        Me.D_Btn_Clrall = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Tab_Control.SuspendLayout()
        Me.TP_Add.SuspendLayout()
        Me.GB_Realize.SuspendLayout()
        Me.GB_PmntMethod.SuspendLayout()
        Me.GB_GRN_Selection.SuspendLayout()
        CType(Me.DGV_Realize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Update.SuspendLayout()
        Me.UD_GB_Realize.SuspendLayout()
        Me.UD_GB_PmntMethod.SuspendLayout()
        Me.UD_GB_GRN_Selection.SuspendLayout()
        CType(Me.UD_New_DGV_Realize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UD_DGV_Realize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_Delete.SuspendLayout()
        Me.D_GB_Realize.SuspendLayout()
        Me.D_GB_PmntMethod.SuspendLayout()
        Me.D_GB_GRN_Selection.SuspendLayout()
        CType(Me.D_DGV_Realize, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tab_Control
        '
        Me.Tab_Control.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.Tab_Control.Controls.Add(Me.TP_Add)
        Me.Tab_Control.Controls.Add(Me.TP_Update)
        Me.Tab_Control.Controls.Add(Me.TP_Delete)
        Me.Tab_Control.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Control.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Tab_Control.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Control.Name = "Tab_Control"
        Me.Tab_Control.SelectedIndex = 0
        Me.Tab_Control.Size = New System.Drawing.Size(897, 592)
        Me.Tab_Control.TabIndex = 1
        '
        'TP_Add
        '
        Me.TP_Add.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Add.Controls.Add(Me.Btn_Clrall)
        Me.TP_Add.Controls.Add(Me.GB_Realize)
        Me.TP_Add.Controls.Add(Me.GB_GRN_Selection)
        Me.TP_Add.Controls.Add(Me.Btn_Submit)
        Me.TP_Add.Location = New System.Drawing.Point(4, 25)
        Me.TP_Add.Name = "TP_Add"
        Me.TP_Add.Size = New System.Drawing.Size(889, 563)
        Me.TP_Add.TabIndex = 2
        Me.TP_Add.Text = "Add Payment"
        '
        'Btn_Clrall
        '
        Me.Btn_Clrall.Location = New System.Drawing.Point(799, 532)
        Me.Btn_Clrall.Name = "Btn_Clrall"
        Me.Btn_Clrall.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clrall.TabIndex = 52
        Me.Btn_Clrall.Text = "Clear All"
        Me.Btn_Clrall.UseVisualStyleBackColor = True
        '
        'GB_Realize
        '
        Me.GB_Realize.Controls.Add(Me.Label3)
        Me.GB_Realize.Controls.Add(Me.Label2)
        Me.GB_Realize.Controls.Add(Me.TB_SName)
        Me.GB_Realize.Controls.Add(Me.TB_CName)
        Me.GB_Realize.Controls.Add(Me.Lbl_InvCred)
        Me.GB_Realize.Controls.Add(Me.TB_RCredit)
        Me.GB_Realize.Controls.Add(Me.Lbl_RBalance)
        Me.GB_Realize.Controls.Add(Me.TB_TBalance)
        Me.GB_Realize.Controls.Add(Me.Lbl_GRN)
        Me.GB_Realize.Controls.Add(Me.TB_InvID)
        Me.GB_Realize.Controls.Add(Me.Lbl_PCred)
        Me.GB_Realize.Controls.Add(Me.TB_PCred)
        Me.GB_Realize.Controls.Add(Me.Lbl_PNo)
        Me.GB_Realize.Controls.Add(Me.GB_PmntMethod)
        Me.GB_Realize.Controls.Add(Me.Lbl_Chq_Paid)
        Me.GB_Realize.Controls.Add(Me.DTP_PDD)
        Me.GB_Realize.Controls.Add(Me.Lbl_DTP_PDD)
        Me.GB_Realize.Controls.Add(Me.DTP_ChqDate)
        Me.GB_Realize.Controls.Add(Me.Lbl_BN)
        Me.GB_Realize.Controls.Add(Me.Lbl_CD)
        Me.GB_Realize.Controls.Add(Me.Lbl_CN)
        Me.GB_Realize.Controls.Add(Me.Lbl_RN)
        Me.GB_Realize.Controls.Add(Me.Lbl_AP)
        Me.GB_Realize.Controls.Add(Me.Lbl_GRNTA)
        Me.GB_Realize.Controls.Add(Me.TB_PmntID)
        Me.GB_Realize.Controls.Add(Me.TB_ChqPad)
        Me.GB_Realize.Controls.Add(Me.TB_AmntPad)
        Me.GB_Realize.Controls.Add(Me.TB_GRNTA)
        Me.GB_Realize.Controls.Add(Me.TB_BnkNam)
        Me.GB_Realize.Controls.Add(Me.TB_ChqNo)
        Me.GB_Realize.Controls.Add(Me.TB_RecName)
        Me.GB_Realize.Location = New System.Drawing.Point(6, 321)
        Me.GB_Realize.Name = "GB_Realize"
        Me.GB_Realize.Size = New System.Drawing.Size(875, 205)
        Me.GB_Realize.TabIndex = 51
        Me.GB_Realize.TabStop = False
        Me.GB_Realize.Text = "Payment"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Company :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(580, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Supplier :"
        '
        'TB_SName
        '
        Me.TB_SName.Enabled = False
        Me.TB_SName.Location = New System.Drawing.Point(703, 73)
        Me.TB_SName.Name = "TB_SName"
        Me.TB_SName.ReadOnly = True
        Me.TB_SName.Size = New System.Drawing.Size(165, 20)
        Me.TB_SName.TabIndex = 79
        '
        'TB_CName
        '
        Me.TB_CName.Enabled = False
        Me.TB_CName.Location = New System.Drawing.Point(110, 99)
        Me.TB_CName.Name = "TB_CName"
        Me.TB_CName.ReadOnly = True
        Me.TB_CName.Size = New System.Drawing.Size(165, 20)
        Me.TB_CName.TabIndex = 78
        '
        'Lbl_InvCred
        '
        Me.Lbl_InvCred.AutoSize = True
        Me.Lbl_InvCred.Location = New System.Drawing.Point(580, 102)
        Me.Lbl_InvCred.Name = "Lbl_InvCred"
        Me.Lbl_InvCred.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_InvCred.TabIndex = 77
        Me.Lbl_InvCred.Text = "Invoice Credit:"
        '
        'TB_RCredit
        '
        Me.TB_RCredit.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_RCredit.Enabled = False
        Me.TB_RCredit.Location = New System.Drawing.Point(703, 99)
        Me.TB_RCredit.Name = "TB_RCredit"
        Me.TB_RCredit.ReadOnly = True
        Me.TB_RCredit.Size = New System.Drawing.Size(165, 20)
        Me.TB_RCredit.TabIndex = 76
        '
        'Lbl_RBalance
        '
        Me.Lbl_RBalance.AutoSize = True
        Me.Lbl_RBalance.Location = New System.Drawing.Point(580, 180)
        Me.Lbl_RBalance.Name = "Lbl_RBalance"
        Me.Lbl_RBalance.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_RBalance.TabIndex = 74
        Me.Lbl_RBalance.Text = "Total Balance :"
        '
        'TB_TBalance
        '
        Me.TB_TBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_TBalance.Location = New System.Drawing.Point(703, 177)
        Me.TB_TBalance.Name = "TB_TBalance"
        Me.TB_TBalance.Size = New System.Drawing.Size(165, 20)
        Me.TB_TBalance.TabIndex = 75
        '
        'Lbl_GRN
        '
        Me.Lbl_GRN.AutoSize = True
        Me.Lbl_GRN.ForeColor = System.Drawing.Color.Red
        Me.Lbl_GRN.Location = New System.Drawing.Point(281, 76)
        Me.Lbl_GRN.Name = "Lbl_GRN"
        Me.Lbl_GRN.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_GRN.TabIndex = 73
        Me.Lbl_GRN.Text = "Invoice ID :"
        '
        'TB_InvID
        '
        Me.TB_InvID.Enabled = False
        Me.TB_InvID.Location = New System.Drawing.Point(408, 73)
        Me.TB_InvID.Name = "TB_InvID"
        Me.TB_InvID.ReadOnly = True
        Me.TB_InvID.Size = New System.Drawing.Size(165, 20)
        Me.TB_InvID.TabIndex = 72
        '
        'Lbl_PCred
        '
        Me.Lbl_PCred.AutoSize = True
        Me.Lbl_PCred.ForeColor = System.Drawing.Color.Red
        Me.Lbl_PCred.Location = New System.Drawing.Point(9, 128)
        Me.Lbl_PCred.Name = "Lbl_PCred"
        Me.Lbl_PCred.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_PCred.TabIndex = 70
        Me.Lbl_PCred.Text = "Previous Credit :"
        '
        'TB_PCred
        '
        Me.TB_PCred.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_PCred.Enabled = False
        Me.TB_PCred.Location = New System.Drawing.Point(110, 125)
        Me.TB_PCred.Name = "TB_PCred"
        Me.TB_PCred.ReadOnly = True
        Me.TB_PCred.Size = New System.Drawing.Size(165, 20)
        Me.TB_PCred.TabIndex = 71
        '
        'Lbl_PNo
        '
        Me.Lbl_PNo.AutoSize = True
        Me.Lbl_PNo.ForeColor = System.Drawing.Color.Red
        Me.Lbl_PNo.Location = New System.Drawing.Point(9, 76)
        Me.Lbl_PNo.Name = "Lbl_PNo"
        Me.Lbl_PNo.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_PNo.TabIndex = 69
        Me.Lbl_PNo.Text = "Payment ID :"
        '
        'GB_PmntMethod
        '
        Me.GB_PmntMethod.Controls.Add(Me.RB_CshNChqNCred)
        Me.GB_PmntMethod.Controls.Add(Me.RB_ChqNCred)
        Me.GB_PmntMethod.Controls.Add(Me.RB_CashNCred)
        Me.GB_PmntMethod.Controls.Add(Me.RB_CashNChq)
        Me.GB_PmntMethod.Controls.Add(Me.RB_Cheque)
        Me.GB_PmntMethod.Controls.Add(Me.RB_Cash)
        Me.GB_PmntMethod.Location = New System.Drawing.Point(6, 19)
        Me.GB_PmntMethod.Name = "GB_PmntMethod"
        Me.GB_PmntMethod.Size = New System.Drawing.Size(863, 48)
        Me.GB_PmntMethod.TabIndex = 67
        Me.GB_PmntMethod.TabStop = False
        Me.GB_PmntMethod.Text = "Payment Method"
        '
        'RB_CshNChqNCred
        '
        Me.RB_CshNChqNCred.AutoSize = True
        Me.RB_CshNChqNCred.Location = New System.Drawing.Point(261, 22)
        Me.RB_CshNChqNCred.Name = "RB_CshNChqNCred"
        Me.RB_CshNChqNCred.Size = New System.Drawing.Size(143, 17)
        Me.RB_CshNChqNCred.TabIndex = 9
        Me.RB_CshNChqNCred.Text = "Cash, Cheque and Credit"
        Me.RB_CshNChqNCred.UseVisualStyleBackColor = True
        '
        'RB_ChqNCred
        '
        Me.RB_ChqNCred.AutoSize = True
        Me.RB_ChqNCred.Location = New System.Drawing.Point(727, 22)
        Me.RB_ChqNCred.Name = "RB_ChqNCred"
        Me.RB_ChqNCred.Size = New System.Drawing.Size(113, 17)
        Me.RB_ChqNCred.TabIndex = 12
        Me.RB_ChqNCred.Text = "Cheque and Credit"
        Me.RB_ChqNCred.UseVisualStyleBackColor = True
        '
        'RB_CashNCred
        '
        Me.RB_CashNCred.AutoSize = True
        Me.RB_CashNCred.Location = New System.Drawing.Point(469, 22)
        Me.RB_CashNCred.Name = "RB_CashNCred"
        Me.RB_CashNCred.Size = New System.Drawing.Size(100, 17)
        Me.RB_CashNCred.TabIndex = 10
        Me.RB_CashNCred.Text = "Cash and Credit"
        Me.RB_CashNCred.UseVisualStyleBackColor = True
        '
        'RB_CashNChq
        '
        Me.RB_CashNChq.AutoSize = True
        Me.RB_CashNChq.Location = New System.Drawing.Point(103, 22)
        Me.RB_CashNChq.Name = "RB_CashNChq"
        Me.RB_CashNChq.Size = New System.Drawing.Size(110, 17)
        Me.RB_CashNChq.TabIndex = 8
        Me.RB_CashNChq.Text = "Cash and Cheque"
        Me.RB_CashNChq.UseVisualStyleBackColor = True
        '
        'RB_Cheque
        '
        Me.RB_Cheque.AutoSize = True
        Me.RB_Cheque.Location = New System.Drawing.Point(617, 22)
        Me.RB_Cheque.Name = "RB_Cheque"
        Me.RB_Cheque.Size = New System.Drawing.Size(62, 17)
        Me.RB_Cheque.TabIndex = 11
        Me.RB_Cheque.Text = "Cheque"
        Me.RB_Cheque.UseVisualStyleBackColor = True
        '
        'RB_Cash
        '
        Me.RB_Cash.AutoSize = True
        Me.RB_Cash.Location = New System.Drawing.Point(6, 22)
        Me.RB_Cash.Name = "RB_Cash"
        Me.RB_Cash.Size = New System.Drawing.Size(49, 17)
        Me.RB_Cash.TabIndex = 7
        Me.RB_Cash.Text = "Cash"
        Me.RB_Cash.UseVisualStyleBackColor = True
        '
        'Lbl_Chq_Paid
        '
        Me.Lbl_Chq_Paid.AutoSize = True
        Me.Lbl_Chq_Paid.Location = New System.Drawing.Point(580, 128)
        Me.Lbl_Chq_Paid.Name = "Lbl_Chq_Paid"
        Me.Lbl_Chq_Paid.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Chq_Paid.TabIndex = 53
        Me.Lbl_Chq_Paid.Text = "Cheque Paid :"
        '
        'DTP_PDD
        '
        Me.DTP_PDD.CustomFormat = "yyyy-MM-dd"
        Me.DTP_PDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_PDD.Location = New System.Drawing.Point(408, 177)
        Me.DTP_PDD.Name = "DTP_PDD"
        Me.DTP_PDD.Size = New System.Drawing.Size(165, 20)
        Me.DTP_PDD.TabIndex = 66
        '
        'Lbl_DTP_PDD
        '
        Me.Lbl_DTP_PDD.AutoSize = True
        Me.Lbl_DTP_PDD.Location = New System.Drawing.Point(281, 180)
        Me.Lbl_DTP_PDD.Name = "Lbl_DTP_PDD"
        Me.Lbl_DTP_PDD.Size = New System.Drawing.Size(121, 13)
        Me.Lbl_DTP_PDD.TabIndex = 65
        Me.Lbl_DTP_PDD.Text = "Payment Delivery Date :"
        '
        'DTP_ChqDate
        '
        Me.DTP_ChqDate.CustomFormat = "yyyy-MM-dd"
        Me.DTP_ChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_ChqDate.Location = New System.Drawing.Point(703, 151)
        Me.DTP_ChqDate.Name = "DTP_ChqDate"
        Me.DTP_ChqDate.Size = New System.Drawing.Size(165, 20)
        Me.DTP_ChqDate.TabIndex = 62
        '
        'Lbl_BN
        '
        Me.Lbl_BN.AutoSize = True
        Me.Lbl_BN.Location = New System.Drawing.Point(9, 180)
        Me.Lbl_BN.Name = "Lbl_BN"
        Me.Lbl_BN.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_BN.TabIndex = 63
        Me.Lbl_BN.Text = "Bank Name :"
        '
        'Lbl_CD
        '
        Me.Lbl_CD.AutoSize = True
        Me.Lbl_CD.Location = New System.Drawing.Point(580, 154)
        Me.Lbl_CD.Name = "Lbl_CD"
        Me.Lbl_CD.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_CD.TabIndex = 61
        Me.Lbl_CD.Text = "Cheque Date :"
        '
        'Lbl_CN
        '
        Me.Lbl_CN.AutoSize = True
        Me.Lbl_CN.Location = New System.Drawing.Point(281, 154)
        Me.Lbl_CN.Name = "Lbl_CN"
        Me.Lbl_CN.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_CN.TabIndex = 59
        Me.Lbl_CN.Text = "Cheque Number :"
        '
        'Lbl_RN
        '
        Me.Lbl_RN.AutoSize = True
        Me.Lbl_RN.Location = New System.Drawing.Point(9, 154)
        Me.Lbl_RN.Name = "Lbl_RN"
        Me.Lbl_RN.Size = New System.Drawing.Size(94, 13)
        Me.Lbl_RN.TabIndex = 57
        Me.Lbl_RN.Text = "Receiver's Name :"
        '
        'Lbl_AP
        '
        Me.Lbl_AP.AutoSize = True
        Me.Lbl_AP.Location = New System.Drawing.Point(281, 128)
        Me.Lbl_AP.Name = "Lbl_AP"
        Me.Lbl_AP.Size = New System.Drawing.Size(100, 13)
        Me.Lbl_AP.TabIndex = 51
        Me.Lbl_AP.Text = "Amount Paid Cash :"
        '
        'Lbl_GRNTA
        '
        Me.Lbl_GRNTA.AutoSize = True
        Me.Lbl_GRNTA.ForeColor = System.Drawing.Color.Red
        Me.Lbl_GRNTA.Location = New System.Drawing.Point(281, 102)
        Me.Lbl_GRNTA.Name = "Lbl_GRNTA"
        Me.Lbl_GRNTA.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_GRNTA.TabIndex = 49
        Me.Lbl_GRNTA.Text = "GRN Total Amount :"
        '
        'TB_PmntID
        '
        Me.TB_PmntID.Enabled = False
        Me.TB_PmntID.Location = New System.Drawing.Point(110, 73)
        Me.TB_PmntID.Name = "TB_PmntID"
        Me.TB_PmntID.ReadOnly = True
        Me.TB_PmntID.Size = New System.Drawing.Size(165, 20)
        Me.TB_PmntID.TabIndex = 68
        '
        'TB_ChqPad
        '
        Me.TB_ChqPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_ChqPad.Location = New System.Drawing.Point(703, 125)
        Me.TB_ChqPad.Name = "TB_ChqPad"
        Me.TB_ChqPad.Size = New System.Drawing.Size(165, 20)
        Me.TB_ChqPad.TabIndex = 54
        '
        'TB_AmntPad
        '
        Me.TB_AmntPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_AmntPad.Location = New System.Drawing.Point(408, 125)
        Me.TB_AmntPad.Name = "TB_AmntPad"
        Me.TB_AmntPad.Size = New System.Drawing.Size(165, 20)
        Me.TB_AmntPad.TabIndex = 52
        '
        'TB_GRNTA
        '
        Me.TB_GRNTA.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_GRNTA.Enabled = False
        Me.TB_GRNTA.Location = New System.Drawing.Point(408, 99)
        Me.TB_GRNTA.Name = "TB_GRNTA"
        Me.TB_GRNTA.ReadOnly = True
        Me.TB_GRNTA.Size = New System.Drawing.Size(165, 20)
        Me.TB_GRNTA.TabIndex = 50
        '
        'TB_BnkNam
        '
        Me.TB_BnkNam.Location = New System.Drawing.Point(110, 177)
        Me.TB_BnkNam.Name = "TB_BnkNam"
        Me.TB_BnkNam.Size = New System.Drawing.Size(165, 20)
        Me.TB_BnkNam.TabIndex = 64
        '
        'TB_ChqNo
        '
        Me.TB_ChqNo.Location = New System.Drawing.Point(408, 151)
        Me.TB_ChqNo.Name = "TB_ChqNo"
        Me.TB_ChqNo.Size = New System.Drawing.Size(165, 20)
        Me.TB_ChqNo.TabIndex = 60
        '
        'TB_RecName
        '
        Me.TB_RecName.Location = New System.Drawing.Point(110, 151)
        Me.TB_RecName.Name = "TB_RecName"
        Me.TB_RecName.Size = New System.Drawing.Size(165, 20)
        Me.TB_RecName.TabIndex = 58
        '
        'GB_GRN_Selection
        '
        Me.GB_GRN_Selection.Controls.Add(Me.TB_DGV_Filter)
        Me.GB_GRN_Selection.Controls.Add(Me.RB_BySup)
        Me.GB_GRN_Selection.Controls.Add(Me.RB_ByInvNo)
        Me.GB_GRN_Selection.Controls.Add(Me.RB_ByGRN)
        Me.GB_GRN_Selection.Controls.Add(Me.DGV_Realize)
        Me.GB_GRN_Selection.Location = New System.Drawing.Point(6, 6)
        Me.GB_GRN_Selection.Name = "GB_GRN_Selection"
        Me.GB_GRN_Selection.Size = New System.Drawing.Size(875, 309)
        Me.GB_GRN_Selection.TabIndex = 50
        Me.GB_GRN_Selection.TabStop = False
        Me.GB_GRN_Selection.Text = "Invoice Selection for Payment"
        '
        'TB_DGV_Filter
        '
        Me.TB_DGV_Filter.Location = New System.Drawing.Point(667, 19)
        Me.TB_DGV_Filter.Name = "TB_DGV_Filter"
        Me.TB_DGV_Filter.Size = New System.Drawing.Size(202, 20)
        Me.TB_DGV_Filter.TabIndex = 55
        '
        'RB_BySup
        '
        Me.RB_BySup.AutoSize = True
        Me.RB_BySup.Location = New System.Drawing.Point(547, 22)
        Me.RB_BySup.Name = "RB_BySup"
        Me.RB_BySup.Size = New System.Drawing.Size(114, 17)
        Me.RB_BySup.TabIndex = 54
        Me.RB_BySup.TabStop = True
        Me.RB_BySup.Text = "Search by Supplier"
        Me.RB_BySup.UseVisualStyleBackColor = True
        '
        'RB_ByInvNo
        '
        Me.RB_ByInvNo.AutoSize = True
        Me.RB_ByInvNo.Location = New System.Drawing.Point(389, 22)
        Me.RB_ByInvNo.Name = "RB_ByInvNo"
        Me.RB_ByInvNo.Size = New System.Drawing.Size(152, 17)
        Me.RB_ByInvNo.TabIndex = 53
        Me.RB_ByInvNo.TabStop = True
        Me.RB_ByInvNo.Text = "Search By Invoice Number"
        Me.RB_ByInvNo.UseVisualStyleBackColor = True
        '
        'RB_ByGRN
        '
        Me.RB_ByGRN.AutoSize = True
        Me.RB_ByGRN.Location = New System.Drawing.Point(257, 22)
        Me.RB_ByGRN.Name = "RB_ByGRN"
        Me.RB_ByGRN.Size = New System.Drawing.Size(126, 17)
        Me.RB_ByGRN.TabIndex = 52
        Me.RB_ByGRN.TabStop = True
        Me.RB_ByGRN.Text = "Search By Invoice ID"
        Me.RB_ByGRN.UseVisualStyleBackColor = True
        '
        'DGV_Realize
        '
        Me.DGV_Realize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Realize.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Realize_TB_SNo, Me.DGV_Realize_TB_GRNNO, Me.DGV_Realize_TB_Invoice_No, Me.DGV_Realize_TB_PNo, Me.DGV_Realize_TB_Supplier, Me.DGV_Realize_TB_Company, Me.DGV_Realize_TB_GRNTA, Me.DGV_Realize_TB_InvoiceCredit, Me.DGV_Realize_TB_TBalance, Me.DGV_Realize_Btn_Realize})
        Me.DGV_Realize.Location = New System.Drawing.Point(3, 47)
        Me.DGV_Realize.Name = "DGV_Realize"
        Me.DGV_Realize.Size = New System.Drawing.Size(869, 256)
        Me.DGV_Realize.TabIndex = 51
        '
        'DGV_Realize_TB_SNo
        '
        Me.DGV_Realize_TB_SNo.HeaderText = "S.No"
        Me.DGV_Realize_TB_SNo.Name = "DGV_Realize_TB_SNo"
        Me.DGV_Realize_TB_SNo.Width = 50
        '
        'DGV_Realize_TB_GRNNO
        '
        Me.DGV_Realize_TB_GRNNO.HeaderText = "Invoice ID"
        Me.DGV_Realize_TB_GRNNO.Name = "DGV_Realize_TB_GRNNO"
        Me.DGV_Realize_TB_GRNNO.ReadOnly = True
        Me.DGV_Realize_TB_GRNNO.Width = 65
        '
        'DGV_Realize_TB_Invoice_No
        '
        Me.DGV_Realize_TB_Invoice_No.HeaderText = "Invoice No"
        Me.DGV_Realize_TB_Invoice_No.Name = "DGV_Realize_TB_Invoice_No"
        Me.DGV_Realize_TB_Invoice_No.ReadOnly = True
        Me.DGV_Realize_TB_Invoice_No.Width = 65
        '
        'DGV_Realize_TB_PNo
        '
        Me.DGV_Realize_TB_PNo.HeaderText = "Payment ID"
        Me.DGV_Realize_TB_PNo.Name = "DGV_Realize_TB_PNo"
        Me.DGV_Realize_TB_PNo.ReadOnly = True
        Me.DGV_Realize_TB_PNo.Width = 70
        '
        'DGV_Realize_TB_Supplier
        '
        Me.DGV_Realize_TB_Supplier.HeaderText = "Supplier"
        Me.DGV_Realize_TB_Supplier.Name = "DGV_Realize_TB_Supplier"
        Me.DGV_Realize_TB_Supplier.ReadOnly = True
        Me.DGV_Realize_TB_Supplier.Width = 120
        '
        'DGV_Realize_TB_Company
        '
        Me.DGV_Realize_TB_Company.HeaderText = "Company"
        Me.DGV_Realize_TB_Company.Name = "DGV_Realize_TB_Company"
        Me.DGV_Realize_TB_Company.ReadOnly = True
        Me.DGV_Realize_TB_Company.Width = 150
        '
        'DGV_Realize_TB_GRNTA
        '
        Me.DGV_Realize_TB_GRNTA.HeaderText = "GRN Total Amount"
        Me.DGV_Realize_TB_GRNTA.Name = "DGV_Realize_TB_GRNTA"
        Me.DGV_Realize_TB_GRNTA.Width = 85
        '
        'DGV_Realize_TB_InvoiceCredit
        '
        Me.DGV_Realize_TB_InvoiceCredit.HeaderText = "Invoice Credit"
        Me.DGV_Realize_TB_InvoiceCredit.Name = "DGV_Realize_TB_InvoiceCredit"
        Me.DGV_Realize_TB_InvoiceCredit.Width = 60
        '
        'DGV_Realize_TB_TBalance
        '
        Me.DGV_Realize_TB_TBalance.HeaderText = "Total Balance"
        Me.DGV_Realize_TB_TBalance.Name = "DGV_Realize_TB_TBalance"
        Me.DGV_Realize_TB_TBalance.ReadOnly = True
        Me.DGV_Realize_TB_TBalance.Width = 90
        '
        'DGV_Realize_Btn_Realize
        '
        Me.DGV_Realize_Btn_Realize.HeaderText = ""
        Me.DGV_Realize_Btn_Realize.Name = "DGV_Realize_Btn_Realize"
        Me.DGV_Realize_Btn_Realize.Width = 70
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Location = New System.Drawing.Point(709, 532)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Submit.TabIndex = 1
        Me.Btn_Submit.Text = "Add"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'TP_Update
        '
        Me.TP_Update.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Update.Controls.Add(Me.Label17)
        Me.TP_Update.Controls.Add(Me.UD_GB_Realize)
        Me.TP_Update.Controls.Add(Me.UD_GB_GRN_Selection)
        Me.TP_Update.Controls.Add(Me.UD_Btn_Clrall)
        Me.TP_Update.Controls.Add(Me.Btn_Update)
        Me.TP_Update.Location = New System.Drawing.Point(4, 25)
        Me.TP_Update.Name = "TP_Update"
        Me.TP_Update.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Update.Size = New System.Drawing.Size(889, 563)
        Me.TP_Update.TabIndex = 1
        Me.TP_Update.Text = "Edit Payment"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 513)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(0, 13)
        Me.Label17.TabIndex = 56
        '
        'UD_GB_Realize
        '
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_PCred)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_TBalance)
        Me.UD_GB_Realize.Controls.Add(Me.Label4)
        Me.UD_GB_Realize.Controls.Add(Me.Label5)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_SName)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_CName)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_GRN)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_InvID)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_InvCred)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_RBalance)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_PCred)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_PNo)
        Me.UD_GB_Realize.Controls.Add(Me.UD_GB_PmntMethod)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_Chq_Paid)
        Me.UD_GB_Realize.Controls.Add(Me.UD_DTP_PDD)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_DTP_PDD)
        Me.UD_GB_Realize.Controls.Add(Me.UD_DTP_ChqDate)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_BN)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_CD)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_CN)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_RN)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_AP)
        Me.UD_GB_Realize.Controls.Add(Me.UD_Lbl_GRNTA)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_PmntID)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_ChqPad)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_RCredit)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_AmntPad)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_GRNTA)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_BnkNam)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_ChqNo)
        Me.UD_GB_Realize.Controls.Add(Me.UD_TB_RecName)
        Me.UD_GB_Realize.Location = New System.Drawing.Point(6, 321)
        Me.UD_GB_Realize.Name = "UD_GB_Realize"
        Me.UD_GB_Realize.Size = New System.Drawing.Size(875, 205)
        Me.UD_GB_Realize.TabIndex = 53
        Me.UD_GB_Realize.TabStop = False
        Me.UD_GB_Realize.Text = "Payment"
        '
        'UD_Lbl_PCred
        '
        Me.UD_Lbl_PCred.AutoSize = True
        Me.UD_Lbl_PCred.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_PCred.Location = New System.Drawing.Point(9, 128)
        Me.UD_Lbl_PCred.Name = "UD_Lbl_PCred"
        Me.UD_Lbl_PCred.Size = New System.Drawing.Size(84, 13)
        Me.UD_Lbl_PCred.TabIndex = 86
        Me.UD_Lbl_PCred.Text = "Previous Credit :"
        '
        'UD_TB_TBalance
        '
        Me.UD_TB_TBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_TBalance.Enabled = False
        Me.UD_TB_TBalance.Location = New System.Drawing.Point(703, 177)
        Me.UD_TB_TBalance.Name = "UD_TB_TBalance"
        Me.UD_TB_TBalance.ReadOnly = True
        Me.UD_TB_TBalance.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_TBalance.TabIndex = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Company :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(580, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Supplier :"
        '
        'UD_TB_SName
        '
        Me.UD_TB_SName.Enabled = False
        Me.UD_TB_SName.Location = New System.Drawing.Point(703, 73)
        Me.UD_TB_SName.Name = "UD_TB_SName"
        Me.UD_TB_SName.ReadOnly = True
        Me.UD_TB_SName.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_SName.TabIndex = 83
        '
        'UD_TB_CName
        '
        Me.UD_TB_CName.Enabled = False
        Me.UD_TB_CName.Location = New System.Drawing.Point(110, 99)
        Me.UD_TB_CName.Name = "UD_TB_CName"
        Me.UD_TB_CName.ReadOnly = True
        Me.UD_TB_CName.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_CName.TabIndex = 82
        '
        'UD_Lbl_GRN
        '
        Me.UD_Lbl_GRN.AutoSize = True
        Me.UD_Lbl_GRN.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_GRN.Location = New System.Drawing.Point(281, 76)
        Me.UD_Lbl_GRN.Name = "UD_Lbl_GRN"
        Me.UD_Lbl_GRN.Size = New System.Drawing.Size(62, 13)
        Me.UD_Lbl_GRN.TabIndex = 73
        Me.UD_Lbl_GRN.Text = "Invoice ID :"
        '
        'UD_TB_InvID
        '
        Me.UD_TB_InvID.Enabled = False
        Me.UD_TB_InvID.Location = New System.Drawing.Point(408, 73)
        Me.UD_TB_InvID.Name = "UD_TB_InvID"
        Me.UD_TB_InvID.ReadOnly = True
        Me.UD_TB_InvID.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_InvID.TabIndex = 72
        '
        'UD_Lbl_InvCred
        '
        Me.UD_Lbl_InvCred.AutoSize = True
        Me.UD_Lbl_InvCred.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UD_Lbl_InvCred.Location = New System.Drawing.Point(580, 102)
        Me.UD_Lbl_InvCred.Name = "UD_Lbl_InvCred"
        Me.UD_Lbl_InvCred.Size = New System.Drawing.Size(78, 13)
        Me.UD_Lbl_InvCred.TabIndex = 70
        Me.UD_Lbl_InvCred.Text = "Invoice Credit :"
        '
        'UD_Lbl_RBalance
        '
        Me.UD_Lbl_RBalance.AutoSize = True
        Me.UD_Lbl_RBalance.Location = New System.Drawing.Point(580, 180)
        Me.UD_Lbl_RBalance.Name = "UD_Lbl_RBalance"
        Me.UD_Lbl_RBalance.Size = New System.Drawing.Size(79, 13)
        Me.UD_Lbl_RBalance.TabIndex = 55
        Me.UD_Lbl_RBalance.Text = "Total Balance :"
        '
        'UD_TB_PCred
        '
        Me.UD_TB_PCred.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_PCred.Enabled = False
        Me.UD_TB_PCred.Location = New System.Drawing.Point(110, 125)
        Me.UD_TB_PCred.Name = "UD_TB_PCred"
        Me.UD_TB_PCred.ReadOnly = True
        Me.UD_TB_PCred.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_PCred.TabIndex = 71
        '
        'UD_Lbl_PNo
        '
        Me.UD_Lbl_PNo.AutoSize = True
        Me.UD_Lbl_PNo.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_PNo.Location = New System.Drawing.Point(9, 76)
        Me.UD_Lbl_PNo.Name = "UD_Lbl_PNo"
        Me.UD_Lbl_PNo.Size = New System.Drawing.Size(68, 13)
        Me.UD_Lbl_PNo.TabIndex = 69
        Me.UD_Lbl_PNo.Text = "Payment ID :"
        '
        'UD_GB_PmntMethod
        '
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_CshNChqNCred)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_ChqNCred)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_CashNCred)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_CashNChq)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_Cheque)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_Cash)
        Me.UD_GB_PmntMethod.Location = New System.Drawing.Point(6, 19)
        Me.UD_GB_PmntMethod.Name = "UD_GB_PmntMethod"
        Me.UD_GB_PmntMethod.Size = New System.Drawing.Size(863, 48)
        Me.UD_GB_PmntMethod.TabIndex = 67
        Me.UD_GB_PmntMethod.TabStop = False
        Me.UD_GB_PmntMethod.Text = "Payment Method"
        '
        'UD_RB_CshNChqNCred
        '
        Me.UD_RB_CshNChqNCred.AutoSize = True
        Me.UD_RB_CshNChqNCred.Location = New System.Drawing.Point(261, 22)
        Me.UD_RB_CshNChqNCred.Name = "UD_RB_CshNChqNCred"
        Me.UD_RB_CshNChqNCred.Size = New System.Drawing.Size(143, 17)
        Me.UD_RB_CshNChqNCred.TabIndex = 9
        Me.UD_RB_CshNChqNCred.Text = "Cash, Cheque and Credit"
        Me.UD_RB_CshNChqNCred.UseVisualStyleBackColor = True
        '
        'UD_RB_ChqNCred
        '
        Me.UD_RB_ChqNCred.AutoSize = True
        Me.UD_RB_ChqNCred.Location = New System.Drawing.Point(727, 22)
        Me.UD_RB_ChqNCred.Name = "UD_RB_ChqNCred"
        Me.UD_RB_ChqNCred.Size = New System.Drawing.Size(113, 17)
        Me.UD_RB_ChqNCred.TabIndex = 12
        Me.UD_RB_ChqNCred.Text = "Cheque and Credit"
        Me.UD_RB_ChqNCred.UseVisualStyleBackColor = True
        '
        'UD_RB_CashNCred
        '
        Me.UD_RB_CashNCred.AutoSize = True
        Me.UD_RB_CashNCred.Location = New System.Drawing.Point(469, 22)
        Me.UD_RB_CashNCred.Name = "UD_RB_CashNCred"
        Me.UD_RB_CashNCred.Size = New System.Drawing.Size(100, 17)
        Me.UD_RB_CashNCred.TabIndex = 10
        Me.UD_RB_CashNCred.Text = "Cash and Credit"
        Me.UD_RB_CashNCred.UseVisualStyleBackColor = True
        '
        'UD_RB_CashNChq
        '
        Me.UD_RB_CashNChq.AutoSize = True
        Me.UD_RB_CashNChq.Location = New System.Drawing.Point(103, 22)
        Me.UD_RB_CashNChq.Name = "UD_RB_CashNChq"
        Me.UD_RB_CashNChq.Size = New System.Drawing.Size(110, 17)
        Me.UD_RB_CashNChq.TabIndex = 8
        Me.UD_RB_CashNChq.Text = "Cash and Cheque"
        Me.UD_RB_CashNChq.UseVisualStyleBackColor = True
        '
        'UD_RB_Cheque
        '
        Me.UD_RB_Cheque.AutoSize = True
        Me.UD_RB_Cheque.Location = New System.Drawing.Point(617, 22)
        Me.UD_RB_Cheque.Name = "UD_RB_Cheque"
        Me.UD_RB_Cheque.Size = New System.Drawing.Size(62, 17)
        Me.UD_RB_Cheque.TabIndex = 11
        Me.UD_RB_Cheque.Text = "Cheque"
        Me.UD_RB_Cheque.UseVisualStyleBackColor = True
        '
        'UD_RB_Cash
        '
        Me.UD_RB_Cash.AutoSize = True
        Me.UD_RB_Cash.Location = New System.Drawing.Point(6, 22)
        Me.UD_RB_Cash.Name = "UD_RB_Cash"
        Me.UD_RB_Cash.Size = New System.Drawing.Size(49, 17)
        Me.UD_RB_Cash.TabIndex = 7
        Me.UD_RB_Cash.Text = "Cash"
        Me.UD_RB_Cash.UseVisualStyleBackColor = True
        '
        'UD_Lbl_Chq_Paid
        '
        Me.UD_Lbl_Chq_Paid.AutoSize = True
        Me.UD_Lbl_Chq_Paid.Location = New System.Drawing.Point(580, 128)
        Me.UD_Lbl_Chq_Paid.Name = "UD_Lbl_Chq_Paid"
        Me.UD_Lbl_Chq_Paid.Size = New System.Drawing.Size(74, 13)
        Me.UD_Lbl_Chq_Paid.TabIndex = 53
        Me.UD_Lbl_Chq_Paid.Text = "Cheque Paid :"
        '
        'UD_DTP_PDD
        '
        Me.UD_DTP_PDD.CustomFormat = "yyyy-MM-dd"
        Me.UD_DTP_PDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UD_DTP_PDD.Location = New System.Drawing.Point(408, 177)
        Me.UD_DTP_PDD.Name = "UD_DTP_PDD"
        Me.UD_DTP_PDD.Size = New System.Drawing.Size(165, 20)
        Me.UD_DTP_PDD.TabIndex = 66
        '
        'UD_Lbl_DTP_PDD
        '
        Me.UD_Lbl_DTP_PDD.AutoSize = True
        Me.UD_Lbl_DTP_PDD.Location = New System.Drawing.Point(281, 180)
        Me.UD_Lbl_DTP_PDD.Name = "UD_Lbl_DTP_PDD"
        Me.UD_Lbl_DTP_PDD.Size = New System.Drawing.Size(121, 13)
        Me.UD_Lbl_DTP_PDD.TabIndex = 65
        Me.UD_Lbl_DTP_PDD.Text = "Payment Delivery Date :"
        '
        'UD_DTP_ChqDate
        '
        Me.UD_DTP_ChqDate.CustomFormat = "yyyy-MM-dd"
        Me.UD_DTP_ChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UD_DTP_ChqDate.Location = New System.Drawing.Point(703, 151)
        Me.UD_DTP_ChqDate.Name = "UD_DTP_ChqDate"
        Me.UD_DTP_ChqDate.Size = New System.Drawing.Size(165, 20)
        Me.UD_DTP_ChqDate.TabIndex = 62
        '
        'UD_Lbl_BN
        '
        Me.UD_Lbl_BN.AutoSize = True
        Me.UD_Lbl_BN.Location = New System.Drawing.Point(9, 180)
        Me.UD_Lbl_BN.Name = "UD_Lbl_BN"
        Me.UD_Lbl_BN.Size = New System.Drawing.Size(69, 13)
        Me.UD_Lbl_BN.TabIndex = 63
        Me.UD_Lbl_BN.Text = "Bank Name :"
        '
        'UD_Lbl_CD
        '
        Me.UD_Lbl_CD.AutoSize = True
        Me.UD_Lbl_CD.Location = New System.Drawing.Point(580, 154)
        Me.UD_Lbl_CD.Name = "UD_Lbl_CD"
        Me.UD_Lbl_CD.Size = New System.Drawing.Size(76, 13)
        Me.UD_Lbl_CD.TabIndex = 61
        Me.UD_Lbl_CD.Text = "Cheque Date :"
        '
        'UD_Lbl_CN
        '
        Me.UD_Lbl_CN.AutoSize = True
        Me.UD_Lbl_CN.Location = New System.Drawing.Point(281, 154)
        Me.UD_Lbl_CN.Name = "UD_Lbl_CN"
        Me.UD_Lbl_CN.Size = New System.Drawing.Size(90, 13)
        Me.UD_Lbl_CN.TabIndex = 59
        Me.UD_Lbl_CN.Text = "Cheque Number :"
        '
        'UD_Lbl_RN
        '
        Me.UD_Lbl_RN.AutoSize = True
        Me.UD_Lbl_RN.Location = New System.Drawing.Point(9, 154)
        Me.UD_Lbl_RN.Name = "UD_Lbl_RN"
        Me.UD_Lbl_RN.Size = New System.Drawing.Size(94, 13)
        Me.UD_Lbl_RN.TabIndex = 57
        Me.UD_Lbl_RN.Text = "Receiver's Name :"
        '
        'UD_Lbl_AP
        '
        Me.UD_Lbl_AP.AutoSize = True
        Me.UD_Lbl_AP.Location = New System.Drawing.Point(281, 128)
        Me.UD_Lbl_AP.Name = "UD_Lbl_AP"
        Me.UD_Lbl_AP.Size = New System.Drawing.Size(100, 13)
        Me.UD_Lbl_AP.TabIndex = 51
        Me.UD_Lbl_AP.Text = "Amount Paid Cash :"
        '
        'UD_Lbl_GRNTA
        '
        Me.UD_Lbl_GRNTA.AutoSize = True
        Me.UD_Lbl_GRNTA.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_GRNTA.Location = New System.Drawing.Point(281, 102)
        Me.UD_Lbl_GRNTA.Name = "UD_Lbl_GRNTA"
        Me.UD_Lbl_GRNTA.Size = New System.Drawing.Size(103, 13)
        Me.UD_Lbl_GRNTA.TabIndex = 49
        Me.UD_Lbl_GRNTA.Text = "GRN Total Amount :"
        '
        'UD_TB_PmntID
        '
        Me.UD_TB_PmntID.Enabled = False
        Me.UD_TB_PmntID.Location = New System.Drawing.Point(110, 73)
        Me.UD_TB_PmntID.Name = "UD_TB_PmntID"
        Me.UD_TB_PmntID.ReadOnly = True
        Me.UD_TB_PmntID.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_PmntID.TabIndex = 68
        '
        'UD_TB_ChqPad
        '
        Me.UD_TB_ChqPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_ChqPad.Location = New System.Drawing.Point(703, 125)
        Me.UD_TB_ChqPad.Name = "UD_TB_ChqPad"
        Me.UD_TB_ChqPad.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_ChqPad.TabIndex = 54
        '
        'UD_TB_RCredit
        '
        Me.UD_TB_RCredit.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_RCredit.Enabled = False
        Me.UD_TB_RCredit.Location = New System.Drawing.Point(703, 99)
        Me.UD_TB_RCredit.Name = "UD_TB_RCredit"
        Me.UD_TB_RCredit.ReadOnly = True
        Me.UD_TB_RCredit.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_RCredit.TabIndex = 56
        '
        'UD_TB_AmntPad
        '
        Me.UD_TB_AmntPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_AmntPad.Location = New System.Drawing.Point(408, 125)
        Me.UD_TB_AmntPad.Name = "UD_TB_AmntPad"
        Me.UD_TB_AmntPad.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_AmntPad.TabIndex = 52
        '
        'UD_TB_GRNTA
        '
        Me.UD_TB_GRNTA.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_GRNTA.Enabled = False
        Me.UD_TB_GRNTA.Location = New System.Drawing.Point(408, 99)
        Me.UD_TB_GRNTA.Name = "UD_TB_GRNTA"
        Me.UD_TB_GRNTA.ReadOnly = True
        Me.UD_TB_GRNTA.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_GRNTA.TabIndex = 50
        '
        'UD_TB_BnkNam
        '
        Me.UD_TB_BnkNam.Location = New System.Drawing.Point(110, 177)
        Me.UD_TB_BnkNam.Name = "UD_TB_BnkNam"
        Me.UD_TB_BnkNam.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_BnkNam.TabIndex = 64
        '
        'UD_TB_ChqNo
        '
        Me.UD_TB_ChqNo.Location = New System.Drawing.Point(408, 151)
        Me.UD_TB_ChqNo.Name = "UD_TB_ChqNo"
        Me.UD_TB_ChqNo.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_ChqNo.TabIndex = 60
        '
        'UD_TB_RecName
        '
        Me.UD_TB_RecName.Location = New System.Drawing.Point(110, 151)
        Me.UD_TB_RecName.Name = "UD_TB_RecName"
        Me.UD_TB_RecName.Size = New System.Drawing.Size(165, 20)
        Me.UD_TB_RecName.TabIndex = 58
        '
        'UD_GB_GRN_Selection
        '
        Me.UD_GB_GRN_Selection.Controls.Add(Me.UD_New_DGV_Realize)
        Me.UD_GB_GRN_Selection.Controls.Add(Me.UD_TB_DGV_Filter)
        Me.UD_GB_GRN_Selection.Controls.Add(Me.UD_RB_BySup)
        Me.UD_GB_GRN_Selection.Controls.Add(Me.UD_RB_ByInvNo)
        Me.UD_GB_GRN_Selection.Controls.Add(Me.UD_RB_ByGRN)
        Me.UD_GB_GRN_Selection.Controls.Add(Me.UD_DGV_Realize)
        Me.UD_GB_GRN_Selection.Location = New System.Drawing.Point(6, 6)
        Me.UD_GB_GRN_Selection.Name = "UD_GB_GRN_Selection"
        Me.UD_GB_GRN_Selection.Size = New System.Drawing.Size(875, 309)
        Me.UD_GB_GRN_Selection.TabIndex = 52
        Me.UD_GB_GRN_Selection.TabStop = False
        Me.UD_GB_GRN_Selection.Text = "Select a Payment to Update"
        '
        'UD_New_DGV_Realize
        '
        Me.UD_New_DGV_Realize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UD_New_DGV_Realize.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.UD_New_DGV_Realize_Btn_realize})
        Me.UD_New_DGV_Realize.Location = New System.Drawing.Point(3, 223)
        Me.UD_New_DGV_Realize.Name = "UD_New_DGV_Realize"
        Me.UD_New_DGV_Realize.Size = New System.Drawing.Size(869, 80)
        Me.UD_New_DGV_Realize.TabIndex = 56
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "S.No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Invoice ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 65
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Invoice No"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 65
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Payment ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Supplier"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Company"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "GRN Total Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 85
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Invoice Credit"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 60
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total Balance"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 90
        '
        'UD_New_DGV_Realize_Btn_realize
        '
        Me.UD_New_DGV_Realize_Btn_realize.HeaderText = ""
        Me.UD_New_DGV_Realize_Btn_realize.Name = "UD_New_DGV_Realize_Btn_realize"
        Me.UD_New_DGV_Realize_Btn_realize.Width = 70
        '
        'UD_TB_DGV_Filter
        '
        Me.UD_TB_DGV_Filter.Location = New System.Drawing.Point(667, 19)
        Me.UD_TB_DGV_Filter.Name = "UD_TB_DGV_Filter"
        Me.UD_TB_DGV_Filter.Size = New System.Drawing.Size(202, 20)
        Me.UD_TB_DGV_Filter.TabIndex = 55
        '
        'UD_RB_BySup
        '
        Me.UD_RB_BySup.AutoSize = True
        Me.UD_RB_BySup.Location = New System.Drawing.Point(547, 22)
        Me.UD_RB_BySup.Name = "UD_RB_BySup"
        Me.UD_RB_BySup.Size = New System.Drawing.Size(114, 17)
        Me.UD_RB_BySup.TabIndex = 54
        Me.UD_RB_BySup.TabStop = True
        Me.UD_RB_BySup.Text = "Search by Supplier"
        Me.UD_RB_BySup.UseVisualStyleBackColor = True
        '
        'UD_RB_ByInvNo
        '
        Me.UD_RB_ByInvNo.AutoSize = True
        Me.UD_RB_ByInvNo.Location = New System.Drawing.Point(389, 22)
        Me.UD_RB_ByInvNo.Name = "UD_RB_ByInvNo"
        Me.UD_RB_ByInvNo.Size = New System.Drawing.Size(152, 17)
        Me.UD_RB_ByInvNo.TabIndex = 53
        Me.UD_RB_ByInvNo.TabStop = True
        Me.UD_RB_ByInvNo.Text = "Search By Invoice Number"
        Me.UD_RB_ByInvNo.UseVisualStyleBackColor = True
        '
        'UD_RB_ByGRN
        '
        Me.UD_RB_ByGRN.AutoSize = True
        Me.UD_RB_ByGRN.Location = New System.Drawing.Point(257, 22)
        Me.UD_RB_ByGRN.Name = "UD_RB_ByGRN"
        Me.UD_RB_ByGRN.Size = New System.Drawing.Size(126, 17)
        Me.UD_RB_ByGRN.TabIndex = 52
        Me.UD_RB_ByGRN.TabStop = True
        Me.UD_RB_ByGRN.Text = "Search By Invoice ID"
        Me.UD_RB_ByGRN.UseVisualStyleBackColor = True
        '
        'UD_DGV_Realize
        '
        Me.UD_DGV_Realize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UD_DGV_Realize.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UD_DGV_Realize_TB_SNo, Me.UD_DGV_Realize_TB_GRNNO, Me.UD_DGV_Realize_TB_Invoice_No, Me.UD_DGV_Realize_TB_PNo, Me.UD_DGV_Realize_TB_Supplier, Me.UD_DGV_Realize_TB_Company, Me.UD_DGV_Realize_TB_GRNTA, Me.UD_DGV_Realize_TB_InvoiceCredit, Me.UD_DGV_Realize_TB_RBalance, Me.UD_DGV_Realize_Btn_Realize})
        Me.UD_DGV_Realize.Location = New System.Drawing.Point(3, 47)
        Me.UD_DGV_Realize.Name = "UD_DGV_Realize"
        Me.UD_DGV_Realize.Size = New System.Drawing.Size(869, 170)
        Me.UD_DGV_Realize.TabIndex = 51
        '
        'UD_DGV_Realize_TB_SNo
        '
        Me.UD_DGV_Realize_TB_SNo.HeaderText = "S.No"
        Me.UD_DGV_Realize_TB_SNo.Name = "UD_DGV_Realize_TB_SNo"
        Me.UD_DGV_Realize_TB_SNo.Width = 50
        '
        'UD_DGV_Realize_TB_GRNNO
        '
        Me.UD_DGV_Realize_TB_GRNNO.HeaderText = "Invoice ID"
        Me.UD_DGV_Realize_TB_GRNNO.Name = "UD_DGV_Realize_TB_GRNNO"
        Me.UD_DGV_Realize_TB_GRNNO.ReadOnly = True
        Me.UD_DGV_Realize_TB_GRNNO.Width = 65
        '
        'UD_DGV_Realize_TB_Invoice_No
        '
        Me.UD_DGV_Realize_TB_Invoice_No.HeaderText = "Invoice No"
        Me.UD_DGV_Realize_TB_Invoice_No.Name = "UD_DGV_Realize_TB_Invoice_No"
        Me.UD_DGV_Realize_TB_Invoice_No.ReadOnly = True
        Me.UD_DGV_Realize_TB_Invoice_No.Width = 65
        '
        'UD_DGV_Realize_TB_PNo
        '
        Me.UD_DGV_Realize_TB_PNo.HeaderText = "Payment ID"
        Me.UD_DGV_Realize_TB_PNo.Name = "UD_DGV_Realize_TB_PNo"
        Me.UD_DGV_Realize_TB_PNo.ReadOnly = True
        Me.UD_DGV_Realize_TB_PNo.Width = 70
        '
        'UD_DGV_Realize_TB_Supplier
        '
        Me.UD_DGV_Realize_TB_Supplier.HeaderText = "Supplier"
        Me.UD_DGV_Realize_TB_Supplier.Name = "UD_DGV_Realize_TB_Supplier"
        Me.UD_DGV_Realize_TB_Supplier.ReadOnly = True
        Me.UD_DGV_Realize_TB_Supplier.Width = 120
        '
        'UD_DGV_Realize_TB_Company
        '
        Me.UD_DGV_Realize_TB_Company.HeaderText = "Company"
        Me.UD_DGV_Realize_TB_Company.Name = "UD_DGV_Realize_TB_Company"
        Me.UD_DGV_Realize_TB_Company.ReadOnly = True
        Me.UD_DGV_Realize_TB_Company.Width = 150
        '
        'UD_DGV_Realize_TB_GRNTA
        '
        Me.UD_DGV_Realize_TB_GRNTA.HeaderText = "GRN Total Amount"
        Me.UD_DGV_Realize_TB_GRNTA.Name = "UD_DGV_Realize_TB_GRNTA"
        Me.UD_DGV_Realize_TB_GRNTA.ReadOnly = True
        Me.UD_DGV_Realize_TB_GRNTA.Width = 85
        '
        'UD_DGV_Realize_TB_InvoiceCredit
        '
        Me.UD_DGV_Realize_TB_InvoiceCredit.HeaderText = "Invoice Credit"
        Me.UD_DGV_Realize_TB_InvoiceCredit.Name = "UD_DGV_Realize_TB_InvoiceCredit"
        Me.UD_DGV_Realize_TB_InvoiceCredit.Width = 60
        '
        'UD_DGV_Realize_TB_RBalance
        '
        Me.UD_DGV_Realize_TB_RBalance.HeaderText = "Total Balance"
        Me.UD_DGV_Realize_TB_RBalance.Name = "UD_DGV_Realize_TB_RBalance"
        Me.UD_DGV_Realize_TB_RBalance.ReadOnly = True
        Me.UD_DGV_Realize_TB_RBalance.Width = 90
        '
        'UD_DGV_Realize_Btn_Realize
        '
        Me.UD_DGV_Realize_Btn_Realize.HeaderText = ""
        Me.UD_DGV_Realize_Btn_Realize.Name = "UD_DGV_Realize_Btn_Realize"
        Me.UD_DGV_Realize_Btn_Realize.Width = 70
        '
        'UD_Btn_Clrall
        '
        Me.UD_Btn_Clrall.Location = New System.Drawing.Point(799, 532)
        Me.UD_Btn_Clrall.Name = "UD_Btn_Clrall"
        Me.UD_Btn_Clrall.Size = New System.Drawing.Size(75, 23)
        Me.UD_Btn_Clrall.TabIndex = 3
        Me.UD_Btn_Clrall.Text = "Clear All"
        Me.UD_Btn_Clrall.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(709, 532)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Update.TabIndex = 2
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'TP_Delete
        '
        Me.TP_Delete.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Delete.Controls.Add(Me.D_Lbl_Credit_Status)
        Me.TP_Delete.Controls.Add(Me.D_GB_Realize)
        Me.TP_Delete.Controls.Add(Me.D_GB_GRN_Selection)
        Me.TP_Delete.Controls.Add(Me.D_CStatus)
        Me.TP_Delete.Controls.Add(Me.D_Btn_Clrall)
        Me.TP_Delete.Controls.Add(Me.Btn_Delete)
        Me.TP_Delete.Location = New System.Drawing.Point(4, 25)
        Me.TP_Delete.Name = "TP_Delete"
        Me.TP_Delete.Size = New System.Drawing.Size(889, 563)
        Me.TP_Delete.TabIndex = 3
        Me.TP_Delete.Text = "Delete Payment"
        '
        'D_Lbl_Credit_Status
        '
        Me.D_Lbl_Credit_Status.AutoSize = True
        Me.D_Lbl_Credit_Status.Location = New System.Drawing.Point(15, 537)
        Me.D_Lbl_Credit_Status.Name = "D_Lbl_Credit_Status"
        Me.D_Lbl_Credit_Status.Size = New System.Drawing.Size(73, 13)
        Me.D_Lbl_Credit_Status.TabIndex = 58
        Me.D_Lbl_Credit_Status.Text = "Credit Status :"
        '
        'D_GB_Realize
        '
        Me.D_GB_Realize.Controls.Add(Me.D_TB_TBalance)
        Me.D_GB_Realize.Controls.Add(Me.Label8)
        Me.D_GB_Realize.Controls.Add(Me.Label7)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_PCred)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_SName)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_CName)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_RecName)
        Me.D_GB_Realize.Controls.Add(Me.Label1)
        Me.D_GB_Realize.Controls.Add(Me.Label6)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_GRN)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_GRN)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_PNo)
        Me.D_GB_Realize.Controls.Add(Me.D_GB_PmntMethod)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_Chq_Paid)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_RCredit)
        Me.D_GB_Realize.Controls.Add(Me.D_DTP_PDD)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_DTP_PDD)
        Me.D_GB_Realize.Controls.Add(Me.D_DTP_ChqDate)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_BN)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_CD)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_CN)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_RN)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_AP)
        Me.D_GB_Realize.Controls.Add(Me.D_Lbl_GRNTA)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_PNo)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_ChqPad)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_RCredit)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_AmntPad)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_GRNTA)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_BnkNam)
        Me.D_GB_Realize.Controls.Add(Me.D_TB_ChqNo)
        Me.D_GB_Realize.Location = New System.Drawing.Point(6, 321)
        Me.D_GB_Realize.Name = "D_GB_Realize"
        Me.D_GB_Realize.Size = New System.Drawing.Size(875, 205)
        Me.D_GB_Realize.TabIndex = 57
        Me.D_GB_Realize.TabStop = False
        Me.D_GB_Realize.Text = "Selected Payment"
        '
        'D_TB_TBalance
        '
        Me.D_TB_TBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_TBalance.Enabled = False
        Me.D_TB_TBalance.Location = New System.Drawing.Point(703, 177)
        Me.D_TB_TBalance.Name = "D_TB_TBalance"
        Me.D_TB_TBalance.ReadOnly = True
        Me.D_TB_TBalance.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_TBalance.TabIndex = 93
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(580, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Total Balance :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(9, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 13)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "Previous Credit :"
        '
        'D_TB_PCred
        '
        Me.D_TB_PCred.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_PCred.Enabled = False
        Me.D_TB_PCred.Location = New System.Drawing.Point(110, 125)
        Me.D_TB_PCred.Name = "D_TB_PCred"
        Me.D_TB_PCred.ReadOnly = True
        Me.D_TB_PCred.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_PCred.TabIndex = 90
        '
        'D_TB_SName
        '
        Me.D_TB_SName.Enabled = False
        Me.D_TB_SName.Location = New System.Drawing.Point(703, 73)
        Me.D_TB_SName.Name = "D_TB_SName"
        Me.D_TB_SName.ReadOnly = True
        Me.D_TB_SName.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_SName.TabIndex = 87
        '
        'D_TB_CName
        '
        Me.D_TB_CName.Enabled = False
        Me.D_TB_CName.Location = New System.Drawing.Point(110, 99)
        Me.D_TB_CName.Name = "D_TB_CName"
        Me.D_TB_CName.ReadOnly = True
        Me.D_TB_CName.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_CName.TabIndex = 86
        '
        'D_TB_RecName
        '
        Me.D_TB_RecName.Enabled = False
        Me.D_TB_RecName.Location = New System.Drawing.Point(110, 151)
        Me.D_TB_RecName.Name = "D_TB_RecName"
        Me.D_TB_RecName.ReadOnly = True
        Me.D_TB_RecName.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_RecName.TabIndex = 58
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Company :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(580, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Supplier :"
        '
        'D_Lbl_GRN
        '
        Me.D_Lbl_GRN.AutoSize = True
        Me.D_Lbl_GRN.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_GRN.Location = New System.Drawing.Point(281, 76)
        Me.D_Lbl_GRN.Name = "D_Lbl_GRN"
        Me.D_Lbl_GRN.Size = New System.Drawing.Size(62, 13)
        Me.D_Lbl_GRN.TabIndex = 73
        Me.D_Lbl_GRN.Text = "Invoice ID :"
        '
        'D_TB_GRN
        '
        Me.D_TB_GRN.Enabled = False
        Me.D_TB_GRN.Location = New System.Drawing.Point(408, 73)
        Me.D_TB_GRN.Name = "D_TB_GRN"
        Me.D_TB_GRN.ReadOnly = True
        Me.D_TB_GRN.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_GRN.TabIndex = 72
        '
        'D_Lbl_PNo
        '
        Me.D_Lbl_PNo.AutoSize = True
        Me.D_Lbl_PNo.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_PNo.Location = New System.Drawing.Point(9, 76)
        Me.D_Lbl_PNo.Name = "D_Lbl_PNo"
        Me.D_Lbl_PNo.Size = New System.Drawing.Size(68, 13)
        Me.D_Lbl_PNo.TabIndex = 69
        Me.D_Lbl_PNo.Text = "Payment ID :"
        '
        'D_GB_PmntMethod
        '
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_CshNChqNCred)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_ChqNCred)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_CashNCred)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_CashNChq)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_Cheque)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_Cash)
        Me.D_GB_PmntMethod.Location = New System.Drawing.Point(6, 19)
        Me.D_GB_PmntMethod.Name = "D_GB_PmntMethod"
        Me.D_GB_PmntMethod.Size = New System.Drawing.Size(863, 48)
        Me.D_GB_PmntMethod.TabIndex = 67
        Me.D_GB_PmntMethod.TabStop = False
        Me.D_GB_PmntMethod.Text = "Payment Method"
        '
        'D_RB_CshNChqNCred
        '
        Me.D_RB_CshNChqNCred.AutoSize = True
        Me.D_RB_CshNChqNCred.Enabled = False
        Me.D_RB_CshNChqNCred.Location = New System.Drawing.Point(261, 22)
        Me.D_RB_CshNChqNCred.Name = "D_RB_CshNChqNCred"
        Me.D_RB_CshNChqNCred.Size = New System.Drawing.Size(143, 17)
        Me.D_RB_CshNChqNCred.TabIndex = 9
        Me.D_RB_CshNChqNCred.Text = "Cash, Cheque and Credit"
        Me.D_RB_CshNChqNCred.UseVisualStyleBackColor = True
        '
        'D_RB_ChqNCred
        '
        Me.D_RB_ChqNCred.AutoSize = True
        Me.D_RB_ChqNCred.Enabled = False
        Me.D_RB_ChqNCred.Location = New System.Drawing.Point(727, 22)
        Me.D_RB_ChqNCred.Name = "D_RB_ChqNCred"
        Me.D_RB_ChqNCred.Size = New System.Drawing.Size(113, 17)
        Me.D_RB_ChqNCred.TabIndex = 12
        Me.D_RB_ChqNCred.Text = "Cheque and Credit"
        Me.D_RB_ChqNCred.UseVisualStyleBackColor = True
        '
        'D_RB_CashNCred
        '
        Me.D_RB_CashNCred.AutoSize = True
        Me.D_RB_CashNCred.Enabled = False
        Me.D_RB_CashNCred.Location = New System.Drawing.Point(469, 22)
        Me.D_RB_CashNCred.Name = "D_RB_CashNCred"
        Me.D_RB_CashNCred.Size = New System.Drawing.Size(100, 17)
        Me.D_RB_CashNCred.TabIndex = 10
        Me.D_RB_CashNCred.Text = "Cash and Credit"
        Me.D_RB_CashNCred.UseVisualStyleBackColor = True
        '
        'D_RB_CashNChq
        '
        Me.D_RB_CashNChq.AutoSize = True
        Me.D_RB_CashNChq.Enabled = False
        Me.D_RB_CashNChq.Location = New System.Drawing.Point(103, 22)
        Me.D_RB_CashNChq.Name = "D_RB_CashNChq"
        Me.D_RB_CashNChq.Size = New System.Drawing.Size(110, 17)
        Me.D_RB_CashNChq.TabIndex = 8
        Me.D_RB_CashNChq.Text = "Cash and Cheque"
        Me.D_RB_CashNChq.UseVisualStyleBackColor = True
        '
        'D_RB_Cheque
        '
        Me.D_RB_Cheque.AutoSize = True
        Me.D_RB_Cheque.Enabled = False
        Me.D_RB_Cheque.Location = New System.Drawing.Point(617, 22)
        Me.D_RB_Cheque.Name = "D_RB_Cheque"
        Me.D_RB_Cheque.Size = New System.Drawing.Size(62, 17)
        Me.D_RB_Cheque.TabIndex = 11
        Me.D_RB_Cheque.Text = "Cheque"
        Me.D_RB_Cheque.UseVisualStyleBackColor = True
        '
        'D_RB_Cash
        '
        Me.D_RB_Cash.AutoSize = True
        Me.D_RB_Cash.Enabled = False
        Me.D_RB_Cash.Location = New System.Drawing.Point(6, 22)
        Me.D_RB_Cash.Name = "D_RB_Cash"
        Me.D_RB_Cash.Size = New System.Drawing.Size(49, 17)
        Me.D_RB_Cash.TabIndex = 7
        Me.D_RB_Cash.Text = "Cash"
        Me.D_RB_Cash.UseVisualStyleBackColor = True
        '
        'D_Lbl_Chq_Paid
        '
        Me.D_Lbl_Chq_Paid.AutoSize = True
        Me.D_Lbl_Chq_Paid.Location = New System.Drawing.Point(580, 128)
        Me.D_Lbl_Chq_Paid.Name = "D_Lbl_Chq_Paid"
        Me.D_Lbl_Chq_Paid.Size = New System.Drawing.Size(74, 13)
        Me.D_Lbl_Chq_Paid.TabIndex = 53
        Me.D_Lbl_Chq_Paid.Text = "Cheque Paid :"
        '
        'D_Lbl_RCredit
        '
        Me.D_Lbl_RCredit.AutoSize = True
        Me.D_Lbl_RCredit.Location = New System.Drawing.Point(580, 102)
        Me.D_Lbl_RCredit.Name = "D_Lbl_RCredit"
        Me.D_Lbl_RCredit.Size = New System.Drawing.Size(78, 13)
        Me.D_Lbl_RCredit.TabIndex = 55
        Me.D_Lbl_RCredit.Text = "Invoice Credit :"
        '
        'D_DTP_PDD
        '
        Me.D_DTP_PDD.CustomFormat = "yyyy-MM-dd"
        Me.D_DTP_PDD.Enabled = False
        Me.D_DTP_PDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_DTP_PDD.Location = New System.Drawing.Point(408, 177)
        Me.D_DTP_PDD.Name = "D_DTP_PDD"
        Me.D_DTP_PDD.Size = New System.Drawing.Size(165, 20)
        Me.D_DTP_PDD.TabIndex = 66
        '
        'D_Lbl_DTP_PDD
        '
        Me.D_Lbl_DTP_PDD.AutoSize = True
        Me.D_Lbl_DTP_PDD.Location = New System.Drawing.Point(281, 180)
        Me.D_Lbl_DTP_PDD.Name = "D_Lbl_DTP_PDD"
        Me.D_Lbl_DTP_PDD.Size = New System.Drawing.Size(121, 13)
        Me.D_Lbl_DTP_PDD.TabIndex = 65
        Me.D_Lbl_DTP_PDD.Text = "Payment Delivery Date :"
        '
        'D_DTP_ChqDate
        '
        Me.D_DTP_ChqDate.CustomFormat = "yyyy-MM-dd"
        Me.D_DTP_ChqDate.Enabled = False
        Me.D_DTP_ChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_DTP_ChqDate.Location = New System.Drawing.Point(703, 151)
        Me.D_DTP_ChqDate.Name = "D_DTP_ChqDate"
        Me.D_DTP_ChqDate.Size = New System.Drawing.Size(165, 20)
        Me.D_DTP_ChqDate.TabIndex = 62
        '
        'D_Lbl_BN
        '
        Me.D_Lbl_BN.AutoSize = True
        Me.D_Lbl_BN.Location = New System.Drawing.Point(9, 180)
        Me.D_Lbl_BN.Name = "D_Lbl_BN"
        Me.D_Lbl_BN.Size = New System.Drawing.Size(69, 13)
        Me.D_Lbl_BN.TabIndex = 63
        Me.D_Lbl_BN.Text = "Bank Name :"
        '
        'D_Lbl_CD
        '
        Me.D_Lbl_CD.AutoSize = True
        Me.D_Lbl_CD.Location = New System.Drawing.Point(580, 154)
        Me.D_Lbl_CD.Name = "D_Lbl_CD"
        Me.D_Lbl_CD.Size = New System.Drawing.Size(76, 13)
        Me.D_Lbl_CD.TabIndex = 61
        Me.D_Lbl_CD.Text = "Cheque Date :"
        '
        'D_Lbl_CN
        '
        Me.D_Lbl_CN.AutoSize = True
        Me.D_Lbl_CN.Location = New System.Drawing.Point(281, 154)
        Me.D_Lbl_CN.Name = "D_Lbl_CN"
        Me.D_Lbl_CN.Size = New System.Drawing.Size(90, 13)
        Me.D_Lbl_CN.TabIndex = 59
        Me.D_Lbl_CN.Text = "Cheque Number :"
        '
        'D_Lbl_RN
        '
        Me.D_Lbl_RN.AutoSize = True
        Me.D_Lbl_RN.Location = New System.Drawing.Point(9, 154)
        Me.D_Lbl_RN.Name = "D_Lbl_RN"
        Me.D_Lbl_RN.Size = New System.Drawing.Size(94, 13)
        Me.D_Lbl_RN.TabIndex = 57
        Me.D_Lbl_RN.Text = "Receiver's Name :"
        '
        'D_Lbl_AP
        '
        Me.D_Lbl_AP.AutoSize = True
        Me.D_Lbl_AP.Location = New System.Drawing.Point(281, 128)
        Me.D_Lbl_AP.Name = "D_Lbl_AP"
        Me.D_Lbl_AP.Size = New System.Drawing.Size(100, 13)
        Me.D_Lbl_AP.TabIndex = 51
        Me.D_Lbl_AP.Text = "Amount Paid Cash :"
        '
        'D_Lbl_GRNTA
        '
        Me.D_Lbl_GRNTA.AutoSize = True
        Me.D_Lbl_GRNTA.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_GRNTA.Location = New System.Drawing.Point(281, 102)
        Me.D_Lbl_GRNTA.Name = "D_Lbl_GRNTA"
        Me.D_Lbl_GRNTA.Size = New System.Drawing.Size(103, 13)
        Me.D_Lbl_GRNTA.TabIndex = 49
        Me.D_Lbl_GRNTA.Text = "GRN Total Amount :"
        '
        'D_TB_PNo
        '
        Me.D_TB_PNo.Enabled = False
        Me.D_TB_PNo.Location = New System.Drawing.Point(110, 73)
        Me.D_TB_PNo.Name = "D_TB_PNo"
        Me.D_TB_PNo.ReadOnly = True
        Me.D_TB_PNo.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_PNo.TabIndex = 68
        '
        'D_TB_ChqPad
        '
        Me.D_TB_ChqPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_ChqPad.Enabled = False
        Me.D_TB_ChqPad.Location = New System.Drawing.Point(703, 125)
        Me.D_TB_ChqPad.Name = "D_TB_ChqPad"
        Me.D_TB_ChqPad.ReadOnly = True
        Me.D_TB_ChqPad.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_ChqPad.TabIndex = 54
        '
        'D_TB_RCredit
        '
        Me.D_TB_RCredit.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_RCredit.Enabled = False
        Me.D_TB_RCredit.Location = New System.Drawing.Point(703, 99)
        Me.D_TB_RCredit.Name = "D_TB_RCredit"
        Me.D_TB_RCredit.ReadOnly = True
        Me.D_TB_RCredit.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_RCredit.TabIndex = 56
        '
        'D_TB_AmntPad
        '
        Me.D_TB_AmntPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_AmntPad.Enabled = False
        Me.D_TB_AmntPad.Location = New System.Drawing.Point(408, 125)
        Me.D_TB_AmntPad.Name = "D_TB_AmntPad"
        Me.D_TB_AmntPad.ReadOnly = True
        Me.D_TB_AmntPad.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_AmntPad.TabIndex = 52
        '
        'D_TB_GRNTA
        '
        Me.D_TB_GRNTA.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_GRNTA.Enabled = False
        Me.D_TB_GRNTA.Location = New System.Drawing.Point(408, 99)
        Me.D_TB_GRNTA.Name = "D_TB_GRNTA"
        Me.D_TB_GRNTA.ReadOnly = True
        Me.D_TB_GRNTA.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_GRNTA.TabIndex = 50
        '
        'D_TB_BnkNam
        '
        Me.D_TB_BnkNam.Enabled = False
        Me.D_TB_BnkNam.Location = New System.Drawing.Point(110, 177)
        Me.D_TB_BnkNam.Name = "D_TB_BnkNam"
        Me.D_TB_BnkNam.ReadOnly = True
        Me.D_TB_BnkNam.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_BnkNam.TabIndex = 64
        '
        'D_TB_ChqNo
        '
        Me.D_TB_ChqNo.Enabled = False
        Me.D_TB_ChqNo.Location = New System.Drawing.Point(408, 151)
        Me.D_TB_ChqNo.Name = "D_TB_ChqNo"
        Me.D_TB_ChqNo.ReadOnly = True
        Me.D_TB_ChqNo.Size = New System.Drawing.Size(165, 20)
        Me.D_TB_ChqNo.TabIndex = 60
        '
        'D_GB_GRN_Selection
        '
        Me.D_GB_GRN_Selection.Controls.Add(Me.D_TB_DGV_Filter)
        Me.D_GB_GRN_Selection.Controls.Add(Me.D_RB_BySup)
        Me.D_GB_GRN_Selection.Controls.Add(Me.D_RB_ByInvNo)
        Me.D_GB_GRN_Selection.Controls.Add(Me.D_RB_ByGRN)
        Me.D_GB_GRN_Selection.Controls.Add(Me.D_DGV_Realize)
        Me.D_GB_GRN_Selection.Location = New System.Drawing.Point(6, 6)
        Me.D_GB_GRN_Selection.Name = "D_GB_GRN_Selection"
        Me.D_GB_GRN_Selection.Size = New System.Drawing.Size(875, 309)
        Me.D_GB_GRN_Selection.TabIndex = 56
        Me.D_GB_GRN_Selection.TabStop = False
        Me.D_GB_GRN_Selection.Text = "Select a Payment to Delete"
        '
        'D_TB_DGV_Filter
        '
        Me.D_TB_DGV_Filter.Location = New System.Drawing.Point(667, 19)
        Me.D_TB_DGV_Filter.Name = "D_TB_DGV_Filter"
        Me.D_TB_DGV_Filter.Size = New System.Drawing.Size(202, 20)
        Me.D_TB_DGV_Filter.TabIndex = 55
        '
        'D_RB_BySup
        '
        Me.D_RB_BySup.AutoSize = True
        Me.D_RB_BySup.Location = New System.Drawing.Point(547, 22)
        Me.D_RB_BySup.Name = "D_RB_BySup"
        Me.D_RB_BySup.Size = New System.Drawing.Size(114, 17)
        Me.D_RB_BySup.TabIndex = 54
        Me.D_RB_BySup.TabStop = True
        Me.D_RB_BySup.Text = "Search by Supplier"
        Me.D_RB_BySup.UseVisualStyleBackColor = True
        '
        'D_RB_ByInvNo
        '
        Me.D_RB_ByInvNo.AutoSize = True
        Me.D_RB_ByInvNo.Location = New System.Drawing.Point(389, 22)
        Me.D_RB_ByInvNo.Name = "D_RB_ByInvNo"
        Me.D_RB_ByInvNo.Size = New System.Drawing.Size(152, 17)
        Me.D_RB_ByInvNo.TabIndex = 53
        Me.D_RB_ByInvNo.TabStop = True
        Me.D_RB_ByInvNo.Text = "Search By Invoice Number"
        Me.D_RB_ByInvNo.UseVisualStyleBackColor = True
        '
        'D_RB_ByGRN
        '
        Me.D_RB_ByGRN.AutoSize = True
        Me.D_RB_ByGRN.Location = New System.Drawing.Point(257, 22)
        Me.D_RB_ByGRN.Name = "D_RB_ByGRN"
        Me.D_RB_ByGRN.Size = New System.Drawing.Size(126, 17)
        Me.D_RB_ByGRN.TabIndex = 52
        Me.D_RB_ByGRN.TabStop = True
        Me.D_RB_ByGRN.Text = "Search By Invoice ID"
        Me.D_RB_ByGRN.UseVisualStyleBackColor = True
        '
        'D_DGV_Realize
        '
        Me.D_DGV_Realize.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_DGV_Realize.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_DGV_Realize_TB_SNo, Me.D_DGV_Realize_TB_GRNNO, Me.D_DGV_Realize_TB_Invoice_No, Me.D_DGV_Realize_TB_PNo, Me.D_DGV_Realize_TB_Supplier, Me.D_DGV_Realize_TB_Company, Me.D_DGV_Realize_TB_GRNTA, Me.D_DGV_Realize_TB_InvoiceCredit, Me.D_DGV_Realize_TB_RBalance, Me.D_DGV_Realize_Btn_Realize})
        Me.D_DGV_Realize.Location = New System.Drawing.Point(3, 47)
        Me.D_DGV_Realize.Name = "D_DGV_Realize"
        Me.D_DGV_Realize.Size = New System.Drawing.Size(869, 256)
        Me.D_DGV_Realize.TabIndex = 51
        '
        'D_DGV_Realize_TB_SNo
        '
        Me.D_DGV_Realize_TB_SNo.HeaderText = "S.No"
        Me.D_DGV_Realize_TB_SNo.Name = "D_DGV_Realize_TB_SNo"
        Me.D_DGV_Realize_TB_SNo.Width = 50
        '
        'D_DGV_Realize_TB_GRNNO
        '
        Me.D_DGV_Realize_TB_GRNNO.HeaderText = "Invoice ID"
        Me.D_DGV_Realize_TB_GRNNO.Name = "D_DGV_Realize_TB_GRNNO"
        Me.D_DGV_Realize_TB_GRNNO.ReadOnly = True
        Me.D_DGV_Realize_TB_GRNNO.Width = 65
        '
        'D_DGV_Realize_TB_Invoice_No
        '
        Me.D_DGV_Realize_TB_Invoice_No.HeaderText = "Invoice No"
        Me.D_DGV_Realize_TB_Invoice_No.Name = "D_DGV_Realize_TB_Invoice_No"
        Me.D_DGV_Realize_TB_Invoice_No.ReadOnly = True
        Me.D_DGV_Realize_TB_Invoice_No.Width = 65
        '
        'D_DGV_Realize_TB_PNo
        '
        Me.D_DGV_Realize_TB_PNo.HeaderText = "Payment ID"
        Me.D_DGV_Realize_TB_PNo.Name = "D_DGV_Realize_TB_PNo"
        Me.D_DGV_Realize_TB_PNo.ReadOnly = True
        Me.D_DGV_Realize_TB_PNo.Width = 70
        '
        'D_DGV_Realize_TB_Supplier
        '
        Me.D_DGV_Realize_TB_Supplier.HeaderText = "Supplier"
        Me.D_DGV_Realize_TB_Supplier.Name = "D_DGV_Realize_TB_Supplier"
        Me.D_DGV_Realize_TB_Supplier.ReadOnly = True
        Me.D_DGV_Realize_TB_Supplier.Width = 120
        '
        'D_DGV_Realize_TB_Company
        '
        Me.D_DGV_Realize_TB_Company.HeaderText = "Company"
        Me.D_DGV_Realize_TB_Company.Name = "D_DGV_Realize_TB_Company"
        Me.D_DGV_Realize_TB_Company.ReadOnly = True
        Me.D_DGV_Realize_TB_Company.Width = 150
        '
        'D_DGV_Realize_TB_GRNTA
        '
        Me.D_DGV_Realize_TB_GRNTA.HeaderText = "GRN Total Amount"
        Me.D_DGV_Realize_TB_GRNTA.Name = "D_DGV_Realize_TB_GRNTA"
        Me.D_DGV_Realize_TB_GRNTA.ReadOnly = True
        Me.D_DGV_Realize_TB_GRNTA.Width = 85
        '
        'D_DGV_Realize_TB_InvoiceCredit
        '
        Me.D_DGV_Realize_TB_InvoiceCredit.HeaderText = "Invoice Credit"
        Me.D_DGV_Realize_TB_InvoiceCredit.Name = "D_DGV_Realize_TB_InvoiceCredit"
        Me.D_DGV_Realize_TB_InvoiceCredit.Width = 60
        '
        'D_DGV_Realize_TB_RBalance
        '
        Me.D_DGV_Realize_TB_RBalance.HeaderText = "Total Balance"
        Me.D_DGV_Realize_TB_RBalance.Name = "D_DGV_Realize_TB_RBalance"
        Me.D_DGV_Realize_TB_RBalance.ReadOnly = True
        Me.D_DGV_Realize_TB_RBalance.Width = 90
        '
        'D_DGV_Realize_Btn_Realize
        '
        Me.D_DGV_Realize_Btn_Realize.HeaderText = ""
        Me.D_DGV_Realize_Btn_Realize.Name = "D_DGV_Realize_Btn_Realize"
        Me.D_DGV_Realize_Btn_Realize.Width = 70
        '
        'D_CStatus
        '
        Me.D_CStatus.AutoSize = True
        Me.D_CStatus.Enabled = False
        Me.D_CStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.D_CStatus.Location = New System.Drawing.Point(94, 537)
        Me.D_CStatus.Name = "D_CStatus"
        Me.D_CStatus.Size = New System.Drawing.Size(47, 13)
        Me.D_CStatus.TabIndex = 55
        Me.D_CStatus.Text = "----------"
        '
        'D_Btn_Clrall
        '
        Me.D_Btn_Clrall.Location = New System.Drawing.Point(799, 532)
        Me.D_Btn_Clrall.Name = "D_Btn_Clrall"
        Me.D_Btn_Clrall.Size = New System.Drawing.Size(75, 23)
        Me.D_Btn_Clrall.TabIndex = 3
        Me.D_Btn_Clrall.Text = "Clear All"
        Me.D_Btn_Clrall.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(709, 532)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Delete.TabIndex = 2
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Invoice_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 592)
        Me.Controls.Add(Me.Tab_Control)
        Me.Name = "Invoice_Purchase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Purchased Invoice Payment"
        Me.Tab_Control.ResumeLayout(False)
        Me.TP_Add.ResumeLayout(False)
        Me.GB_Realize.ResumeLayout(False)
        Me.GB_Realize.PerformLayout()
        Me.GB_PmntMethod.ResumeLayout(False)
        Me.GB_PmntMethod.PerformLayout()
        Me.GB_GRN_Selection.ResumeLayout(False)
        Me.GB_GRN_Selection.PerformLayout()
        CType(Me.DGV_Realize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Update.ResumeLayout(False)
        Me.TP_Update.PerformLayout()
        Me.UD_GB_Realize.ResumeLayout(False)
        Me.UD_GB_Realize.PerformLayout()
        Me.UD_GB_PmntMethod.ResumeLayout(False)
        Me.UD_GB_PmntMethod.PerformLayout()
        Me.UD_GB_GRN_Selection.ResumeLayout(False)
        Me.UD_GB_GRN_Selection.PerformLayout()
        CType(Me.UD_New_DGV_Realize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UD_DGV_Realize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_Delete.ResumeLayout(False)
        Me.TP_Delete.PerformLayout()
        Me.D_GB_Realize.ResumeLayout(False)
        Me.D_GB_Realize.PerformLayout()
        Me.D_GB_PmntMethod.ResumeLayout(False)
        Me.D_GB_PmntMethod.PerformLayout()
        Me.D_GB_GRN_Selection.ResumeLayout(False)
        Me.D_GB_GRN_Selection.PerformLayout()
        CType(Me.D_DGV_Realize, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Control As System.Windows.Forms.TabControl
    Friend WithEvents TP_Update As System.Windows.Forms.TabPage
    Friend WithEvents UD_Btn_Clrall As System.Windows.Forms.Button
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents TP_Delete As System.Windows.Forms.TabPage
    Friend WithEvents D_Btn_Clrall As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents TP_Add As System.Windows.Forms.TabPage
    Friend WithEvents Btn_Clrall As System.Windows.Forms.Button
    Friend WithEvents GB_Realize As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_PCred As System.Windows.Forms.Label
    Friend WithEvents TB_PCred As CRMS.MathsTB
    Friend WithEvents Lbl_PNo As System.Windows.Forms.Label
    Friend WithEvents GB_PmntMethod As System.Windows.Forms.GroupBox
    Friend WithEvents RB_CshNChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CashNCred As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CashNChq As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Cash As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Chq_Paid As System.Windows.Forms.Label
    Friend WithEvents Btn_Submit As System.Windows.Forms.Button
    Friend WithEvents DTP_PDD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_DTP_PDD As System.Windows.Forms.Label
    Friend WithEvents DTP_ChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_BN As System.Windows.Forms.Label
    Friend WithEvents Lbl_CD As System.Windows.Forms.Label
    Friend WithEvents Lbl_CN As System.Windows.Forms.Label
    Friend WithEvents Lbl_RN As System.Windows.Forms.Label
    Friend WithEvents Lbl_AP As System.Windows.Forms.Label
    Friend WithEvents Lbl_GRNTA As System.Windows.Forms.Label
    Friend WithEvents TB_PmntID As CRMS.IntegerTB
    Friend WithEvents TB_ChqPad As CRMS.MathsTB
    Friend WithEvents TB_AmntPad As CRMS.MathsTB
    Friend WithEvents TB_GRNTA As CRMS.MathsTB
    Friend WithEvents TB_BnkNam As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_ChqNo As CRMS.IntegerTB
    Friend WithEvents TB_RecName As CRMS.CharMinusSpaceTB
    Friend WithEvents GB_GRN_Selection As System.Windows.Forms.GroupBox
    Friend WithEvents TB_DGV_Filter As System.Windows.Forms.TextBox
    Friend WithEvents RB_BySup As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ByInvNo As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ByGRN As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_GRN As System.Windows.Forms.Label
    Friend WithEvents TB_InvID As CRMS.IntegerTB
    Friend WithEvents DGV_Realize As System.Windows.Forms.DataGridView
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents UD_GB_Realize As System.Windows.Forms.GroupBox
    Friend WithEvents UD_Lbl_GRN As System.Windows.Forms.Label
    Friend WithEvents UD_TB_InvID As CRMS.IntegerTB
    Friend WithEvents UD_Lbl_InvCred As System.Windows.Forms.Label
    Friend WithEvents UD_TB_PCred As CRMS.MathsTB
    Friend WithEvents UD_Lbl_PNo As System.Windows.Forms.Label
    Friend WithEvents UD_GB_PmntMethod As System.Windows.Forms.GroupBox
    Friend WithEvents UD_RB_CshNChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_ChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_CashNCred As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_CashNChq As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_Cash As System.Windows.Forms.RadioButton
    Friend WithEvents UD_Lbl_Chq_Paid As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_RBalance As System.Windows.Forms.Label
    Friend WithEvents UD_DTP_PDD As System.Windows.Forms.DateTimePicker
    Friend WithEvents UD_Lbl_DTP_PDD As System.Windows.Forms.Label
    Friend WithEvents UD_DTP_ChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents UD_Lbl_BN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_CD As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_CN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_RN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_AP As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_GRNTA As System.Windows.Forms.Label
    Friend WithEvents UD_TB_PmntID As CRMS.IntegerTB
    Friend WithEvents UD_TB_ChqPad As CRMS.MathsTB
    Friend WithEvents UD_TB_RCredit As CRMS.MathsTB
    Friend WithEvents UD_TB_AmntPad As CRMS.MathsTB
    Friend WithEvents UD_TB_GRNTA As CRMS.MathsTB
    Friend WithEvents UD_TB_BnkNam As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_TB_ChqNo As CRMS.IntegerTB
    Friend WithEvents UD_TB_RecName As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_GB_GRN_Selection As System.Windows.Forms.GroupBox
    Friend WithEvents UD_TB_DGV_Filter As System.Windows.Forms.TextBox
    Friend WithEvents UD_RB_BySup As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_ByInvNo As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_ByGRN As System.Windows.Forms.RadioButton
    Friend WithEvents UD_DGV_Realize As System.Windows.Forms.DataGridView
    Friend WithEvents D_Lbl_Credit_Status As System.Windows.Forms.Label
    Friend WithEvents D_GB_Realize As System.Windows.Forms.GroupBox
    Friend WithEvents D_Lbl_GRN As System.Windows.Forms.Label
    Friend WithEvents D_TB_GRN As CRMS.IntegerTB
    Friend WithEvents D_Lbl_PNo As System.Windows.Forms.Label
    Friend WithEvents D_GB_PmntMethod As System.Windows.Forms.GroupBox
    Friend WithEvents D_RB_CshNChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_ChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_CashNCred As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_CashNChq As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_Cash As System.Windows.Forms.RadioButton
    Friend WithEvents D_Lbl_Chq_Paid As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_RCredit As System.Windows.Forms.Label
    Friend WithEvents D_DTP_PDD As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_Lbl_DTP_PDD As System.Windows.Forms.Label
    Friend WithEvents D_DTP_ChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_Lbl_BN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_CD As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_CN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_RN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_AP As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_GRNTA As System.Windows.Forms.Label
    Friend WithEvents D_TB_PNo As CRMS.IntegerTB
    Friend WithEvents D_TB_ChqPad As CRMS.MathsTB
    Friend WithEvents D_TB_RCredit As CRMS.MathsTB
    Friend WithEvents D_TB_GRNTA As CRMS.MathsTB
    Friend WithEvents D_TB_BnkNam As CRMS.CharMinusSpaceTB
    Friend WithEvents D_TB_ChqNo As CRMS.IntegerTB
    Friend WithEvents D_TB_RecName As CRMS.CharMinusSpaceTB
    Friend WithEvents D_GB_GRN_Selection As System.Windows.Forms.GroupBox
    Friend WithEvents D_TB_DGV_Filter As System.Windows.Forms.TextBox
    Friend WithEvents D_RB_BySup As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_ByInvNo As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_ByGRN As System.Windows.Forms.RadioButton
    Friend WithEvents D_DGV_Realize As System.Windows.Forms.DataGridView
    Friend WithEvents D_CStatus As System.Windows.Forms.Label
    Friend WithEvents D_TB_AmntPad As CRMS.MathsTB
    Friend WithEvents Lbl_RBalance As System.Windows.Forms.Label
    Friend WithEvents TB_TBalance As CRMS.MathsTB
    Friend WithEvents TB_RCredit As CRMS.MathsTB
    Friend WithEvents Lbl_InvCred As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_SName As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_CName As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_New_DGV_Realize As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UD_TB_SName As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_TB_CName As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_Lbl_PCred As System.Windows.Forms.Label
    Friend WithEvents UD_TB_TBalance As CRMS.MathsTB
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents D_TB_SName As CRMS.CharMinusSpaceTB
    Friend WithEvents D_TB_CName As CRMS.CharMinusSpaceTB
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents D_TB_PCred As CRMS.MathsTB
    Friend WithEvents D_TB_TBalance As CRMS.MathsTB
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_New_DGV_Realize_Btn_realize As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents D_DGV_Realize_TB_SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_GRNNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_Invoice_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_PNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_GRNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_InvoiceCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_TB_RBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Realize_Btn_Realize As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DGV_Realize_TB_SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_GRNNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_Invoice_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_PNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_GRNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_InvoiceCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_TB_TBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Realize_Btn_Realize As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents UD_DGV_Realize_TB_SNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_GRNNO As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_Invoice_No As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_PNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_Company As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_GRNTA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_InvoiceCredit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_TB_RBalance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Realize_Btn_Realize As System.Windows.Forms.DataGridViewButtonColumn
End Class
