Public Class frmBasicPage3
    Protected rowInd As Integer

    Private Sub frmBasicPage1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AppVar.hsh.Remove(Me.Name)
    End Sub

    Private Sub frmBasicPage1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call EnaCmd(True, False, False)
        btnAutosave.Visible = False
        BtnDelAll.Visible = False

        If AppVar.hsh Is Nothing Then
            AppVar.hsh = New Hashtable
        End If
    End Sub

    Public Overridable Sub EnaCmd(ByVal Add As Boolean, ByVal Edit As Boolean, ByVal Delete As Boolean)
        btnAdd.Enabled = Add
        btnEdit.Enabled = Edit
        btnDelete.Enabled = Delete
    End Sub

    Public Overridable Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub

    Public Overridable Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

    End Sub

    Public Overridable Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

    End Sub

    Public Overridable Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Call EnaCmd(True, True, False)
    End Sub

    Public Overridable Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Overridable Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

    End Sub

    Public Overridable Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

    End Sub


    Public Overridable Sub btnAutosave_Click(sender As System.Object, e As System.EventArgs) Handles btnAutosave.Click

    End Sub

    Public Overridable Sub btnDelAll_Click(sender As System.Object, e As System.EventArgs) Handles BtnDelAll.Click

    End Sub

End Class
