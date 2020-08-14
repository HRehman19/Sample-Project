Imports System.Data.SqlClient

Public Class Invoice_Purchase

    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=CRMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim SNum, GRNO, INo, Supp, Comp, PmntNo, GRNTotlAmnt, RemngCrdt As String 'For Data GridView Only
    Dim ChkBox, UD_ChkBox, D_ChkBox As String   'For Payment Method
    Dim RB_Click As Boolean = False 'For Checkbox Checked Status
    Dim PCred, AmntPad, ChqPad, RCredit, InvCrdit As Decimal 'For Money Convertion to Decimal
    Dim PrevPmntNo, CStatus, UD_CStatus As String
    Dim SuppID, PaymentID As Long

    Private Sub GRN_Realize_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Utype As String = Home.TSSL_RollType.Text
        If Utype = "User" Or Utype = "user" Then
            Tab_Control.TabPages.Remove(TP_Delete)
        End If
        CredLoad()
    End Sub

    '"""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Addition Code Start ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Starts ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub RB_ByGRN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ByGRN.CheckedChanged
        DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
        DGV_Realize.Columns(3).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub RB_ByInvNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ByInvNo.CheckedChanged
        DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
        DGV_Realize.Columns(3).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub RB_BySup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_BySup.CheckedChanged
        DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
        DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub TB_DGV_Filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_DGV_Filter.TextChanged
        CredLoad()
    End Sub

    Private Sub DGV_Realize_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Realize.CellClick
        Try
            Dim index As Integer = e.RowIndex
            If e.ColumnIndex = 9 And e.RowIndex >= 0 Then
                If Me.DGV_Realize.Rows(index).Cells(1).Value <> "" Then
                    RB_Uncheck()
                    TB_InvID.Text = DGV_Realize.Rows(index).Cells(1).Value
                    TB_PmntID.Text = PmntID()
                    TB_SName.Text = DGV_Realize.Rows(index).Cells(4).Value
                    TB_CName.Text = DGV_Realize.Rows(index).Cells(5).Value
                    TB_GRNTA.Text = DGV_Realize.Rows(index).Cells(6).Value
                    TB_RCredit.Text = DGV_Realize.Rows(index).Cells(7).Value
                    TB_PCred.Text = DGV_Realize.Rows(index).Cells(8).Value
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub RB_Cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Cash.CheckedChanged
        CStatus = "Active"
        ChkBox = RB_Cash.Text.Trim()
        RB_Click = True
        Reefresh()
        If TB_GRNTA.Text.Trim() <> "" Then
            TB_AmntPad.Text = TB_PCred.Text.Trim()
            TB_ChqPad.Text = 0
            TB_TBalance.Text = 0
        End If
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_TBalance.Enabled = False
        TB_TBalance.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = False
        TB_ChqNo.ReadOnly = True
        DTP_ChqDate.Enabled = False
        TB_BnkNam.Enabled = False
        TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub RB_CashNChq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CashNChq.CheckedChanged
        CStatus = "Active"
        ChkBox = RB_CashNChq.Text.Trim()
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = True
        TB_AmntPad.ReadOnly = False
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_TBalance.Enabled = False
        TB_TBalance.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_CshNChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CshNChqNCred.CheckedChanged
        CStatus = "Active"
        ChkBox = RB_CshNChqNCred.Text.Trim()
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = True
        TB_AmntPad.ReadOnly = False
        TB_ChqPad.Enabled = True
        TB_ChqPad.ReadOnly = False
        TB_TBalance.Enabled = False
        TB_TBalance.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_CashNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CashNCred.CheckedChanged
        CStatus = "Active"
        ChkBox = RB_CashNCred.Text.Trim()
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = True
        TB_AmntPad.ReadOnly = False
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_TBalance.Enabled = False
        TB_TBalance.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = False
        TB_ChqNo.ReadOnly = True
        DTP_ChqDate.Enabled = False
        TB_BnkNam.Enabled = False
        TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub RB_Cheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Cheque.CheckedChanged
        CStatus = "Active"
        ChkBox = RB_Cheque.Text.Trim()
        RB_Click = True
        Reefresh()
        If TB_GRNTA.Text.Trim() <> "" Then
            TB_ChqPad.Text = CDec(TB_PCred.Text.Trim())
            TB_AmntPad.Text = 0
            TB_TBalance.Text = 0
        End If
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_TBalance.Enabled = False
        TB_TBalance.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_ChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ChqNCred.CheckedChanged
        CStatus = "Active"
        ChkBox = RB_ChqNCred.Text.Trim()
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = True
        TB_ChqPad.ReadOnly = False
        TB_TBalance.Enabled = False
        TB_TBalance.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub TB_AmntPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_AmntPad.Leave
        If TB_PCred.Text = "" Then
            PCred = 0
        Else
            PCred = TB_PCred.Text.Trim()
        End If
        If TB_AmntPad.Text = "" Then
            AmntPad = 0
        Else
            AmntPad = TB_AmntPad.Text.Trim()
        End If
        If TB_ChqPad.Text = "" Then
            ChqPad = 0
        Else
            ChqPad = TB_ChqPad.Text.Trim()
        End If
        If TB_TBalance.Text = "" Then
            RCredit = 0
        Else
            RCredit = TB_TBalance.Text.Trim()
        End If

        If RB_CashNChq.Checked = True Then
            AmountCheck()
            ChqPad = PCred - AmntPad
            RCredit = 0
        ElseIf RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If AmntPad <= PCred And ChqPad <> 0 Then
                RCredit = (PCred - (AmntPad + ChqPad))
            Else
                RCredit = PCred - AmntPad
            End If
        ElseIf RB_CashNCred.Checked = True Then
            AmountCheck()
            ChqPad = 0
            RCredit = PCred - AmntPad
        End If

        TB_ChqPad.Text = ChqPad
        TB_TBalance.Text = RCredit

    End Sub

    Private Sub TB_ChqPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_ChqPad.Leave
        If TB_PCred.Text = "" Then
            PCred = 0
        Else
            PCred = TB_PCred.Text.Trim()
        End If
        If TB_AmntPad.Text = "" Then
            AmntPad = 0
        Else
            AmntPad = TB_AmntPad.Text.Trim()
        End If
        If TB_ChqPad.Text = "" Then
            ChqPad = 0
        Else
            ChqPad = TB_ChqPad.Text.Trim()
        End If
        If TB_TBalance.Text = "" Then
            RCredit = 0
        Else
            RCredit = TB_TBalance.Text.Trim()
        End If

        If RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If ChqPad <= PCred And AmntPad <> 0 Then
                RCredit = (PCred - (AmntPad + ChqPad))
            Else
                RCredit = PCred - ChqPad
            End If
        ElseIf RB_ChqNCred.Checked = True Then
            AmountCheck()
            AmntPad = 0
            RCredit = PCred - ChqPad
        End If
        TB_AmntPad.Text = AmntPad
        TB_TBalance.Text = RCredit
    End Sub

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Ends ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    '~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub Btn_Clrall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clrall.Click
        RB_ByGRN.Checked = False
        RB_ByInvNo.Checked = False
        RB_BySup.Checked = False
        TB_DGV_Filter.Text = ""
        CredLoad()
        TB_InvID.Text = ""
        TB_PmntID.Text = ""
        TB_SName.Text = ""
        TB_CName.Text = ""
        TB_GRNTA.Text = ""
        TB_RCredit.Text = ""
        TB_PCred.Text = ""
        TB_AmntPad.Text = ""
        TB_ChqPad.Text = ""
        TB_RecName.Text = ""
        TB_ChqNo.Text = ""
        DTP_ChqDate.Text = Today()
        TB_BnkNam.Text = ""
        DTP_PDD.Text = Today()
        RB_Uncheck()
        TB_TBalance.Text = ""
    End Sub

    Private Sub Btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Submit.Click
        Try
            If RB_Click = False Then
                MessageBox.Show("Please select ""Payment Method"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Try
                    SuppID = SupID(TB_SName.Text.Trim(), TB_CName.Text.Trim())
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        Try
                            cmd.CommandText = "Update GRNPayment set Credit_Status = 'Idle' where Invoice_ID = (Select GRN.Invoice_ID FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE GRN.SID = '" & SuppID & "' AND GRNPayment.Credit_Status = 'Active')"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Insert into GRNPayment (Payment_ID, Invoice_ID, GRNTAmount, Payment_Method, CashPaid, ChequePaid, Invoice_Credit, Receivers_Name, ChequeNo, ChequeDate, BankName, PaymentDeliveryDate, TotalBalance, Credit_Status) VALUES ('" & TB_PmntID.Text.Trim() & "', '" & TB_InvID.Text.Trim() & "', '" & TB_GRNTA.Text.Trim() & "', '" & ChkBox & "', '" & TB_AmntPad.Text.Trim() & "', '" & TB_ChqPad.Text.Trim() & "', '" & TB_RCredit.Text.Trim() & "', '" & TB_RecName.Text.Trim() & "', '" & TB_ChqNo.Text.Trim() & "', '" & DTP_ChqDate.Text.Trim() & "', '" & TB_BnkNam.Text.Trim() & "', '" & DTP_PDD.Text.Trim() & "', '" & TB_TBalance.Text.Trim() & "', '" & CStatus & "')"
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MessageBox.Show("""Realize"" has been saved Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Btn_Clrall_Click(sender, e)
                        Catch ex As Exception
                            MessageBox.Show(String.Format("Error: {0}", ex.Message))
                            Try
                                transaction.Rollback()
                            Catch ex2 As Exception
                                MessageBox.Show(String.Format("Rollbacking: {0}", ex2.Message))
                            End Try
                        End Try
                    End Using
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    ''~~~~~~~~~~~~~~~~~ Buttons Code End ~~~~~~~~~~~~~~~~~'
    ''____________________________________________________'

    ''"""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Addition Code End ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '#####################################################################'
    ''~~~~~~~~~~~~~~ Updation & Deletion Header Code Starts ~~~~~~~~~~~~~~'
    '_____________________________________________________________________'

    Private Sub Tab_Control_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Control.SelectedIndexChanged
        If Tab_Control.SelectedIndex = 0 Then
            CredLoad()
        ElseIf Tab_Control.SelectedIndex = 1 Then
            UD_CredLoad()
        ElseIf Tab_Control.SelectedIndex = 2 Then
            D_CredLoad()
        End If
    End Sub

    '###################################################################'
    ''~~~~~~~~~~~~~~ Updation & Deletion Header Code Ends ~~~~~~~~~~~~~~'
    '___________________________________________________________________'

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Starts ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub UD_RB_ByGRN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_ByGRN.CheckedChanged
        UD_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
        UD_DGV_Realize.Columns(3).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub UD_RB_ByInvNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_ByInvNo.CheckedChanged
        UD_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
        UD_DGV_Realize.Columns(3).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub UD_RB_BySup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_BySup.CheckedChanged
        UD_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
        UD_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub UD_TB_DGV_Filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_DGV_Filter.TextChanged
        UD_CredLoad()
    End Sub

    Private Sub UD_DGV_Realize_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UD_DGV_Realize.CellClick
        Try
            Dim index As Integer = e.RowIndex
            PaymentID = UD_DGV_Realize.Rows(index).Cells(3).Value
            If e.ColumnIndex = 9 And e.RowIndex >= 0 Then
                If Me.UD_DGV_Realize.Rows(index).Cells(1).Value <> "" Then
                    UD_New_DGV_Realize.Rows.Clear()
                    Try

                        SuppID = SupID(UD_DGV_Realize.Rows(index).Cells(4).Value, UD_DGV_Realize.Rows(index).Cells(5).Value)
                        cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE (GRNPayment.Payment_ID  = (SELECT MAX(GRNPayment.Payment_ID) FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE (GRN.SID = '" & SuppID & "') AND (GRNPayment.Credit_Status = 'Idle')))", con)
                        If con.State = ConnectionState.Closed Then con.Open()
                        Using dr = cmd.ExecuteReader()
                            While dr.Read()
                                Dim rz As Integer = UD_New_DGV_Realize.RowCount - 1
                                Dim SNum As Integer
                                If rz = 0 Then
                                    SNum = 1
                                Else
                                    SNum = rz + 1
                                End If
                                GRNO = dr("Invoice_ID")
                                INo = dr("Invoice_No")
                                PmntNo = dr("Payment_ID")
                                Supp = dr("SName")
                                Comp = dr("CName")
                                GRNTotlAmnt = dr("GRNTAmount")
                                InvCrdit = dr("Invoice_Credit")
                                RemngCrdt = dr("TotalBalance")
                                Dim row As String()
                                row = New String() {SNum, GRNO, INo, PmntNo, Supp, Comp, GRNTotlAmnt, InvCrdit, RemngCrdt}
                                UD_New_DGV_Realize.Rows.Add(row)
                                UD_New_DGV_Realize_Btn_realize.Text = "Pay Credit"
                                UD_New_DGV_Realize_Btn_realize.UseColumnTextForButtonValue = True
                            End While
                        End Using

                    Catch ex As Exception
                        MessageBox.Show(String.Format("Error: {0}", ex.Message))
                    End Try

                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UD_New_DGV_Realize_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UD_New_DGV_Realize.CellClick
        Try
            Dim index As Integer = e.RowIndex

            If e.ColumnIndex = 9 And e.RowIndex >= 0 Then
                If Me.UD_New_DGV_Realize.Rows(index).Cells(1).Value <> "" Then
                    RB_Uncheck()
                    UD_TB_InvID.Text = UD_New_DGV_Realize.Rows(index).Cells(1).Value
                    UD_TB_PmntID.Text = PaymentID
                    UD_TB_SName.Text = UD_New_DGV_Realize.Rows(index).Cells(4).Value
                    UD_TB_CName.Text = UD_New_DGV_Realize.Rows(index).Cells(5).Value
                    UD_TB_GRNTA.Text = UD_New_DGV_Realize.Rows(index).Cells(6).Value
                    UD_TB_RCredit.Text = UD_New_DGV_Realize.Rows(index).Cells(7).Value
                    UD_TB_PCred.Text = UD_New_DGV_Realize.Rows(index).Cells(8).Value
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub UD_RB_Cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_Cash.CheckedChanged
        UD_CStatus = "Active"
        UD_ChkBox = UD_RB_Cash.Text.Trim()
        RB_Click = True
        UD_Reefresh()
        If UD_TB_GRNTA.Text.Trim() <> "" Then
            UD_TB_AmntPad.Text = UD_TB_PCred.Text.Trim()
            UD_TB_ChqPad.Text = 0
            UD_TB_TBalance.Text = 0
        End If
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = False
        UD_TB_ChqNo.ReadOnly = True
        UD_DTP_ChqDate.Enabled = False
        UD_TB_BnkNam.Enabled = False
        UD_TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub UD_RB_CashNChq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_CashNChq.CheckedChanged
        UD_CStatus = "Active"
        UD_ChkBox = UD_RB_CashNChq.Text.Trim()
        RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = True
        UD_TB_AmntPad.ReadOnly = False
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_CshNChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_CshNChqNCred.CheckedChanged
        UD_CStatus = "Active"
        UD_ChkBox = UD_RB_CshNChqNCred.Text.Trim()
        RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = True
        UD_TB_AmntPad.ReadOnly = False
        UD_TB_ChqPad.Enabled = True
        UD_TB_ChqPad.ReadOnly = False
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_CashNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_CashNCred.CheckedChanged
        UD_CStatus = "Active"
        UD_ChkBox = UD_RB_CashNCred.Text.Trim()
        RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = True
        UD_TB_AmntPad.ReadOnly = False
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = False
        UD_TB_ChqNo.ReadOnly = True
        UD_DTP_ChqDate.Enabled = False
        UD_TB_BnkNam.Enabled = False
        UD_TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub UD_RB_Cheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_Cheque.CheckedChanged
        UD_CStatus = "Active"
        UD_ChkBox = UD_RB_Cheque.Text.Trim()
        RB_Click = True
        UD_Reefresh()
        If UD_TB_GRNTA.Text.Trim() <> "" Then
            UD_TB_ChqPad.Text = CDec(UD_TB_PCred.Text.Trim())
            UD_TB_AmntPad.Text = 0
            UD_TB_TBalance.Text = 0
        End If
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_ChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_ChqNCred.CheckedChanged
        UD_CStatus = "Active"
        UD_ChkBox = UD_RB_ChqNCred.Text.Trim()
        RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = True
        UD_TB_ChqPad.ReadOnly = False
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_TB_AmntPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_AmntPad.Leave
        If UD_TB_PCred.Text = "" Then
            PCred = 0
        Else
            PCred = UD_TB_PCred.Text.Trim()
        End If
        If UD_TB_AmntPad.Text = "" Then
            AmntPad = 0
        Else
            AmntPad = UD_TB_AmntPad.Text.Trim()
        End If
        If UD_TB_ChqPad.Text = "" Then
            ChqPad = 0
        Else
            ChqPad = UD_TB_ChqPad.Text.Trim()
        End If
        If UD_TB_TBalance.Text = "" Then
            RCredit = 0
        Else
            RCredit = UD_TB_RCredit.Text.Trim()
        End If

        If UD_RB_CashNChq.Checked = True Then
            AmountCheck()
            ChqPad = PCred - AmntPad
            RCredit = 0
        ElseIf UD_RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If AmntPad <= PCred And ChqPad <> 0 Then
                RCredit = (PCred - (AmntPad + ChqPad))
            Else
                RCredit = PCred - AmntPad
            End If
        ElseIf UD_RB_CashNCred.Checked = True Then
            AmountCheck()
            ChqPad = 0
            RCredit = PCred - AmntPad
        End If

        UD_TB_ChqPad.Text = ChqPad
        UD_TB_TBalance.Text = RCredit

    End Sub

    Private Sub UD_TB_ChqPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_ChqPad.Leave
        If UD_TB_PCred.Text = "" Then
            PCred = 0
        Else
            PCred = UD_TB_PCred.Text.Trim()
        End If
        If UD_TB_AmntPad.Text = "" Then
            AmntPad = 0
        Else
            AmntPad = UD_TB_AmntPad.Text.Trim()
        End If
        If UD_TB_ChqPad.Text = "" Then
            ChqPad = 0
        Else
            ChqPad = UD_TB_ChqPad.Text.Trim()
        End If
        If UD_TB_TBalance.Text = "" Then
            RCredit = 0
        Else
            RCredit = UD_TB_TBalance.Text.Trim()
        End If

        If UD_RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If ChqPad <= PCred And AmntPad <> 0 Then
                RCredit = (PCred - (AmntPad + ChqPad))
            Else
                RCredit = PCred - ChqPad
            End If
        ElseIf UD_RB_ChqNCred.Checked = True Then
            AmountCheck()
            AmntPad = 0
            RCredit = PCred - ChqPad
        End If
        UD_TB_AmntPad.Text = AmntPad
        UD_TB_TBalance.Text = RCredit
    End Sub

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Ends ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    ''~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    ''______________________________________________________'

    Private Sub UD_Btn_Clrall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_Btn_Clrall.Click
        UD_RB_ByGRN.Checked = False
        UD_RB_ByInvNo.Checked = False
        UD_RB_BySup.Checked = False
        UD_TB_DGV_Filter.Text = ""
        UD_CredLoad()
        UD_TB_InvID.Text = ""
        UD_TB_PmntID.Text = ""
        UD_TB_SName.Text = ""
        UD_TB_CName.Text = ""
        UD_TB_GRNTA.Text = ""
        UD_TB_PCred.Text = ""
        UD_TB_AmntPad.Text = ""
        UD_TB_ChqPad.Text = ""
        UD_TB_RCredit.Text = ""
        UD_TB_RecName.Text = ""
        UD_TB_ChqNo.Text = ""
        UD_DTP_ChqDate.Text = Today()
        UD_TB_BnkNam.Text = ""
        UD_DTP_PDD.Text = Today()
        RB_Uncheck()
        UD_TB_TBalance.Text = ""
    End Sub

    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        Try
            If RB_Click = False Then
                MessageBox.Show("Please select ""Payment Method"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Try
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        Try
                            cmd.CommandText = "Update GRNPayment set Payment_Method = '" & UD_ChkBox & "', CashPaid = '" & UD_TB_AmntPad.Text.Trim() & "', ChequePaid = '" & UD_TB_ChqPad.Text.Trim() & "', Receivers_Name = '" & UD_TB_RecName.Text.Trim() & "', ChequeNo = '" & UD_TB_ChqNo.Text.Trim() & "', ChequeDate = '" & UD_DTP_ChqDate.Text.Trim() & "', BankName = '" & UD_TB_BnkNam.Text.Trim() & "', PaymentDeliveryDate = '" & UD_DTP_PDD.Text.Trim() & "', TotalBalance = '" & UD_TB_TBalance.Text.Trim() & "', Credit_Status = '" & UD_CStatus & "' where Payment_ID = '" & UD_TB_PmntID.Text.Trim() & "' AND Invoice_ID = '" & UD_TB_InvID.Text.Trim() & "'"
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MessageBox.Show("""Realize"" has been Updated Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            UD_Btn_Clrall_Click(sender, e)
                        Catch ex As Exception
                            MessageBox.Show(String.Format("Error: {0}", ex.Message))
                            Try
                                transaction.Rollback()
                            Catch ex2 As Exception
                                MessageBox.Show(String.Format("Rollbacking: {0}", ex2.Message))
                            End Try
                        End Try
                    End Using
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    '~~~~~~~~~~~~~~~~~ Buttons Code End ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    '"""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Updation Code End ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '""""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Deletion Code Starts ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Starts ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub D_RB_ByGRN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_RB_ByGRN.CheckedChanged
        D_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
        D_DGV_Realize.Columns(3).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub D_RB_ByInvNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_RB_ByInvNo.CheckedChanged
        D_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
        D_DGV_Realize.Columns(3).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub D_RB_BySup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_RB_BySup.CheckedChanged
        D_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
        D_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
    End Sub

    Private Sub D_TB_DGV_Filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_TB_DGV_Filter.TextChanged
        D_CredLoad()
    End Sub

    Private Sub D_DGV_Realize_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles D_DGV_Realize.CellClick
        Try
            Dim index As Integer = e.RowIndex
            If e.ColumnIndex = 9 And e.RowIndex >= 0 Then
                If Me.D_DGV_Realize.Rows(index).Cells(1).Value <> "" Then
                    Try
                        Dim DGRNNO As Integer = D_DGV_Realize.Rows(index).Cells(1).Value
                        Dim PmntNo As Integer = D_DGV_Realize.Rows(index).Cells(3).Value
                        Dim Pmethod As String = ""
                        Dim Saplier As String = ""
                        Dim Campny As String = ""
                        Using cmd As New SqlCommand
                            Dim transaction As SqlTransaction
                            If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                            transaction = con.BeginTransaction("SampleTransaction")
                            cmd.Connection = con
                            cmd.Transaction = transaction
                            Try
                                cmd.CommandText = "SELECT GRNPayment.Payment_Method, Suppliers.SName, Suppliers.CName, " _
                                    & "GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.CashPaid, " _
                                    & "GRNPayment.ChequePaid, GRNPayment.Receivers_Name, GRNPayment.ChequeNo, " _
                                    & "GRNPayment.ChequeDate, GRNPayment.BankName, GRNPayment.PaymentDeliveryDate, " _
                                    & "GRNPayment.TotalBalance, GRNPayment.Credit_Status " _
                                    & "FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN " _
                                    & "Suppliers ON GRN.SID = Suppliers.SID " _
                                    & "WHERE (GRNPayment.Payment_ID = '" & PmntNo & "') AND (GRNPayment.Invoice_ID = '" & DGRNNO & "')"
                                Using dr = cmd.ExecuteReader()
                                    While dr.Read
                                        D_TB_PNo.Text = PmntNo
                                        D_TB_GRN.Text = DGRNNO
                                        Pmethod = dr("Payment_Method")
                                        D_TB_SName.Text = dr("SName")
                                        Saplier = dr("SName")
                                        D_TB_CName.Text = dr("CName")
                                        Campny = dr("CName")
                                        D_TB_GRNTA.Text = dr("GRNTAmount")
                                        D_TB_RCredit.Text = dr("Invoice_Credit")
                                        D_TB_AmntPad.Text = dr("CashPaid")
                                        D_TB_ChqPad.Text = dr("ChequePaid")
                                        D_TB_RecName.Text = dr("Receivers_Name")
                                        D_TB_ChqNo.Text = dr("ChequeNo")
                                        D_DTP_ChqDate.Text = dr("ChequeDate")
                                        D_TB_BnkNam.Text = dr("BankName")
                                        D_DTP_PDD.Text = dr("PaymentDeliveryDate")
                                        D_TB_TBalance.Text = dr("TotalBalance")
                                        D_CStatus.Text = dr("Credit_Status")
                                    End While
                                End Using
                                If Pmethod = D_RB_Cash.Text Then
                                    D_RB_Cash.Checked = True
                                ElseIf Pmethod = D_RB_CashNChq.Text Then
                                    D_RB_CashNChq.Checked = True
                                ElseIf Pmethod = D_RB_CshNChqNCred.Text Then
                                    D_RB_CshNChqNCred.Checked = True
                                ElseIf Pmethod = D_RB_CashNCred.Text Then
                                    D_RB_CashNCred.Checked = True
                                ElseIf Pmethod = D_RB_Cheque.Text Then
                                    D_RB_Cheque.Checked = True
                                ElseIf Pmethod = D_RB_ChqNCred.Text Then
                                    D_RB_ChqNCred.Checked = True
                                End If
                                cmd.CommandText = "SELECT TotalBalance FROM GRNPayment WHERE Payment_ID = " _
                                    & "(SELECT MAX(GRNPayment.Payment_ID) FROM GRN INNER JOIN  GRNPayment ON " _
                                    & "GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID " _
                                    & "WHERE Suppliers.SName = '" & Saplier & "' AND " _
                                    & "Suppliers.CName = '" & Campny & "' AND GRNPayment.Credit_Status ='Idle')"
                                Using dr = cmd.ExecuteReader()
                                    If dr.Read() Then
                                        D_TB_PCred.Text = dr("TotalBalance")
                                    Else
                                        D_TB_PCred.Text = "Can't read."
                                    End If

                                End Using
                                transaction.Commit()
                            Catch ex As Exception
                                MessageBox.Show(String.Format("Error: {0}", ex.Message))
                                Try
                                    transaction.Rollback()
                                Catch ex2 As Exception
                                    MessageBox.Show(String.Format("Rollbacking: {0}", ex2.Message))
                                End Try
                            End Try
                        End Using
                    Catch ex As Exception
                        MessageBox.Show(String.Format("Error: {0}", ex.Message))
                    End Try
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Ends ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    '~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub D_Btn_Clrall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_Btn_Clrall.Click
        D_RB_ByGRN.Checked = False
        D_RB_ByInvNo.Checked = False
        D_RB_BySup.Checked = False
        D_TB_DGV_Filter.Text = ""
        D_CredLoad()
        D_TB_GRN.Text = ""
        D_TB_PNo.Text = ""
        D_TB_SName.Text = ""
        D_TB_CName.Text = ""
        D_TB_GRNTA.Text = ""
        D_TB_AmntPad.Text = ""
        D_TB_ChqPad.Text = ""
        D_TB_RCredit.Text = ""
        D_TB_PCred.Text = ""
        D_TB_RecName.Text = ""
        D_TB_ChqNo.Text = ""
        D_DTP_ChqDate.Text = Today()
        D_TB_BnkNam.Text = ""
        D_DTP_PDD.Text = Today()
        D_TB_TBalance.Text = ""
        RB_Uncheck()
        D_CStatus.Text = "----------"
    End Sub

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            If D_TB_GRN.Text.Trim() = "" Then
                MessageBox.Show("Please Select a ""Realize"" first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Try
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        Try
                            cmd.CommandText = "Delete from GRNPayment where Invoice_ID = '" & D_TB_GRN.Text.Trim() & "' AND Payment_ID = '" & D_TB_PNo.Text.Trim() & "'"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Update GRNPayment SET Credit_Status = 'Active' WHERE Payment_ID = " _
                                & "(SELECT MAX(Payment_ID) FROM GRNPayment WHERE Invoice_ID = '" & D_TB_GRN.Text.Trim() & "' " _
                                & "AND Credit_Status = 'Idle')"
                            cmd.ExecuteNonQuery()

                            Dim Permision As Integer = MessageBox.Show("Are you sure to delete Payment ID : " + D_TB_PNo.Text.Trim() + "." + Environment.NewLine + "It will be deleted Permanently.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If Permision = DialogResult.Yes Then
                                transaction.Commit()
                                MessageBox.Show("""Realize"" has been Deleted Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                D_Btn_Clrall_Click(sender, e)
                            Else
                                Try
                                    transaction.Rollback()
                                    MessageBox.Show("""Deletion"" has been Canceled.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Catch ex2 As Exception
                                    MessageBox.Show(String.Format("Rollbacking: {0}", ex2.Message))
                                End Try
                            End If
                        Catch ex As Exception
                            MessageBox.Show(String.Format("Error: {0}", ex.Message))
                            Try
                                transaction.Rollback()
                            Catch ex2 As Exception
                                MessageBox.Show(String.Format("Rollbacking: {0}", ex2.Message))
                            End Try
                        End Try
                    End Using
                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    '~~~~~~~~~~~~~~~~~ Buttons Code End ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    '"""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Deletion Code End ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    ' Private Functions
    Private Sub CredLoad()
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        DGV_Realize.Rows.Clear()
        Try
            If RB_ByGRN.Checked = True And caler.Name = "TB_DGV_Filter_TextChanged" And TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND TotalBalance > 0 AND GRN.Invoice_ID Like '%" & TB_DGV_Filter.Text.Trim() & "%'", con)
                DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf RB_ByInvNo.Checked = True And caler.Name = "TB_DGV_Filter_TextChanged" And TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND TotalBalance > 0 AND GRN.Invoice_No Like '%" & TB_DGV_Filter.Text.Trim() & "%' ORDER BY GRN.Invoice_No ASC", con)
                DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf RB_BySup.Checked = True And caler.Name = "TB_DGV_Filter_TextChanged" And TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND TotalBalance > 0 AND Suppliers.SName Like '%" & TB_DGV_Filter.Text.Trim() & "%' ORDER BY Suppliers.SName ASC", con)
                DGV_Realize.Columns(4).DefaultCellStyle.BackColor = Color.LightGreen
            Else
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND TotalBalance > 0 ORDER BY Suppliers.SName", con)
                DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
                DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
                DGV_Realize.Columns(4).DefaultCellStyle.BackColor = Color.White
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            Using dr = cmd.ExecuteReader()
                While dr.Read()
                    Dim rz As Integer = DGV_Realize.RowCount - 1
                    Dim SNum As Integer
                    If rz = 0 Then
                        SNum = 1
                    Else
                        SNum = rz + 1
                    End If
                    GRNO = dr("Invoice_ID")
                    INo = dr("Invoice_No")
                    PmntNo = dr("Payment_ID")
                    Supp = dr("SName")
                    Comp = dr("CName")
                    GRNTotlAmnt = dr("GRNTAmount")
                    InvCrdit = dr("Invoice_Credit")
                    RemngCrdt = dr("TotalBalance")
                    Dim row As String()
                    row = New String() {SNum, GRNO, INo, PmntNo, Supp, Comp, GRNTotlAmnt, InvCrdit, RemngCrdt}
                    DGV_Realize.Rows.Add(row)
                    DGV_Realize_Btn_Realize.Text = "Pay Credit"
                    DGV_Realize_Btn_Realize.UseColumnTextForButtonValue = True
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub UD_CredLoad()
        Dim tday As String = Date.Now.ToString("yyyy-MM-dd")
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        UD_DGV_Realize.Rows.Clear()
        UD_New_DGV_Realize.Rows.Clear()
        Try
            If UD_RB_ByGRN.Checked = True And caler.Name = "UD_TB_DGV_Filter_TextChanged" And UD_TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND GRN.Invoice_ID Like '%" & UD_TB_DGV_Filter.Text.Trim() & "%' AND GRNPayment.Invoice_ID  IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a)", con)
                UD_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf UD_RB_ByInvNo.Checked = True And caler.Name = "UD_TB_DGV_Filter_TextChanged" And UD_TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND GRN.Invoice_No Like '%" & UD_TB_DGV_Filter.Text.Trim() & "%' AND GRNPayment.Invoice_ID  IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a)  ORDER BY GRN.Invoice_No ASC", con)
                UD_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf UD_RB_BySup.Checked = True And caler.Name = "UD_TB_DGV_Filter_TextChanged" And UD_TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND Suppliers.SName Like '%" & UD_TB_DGV_Filter.Text.Trim() & "%'  AND GRNPayment.Invoice_ID IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a) ORDER BY Suppliers.SName ASC", con)
                UD_DGV_Realize.Columns(4).DefaultCellStyle.BackColor = Color.LightGreen
            Else
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND GRNPayment.Invoice_ID IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a) ORDER BY Suppliers.SName", con)
                UD_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
                UD_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
                UD_DGV_Realize.Columns(4).DefaultCellStyle.BackColor = Color.White

            End If
            If con.State = ConnectionState.Closed Then con.Open()
            Using dr = cmd.ExecuteReader()
                While dr.Read()
                    Dim rz As Integer = UD_DGV_Realize.RowCount - 1
                    Dim SNum As Integer
                    If rz = 0 Then
                        SNum = 1
                    Else
                        SNum = rz + 1
                    End If
                    GRNO = dr("Invoice_ID")
                    INo = dr("Invoice_No")
                    PmntNo = dr("Payment_ID")
                    Supp = dr("SName")
                    Comp = dr("CName")
                    GRNTotlAmnt = dr("GRNTAmount")
                    InvCrdit = dr("Invoice_Credit")
                    RemngCrdt = dr("TotalBalance")
                    Dim row As String()
                    row = New String() {SNum, GRNO, INo, PmntNo, Supp, Comp, GRNTotlAmnt, InvCrdit, RemngCrdt}
                    UD_DGV_Realize.Rows.Add(row)
                    UD_DGV_Realize_Btn_Realize.Text = "Retake"
                    UD_DGV_Realize_Btn_Realize.UseColumnTextForButtonValue = True
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Private Sub D_CredLoad()
        Dim tday As String = Date.Now.ToString("yyyy-MM-dd")
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        D_DGV_Realize.Rows.Clear()

        Try
            If D_RB_ByGRN.Checked = True And caler.Name = "D_TB_DGV_Filter_TextChanged" And D_TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND GRN.Invoice_ID Like '%" & D_TB_DGV_Filter.Text.Trim() & "%' AND GRNPayment.Invoice_ID  IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a)", con)
                D_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf D_RB_ByInvNo.Checked = True And caler.Name = "D_TB_DGV_Filter_TextChanged" And D_TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND GRN.Invoice_No Like '%" & D_TB_DGV_Filter.Text.Trim() & "%' AND GRNPayment.Invoice_ID  IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a)  ORDER BY GRN.Invoice_No ASC", con)
                D_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf D_RB_BySup.Checked = True And caler.Name = "D_TB_DGV_Filter_TextChanged" And D_TB_DGV_Filter.Text <> "" Then
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND Suppliers.SName Like '%" & D_TB_DGV_Filter.Text.Trim() & "%'  AND GRNPayment.Invoice_ID IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a) ORDER BY Suppliers.SName ASC", con)
                D_DGV_Realize.Columns(4).DefaultCellStyle.BackColor = Color.LightGreen
            Else
                cmd = New SqlCommand("SELECT GRN.Invoice_ID, GRN.Invoice_No, GRNPayment.Payment_ID, Suppliers.SName, Suppliers.CName, GRNPayment.GRNTAmount, GRNPayment.Invoice_Credit, GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID INNER JOIN Suppliers ON GRN.SID = Suppliers.SID WHERE GRNPayment.Credit_Status = 'Active' AND GRNPayment.Invoice_ID IN (SELECT * FROM (SELECT Invoice_ID FROM GRNPayment GROUP BY Invoice_ID HAVING COUNT(Invoice_ID) > 1) AS a) ORDER BY Suppliers.SName", con)
                D_DGV_Realize.Columns(1).DefaultCellStyle.BackColor = Color.White
                D_DGV_Realize.Columns(2).DefaultCellStyle.BackColor = Color.White
                D_DGV_Realize.Columns(4).DefaultCellStyle.BackColor = Color.White
            End If
            If con.State = ConnectionState.Closed Then con.Open()
            Using dr = cmd.ExecuteReader()
                While dr.Read()
                    Dim rz As Integer = D_DGV_Realize.RowCount - 1
                    Dim SNum As Integer
                    If rz = 0 Then
                        SNum = 1
                    Else
                        SNum = rz + 1
                    End If
                    GRNO = dr("Invoice_ID")
                    INo = dr("Invoice_No")
                    PmntNo = dr("Payment_ID")
                    Supp = dr("SName")
                    Comp = dr("CName")
                    GRNTotlAmnt = dr("GRNTAmount")
                    InvCrdit = dr("Invoice_Credit")
                    RemngCrdt = dr("TotalBalance")
                    Dim row As String()
                    row = New String() {SNum, GRNO, INo, PmntNo, Supp, Comp, GRNTotlAmnt, InvCrdit, RemngCrdt}
                    D_DGV_Realize.Rows.Add(row)
                    D_DGV_Realize_Btn_Realize.Text = "Select"
                    D_DGV_Realize_Btn_Realize.UseColumnTextForButtonValue = True
                End While
            End Using
        Catch ex As Exception
            MessageBox.Show(String.Format("Error: {0}", ex.Message))
        End Try
    End Sub

    Function PmntID()
        Dim Val As String = 0
        Using cmd = New SqlCommand("select Payment_ID from GRNPayment where Payment_ID = (Select MAX(Payment_ID) from GRNPayment)", con)
            If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
            Using dr = cmd.ExecuteReader
                If dr.HasRows = False Then
                    Val = 0
                    TB_PmntID.Text = Val + 1
                ElseIf dr.Read Then
                    Val = dr.Item("Payment_ID")
                    TB_PmntID.Text = Val + 1
                End If
            End Using
        End Using
        Return Val + 1
    End Function

    Function SupID(ByVal SName1 As String, ByVal CName1 As String) As Long

        SupID = 0
        Try
            Using com As New SqlCommand("Select SID from Suppliers where SName = '" & SName1 & "' and CName ='" & CName1 & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                Using dr = com.ExecuteReader
                    If dr.Read Then
                        SupID = dr.Item("SID")
                    Else
                        SupID = 0
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return SupID

    End Function

    Private Sub Reefresh()
        TB_AmntPad.Text = ""
        TB_ChqPad.Text = ""
        TB_TBalance.Text = ""
        TB_RecName.Text = ""
        TB_ChqNo.Text = ""
        DTP_ChqDate.Text = Today
        TB_BnkNam.Text = ""
    End Sub

    Private Sub UD_Reefresh()
        UD_TB_AmntPad.Text = ""
        UD_TB_ChqPad.Text = ""
        UD_TB_TBalance.Text = ""
        UD_TB_RecName.Text = ""
        UD_TB_ChqNo.Text = ""
        UD_DTP_ChqDate.Text = Today
        UD_TB_BnkNam.Text = ""
    End Sub

    Private Sub D_Reefresh()
        D_TB_AmntPad.Text = ""
        D_TB_ChqPad.Text = ""
        D_TB_RCredit.Text = ""
        D_TB_RecName.Text = ""
        D_TB_ChqNo.Text = ""
        D_DTP_ChqDate.Text = Today
        D_TB_BnkNam.Text = ""
    End Sub

    Private Sub AmountCheck()
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        If caler.Name = "TB_AmntPad_Leave" Or caler.Name = "UD_TB_AmntPad_Leave" Then
            If AmntPad <> 0 Then
                If AmntPad > PCred Then
                    Mesg()
                    If caler.Name = "TB_AmntPad_Leave" Then
                        TB_AmntPad.Focus()
                        Return
                    Else
                        UD_TB_AmntPad.Focus()
                        Return
                    End If
                ElseIf ChqPad <> 0 Then
                    If AmntPad + ChqPad > PCred Then
                        Mesg()
                        If caler.Name = "TB_AmntPad_Leave" Then
                            TB_AmntPad.Focus()
                            Return
                        Else
                            UD_TB_AmntPad.Focus()
                            Return
                        End If
                    End If
                End If
            End If
        ElseIf caler.Name = "TB_ChqPad_Leave" Or caler.Name = "UD_TB_ChqPad_Leave" Then
            If ChqPad <> 0 Then
                If ChqPad > PCred Then
                    Mesg()
                    If caler.Name = "TB_ChqPad_Leave" Then
                        TB_ChqPad.Focus()
                        Return
                    Else
                        UD_TB_ChqPad.Focus()
                        Return
                    End If
                ElseIf AmntPad <> 0 Then
                    If AmntPad + ChqPad > PCred Then
                        Mesg()
                        If caler.Name = "TB_ChqPad_Leave" Then
                            TB_ChqPad.Focus()
                            Return
                        Else
                            UD_TB_ChqPad.Focus()
                            Return
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Mesg()
        MessageBox.Show("The Amount you have entered is exceeding" + Environment.NewLine + "then the ""Previous Credit"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub RB_Uncheck()
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        If caler.Name = "Btn_Clrall_Click" Or caler.Name = "DGV_Realize_CellClick" Then
            RB_Cash.Checked = False
            RB_CashNChq.Checked = False
            RB_CshNChqNCred.Checked = False
            RB_CashNCred.Checked = False
            RB_Cheque.Checked = False
            RB_ChqNCred.Checked = False
            RB_Click = False
            CStatus = ""
        ElseIf caler.Name = "UD_Btn_Clrall_Click" Or caler.Name = "UD_DGV_Realize_CellClick" Then
            UD_RB_Cash.Checked = False
            UD_RB_CashNChq.Checked = False
            UD_RB_CshNChqNCred.Checked = False
            UD_RB_CashNCred.Checked = False
            UD_RB_Cheque.Checked = False
            UD_RB_ChqNCred.Checked = False
            RB_Click = False
        ElseIf caler.Name = "D_Btn_Clrall_Click" Then
            D_RB_Cash.Checked = False
            D_RB_CashNChq.Checked = False
            D_RB_CshNChqNCred.Checked = False
            D_RB_CashNCred.Checked = False
            D_RB_Cheque.Checked = False
            D_RB_ChqNCred.Checked = False
        End If

    End Sub





End Class