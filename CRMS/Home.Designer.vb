<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.TSSL_User = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_U_Name = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Roll = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_RollType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MB_StockSetup = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_GRN = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_GRNRealize = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Suppliers = New System.Windows.Forms.ToolStripMenuItem()
        Me.MB_SSale = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_Custs = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_SReceipt = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_SRealize = New System.Windows.Forms.ToolStripMenuItem()
        Me.MB_Help = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.Control
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSSL_User, Me.TSSL_U_Name, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.TSSL_Roll, Me.TSSL_RollType, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel3})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 639)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(974, 22)
        Me.StatusStrip.TabIndex = 21
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'TSSL_User
        '
        Me.TSSL_User.Name = "TSSL_User"
        Me.TSSL_User.Size = New System.Drawing.Size(39, 17)
        Me.TSSL_User.Text = "User : "
        '
        'TSSL_U_Name
        '
        Me.TSSL_U_Name.Name = "TSSL_U_Name"
        Me.TSSL_U_Name.Size = New System.Drawing.Size(82, 17)
        Me.TSSL_U_Name.Text = "TSSL_U_Name"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel6.Text = "     "
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.Color.Silver
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel4.Text = "     "
        '
        'TSSL_Roll
        '
        Me.TSSL_Roll.Name = "TSSL_Roll"
        Me.TSSL_Roll.Size = New System.Drawing.Size(39, 17)
        Me.TSSL_Roll.Text = "Roll :  "
        '
        'TSSL_RollType
        '
        Me.TSSL_RollType.Name = "TSSL_RollType"
        Me.TSSL_RollType.Size = New System.Drawing.Size(83, 17)
        Me.TSSL_RollType.Text = "TSSL_RollType"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel2.Text = "     "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.Silver
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel3.Text = "     "
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MB_StockSetup, Me.MB_SSale, Me.MB_Help})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(974, 24)
        Me.MenuStrip.TabIndex = 25
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'MB_StockSetup
        '
        Me.MB_StockSetup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_GRN, Me.TSMI_GRNRealize, Me.TSMI_Suppliers})
        Me.MB_StockSetup.Name = "MB_StockSetup"
        Me.MB_StockSetup.Size = New System.Drawing.Size(67, 20)
        Me.MB_StockSetup.Text = "&Purchase"
        '
        'TSMI_GRN
        '
        Me.TSMI_GRN.Name = "TSMI_GRN"
        Me.TSMI_GRN.Size = New System.Drawing.Size(220, 22)
        Me.TSMI_GRN.Text = "P&urchased Invoice"
        '
        'TSMI_GRNRealize
        '
        Me.TSMI_GRNRealize.Name = "TSMI_GRNRealize"
        Me.TSMI_GRNRealize.Size = New System.Drawing.Size(220, 22)
        Me.TSMI_GRNRealize.Text = "Pur&chased Invoice Payment"
        '
        'TSMI_Suppliers
        '
        Me.TSMI_Suppliers.Name = "TSMI_Suppliers"
        Me.TSMI_Suppliers.Size = New System.Drawing.Size(220, 22)
        Me.TSMI_Suppliers.Text = "Supp&liers"
        '
        'MB_SSale
        '
        Me.MB_SSale.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_Custs, Me.TSMI_SReceipt, Me.TSMI_SRealize})
        Me.MB_SSale.Name = "MB_SSale"
        Me.MB_SSale.Size = New System.Drawing.Size(40, 20)
        Me.MB_SSale.Text = "&Sale"
        '
        'TSMI_Custs
        '
        Me.TSMI_Custs.Name = "TSMI_Custs"
        Me.TSMI_Custs.Size = New System.Drawing.Size(187, 22)
        Me.TSMI_Custs.Text = "&Customers"
        '
        'TSMI_SReceipt
        '
        Me.TSMI_SReceipt.Name = "TSMI_SReceipt"
        Me.TSMI_SReceipt.Size = New System.Drawing.Size(187, 22)
        Me.TSMI_SReceipt.Text = "Sale Invoice"
        '
        'TSMI_SRealize
        '
        Me.TSMI_SRealize.Name = "TSMI_SRealize"
        Me.TSMI_SRealize.Size = New System.Drawing.Size(187, 22)
        Me.TSMI_SRealize.Text = "Sale Invoice &Recovery"
        '
        'MB_Help
        '
        Me.MB_Help.Name = "MB_Help"
        Me.MB_Help.Size = New System.Drawing.Size(44, 20)
        Me.MB_Help.Text = "&Help"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 661)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents TSSL_User As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_U_Name As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Roll As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_RollType As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MB_StockSetup As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MB_SSale As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Custs As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_SReceipt As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MB_Help As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_Suppliers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_SRealize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_GRN As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSMI_GRNRealize As System.Windows.Forms.ToolStripMenuItem
End Class
