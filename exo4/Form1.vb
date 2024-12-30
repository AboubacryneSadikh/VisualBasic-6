Imports System.Data
Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.nom.Text Is Nothing Or Me.nom.Text = "" Then
            MessageBox.Show("Le champs nom est vide")
        ElseIf Me.prenom.Text Is Nothing Or Me.prenom.Text = "" Then
            MessageBox.Show("Le champs prenom est vide")
        ElseIf Me.cni.Text Is Nothing Or Me.cni.Text = "" Then
            MessageBox.Show("Le champs CNI est vide")
        ElseIf Me.tel.Text Is Nothing Or Me.tel.Text = "" Then
            MessageBox.Show("Le champs telephone est vide")
        ElseIf Me.email.Text Is Nothing Or Me.email.Text = "" Then
            MessageBox.Show("Le champs Mail est vide")
        ElseIf Me.motdepasse.Text Is Nothing Or Me.motdepasse.Text = "" Then
            MessageBox.Show("Le champs mot de passe est vide")
        Else
            Dim connectionString = "host=127.0.0.1; user=root; password=; database=cefas"
            Dim query = "insert into user (nom, prenom, cni, tel, email, motdepasse) values (@nom, @prenom, @cni, @tel, @email, @motdepasse)"
            Using connection As New MySqlConnection(connectionString)
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("nom", Me.nom.Text)
                command.Parameters.AddWithValue("@prenom", Me.prenom.Text)
                command.Parameters.AddWithValue("@cni", Me.cni.Text)
                command.Parameters.AddWithValue("@tel", Me.tel.Text)
                command.Parameters.AddWithValue("@email", Me.email.Text)
                command.Parameters.AddWithValue("@motdepasse", Me.motdepasse.Text)
                command.Connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Enregistrement effectué avec succé")
            End Using
        End If
        Dim var_email = Me.email.Text
        Dim var_passwd = Me.motdepasse.Text
        Dim var_cpasswd = Me.cmotdepasse.Text
        'verification passwd
        If (var_passwd = var_cpasswd) Then
            MessageBox.Show("Les mots de passe sont conforment")
        Else
            MessageBox.Show("Les mots de passe ne sont pas identiques")
        End If
        If (var_cpasswd.Length < 8) Then
            MessageBox.Show("Mauvais mot de passe veillez saisir un mot de passe superieur ou egal à 9 caractère")
        Else MessageBox.Show("Bon mot de passe")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles prenom.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub nom_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nom_TextChanged_1(sender As Object, e As EventArgs) Handles nom.TextChanged

    End Sub
End Class
