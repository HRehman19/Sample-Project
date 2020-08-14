Imports System.Data.SqlClient
Imports System.IO

Public Class Sale

    Dim Assem As System.IO.FileInfo = New System.IO.FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location)
    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=CRMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Dim index As Integer = 0
    Dim RB_Click As Boolean = False
    Dim UD_RB_Click As Boolean = False
    Dim GRNTA, AmntPad, ChqPad, RCredit As Decimal
    Dim ChkBox, UD_ChkBox, D_ChkBox, ItmNo, Ietm, mitrs, Price, CName As String
    Dim PreviousRows As Integer
    Dim SuppID As Long
    Dim ID As Long
    Dim SplyrName, SplyrComp As String

    Dim SelectionChangeCommited As Boolean = False

    Private Sub GRN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Utype As String = Home.TSSL_RollType.Text
        If Utype = "User" Or Utype = "user" Then
            Tab_Control.TabPages.Remove(TP_Delete)
        End If
        Invoice_ID()
        PmntID()
        SupName()
    End Sub

    Private Sub Tab_Control_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Control.SelectedIndexChanged
        If Tab_Control.SelectedIndex = 0 Then
            Invoice_ID()
            PmntID()
            SupName()
        End If
    End Sub

    '"""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Addition Code Start ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Starts ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    'GRN TAB

    Private Sub CB_SName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_SName.SelectedIndexChanged
        CB_CName.SelectedItem = Nothing
        TB_TBalance.Text = ""
        TB_PrevBalance.Text = ""
    End Sub

    Private Sub CB_CName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CName.SelectedIndexChanged
        TB_TBalance.Text = ""
        TB_PrevBalance.Text = ""
    End Sub

    Private Sub CB_CName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_CName.Enter
        CompName()
    End Sub

    'GRN Items TAB
    Private Sub DGV_Items_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV_Items.CellClick
        Try
            index = e.RowIndex
            If e.ColumnIndex = 5 And e.RowIndex >= 0 Then
                If Me.DGV_Items.Rows(index).Cells(1).Value <> "" Then
                    DGV_Items.Rows.RemoveAt(DGV_Items.CurrentRow.Index)

                    Dim RSNo As Integer
                    For RSNo = 0 To DGV_Items.RowCount - 2
                        DGV_Items.Rows(RSNo).Cells(0).Value = RSNo + 1
                    Next

                End If
            ElseIf e.ColumnIndex = 4 And e.RowIndex >= 0 Then
                If Me.DGV_Items.Rows(index).Cells(1).Value <> "" Then
                    TB_ItmNam.Text = DGV_Items.Rows(index).Cells(1).Value
                    TB_Metrs.Text = DGV_Items.Rows(index).Cells(2).Value
                    TB_TAmount.Text = DGV_Items.Rows(index).Cells(3).Value
                    Btn_AItem.Text = "Update"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'GRN Payment TAB
    Private Sub TC_GRN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TC_GRN.SelectedIndexChanged
        Dim inde, rowc As Integer
        Dim val As Decimal
        rowc = DGV_Items.RowCount - 1
        If TC_GRN.SelectedIndex = 2 And rowc > 0 Then
            TB_GRNTA.Text = ""
            For inde = 0 To rowc
                val += DGV_Items.Rows(inde).Cells(3).Value
            Next
            TB_GRNTA.Text = val
        ElseIf TC_GRN.SelectedIndex = 0 Then
            Invoice_ID()
        End If
    End Sub

    Private Sub RB_Cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Cash.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_Cash.Text
        RB_Click = True
        Reefresh()
        If TB_GRNTA.Text.Trim() <> "" Then
            TB_AmntPad.Text = TB_GRNTA.Text.Trim()
            TB_ChqPad.Text = 0
            TB_InvCredit.Text = 0
        End If
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = False
        TB_ChqNo.ReadOnly = True
        DTP_ChqDate.Enabled = False
        TB_BnkNam.Enabled = False
        TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub RB_CashNChq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CashNChq.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_CashNChq.Text
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = True
        TB_AmntPad.ReadOnly = False
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_CshNChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CshNChqNCred.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_CshNChqNCred.Text
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = True
        TB_AmntPad.ReadOnly = False
        TB_ChqPad.Enabled = True
        TB_ChqPad.ReadOnly = False
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_CashNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_CashNCred.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_CashNCred.Text
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = True
        TB_AmntPad.ReadOnly = False
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = False
        TB_ChqNo.ReadOnly = True
        DTP_ChqDate.Enabled = False
        TB_BnkNam.Enabled = False
        TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub RB_Cheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Cheque.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_Cheque.Text
        RB_Click = True
        Reefresh()
        If TB_GRNTA.Text.Trim() <> "" Then
            TB_ChqPad.Text = CDec(TB_GRNTA.Text.Trim())
            TB_AmntPad.Text = 0
            TB_InvCredit.Text = 0
        End If
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_ChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_ChqNCred.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_ChqNCred.Text
        RB_Click = True
        Reefresh()
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = True
        TB_ChqPad.ReadOnly = False
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = True
        TB_ChqNo.ReadOnly = False
        DTP_ChqDate.Enabled = True
        TB_BnkNam.Enabled = True
        TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub RB_Credit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RB_Credit.CheckedChanged
        CStatus.Text = "Active"
        ChkBox = RB_Credit.Text
        RB_Click = True
        Reefresh()
        If TB_GRNTA.Text.Trim() <> "" Then
            TB_InvCredit.Text = CDec(TB_GRNTA.Text.Trim())
            TB_AmntPad.Text = 0
            TB_ChqPad.Text = 0
        End If
        TB_AmntPad.Enabled = False
        TB_AmntPad.ReadOnly = True
        TB_ChqPad.Enabled = False
        TB_ChqPad.ReadOnly = True
        TB_InvCredit.Enabled = False
        TB_InvCredit.ReadOnly = True
        TB_RecName.Enabled = True
        TB_RecName.ReadOnly = False
        TB_ChqNo.Enabled = False
        TB_ChqNo.ReadOnly = True
        DTP_ChqDate.Enabled = False
        TB_BnkNam.Enabled = False
        TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub TB_AmntPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_AmntPad.Leave
        If TB_GRNTA.Text = "" Then
            GRNTA = 0
        Else
            GRNTA = TB_GRNTA.Text.Trim()
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
        If TB_InvCredit.Text = "" Then
            RCredit = 0
        Else
            RCredit = TB_InvCredit.Text.Trim()
        End If

        If RB_CashNChq.Checked = True Then
            AmountCheck()
            ChqPad = GRNTA - AmntPad
            RCredit = 0
        ElseIf RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If AmntPad <= GRNTA And ChqPad <> 0 Then
                RCredit = (GRNTA - (AmntPad + ChqPad))
            Else
                RCredit = GRNTA - AmntPad
            End If
        ElseIf RB_CashNCred.Checked = True Then
            AmountCheck()
            ChqPad = 0
            RCredit = GRNTA - AmntPad
        End If

        TB_ChqPad.Text = ChqPad
        TB_InvCredit.Text = RCredit

    End Sub

    Private Sub TB_ChqPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_ChqPad.Leave
        If TB_GRNTA.Text = "" Then
            GRNTA = 0
        Else
            GRNTA = TB_GRNTA.Text.Trim()
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
        If TB_InvCredit.Text = "" Then
            RCredit = 0
        Else
            RCredit = TB_InvCredit.Text.Trim()
        End If

        If RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If ChqPad <= GRNTA And AmntPad <> 0 Then
                RCredit = (GRNTA - (AmntPad + ChqPad))
            Else
                RCredit = GRNTA - ChqPad
            End If
        ElseIf RB_ChqNCred.Checked = True Then
            AmountCheck()
            AmntPad = 0
            RCredit = GRNTA - ChqPad
        End If
        TB_AmntPad.Text = AmntPad
        TB_InvCredit.Text = RCredit

    End Sub

    Private Sub TB_PrevBalance_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_PrevBalance.Enter
        If CB_SName.SelectedItem = Nothing Or CB_CName.SelectedItem = Nothing Then
            MessageBox.Show("Please select Supplier/Company.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            SuppID = SupID(CB_SName.SelectedItem, CB_CName.SelectedItem)
            TB_PrevBalance.Text = PrevBlnc(SuppID)
        End If
    End Sub

    Private Sub TB_TCredit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_TBalance.Enter
        If TB_GRNTA.Text <> "" And TB_PrevBalance.Text <> "" Then
            Me.TB_TBalance.Text = CULng(TB_InvCredit.Text) + CULng(TB_PrevBalance.Text)
        End If
    End Sub

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Ends ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    '^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    '~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub Btn_Pic_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Pic_Browse.Click
        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()
        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}"
        ImageDialogue.Filter = "Image Files|*.gif; *.jpg; *.png; *.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
        End If
    End Sub

    Private Sub Btn_AItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AItem.Click
        If TB_ItmNam.Text.Trim() <> "" And TB_Metrs.Text.Trim() <> "" And TB_TAmount.Text.Trim() <> "" Then
            If Btn_AItem.Text = "Update" Then
                DGV_Items.Rows(index).Cells(1).Value = TB_ItmNam.Text.Trim()
                DGV_Items.Rows(index).Cells(2).Value = TB_Metrs.Text.Trim()
                DGV_Items.Rows(index).Cells(3).Value = TB_TAmount.Text.Trim()
                Btn_AItem.Text = "Add"
            Else
                Dim rz As Integer = DGV_Items.RowCount - 1
                Dim SNum As Integer
                If rz = 0 Then
                    SNum = 1
                Else
                    SNum = rz + 1
                End If
                DGV_Items.Rows.Add(SNum, TB_ItmNam.Text.Trim(), TB_Metrs.Text.Trim(), TB_TAmount.Text.Trim())
                DGV_Items_Edit.Text = "Edit"
                DGV_Items_Edit.UseColumnTextForButtonValue = True
                DGV_Items_Del.Text = "Delete"
                DGV_Items_Del.UseColumnTextForButtonValue = True
            End If
            TB_ItmNam.Text = ""
            TB_Metrs.Text = ""
            TB_TAmount.Text = ""
            index = 0
        End If
        TB_ItmNam.Focus()
    End Sub

    Private Sub Btn_Clrall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clrall.Click
        'GRN TAB
        Invoice_ID()
        PmntID()
        SupName()
        CB_CName.SelectedItem = Nothing
        CB_CName.Items.Clear()
        TB_IN.Text = ""
        DTP_Inv_Date.Text = Today()
        PictureBox.Image = My.Resources.Receipt
        'Items TAB
        TB_ItmNam.Text = ""
        TB_Metrs.Text = ""
        TB_TAmount.Text = ""
        Btn_AItem.Text = "Add"
        DGV_Items.Rows.Clear()
        'GRN Payment TAB
        RB_Click = False
        RB_False()
        Reefresh()
        TB_GRNTA.Text = ""
        TB_AmntPad.Text = ""
        TB_ChqPad.Text = ""
        TB_InvCredit.Text = ""
        TB_RecName.Text = ""
        TB_ChqNo.Text = ""
        DTP_ChqDate.Text = Today()
        TB_BnkNam.Text = ""
        DTP_PDD.Text = Today()
        TB_PrevBalance.Text = ""
        TB_TBalance.Text = ""
    End Sub

    Private Sub Btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Submit.Click
        Try
            If CB_SName.SelectedItem = Nothing Then
                MessageBox.Show("Please select ""Supplier Name"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf CB_CName.SelectedItem = Nothing Then
                MessageBox.Show("Please select ""Company Name"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf TB_IN.Text.Trim() = "" Then
                MessageBox.Show("Please write down ""Invoice Number"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf DTP_Inv_Date.Text > Today Then
                MessageBox.Show("""Invoice Date"" can be from the dates" + Environment.NewLine + "before or today's date.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf DGV_Items.RowCount - 1 = 0 Then
                MessageBox.Show("There are no Items in the ""Items Table"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf RB_Click = False Then
                MessageBox.Show("Please select Invoice ""Payment Method"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf TB_PrevBalance.Text = "" Then
                MessageBox.Show("Please click on Previous Balance textbox to load its value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf TB_TBalance.Text = "" Then
                MessageBox.Show("Please click on Total Credit textbox to load its value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Try

                    SuppID = SupID(CB_SName.SelectedItem, CB_CName.SelectedItem)

                    Using cmd = New SqlCommand("Select * from GRN where SID = '" & SuppID & "' and Invoice_No= '" & TB_IN.Text.Trim() & "' and Invoice_Date = '" & DTP_Inv_Date.Text & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Using dr = cmd.ExecuteReader()
                            If dr.Read() Then
                                MessageBox.Show("This Invoice already exist.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Return
                            End If
                        End Using
                    End Using

                    Using cmd As New SqlCommand

                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        Try
                            cmd.CommandText = "Update GRNPayment set Credit_Status = 'Idle' where Invoice_ID = (Select GRN.Invoice_ID FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE GRN.SID = '" & SuppID & "' AND GRNPayment.Credit_Status = '" & CStatus.Text & "')"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Insert into GRN (Invoice_ID, SID, Invoice_No, Invoice_Date, Recieving_Date, Picture) VALUES ('" & TB_GRN.Text.Trim() & "', '" & SuppID & "', '" & TB_IN.Text.Trim() & "', '" & DTP_Inv_Date.Text & "', '" & DTP_RecDate.Text & "', @Picture)"

                            Dim ms As New MemoryStream()

                            PictureBox.Image.Save(ms, PictureBox.Image.RawFormat)
                            Dim data As Byte() = ms.GetBuffer()
                            Dim p As New SqlParameter("@Picture", SqlDbType.Image)
                            p.Value = data
                            cmd.Parameters.Add(p)

                            cmd.ExecuteNonQuery()

                            Dim x, rowz As Integer

                            rowz = DGV_Items.RowCount - 2

                            For x = 0 To rowz
                                Dim SrNo As String = DGV_Items.Rows(x).Cells(0).Value.ToString()
                                Dim Itm As String = DGV_Items.Rows(x).Cells(1).Value.ToString()
                                Dim Metrs As String = DGV_Items.Rows(x).Cells(2).Value.ToString()
                                Dim ItmTAmnt As String = DGV_Items.Rows(x).Cells(3).Value.ToString()

                                cmd.CommandText = "Insert into GRNItems (Invoice_ID, Item_No, Item, Meters, ItemTAmount, Return_Status) VALUES ('" & TB_GRN.Text.Trim() & "', '" & SrNo & "', '" & Itm & "', '" & Metrs & "', '" & ItmTAmnt & "', '" & LBl_Return_Status.Text & "')"
                                cmd.ExecuteNonQuery()
                            Next

                            cmd.CommandText = "Insert into GRNPayment (Payment_ID, Invoice_ID, GRNTAmount, Payment_Method, CashPaid, ChequePaid, Invoice_Credit, Receivers_Name, ChequeNo, ChequeDate, BankName, PaymentDeliveryDate, TotalBalance, Credit_Status) VALUES ('" & TB_PID.Text.Trim() & "', '" & TB_GRN.Text.Trim() & "', '" & TB_GRNTA.Text.Trim() & "', '" & ChkBox & "', '" & TB_AmntPad.Text.Trim() & "', '" & TB_ChqPad.Text.Trim() & "', '" & TB_InvCredit.Text.Trim() & "', '" & TB_RecName.Text.Trim() & "', '" & TB_ChqNo.Text.Trim() & "', '" & DTP_ChqDate.Text.Trim() & "', '" & TB_BnkNam.Text.Trim() & "', '" & DTP_PDD.Text.Trim() & "', '" & TB_TBalance.Text.Trim() & "', '" & CStatus.Text & "')"
                            cmd.ExecuteNonQuery()

                            transaction.Commit()
                            MessageBox.Show("""Invoice"" has been saved Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    '##########################################################'
    ''~~~~~~~~~~~~~~ Updation Header Code Starts ~~~~~~~~~~~~~~'
    '__________________________________________________________'

    Private Sub TB_UD_Load_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If ((Microsoft.VisualBasic.Asc(e.KeyChar) > 64) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 91) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 96) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 123) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 31) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 127) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 127) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) <= 255)) Then
            e.Handled = True
        ElseIf (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Then
            Btn_UD_Load_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_UD_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UD_Load.Click
        If (TB_UD_Load.Text.Trim() = "") Then
            MessageBox.Show("Please Enter ""Invoice ID"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_UD_Load.Focus()
        ElseIf UD_TB_GRN.Text.Trim() = TB_UD_Load.Text.Trim() Then
            MsgBox("This GRN has already been loaded.")
        Else

            cmd = New SqlCommand("Select * from GRN where Invoice_ID='" & TB_UD_Load.Text.Trim() & "'", con)
            If con.State = ConnectionState.Closed Then con.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                dr.Close()
                Dim RStas As String = "Returned"

                Try

                    Dim SplyerID As Long = SIDByGRN(TB_UD_Load.Text.Trim())
                    Using cmd = New SqlCommand("select Invoice_ID from GRN where Invoice_ID > '" & TB_UD_Load.Text.Trim() & "' and SID = '" & SplyerID & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Dim count As Integer = 0
                        Using dr = cmd.ExecuteReader()
                            If dr.Read() Then
                                MessageBox.Show("You can't update this Invoice. Because newer" + Environment.NewLine + "Invoices are depended on this one.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End Using
                    End Using
                    Using cmd = New SqlCommand("select * from GRNItems where Invoice_ID = '" & TB_UD_Load.Text.Trim() & "' and Return_Status = '" & RStas & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Dim count As Integer = 0
                        Using dr = cmd.ExecuteReader()
                            If dr.Read() Then
                                MessageBox.Show("All/Some of the items in this ""Invoice"" has been" + Environment.NewLine + "returned. Thus you can't Update this ""Invoice"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End Using
                    End Using
                    Using cmd = New SqlCommand("select Invoice_ID from GRNPayment where Invoice_ID = '" & TB_UD_Load.Text.Trim() & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Dim count As Integer = 0
                        Using dr = cmd.ExecuteReader()
                            While dr.Read()
                                count += 1
                            End While
                        End Using
                        If count > 1 Then
                            MessageBox.Show("This ""Invoice"" has more than one payment methods" + Environment.NewLine + "Thus you can't Update this ""Invoice"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        UD_DGV_Items.Rows.Clear()
                        Try
                            cmd.CommandText = "Select * from GRN where Invoice_ID = '" & TB_UD_Load.Text.Trim() & "'"
                            Using dr = cmd.ExecuteReader()
                                If dr.Read() Then
                                    UD_TB_GRN.Text = dr.Item("Invoice_ID")
                                    ID = dr.Item("SID")
                                    UD_TB_IN.Text = dr.Item("Invoice_No")
                                    UD_DTP_Inv_Date.Text = dr.Item("Invoice_Date")
                                    UD_DTP_RecDate.Text = dr.Item("Recieving_Date")
                                    Dim data As Byte() = DirectCast(dr("Picture"), Byte())
                                    Dim ms As New MemoryStream(data)
                                    UD_PictureBox.Image = Image.FromStream(ms)
                                End If
                            End Using

                            cmd.CommandText = "Select * from GRNItems where Invoice_ID = '" & TB_UD_Load.Text.Trim() & "'"
                            Using dr = cmd.ExecuteReader()
                                While dr.Read
                                    ItmNo = dr("Item_No")
                                    Ietm = dr("Item")
                                    mitrs = dr("Meters")
                                    Price = dr("ItemTAmount")
                                    Dim row As String()
                                    row = New String() {ItmNo, Ietm, mitrs, Price}
                                    UD_DGV_Items.Rows.Add(row)
                                    UD_DGV_Items_Edit.Text = "Edit"
                                    UD_DGV_Items_Edit.UseColumnTextForButtonValue = True
                                    UD_DGV_Items_Del.Text = "Delete"
                                    UD_DGV_Items_Del.UseColumnTextForButtonValue = True
                                End While
                                PreviousRows = UD_DGV_Items.RowCount - 1
                            End Using
                            cmd.CommandText = "Select * from GRNPayment where Invoice_ID = '" & TB_UD_Load.Text.Trim() & "'"
                            Using dr = cmd.ExecuteReader()
                                If dr.Read() Then
                                    UD_ChkBox = dr.Item("Payment_Method")
                                    If UD_ChkBox = UD_RB_Cash.Text Then
                                        UD_RB_Cash.Checked = True
                                    ElseIf UD_ChkBox = UD_RB_CashNChq.Text Then
                                        UD_RB_CashNChq.Checked = True
                                    ElseIf UD_ChkBox = UD_RB_CshNChqNCred.Text Then
                                        UD_RB_CshNChqNCred.Checked = True
                                    ElseIf UD_ChkBox = UD_RB_CashNCred.Text Then
                                        UD_RB_CashNCred.Checked = True
                                    ElseIf UD_ChkBox = UD_RB_Cheque.Text Then
                                        UD_RB_Cheque.Checked = True
                                    ElseIf UD_ChkBox = UD_RB_ChqNCred.Text Then
                                        UD_RB_ChqNCred.Checked = True
                                    ElseIf UD_ChkBox = UD_RB_Credit.Text Then
                                        UD_RB_Credit.Checked = True
                                    End If
                                    UD_TB_PID.Text = dr.Item("Payment_ID")
                                    UD_TB_GRNTA.Text = dr.Item("GRNTAmount")
                                    UD_TB_AmntPad.Text = dr.Item("CashPaid")
                                    UD_TB_ChqPad.Text = dr.Item("ChequePaid")
                                    UD_TB_InvCredit.Text = dr.Item("Invoice_Credit")
                                    UD_TB_RecName.Text = dr.Item("Receivers_Name")
                                    UD_TB_ChqNo.Text = dr.Item("ChequeNo")
                                    UD_DTP_ChqDate.Text = dr.Item("ChequeDate")
                                    UD_TB_BnkNam.Text = dr.Item("BankName")
                                    UD_DTP_PDD.Text = dr.Item("PaymentDeliveryDate")
                                End If
                            End Using
                            transaction.Commit()
                            With SNameCNameBySID(ID)
                                SplyrName = .Item1
                                SplyrComp = .Item2
                            End With
                            UD_CB_SName.SelectedItem = SplyrName
                            CompName()
                            UD_CB_CName.SelectedItem = SplyrComp
                            UD_TB_PrevBalance_Enter(sender, e)
                            UD_TB_TCredit_Enter(sender, e)
                            MessageBox.Show("""Invoice"" has been loaded Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Else
                dr.Close()
                MessageBox.Show("No Such ""Invoice"" Exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        End If

    End Sub

    '########################################################'
    ''~~~~~~~~~~~~~~ Updation Header Code Ends ~~~~~~~~~~~~~~'
    '________________________________________________________'

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Starts ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    'GRN TAB

    Private Sub UD_CB_SName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_CB_SName.SelectedIndexChanged
        UD_CB_CName.SelectedItem = Nothing
        UD_TB_TBalance.Text = ""
        UD_TB_PrevBalance.Text = ""
    End Sub

    Private Sub UD_CB_CName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_CB_CName.SelectedIndexChanged
        UD_TB_TBalance.Text = ""
        UD_TB_PrevBalance.Text = ""
    End Sub

    Private Sub UD_CB_CName_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_CB_CName.Enter
        CompName()
    End Sub

    Private Sub UD_CB_SName_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_CB_SName.SelectionChangeCommitted
        UD_CB_CName_SelectionChangeCommitted(sender, e)
    End Sub

    Private Sub UD_CB_CName_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_CB_CName.SelectionChangeCommitted
        SelectionChangeCommited = True
    End Sub

    'GRN Items TAB
    Private Sub UD_DGV_Items_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UD_DGV_Items.CellClick
        Try
            index = e.RowIndex
            If e.ColumnIndex = 5 And e.RowIndex >= 0 Then
                If Me.UD_DGV_Items.Rows(index).Cells(1).Value <> "" Then
                    UD_DGV_Items.Rows.RemoveAt(UD_DGV_Items.CurrentRow.Index)

                    Dim RSNo As Integer
                    For RSNo = 0 To UD_DGV_Items.RowCount - 2
                        UD_DGV_Items.Rows(RSNo).Cells(0).Value = RSNo + 1
                    Next

                End If
            ElseIf e.ColumnIndex = 4 And e.RowIndex >= 0 Then
                If Me.UD_DGV_Items.Rows(index).Cells(1).Value <> "" Then
                    UD_TB_ItmNam.Text = UD_DGV_Items.Rows(index).Cells(1).Value
                    UD_TB_Metrs.Text = UD_DGV_Items.Rows(index).Cells(2).Value
                    UD_TB_TAmount.Text = UD_DGV_Items.Rows(index).Cells(3).Value
                    UD_Btn_AItem.Text = "Update"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'GRN Payment TAB
    Private Sub UD_TC_GRN_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TC_GRN.SelectedIndexChanged
        Dim inde, rowc As Integer
        Dim val As Decimal
        rowc = UD_DGV_Items.RowCount - 1
        If UD_TC_GRN.SelectedIndex = 2 And rowc > 0 Then
            UD_TB_GRNTA.Text = ""
            For inde = 0 To rowc
                val += UD_DGV_Items.Rows(inde).Cells(3).Value
            Next
            UD_TB_GRNTA.Text = val
            UD_DTP_PDD.Text = UD_DTP_Inv_Date.Text
        End If
    End Sub

    Private Sub UD_RB_Cash_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_Cash.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_Cash.Text
        UD_RB_Click = True
        UD_Reefresh()
        If UD_TB_GRNTA.Text.Trim() <> "" Then
            UD_TB_AmntPad.Text = UD_TB_GRNTA.Text.Trim()
            UD_TB_ChqPad.Text = 0
            UD_TB_InvCredit.Text = 0
        End If
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = False
        UD_TB_ChqNo.ReadOnly = True
        UD_DTP_ChqDate.Enabled = False
        UD_TB_BnkNam.Enabled = False
        UD_TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub UD_RB_CashNChq_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_CashNChq.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_CashNChq.Text
        UD_RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = True
        UD_TB_AmntPad.ReadOnly = False
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_CshNChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_CshNChqNCred.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_CshNChqNCred.Text
        UD_RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = True
        UD_TB_AmntPad.ReadOnly = False
        UD_TB_ChqPad.Enabled = True
        UD_TB_ChqPad.ReadOnly = False
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_CashNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_CashNCred.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_CashNCred.Text
        UD_RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = True
        UD_TB_AmntPad.ReadOnly = False
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = False
        UD_TB_ChqNo.ReadOnly = True
        UD_DTP_ChqDate.Enabled = False
        UD_TB_BnkNam.Enabled = False
        UD_TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub UD_RB_Cheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_Cheque.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_Cheque.Text
        UD_RB_Click = True
        UD_Reefresh()
        If UD_TB_GRNTA.Text.Trim() <> "" Then
            UD_TB_ChqPad.Text = UD_TB_GRNTA.Text.Trim()
            UD_TB_AmntPad.Text = 0
            UD_TB_InvCredit.Text = 0
        End If
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_ChqNCred_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_ChqNCred.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_ChqNCred.Text
        UD_RB_Click = True
        UD_Reefresh()
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = True
        UD_TB_ChqPad.ReadOnly = False
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = True
        UD_TB_ChqNo.ReadOnly = False
        UD_DTP_ChqDate.Enabled = True
        UD_TB_BnkNam.Enabled = True
        UD_TB_BnkNam.ReadOnly = False
    End Sub

    Private Sub UD_RB_Credit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_RB_Credit.CheckedChanged
        UD_Credit_Status.Text = "Active"
        UD_ChkBox = UD_RB_Credit.Text
        UD_RB_Click = True
        UD_Reefresh()
        If UD_TB_GRNTA.Text.Trim() <> "" Then
            UD_TB_InvCredit.Text = UD_TB_GRNTA.Text.Trim()
            UD_TB_AmntPad.Text = 0
            UD_TB_ChqPad.Text = 0
        End If
        UD_TB_AmntPad.Enabled = False
        UD_TB_AmntPad.ReadOnly = True
        UD_TB_ChqPad.Enabled = False
        UD_TB_ChqPad.ReadOnly = True
        UD_TB_InvCredit.Enabled = False
        UD_TB_InvCredit.ReadOnly = True
        UD_TB_RecName.Enabled = True
        UD_TB_RecName.ReadOnly = False
        UD_TB_ChqNo.Enabled = False
        UD_TB_ChqNo.ReadOnly = True
        UD_DTP_ChqDate.Enabled = False
        UD_TB_BnkNam.Enabled = False
        UD_TB_BnkNam.ReadOnly = True
    End Sub

    Private Sub UD_TB_AmntPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_AmntPad.Leave
        If UD_TB_GRNTA.Text = "" Then
            GRNTA = 0
        Else
            GRNTA = UD_TB_GRNTA.Text.Trim()
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
        If UD_TB_InvCredit.Text = "" Then
            RCredit = 0
        Else
            RCredit = UD_TB_InvCredit.Text.Trim()
        End If

        If UD_RB_CashNChq.Checked = True Then
            AmountCheck()
            ChqPad = GRNTA - AmntPad
            RCredit = 0
        ElseIf UD_RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If AmntPad <= GRNTA And ChqPad <> 0 Then
                RCredit = (GRNTA - (AmntPad + ChqPad))
            Else
                RCredit = GRNTA - AmntPad
            End If
        ElseIf UD_RB_CashNCred.Checked = True Then
            AmountCheck()
            ChqPad = 0
            RCredit = GRNTA - AmntPad
        End If

        UD_TB_ChqPad.Text = ChqPad
        UD_TB_InvCredit.Text = RCredit

    End Sub

    Private Sub UD_TB_ChqPad_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_ChqPad.Leave
        If UD_TB_GRNTA.Text = "" Then
            GRNTA = 0
        Else
            GRNTA = UD_TB_GRNTA.Text.Trim()
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
        If UD_TB_InvCredit.Text = "" Then
            RCredit = 0
        Else
            RCredit = UD_TB_InvCredit.Text.Trim()
        End If

        If UD_RB_CshNChqNCred.Checked = True Then
            AmountCheck()
            If ChqPad <= GRNTA And AmntPad <> 0 Then
                RCredit = (GRNTA - (AmntPad + ChqPad))
            Else
                RCredit = GRNTA - ChqPad
            End If
        ElseIf UD_RB_ChqNCred.Checked = True Then
            AmountCheck()
            AmntPad = 0
            RCredit = GRNTA - ChqPad
        End If
        UD_TB_AmntPad.Text = AmntPad
        UD_TB_InvCredit.Text = RCredit

    End Sub

    Private Sub UD_TB_PrevBalance_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_PrevBalance.Enter

        If UD_CB_SName.SelectedItem = Nothing Or UD_CB_CName.SelectedItem = Nothing Then
            MessageBox.Show("Please select Supplier/Company.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            SuppID = SupID(UD_CB_SName.SelectedItem, UD_CB_CName.SelectedItem)
            UD_TB_PrevBalance.Text = PrevBlnc(SuppID)
        End If

    End Sub

    Private Sub UD_TB_TCredit_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_TB_TBalance.Enter
        If UD_TB_GRNTA.Text <> "" And UD_TB_PrevBalance.Text <> "" Then
            Me.UD_TB_TBalance.Text = CULng(UD_TB_InvCredit.Text) + CULng(UD_TB_PrevBalance.Text)
        End If
    End Sub

    '!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!'
    '~~~~~~~~~~~~~~~~~ Logics Code Ends ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    ''~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    ''______________________________________________________'

    Private Sub UD_Btn_Pic_Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_Btn_Pic_Browse.Click
        Dim ImageDialogue As OpenFileDialog = New OpenFileDialog()
        ImageDialogue.Title = "Select your Image."
        ImageDialogue.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}"
        ImageDialogue.Filter = "Image Files|*.gif; *.jpg; *.png; *.bmp;"
        ImageDialogue.RestoreDirectory = False

        If ImageDialogue.ShowDialog() = DialogResult.OK Then
            UD_PictureBox.Image = Image.FromFile(ImageDialogue.FileName)
        End If
    End Sub

    Private Sub UD_Btn_AItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_Btn_AItem.Click
        If UD_TB_ItmNam.Text.Trim() = "" Then
            MessageBox.Show("Please fill the ""Item"" Textbox.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf UD_TB_Metrs.Text.Trim() = "" Then
            MessageBox.Show("Please fill the ""Meters"" Textbox.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf UD_TB_TAmount.Text.Trim() = "" Then
            MessageBox.Show("Please fill the ""Total Amount"" Textbox.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If UD_Btn_AItem.Text = "Update" Then
                UD_DGV_Items.Rows(index).Cells(1).Value = UD_TB_ItmNam.Text.Trim()
                UD_DGV_Items.Rows(index).Cells(2).Value = UD_TB_Metrs.Text.Trim()
                UD_DGV_Items.Rows(index).Cells(3).Value = UD_TB_TAmount.Text.Trim()
                UD_Btn_AItem.Text = "Add"
            Else
                Dim rz As Integer = UD_DGV_Items.RowCount - 1
                Dim INum As Integer
                If rz = 0 Then
                    INum = 1
                Else
                    INum = rz + 1
                End If
                UD_DGV_Items.Rows.Add(INum, UD_TB_ItmNam.Text.Trim(), UD_TB_Metrs.Text.Trim(), UD_TB_TAmount.Text.Trim())
                UD_DGV_Items_Edit.Text = "Edit"
                UD_DGV_Items_Edit.UseColumnTextForButtonValue = True
                UD_DGV_Items_Del.Text = "Delete"
                UD_DGV_Items_Del.UseColumnTextForButtonValue = True
            End If
            UD_TB_ItmNam.Text = ""
            UD_TB_Metrs.Text = ""
            UD_TB_TAmount.Text = ""
            index = 0
        End If
        UD_TB_ItmNam.Focus()
    End Sub

    Private Sub UD_Btn_Clrall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UD_Btn_Clrall.Click
        'GRN TAB
        UD_TB_GRN.Text = ""
        UD_CB_CName.SelectedItem = Nothing
        UD_CB_CName.Items.Clear()
        SupName()
        UD_TB_IN.Text = ""
        UD_DTP_Inv_Date.Text = Today()
        UD_DTP_RecDate.Text = Today()
        UD_PictureBox.Image = My.Resources.Receipt
        'Items TAB
        UD_TB_ItmNam.Text = ""
        UD_TB_Metrs.Text = ""
        UD_TB_TAmount.Text = ""
        UD_Btn_AItem.Text = "Add"
        UD_DGV_Items.Rows.Clear()
        'GRN Payment TAB
        UD_TB_PID.Text = ""
        UD_RB_Click = False
        RB_False()
        UD_Reefresh()
        UD_TB_GRNTA.Text = ""
        UD_TB_AmntPad.Text = ""
        UD_TB_ChqPad.Text = ""
        UD_TB_InvCredit.Text = ""
        UD_TB_RecName.Text = ""
        UD_TB_ChqNo.Text = ""
        UD_DTP_ChqDate.Text = Today()
        UD_TB_BnkNam.Text = ""
        UD_DTP_PDD.Text = Today()
        UD_TB_PrevBalance.Text = ""
        UD_TB_TBalance.Text = ""
    End Sub

    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        Try
            If UD_CB_SName.SelectedItem = Nothing Then
                MessageBox.Show("Please select ""Supplier Name"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_CB_CName.SelectedItem = Nothing Then
                MessageBox.Show("Please select ""Company Name"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_TB_IN.Text.Trim() = "" Then
                MessageBox.Show("Please write down ""Invoice Number"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_DTP_Inv_Date.Text > Today Then
                MessageBox.Show("""Invoice Date"" can be from the dates" + Environment.NewLine + "before or today's date.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_DGV_Items.RowCount - 1 = 0 Then
                MessageBox.Show("There are no Items in the ""Items Table"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_RB_Click = False Then
                MessageBox.Show("Please select Invoice ""Payment Method"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_TB_PrevBalance.Text = "" Then
                MessageBox.Show("Please click on Previous Balance textbox to load its value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ElseIf UD_TB_TBalance.Text = "" Then
                MessageBox.Show("Please click on Total Credit textbox to load its value.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                SuppID = SupID(UD_CB_SName.SelectedItem, UD_CB_CName.SelectedItem)

                Try
                    Dim GRNID As String = 0
                    cmd = New SqlCommand("SELECT MAX(Invoice_ID) As Invoice_ID FROM GRN WHERE SID = '" & SuppID & "'", con)
                    con.Open()
                    dr = cmd.ExecuteReader
                    If dr.Read() Then GRNID = dr.Item("Invoice_ID")
                    con.Close()
                    If GRNID > UD_TB_GRN.Text Then
                        MessageBox.Show("This Update is prohibited because there is/are new Invoice/s available.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        Exit Sub
                    End If

                Catch ex As Exception
                    MessageBox.Show(String.Format("Error: {0}", ex.Message))
                End Try

                Try
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        Try

                            If SelectionChangeCommited = True Then
                                cmd.CommandText = "UPDATE GRNPayment SET Credit_Status = 'Active' " _
                                        & "WHERE Payment_ID = (SELECT MAX(GRNPayment.Payment_ID) - 1 FROM " _
                                        & "GRN INNER JOIN GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE " _
                                        & "GRN.SID = (SELECT GRN.SID FROM GRN INNER JOIN GRNPayment ON GRN.Invoice_ID " _
                                        & "= GRNPayment.Invoice_ID WHERE(GRNPayment.Payment_ID = '" & UD_TB_PID.Text.Trim() & "')))"
                                cmd.ExecuteNonQuery()
                            End If

                            If SelectionChangeCommited = True Then
                                cmd.CommandText = "Update GRNPayment set Credit_Status = 'Idle' " _
                                    & "where Invoice_ID = (Select GRN.Invoice_ID FROM GRN INNER JOIN " _
                                    & "GRNPayment ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE GRN.SID " _
                                    & "= '" & SuppID & "' AND GRNPayment.Credit_Status = " _
                                    & "'" & CStatus.Text & "')"
                                cmd.ExecuteNonQuery()
                            End If

                            cmd.CommandText = "Update GRN set SID = '" & SuppID & "',Invoice_No = '" & UD_TB_IN.Text.Trim() & "', Invoice_Date = '" & UD_DTP_Inv_Date.Text & "', Recieving_Date = '" & UD_DTP_RecDate.Text & "', Picture = @Picture  where Invoice_ID = '" & UD_TB_GRN.Text.Trim() & "'"
                            Dim ms As New MemoryStream()
                            UD_PictureBox.Image.Save(ms, UD_PictureBox.Image.RawFormat)
                            Dim data As Byte() = ms.GetBuffer()
                            Dim p As New SqlParameter("@Picture", SqlDbType.Image)
                            p.Value = data
                            cmd.Parameters.Add(p)
                            cmd.ExecuteNonQuery()
                            Dim CurrentRows As Integer = UD_DGV_Items.RowCount - 1
                            Dim y As Integer
                            'If Items Removed
                            If CurrentRows < PreviousRows Then
                                For y = 0 To UD_DGV_Items.RowCount - 2
                                    Dim INo As String = UD_DGV_Items.Rows(y).Cells(0).Value.ToString()
                                    Dim Itm As String = UD_DGV_Items.Rows(y).Cells(1).Value.ToString()
                                    Dim Metrs As String = UD_DGV_Items.Rows(y).Cells(2).Value.ToString()
                                    Dim ItmTAmnt As String = UD_DGV_Items.Rows(y).Cells(3).Value.ToString()
                                    cmd.CommandText = "UPDATE GRNItems SET Item = '" & Itm & "', Meters = '" & Metrs & "', ItemTAmount = '" & ItmTAmnt & "' WHERE (Invoice_ID = '" & UD_TB_GRN.Text.Trim() & "') AND (Item_No = '" & INo & "')"
                                    cmd.ExecuteNonQuery()
                                Next
                                cmd.CommandText = "Delete from GRNItems where (Invoice_ID = '" & UD_TB_GRN.Text.Trim() & "') And (Item_No > '" & CurrentRows & "')"
                                cmd.ExecuteNonQuery()
                            End If
                            'If Items Nither Removed or Added
                            If CurrentRows = PreviousRows Then
                                For y = 0 To PreviousRows - 1
                                    Dim INo As String = UD_DGV_Items.Rows(y).Cells(0).Value.ToString()
                                    Dim Itm As String = UD_DGV_Items.Rows(y).Cells(1).Value.ToString()
                                    Dim Metrs As String = UD_DGV_Items.Rows(y).Cells(2).Value.ToString()
                                    Dim ItmTAmnt As String = UD_DGV_Items.Rows(y).Cells(3).Value.ToString()
                                    cmd.CommandText = "UPDATE GRNItems SET Item = '" & Itm & "', Meters = '" & Metrs & "', ItemTAmount = '" & ItmTAmnt & "' WHERE (Invoice_ID = '" & UD_TB_GRN.Text.Trim() & "') AND (Item_No = '" & INo & "')"
                                    cmd.ExecuteNonQuery()
                                Next
                            End If
                            'If Items Added
                            If CurrentRows > PreviousRows Then
                                'Update
                                For y = 0 To PreviousRows - 1
                                    Dim INo As String = UD_DGV_Items.Rows(y).Cells(0).Value.ToString()
                                    Dim Itm As String = UD_DGV_Items.Rows(y).Cells(1).Value.ToString()
                                    Dim Metrs As String = UD_DGV_Items.Rows(y).Cells(2).Value.ToString()
                                    Dim ItmTAmnt As String = UD_DGV_Items.Rows(y).Cells(3).Value.ToString()
                                    cmd.CommandText = "UPDATE GRNItems SET Item = '" & Itm & "', Meters = '" & Metrs & "', ItemTAmount = '" & ItmTAmnt & "' WHERE (Invoice_ID = '" & UD_TB_GRN.Text.Trim() & "') AND (Item_No = '" & INo & "')"
                                    cmd.ExecuteNonQuery()
                                Next
                                'DGV Rows Delete
                                Dim ydel As Integer = 0
                                Do
                                    UD_DGV_Items.Rows.RemoveAt(0)
                                    ydel += 1
                                Loop While ydel < PreviousRows
                                'Insert
                                For y = 0 To UD_DGV_Items.RowCount - 2
                                    Dim INo As String = UD_DGV_Items.Rows(y).Cells(0).Value.ToString()
                                    Dim Itm As String = UD_DGV_Items.Rows(y).Cells(1).Value.ToString()
                                    Dim Metrs As String = UD_DGV_Items.Rows(y).Cells(2).Value.ToString()
                                    Dim ItmTAmnt As String = UD_DGV_Items.Rows(y).Cells(3).Value.ToString()
                                    cmd.CommandText = "Insert into GRNItems (Invoice_ID, Item_No, Item, Meters, ItemTAmount, Return_Status) VALUES ('" & UD_TB_GRN.Text.Trim() & "', '" & INo & "', '" & Itm & "', '" & Metrs & "', '" & ItmTAmnt & "', '" & UD_LBl_Return_Status.Text & "')"
                                    cmd.ExecuteNonQuery()
                                Next
                            End If

                            cmd.CommandText = "Update GRNPayment set GRNTAmount = '" & UD_TB_GRNTA.Text.Trim() & "', Payment_Method = '" & UD_ChkBox & "', CashPaid = '" & UD_TB_AmntPad.Text.Trim() & "', ChequePaid = '" & UD_TB_ChqPad.Text.Trim() & "', Invoice_Credit = '" & UD_TB_InvCredit.Text.Trim() & "', Receivers_Name = '" & UD_TB_RecName.Text.Trim() & "', ChequeNo = '" & UD_TB_ChqNo.Text.Trim() & "', ChequeDate = '" & UD_DTP_ChqDate.Text.Trim() & "', BankName = '" & UD_TB_BnkNam.Text.Trim() & "', PaymentDeliveryDate = '" & UD_DTP_PDD.Text.Trim() & "', TotalBalance = '" & UD_TB_TBalance.Text.Trim() & "' where Invoice_ID = '" & UD_TB_GRN.Text.Trim() & "' and Payment_ID = '" & UD_TB_PID.Text.Trim() & "'"
                            cmd.ExecuteNonQuery()
                            transaction.Commit()
                            MessageBox.Show("""Invoice"" has been Upgraded Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    ''~~~~~~~~~~~~~~~~~ Buttons Code End ~~~~~~~~~~~~~~~~~'
    ''____________________________________________________'

    ''"""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Updation Code End ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    ''""""""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Deletion Code Starts ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '##########################################################'
    ''~~~~~~~~~~~~~~ Deletion Header Code Starts ~~~~~~~~~~~~~~'
    '__________________________________________________________'

    Private Sub TB_D_Load_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_D_Load.KeyPress
        If ((Microsoft.VisualBasic.Asc(e.KeyChar) > 64) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 91) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 96) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 123) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 31) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 48) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 57) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 65) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 90) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 97) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 122) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) < 127) Or _
            (Microsoft.VisualBasic.Asc(e.KeyChar) > 127) And _
            (Microsoft.VisualBasic.Asc(e.KeyChar) <= 255)) Then
            e.Handled = True
        ElseIf (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Then
            Btn_D_Load_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_D_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_D_Load.Click
        If (TB_D_Load.Text.Trim() = "") Then
            MessageBox.Show("Please Enter ""Invoice ID"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_D_Load.Focus()
        ElseIf D_TB_GRN.Text.Trim() = TB_D_Load.Text.Trim() Then
            MsgBox("This Invoice has already been loaded.")
        Else

            cmd = New SqlCommand("Select * from GRN where Invoice_ID='" & TB_D_Load.Text.Trim() & "'", con)
            If con.State = ConnectionState.Closed Then con.Open()
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                dr.Close()
                Dim RStas As String = "Returned"

                Try

                    Dim SplyerID As Long = SIDByGRN(TB_D_Load.Text.Trim())
                    Using cmd = New SqlCommand("select Invoice_ID from GRN where Invoice_ID > '" & TB_D_Load.Text.Trim() & "' and SID = '" & SplyerID & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Dim count As Integer = 0
                        Using dr = cmd.ExecuteReader()
                            If dr.Read() Then
                                MessageBox.Show("You can't Delete this Invoice. Because newer" + Environment.NewLine + "Invoice/s are depended on this one.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End Using
                    End Using
                    Using cmd = New SqlCommand("select * from GRNItems where Invoice_ID = '" & TB_D_Load.Text.Trim() & "' and Return_Status = '" & RStas & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Dim count As Integer = 0
                        Using dr = cmd.ExecuteReader()
                            If dr.Read() Then
                                MessageBox.Show("All/Some of the items in this ""Invoice"" has been" + Environment.NewLine + "returned. Thus you can't Delete this ""Invoice"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                Return
                            End If
                        End Using
                    End Using
                    Using cmd = New SqlCommand("select Invoice_ID from GRNPayment where Invoice_ID = '" & TB_D_Load.Text.Trim() & "'", con)
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        Dim count As Integer = 0
                        Using dr = cmd.ExecuteReader()
                            While dr.Read()
                                count += 1
                            End While
                        End Using
                        If count > 1 Then
                            MessageBox.Show("This ""Invoice"" has more than one payment methods" + Environment.NewLine + "Thus you can't Delete this ""Invoice"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Return
                        End If
                    End Using
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        D_DGV_Items.Rows.Clear()
                        Try
                            cmd.CommandText = "Select * from GRN where Invoice_ID = '" & TB_D_Load.Text.Trim() & "'"
                            Using dr = cmd.ExecuteReader()
                                If dr.Read() Then
                                    D_TB_GRN.Text = dr.Item("Invoice_ID")
                                    ID = dr.Item("SID")
                                    D_TB_IN.Text = dr.Item("Invoice_No")
                                    D_DTP_Inv_Date.Text = dr.Item("Invoice_Date")
                                    D_DTP_RecDate.Text = dr.Item("Recieving_Date")
                                    Dim data As Byte() = DirectCast(dr("Picture"), Byte())
                                    Dim ms As New MemoryStream(data)
                                    D_PictureBox.Image = Image.FromStream(ms)
                                End If
                            End Using

                            cmd.CommandText = "Select * from GRNItems where Invoice_ID = '" & TB_D_Load.Text.Trim() & "'"
                            Using dr = cmd.ExecuteReader()
                                While dr.Read
                                    ItmNo = dr("Item_No")
                                    Ietm = dr("Item")
                                    mitrs = dr("Meters")
                                    Price = dr("ItemTAmount")
                                    Dim row As String()
                                    row = New String() {ItmNo, Ietm, mitrs, Price}
                                    D_DGV_Items.Rows.Add(row)
                                    D_DGV_Items_Edit.Text = "Edit"
                                    D_DGV_Items_Edit.UseColumnTextForButtonValue = True
                                    D_DGV_Items_Del.Text = "Delete"
                                    D_DGV_Items_Del.UseColumnTextForButtonValue = True
                                End While
                                PreviousRows = D_DGV_Items.RowCount - 1
                            End Using
                            cmd.CommandText = "Select * from GRNPayment where Invoice_ID = '" & TB_D_Load.Text.Trim() & "'"
                            Using dr = cmd.ExecuteReader()
                                If dr.Read() Then
                                    D_ChkBox = dr.Item("Payment_Method")
                                    If D_ChkBox = D_RB_Cash.Text Then
                                        D_RB_Cash.Checked = True
                                    ElseIf D_ChkBox = D_RB_CashNChq.Text Then
                                        D_RB_CashNChq.Checked = True
                                    ElseIf D_ChkBox = D_RB_CshNChqNCred.Text Then
                                        D_RB_CshNChqNCred.Checked = True
                                    ElseIf D_ChkBox = D_RB_CashNCred.Text Then
                                        D_RB_CashNCred.Checked = True
                                    ElseIf D_ChkBox = D_RB_Cheque.Text Then
                                        D_RB_Cheque.Checked = True
                                    ElseIf D_ChkBox = D_RB_ChqNCred.Text Then
                                        D_RB_ChqNCred.Checked = True
                                    ElseIf D_ChkBox = D_RB_Credit.Text Then
                                        D_RB_Credit.Checked = True
                                    End If
                                    D_TB_PID.Text = dr.Item("Payment_ID")
                                    D_TB_GRNTA.Text = dr.Item("GRNTAmount")
                                    D_TB_AmntPad.Text = dr.Item("CashPaid")
                                    D_TB_ChqPad.Text = dr.Item("ChequePaid")
                                    D_TB_InvCredit.Text = dr.Item("Invoice_Credit")
                                    D_TB_RecName.Text = dr.Item("Receivers_Name")
                                    D_TB_ChqNo.Text = dr.Item("ChequeNo")
                                    D_DTP_ChqDate.Text = dr.Item("ChequeDate")
                                    D_TB_BnkNam.Text = dr.Item("BankName")
                                    D_DTP_PDD.Text = dr.Item("PaymentDeliveryDate")
                                    D_TB_TBalance.Text = dr.Item("TotalBalance")
                                End If
                            End Using
                            transaction.Commit()
                            With SNameCNameBySID(ID)
                                SplyrName = .Item1
                                SplyrComp = .Item2
                            End With
                            D_CB_SName.Text = SplyrName
                            D_CB_CName.Text = SplyrComp
                            D_TB_PrevBalance_Enter(sender, e)
                            MessageBox.Show("""Invoice"" has been loaded Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
            Else
                dr.Close()
                MessageBox.Show("No Such ""Invoice"" Exists.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        End If
    End Sub

    Private Sub D_TB_PrevBalance_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_TB_PrevBalance.Enter
        If D_CB_SName.Text = "" Or D_CB_CName.Text = "" Then
            MessageBox.Show("Supplier or Company has not been loaded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else
            SuppID = SupID(D_CB_SName.Text, D_CB_CName.Text)
            D_TB_PrevBalance.Text = PrevBlnc(SuppID)
        End If
    End Sub

    '########################################################'
    ''~~~~~~~~~~~~~~ Deletion Header Code Ends ~~~~~~~~~~~~~~'
    '________________________________________________________'

    ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    ''~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    ''______________________________________________________'

    Private Sub D_Btn_Clrall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles D_Btn_Clrall.Click
        'GRN TAB
        D_TB_GRN.Text = ""
        D_CB_SName.Text = ""
        D_CB_CName.Text = ""
        D_TB_IN.Text = ""
        D_DTP_Inv_Date.Text = Today()
        D_DTP_RecDate.Text = Today()
        D_PictureBox.Image = My.Resources.Receipt
        'Items TAB
        D_DGV_Items.Rows.Clear()
        'GRN Payment TAB
        RB_False()
        D_Reefresh()
        D_TB_GRNTA.Text = ""
        D_TB_AmntPad.Text = ""
        D_TB_ChqPad.Text = ""
        D_TB_InvCredit.Text = ""
        D_TB_RecName.Text = ""
        D_TB_ChqNo.Text = ""
        D_DTP_ChqDate.Text = Today()
        D_TB_BnkNam.Text = ""
        D_DTP_PDD.Text = Today()
        D_TB_PrevBalance.Text = ""
        D_TB_TBalance.Text = ""
        GRN_Load(sender, e)
    End Sub

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        Try
            If D_TB_GRN.Text.Trim() = "" Then
                MessageBox.Show("Please load an ""Invoice"" first.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Else
                Try

                    SuppID = SupID(D_CB_SName.Text, D_CB_CName.Text)
                    Using cmd As New SqlCommand
                        Dim transaction As SqlTransaction
                        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                        transaction = con.BeginTransaction("SampleTransaction")
                        cmd.Connection = con
                        cmd.Transaction = transaction
                        Try
                            cmd.CommandText = "Delete from GRNItems where Invoice_ID = '" & D_TB_GRN.Text.Trim() & "'"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Delete from GRNPayment where Invoice_ID = '" & D_TB_GRN.Text.Trim() & "'"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Delete from GRN where Invoice_ID = '" & D_TB_GRN.Text.Trim() & "'"
                            cmd.ExecuteNonQuery()

                            cmd.CommandText = "Update GRNPayment SET Credit_Status = 'Active' WHERE Payment_ID = (" _
                                & "Select Max(GRNPayment.Payment_ID) FROM GRN INNER JOIN GRNPayment " _
                                & "ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE GRN.Invoice_ID = (" _
                                & "Select Max(GRN.Invoice_ID) FROM GRN INNER JOIN GRNPayment " _
                                & "ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE	GRN.SID = '" & SuppID & "' and " _
                                & "GRNPayment.Credit_Status = 'Idle'))"
                            cmd.ExecuteNonQuery()

                            Dim Permision As Integer = MessageBox.Show("Are you sure to delete Invoice ID : " + D_TB_GRN.Text.Trim() + "." + Environment.NewLine + "It will be deleted Permanently.", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If Permision = DialogResult.Yes Then
                                transaction.Commit()
                                MessageBox.Show("""Invoice"" has been Deleted Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    ''^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^'
    ''~~~~~~~~~~~~~~~~~ Buttons Code End ~~~~~~~~~~~~~~~~~'
    ''____________________________________________________'

    ''"""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Deletion Code End ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    ''"""""""""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Private Functions Start ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    Private Sub Invoice_ID()

        Dim Val As String
        Using cmd = New SqlCommand("select Invoice_ID from GRN where Invoice_ID = (Select MAX(Invoice_ID) from GRN)", con)
            If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
            Using dr = cmd.ExecuteReader
                If dr.HasRows = False Then
                    Val = 0
                    TB_GRN.Text = Val + 1
                ElseIf dr.Read Then
                    Val = dr.Item("Invoice_ID")
                    TB_GRN.Text = Val + 1
                End If
            End Using
        End Using
    End Sub

    Private Sub PmntID()
        Dim Val As String
        Using cmd = New SqlCommand("select Payment_ID from GRNPayment where Payment_ID = (Select MAX(Payment_ID) from GRNPayment)", con)
            If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
            Using dr = cmd.ExecuteReader
                If dr.HasRows = False Then
                    Val = 0
                    TB_PID.Text = Val + 1
                ElseIf dr.Read Then
                    Val = dr.Item("Payment_ID")
                    TB_PID.Text = Val + 1
                End If
            End Using
        End Using
    End Sub

    Private Sub SupName()
        CB_SName.SelectedItem = Nothing
        CB_SName.Items.Clear()
        UD_CB_SName.SelectedItem = Nothing
        UD_CB_SName.Items.Clear()

        Try
            Using com As New SqlCommand("Select SName from Suppliers ORDER BY SName ASC", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                Using dr = com.ExecuteReader
                    While dr.Read
                        CB_SName.Items.Add(dr("SName"))
                        UD_CB_SName.Items.Add(dr("SName"))
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Function SupID(ByVal SName1 As String, ByVal CName1 As String) As Long
        '~~~~ Supplier ID by Supplier Name and Company Name ~~~~'

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
                If ConnectionState.Open Then con.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return SupID

    End Function

    Function PrevBlnc(ByVal Supidnty As Long) As Long
        PrevBlnc = 0
        Dim paimntId As String = 0
        Try
            Using com As New SqlCommand("SELECT GRNPayment.Payment_ID FROM GRN INNER JOIN GRNPayment" _
                      & " ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE GRN.SID = '" & Supidnty & "' and " _
                      & "GRNPayment.Credit_Status = '" & CStatus.Text & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                Using dr = com.ExecuteReader
                    If dr.Read Then
                        paimntId = dr.Item("Payment_ID")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        If paimntId = UD_TB_PID.Text Or paimntId = D_TB_PID.Text Then
            SelectionChangeCommited = False

            Dim naam, campny As String
            naam = ""
            campny = ""
            Try
                Using com As New SqlCommand("Select SName, CName from Suppliers where SID ='" & Supidnty & "'", con)
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    Using dr = com.ExecuteReader
                        If dr.Read Then
                            naam = dr.Item("SName")
                            campny = dr.Item("CName")
                        Else
                            MessageBox.Show("The Supplier doesn't exist anymore. Please contact developer or add another supplier.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Try
                Using com As New SqlCommand("SELECT TotalBalance " _
                                            & "FROM GRNPayment " _
                                            & "WHERE (Payment_ID = " _
                                            & "(SELECT MAX(GRNPayment_1.Payment_ID) AS Expr1 " _
                                            & "FROM GRN INNER JOIN " _
                                            & "GRNPayment AS GRNPayment_1 ON GRN.Invoice_ID = GRNPayment_1.Invoice_ID " _
                                            & "WHERE (GRNPayment_1.Credit_Status = 'Idle') AND (GRN.SID = " _
                                            & "(SELECT SID " _
                                            & "FROM Suppliers " _
                                            & "WHERE (SName = '" & naam & "') " _
                                            & "AND (CName = '" & campny & "')))))", con)
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    Using dr = com.ExecuteReader
                        If dr.Read Then
                            PrevBlnc = dr.Item("TotalBalance")
                        End If
                    End Using
                End Using
                Return PrevBlnc
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
            Try
                Using com As New SqlCommand("SELECT GRNPayment.TotalBalance FROM GRN INNER JOIN GRNPayment" _
                          & " ON GRN.Invoice_ID = GRNPayment.Invoice_ID WHERE GRN.SID = '" & Supidnty & "' and " _
                          & "GRNPayment.Credit_Status = '" & CStatus.Text & "'", con)
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    Using dr = com.ExecuteReader
                        If dr.Read Then
                            PrevBlnc = dr.Item("TotalBalance")
                        Else
                            PrevBlnc = 0
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return PrevBlnc
        End If

    End Function

    Function SIDByGRN(ByVal GRNN As Long) As Long
        '~~~~ Supplier ID by GRN-Number ~~~~'

        SIDByGRN = 0
        Try
            Using com As New SqlCommand("Select SID from GRN where Invoice_ID = '" & GRNN & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                Using dr = com.ExecuteReader
                    If dr.Read Then
                        SIDByGRN = dr.Item("SID")
                    Else
                        SIDByGRN = 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return SIDByGRN

    End Function

    Public Function SNameCNameBySID(ByVal ID As Integer) As Tuple(Of String, String)
        '~~~~ Supplier ID by Supplier Name and Company Name ~~~~'
        Dim naam, campny As String
        naam = ""
        campny = ""
        Try
            Using com As New SqlCommand("Select SName,CName from Suppliers where SID ='" & ID & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                Using dr = com.ExecuteReader
                    If dr.Read Then
                        naam = dr.Item("SName")
                        campny = dr.Item("CName")
                    Else
                        MessageBox.Show("The Supplier doesn't exist anymore. Please contact developer or add another supplier.", "message", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return New Tuple(Of String, String)(naam, campny)
    End Function

    Private Sub CompName()
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        Try
            If caler.Name = "CB_CName_Enter" And CB_SName.SelectedItem <> Nothing Then
                Using com As New SqlCommand("Select CName from Suppliers where SName = '" & CB_SName.SelectedItem & "' ORDER BY SName ASC", con)
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    Using dr = com.ExecuteReader
                        CB_CName.Items.Clear()
                        While dr.Read
                            CB_CName.Items.Add(dr("CName"))
                        End While
                    End Using
                End Using
            ElseIf caler.Name = "UD_CB_CName_Enter" And UD_CB_SName.SelectedItem <> Nothing Or caler.Name = "Btn_UD_Load_Click" Then
                Using com As New SqlCommand("Select CName from Suppliers where SName = '" & UD_CB_SName.SelectedItem & "' ORDER BY SName ASC", con)
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    Using dr = com.ExecuteReader
                        UD_CB_CName.Items.Clear()
                        While dr.Read
                            UD_CB_CName.Items.Add(dr("CName"))
                        End While
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Reefresh()
        TB_AmntPad.Text = ""
        TB_ChqPad.Text = ""
        TB_InvCredit.Text = ""
        TB_RecName.Text = ""
        TB_ChqNo.Text = ""
        DTP_ChqDate.Text = Today
        TB_BnkNam.Text = ""
    End Sub

    Private Sub UD_Reefresh()
        UD_TB_AmntPad.Text = ""
        UD_TB_ChqPad.Text = ""
        UD_TB_InvCredit.Text = ""
        UD_TB_RecName.Text = ""
        UD_TB_ChqNo.Text = ""
        UD_DTP_ChqDate.Text = Today
        UD_TB_BnkNam.Text = ""
    End Sub

    Private Sub D_Reefresh()
        D_TB_AmntPad.Text = ""
        D_TB_ChqPad.Text = ""
        D_TB_InvCredit.Text = ""
        D_TB_RecName.Text = ""
        D_TB_ChqNo.Text = ""
        D_DTP_ChqDate.Text = Today
        D_TB_BnkNam.Text = ""
    End Sub

    Private Sub Mesg()
        MessageBox.Show("The Amount you have entered is exceeding" + Environment.NewLine + "then the ""GRN Total Amount"".", "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub RB_False()
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        If caler.Name = "Btn_Clrall_Click" Then
            RB_Cash.Checked = False
            RB_CashNChq.Checked = False
            RB_CshNChqNCred.Checked = False
            RB_CashNCred.Checked = False
            RB_Cheque.Checked = False
            RB_ChqNCred.Checked = False
            RB_Credit.Checked = False
            RB_Click = False
        ElseIf caler.Name = "UD_Btn_Clrall_Click" Then
            UD_RB_Cash.Checked = False
            UD_RB_CashNChq.Checked = False
            UD_RB_CshNChqNCred.Checked = False
            UD_RB_CashNCred.Checked = False
            UD_RB_Cheque.Checked = False
            UD_RB_ChqNCred.Checked = False
            UD_RB_Credit.Checked = False
            RB_Click = False
        ElseIf caler.Name = "D_Btn_Clrall_Click" Then
            D_RB_Cash.Checked = False
            D_RB_CashNChq.Checked = False
            D_RB_CshNChqNCred.Checked = False
            D_RB_CashNCred.Checked = False
            D_RB_Cheque.Checked = False
            D_RB_ChqNCred.Checked = False
            D_RB_Credit.Checked = False
        End If

    End Sub

    Private Sub AmountCheck()
        Dim caler As System.Reflection.MethodBase
        caler = New System.Diagnostics.StackTrace().GetFrame(1).GetMethod()
        If caler.Name = "TB_AmntPad_Leave" Or caler.Name = "UD_TB_AmntPad_Leave" Then
            If AmntPad <> 0 Then
                If AmntPad > GRNTA Then
                    Mesg()
                    If caler.Name = "TB_AmntPad_Leave" Then
                        TB_AmntPad.Focus()
                        Return
                    Else
                        UD_TB_AmntPad.Focus()
                        Return
                    End If
                ElseIf ChqPad <> 0 Then
                    If AmntPad + ChqPad > GRNTA Then
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
                If ChqPad > GRNTA Then
                    Mesg()
                    If caler.Name = "TB_ChqPad_Leave" Then
                        TB_ChqPad.Focus()
                        Return
                    Else
                        UD_TB_ChqPad.Focus()
                        Return
                    End If
                ElseIf AmntPad <> 0 Then
                    If AmntPad + ChqPad > GRNTA Then
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

End Class