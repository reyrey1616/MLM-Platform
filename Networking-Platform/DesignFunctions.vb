Module DesignFunctions


    Public Sub closeChilds()
        For Each frm As Form In Menu.MdiChildren
            frm.Close()
        Next
    End Sub

    Public Sub setFormProps()
        For Each frm As Form In Menu.MdiChildren
            frm.Width = 1046
            frm.Height = 696
            frm.FormBorderStyle = FormBorderStyle.None
            frm.BackColor = Color.Red
            frm.StartPosition = FormStartPosition.CenterScreen

        Next
    End Sub
End Module
