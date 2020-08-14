<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sale))
        Me.Tab_Control = New System.Windows.Forms.TabControl()
        Me.TP_Add = New System.Windows.Forms.TabPage()
        Me.CStatus = New System.Windows.Forms.Label()
        Me.TC_GRN = New System.Windows.Forms.TabControl()
        Me.TP_GRN = New System.Windows.Forms.TabPage()
        Me.DTP_RecDate = New System.Windows.Forms.DateTimePicker()
        Me.DTP_Inv_Date = New System.Windows.Forms.DateTimePicker()
        Me.TB_IN = New CRMS.CharIntTB()
        Me.TB_GRN = New System.Windows.Forms.TextBox()
        Me.CB_SName = New System.Windows.Forms.ComboBox()
        Me.Lbl_SGRN_Pic = New System.Windows.Forms.Label()
        Me.Lbl_CName = New System.Windows.Forms.Label()
        Me.Btn_Pic_Browse = New System.Windows.Forms.Button()
        Me.Lbl_RD = New System.Windows.Forms.Label()
        Me.CB_CName = New System.Windows.Forms.ComboBox()
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Lbl_ID = New System.Windows.Forms.Label()
        Me.Lbl_IN = New System.Windows.Forms.Label()
        Me.Lbl_SName = New System.Windows.Forms.Label()
        Me.Lbl_GRN = New System.Windows.Forms.Label()
        Me.TP_GRNItems = New System.Windows.Forms.TabPage()
        Me.LBl_Return_Status = New System.Windows.Forms.Label()
        Me.GB_ItmTbl = New System.Windows.Forms.GroupBox()
        Me.DGV_Items = New System.Windows.Forms.DataGridView()
        Me.INo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Items = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Meters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Items_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DGV_Items_Del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TB_ItmNam = New System.Windows.Forms.TextBox()
        Me.Btn_AItem = New System.Windows.Forms.Button()
        Me.Lbl_TA = New System.Windows.Forms.Label()
        Me.Lbl_Mtr = New System.Windows.Forms.Label()
        Me.Lbl_Itm = New System.Windows.Forms.Label()
        Me.TB_TAmount = New CRMS.MathsTB()
        Me.TB_Metrs = New CRMS.MathsTB()
        Me.TP_GRNPayment = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_SNo = New System.Windows.Forms.Label()
        Me.GB_PmntMethod = New System.Windows.Forms.GroupBox()
        Me.RB_CshNChqNCred = New System.Windows.Forms.RadioButton()
        Me.RB_ChqNCred = New System.Windows.Forms.RadioButton()
        Me.RB_CashNCred = New System.Windows.Forms.RadioButton()
        Me.RB_CashNChq = New System.Windows.Forms.RadioButton()
        Me.RB_Credit = New System.Windows.Forms.RadioButton()
        Me.RB_Cheque = New System.Windows.Forms.RadioButton()
        Me.RB_Cash = New System.Windows.Forms.RadioButton()
        Me.Lbl_Chq_Paid = New System.Windows.Forms.Label()
        Me.Lbl_InvCredit = New System.Windows.Forms.Label()
        Me.DTP_PDD = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DTP_PDD = New System.Windows.Forms.Label()
        Me.DTP_ChqDate = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_BN = New System.Windows.Forms.Label()
        Me.Lbl_CD = New System.Windows.Forms.Label()
        Me.Lbl_CN = New System.Windows.Forms.Label()
        Me.Lbl_RN = New System.Windows.Forms.Label()
        Me.Lbl_AP = New System.Windows.Forms.Label()
        Me.Lbl_GRNTA = New System.Windows.Forms.Label()
        Me.TB_TBalance = New CRMS.MathsTB()
        Me.TB_PrevBalance = New CRMS.MathsTB()
        Me.TB_PID = New CRMS.IntegerTB()
        Me.TB_ChqPad = New CRMS.MathsTB()
        Me.TB_InvCredit = New CRMS.MathsTB()
        Me.TB_AmntPad = New CRMS.MathsTB()
        Me.TB_GRNTA = New CRMS.MathsTB()
        Me.TB_BnkNam = New CRMS.CharMinusSpaceTB()
        Me.TB_ChqNo = New CRMS.IntegerTB()
        Me.TB_RecName = New CRMS.CharMinusSpaceTB()
        Me.Btn_Clrall = New System.Windows.Forms.Button()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.TP_Update = New System.Windows.Forms.TabPage()
        Me.UD_Credit_Status = New System.Windows.Forms.Label()
        Me.UD_TC_GRN = New System.Windows.Forms.TabControl()
        Me.UD_TP_GRN = New System.Windows.Forms.TabPage()
        Me.UD_DTP_RecDate = New System.Windows.Forms.DateTimePicker()
        Me.UD_DTP_Inv_Date = New System.Windows.Forms.DateTimePicker()
        Me.UD_TB_IN = New CRMS.CharIntTB()
        Me.UD_TB_GRN = New System.Windows.Forms.TextBox()
        Me.UD_CB_SName = New System.Windows.Forms.ComboBox()
        Me.UD_Lbl_SGRN_Pic = New System.Windows.Forms.Label()
        Me.UD_Lbl_CName = New System.Windows.Forms.Label()
        Me.UD_Btn_Pic_Browse = New System.Windows.Forms.Button()
        Me.UD_Lbl_RD = New System.Windows.Forms.Label()
        Me.UD_CB_CName = New System.Windows.Forms.ComboBox()
        Me.UD_PictureBox = New System.Windows.Forms.PictureBox()
        Me.UD_Lbl_ID = New System.Windows.Forms.Label()
        Me.UD_Lbl_IN = New System.Windows.Forms.Label()
        Me.UD_Lbl_SName = New System.Windows.Forms.Label()
        Me.UD_Lbl_GRN = New System.Windows.Forms.Label()
        Me.UD_TP_GRNItems = New System.Windows.Forms.TabPage()
        Me.UD_LBl_Return_Status = New System.Windows.Forms.Label()
        Me.UD_GB_ItmTbl = New System.Windows.Forms.GroupBox()
        Me.UD_DGV_Items = New System.Windows.Forms.DataGridView()
        Me.UD_INo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_Items = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_Meters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_TAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UD_DGV_Items_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UD_DGV_Items_Del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.UD_TB_ItmNam = New System.Windows.Forms.TextBox()
        Me.UD_Btn_AItem = New System.Windows.Forms.Button()
        Me.UD_Lbl_TA = New System.Windows.Forms.Label()
        Me.UD_Lbl_Mtr = New System.Windows.Forms.Label()
        Me.UD_Lbl_Itm = New System.Windows.Forms.Label()
        Me.UD_TB_TAmount = New CRMS.MathsTB()
        Me.UD_TB_Metrs = New CRMS.MathsTB()
        Me.UD_TP_GRNPayment = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UD_Lbl_SNo = New System.Windows.Forms.Label()
        Me.UD_GB_PmntMethod = New System.Windows.Forms.GroupBox()
        Me.UD_RB_CshNChqNCred = New System.Windows.Forms.RadioButton()
        Me.UD_RB_ChqNCred = New System.Windows.Forms.RadioButton()
        Me.UD_RB_CashNCred = New System.Windows.Forms.RadioButton()
        Me.UD_RB_CashNChq = New System.Windows.Forms.RadioButton()
        Me.UD_RB_Credit = New System.Windows.Forms.RadioButton()
        Me.UD_RB_Cheque = New System.Windows.Forms.RadioButton()
        Me.UD_RB_Cash = New System.Windows.Forms.RadioButton()
        Me.UD_Lbl_Chq_Paid = New System.Windows.Forms.Label()
        Me.UD_Lbl_InvCredit = New System.Windows.Forms.Label()
        Me.UD_DTP_PDD = New System.Windows.Forms.DateTimePicker()
        Me.UD_Lbl_DTP_PDD = New System.Windows.Forms.Label()
        Me.UD_DTP_ChqDate = New System.Windows.Forms.DateTimePicker()
        Me.UD_Lbl_BN = New System.Windows.Forms.Label()
        Me.UD_Lbl_CD = New System.Windows.Forms.Label()
        Me.UD_Lbl_CN = New System.Windows.Forms.Label()
        Me.UD_Lbl_RN = New System.Windows.Forms.Label()
        Me.UD_Lbl_AP = New System.Windows.Forms.Label()
        Me.UD_Lbl_GRNTA = New System.Windows.Forms.Label()
        Me.UD_TB_TBalance = New CRMS.MathsTB()
        Me.UD_TB_PrevBalance = New CRMS.MathsTB()
        Me.UD_TB_PID = New CRMS.IntegerTB()
        Me.UD_TB_ChqPad = New CRMS.MathsTB()
        Me.UD_TB_InvCredit = New CRMS.MathsTB()
        Me.UD_TB_AmntPad = New CRMS.MathsTB()
        Me.UD_TB_GRNTA = New CRMS.MathsTB()
        Me.UD_TB_BnkNam = New CRMS.CharMinusSpaceTB()
        Me.UD_TB_ChqNo = New CRMS.IntegerTB()
        Me.UD_TB_RecName = New CRMS.CharMinusSpaceTB()
        Me.UD_Btn_Clrall = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.UD_GB_Browse = New System.Windows.Forms.GroupBox()
        Me.UD_Lbl_Browse = New System.Windows.Forms.Label()
        Me.Btn_UD_Load = New System.Windows.Forms.Button()
        Me.TB_UD_Load = New CRMS.MathsTB()
        Me.TP_Delete = New System.Windows.Forms.TabPage()
        Me.D_TC_GRN = New System.Windows.Forms.TabControl()
        Me.D_TP_GRN = New System.Windows.Forms.TabPage()
        Me.D_DTP_RecDate = New System.Windows.Forms.DateTimePicker()
        Me.D_DTP_Inv_Date = New System.Windows.Forms.DateTimePicker()
        Me.D_TB_IN = New CRMS.CharIntTB()
        Me.D_TB_GRN = New System.Windows.Forms.TextBox()
        Me.D_CB_SName = New System.Windows.Forms.ComboBox()
        Me.D_Lbl_CName = New System.Windows.Forms.Label()
        Me.D_Lbl_RD = New System.Windows.Forms.Label()
        Me.D_CB_CName = New System.Windows.Forms.ComboBox()
        Me.D_PictureBox = New System.Windows.Forms.PictureBox()
        Me.D_Lbl_ID = New System.Windows.Forms.Label()
        Me.D_Lbl_IN = New System.Windows.Forms.Label()
        Me.D_Lbl_SName = New System.Windows.Forms.Label()
        Me.D_Lbl_GRN = New System.Windows.Forms.Label()
        Me.D_TP_GRNItems = New System.Windows.Forms.TabPage()
        Me.D_GB_ItmTbl = New System.Windows.Forms.GroupBox()
        Me.D_DGV_Items = New System.Windows.Forms.DataGridView()
        Me.D_INo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_Items = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_Meters = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_TAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.D_DGV_Items_Edit = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.D_DGV_Items_Del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.D_TP_GRNPayment = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.D_Lbl_SNo = New System.Windows.Forms.Label()
        Me.D_GB_PmntMethod = New System.Windows.Forms.GroupBox()
        Me.D_RB_CshNChqNCred = New System.Windows.Forms.RadioButton()
        Me.D_RB_ChqNCred = New System.Windows.Forms.RadioButton()
        Me.D_RB_CashNCred = New System.Windows.Forms.RadioButton()
        Me.D_RB_CashNChq = New System.Windows.Forms.RadioButton()
        Me.D_RB_Credit = New System.Windows.Forms.RadioButton()
        Me.D_RB_Cheque = New System.Windows.Forms.RadioButton()
        Me.D_RB_Cash = New System.Windows.Forms.RadioButton()
        Me.D_Lbl_Chq_Paid = New System.Windows.Forms.Label()
        Me.D_Lbl_InvCredit = New System.Windows.Forms.Label()
        Me.D_DTP_PDD = New System.Windows.Forms.DateTimePicker()
        Me.D_Lbl_DTP_PDD = New System.Windows.Forms.Label()
        Me.D_DTP_ChqDate = New System.Windows.Forms.DateTimePicker()
        Me.D_Lbl_BN = New System.Windows.Forms.Label()
        Me.D_Lbl_CD = New System.Windows.Forms.Label()
        Me.D_Lbl_CN = New System.Windows.Forms.Label()
        Me.D_Lbl_RN = New System.Windows.Forms.Label()
        Me.D_Lbl_AP = New System.Windows.Forms.Label()
        Me.D_Lbl_GRNTA = New System.Windows.Forms.Label()
        Me.D_TB_TBalance = New CRMS.MathsTB()
        Me.D_TB_PrevBalance = New CRMS.MathsTB()
        Me.D_TB_PID = New CRMS.IntegerTB()
        Me.D_TB_ChqPad = New CRMS.MathsTB()
        Me.D_TB_InvCredit = New CRMS.MathsTB()
        Me.D_TB_AmntPad = New CRMS.MathsTB()
        Me.D_TB_GRNTA = New CRMS.MathsTB()
        Me.D_TB_BnkNam = New CRMS.CharMinusSpaceTB()
        Me.D_TB_ChqNo = New CRMS.IntegerTB()
        Me.D_TB_RecName = New CRMS.CharMinusSpaceTB()
        Me.D_Btn_Clrall = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.D_GB_Browse = New System.Windows.Forms.GroupBox()
        Me.TB_D_Load = New System.Windows.Forms.TextBox()
        Me.D_Lbl_Browse = New System.Windows.Forms.Label()
        Me.Btn_D_Load = New System.Windows.Forms.Button()
        Me.Tab_Control.SuspendLayout()
        Me.TP_Add.SuspendLayout()
        Me.TC_GRN.SuspendLayout()
        Me.TP_GRN.SuspendLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_GRNItems.SuspendLayout()
        Me.GB_ItmTbl.SuspendLayout()
        CType(Me.DGV_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TP_GRNPayment.SuspendLayout()
        Me.GB_PmntMethod.SuspendLayout()
        Me.TP_Update.SuspendLayout()
        Me.UD_TC_GRN.SuspendLayout()
        Me.UD_TP_GRN.SuspendLayout()
        CType(Me.UD_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UD_TP_GRNItems.SuspendLayout()
        Me.UD_GB_ItmTbl.SuspendLayout()
        CType(Me.UD_DGV_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UD_TP_GRNPayment.SuspendLayout()
        Me.UD_GB_PmntMethod.SuspendLayout()
        Me.UD_GB_Browse.SuspendLayout()
        Me.TP_Delete.SuspendLayout()
        Me.D_TC_GRN.SuspendLayout()
        Me.D_TP_GRN.SuspendLayout()
        CType(Me.D_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.D_TP_GRNItems.SuspendLayout()
        Me.D_GB_ItmTbl.SuspendLayout()
        CType(Me.D_DGV_Items, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.D_TP_GRNPayment.SuspendLayout()
        Me.D_GB_PmntMethod.SuspendLayout()
        Me.D_GB_Browse.SuspendLayout()
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
        Me.Tab_Control.Size = New System.Drawing.Size(526, 477)
        Me.Tab_Control.TabIndex = 0
        '
        'TP_Add
        '
        Me.TP_Add.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Add.Controls.Add(Me.CStatus)
        Me.TP_Add.Controls.Add(Me.TC_GRN)
        Me.TP_Add.Controls.Add(Me.Btn_Clrall)
        Me.TP_Add.Controls.Add(Me.Btn_Submit)
        Me.TP_Add.Location = New System.Drawing.Point(4, 25)
        Me.TP_Add.Name = "TP_Add"
        Me.TP_Add.Size = New System.Drawing.Size(518, 448)
        Me.TP_Add.TabIndex = 2
        Me.TP_Add.Text = "Add Invoice"
        '
        'CStatus
        '
        Me.CStatus.AutoSize = True
        Me.CStatus.Enabled = False
        Me.CStatus.Location = New System.Drawing.Point(10, 420)
        Me.CStatus.Name = "CStatus"
        Me.CStatus.Size = New System.Drawing.Size(37, 13)
        Me.CStatus.TabIndex = 14
        Me.CStatus.Text = "Active"
        Me.CStatus.Visible = False
        '
        'TC_GRN
        '
        Me.TC_GRN.Controls.Add(Me.TP_GRN)
        Me.TC_GRN.Controls.Add(Me.TP_GRNItems)
        Me.TC_GRN.Controls.Add(Me.TP_GRNPayment)
        Me.TC_GRN.Location = New System.Drawing.Point(3, 63)
        Me.TC_GRN.Name = "TC_GRN"
        Me.TC_GRN.SelectedIndex = 0
        Me.TC_GRN.Size = New System.Drawing.Size(513, 346)
        Me.TC_GRN.TabIndex = 0
        '
        'TP_GRN
        '
        Me.TP_GRN.Controls.Add(Me.DTP_RecDate)
        Me.TP_GRN.Controls.Add(Me.DTP_Inv_Date)
        Me.TP_GRN.Controls.Add(Me.TB_IN)
        Me.TP_GRN.Controls.Add(Me.TB_GRN)
        Me.TP_GRN.Controls.Add(Me.CB_SName)
        Me.TP_GRN.Controls.Add(Me.Lbl_SGRN_Pic)
        Me.TP_GRN.Controls.Add(Me.Lbl_CName)
        Me.TP_GRN.Controls.Add(Me.Btn_Pic_Browse)
        Me.TP_GRN.Controls.Add(Me.Lbl_RD)
        Me.TP_GRN.Controls.Add(Me.CB_CName)
        Me.TP_GRN.Controls.Add(Me.PictureBox)
        Me.TP_GRN.Controls.Add(Me.Lbl_ID)
        Me.TP_GRN.Controls.Add(Me.Lbl_IN)
        Me.TP_GRN.Controls.Add(Me.Lbl_SName)
        Me.TP_GRN.Controls.Add(Me.Lbl_GRN)
        Me.TP_GRN.Location = New System.Drawing.Point(4, 22)
        Me.TP_GRN.Name = "TP_GRN"
        Me.TP_GRN.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_GRN.Size = New System.Drawing.Size(505, 320)
        Me.TP_GRN.TabIndex = 0
        Me.TP_GRN.Text = "Invoice Information"
        Me.TP_GRN.UseVisualStyleBackColor = True
        '
        'DTP_RecDate
        '
        Me.DTP_RecDate.CustomFormat = "yyyy-MM-dd"
        Me.DTP_RecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_RecDate.Location = New System.Drawing.Point(133, 151)
        Me.DTP_RecDate.Name = "DTP_RecDate"
        Me.DTP_RecDate.Size = New System.Drawing.Size(159, 20)
        Me.DTP_RecDate.TabIndex = 11
        '
        'DTP_Inv_Date
        '
        Me.DTP_Inv_Date.CustomFormat = "yyyy-MM-dd"
        Me.DTP_Inv_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_Inv_Date.Location = New System.Drawing.Point(133, 125)
        Me.DTP_Inv_Date.Name = "DTP_Inv_Date"
        Me.DTP_Inv_Date.Size = New System.Drawing.Size(159, 20)
        Me.DTP_Inv_Date.TabIndex = 9
        '
        'TB_IN
        '
        Me.TB_IN.Location = New System.Drawing.Point(133, 99)
        Me.TB_IN.Name = "TB_IN"
        Me.TB_IN.Size = New System.Drawing.Size(159, 20)
        Me.TB_IN.TabIndex = 7
        '
        'TB_GRN
        '
        Me.TB_GRN.Enabled = False
        Me.TB_GRN.Location = New System.Drawing.Point(133, 19)
        Me.TB_GRN.Name = "TB_GRN"
        Me.TB_GRN.ReadOnly = True
        Me.TB_GRN.Size = New System.Drawing.Size(159, 20)
        Me.TB_GRN.TabIndex = 1
        '
        'CB_SName
        '
        Me.CB_SName.FormattingEnabled = True
        Me.CB_SName.Location = New System.Drawing.Point(133, 45)
        Me.CB_SName.Name = "CB_SName"
        Me.CB_SName.Size = New System.Drawing.Size(159, 21)
        Me.CB_SName.TabIndex = 3
        '
        'Lbl_SGRN_Pic
        '
        Me.Lbl_SGRN_Pic.AutoSize = True
        Me.Lbl_SGRN_Pic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Lbl_SGRN_Pic.Location = New System.Drawing.Point(83, 246)
        Me.Lbl_SGRN_Pic.Name = "Lbl_SGRN_Pic"
        Me.Lbl_SGRN_Pic.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_SGRN_Pic.TabIndex = 12
        Me.Lbl_SGRN_Pic.Text = "Select Invoice Image :"
        '
        'Lbl_CName
        '
        Me.Lbl_CName.AutoSize = True
        Me.Lbl_CName.ForeColor = System.Drawing.Color.Red
        Me.Lbl_CName.Location = New System.Drawing.Point(6, 75)
        Me.Lbl_CName.Name = "Lbl_CName"
        Me.Lbl_CName.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_CName.TabIndex = 4
        Me.Lbl_CName.Text = "Company's Name :"
        '
        'Btn_Pic_Browse
        '
        Me.Btn_Pic_Browse.Location = New System.Drawing.Point(202, 241)
        Me.Btn_Pic_Browse.Name = "Btn_Pic_Browse"
        Me.Btn_Pic_Browse.Size = New System.Drawing.Size(90, 23)
        Me.Btn_Pic_Browse.TabIndex = 13
        Me.Btn_Pic_Browse.Text = "Browse"
        Me.Btn_Pic_Browse.UseVisualStyleBackColor = True
        '
        'Lbl_RD
        '
        Me.Lbl_RD.AutoSize = True
        Me.Lbl_RD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_RD.Location = New System.Drawing.Point(6, 157)
        Me.Lbl_RD.Name = "Lbl_RD"
        Me.Lbl_RD.Size = New System.Drawing.Size(121, 13)
        Me.Lbl_RD.TabIndex = 10
        Me.Lbl_RD.Text = "Goods Receiving Date :"
        '
        'CB_CName
        '
        Me.CB_CName.FormattingEnabled = True
        Me.CB_CName.Location = New System.Drawing.Point(133, 72)
        Me.CB_CName.Name = "CB_CName"
        Me.CB_CName.Size = New System.Drawing.Size(159, 21)
        Me.CB_CName.TabIndex = 5
        '
        'PictureBox
        '
        Me.PictureBox.Image = CType(resources.GetObject("PictureBox.Image"), System.Drawing.Image)
        Me.PictureBox.Location = New System.Drawing.Point(298, 6)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(201, 308)
        Me.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox.TabIndex = 5
        Me.PictureBox.TabStop = False
        '
        'Lbl_ID
        '
        Me.Lbl_ID.AutoSize = True
        Me.Lbl_ID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_ID.Location = New System.Drawing.Point(6, 131)
        Me.Lbl_ID.Name = "Lbl_ID"
        Me.Lbl_ID.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_ID.TabIndex = 8
        Me.Lbl_ID.Text = "Invoice Date :"
        '
        'Lbl_IN
        '
        Me.Lbl_IN.AutoSize = True
        Me.Lbl_IN.ForeColor = System.Drawing.Color.Red
        Me.Lbl_IN.Location = New System.Drawing.Point(6, 102)
        Me.Lbl_IN.Name = "Lbl_IN"
        Me.Lbl_IN.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_IN.TabIndex = 6
        Me.Lbl_IN.Text = "Invoice No :"
        '
        'Lbl_SName
        '
        Me.Lbl_SName.AutoSize = True
        Me.Lbl_SName.ForeColor = System.Drawing.Color.Red
        Me.Lbl_SName.Location = New System.Drawing.Point(6, 48)
        Me.Lbl_SName.Name = "Lbl_SName"
        Me.Lbl_SName.Size = New System.Drawing.Size(89, 13)
        Me.Lbl_SName.TabIndex = 2
        Me.Lbl_SName.Text = "Supplier's Name :"
        '
        'Lbl_GRN
        '
        Me.Lbl_GRN.AutoSize = True
        Me.Lbl_GRN.ForeColor = System.Drawing.Color.Red
        Me.Lbl_GRN.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_GRN.Name = "Lbl_GRN"
        Me.Lbl_GRN.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_GRN.TabIndex = 0
        Me.Lbl_GRN.Text = "Invoice ID :"
        '
        'TP_GRNItems
        '
        Me.TP_GRNItems.Controls.Add(Me.LBl_Return_Status)
        Me.TP_GRNItems.Controls.Add(Me.GB_ItmTbl)
        Me.TP_GRNItems.Controls.Add(Me.TB_ItmNam)
        Me.TP_GRNItems.Controls.Add(Me.Btn_AItem)
        Me.TP_GRNItems.Controls.Add(Me.Lbl_TA)
        Me.TP_GRNItems.Controls.Add(Me.Lbl_Mtr)
        Me.TP_GRNItems.Controls.Add(Me.Lbl_Itm)
        Me.TP_GRNItems.Controls.Add(Me.TB_TAmount)
        Me.TP_GRNItems.Controls.Add(Me.TB_Metrs)
        Me.TP_GRNItems.Location = New System.Drawing.Point(4, 22)
        Me.TP_GRNItems.Name = "TP_GRNItems"
        Me.TP_GRNItems.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_GRNItems.Size = New System.Drawing.Size(505, 320)
        Me.TP_GRNItems.TabIndex = 1
        Me.TP_GRNItems.Text = "Invoice Items"
        Me.TP_GRNItems.UseVisualStyleBackColor = True
        '
        'LBl_Return_Status
        '
        Me.LBl_Return_Status.AutoSize = True
        Me.LBl_Return_Status.Enabled = False
        Me.LBl_Return_Status.Location = New System.Drawing.Point(449, 42)
        Me.LBl_Return_Status.Name = "LBl_Return_Status"
        Me.LBl_Return_Status.Size = New System.Drawing.Size(50, 13)
        Me.LBl_Return_Status.TabIndex = 8
        Me.LBl_Return_Status.Text = "Available"
        Me.LBl_Return_Status.Visible = False
        '
        'GB_ItmTbl
        '
        Me.GB_ItmTbl.BackColor = System.Drawing.Color.Transparent
        Me.GB_ItmTbl.Controls.Add(Me.DGV_Items)
        Me.GB_ItmTbl.ForeColor = System.Drawing.Color.Red
        Me.GB_ItmTbl.Location = New System.Drawing.Point(6, 67)
        Me.GB_ItmTbl.Name = "GB_ItmTbl"
        Me.GB_ItmTbl.Size = New System.Drawing.Size(493, 247)
        Me.GB_ItmTbl.TabIndex = 7
        Me.GB_ItmTbl.TabStop = False
        Me.GB_ItmTbl.Text = "List of Items"
        '
        'DGV_Items
        '
        Me.DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.INo, Me.Items, Me.Meters, Me.TAmount, Me.DGV_Items_Edit, Me.DGV_Items_Del})
        Me.DGV_Items.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV_Items.Location = New System.Drawing.Point(3, 16)
        Me.DGV_Items.Name = "DGV_Items"
        Me.DGV_Items.Size = New System.Drawing.Size(487, 228)
        Me.DGV_Items.TabIndex = 8
        '
        'INo
        '
        Me.INo.HeaderText = "Item No"
        Me.INo.Name = "INo"
        Me.INo.ReadOnly = True
        Me.INo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.INo.Width = 70
        '
        'Items
        '
        Me.Items.HeaderText = "Item"
        Me.Items.Name = "Items"
        Me.Items.ReadOnly = True
        '
        'Meters
        '
        Me.Meters.HeaderText = "Meters / Qty"
        Me.Meters.Name = "Meters"
        Me.Meters.ReadOnly = True
        Me.Meters.Width = 80
        '
        'TAmount
        '
        Me.TAmount.HeaderText = "Total Price"
        Me.TAmount.Name = "TAmount"
        Me.TAmount.ReadOnly = True
        Me.TAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TAmount.Width = 94
        '
        'DGV_Items_Edit
        '
        Me.DGV_Items_Edit.HeaderText = ""
        Me.DGV_Items_Edit.Name = "DGV_Items_Edit"
        Me.DGV_Items_Edit.ReadOnly = True
        Me.DGV_Items_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Items_Edit.Width = 50
        '
        'DGV_Items_Del
        '
        Me.DGV_Items_Del.HeaderText = ""
        Me.DGV_Items_Del.Name = "DGV_Items_Del"
        Me.DGV_Items_Del.ReadOnly = True
        Me.DGV_Items_Del.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Items_Del.Width = 50
        '
        'TB_ItmNam
        '
        Me.TB_ItmNam.Location = New System.Drawing.Point(102, 13)
        Me.TB_ItmNam.Name = "TB_ItmNam"
        Me.TB_ItmNam.Size = New System.Drawing.Size(145, 20)
        Me.TB_ItmNam.TabIndex = 1
        '
        'Btn_AItem
        '
        Me.Btn_AItem.Location = New System.Drawing.Point(354, 37)
        Me.Btn_AItem.Name = "Btn_AItem"
        Me.Btn_AItem.Size = New System.Drawing.Size(75, 23)
        Me.Btn_AItem.TabIndex = 6
        Me.Btn_AItem.Text = "Add"
        Me.Btn_AItem.UseVisualStyleBackColor = True
        '
        'Lbl_TA
        '
        Me.Lbl_TA.AutoSize = True
        Me.Lbl_TA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_TA.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_TA.Name = "Lbl_TA"
        Me.Lbl_TA.Size = New System.Drawing.Size(90, 13)
        Me.Lbl_TA.TabIndex = 4
        Me.Lbl_TA.Text = "Item's total Price :"
        '
        'Lbl_Mtr
        '
        Me.Lbl_Mtr.AutoSize = True
        Me.Lbl_Mtr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_Mtr.Location = New System.Drawing.Point(276, 16)
        Me.Lbl_Mtr.Name = "Lbl_Mtr"
        Me.Lbl_Mtr.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_Mtr.TabIndex = 2
        Me.Lbl_Mtr.Text = "Meters / Qty :"
        '
        'Lbl_Itm
        '
        Me.Lbl_Itm.AutoSize = True
        Me.Lbl_Itm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lbl_Itm.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_Itm.Name = "Lbl_Itm"
        Me.Lbl_Itm.Size = New System.Drawing.Size(33, 13)
        Me.Lbl_Itm.TabIndex = 0
        Me.Lbl_Itm.Text = "Item :"
        '
        'TB_TAmount
        '
        Me.TB_TAmount.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_TAmount.Location = New System.Drawing.Point(102, 39)
        Me.TB_TAmount.Name = "TB_TAmount"
        Me.TB_TAmount.Size = New System.Drawing.Size(145, 20)
        Me.TB_TAmount.TabIndex = 5
        '
        'TB_Metrs
        '
        Me.TB_Metrs.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_Metrs.Location = New System.Drawing.Point(354, 13)
        Me.TB_Metrs.Name = "TB_Metrs"
        Me.TB_Metrs.Size = New System.Drawing.Size(145, 20)
        Me.TB_Metrs.TabIndex = 3
        '
        'TP_GRNPayment
        '
        Me.TP_GRNPayment.Controls.Add(Me.Label8)
        Me.TP_GRNPayment.Controls.Add(Me.Label2)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_SNo)
        Me.TP_GRNPayment.Controls.Add(Me.GB_PmntMethod)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_Chq_Paid)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_InvCredit)
        Me.TP_GRNPayment.Controls.Add(Me.DTP_PDD)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_DTP_PDD)
        Me.TP_GRNPayment.Controls.Add(Me.DTP_ChqDate)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_BN)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_CD)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_CN)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_RN)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_AP)
        Me.TP_GRNPayment.Controls.Add(Me.Lbl_GRNTA)
        Me.TP_GRNPayment.Controls.Add(Me.TB_TBalance)
        Me.TP_GRNPayment.Controls.Add(Me.TB_PrevBalance)
        Me.TP_GRNPayment.Controls.Add(Me.TB_PID)
        Me.TP_GRNPayment.Controls.Add(Me.TB_ChqPad)
        Me.TP_GRNPayment.Controls.Add(Me.TB_InvCredit)
        Me.TP_GRNPayment.Controls.Add(Me.TB_AmntPad)
        Me.TP_GRNPayment.Controls.Add(Me.TB_GRNTA)
        Me.TP_GRNPayment.Controls.Add(Me.TB_BnkNam)
        Me.TP_GRNPayment.Controls.Add(Me.TB_ChqNo)
        Me.TP_GRNPayment.Controls.Add(Me.TB_RecName)
        Me.TP_GRNPayment.Location = New System.Drawing.Point(4, 22)
        Me.TP_GRNPayment.Name = "TP_GRNPayment"
        Me.TP_GRNPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_GRNPayment.Size = New System.Drawing.Size(505, 320)
        Me.TP_GRNPayment.TabIndex = 2
        Me.TP_GRNPayment.Text = "Invoice Payment"
        Me.TP_GRNPayment.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(292, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Total Balance :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Previous Balance :"
        '
        'Lbl_SNo
        '
        Me.Lbl_SNo.AutoSize = True
        Me.Lbl_SNo.ForeColor = System.Drawing.Color.Red
        Me.Lbl_SNo.Location = New System.Drawing.Point(6, 83)
        Me.Lbl_SNo.Name = "Lbl_SNo"
        Me.Lbl_SNo.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_SNo.TabIndex = 27
        Me.Lbl_SNo.Text = "Payment ID :"
        '
        'GB_PmntMethod
        '
        Me.GB_PmntMethod.Controls.Add(Me.RB_CshNChqNCred)
        Me.GB_PmntMethod.Controls.Add(Me.RB_ChqNCred)
        Me.GB_PmntMethod.Controls.Add(Me.RB_CashNCred)
        Me.GB_PmntMethod.Controls.Add(Me.RB_CashNChq)
        Me.GB_PmntMethod.Controls.Add(Me.RB_Credit)
        Me.GB_PmntMethod.Controls.Add(Me.RB_Cheque)
        Me.GB_PmntMethod.Controls.Add(Me.RB_Cash)
        Me.GB_PmntMethod.Location = New System.Drawing.Point(6, 10)
        Me.GB_PmntMethod.Name = "GB_PmntMethod"
        Me.GB_PmntMethod.Size = New System.Drawing.Size(493, 64)
        Me.GB_PmntMethod.TabIndex = 25
        Me.GB_PmntMethod.TabStop = False
        Me.GB_PmntMethod.Text = "Payment Method (How the money was paid.)"
        '
        'RB_CshNChqNCred
        '
        Me.RB_CshNChqNCred.AutoSize = True
        Me.RB_CshNChqNCred.Location = New System.Drawing.Point(344, 16)
        Me.RB_CshNChqNCred.Name = "RB_CshNChqNCred"
        Me.RB_CshNChqNCred.Size = New System.Drawing.Size(143, 17)
        Me.RB_CshNChqNCred.TabIndex = 9
        Me.RB_CshNChqNCred.Text = "Cash, Cheque and Credit"
        Me.RB_CshNChqNCred.UseVisualStyleBackColor = True
        '
        'RB_ChqNCred
        '
        Me.RB_ChqNCred.AutoSize = True
        Me.RB_ChqNCred.Location = New System.Drawing.Point(101, 39)
        Me.RB_ChqNCred.Name = "RB_ChqNCred"
        Me.RB_ChqNCred.Size = New System.Drawing.Size(113, 17)
        Me.RB_ChqNCred.TabIndex = 12
        Me.RB_ChqNCred.Text = "Cheque and Credit"
        Me.RB_ChqNCred.UseVisualStyleBackColor = True
        '
        'RB_CashNCred
        '
        Me.RB_CashNCred.AutoSize = True
        Me.RB_CashNCred.Location = New System.Drawing.Point(221, 16)
        Me.RB_CashNCred.Name = "RB_CashNCred"
        Me.RB_CashNCred.Size = New System.Drawing.Size(100, 17)
        Me.RB_CashNCred.TabIndex = 10
        Me.RB_CashNCred.Text = "Cash and Credit"
        Me.RB_CashNCred.UseVisualStyleBackColor = True
        '
        'RB_CashNChq
        '
        Me.RB_CashNChq.AutoSize = True
        Me.RB_CashNChq.Location = New System.Drawing.Point(101, 16)
        Me.RB_CashNChq.Name = "RB_CashNChq"
        Me.RB_CashNChq.Size = New System.Drawing.Size(110, 17)
        Me.RB_CashNChq.TabIndex = 8
        Me.RB_CashNChq.Text = "Cash and Cheque"
        Me.RB_CashNChq.UseVisualStyleBackColor = True
        '
        'RB_Credit
        '
        Me.RB_Credit.AutoSize = True
        Me.RB_Credit.Location = New System.Drawing.Point(221, 39)
        Me.RB_Credit.Name = "RB_Credit"
        Me.RB_Credit.Size = New System.Drawing.Size(52, 17)
        Me.RB_Credit.TabIndex = 13
        Me.RB_Credit.Text = "Credit"
        Me.RB_Credit.UseVisualStyleBackColor = True
        '
        'RB_Cheque
        '
        Me.RB_Cheque.AutoSize = True
        Me.RB_Cheque.Location = New System.Drawing.Point(6, 39)
        Me.RB_Cheque.Name = "RB_Cheque"
        Me.RB_Cheque.Size = New System.Drawing.Size(62, 17)
        Me.RB_Cheque.TabIndex = 11
        Me.RB_Cheque.Text = "Cheque"
        Me.RB_Cheque.UseVisualStyleBackColor = True
        '
        'RB_Cash
        '
        Me.RB_Cash.AutoSize = True
        Me.RB_Cash.Location = New System.Drawing.Point(6, 16)
        Me.RB_Cash.Name = "RB_Cash"
        Me.RB_Cash.Size = New System.Drawing.Size(49, 17)
        Me.RB_Cash.TabIndex = 7
        Me.RB_Cash.Text = "Cash"
        Me.RB_Cash.UseVisualStyleBackColor = True
        '
        'Lbl_Chq_Paid
        '
        Me.Lbl_Chq_Paid.AutoSize = True
        Me.Lbl_Chq_Paid.Location = New System.Drawing.Point(292, 109)
        Me.Lbl_Chq_Paid.Name = "Lbl_Chq_Paid"
        Me.Lbl_Chq_Paid.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Chq_Paid.TabIndex = 11
        Me.Lbl_Chq_Paid.Text = "Cheque Paid :"
        '
        'Lbl_InvCredit
        '
        Me.Lbl_InvCredit.AutoSize = True
        Me.Lbl_InvCredit.Location = New System.Drawing.Point(6, 135)
        Me.Lbl_InvCredit.Name = "Lbl_InvCredit"
        Me.Lbl_InvCredit.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_InvCredit.TabIndex = 13
        Me.Lbl_InvCredit.Text = "Invoice Credit :"
        '
        'DTP_PDD
        '
        Me.DTP_PDD.CustomFormat = "yyyy-MM-dd"
        Me.DTP_PDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_PDD.Location = New System.Drawing.Point(133, 262)
        Me.DTP_PDD.Name = "DTP_PDD"
        Me.DTP_PDD.Size = New System.Drawing.Size(366, 20)
        Me.DTP_PDD.TabIndex = 24
        '
        'Lbl_DTP_PDD
        '
        Me.Lbl_DTP_PDD.AutoSize = True
        Me.Lbl_DTP_PDD.Location = New System.Drawing.Point(6, 268)
        Me.Lbl_DTP_PDD.Name = "Lbl_DTP_PDD"
        Me.Lbl_DTP_PDD.Size = New System.Drawing.Size(80, 13)
        Me.Lbl_DTP_PDD.TabIndex = 23
        Me.Lbl_DTP_PDD.Text = "Payment Date :"
        '
        'DTP_ChqDate
        '
        Me.DTP_ChqDate.CustomFormat = "yyyy-MM-dd"
        Me.DTP_ChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP_ChqDate.Location = New System.Drawing.Point(133, 210)
        Me.DTP_ChqDate.Name = "DTP_ChqDate"
        Me.DTP_ChqDate.Size = New System.Drawing.Size(366, 20)
        Me.DTP_ChqDate.TabIndex = 20
        '
        'Lbl_BN
        '
        Me.Lbl_BN.AutoSize = True
        Me.Lbl_BN.Location = New System.Drawing.Point(6, 239)
        Me.Lbl_BN.Name = "Lbl_BN"
        Me.Lbl_BN.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_BN.TabIndex = 21
        Me.Lbl_BN.Text = "Bank's Name :"
        '
        'Lbl_CD
        '
        Me.Lbl_CD.AutoSize = True
        Me.Lbl_CD.Location = New System.Drawing.Point(6, 216)
        Me.Lbl_CD.Name = "Lbl_CD"
        Me.Lbl_CD.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_CD.TabIndex = 19
        Me.Lbl_CD.Text = "Cheque Date :"
        '
        'Lbl_CN
        '
        Me.Lbl_CN.AutoSize = True
        Me.Lbl_CN.Location = New System.Drawing.Point(6, 187)
        Me.Lbl_CN.Name = "Lbl_CN"
        Me.Lbl_CN.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_CN.TabIndex = 17
        Me.Lbl_CN.Text = "Cheque No :"
        '
        'Lbl_RN
        '
        Me.Lbl_RN.AutoSize = True
        Me.Lbl_RN.Location = New System.Drawing.Point(6, 161)
        Me.Lbl_RN.Name = "Lbl_RN"
        Me.Lbl_RN.Size = New System.Drawing.Size(121, 13)
        Me.Lbl_RN.TabIndex = 15
        Me.Lbl_RN.Text = "Cash Receiver's Name :"
        '
        'Lbl_AP
        '
        Me.Lbl_AP.AutoSize = True
        Me.Lbl_AP.Location = New System.Drawing.Point(6, 109)
        Me.Lbl_AP.Name = "Lbl_AP"
        Me.Lbl_AP.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_AP.TabIndex = 9
        Me.Lbl_AP.Text = "Cash Paid :"
        '
        'Lbl_GRNTA
        '
        Me.Lbl_GRNTA.AutoSize = True
        Me.Lbl_GRNTA.ForeColor = System.Drawing.Color.Red
        Me.Lbl_GRNTA.Location = New System.Drawing.Point(292, 83)
        Me.Lbl_GRNTA.Name = "Lbl_GRNTA"
        Me.Lbl_GRNTA.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_GRNTA.TabIndex = 7
        Me.Lbl_GRNTA.Text = "Invoice Total :"
        '
        'TB_TBalance
        '
        Me.TB_TBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_TBalance.Location = New System.Drawing.Point(377, 288)
        Me.TB_TBalance.Name = "TB_TBalance"
        Me.TB_TBalance.Size = New System.Drawing.Size(122, 20)
        Me.TB_TBalance.TabIndex = 36
        '
        'TB_PrevBalance
        '
        Me.TB_PrevBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_PrevBalance.Location = New System.Drawing.Point(133, 288)
        Me.TB_PrevBalance.Name = "TB_PrevBalance"
        Me.TB_PrevBalance.Size = New System.Drawing.Size(122, 20)
        Me.TB_PrevBalance.TabIndex = 34
        '
        'TB_PID
        '
        Me.TB_PID.Enabled = False
        Me.TB_PID.Location = New System.Drawing.Point(133, 80)
        Me.TB_PID.Name = "TB_PID"
        Me.TB_PID.ReadOnly = True
        Me.TB_PID.Size = New System.Drawing.Size(122, 20)
        Me.TB_PID.TabIndex = 26
        '
        'TB_ChqPad
        '
        Me.TB_ChqPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_ChqPad.Location = New System.Drawing.Point(377, 106)
        Me.TB_ChqPad.Name = "TB_ChqPad"
        Me.TB_ChqPad.Size = New System.Drawing.Size(122, 20)
        Me.TB_ChqPad.TabIndex = 12
        '
        'TB_InvCredit
        '
        Me.TB_InvCredit.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_InvCredit.Location = New System.Drawing.Point(133, 132)
        Me.TB_InvCredit.Name = "TB_InvCredit"
        Me.TB_InvCredit.Size = New System.Drawing.Size(366, 20)
        Me.TB_InvCredit.TabIndex = 14
        '
        'TB_AmntPad
        '
        Me.TB_AmntPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_AmntPad.Location = New System.Drawing.Point(133, 106)
        Me.TB_AmntPad.Name = "TB_AmntPad"
        Me.TB_AmntPad.Size = New System.Drawing.Size(122, 20)
        Me.TB_AmntPad.TabIndex = 10
        '
        'TB_GRNTA
        '
        Me.TB_GRNTA.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_GRNTA.Enabled = False
        Me.TB_GRNTA.Location = New System.Drawing.Point(377, 80)
        Me.TB_GRNTA.Name = "TB_GRNTA"
        Me.TB_GRNTA.ReadOnly = True
        Me.TB_GRNTA.Size = New System.Drawing.Size(122, 20)
        Me.TB_GRNTA.TabIndex = 8
        '
        'TB_BnkNam
        '
        Me.TB_BnkNam.Location = New System.Drawing.Point(133, 236)
        Me.TB_BnkNam.Name = "TB_BnkNam"
        Me.TB_BnkNam.Size = New System.Drawing.Size(366, 20)
        Me.TB_BnkNam.TabIndex = 22
        '
        'TB_ChqNo
        '
        Me.TB_ChqNo.Location = New System.Drawing.Point(133, 184)
        Me.TB_ChqNo.Name = "TB_ChqNo"
        Me.TB_ChqNo.Size = New System.Drawing.Size(366, 20)
        Me.TB_ChqNo.TabIndex = 18
        '
        'TB_RecName
        '
        Me.TB_RecName.Location = New System.Drawing.Point(133, 158)
        Me.TB_RecName.Name = "TB_RecName"
        Me.TB_RecName.Size = New System.Drawing.Size(366, 20)
        Me.TB_RecName.TabIndex = 16
        '
        'Btn_Clrall
        '
        Me.Btn_Clrall.Location = New System.Drawing.Point(431, 415)
        Me.Btn_Clrall.Name = "Btn_Clrall"
        Me.Btn_Clrall.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clrall.TabIndex = 2
        Me.Btn_Clrall.Text = "Clear All"
        Me.Btn_Clrall.UseVisualStyleBackColor = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Location = New System.Drawing.Point(350, 415)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Submit.TabIndex = 1
        Me.Btn_Submit.Text = "Add"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'TP_Update
        '
        Me.TP_Update.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Update.Controls.Add(Me.UD_Credit_Status)
        Me.TP_Update.Controls.Add(Me.UD_TC_GRN)
        Me.TP_Update.Controls.Add(Me.UD_Btn_Clrall)
        Me.TP_Update.Controls.Add(Me.Btn_Update)
        Me.TP_Update.Controls.Add(Me.UD_GB_Browse)
        Me.TP_Update.Location = New System.Drawing.Point(4, 25)
        Me.TP_Update.Name = "TP_Update"
        Me.TP_Update.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Update.Size = New System.Drawing.Size(518, 448)
        Me.TP_Update.TabIndex = 1
        Me.TP_Update.Text = "Update Invoice"
        '
        'UD_Credit_Status
        '
        Me.UD_Credit_Status.AutoSize = True
        Me.UD_Credit_Status.Enabled = False
        Me.UD_Credit_Status.Location = New System.Drawing.Point(10, 420)
        Me.UD_Credit_Status.Name = "UD_Credit_Status"
        Me.UD_Credit_Status.Size = New System.Drawing.Size(37, 13)
        Me.UD_Credit_Status.TabIndex = 15
        Me.UD_Credit_Status.Text = "Active"
        Me.UD_Credit_Status.Visible = False
        '
        'UD_TC_GRN
        '
        Me.UD_TC_GRN.Controls.Add(Me.UD_TP_GRN)
        Me.UD_TC_GRN.Controls.Add(Me.UD_TP_GRNItems)
        Me.UD_TC_GRN.Controls.Add(Me.UD_TP_GRNPayment)
        Me.UD_TC_GRN.Location = New System.Drawing.Point(3, 63)
        Me.UD_TC_GRN.Name = "UD_TC_GRN"
        Me.UD_TC_GRN.RightToLeftLayout = True
        Me.UD_TC_GRN.SelectedIndex = 0
        Me.UD_TC_GRN.Size = New System.Drawing.Size(513, 346)
        Me.UD_TC_GRN.TabIndex = 4
        '
        'UD_TP_GRN
        '
        Me.UD_TP_GRN.Controls.Add(Me.UD_DTP_RecDate)
        Me.UD_TP_GRN.Controls.Add(Me.UD_DTP_Inv_Date)
        Me.UD_TP_GRN.Controls.Add(Me.UD_TB_IN)
        Me.UD_TP_GRN.Controls.Add(Me.UD_TB_GRN)
        Me.UD_TP_GRN.Controls.Add(Me.UD_CB_SName)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_SGRN_Pic)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_CName)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Btn_Pic_Browse)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_RD)
        Me.UD_TP_GRN.Controls.Add(Me.UD_CB_CName)
        Me.UD_TP_GRN.Controls.Add(Me.UD_PictureBox)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_ID)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_IN)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_SName)
        Me.UD_TP_GRN.Controls.Add(Me.UD_Lbl_GRN)
        Me.UD_TP_GRN.Location = New System.Drawing.Point(4, 22)
        Me.UD_TP_GRN.Name = "UD_TP_GRN"
        Me.UD_TP_GRN.Padding = New System.Windows.Forms.Padding(3)
        Me.UD_TP_GRN.Size = New System.Drawing.Size(505, 320)
        Me.UD_TP_GRN.TabIndex = 0
        Me.UD_TP_GRN.Text = "Invoice Information"
        Me.UD_TP_GRN.UseVisualStyleBackColor = True
        '
        'UD_DTP_RecDate
        '
        Me.UD_DTP_RecDate.CustomFormat = "yyyy-MM-dd"
        Me.UD_DTP_RecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UD_DTP_RecDate.Location = New System.Drawing.Point(133, 151)
        Me.UD_DTP_RecDate.Name = "UD_DTP_RecDate"
        Me.UD_DTP_RecDate.Size = New System.Drawing.Size(159, 20)
        Me.UD_DTP_RecDate.TabIndex = 11
        '
        'UD_DTP_Inv_Date
        '
        Me.UD_DTP_Inv_Date.CustomFormat = "yyyy-MM-dd"
        Me.UD_DTP_Inv_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UD_DTP_Inv_Date.Location = New System.Drawing.Point(133, 125)
        Me.UD_DTP_Inv_Date.Name = "UD_DTP_Inv_Date"
        Me.UD_DTP_Inv_Date.Size = New System.Drawing.Size(159, 20)
        Me.UD_DTP_Inv_Date.TabIndex = 9
        '
        'UD_TB_IN
        '
        Me.UD_TB_IN.Location = New System.Drawing.Point(133, 99)
        Me.UD_TB_IN.Name = "UD_TB_IN"
        Me.UD_TB_IN.Size = New System.Drawing.Size(159, 20)
        Me.UD_TB_IN.TabIndex = 7
        '
        'UD_TB_GRN
        '
        Me.UD_TB_GRN.Enabled = False
        Me.UD_TB_GRN.Location = New System.Drawing.Point(133, 19)
        Me.UD_TB_GRN.Name = "UD_TB_GRN"
        Me.UD_TB_GRN.ReadOnly = True
        Me.UD_TB_GRN.Size = New System.Drawing.Size(159, 20)
        Me.UD_TB_GRN.TabIndex = 1
        '
        'UD_CB_SName
        '
        Me.UD_CB_SName.FormattingEnabled = True
        Me.UD_CB_SName.Location = New System.Drawing.Point(133, 45)
        Me.UD_CB_SName.Name = "UD_CB_SName"
        Me.UD_CB_SName.Size = New System.Drawing.Size(159, 21)
        Me.UD_CB_SName.TabIndex = 3
        '
        'UD_Lbl_SGRN_Pic
        '
        Me.UD_Lbl_SGRN_Pic.AutoSize = True
        Me.UD_Lbl_SGRN_Pic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.UD_Lbl_SGRN_Pic.Location = New System.Drawing.Point(83, 246)
        Me.UD_Lbl_SGRN_Pic.Name = "UD_Lbl_SGRN_Pic"
        Me.UD_Lbl_SGRN_Pic.Size = New System.Drawing.Size(113, 13)
        Me.UD_Lbl_SGRN_Pic.TabIndex = 12
        Me.UD_Lbl_SGRN_Pic.Text = "Select Invoice Image :"
        '
        'UD_Lbl_CName
        '
        Me.UD_Lbl_CName.AutoSize = True
        Me.UD_Lbl_CName.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_CName.Location = New System.Drawing.Point(6, 75)
        Me.UD_Lbl_CName.Name = "UD_Lbl_CName"
        Me.UD_Lbl_CName.Size = New System.Drawing.Size(95, 13)
        Me.UD_Lbl_CName.TabIndex = 4
        Me.UD_Lbl_CName.Text = "Company's Name :"
        '
        'UD_Btn_Pic_Browse
        '
        Me.UD_Btn_Pic_Browse.Location = New System.Drawing.Point(202, 241)
        Me.UD_Btn_Pic_Browse.Name = "UD_Btn_Pic_Browse"
        Me.UD_Btn_Pic_Browse.Size = New System.Drawing.Size(90, 23)
        Me.UD_Btn_Pic_Browse.TabIndex = 13
        Me.UD_Btn_Pic_Browse.Text = "Browse"
        Me.UD_Btn_Pic_Browse.UseVisualStyleBackColor = True
        '
        'UD_Lbl_RD
        '
        Me.UD_Lbl_RD.AutoSize = True
        Me.UD_Lbl_RD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UD_Lbl_RD.Location = New System.Drawing.Point(6, 157)
        Me.UD_Lbl_RD.Name = "UD_Lbl_RD"
        Me.UD_Lbl_RD.Size = New System.Drawing.Size(121, 13)
        Me.UD_Lbl_RD.TabIndex = 10
        Me.UD_Lbl_RD.Text = "Goods Receiving Date :"
        '
        'UD_CB_CName
        '
        Me.UD_CB_CName.FormattingEnabled = True
        Me.UD_CB_CName.Location = New System.Drawing.Point(133, 72)
        Me.UD_CB_CName.Name = "UD_CB_CName"
        Me.UD_CB_CName.Size = New System.Drawing.Size(159, 21)
        Me.UD_CB_CName.TabIndex = 5
        '
        'UD_PictureBox
        '
        Me.UD_PictureBox.Image = CType(resources.GetObject("UD_PictureBox.Image"), System.Drawing.Image)
        Me.UD_PictureBox.Location = New System.Drawing.Point(298, 6)
        Me.UD_PictureBox.Name = "UD_PictureBox"
        Me.UD_PictureBox.Size = New System.Drawing.Size(201, 308)
        Me.UD_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UD_PictureBox.TabIndex = 5
        Me.UD_PictureBox.TabStop = False
        '
        'UD_Lbl_ID
        '
        Me.UD_Lbl_ID.AutoSize = True
        Me.UD_Lbl_ID.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_ID.Location = New System.Drawing.Point(6, 131)
        Me.UD_Lbl_ID.Name = "UD_Lbl_ID"
        Me.UD_Lbl_ID.Size = New System.Drawing.Size(74, 13)
        Me.UD_Lbl_ID.TabIndex = 8
        Me.UD_Lbl_ID.Text = "Invoice Date :"
        '
        'UD_Lbl_IN
        '
        Me.UD_Lbl_IN.AutoSize = True
        Me.UD_Lbl_IN.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_IN.Location = New System.Drawing.Point(6, 102)
        Me.UD_Lbl_IN.Name = "UD_Lbl_IN"
        Me.UD_Lbl_IN.Size = New System.Drawing.Size(65, 13)
        Me.UD_Lbl_IN.TabIndex = 6
        Me.UD_Lbl_IN.Text = "Invoice No :"
        '
        'UD_Lbl_SName
        '
        Me.UD_Lbl_SName.AutoSize = True
        Me.UD_Lbl_SName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.UD_Lbl_SName.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_SName.Location = New System.Drawing.Point(6, 48)
        Me.UD_Lbl_SName.Name = "UD_Lbl_SName"
        Me.UD_Lbl_SName.Size = New System.Drawing.Size(89, 13)
        Me.UD_Lbl_SName.TabIndex = 2
        Me.UD_Lbl_SName.Text = "Supplier's Name :"
        '
        'UD_Lbl_GRN
        '
        Me.UD_Lbl_GRN.AutoSize = True
        Me.UD_Lbl_GRN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.UD_Lbl_GRN.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_GRN.Location = New System.Drawing.Point(6, 22)
        Me.UD_Lbl_GRN.Name = "UD_Lbl_GRN"
        Me.UD_Lbl_GRN.Size = New System.Drawing.Size(62, 13)
        Me.UD_Lbl_GRN.TabIndex = 0
        Me.UD_Lbl_GRN.Text = "Invoice ID :"
        '
        'UD_TP_GRNItems
        '
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_LBl_Return_Status)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_GB_ItmTbl)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_TB_ItmNam)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_Btn_AItem)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_Lbl_TA)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_Lbl_Mtr)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_Lbl_Itm)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_TB_TAmount)
        Me.UD_TP_GRNItems.Controls.Add(Me.UD_TB_Metrs)
        Me.UD_TP_GRNItems.Location = New System.Drawing.Point(4, 22)
        Me.UD_TP_GRNItems.Name = "UD_TP_GRNItems"
        Me.UD_TP_GRNItems.Padding = New System.Windows.Forms.Padding(3)
        Me.UD_TP_GRNItems.Size = New System.Drawing.Size(505, 320)
        Me.UD_TP_GRNItems.TabIndex = 1
        Me.UD_TP_GRNItems.Text = "Invoice Items"
        Me.UD_TP_GRNItems.UseVisualStyleBackColor = True
        '
        'UD_LBl_Return_Status
        '
        Me.UD_LBl_Return_Status.AutoSize = True
        Me.UD_LBl_Return_Status.Enabled = False
        Me.UD_LBl_Return_Status.Location = New System.Drawing.Point(449, 42)
        Me.UD_LBl_Return_Status.Name = "UD_LBl_Return_Status"
        Me.UD_LBl_Return_Status.Size = New System.Drawing.Size(50, 13)
        Me.UD_LBl_Return_Status.TabIndex = 8
        Me.UD_LBl_Return_Status.Text = "Available"
        Me.UD_LBl_Return_Status.Visible = False
        '
        'UD_GB_ItmTbl
        '
        Me.UD_GB_ItmTbl.BackColor = System.Drawing.Color.Transparent
        Me.UD_GB_ItmTbl.Controls.Add(Me.UD_DGV_Items)
        Me.UD_GB_ItmTbl.ForeColor = System.Drawing.Color.Red
        Me.UD_GB_ItmTbl.Location = New System.Drawing.Point(6, 67)
        Me.UD_GB_ItmTbl.Name = "UD_GB_ItmTbl"
        Me.UD_GB_ItmTbl.Size = New System.Drawing.Size(493, 247)
        Me.UD_GB_ItmTbl.TabIndex = 7
        Me.UD_GB_ItmTbl.TabStop = False
        Me.UD_GB_ItmTbl.Text = "List of Items"
        '
        'UD_DGV_Items
        '
        Me.UD_DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UD_DGV_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UD_INo, Me.UD_Items, Me.UD_Meters, Me.UD_TAmount, Me.UD_DGV_Items_Edit, Me.UD_DGV_Items_Del})
        Me.UD_DGV_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UD_DGV_Items.Location = New System.Drawing.Point(3, 16)
        Me.UD_DGV_Items.Name = "UD_DGV_Items"
        Me.UD_DGV_Items.Size = New System.Drawing.Size(487, 228)
        Me.UD_DGV_Items.TabIndex = 8
        '
        'UD_INo
        '
        Me.UD_INo.HeaderText = "Item No"
        Me.UD_INo.Name = "UD_INo"
        Me.UD_INo.ReadOnly = True
        Me.UD_INo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UD_INo.Width = 70
        '
        'UD_Items
        '
        Me.UD_Items.HeaderText = "Item"
        Me.UD_Items.Name = "UD_Items"
        Me.UD_Items.ReadOnly = True
        '
        'UD_Meters
        '
        Me.UD_Meters.HeaderText = "Meters / Qty"
        Me.UD_Meters.Name = "UD_Meters"
        Me.UD_Meters.ReadOnly = True
        Me.UD_Meters.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UD_Meters.Width = 80
        '
        'UD_TAmount
        '
        Me.UD_TAmount.HeaderText = "Total Price"
        Me.UD_TAmount.Name = "UD_TAmount"
        Me.UD_TAmount.ReadOnly = True
        Me.UD_TAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UD_TAmount.Width = 94
        '
        'UD_DGV_Items_Edit
        '
        Me.UD_DGV_Items_Edit.HeaderText = ""
        Me.UD_DGV_Items_Edit.Name = "UD_DGV_Items_Edit"
        Me.UD_DGV_Items_Edit.ReadOnly = True
        Me.UD_DGV_Items_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UD_DGV_Items_Edit.Width = 50
        '
        'UD_DGV_Items_Del
        '
        Me.UD_DGV_Items_Del.HeaderText = ""
        Me.UD_DGV_Items_Del.Name = "UD_DGV_Items_Del"
        Me.UD_DGV_Items_Del.ReadOnly = True
        Me.UD_DGV_Items_Del.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.UD_DGV_Items_Del.Width = 50
        '
        'UD_TB_ItmNam
        '
        Me.UD_TB_ItmNam.Location = New System.Drawing.Point(102, 13)
        Me.UD_TB_ItmNam.Name = "UD_TB_ItmNam"
        Me.UD_TB_ItmNam.Size = New System.Drawing.Size(145, 20)
        Me.UD_TB_ItmNam.TabIndex = 1
        '
        'UD_Btn_AItem
        '
        Me.UD_Btn_AItem.Location = New System.Drawing.Point(354, 37)
        Me.UD_Btn_AItem.Name = "UD_Btn_AItem"
        Me.UD_Btn_AItem.Size = New System.Drawing.Size(75, 23)
        Me.UD_Btn_AItem.TabIndex = 6
        Me.UD_Btn_AItem.Text = "Add"
        Me.UD_Btn_AItem.UseVisualStyleBackColor = True
        '
        'UD_Lbl_TA
        '
        Me.UD_Lbl_TA.AutoSize = True
        Me.UD_Lbl_TA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UD_Lbl_TA.Location = New System.Drawing.Point(6, 42)
        Me.UD_Lbl_TA.Name = "UD_Lbl_TA"
        Me.UD_Lbl_TA.Size = New System.Drawing.Size(90, 13)
        Me.UD_Lbl_TA.TabIndex = 4
        Me.UD_Lbl_TA.Text = "Item's total Price :"
        '
        'UD_Lbl_Mtr
        '
        Me.UD_Lbl_Mtr.AutoSize = True
        Me.UD_Lbl_Mtr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UD_Lbl_Mtr.Location = New System.Drawing.Point(276, 16)
        Me.UD_Lbl_Mtr.Name = "UD_Lbl_Mtr"
        Me.UD_Lbl_Mtr.Size = New System.Drawing.Size(72, 13)
        Me.UD_Lbl_Mtr.TabIndex = 2
        Me.UD_Lbl_Mtr.Text = "Meters / Qty :"
        '
        'UD_Lbl_Itm
        '
        Me.UD_Lbl_Itm.AutoSize = True
        Me.UD_Lbl_Itm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.UD_Lbl_Itm.Location = New System.Drawing.Point(6, 16)
        Me.UD_Lbl_Itm.Name = "UD_Lbl_Itm"
        Me.UD_Lbl_Itm.Size = New System.Drawing.Size(33, 13)
        Me.UD_Lbl_Itm.TabIndex = 0
        Me.UD_Lbl_Itm.Text = "Item :"
        '
        'UD_TB_TAmount
        '
        Me.UD_TB_TAmount.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_TAmount.Location = New System.Drawing.Point(102, 39)
        Me.UD_TB_TAmount.Name = "UD_TB_TAmount"
        Me.UD_TB_TAmount.Size = New System.Drawing.Size(145, 20)
        Me.UD_TB_TAmount.TabIndex = 5
        '
        'UD_TB_Metrs
        '
        Me.UD_TB_Metrs.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_Metrs.Location = New System.Drawing.Point(354, 13)
        Me.UD_TB_Metrs.Name = "UD_TB_Metrs"
        Me.UD_TB_Metrs.Size = New System.Drawing.Size(145, 20)
        Me.UD_TB_Metrs.TabIndex = 3
        '
        'UD_TP_GRNPayment
        '
        Me.UD_TP_GRNPayment.Controls.Add(Me.Label1)
        Me.UD_TP_GRNPayment.Controls.Add(Me.Label3)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_SNo)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_GB_PmntMethod)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_Chq_Paid)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_InvCredit)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_DTP_PDD)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_DTP_PDD)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_DTP_ChqDate)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_BN)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_CD)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_CN)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_RN)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_AP)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_Lbl_GRNTA)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_TBalance)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_PrevBalance)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_PID)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_ChqPad)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_InvCredit)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_AmntPad)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_GRNTA)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_BnkNam)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_ChqNo)
        Me.UD_TP_GRNPayment.Controls.Add(Me.UD_TB_RecName)
        Me.UD_TP_GRNPayment.Location = New System.Drawing.Point(4, 22)
        Me.UD_TP_GRNPayment.Name = "UD_TP_GRNPayment"
        Me.UD_TP_GRNPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.UD_TP_GRNPayment.Size = New System.Drawing.Size(505, 320)
        Me.UD_TP_GRNPayment.TabIndex = 2
        Me.UD_TP_GRNPayment.Text = "Invoice Payment"
        Me.UD_TP_GRNPayment.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 291)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Total Balance :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Previous Balance :"
        '
        'UD_Lbl_SNo
        '
        Me.UD_Lbl_SNo.AutoSize = True
        Me.UD_Lbl_SNo.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_SNo.Location = New System.Drawing.Point(6, 83)
        Me.UD_Lbl_SNo.Name = "UD_Lbl_SNo"
        Me.UD_Lbl_SNo.Size = New System.Drawing.Size(68, 13)
        Me.UD_Lbl_SNo.TabIndex = 29
        Me.UD_Lbl_SNo.Text = "Payment ID :"
        '
        'UD_GB_PmntMethod
        '
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_CshNChqNCred)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_ChqNCred)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_CashNCred)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_CashNChq)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_Credit)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_Cheque)
        Me.UD_GB_PmntMethod.Controls.Add(Me.UD_RB_Cash)
        Me.UD_GB_PmntMethod.Location = New System.Drawing.Point(6, 10)
        Me.UD_GB_PmntMethod.Name = "UD_GB_PmntMethod"
        Me.UD_GB_PmntMethod.Size = New System.Drawing.Size(493, 64)
        Me.UD_GB_PmntMethod.TabIndex = 25
        Me.UD_GB_PmntMethod.TabStop = False
        Me.UD_GB_PmntMethod.Text = "Payment Method (How the money was paid.)"
        '
        'UD_RB_CshNChqNCred
        '
        Me.UD_RB_CshNChqNCred.AutoSize = True
        Me.UD_RB_CshNChqNCred.Location = New System.Drawing.Point(344, 16)
        Me.UD_RB_CshNChqNCred.Name = "UD_RB_CshNChqNCred"
        Me.UD_RB_CshNChqNCred.Size = New System.Drawing.Size(143, 17)
        Me.UD_RB_CshNChqNCred.TabIndex = 9
        Me.UD_RB_CshNChqNCred.Text = "Cash, Cheque and Credit"
        Me.UD_RB_CshNChqNCred.UseVisualStyleBackColor = True
        '
        'UD_RB_ChqNCred
        '
        Me.UD_RB_ChqNCred.AutoSize = True
        Me.UD_RB_ChqNCred.Location = New System.Drawing.Point(101, 39)
        Me.UD_RB_ChqNCred.Name = "UD_RB_ChqNCred"
        Me.UD_RB_ChqNCred.Size = New System.Drawing.Size(113, 17)
        Me.UD_RB_ChqNCred.TabIndex = 12
        Me.UD_RB_ChqNCred.Text = "Cheque and Credit"
        Me.UD_RB_ChqNCred.UseVisualStyleBackColor = True
        '
        'UD_RB_CashNCred
        '
        Me.UD_RB_CashNCred.AutoSize = True
        Me.UD_RB_CashNCred.Location = New System.Drawing.Point(221, 16)
        Me.UD_RB_CashNCred.Name = "UD_RB_CashNCred"
        Me.UD_RB_CashNCred.Size = New System.Drawing.Size(100, 17)
        Me.UD_RB_CashNCred.TabIndex = 10
        Me.UD_RB_CashNCred.Text = "Cash and Credit"
        Me.UD_RB_CashNCred.UseVisualStyleBackColor = True
        '
        'UD_RB_CashNChq
        '
        Me.UD_RB_CashNChq.AutoSize = True
        Me.UD_RB_CashNChq.Location = New System.Drawing.Point(101, 16)
        Me.UD_RB_CashNChq.Name = "UD_RB_CashNChq"
        Me.UD_RB_CashNChq.Size = New System.Drawing.Size(110, 17)
        Me.UD_RB_CashNChq.TabIndex = 8
        Me.UD_RB_CashNChq.Text = "Cash and Cheque"
        Me.UD_RB_CashNChq.UseVisualStyleBackColor = True
        '
        'UD_RB_Credit
        '
        Me.UD_RB_Credit.AutoSize = True
        Me.UD_RB_Credit.Location = New System.Drawing.Point(221, 39)
        Me.UD_RB_Credit.Name = "UD_RB_Credit"
        Me.UD_RB_Credit.Size = New System.Drawing.Size(52, 17)
        Me.UD_RB_Credit.TabIndex = 13
        Me.UD_RB_Credit.Text = "Credit"
        Me.UD_RB_Credit.UseVisualStyleBackColor = True
        '
        'UD_RB_Cheque
        '
        Me.UD_RB_Cheque.AutoSize = True
        Me.UD_RB_Cheque.Location = New System.Drawing.Point(6, 39)
        Me.UD_RB_Cheque.Name = "UD_RB_Cheque"
        Me.UD_RB_Cheque.Size = New System.Drawing.Size(62, 17)
        Me.UD_RB_Cheque.TabIndex = 11
        Me.UD_RB_Cheque.Text = "Cheque"
        Me.UD_RB_Cheque.UseVisualStyleBackColor = True
        '
        'UD_RB_Cash
        '
        Me.UD_RB_Cash.AutoSize = True
        Me.UD_RB_Cash.Location = New System.Drawing.Point(6, 16)
        Me.UD_RB_Cash.Name = "UD_RB_Cash"
        Me.UD_RB_Cash.Size = New System.Drawing.Size(49, 17)
        Me.UD_RB_Cash.TabIndex = 7
        Me.UD_RB_Cash.Text = "Cash"
        Me.UD_RB_Cash.UseVisualStyleBackColor = True
        '
        'UD_Lbl_Chq_Paid
        '
        Me.UD_Lbl_Chq_Paid.AutoSize = True
        Me.UD_Lbl_Chq_Paid.Location = New System.Drawing.Point(292, 109)
        Me.UD_Lbl_Chq_Paid.Name = "UD_Lbl_Chq_Paid"
        Me.UD_Lbl_Chq_Paid.Size = New System.Drawing.Size(74, 13)
        Me.UD_Lbl_Chq_Paid.TabIndex = 11
        Me.UD_Lbl_Chq_Paid.Text = "Cheque Paid :"
        '
        'UD_Lbl_InvCredit
        '
        Me.UD_Lbl_InvCredit.AutoSize = True
        Me.UD_Lbl_InvCredit.Location = New System.Drawing.Point(6, 135)
        Me.UD_Lbl_InvCredit.Name = "UD_Lbl_InvCredit"
        Me.UD_Lbl_InvCredit.Size = New System.Drawing.Size(76, 13)
        Me.UD_Lbl_InvCredit.TabIndex = 13
        Me.UD_Lbl_InvCredit.Text = "Invoce Credit :"
        '
        'UD_DTP_PDD
        '
        Me.UD_DTP_PDD.CustomFormat = "yyyy-MM-dd"
        Me.UD_DTP_PDD.Enabled = False
        Me.UD_DTP_PDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UD_DTP_PDD.Location = New System.Drawing.Point(133, 262)
        Me.UD_DTP_PDD.Name = "UD_DTP_PDD"
        Me.UD_DTP_PDD.Size = New System.Drawing.Size(366, 20)
        Me.UD_DTP_PDD.TabIndex = 24
        '
        'UD_Lbl_DTP_PDD
        '
        Me.UD_Lbl_DTP_PDD.AutoSize = True
        Me.UD_Lbl_DTP_PDD.Location = New System.Drawing.Point(6, 268)
        Me.UD_Lbl_DTP_PDD.Name = "UD_Lbl_DTP_PDD"
        Me.UD_Lbl_DTP_PDD.Size = New System.Drawing.Size(80, 13)
        Me.UD_Lbl_DTP_PDD.TabIndex = 23
        Me.UD_Lbl_DTP_PDD.Text = "Payment Date :"
        '
        'UD_DTP_ChqDate
        '
        Me.UD_DTP_ChqDate.CustomFormat = "yyyy-MM-dd"
        Me.UD_DTP_ChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.UD_DTP_ChqDate.Location = New System.Drawing.Point(133, 210)
        Me.UD_DTP_ChqDate.Name = "UD_DTP_ChqDate"
        Me.UD_DTP_ChqDate.Size = New System.Drawing.Size(366, 20)
        Me.UD_DTP_ChqDate.TabIndex = 20
        '
        'UD_Lbl_BN
        '
        Me.UD_Lbl_BN.AutoSize = True
        Me.UD_Lbl_BN.Location = New System.Drawing.Point(6, 239)
        Me.UD_Lbl_BN.Name = "UD_Lbl_BN"
        Me.UD_Lbl_BN.Size = New System.Drawing.Size(76, 13)
        Me.UD_Lbl_BN.TabIndex = 21
        Me.UD_Lbl_BN.Text = "Bank's Name :"
        '
        'UD_Lbl_CD
        '
        Me.UD_Lbl_CD.AutoSize = True
        Me.UD_Lbl_CD.Location = New System.Drawing.Point(6, 216)
        Me.UD_Lbl_CD.Name = "UD_Lbl_CD"
        Me.UD_Lbl_CD.Size = New System.Drawing.Size(76, 13)
        Me.UD_Lbl_CD.TabIndex = 19
        Me.UD_Lbl_CD.Text = "Cheque Date :"
        '
        'UD_Lbl_CN
        '
        Me.UD_Lbl_CN.AutoSize = True
        Me.UD_Lbl_CN.Location = New System.Drawing.Point(6, 187)
        Me.UD_Lbl_CN.Name = "UD_Lbl_CN"
        Me.UD_Lbl_CN.Size = New System.Drawing.Size(67, 13)
        Me.UD_Lbl_CN.TabIndex = 17
        Me.UD_Lbl_CN.Text = "Cheque No :"
        '
        'UD_Lbl_RN
        '
        Me.UD_Lbl_RN.AutoSize = True
        Me.UD_Lbl_RN.Location = New System.Drawing.Point(6, 161)
        Me.UD_Lbl_RN.Name = "UD_Lbl_RN"
        Me.UD_Lbl_RN.Size = New System.Drawing.Size(121, 13)
        Me.UD_Lbl_RN.TabIndex = 15
        Me.UD_Lbl_RN.Text = "Cash Receiver's Name :"
        '
        'UD_Lbl_AP
        '
        Me.UD_Lbl_AP.AutoSize = True
        Me.UD_Lbl_AP.Location = New System.Drawing.Point(6, 109)
        Me.UD_Lbl_AP.Name = "UD_Lbl_AP"
        Me.UD_Lbl_AP.Size = New System.Drawing.Size(61, 13)
        Me.UD_Lbl_AP.TabIndex = 9
        Me.UD_Lbl_AP.Text = "Cash Paid :"
        '
        'UD_Lbl_GRNTA
        '
        Me.UD_Lbl_GRNTA.AutoSize = True
        Me.UD_Lbl_GRNTA.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_GRNTA.Location = New System.Drawing.Point(292, 83)
        Me.UD_Lbl_GRNTA.Name = "UD_Lbl_GRNTA"
        Me.UD_Lbl_GRNTA.Size = New System.Drawing.Size(73, 13)
        Me.UD_Lbl_GRNTA.TabIndex = 7
        Me.UD_Lbl_GRNTA.Text = "Invoce Total :"
        '
        'UD_TB_TBalance
        '
        Me.UD_TB_TBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_TBalance.Location = New System.Drawing.Point(377, 288)
        Me.UD_TB_TBalance.Name = "UD_TB_TBalance"
        Me.UD_TB_TBalance.Size = New System.Drawing.Size(122, 20)
        Me.UD_TB_TBalance.TabIndex = 40
        '
        'UD_TB_PrevBalance
        '
        Me.UD_TB_PrevBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_PrevBalance.Location = New System.Drawing.Point(133, 288)
        Me.UD_TB_PrevBalance.Name = "UD_TB_PrevBalance"
        Me.UD_TB_PrevBalance.Size = New System.Drawing.Size(122, 20)
        Me.UD_TB_PrevBalance.TabIndex = 38
        '
        'UD_TB_PID
        '
        Me.UD_TB_PID.Enabled = False
        Me.UD_TB_PID.Location = New System.Drawing.Point(133, 80)
        Me.UD_TB_PID.Name = "UD_TB_PID"
        Me.UD_TB_PID.ReadOnly = True
        Me.UD_TB_PID.Size = New System.Drawing.Size(122, 20)
        Me.UD_TB_PID.TabIndex = 28
        '
        'UD_TB_ChqPad
        '
        Me.UD_TB_ChqPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_ChqPad.Location = New System.Drawing.Point(377, 106)
        Me.UD_TB_ChqPad.Name = "UD_TB_ChqPad"
        Me.UD_TB_ChqPad.Size = New System.Drawing.Size(122, 20)
        Me.UD_TB_ChqPad.TabIndex = 12
        '
        'UD_TB_InvCredit
        '
        Me.UD_TB_InvCredit.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_InvCredit.Location = New System.Drawing.Point(133, 132)
        Me.UD_TB_InvCredit.Name = "UD_TB_InvCredit"
        Me.UD_TB_InvCredit.Size = New System.Drawing.Size(366, 20)
        Me.UD_TB_InvCredit.TabIndex = 14
        '
        'UD_TB_AmntPad
        '
        Me.UD_TB_AmntPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_AmntPad.Location = New System.Drawing.Point(133, 106)
        Me.UD_TB_AmntPad.Name = "UD_TB_AmntPad"
        Me.UD_TB_AmntPad.Size = New System.Drawing.Size(122, 20)
        Me.UD_TB_AmntPad.TabIndex = 10
        '
        'UD_TB_GRNTA
        '
        Me.UD_TB_GRNTA.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.UD_TB_GRNTA.Enabled = False
        Me.UD_TB_GRNTA.Location = New System.Drawing.Point(377, 80)
        Me.UD_TB_GRNTA.Name = "UD_TB_GRNTA"
        Me.UD_TB_GRNTA.ReadOnly = True
        Me.UD_TB_GRNTA.Size = New System.Drawing.Size(122, 20)
        Me.UD_TB_GRNTA.TabIndex = 8
        '
        'UD_TB_BnkNam
        '
        Me.UD_TB_BnkNam.Location = New System.Drawing.Point(133, 236)
        Me.UD_TB_BnkNam.Name = "UD_TB_BnkNam"
        Me.UD_TB_BnkNam.Size = New System.Drawing.Size(366, 20)
        Me.UD_TB_BnkNam.TabIndex = 22
        '
        'UD_TB_ChqNo
        '
        Me.UD_TB_ChqNo.Location = New System.Drawing.Point(133, 184)
        Me.UD_TB_ChqNo.Name = "UD_TB_ChqNo"
        Me.UD_TB_ChqNo.Size = New System.Drawing.Size(366, 20)
        Me.UD_TB_ChqNo.TabIndex = 18
        '
        'UD_TB_RecName
        '
        Me.UD_TB_RecName.Location = New System.Drawing.Point(133, 158)
        Me.UD_TB_RecName.Name = "UD_TB_RecName"
        Me.UD_TB_RecName.Size = New System.Drawing.Size(366, 20)
        Me.UD_TB_RecName.TabIndex = 16
        '
        'UD_Btn_Clrall
        '
        Me.UD_Btn_Clrall.Location = New System.Drawing.Point(431, 415)
        Me.UD_Btn_Clrall.Name = "UD_Btn_Clrall"
        Me.UD_Btn_Clrall.Size = New System.Drawing.Size(75, 23)
        Me.UD_Btn_Clrall.TabIndex = 3
        Me.UD_Btn_Clrall.Text = "Clear All"
        Me.UD_Btn_Clrall.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(350, 415)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Update.TabIndex = 2
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'UD_GB_Browse
        '
        Me.UD_GB_Browse.BackColor = System.Drawing.SystemColors.Control
        Me.UD_GB_Browse.Controls.Add(Me.UD_Lbl_Browse)
        Me.UD_GB_Browse.Controls.Add(Me.Btn_UD_Load)
        Me.UD_GB_Browse.Controls.Add(Me.TB_UD_Load)
        Me.UD_GB_Browse.Location = New System.Drawing.Point(6, 6)
        Me.UD_GB_Browse.Name = "UD_GB_Browse"
        Me.UD_GB_Browse.Size = New System.Drawing.Size(506, 51)
        Me.UD_GB_Browse.TabIndex = 0
        Me.UD_GB_Browse.TabStop = False
        Me.UD_GB_Browse.Text = "Select Invoice ID for Updation."
        '
        'UD_Lbl_Browse
        '
        Me.UD_Lbl_Browse.AutoSize = True
        Me.UD_Lbl_Browse.Location = New System.Drawing.Point(179, 23)
        Me.UD_Lbl_Browse.Name = "UD_Lbl_Browse"
        Me.UD_Lbl_Browse.Size = New System.Drawing.Size(62, 13)
        Me.UD_Lbl_Browse.TabIndex = 4
        Me.UD_Lbl_Browse.Text = "Invoice ID :"
        '
        'Btn_UD_Load
        '
        Me.Btn_UD_Load.Location = New System.Drawing.Point(443, 18)
        Me.Btn_UD_Load.Name = "Btn_UD_Load"
        Me.Btn_UD_Load.Size = New System.Drawing.Size(57, 23)
        Me.Btn_UD_Load.TabIndex = 3
        Me.Btn_UD_Load.Text = "Load"
        Me.Btn_UD_Load.UseVisualStyleBackColor = True
        '
        'TB_UD_Load
        '
        Me.TB_UD_Load.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.TB_UD_Load.Location = New System.Drawing.Point(249, 20)
        Me.TB_UD_Load.Name = "TB_UD_Load"
        Me.TB_UD_Load.Size = New System.Drawing.Size(188, 20)
        Me.TB_UD_Load.TabIndex = 5
        '
        'TP_Delete
        '
        Me.TP_Delete.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Delete.Controls.Add(Me.D_TC_GRN)
        Me.TP_Delete.Controls.Add(Me.D_Btn_Clrall)
        Me.TP_Delete.Controls.Add(Me.Btn_Delete)
        Me.TP_Delete.Controls.Add(Me.D_GB_Browse)
        Me.TP_Delete.Location = New System.Drawing.Point(4, 25)
        Me.TP_Delete.Name = "TP_Delete"
        Me.TP_Delete.Size = New System.Drawing.Size(518, 448)
        Me.TP_Delete.TabIndex = 3
        Me.TP_Delete.Text = "Delete Invoice"
        '
        'D_TC_GRN
        '
        Me.D_TC_GRN.Controls.Add(Me.D_TP_GRN)
        Me.D_TC_GRN.Controls.Add(Me.D_TP_GRNItems)
        Me.D_TC_GRN.Controls.Add(Me.D_TP_GRNPayment)
        Me.D_TC_GRN.Location = New System.Drawing.Point(3, 63)
        Me.D_TC_GRN.Name = "D_TC_GRN"
        Me.D_TC_GRN.RightToLeftLayout = True
        Me.D_TC_GRN.SelectedIndex = 0
        Me.D_TC_GRN.Size = New System.Drawing.Size(513, 346)
        Me.D_TC_GRN.TabIndex = 5
        '
        'D_TP_GRN
        '
        Me.D_TP_GRN.Controls.Add(Me.D_DTP_RecDate)
        Me.D_TP_GRN.Controls.Add(Me.D_DTP_Inv_Date)
        Me.D_TP_GRN.Controls.Add(Me.D_TB_IN)
        Me.D_TP_GRN.Controls.Add(Me.D_TB_GRN)
        Me.D_TP_GRN.Controls.Add(Me.D_CB_SName)
        Me.D_TP_GRN.Controls.Add(Me.D_Lbl_CName)
        Me.D_TP_GRN.Controls.Add(Me.D_Lbl_RD)
        Me.D_TP_GRN.Controls.Add(Me.D_CB_CName)
        Me.D_TP_GRN.Controls.Add(Me.D_PictureBox)
        Me.D_TP_GRN.Controls.Add(Me.D_Lbl_ID)
        Me.D_TP_GRN.Controls.Add(Me.D_Lbl_IN)
        Me.D_TP_GRN.Controls.Add(Me.D_Lbl_SName)
        Me.D_TP_GRN.Controls.Add(Me.D_Lbl_GRN)
        Me.D_TP_GRN.Location = New System.Drawing.Point(4, 22)
        Me.D_TP_GRN.Name = "D_TP_GRN"
        Me.D_TP_GRN.Padding = New System.Windows.Forms.Padding(3)
        Me.D_TP_GRN.Size = New System.Drawing.Size(505, 320)
        Me.D_TP_GRN.TabIndex = 0
        Me.D_TP_GRN.Text = "Invoice Information"
        Me.D_TP_GRN.UseVisualStyleBackColor = True
        '
        'D_DTP_RecDate
        '
        Me.D_DTP_RecDate.CustomFormat = "yyyy-MM-dd"
        Me.D_DTP_RecDate.Enabled = False
        Me.D_DTP_RecDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_DTP_RecDate.Location = New System.Drawing.Point(133, 151)
        Me.D_DTP_RecDate.Name = "D_DTP_RecDate"
        Me.D_DTP_RecDate.Size = New System.Drawing.Size(159, 20)
        Me.D_DTP_RecDate.TabIndex = 11
        '
        'D_DTP_Inv_Date
        '
        Me.D_DTP_Inv_Date.CustomFormat = "yyyy-MM-dd"
        Me.D_DTP_Inv_Date.Enabled = False
        Me.D_DTP_Inv_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_DTP_Inv_Date.Location = New System.Drawing.Point(133, 125)
        Me.D_DTP_Inv_Date.Name = "D_DTP_Inv_Date"
        Me.D_DTP_Inv_Date.Size = New System.Drawing.Size(159, 20)
        Me.D_DTP_Inv_Date.TabIndex = 9
        '
        'D_TB_IN
        '
        Me.D_TB_IN.Enabled = False
        Me.D_TB_IN.Location = New System.Drawing.Point(133, 99)
        Me.D_TB_IN.Name = "D_TB_IN"
        Me.D_TB_IN.ReadOnly = True
        Me.D_TB_IN.Size = New System.Drawing.Size(159, 20)
        Me.D_TB_IN.TabIndex = 7
        '
        'D_TB_GRN
        '
        Me.D_TB_GRN.Enabled = False
        Me.D_TB_GRN.Location = New System.Drawing.Point(133, 19)
        Me.D_TB_GRN.Name = "D_TB_GRN"
        Me.D_TB_GRN.ReadOnly = True
        Me.D_TB_GRN.Size = New System.Drawing.Size(159, 20)
        Me.D_TB_GRN.TabIndex = 1
        '
        'D_CB_SName
        '
        Me.D_CB_SName.Enabled = False
        Me.D_CB_SName.FormattingEnabled = True
        Me.D_CB_SName.Location = New System.Drawing.Point(133, 45)
        Me.D_CB_SName.Name = "D_CB_SName"
        Me.D_CB_SName.Size = New System.Drawing.Size(159, 21)
        Me.D_CB_SName.TabIndex = 3
        '
        'D_Lbl_CName
        '
        Me.D_Lbl_CName.AutoSize = True
        Me.D_Lbl_CName.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_CName.Location = New System.Drawing.Point(6, 75)
        Me.D_Lbl_CName.Name = "D_Lbl_CName"
        Me.D_Lbl_CName.Size = New System.Drawing.Size(95, 13)
        Me.D_Lbl_CName.TabIndex = 4
        Me.D_Lbl_CName.Text = "Company's Name :"
        '
        'D_Lbl_RD
        '
        Me.D_Lbl_RD.AutoSize = True
        Me.D_Lbl_RD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.D_Lbl_RD.Location = New System.Drawing.Point(6, 157)
        Me.D_Lbl_RD.Name = "D_Lbl_RD"
        Me.D_Lbl_RD.Size = New System.Drawing.Size(121, 13)
        Me.D_Lbl_RD.TabIndex = 10
        Me.D_Lbl_RD.Text = "Goods Receiving Date :"
        '
        'D_CB_CName
        '
        Me.D_CB_CName.Enabled = False
        Me.D_CB_CName.FormattingEnabled = True
        Me.D_CB_CName.Location = New System.Drawing.Point(133, 72)
        Me.D_CB_CName.Name = "D_CB_CName"
        Me.D_CB_CName.Size = New System.Drawing.Size(159, 21)
        Me.D_CB_CName.TabIndex = 5
        '
        'D_PictureBox
        '
        Me.D_PictureBox.Image = CType(resources.GetObject("D_PictureBox.Image"), System.Drawing.Image)
        Me.D_PictureBox.Location = New System.Drawing.Point(298, 6)
        Me.D_PictureBox.Name = "D_PictureBox"
        Me.D_PictureBox.Size = New System.Drawing.Size(201, 308)
        Me.D_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.D_PictureBox.TabIndex = 5
        Me.D_PictureBox.TabStop = False
        '
        'D_Lbl_ID
        '
        Me.D_Lbl_ID.AutoSize = True
        Me.D_Lbl_ID.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_ID.Location = New System.Drawing.Point(6, 131)
        Me.D_Lbl_ID.Name = "D_Lbl_ID"
        Me.D_Lbl_ID.Size = New System.Drawing.Size(74, 13)
        Me.D_Lbl_ID.TabIndex = 8
        Me.D_Lbl_ID.Text = "Invoice Date :"
        '
        'D_Lbl_IN
        '
        Me.D_Lbl_IN.AutoSize = True
        Me.D_Lbl_IN.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_IN.Location = New System.Drawing.Point(6, 102)
        Me.D_Lbl_IN.Name = "D_Lbl_IN"
        Me.D_Lbl_IN.Size = New System.Drawing.Size(65, 13)
        Me.D_Lbl_IN.TabIndex = 6
        Me.D_Lbl_IN.Text = "Invoice No :"
        '
        'D_Lbl_SName
        '
        Me.D_Lbl_SName.AutoSize = True
        Me.D_Lbl_SName.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_SName.Location = New System.Drawing.Point(6, 48)
        Me.D_Lbl_SName.Name = "D_Lbl_SName"
        Me.D_Lbl_SName.Size = New System.Drawing.Size(89, 13)
        Me.D_Lbl_SName.TabIndex = 2
        Me.D_Lbl_SName.Text = "Supplier's Name :"
        '
        'D_Lbl_GRN
        '
        Me.D_Lbl_GRN.AutoSize = True
        Me.D_Lbl_GRN.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_GRN.Location = New System.Drawing.Point(6, 22)
        Me.D_Lbl_GRN.Name = "D_Lbl_GRN"
        Me.D_Lbl_GRN.Size = New System.Drawing.Size(62, 13)
        Me.D_Lbl_GRN.TabIndex = 0
        Me.D_Lbl_GRN.Text = "Invoice ID :"
        '
        'D_TP_GRNItems
        '
        Me.D_TP_GRNItems.Controls.Add(Me.D_GB_ItmTbl)
        Me.D_TP_GRNItems.Location = New System.Drawing.Point(4, 22)
        Me.D_TP_GRNItems.Name = "D_TP_GRNItems"
        Me.D_TP_GRNItems.Padding = New System.Windows.Forms.Padding(3)
        Me.D_TP_GRNItems.Size = New System.Drawing.Size(505, 320)
        Me.D_TP_GRNItems.TabIndex = 1
        Me.D_TP_GRNItems.Text = "Invoice Items"
        Me.D_TP_GRNItems.UseVisualStyleBackColor = True
        '
        'D_GB_ItmTbl
        '
        Me.D_GB_ItmTbl.BackColor = System.Drawing.Color.Transparent
        Me.D_GB_ItmTbl.Controls.Add(Me.D_DGV_Items)
        Me.D_GB_ItmTbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.D_GB_ItmTbl.ForeColor = System.Drawing.Color.Red
        Me.D_GB_ItmTbl.Location = New System.Drawing.Point(3, 3)
        Me.D_GB_ItmTbl.Name = "D_GB_ItmTbl"
        Me.D_GB_ItmTbl.Size = New System.Drawing.Size(499, 314)
        Me.D_GB_ItmTbl.TabIndex = 7
        Me.D_GB_ItmTbl.TabStop = False
        Me.D_GB_ItmTbl.Text = "List of Items"
        '
        'D_DGV_Items
        '
        Me.D_DGV_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_DGV_Items.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.D_INo, Me.D_Items, Me.D_Meters, Me.D_TAmount, Me.D_DGV_Items_Edit, Me.D_DGV_Items_Del})
        Me.D_DGV_Items.Dock = System.Windows.Forms.DockStyle.Fill
        Me.D_DGV_Items.Enabled = False
        Me.D_DGV_Items.Location = New System.Drawing.Point(3, 16)
        Me.D_DGV_Items.Name = "D_DGV_Items"
        Me.D_DGV_Items.ReadOnly = True
        Me.D_DGV_Items.Size = New System.Drawing.Size(493, 295)
        Me.D_DGV_Items.TabIndex = 8
        '
        'D_INo
        '
        Me.D_INo.HeaderText = "Item No"
        Me.D_INo.Name = "D_INo"
        Me.D_INo.ReadOnly = True
        Me.D_INo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D_INo.Width = 70
        '
        'D_Items
        '
        Me.D_Items.HeaderText = "Item"
        Me.D_Items.Name = "D_Items"
        Me.D_Items.ReadOnly = True
        '
        'D_Meters
        '
        Me.D_Meters.HeaderText = "Meters / Qty"
        Me.D_Meters.Name = "D_Meters"
        Me.D_Meters.ReadOnly = True
        Me.D_Meters.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D_Meters.Width = 80
        '
        'D_TAmount
        '
        Me.D_TAmount.HeaderText = "Total Price"
        Me.D_TAmount.Name = "D_TAmount"
        Me.D_TAmount.ReadOnly = True
        Me.D_TAmount.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D_TAmount.Width = 94
        '
        'D_DGV_Items_Edit
        '
        Me.D_DGV_Items_Edit.HeaderText = ""
        Me.D_DGV_Items_Edit.Name = "D_DGV_Items_Edit"
        Me.D_DGV_Items_Edit.ReadOnly = True
        Me.D_DGV_Items_Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D_DGV_Items_Edit.Width = 50
        '
        'D_DGV_Items_Del
        '
        Me.D_DGV_Items_Del.HeaderText = ""
        Me.D_DGV_Items_Del.Name = "D_DGV_Items_Del"
        Me.D_DGV_Items_Del.ReadOnly = True
        Me.D_DGV_Items_Del.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.D_DGV_Items_Del.Width = 50
        '
        'D_TP_GRNPayment
        '
        Me.D_TP_GRNPayment.Controls.Add(Me.Label4)
        Me.D_TP_GRNPayment.Controls.Add(Me.Label5)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_SNo)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_GB_PmntMethod)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_Chq_Paid)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_InvCredit)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_DTP_PDD)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_DTP_PDD)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_DTP_ChqDate)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_BN)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_CD)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_CN)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_RN)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_AP)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_Lbl_GRNTA)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_TBalance)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_PrevBalance)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_PID)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_ChqPad)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_InvCredit)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_AmntPad)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_GRNTA)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_BnkNam)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_ChqNo)
        Me.D_TP_GRNPayment.Controls.Add(Me.D_TB_RecName)
        Me.D_TP_GRNPayment.Location = New System.Drawing.Point(4, 22)
        Me.D_TP_GRNPayment.Name = "D_TP_GRNPayment"
        Me.D_TP_GRNPayment.Padding = New System.Windows.Forms.Padding(3)
        Me.D_TP_GRNPayment.Size = New System.Drawing.Size(505, 320)
        Me.D_TP_GRNPayment.TabIndex = 2
        Me.D_TP_GRNPayment.Text = "Invoice Payment"
        Me.D_TP_GRNPayment.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(292, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Total Balance :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Previous Balance :"
        '
        'D_Lbl_SNo
        '
        Me.D_Lbl_SNo.AutoSize = True
        Me.D_Lbl_SNo.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_SNo.Location = New System.Drawing.Point(6, 83)
        Me.D_Lbl_SNo.Name = "D_Lbl_SNo"
        Me.D_Lbl_SNo.Size = New System.Drawing.Size(68, 13)
        Me.D_Lbl_SNo.TabIndex = 31
        Me.D_Lbl_SNo.Text = "Payment ID :"
        '
        'D_GB_PmntMethod
        '
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_CshNChqNCred)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_ChqNCred)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_CashNCred)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_CashNChq)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_Credit)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_Cheque)
        Me.D_GB_PmntMethod.Controls.Add(Me.D_RB_Cash)
        Me.D_GB_PmntMethod.Location = New System.Drawing.Point(6, 10)
        Me.D_GB_PmntMethod.Name = "D_GB_PmntMethod"
        Me.D_GB_PmntMethod.Size = New System.Drawing.Size(493, 64)
        Me.D_GB_PmntMethod.TabIndex = 25
        Me.D_GB_PmntMethod.TabStop = False
        Me.D_GB_PmntMethod.Text = "Payment Method (How the money was paid.)"
        '
        'D_RB_CshNChqNCred
        '
        Me.D_RB_CshNChqNCred.AutoSize = True
        Me.D_RB_CshNChqNCred.Enabled = False
        Me.D_RB_CshNChqNCred.Location = New System.Drawing.Point(344, 16)
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
        Me.D_RB_ChqNCred.Location = New System.Drawing.Point(101, 39)
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
        Me.D_RB_CashNCred.Location = New System.Drawing.Point(221, 16)
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
        Me.D_RB_CashNChq.Location = New System.Drawing.Point(101, 16)
        Me.D_RB_CashNChq.Name = "D_RB_CashNChq"
        Me.D_RB_CashNChq.Size = New System.Drawing.Size(110, 17)
        Me.D_RB_CashNChq.TabIndex = 8
        Me.D_RB_CashNChq.Text = "Cash and Cheque"
        Me.D_RB_CashNChq.UseVisualStyleBackColor = True
        '
        'D_RB_Credit
        '
        Me.D_RB_Credit.AutoSize = True
        Me.D_RB_Credit.Enabled = False
        Me.D_RB_Credit.Location = New System.Drawing.Point(221, 39)
        Me.D_RB_Credit.Name = "D_RB_Credit"
        Me.D_RB_Credit.Size = New System.Drawing.Size(52, 17)
        Me.D_RB_Credit.TabIndex = 13
        Me.D_RB_Credit.Text = "Credit"
        Me.D_RB_Credit.UseVisualStyleBackColor = True
        '
        'D_RB_Cheque
        '
        Me.D_RB_Cheque.AutoSize = True
        Me.D_RB_Cheque.Enabled = False
        Me.D_RB_Cheque.Location = New System.Drawing.Point(6, 39)
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
        Me.D_RB_Cash.Location = New System.Drawing.Point(6, 16)
        Me.D_RB_Cash.Name = "D_RB_Cash"
        Me.D_RB_Cash.Size = New System.Drawing.Size(49, 17)
        Me.D_RB_Cash.TabIndex = 7
        Me.D_RB_Cash.Text = "Cash"
        Me.D_RB_Cash.UseVisualStyleBackColor = True
        '
        'D_Lbl_Chq_Paid
        '
        Me.D_Lbl_Chq_Paid.AutoSize = True
        Me.D_Lbl_Chq_Paid.Location = New System.Drawing.Point(292, 109)
        Me.D_Lbl_Chq_Paid.Name = "D_Lbl_Chq_Paid"
        Me.D_Lbl_Chq_Paid.Size = New System.Drawing.Size(74, 13)
        Me.D_Lbl_Chq_Paid.TabIndex = 11
        Me.D_Lbl_Chq_Paid.Text = "Cheque Paid :"
        '
        'D_Lbl_InvCredit
        '
        Me.D_Lbl_InvCredit.AutoSize = True
        Me.D_Lbl_InvCredit.Location = New System.Drawing.Point(6, 135)
        Me.D_Lbl_InvCredit.Name = "D_Lbl_InvCredit"
        Me.D_Lbl_InvCredit.Size = New System.Drawing.Size(76, 13)
        Me.D_Lbl_InvCredit.TabIndex = 13
        Me.D_Lbl_InvCredit.Text = "Invoce Credit :"
        '
        'D_DTP_PDD
        '
        Me.D_DTP_PDD.CustomFormat = "yyyy-MM-dd"
        Me.D_DTP_PDD.Enabled = False
        Me.D_DTP_PDD.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_DTP_PDD.Location = New System.Drawing.Point(133, 262)
        Me.D_DTP_PDD.Name = "D_DTP_PDD"
        Me.D_DTP_PDD.Size = New System.Drawing.Size(366, 20)
        Me.D_DTP_PDD.TabIndex = 24
        '
        'D_Lbl_DTP_PDD
        '
        Me.D_Lbl_DTP_PDD.AutoSize = True
        Me.D_Lbl_DTP_PDD.Location = New System.Drawing.Point(6, 268)
        Me.D_Lbl_DTP_PDD.Name = "D_Lbl_DTP_PDD"
        Me.D_Lbl_DTP_PDD.Size = New System.Drawing.Size(80, 13)
        Me.D_Lbl_DTP_PDD.TabIndex = 23
        Me.D_Lbl_DTP_PDD.Text = "Payment Date :"
        '
        'D_DTP_ChqDate
        '
        Me.D_DTP_ChqDate.CustomFormat = "yyyy-MM-dd"
        Me.D_DTP_ChqDate.Enabled = False
        Me.D_DTP_ChqDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.D_DTP_ChqDate.Location = New System.Drawing.Point(133, 210)
        Me.D_DTP_ChqDate.Name = "D_DTP_ChqDate"
        Me.D_DTP_ChqDate.Size = New System.Drawing.Size(366, 20)
        Me.D_DTP_ChqDate.TabIndex = 20
        '
        'D_Lbl_BN
        '
        Me.D_Lbl_BN.AutoSize = True
        Me.D_Lbl_BN.Location = New System.Drawing.Point(6, 239)
        Me.D_Lbl_BN.Name = "D_Lbl_BN"
        Me.D_Lbl_BN.Size = New System.Drawing.Size(76, 13)
        Me.D_Lbl_BN.TabIndex = 21
        Me.D_Lbl_BN.Text = "Bank's Name :"
        '
        'D_Lbl_CD
        '
        Me.D_Lbl_CD.AutoSize = True
        Me.D_Lbl_CD.Location = New System.Drawing.Point(6, 216)
        Me.D_Lbl_CD.Name = "D_Lbl_CD"
        Me.D_Lbl_CD.Size = New System.Drawing.Size(76, 13)
        Me.D_Lbl_CD.TabIndex = 19
        Me.D_Lbl_CD.Text = "Cheque Date :"
        '
        'D_Lbl_CN
        '
        Me.D_Lbl_CN.AutoSize = True
        Me.D_Lbl_CN.Location = New System.Drawing.Point(6, 187)
        Me.D_Lbl_CN.Name = "D_Lbl_CN"
        Me.D_Lbl_CN.Size = New System.Drawing.Size(67, 13)
        Me.D_Lbl_CN.TabIndex = 17
        Me.D_Lbl_CN.Text = "Cheque No :"
        '
        'D_Lbl_RN
        '
        Me.D_Lbl_RN.AutoSize = True
        Me.D_Lbl_RN.Location = New System.Drawing.Point(6, 161)
        Me.D_Lbl_RN.Name = "D_Lbl_RN"
        Me.D_Lbl_RN.Size = New System.Drawing.Size(121, 13)
        Me.D_Lbl_RN.TabIndex = 15
        Me.D_Lbl_RN.Text = "Cash Receiver's Name :"
        '
        'D_Lbl_AP
        '
        Me.D_Lbl_AP.AutoSize = True
        Me.D_Lbl_AP.Location = New System.Drawing.Point(6, 109)
        Me.D_Lbl_AP.Name = "D_Lbl_AP"
        Me.D_Lbl_AP.Size = New System.Drawing.Size(61, 13)
        Me.D_Lbl_AP.TabIndex = 9
        Me.D_Lbl_AP.Text = "Cash Paid :"
        '
        'D_Lbl_GRNTA
        '
        Me.D_Lbl_GRNTA.AutoSize = True
        Me.D_Lbl_GRNTA.ForeColor = System.Drawing.Color.Red
        Me.D_Lbl_GRNTA.Location = New System.Drawing.Point(292, 83)
        Me.D_Lbl_GRNTA.Name = "D_Lbl_GRNTA"
        Me.D_Lbl_GRNTA.Size = New System.Drawing.Size(73, 13)
        Me.D_Lbl_GRNTA.TabIndex = 7
        Me.D_Lbl_GRNTA.Text = "Invoce Total :"
        '
        'D_TB_TBalance
        '
        Me.D_TB_TBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_TBalance.Enabled = False
        Me.D_TB_TBalance.Location = New System.Drawing.Point(377, 288)
        Me.D_TB_TBalance.Name = "D_TB_TBalance"
        Me.D_TB_TBalance.ReadOnly = True
        Me.D_TB_TBalance.Size = New System.Drawing.Size(122, 20)
        Me.D_TB_TBalance.TabIndex = 40
        '
        'D_TB_PrevBalance
        '
        Me.D_TB_PrevBalance.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_PrevBalance.Enabled = False
        Me.D_TB_PrevBalance.Location = New System.Drawing.Point(133, 288)
        Me.D_TB_PrevBalance.Name = "D_TB_PrevBalance"
        Me.D_TB_PrevBalance.ReadOnly = True
        Me.D_TB_PrevBalance.Size = New System.Drawing.Size(122, 20)
        Me.D_TB_PrevBalance.TabIndex = 38
        '
        'D_TB_PID
        '
        Me.D_TB_PID.Enabled = False
        Me.D_TB_PID.Location = New System.Drawing.Point(133, 80)
        Me.D_TB_PID.Name = "D_TB_PID"
        Me.D_TB_PID.ReadOnly = True
        Me.D_TB_PID.Size = New System.Drawing.Size(122, 20)
        Me.D_TB_PID.TabIndex = 30
        '
        'D_TB_ChqPad
        '
        Me.D_TB_ChqPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_ChqPad.Enabled = False
        Me.D_TB_ChqPad.Location = New System.Drawing.Point(377, 106)
        Me.D_TB_ChqPad.Name = "D_TB_ChqPad"
        Me.D_TB_ChqPad.ReadOnly = True
        Me.D_TB_ChqPad.Size = New System.Drawing.Size(122, 20)
        Me.D_TB_ChqPad.TabIndex = 12
        '
        'D_TB_InvCredit
        '
        Me.D_TB_InvCredit.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_InvCredit.Enabled = False
        Me.D_TB_InvCredit.Location = New System.Drawing.Point(133, 132)
        Me.D_TB_InvCredit.Name = "D_TB_InvCredit"
        Me.D_TB_InvCredit.ReadOnly = True
        Me.D_TB_InvCredit.Size = New System.Drawing.Size(366, 20)
        Me.D_TB_InvCredit.TabIndex = 14
        '
        'D_TB_AmntPad
        '
        Me.D_TB_AmntPad.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_AmntPad.Enabled = False
        Me.D_TB_AmntPad.Location = New System.Drawing.Point(133, 106)
        Me.D_TB_AmntPad.Name = "D_TB_AmntPad"
        Me.D_TB_AmntPad.ReadOnly = True
        Me.D_TB_AmntPad.Size = New System.Drawing.Size(122, 20)
        Me.D_TB_AmntPad.TabIndex = 10
        '
        'D_TB_GRNTA
        '
        Me.D_TB_GRNTA.DecimalPlaces = CRMS.MathsTB.DecimalDigits.ZeroDigits
        Me.D_TB_GRNTA.Enabled = False
        Me.D_TB_GRNTA.Location = New System.Drawing.Point(377, 80)
        Me.D_TB_GRNTA.Name = "D_TB_GRNTA"
        Me.D_TB_GRNTA.ReadOnly = True
        Me.D_TB_GRNTA.Size = New System.Drawing.Size(122, 20)
        Me.D_TB_GRNTA.TabIndex = 8
        '
        'D_TB_BnkNam
        '
        Me.D_TB_BnkNam.Enabled = False
        Me.D_TB_BnkNam.Location = New System.Drawing.Point(133, 236)
        Me.D_TB_BnkNam.Name = "D_TB_BnkNam"
        Me.D_TB_BnkNam.ReadOnly = True
        Me.D_TB_BnkNam.Size = New System.Drawing.Size(366, 20)
        Me.D_TB_BnkNam.TabIndex = 22
        '
        'D_TB_ChqNo
        '
        Me.D_TB_ChqNo.Enabled = False
        Me.D_TB_ChqNo.Location = New System.Drawing.Point(133, 184)
        Me.D_TB_ChqNo.Name = "D_TB_ChqNo"
        Me.D_TB_ChqNo.ReadOnly = True
        Me.D_TB_ChqNo.Size = New System.Drawing.Size(366, 20)
        Me.D_TB_ChqNo.TabIndex = 18
        '
        'D_TB_RecName
        '
        Me.D_TB_RecName.Enabled = False
        Me.D_TB_RecName.Location = New System.Drawing.Point(133, 158)
        Me.D_TB_RecName.Name = "D_TB_RecName"
        Me.D_TB_RecName.ReadOnly = True
        Me.D_TB_RecName.Size = New System.Drawing.Size(366, 20)
        Me.D_TB_RecName.TabIndex = 16
        '
        'D_Btn_Clrall
        '
        Me.D_Btn_Clrall.Location = New System.Drawing.Point(431, 415)
        Me.D_Btn_Clrall.Name = "D_Btn_Clrall"
        Me.D_Btn_Clrall.Size = New System.Drawing.Size(75, 23)
        Me.D_Btn_Clrall.TabIndex = 3
        Me.D_Btn_Clrall.Text = "Clear All"
        Me.D_Btn_Clrall.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(350, 415)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Delete.TabIndex = 2
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'D_GB_Browse
        '
        Me.D_GB_Browse.BackColor = System.Drawing.SystemColors.Control
        Me.D_GB_Browse.Controls.Add(Me.TB_D_Load)
        Me.D_GB_Browse.Controls.Add(Me.D_Lbl_Browse)
        Me.D_GB_Browse.Controls.Add(Me.Btn_D_Load)
        Me.D_GB_Browse.Location = New System.Drawing.Point(6, 6)
        Me.D_GB_Browse.Name = "D_GB_Browse"
        Me.D_GB_Browse.Size = New System.Drawing.Size(506, 51)
        Me.D_GB_Browse.TabIndex = 0
        Me.D_GB_Browse.TabStop = False
        Me.D_GB_Browse.Text = "Select Invoice ID for Deletion."
        '
        'TB_D_Load
        '
        Me.TB_D_Load.Location = New System.Drawing.Point(249, 20)
        Me.TB_D_Load.Name = "TB_D_Load"
        Me.TB_D_Load.Size = New System.Drawing.Size(188, 20)
        Me.TB_D_Load.TabIndex = 7
        '
        'D_Lbl_Browse
        '
        Me.D_Lbl_Browse.AutoSize = True
        Me.D_Lbl_Browse.Location = New System.Drawing.Point(179, 23)
        Me.D_Lbl_Browse.Name = "D_Lbl_Browse"
        Me.D_Lbl_Browse.Size = New System.Drawing.Size(62, 13)
        Me.D_Lbl_Browse.TabIndex = 5
        Me.D_Lbl_Browse.Text = "Invoice ID :"
        '
        'Btn_D_Load
        '
        Me.Btn_D_Load.Location = New System.Drawing.Point(443, 18)
        Me.Btn_D_Load.Name = "Btn_D_Load"
        Me.Btn_D_Load.Size = New System.Drawing.Size(57, 23)
        Me.Btn_D_Load.TabIndex = 3
        Me.Btn_D_Load.Text = "Load"
        Me.Btn_D_Load.UseVisualStyleBackColor = True
        '
        'Sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 477)
        Me.Controls.Add(Me.Tab_Control)
        Me.Name = "Sale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Purchased Invoice"
        Me.Tab_Control.ResumeLayout(False)
        Me.TP_Add.ResumeLayout(False)
        Me.TP_Add.PerformLayout()
        Me.TC_GRN.ResumeLayout(False)
        Me.TP_GRN.ResumeLayout(False)
        Me.TP_GRN.PerformLayout()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_GRNItems.ResumeLayout(False)
        Me.TP_GRNItems.PerformLayout()
        Me.GB_ItmTbl.ResumeLayout(False)
        CType(Me.DGV_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TP_GRNPayment.ResumeLayout(False)
        Me.TP_GRNPayment.PerformLayout()
        Me.GB_PmntMethod.ResumeLayout(False)
        Me.GB_PmntMethod.PerformLayout()
        Me.TP_Update.ResumeLayout(False)
        Me.TP_Update.PerformLayout()
        Me.UD_TC_GRN.ResumeLayout(False)
        Me.UD_TP_GRN.ResumeLayout(False)
        Me.UD_TP_GRN.PerformLayout()
        CType(Me.UD_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UD_TP_GRNItems.ResumeLayout(False)
        Me.UD_TP_GRNItems.PerformLayout()
        Me.UD_GB_ItmTbl.ResumeLayout(False)
        CType(Me.UD_DGV_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UD_TP_GRNPayment.ResumeLayout(False)
        Me.UD_TP_GRNPayment.PerformLayout()
        Me.UD_GB_PmntMethod.ResumeLayout(False)
        Me.UD_GB_PmntMethod.PerformLayout()
        Me.UD_GB_Browse.ResumeLayout(False)
        Me.UD_GB_Browse.PerformLayout()
        Me.TP_Delete.ResumeLayout(False)
        Me.D_TC_GRN.ResumeLayout(False)
        Me.D_TP_GRN.ResumeLayout(False)
        Me.D_TP_GRN.PerformLayout()
        CType(Me.D_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.D_TP_GRNItems.ResumeLayout(False)
        Me.D_GB_ItmTbl.ResumeLayout(False)
        CType(Me.D_DGV_Items, System.ComponentModel.ISupportInitialize).EndInit()
        Me.D_TP_GRNPayment.ResumeLayout(False)
        Me.D_TP_GRNPayment.PerformLayout()
        Me.D_GB_PmntMethod.ResumeLayout(False)
        Me.D_GB_PmntMethod.PerformLayout()
        Me.D_GB_Browse.ResumeLayout(False)
        Me.D_GB_Browse.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Control As System.Windows.Forms.TabControl
    Friend WithEvents TP_Add As System.Windows.Forms.TabPage
    Friend WithEvents Btn_Clrall As System.Windows.Forms.Button
    Friend WithEvents Btn_Submit As System.Windows.Forms.Button
    Friend WithEvents TP_Update As System.Windows.Forms.TabPage
    Friend WithEvents UD_Btn_Clrall As System.Windows.Forms.Button
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents UD_GB_Browse As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_UD_Load As System.Windows.Forms.Button
    Friend WithEvents TP_Delete As System.Windows.Forms.TabPage
    Friend WithEvents D_Btn_Clrall As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents D_GB_Browse As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_D_Load As System.Windows.Forms.Button
    Friend WithEvents TC_GRN As System.Windows.Forms.TabControl
    Friend WithEvents TP_GRN As System.Windows.Forms.TabPage
    Friend WithEvents DTP_RecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_Inv_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents TB_IN As CRMS.CharIntTB
    Friend WithEvents TB_GRN As System.Windows.Forms.TextBox
    Friend WithEvents CB_SName As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_SGRN_Pic As System.Windows.Forms.Label
    Friend WithEvents Lbl_CName As System.Windows.Forms.Label
    Friend WithEvents Btn_Pic_Browse As System.Windows.Forms.Button
    Friend WithEvents Lbl_RD As System.Windows.Forms.Label
    Friend WithEvents CB_CName As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_ID As System.Windows.Forms.Label
    Friend WithEvents Lbl_IN As System.Windows.Forms.Label
    Friend WithEvents Lbl_SName As System.Windows.Forms.Label
    Friend WithEvents Lbl_GRN As System.Windows.Forms.Label
    Friend WithEvents TP_GRNItems As System.Windows.Forms.TabPage
    Friend WithEvents TB_ItmNam As System.Windows.Forms.TextBox
    Friend WithEvents Btn_AItem As System.Windows.Forms.Button
    Friend WithEvents Lbl_TA As System.Windows.Forms.Label
    Friend WithEvents Lbl_Mtr As System.Windows.Forms.Label
    Friend WithEvents Lbl_Itm As System.Windows.Forms.Label
    Friend WithEvents TP_GRNPayment As System.Windows.Forms.TabPage
    Friend WithEvents DTP_PDD As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_DTP_PDD As System.Windows.Forms.Label
    Friend WithEvents DTP_ChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_BN As System.Windows.Forms.Label
    Friend WithEvents Lbl_CD As System.Windows.Forms.Label
    Friend WithEvents Lbl_CN As System.Windows.Forms.Label
    Friend WithEvents Lbl_RN As System.Windows.Forms.Label
    Friend WithEvents Lbl_AP As System.Windows.Forms.Label
    Friend WithEvents Lbl_GRNTA As System.Windows.Forms.Label
    Friend WithEvents TB_BnkNam As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_ChqNo As CRMS.IntegerTB
    Friend WithEvents TB_RecName As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_TAmount As CRMS.MathsTB
    Friend WithEvents TB_Metrs As CRMS.MathsTB
    Friend WithEvents TB_AmntPad As CRMS.MathsTB
    Friend WithEvents TB_GRNTA As CRMS.MathsTB
    Friend WithEvents TB_InvCredit As CRMS.MathsTB
    Friend WithEvents Lbl_InvCredit As System.Windows.Forms.Label
    Friend WithEvents TB_ChqPad As CRMS.MathsTB
    Friend WithEvents Lbl_Chq_Paid As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_Browse As System.Windows.Forms.Label
    Friend WithEvents GB_PmntMethod As System.Windows.Forms.GroupBox
    Friend WithEvents RB_CshNChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CashNCred As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CashNChq As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Credit As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Cash As System.Windows.Forms.RadioButton
    Friend WithEvents GB_ItmTbl As System.Windows.Forms.GroupBox
    Friend WithEvents DGV_Items As System.Windows.Forms.DataGridView
    Friend WithEvents LBl_Return_Status As System.Windows.Forms.Label
    Friend WithEvents UD_TC_GRN As System.Windows.Forms.TabControl
    Friend WithEvents UD_TP_GRN As System.Windows.Forms.TabPage
    Friend WithEvents UD_DTP_RecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents UD_DTP_Inv_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents UD_TB_IN As CRMS.CharIntTB
    Friend WithEvents UD_TB_GRN As System.Windows.Forms.TextBox
    Friend WithEvents UD_CB_SName As System.Windows.Forms.ComboBox
    Friend WithEvents UD_Lbl_SGRN_Pic As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_CName As System.Windows.Forms.Label
    Friend WithEvents UD_Btn_Pic_Browse As System.Windows.Forms.Button
    Friend WithEvents UD_Lbl_RD As System.Windows.Forms.Label
    Friend WithEvents UD_CB_CName As System.Windows.Forms.ComboBox
    Friend WithEvents UD_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UD_Lbl_ID As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_IN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_SName As System.Windows.Forms.Label
    Friend WithEvents UD_TP_GRNItems As System.Windows.Forms.TabPage
    Friend WithEvents UD_LBl_Return_Status As System.Windows.Forms.Label
    Friend WithEvents UD_GB_ItmTbl As System.Windows.Forms.GroupBox
    Friend WithEvents UD_DGV_Items As System.Windows.Forms.DataGridView
    Friend WithEvents UD_TB_ItmNam As System.Windows.Forms.TextBox
    Friend WithEvents UD_Btn_AItem As System.Windows.Forms.Button
    Friend WithEvents UD_Lbl_TA As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_Mtr As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_Itm As System.Windows.Forms.Label
    Friend WithEvents UD_TB_TAmount As CRMS.MathsTB
    Friend WithEvents UD_TB_Metrs As CRMS.MathsTB
    Friend WithEvents UD_TP_GRNPayment As System.Windows.Forms.TabPage
    Friend WithEvents UD_GB_PmntMethod As System.Windows.Forms.GroupBox
    Friend WithEvents UD_RB_CshNChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_ChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_CashNCred As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_CashNChq As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_Credit As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents UD_RB_Cash As System.Windows.Forms.RadioButton
    Friend WithEvents UD_Lbl_Chq_Paid As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_InvCredit As System.Windows.Forms.Label
    Friend WithEvents UD_DTP_PDD As System.Windows.Forms.DateTimePicker
    Friend WithEvents UD_Lbl_DTP_PDD As System.Windows.Forms.Label
    Friend WithEvents UD_DTP_ChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents UD_Lbl_BN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_CD As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_CN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_RN As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_AP As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_GRNTA As System.Windows.Forms.Label
    Friend WithEvents UD_TB_ChqPad As CRMS.MathsTB
    Friend WithEvents UD_TB_InvCredit As CRMS.MathsTB
    Friend WithEvents UD_TB_AmntPad As CRMS.MathsTB
    Friend WithEvents UD_TB_GRNTA As CRMS.MathsTB
    Friend WithEvents UD_TB_BnkNam As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_TB_ChqNo As CRMS.IntegerTB
    Friend WithEvents UD_TB_RecName As CRMS.CharMinusSpaceTB
    Friend WithEvents D_TC_GRN As System.Windows.Forms.TabControl
    Friend WithEvents D_TP_GRN As System.Windows.Forms.TabPage
    Friend WithEvents D_DTP_RecDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_DTP_Inv_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_TB_IN As CRMS.CharIntTB
    Friend WithEvents D_TB_GRN As System.Windows.Forms.TextBox
    Friend WithEvents D_CB_SName As System.Windows.Forms.ComboBox
    Friend WithEvents D_Lbl_CName As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_RD As System.Windows.Forms.Label
    Friend WithEvents D_CB_CName As System.Windows.Forms.ComboBox
    Friend WithEvents D_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents D_Lbl_ID As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_IN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_SName As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_GRN As System.Windows.Forms.Label
    Friend WithEvents D_TP_GRNItems As System.Windows.Forms.TabPage
    Friend WithEvents D_GB_ItmTbl As System.Windows.Forms.GroupBox
    Friend WithEvents D_DGV_Items As System.Windows.Forms.DataGridView
    Friend WithEvents D_TP_GRNPayment As System.Windows.Forms.TabPage
    Friend WithEvents D_GB_PmntMethod As System.Windows.Forms.GroupBox
    Friend WithEvents D_RB_CshNChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_ChqNCred As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_CashNCred As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_CashNChq As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_Credit As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_Cheque As System.Windows.Forms.RadioButton
    Friend WithEvents D_RB_Cash As System.Windows.Forms.RadioButton
    Friend WithEvents D_Lbl_Chq_Paid As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_InvCredit As System.Windows.Forms.Label
    Friend WithEvents D_DTP_PDD As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_Lbl_DTP_PDD As System.Windows.Forms.Label
    Friend WithEvents D_DTP_ChqDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_Lbl_BN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_CD As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_CN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_RN As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_AP As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_GRNTA As System.Windows.Forms.Label
    Friend WithEvents D_TB_ChqPad As CRMS.MathsTB
    Friend WithEvents D_TB_InvCredit As CRMS.MathsTB
    Friend WithEvents D_TB_AmntPad As CRMS.MathsTB
    Friend WithEvents D_TB_GRNTA As CRMS.MathsTB
    Friend WithEvents D_TB_BnkNam As CRMS.CharMinusSpaceTB
    Friend WithEvents D_TB_ChqNo As CRMS.IntegerTB
    Friend WithEvents D_TB_RecName As CRMS.CharMinusSpaceTB
    Friend WithEvents D_Lbl_Browse As System.Windows.Forms.Label
    Friend WithEvents CStatus As System.Windows.Forms.Label
    Friend WithEvents UD_Credit_Status As System.Windows.Forms.Label
    Friend WithEvents Lbl_SNo As System.Windows.Forms.Label
    Friend WithEvents TB_PID As CRMS.IntegerTB
    Friend WithEvents UD_Lbl_SNo As System.Windows.Forms.Label
    Friend WithEvents UD_TB_PID As CRMS.IntegerTB
    Friend WithEvents D_Lbl_SNo As System.Windows.Forms.Label
    Friend WithEvents D_TB_PID As CRMS.IntegerTB
    Friend WithEvents TB_D_Load As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_TBalance As CRMS.MathsTB
    Friend WithEvents TB_PrevBalance As CRMS.MathsTB
    Friend WithEvents UD_Lbl_GRN As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents UD_TB_TBalance As CRMS.MathsTB
    Friend WithEvents UD_TB_PrevBalance As CRMS.MathsTB
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents D_TB_TBalance As CRMS.MathsTB
    Friend WithEvents D_TB_PrevBalance As CRMS.MathsTB
    Friend WithEvents TB_UD_Load As CRMS.MathsTB
    Friend WithEvents INo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Items As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Meters As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DGV_Items_Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents DGV_Items_Del As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents UD_INo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_Items As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_Meters As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_TAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UD_DGV_Items_Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents UD_DGV_Items_Del As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents D_INo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_Items As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_Meters As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_TAmount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents D_DGV_Items_Edit As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents D_DGV_Items_Del As System.Windows.Forms.DataGridViewButtonColumn
End Class
