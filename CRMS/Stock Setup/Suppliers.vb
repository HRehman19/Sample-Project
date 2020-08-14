Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Suppliers
    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=CRMS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub Suppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Utype As String = Home.TSSL_RollType.Text
        If Utype = "User" Or Utype = "user" Then
            Tab_Control.TabPages.Remove(TP_Delete)
        End If
        Sup_ID()
    End Sub

    '"""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Addition Code Start ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '""""""""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub Btn_Clear_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Clear_All.Click
        Sup_ID()
        TB_SName.Text = ""
        TB_CName.Text = ""
        TB_Email.Text = ""
        TB_P_No.Text = ""
        TB_BAT.Text = ""
        TB_BAN.Text = ""
        TB_BBC.Text = ""
        TB_Adr.Text = ""
    End Sub

    Private Sub Btn_Submit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Submit.Click
        If (TB_SName.Text.Trim() = "") Then
            MessageBox.Show("Please enter ""Supplier Name"".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_SName.Focus()
        ElseIf (TB_CName.Text.Trim() = "") Then
            MessageBox.Show("Please enter ""Comapany Name"".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_CName.Focus()
        Else
            Try
                cmd = New SqlCommand("select * from Suppliers where SName = '" & TB_SName.Text.Trim() & "' and CName = '" & TB_CName.Text.Trim() & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MessageBox.Show("Supplier " & TB_SName.Text.Trim() & " in company " & TB_CName.Text.Trim() & " does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                Else
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    cmd = New SqlCommand("Insert Into Suppliers Values ('" & TB_SName.Text.Trim() & "', '" & TB_CName.Text.Trim() & "', '" & TB_Email.Text.Trim() & "', '" & TB_P_No.Text.Trim() & "', '" & TB_BAT.Text.Trim() & "', '" & TB_BAN.Text.Trim() & "', '" & TB_BBC.Text.Trim() & "', '" & TB_Adr.Text.Trim() & "')", con)
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    cmd.ExecuteNonQuery()
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    Btn_Clear_All.PerformClick()
                    MessageBox.Show("New Supplier has been added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If

    End Sub

    ''"""""""""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~~~~ Buttons Code Ends ~~~~~~~~~~~~~~~~~'
    ''_____________________________________________________'

    ''""""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Addition Code Ends ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    ''""""""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~ Updation Code Starts ~~~~~~~~~~~~~~'
    ''~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    Private Sub TB_UD_Load_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TB_UD_Load.KeyPress
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Then
            Btn_UD_Load_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_UD_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UD_Load.Click
        If (TB_UD_Load.Text.Trim() = "") Then
            MessageBox.Show("Please enter ""Supplier ID"".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_UD_Load.Focus()
        ElseIf UD_TB_SID.Text.Trim() = TB_UD_Load.Text.Trim() Then
            MessageBox.Show("This supplier has alredy been loaded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                cmd = New SqlCommand("select * from Suppliers where SID = '" & TB_UD_Load.Text.Trim() & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                dr = cmd.ExecuteReader
                If dr.Read Then
                    UD_TB_SID.Text = dr.Item("SID")
                    UD_TB_SName.Text = dr.Item("SName")
                    UD_TB_CName.Text = dr.Item("CName")
                    UD_TB_Email.Text = dr.Item("Email")
                    UD_TB_P_No.Text = dr.Item("Phone_No")
                    UD_TB_BAT.Text = dr.Item("BnkAcntTitle")
                    UD_TB_BAN.Text = dr.Item("BnkAcntNo")
                    UD_TB_BBC.Text = dr.Item("BnkBrnhCod")
                    UD_TB_Adr.Text = dr.Item("Address")
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    MessageBox.Show("Supplier has been loaded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    MessageBox.Show("No such supplier found.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub

    ''""""""""""""""""""""""""""""""""""""""""""""""""""""""'
    ''~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    ''______________________________________________________'

    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        Dim check As Integer = 0
        If UD_TB_SID.Text.Trim() = "" Then
            MessageBox.Show("Please load a supplier first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (UD_TB_SName.Text.Trim() = "") Then
            MessageBox.Show("Please enter ""Supplier Name"".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UD_TB_SName.Focus()
        ElseIf (UD_TB_CName.Text.Trim() = "") Then
            MessageBox.Show("Please enter ""Comapany Name"".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            UD_TB_CName.Focus()
        Else
            Try
                cmd = New SqlCommand("select * from Suppliers where SName = '" & UD_TB_SName.Text.Trim() & "' AND CName = '" & UD_TB_CName.Text.Trim() & "' AND SID <> '" & UD_TB_SID.Text.Trim() & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                dr = cmd.ExecuteReader
                If dr.Read Then
                    MessageBox.Show("Supplier " & UD_TB_SName.Text.Trim() & " in company " & UD_TB_CName.Text.Trim() & " does not exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                Else
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    cmd = New SqlCommand("Update Suppliers Set SName = '" & UD_TB_SName.Text.Trim() & "', CName = '" & UD_TB_CName.Text.Trim() & "', Email ='" & UD_TB_Email.Text.Trim() & "', Phone_No = '" & UD_TB_P_No.Text.Trim() & "', BnkAcntTitle = '" & UD_TB_BAT.Text.Trim() & "', BnkAcntNo = '" & UD_TB_BAN.Text.Trim() & "', BnkBrnhCod ='" & UD_TB_BBC.Text.Trim() & "', Address = '" & UD_TB_Adr.Text.Trim() & "' where SID = '" & UD_TB_SID.Text.Trim() & "'", con)
                    If con.State = ConnectionState.Closed Then con.Open()
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MessageBox.Show("Supplier has been updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Btn_UD_Clear_All.PerformClick()
                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub

    Private Sub Btn_UD_Clear_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_UD_Clear_All.Click
        TB_UD_Load.Text = ""
        UD_TB_SID.Text = ""
        UD_TB_SName.Text = ""
        UD_TB_CName.Text = ""
        UD_TB_Email.Text = ""
        UD_TB_P_No.Text = ""
        UD_TB_BAT.Text = ""
        UD_TB_BAN.Text = ""
        UD_TB_BBC.Text = ""
        UD_TB_Adr.Text = ""
    End Sub

    '"""""""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~~~~ Buttons Code Ends ~~~~~~~~~~~~~~~~~'
    '_____________________________________________________'

    '""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Updation Code Ends ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    '""""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Deletion Code Starts ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    Private Sub TB_D_Load_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Microsoft.VisualBasic.Asc(e.KeyChar) = 13) Then
            Btn_D_Load_Click(sender, e)
        End If
    End Sub

    Private Sub Btn_D_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_D_Load.Click
        If (TB_D_Load.Text.Trim() = "") Then
            MessageBox.Show("Please enter ""Supplier ID"".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TB_D_Load.Focus()
        ElseIf D_TB_SID.Text.Trim() = TB_D_Load.Text.Trim() Then
            MessageBox.Show("This supplier has alredy been loaded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                cmd = New SqlCommand("select * from Suppliers where SID = '" & TB_D_Load.Text.Trim() & "'", con)
                If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                dr = cmd.ExecuteReader
                If dr.Read Then
                    D_TB_SID.Text = dr.Item("SID")
                    D_TB_SName.Text = dr.Item("SName")
                    D_TB_CName.Text = dr.Item("CName")
                    D_TB_Email.Text = dr.Item("Email")
                    D_TB_P_No.Text = dr.Item("Phone_No")
                    D_TB_BAT.Text = dr.Item("BnkAcntTitle")
                    D_TB_BAN.Text = dr.Item("BnkAcntNo")
                    D_TB_BBC.Text = dr.Item("BnkBrnhCod")
                    D_TB_Adr.Text = dr.Item("Address")
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    MessageBox.Show("Supplier has been loaded.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    MessageBox.Show("No such supplier found.", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub

    '""""""""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~~~~ Buttons Code Start ~~~~~~~~~~~~~~~~~'
    '______________________________________________________'

    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click


        If (D_TB_SID.Text.Trim() = "") Then
            MessageBox.Show("Please load a supplier first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                cmd = New SqlCommand("Delete from Suppliers where SID = '" & D_TB_SID.Text.Trim() & "'", con)
                Dim Confirm As MsgBoxResult = MessageBox.Show("Do you really want to delete this supplier?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Confirm = MsgBoxResult.Yes Then
                    If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
                    cmd.ExecuteNonQuery()
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    MessageBox.Show("Supplier has been deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Btn_D_Clear_All.PerformClick()
                Else
                    If con.State = ConnectionState.Open Then con.Close() 'Connection Close
                    Return
                End If
            Catch ex As Exception
                MessageBox.Show(String.Format("Error: {0}", ex.Message))
            End Try
        End If
    End Sub

    Private Sub Btn_D_Clear_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_D_Clear_All.Click
        TB_D_Load.Text = ""
        D_TB_SID.Text = ""
        D_TB_SName.Text = ""
        D_TB_CName.Text = ""
        D_TB_Email.Text = ""
        D_TB_P_No.Text = ""
        D_TB_BAT.Text = ""
        D_TB_BAN.Text = ""
        D_TB_BBC.Text = ""
        D_TB_Adr.Text = ""
    End Sub

    '""""""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~~~~ Buttons Code End ~~~~~~~~~~~~~~~~~'
    '____________________________________________________'

    '""""""""""""""""""""""""""""""""""""""""""""""""'
    '~~~~~~~~~~~~~~ Deletion Code Ends ~~~~~~~~~~~~~~'
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~'

    'Custom Functions

    Public Sub Sup_ID()
        Dim Val As String
        cmd = New SqlCommand("Select IDENT_CURRENT('Suppliers')", con)
        If con.State = ConnectionState.Closed Then con.Open() 'Connection Open
        Val = cmd.ExecuteScalar
        TB_SID.Text = Val + 1
        If con.State = ConnectionState.Open Then con.Close() 'Connection Close
    End Sub

End Class