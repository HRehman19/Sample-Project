<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suppliers
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
        Me.GB_Add = New System.Windows.Forms.GroupBox()
        Me.TB_BBC = New CRMS.IntegerTB()
        Me.TB_BAN = New CRMS.IntegerTB()
        Me.TB_SName = New CRMS.CharMinusSpaceTB()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Email = New CRMS.EmailTB()
        Me.TB_BAT = New CRMS.CharMinusSpaceTB()
        Me.Lbl_P_No = New System.Windows.Forms.Label()
        Me.Lbl_Email = New System.Windows.Forms.Label()
        Me.Lbl_CName = New System.Windows.Forms.Label()
        Me.TB_P_No = New CRMS.IntMinusSpaceTB()
        Me.Lbl_Name = New System.Windows.Forms.Label()
        Me.TB_CName = New CRMS.CharMinusSpaceTB()
        Me.Lbl_BnkAcnt = New System.Windows.Forms.Label()
        Me.Lbl_Adr = New System.Windows.Forms.Label()
        Me.TB_Adr = New System.Windows.Forms.TextBox()
        Me.Lbl_SID = New System.Windows.Forms.Label()
        Me.TB_SID = New System.Windows.Forms.TextBox()
        Me.Btn_Clear_All = New System.Windows.Forms.Button()
        Me.Btn_Submit = New System.Windows.Forms.Button()
        Me.TP_Update = New System.Windows.Forms.TabPage()
        Me.GB_UD_Loaded = New System.Windows.Forms.GroupBox()
        Me.UD_TB_BBC = New CRMS.IntegerTB()
        Me.UD_TB_BAN = New CRMS.IntegerTB()
        Me.UD_TB_BAT = New CRMS.CharMinusSpaceTB()
        Me.UD_TB_SID = New System.Windows.Forms.TextBox()
        Me.UD_TB_Email = New CRMS.EmailTB()
        Me.UD_TB_SName = New CRMS.CharMinusSpaceTB()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.UD_Lbl_Email = New System.Windows.Forms.Label()
        Me.UD_TB_P_No = New CRMS.IntMinusSpaceTB()
        Me.UD_Lbl_Name = New System.Windows.Forms.Label()
        Me.UD_Lbl_SID = New System.Windows.Forms.Label()
        Me.UD_TB_CName = New CRMS.CharMinusSpaceTB()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.UD_Lbl_CName = New System.Windows.Forms.Label()
        Me.UD_Lbl_Adr = New System.Windows.Forms.Label()
        Me.UD_TB_Adr = New System.Windows.Forms.TextBox()
        Me.UD_Lbl_P_No = New System.Windows.Forms.Label()
        Me.GB_UD_Load = New System.Windows.Forms.GroupBox()
        Me.TB_UD_Load = New CRMS.IntegerTB()
        Me.Lbl_UD_Load = New System.Windows.Forms.Label()
        Me.Btn_UD_Load = New System.Windows.Forms.Button()
        Me.Btn_UD_Clear_All = New System.Windows.Forms.Button()
        Me.Btn_Update = New System.Windows.Forms.Button()
        Me.TP_Delete = New System.Windows.Forms.TabPage()
        Me.GB_D_Loaded = New System.Windows.Forms.GroupBox()
        Me.D_TB_BBC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.D_TB_BAT = New System.Windows.Forms.TextBox()
        Me.D_TB_SName = New System.Windows.Forms.TextBox()
        Me.D_Lbl_Name = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.D_TB_BAN = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.D_Lbl_CName = New System.Windows.Forms.Label()
        Me.D_TB_CName = New System.Windows.Forms.TextBox()
        Me.D_Lbl_SID = New System.Windows.Forms.Label()
        Me.D_TB_SID = New System.Windows.Forms.TextBox()
        Me.D_TB_Email = New System.Windows.Forms.TextBox()
        Me.D_Lbl_Email = New System.Windows.Forms.Label()
        Me.D_Lbl_Adr = New System.Windows.Forms.Label()
        Me.D_TB_Adr = New System.Windows.Forms.TextBox()
        Me.D_Lbl_P_No = New System.Windows.Forms.Label()
        Me.D_TB_P_No = New System.Windows.Forms.TextBox()
        Me.GB_D_Load = New System.Windows.Forms.GroupBox()
        Me.TB_D_Load = New CRMS.IntegerTB()
        Me.Lbl_D_Load = New System.Windows.Forms.Label()
        Me.Btn_D_Load = New System.Windows.Forms.Button()
        Me.Btn_D_Clear_All = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Tab_Control.SuspendLayout()
        Me.TP_Add.SuspendLayout()
        Me.GB_Add.SuspendLayout()
        Me.TP_Update.SuspendLayout()
        Me.GB_UD_Loaded.SuspendLayout()
        Me.GB_UD_Load.SuspendLayout()
        Me.TP_Delete.SuspendLayout()
        Me.GB_D_Loaded.SuspendLayout()
        Me.GB_D_Load.SuspendLayout()
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
        Me.Tab_Control.Size = New System.Drawing.Size(631, 285)
        Me.Tab_Control.TabIndex = 0
        '
        'TP_Add
        '
        Me.TP_Add.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Add.Controls.Add(Me.GB_Add)
        Me.TP_Add.Controls.Add(Me.Btn_Clear_All)
        Me.TP_Add.Controls.Add(Me.Btn_Submit)
        Me.TP_Add.Location = New System.Drawing.Point(4, 25)
        Me.TP_Add.Name = "TP_Add"
        Me.TP_Add.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Add.Size = New System.Drawing.Size(623, 256)
        Me.TP_Add.TabIndex = 0
        Me.TP_Add.Text = "Add Supplier"
        '
        'GB_Add
        '
        Me.GB_Add.BackColor = System.Drawing.SystemColors.Control
        Me.GB_Add.Controls.Add(Me.TB_BBC)
        Me.GB_Add.Controls.Add(Me.TB_BAN)
        Me.GB_Add.Controls.Add(Me.TB_SName)
        Me.GB_Add.Controls.Add(Me.Label8)
        Me.GB_Add.Controls.Add(Me.Label1)
        Me.GB_Add.Controls.Add(Me.TB_Email)
        Me.GB_Add.Controls.Add(Me.TB_BAT)
        Me.GB_Add.Controls.Add(Me.Lbl_P_No)
        Me.GB_Add.Controls.Add(Me.Lbl_Email)
        Me.GB_Add.Controls.Add(Me.Lbl_CName)
        Me.GB_Add.Controls.Add(Me.TB_P_No)
        Me.GB_Add.Controls.Add(Me.Lbl_Name)
        Me.GB_Add.Controls.Add(Me.TB_CName)
        Me.GB_Add.Controls.Add(Me.Lbl_BnkAcnt)
        Me.GB_Add.Controls.Add(Me.Lbl_Adr)
        Me.GB_Add.Controls.Add(Me.TB_Adr)
        Me.GB_Add.Controls.Add(Me.Lbl_SID)
        Me.GB_Add.Controls.Add(Me.TB_SID)
        Me.GB_Add.Location = New System.Drawing.Point(6, 60)
        Me.GB_Add.Name = "GB_Add"
        Me.GB_Add.Size = New System.Drawing.Size(610, 160)
        Me.GB_Add.TabIndex = 0
        Me.GB_Add.TabStop = False
        Me.GB_Add.Text = "Add new supplier."
        '
        'TB_BBC
        '
        Me.TB_BBC.Location = New System.Drawing.Point(420, 101)
        Me.TB_BBC.Name = "TB_BBC"
        Me.TB_BBC.Size = New System.Drawing.Size(183, 20)
        Me.TB_BBC.TabIndex = 15
        '
        'TB_BAN
        '
        Me.TB_BAN.Location = New System.Drawing.Point(114, 101)
        Me.TB_BAN.Name = "TB_BAN"
        Me.TB_BAN.Size = New System.Drawing.Size(183, 20)
        Me.TB_BAN.TabIndex = 13
        '
        'TB_SName
        '
        Me.TB_SName.Location = New System.Drawing.Point(420, 23)
        Me.TB_SName.Name = "TB_SName"
        Me.TB_SName.Size = New System.Drawing.Size(183, 20)
        Me.TB_SName.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(310, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Bank Branch Code :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(310, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Bank Account Title :"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(420, 49)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(183, 20)
        Me.TB_Email.TabIndex = 7
        '
        'TB_BAT
        '
        Me.TB_BAT.Location = New System.Drawing.Point(420, 75)
        Me.TB_BAT.Name = "TB_BAT"
        Me.TB_BAT.Size = New System.Drawing.Size(183, 20)
        Me.TB_BAT.TabIndex = 11
        '
        'Lbl_P_No
        '
        Me.Lbl_P_No.AutoSize = True
        Me.Lbl_P_No.Location = New System.Drawing.Point(10, 78)
        Me.Lbl_P_No.Name = "Lbl_P_No"
        Me.Lbl_P_No.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_P_No.TabIndex = 8
        Me.Lbl_P_No.Text = "Contact No :"
        '
        'Lbl_Email
        '
        Me.Lbl_Email.AutoSize = True
        Me.Lbl_Email.Location = New System.Drawing.Point(310, 52)
        Me.Lbl_Email.Name = "Lbl_Email"
        Me.Lbl_Email.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_Email.TabIndex = 6
        Me.Lbl_Email.Text = "Email ID :"
        '
        'Lbl_CName
        '
        Me.Lbl_CName.AutoSize = True
        Me.Lbl_CName.ForeColor = System.Drawing.Color.Red
        Me.Lbl_CName.Location = New System.Drawing.Point(10, 52)
        Me.Lbl_CName.Name = "Lbl_CName"
        Me.Lbl_CName.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_CName.TabIndex = 4
        Me.Lbl_CName.Text = "Company Name :"
        '
        'TB_P_No
        '
        Me.TB_P_No.Location = New System.Drawing.Point(114, 75)
        Me.TB_P_No.Name = "TB_P_No"
        Me.TB_P_No.Size = New System.Drawing.Size(183, 20)
        Me.TB_P_No.TabIndex = 9
        '
        'Lbl_Name
        '
        Me.Lbl_Name.AutoSize = True
        Me.Lbl_Name.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Name.Location = New System.Drawing.Point(310, 26)
        Me.Lbl_Name.Name = "Lbl_Name"
        Me.Lbl_Name.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_Name.TabIndex = 2
        Me.Lbl_Name.Text = "Supplier Name :"
        '
        'TB_CName
        '
        Me.TB_CName.Location = New System.Drawing.Point(114, 49)
        Me.TB_CName.Name = "TB_CName"
        Me.TB_CName.Size = New System.Drawing.Size(183, 20)
        Me.TB_CName.TabIndex = 5
        '
        'Lbl_BnkAcnt
        '
        Me.Lbl_BnkAcnt.AutoSize = True
        Me.Lbl_BnkAcnt.Location = New System.Drawing.Point(10, 104)
        Me.Lbl_BnkAcnt.Name = "Lbl_BnkAcnt"
        Me.Lbl_BnkAcnt.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_BnkAcnt.TabIndex = 12
        Me.Lbl_BnkAcnt.Text = "Bank Account No :"
        '
        'Lbl_Adr
        '
        Me.Lbl_Adr.AutoSize = True
        Me.Lbl_Adr.Location = New System.Drawing.Point(10, 130)
        Me.Lbl_Adr.Name = "Lbl_Adr"
        Me.Lbl_Adr.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_Adr.TabIndex = 16
        Me.Lbl_Adr.Text = "Address :"
        '
        'TB_Adr
        '
        Me.TB_Adr.Location = New System.Drawing.Point(114, 127)
        Me.TB_Adr.Name = "TB_Adr"
        Me.TB_Adr.Size = New System.Drawing.Size(489, 20)
        Me.TB_Adr.TabIndex = 17
        '
        'Lbl_SID
        '
        Me.Lbl_SID.AutoSize = True
        Me.Lbl_SID.ForeColor = System.Drawing.Color.Red
        Me.Lbl_SID.Location = New System.Drawing.Point(10, 26)
        Me.Lbl_SID.Name = "Lbl_SID"
        Me.Lbl_SID.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_SID.TabIndex = 0
        Me.Lbl_SID.Text = "Supplier ID :"
        '
        'TB_SID
        '
        Me.TB_SID.Enabled = False
        Me.TB_SID.Location = New System.Drawing.Point(114, 23)
        Me.TB_SID.Name = "TB_SID"
        Me.TB_SID.ReadOnly = True
        Me.TB_SID.Size = New System.Drawing.Size(183, 20)
        Me.TB_SID.TabIndex = 1
        '
        'Btn_Clear_All
        '
        Me.Btn_Clear_All.Location = New System.Drawing.Point(534, 226)
        Me.Btn_Clear_All.Name = "Btn_Clear_All"
        Me.Btn_Clear_All.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clear_All.TabIndex = 2
        Me.Btn_Clear_All.Text = "Clear All"
        Me.Btn_Clear_All.UseVisualStyleBackColor = True
        '
        'Btn_Submit
        '
        Me.Btn_Submit.Location = New System.Drawing.Point(453, 226)
        Me.Btn_Submit.Name = "Btn_Submit"
        Me.Btn_Submit.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Submit.TabIndex = 1
        Me.Btn_Submit.Text = "Add"
        Me.Btn_Submit.UseVisualStyleBackColor = True
        '
        'TP_Update
        '
        Me.TP_Update.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Update.Controls.Add(Me.GB_UD_Loaded)
        Me.TP_Update.Controls.Add(Me.GB_UD_Load)
        Me.TP_Update.Controls.Add(Me.Btn_UD_Clear_All)
        Me.TP_Update.Controls.Add(Me.Btn_Update)
        Me.TP_Update.Location = New System.Drawing.Point(4, 25)
        Me.TP_Update.Name = "TP_Update"
        Me.TP_Update.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Update.Size = New System.Drawing.Size(623, 256)
        Me.TP_Update.TabIndex = 1
        Me.TP_Update.Text = "Update Supplier"
        '
        'GB_UD_Loaded
        '
        Me.GB_UD_Loaded.BackColor = System.Drawing.SystemColors.Control
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_BBC)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_BAN)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_BAT)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_SID)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_Email)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_SName)
        Me.GB_UD_Loaded.Controls.Add(Me.Label2)
        Me.GB_UD_Loaded.Controls.Add(Me.Label4)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_Lbl_Email)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_P_No)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_Lbl_Name)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_Lbl_SID)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_CName)
        Me.GB_UD_Loaded.Controls.Add(Me.Label5)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_Lbl_CName)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_Lbl_Adr)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_TB_Adr)
        Me.GB_UD_Loaded.Controls.Add(Me.UD_Lbl_P_No)
        Me.GB_UD_Loaded.Location = New System.Drawing.Point(6, 60)
        Me.GB_UD_Loaded.Name = "GB_UD_Loaded"
        Me.GB_UD_Loaded.Size = New System.Drawing.Size(610, 160)
        Me.GB_UD_Loaded.TabIndex = 1
        Me.GB_UD_Loaded.TabStop = False
        Me.GB_UD_Loaded.Text = "Selected supplier data appears here."
        '
        'UD_TB_BBC
        '
        Me.UD_TB_BBC.Location = New System.Drawing.Point(420, 101)
        Me.UD_TB_BBC.Name = "UD_TB_BBC"
        Me.UD_TB_BBC.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_BBC.TabIndex = 15
        '
        'UD_TB_BAN
        '
        Me.UD_TB_BAN.Location = New System.Drawing.Point(114, 101)
        Me.UD_TB_BAN.Name = "UD_TB_BAN"
        Me.UD_TB_BAN.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_BAN.TabIndex = 13
        '
        'UD_TB_BAT
        '
        Me.UD_TB_BAT.Location = New System.Drawing.Point(420, 75)
        Me.UD_TB_BAT.Name = "UD_TB_BAT"
        Me.UD_TB_BAT.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_BAT.TabIndex = 11
        '
        'UD_TB_SID
        '
        Me.UD_TB_SID.Enabled = False
        Me.UD_TB_SID.Location = New System.Drawing.Point(114, 23)
        Me.UD_TB_SID.Name = "UD_TB_SID"
        Me.UD_TB_SID.ReadOnly = True
        Me.UD_TB_SID.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_SID.TabIndex = 1
        '
        'UD_TB_Email
        '
        Me.UD_TB_Email.Location = New System.Drawing.Point(420, 49)
        Me.UD_TB_Email.Name = "UD_TB_Email"
        Me.UD_TB_Email.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_Email.TabIndex = 7
        '
        'UD_TB_SName
        '
        Me.UD_TB_SName.Location = New System.Drawing.Point(420, 23)
        Me.UD_TB_SName.Name = "UD_TB_SName"
        Me.UD_TB_SName.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_SName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Bank Branch Code :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(310, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Bank Account Title :"
        '
        'UD_Lbl_Email
        '
        Me.UD_Lbl_Email.AutoSize = True
        Me.UD_Lbl_Email.Location = New System.Drawing.Point(310, 52)
        Me.UD_Lbl_Email.Name = "UD_Lbl_Email"
        Me.UD_Lbl_Email.Size = New System.Drawing.Size(52, 13)
        Me.UD_Lbl_Email.TabIndex = 6
        Me.UD_Lbl_Email.Text = "Email ID :"
        '
        'UD_TB_P_No
        '
        Me.UD_TB_P_No.Location = New System.Drawing.Point(114, 75)
        Me.UD_TB_P_No.Name = "UD_TB_P_No"
        Me.UD_TB_P_No.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_P_No.TabIndex = 9
        '
        'UD_Lbl_Name
        '
        Me.UD_Lbl_Name.AutoSize = True
        Me.UD_Lbl_Name.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_Name.Location = New System.Drawing.Point(310, 26)
        Me.UD_Lbl_Name.Name = "UD_Lbl_Name"
        Me.UD_Lbl_Name.Size = New System.Drawing.Size(82, 13)
        Me.UD_Lbl_Name.TabIndex = 2
        Me.UD_Lbl_Name.Text = "Supplier Name :"
        '
        'UD_Lbl_SID
        '
        Me.UD_Lbl_SID.AutoSize = True
        Me.UD_Lbl_SID.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_SID.Location = New System.Drawing.Point(10, 26)
        Me.UD_Lbl_SID.Name = "UD_Lbl_SID"
        Me.UD_Lbl_SID.Size = New System.Drawing.Size(65, 13)
        Me.UD_Lbl_SID.TabIndex = 0
        Me.UD_Lbl_SID.Text = "Supplier ID :"
        '
        'UD_TB_CName
        '
        Me.UD_TB_CName.Location = New System.Drawing.Point(114, 49)
        Me.UD_TB_CName.Name = "UD_TB_CName"
        Me.UD_TB_CName.Size = New System.Drawing.Size(183, 20)
        Me.UD_TB_CName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Bank Account No :"
        '
        'UD_Lbl_CName
        '
        Me.UD_Lbl_CName.AutoSize = True
        Me.UD_Lbl_CName.ForeColor = System.Drawing.Color.Red
        Me.UD_Lbl_CName.Location = New System.Drawing.Point(10, 52)
        Me.UD_Lbl_CName.Name = "UD_Lbl_CName"
        Me.UD_Lbl_CName.Size = New System.Drawing.Size(88, 13)
        Me.UD_Lbl_CName.TabIndex = 4
        Me.UD_Lbl_CName.Text = "Company Name :"
        '
        'UD_Lbl_Adr
        '
        Me.UD_Lbl_Adr.AutoSize = True
        Me.UD_Lbl_Adr.Location = New System.Drawing.Point(10, 130)
        Me.UD_Lbl_Adr.Name = "UD_Lbl_Adr"
        Me.UD_Lbl_Adr.Size = New System.Drawing.Size(51, 13)
        Me.UD_Lbl_Adr.TabIndex = 16
        Me.UD_Lbl_Adr.Text = "Address :"
        '
        'UD_TB_Adr
        '
        Me.UD_TB_Adr.Location = New System.Drawing.Point(114, 127)
        Me.UD_TB_Adr.Name = "UD_TB_Adr"
        Me.UD_TB_Adr.Size = New System.Drawing.Size(489, 20)
        Me.UD_TB_Adr.TabIndex = 17
        '
        'UD_Lbl_P_No
        '
        Me.UD_Lbl_P_No.AutoSize = True
        Me.UD_Lbl_P_No.Location = New System.Drawing.Point(10, 78)
        Me.UD_Lbl_P_No.Name = "UD_Lbl_P_No"
        Me.UD_Lbl_P_No.Size = New System.Drawing.Size(67, 13)
        Me.UD_Lbl_P_No.TabIndex = 8
        Me.UD_Lbl_P_No.Text = "Contact No :"
        '
        'GB_UD_Load
        '
        Me.GB_UD_Load.BackColor = System.Drawing.SystemColors.Control
        Me.GB_UD_Load.Controls.Add(Me.TB_UD_Load)
        Me.GB_UD_Load.Controls.Add(Me.Lbl_UD_Load)
        Me.GB_UD_Load.Controls.Add(Me.Btn_UD_Load)
        Me.GB_UD_Load.Location = New System.Drawing.Point(6, 6)
        Me.GB_UD_Load.Name = "GB_UD_Load"
        Me.GB_UD_Load.Size = New System.Drawing.Size(610, 48)
        Me.GB_UD_Load.TabIndex = 0
        Me.GB_UD_Load.TabStop = False
        Me.GB_UD_Load.Text = "Select supplier to update."
        '
        'TB_UD_Load
        '
        Me.TB_UD_Load.Location = New System.Drawing.Point(314, 19)
        Me.TB_UD_Load.Name = "TB_UD_Load"
        Me.TB_UD_Load.Size = New System.Drawing.Size(209, 20)
        Me.TB_UD_Load.TabIndex = 1
        '
        'Lbl_UD_Load
        '
        Me.Lbl_UD_Load.AutoSize = True
        Me.Lbl_UD_Load.Location = New System.Drawing.Point(243, 22)
        Me.Lbl_UD_Load.Name = "Lbl_UD_Load"
        Me.Lbl_UD_Load.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_UD_Load.TabIndex = 0
        Me.Lbl_UD_Load.Text = "Supplier ID :"
        '
        'Btn_UD_Load
        '
        Me.Btn_UD_Load.Location = New System.Drawing.Point(529, 17)
        Me.Btn_UD_Load.Name = "Btn_UD_Load"
        Me.Btn_UD_Load.Size = New System.Drawing.Size(75, 23)
        Me.Btn_UD_Load.TabIndex = 2
        Me.Btn_UD_Load.Text = "Load"
        Me.Btn_UD_Load.UseVisualStyleBackColor = True
        '
        'Btn_UD_Clear_All
        '
        Me.Btn_UD_Clear_All.Location = New System.Drawing.Point(534, 226)
        Me.Btn_UD_Clear_All.Name = "Btn_UD_Clear_All"
        Me.Btn_UD_Clear_All.Size = New System.Drawing.Size(75, 23)
        Me.Btn_UD_Clear_All.TabIndex = 3
        Me.Btn_UD_Clear_All.Text = "Clear All"
        Me.Btn_UD_Clear_All.UseVisualStyleBackColor = True
        '
        'Btn_Update
        '
        Me.Btn_Update.Location = New System.Drawing.Point(453, 226)
        Me.Btn_Update.Name = "Btn_Update"
        Me.Btn_Update.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Update.TabIndex = 2
        Me.Btn_Update.Text = "Update"
        Me.Btn_Update.UseVisualStyleBackColor = True
        '
        'TP_Delete
        '
        Me.TP_Delete.BackColor = System.Drawing.SystemColors.Control
        Me.TP_Delete.Controls.Add(Me.GB_D_Loaded)
        Me.TP_Delete.Controls.Add(Me.GB_D_Load)
        Me.TP_Delete.Controls.Add(Me.Btn_D_Clear_All)
        Me.TP_Delete.Controls.Add(Me.Btn_Delete)
        Me.TP_Delete.Location = New System.Drawing.Point(4, 25)
        Me.TP_Delete.Name = "TP_Delete"
        Me.TP_Delete.Padding = New System.Windows.Forms.Padding(3)
        Me.TP_Delete.Size = New System.Drawing.Size(623, 256)
        Me.TP_Delete.TabIndex = 2
        Me.TP_Delete.Text = "Delete Supplier"
        '
        'GB_D_Loaded
        '
        Me.GB_D_Loaded.BackColor = System.Drawing.SystemColors.Control
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_BBC)
        Me.GB_D_Loaded.Controls.Add(Me.Label3)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_BAT)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_SName)
        Me.GB_D_Loaded.Controls.Add(Me.D_Lbl_Name)
        Me.GB_D_Loaded.Controls.Add(Me.Label6)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_BAN)
        Me.GB_D_Loaded.Controls.Add(Me.Label7)
        Me.GB_D_Loaded.Controls.Add(Me.D_Lbl_CName)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_CName)
        Me.GB_D_Loaded.Controls.Add(Me.D_Lbl_SID)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_SID)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_Email)
        Me.GB_D_Loaded.Controls.Add(Me.D_Lbl_Email)
        Me.GB_D_Loaded.Controls.Add(Me.D_Lbl_Adr)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_Adr)
        Me.GB_D_Loaded.Controls.Add(Me.D_Lbl_P_No)
        Me.GB_D_Loaded.Controls.Add(Me.D_TB_P_No)
        Me.GB_D_Loaded.Location = New System.Drawing.Point(6, 60)
        Me.GB_D_Loaded.Name = "GB_D_Loaded"
        Me.GB_D_Loaded.Size = New System.Drawing.Size(610, 160)
        Me.GB_D_Loaded.TabIndex = 1
        Me.GB_D_Loaded.TabStop = False
        Me.GB_D_Loaded.Text = "Selected supplier data appears here."
        '
        'D_TB_BBC
        '
        Me.D_TB_BBC.Enabled = False
        Me.D_TB_BBC.Location = New System.Drawing.Point(420, 101)
        Me.D_TB_BBC.Name = "D_TB_BBC"
        Me.D_TB_BBC.ReadOnly = True
        Me.D_TB_BBC.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_BBC.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Bank Branch Code :"
        '
        'D_TB_BAT
        '
        Me.D_TB_BAT.Enabled = False
        Me.D_TB_BAT.Location = New System.Drawing.Point(420, 75)
        Me.D_TB_BAT.Name = "D_TB_BAT"
        Me.D_TB_BAT.ReadOnly = True
        Me.D_TB_BAT.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_BAT.TabIndex = 11
        '
        'D_TB_SName
        '
        Me.D_TB_SName.Enabled = False
        Me.D_TB_SName.Location = New System.Drawing.Point(420, 23)
        Me.D_TB_SName.Name = "D_TB_SName"
        Me.D_TB_SName.ReadOnly = True
        Me.D_TB_SName.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_SName.TabIndex = 3
        '
        'D_Lbl_Name
        '
        Me.D_Lbl_Name.AutoSize = True
        Me.D_Lbl_Name.Location = New System.Drawing.Point(310, 26)
        Me.D_Lbl_Name.Name = "D_Lbl_Name"
        Me.D_Lbl_Name.Size = New System.Drawing.Size(82, 13)
        Me.D_Lbl_Name.TabIndex = 2
        Me.D_Lbl_Name.Text = "Supplier Name :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(310, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Bank Account Title :"
        '
        'D_TB_BAN
        '
        Me.D_TB_BAN.Enabled = False
        Me.D_TB_BAN.Location = New System.Drawing.Point(114, 101)
        Me.D_TB_BAN.Name = "D_TB_BAN"
        Me.D_TB_BAN.ReadOnly = True
        Me.D_TB_BAN.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_BAN.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Bank Account No :"
        '
        'D_Lbl_CName
        '
        Me.D_Lbl_CName.AutoSize = True
        Me.D_Lbl_CName.Location = New System.Drawing.Point(10, 52)
        Me.D_Lbl_CName.Name = "D_Lbl_CName"
        Me.D_Lbl_CName.Size = New System.Drawing.Size(88, 13)
        Me.D_Lbl_CName.TabIndex = 4
        Me.D_Lbl_CName.Text = "Company Name :"
        '
        'D_TB_CName
        '
        Me.D_TB_CName.Enabled = False
        Me.D_TB_CName.Location = New System.Drawing.Point(114, 49)
        Me.D_TB_CName.Name = "D_TB_CName"
        Me.D_TB_CName.ReadOnly = True
        Me.D_TB_CName.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_CName.TabIndex = 5
        '
        'D_Lbl_SID
        '
        Me.D_Lbl_SID.AutoSize = True
        Me.D_Lbl_SID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.D_Lbl_SID.Location = New System.Drawing.Point(10, 26)
        Me.D_Lbl_SID.Name = "D_Lbl_SID"
        Me.D_Lbl_SID.Size = New System.Drawing.Size(65, 13)
        Me.D_Lbl_SID.TabIndex = 0
        Me.D_Lbl_SID.Text = "Supplier ID :"
        '
        'D_TB_SID
        '
        Me.D_TB_SID.Enabled = False
        Me.D_TB_SID.Location = New System.Drawing.Point(114, 23)
        Me.D_TB_SID.Name = "D_TB_SID"
        Me.D_TB_SID.ReadOnly = True
        Me.D_TB_SID.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_SID.TabIndex = 1
        '
        'D_TB_Email
        '
        Me.D_TB_Email.Enabled = False
        Me.D_TB_Email.Location = New System.Drawing.Point(420, 49)
        Me.D_TB_Email.Name = "D_TB_Email"
        Me.D_TB_Email.ReadOnly = True
        Me.D_TB_Email.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_Email.TabIndex = 7
        '
        'D_Lbl_Email
        '
        Me.D_Lbl_Email.AutoSize = True
        Me.D_Lbl_Email.Location = New System.Drawing.Point(310, 52)
        Me.D_Lbl_Email.Name = "D_Lbl_Email"
        Me.D_Lbl_Email.Size = New System.Drawing.Size(52, 13)
        Me.D_Lbl_Email.TabIndex = 6
        Me.D_Lbl_Email.Text = "Email ID :"
        '
        'D_Lbl_Adr
        '
        Me.D_Lbl_Adr.AutoSize = True
        Me.D_Lbl_Adr.Location = New System.Drawing.Point(10, 130)
        Me.D_Lbl_Adr.Name = "D_Lbl_Adr"
        Me.D_Lbl_Adr.Size = New System.Drawing.Size(51, 13)
        Me.D_Lbl_Adr.TabIndex = 16
        Me.D_Lbl_Adr.Text = "Address :"
        '
        'D_TB_Adr
        '
        Me.D_TB_Adr.Enabled = False
        Me.D_TB_Adr.Location = New System.Drawing.Point(114, 127)
        Me.D_TB_Adr.Name = "D_TB_Adr"
        Me.D_TB_Adr.ReadOnly = True
        Me.D_TB_Adr.Size = New System.Drawing.Size(489, 20)
        Me.D_TB_Adr.TabIndex = 17
        '
        'D_Lbl_P_No
        '
        Me.D_Lbl_P_No.AutoSize = True
        Me.D_Lbl_P_No.Location = New System.Drawing.Point(10, 78)
        Me.D_Lbl_P_No.Name = "D_Lbl_P_No"
        Me.D_Lbl_P_No.Size = New System.Drawing.Size(67, 13)
        Me.D_Lbl_P_No.TabIndex = 8
        Me.D_Lbl_P_No.Text = "Contact No :"
        '
        'D_TB_P_No
        '
        Me.D_TB_P_No.Enabled = False
        Me.D_TB_P_No.Location = New System.Drawing.Point(114, 75)
        Me.D_TB_P_No.Name = "D_TB_P_No"
        Me.D_TB_P_No.ReadOnly = True
        Me.D_TB_P_No.Size = New System.Drawing.Size(183, 20)
        Me.D_TB_P_No.TabIndex = 9
        '
        'GB_D_Load
        '
        Me.GB_D_Load.BackColor = System.Drawing.SystemColors.Control
        Me.GB_D_Load.Controls.Add(Me.TB_D_Load)
        Me.GB_D_Load.Controls.Add(Me.Lbl_D_Load)
        Me.GB_D_Load.Controls.Add(Me.Btn_D_Load)
        Me.GB_D_Load.Location = New System.Drawing.Point(6, 6)
        Me.GB_D_Load.Name = "GB_D_Load"
        Me.GB_D_Load.Size = New System.Drawing.Size(610, 48)
        Me.GB_D_Load.TabIndex = 0
        Me.GB_D_Load.TabStop = False
        Me.GB_D_Load.Text = "Select supplier to delete."
        '
        'TB_D_Load
        '
        Me.TB_D_Load.Location = New System.Drawing.Point(314, 19)
        Me.TB_D_Load.Name = "TB_D_Load"
        Me.TB_D_Load.Size = New System.Drawing.Size(209, 20)
        Me.TB_D_Load.TabIndex = 3
        '
        'Lbl_D_Load
        '
        Me.Lbl_D_Load.AutoSize = True
        Me.Lbl_D_Load.Location = New System.Drawing.Point(243, 22)
        Me.Lbl_D_Load.Name = "Lbl_D_Load"
        Me.Lbl_D_Load.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_D_Load.TabIndex = 0
        Me.Lbl_D_Load.Text = "Supplier ID :"
        '
        'Btn_D_Load
        '
        Me.Btn_D_Load.Location = New System.Drawing.Point(529, 17)
        Me.Btn_D_Load.Name = "Btn_D_Load"
        Me.Btn_D_Load.Size = New System.Drawing.Size(75, 23)
        Me.Btn_D_Load.TabIndex = 2
        Me.Btn_D_Load.Text = "Load"
        Me.Btn_D_Load.UseVisualStyleBackColor = True
        '
        'Btn_D_Clear_All
        '
        Me.Btn_D_Clear_All.Location = New System.Drawing.Point(534, 226)
        Me.Btn_D_Clear_All.Name = "Btn_D_Clear_All"
        Me.Btn_D_Clear_All.Size = New System.Drawing.Size(75, 23)
        Me.Btn_D_Clear_All.TabIndex = 3
        Me.Btn_D_Clear_All.Text = "Clear All"
        Me.Btn_D_Clear_All.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(453, 226)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Delete.TabIndex = 2
        Me.Btn_Delete.Text = "Delete"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 285)
        Me.Controls.Add(Me.Tab_Control)
        Me.Name = "Suppliers"
        Me.Text = "Supplier"
        Me.Tab_Control.ResumeLayout(False)
        Me.TP_Add.ResumeLayout(False)
        Me.GB_Add.ResumeLayout(False)
        Me.GB_Add.PerformLayout()
        Me.TP_Update.ResumeLayout(False)
        Me.GB_UD_Loaded.ResumeLayout(False)
        Me.GB_UD_Loaded.PerformLayout()
        Me.GB_UD_Load.ResumeLayout(False)
        Me.GB_UD_Load.PerformLayout()
        Me.TP_Delete.ResumeLayout(False)
        Me.GB_D_Loaded.ResumeLayout(False)
        Me.GB_D_Loaded.PerformLayout()
        Me.GB_D_Load.ResumeLayout(False)
        Me.GB_D_Load.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Control As System.Windows.Forms.TabControl
    Friend WithEvents TP_Add As System.Windows.Forms.TabPage
    Friend WithEvents GB_Add As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_BnkAcnt As System.Windows.Forms.Label
    Friend WithEvents Lbl_Adr As System.Windows.Forms.Label
    Friend WithEvents TB_Adr As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_P_No As System.Windows.Forms.Label
    Friend WithEvents Lbl_Name As System.Windows.Forms.Label
    Friend WithEvents Lbl_SID As System.Windows.Forms.Label
    Friend WithEvents TB_SID As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Clear_All As System.Windows.Forms.Button
    Friend WithEvents Btn_Submit As System.Windows.Forms.Button
    Friend WithEvents TP_Update As System.Windows.Forms.TabPage
    Friend WithEvents GB_UD_Loaded As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_SID As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_Adr As System.Windows.Forms.Label
    Friend WithEvents UD_TB_Adr As System.Windows.Forms.TextBox
    Friend WithEvents UD_Lbl_P_No As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_Name As System.Windows.Forms.Label
    Friend WithEvents GB_UD_Load As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_UD_Load As System.Windows.Forms.Label
    Friend WithEvents Btn_UD_Load As System.Windows.Forms.Button
    Friend WithEvents Btn_UD_Clear_All As System.Windows.Forms.Button
    Friend WithEvents Btn_Update As System.Windows.Forms.Button
    Friend WithEvents TP_Delete As System.Windows.Forms.TabPage
    Friend WithEvents GB_D_Loaded As System.Windows.Forms.GroupBox
    Friend WithEvents D_TB_BAT As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents D_TB_BAN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_CName As System.Windows.Forms.Label
    Friend WithEvents D_TB_CName As System.Windows.Forms.TextBox
    Friend WithEvents D_Lbl_SID As System.Windows.Forms.Label
    Friend WithEvents D_TB_SID As System.Windows.Forms.TextBox
    Friend WithEvents D_TB_Email As System.Windows.Forms.TextBox
    Friend WithEvents D_Lbl_Email As System.Windows.Forms.Label
    Friend WithEvents D_Lbl_Adr As System.Windows.Forms.Label
    Friend WithEvents D_TB_Adr As System.Windows.Forms.TextBox
    Friend WithEvents D_Lbl_P_No As System.Windows.Forms.Label
    Friend WithEvents D_TB_P_No As System.Windows.Forms.TextBox
    Friend WithEvents D_Lbl_Name As System.Windows.Forms.Label
    Friend WithEvents D_TB_SName As System.Windows.Forms.TextBox
    Friend WithEvents GB_D_Load As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_D_Load As System.Windows.Forms.Label
    Friend WithEvents Btn_D_Load As System.Windows.Forms.Button
    Friend WithEvents Btn_D_Clear_All As System.Windows.Forms.Button
    Friend WithEvents Btn_Delete As System.Windows.Forms.Button
    Friend WithEvents Lbl_Email As System.Windows.Forms.Label
    Friend WithEvents Lbl_CName As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_CName As System.Windows.Forms.Label
    Friend WithEvents UD_Lbl_Email As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents D_TB_BBC As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_SName As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_CName As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_Email As CRMS.EmailTB
    Friend WithEvents TB_P_No As CRMS.IntMinusSpaceTB
    Friend WithEvents TB_BAN As CRMS.IntegerTB
    Friend WithEvents TB_BAT As CRMS.CharMinusSpaceTB
    Friend WithEvents TB_BBC As CRMS.IntegerTB
    Friend WithEvents UD_TB_BBC As CRMS.IntegerTB
    Friend WithEvents UD_TB_BAN As CRMS.IntegerTB
    Friend WithEvents UD_TB_BAT As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_TB_P_No As CRMS.IntMinusSpaceTB
    Friend WithEvents UD_TB_Email As CRMS.EmailTB
    Friend WithEvents UD_TB_CName As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_TB_SName As CRMS.CharMinusSpaceTB
    Friend WithEvents UD_TB_SID As System.Windows.Forms.TextBox
    Friend WithEvents TB_UD_Load As CRMS.IntegerTB
    Friend WithEvents TB_D_Load As CRMS.IntegerTB
End Class
