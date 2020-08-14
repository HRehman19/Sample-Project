Imports System.Data.SqlClient
Public Class Home

    Dim con As SqlConnection = New SqlConnection("Data Source=.;Initial Catalog=POS;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Public pass As String
    Public UID As String
    Public UType As String

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TSSL_U_Name.Text = UID
        TSSL_RollType.Text = UType

    End Sub
    Private Sub TSMI_Logout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub TSMI_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub

    Private Sub TSMI_GRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_GRN.Click
        Purchase.MdiParent = Me
        Purchase.Show()
    End Sub


    Private Sub TSMI_SReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_SReceipt.Click
        Sales.MdiParent = Me
        Sales.Show()
    End Sub

End Class