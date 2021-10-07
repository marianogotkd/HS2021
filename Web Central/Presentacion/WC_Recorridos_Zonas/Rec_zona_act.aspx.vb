Public Class Rec_zona_act
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim valido As String
        If TextBox1.Text = "" Then
            valido = "no"
        Else
            valido = "si"
        End If

        Dim fecha2 As String = TextBox2.Text

    End Sub
End Class