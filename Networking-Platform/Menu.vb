Public Class Menu

 
    Private Sub BunifuCustomLabel1_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel1.Click
        closeChilds()
        Home.MdiParent = Me
        Home.Show()
    End Sub

 


  
    Private Sub BunifuCustomLabel2_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel2.Click
        closeChilds()
        Downloads.MdiParent = Me
        Downloads.Show()
    End Sub

    Private Sub BunifuCustomLabel3_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel3.Click
        closeChilds()
        Ordering.MdiParent = Me
        Ordering.Show()
    End Sub

    Private Sub BunifuCustomLabel5_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel5.Click
        closeChilds()
        FAQ.MdiParent = Me
        FAQ.Show()
    End Sub

  


    Private Sub BunifuCustomLabel4_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel4.Click
        closeChilds()
        Support.MdiParent = Me
        Support.Show()
    End Sub

    Private Sub BunifuCustomLabel6_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel6.Click
        closeChilds()
        Contact.MdiParent = Me
        Contact.Show()
    End Sub

    Private Sub BunifuCustomLabel7_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel7.Click
        closeChilds()
        Licenses.MdiParent = Me
        Licenses.Show()
    End Sub

    Private Sub BunifuCustomLabel8_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel8.Click
        closeChilds()
        Profile.MdiParent = Me
        Profile.Show()
    End Sub

    Private Sub BunifuCustomLabel9_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel9.Click
        closeChilds()
        Downloads.MdiParent = Me
        Downloads.Show()
    End Sub

    Private Sub BunifuCustomLabel10_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel10.Click
        closeChilds()
        Network.MdiParent = Me
        Network.Show()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setFormProps()
        closeChilds()
        Home.MdiParent = Me
        Home.Show()
    End Sub

    Private Sub BunifuCustomLabel11_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel11.Click
        closeChilds()
        Login.MdiParent = Me
        Login.Show()
    End Sub

    Private Sub BunifuCustomLabel12_Click(sender As Object, e As EventArgs) Handles BunifuCustomLabel12.Click
        closeChilds()
        About.MdiParent = Me
        About.Show()
    End Sub
End Class
