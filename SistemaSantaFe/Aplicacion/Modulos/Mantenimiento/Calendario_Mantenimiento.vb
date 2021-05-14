Public Class Calendario_Mantenimiento
    Private Sub Calendario_Mantenimiento_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim fecha As Date = Today

        Dim dias_Sumar As Integer = 30

        Dim fechaResul = DateAdd("d", dias_Sumar, fecha)

        ' WEEKDAY--> si el valor es 7 sabado y si es 1 es domingo

        If Weekday(fechaResul) = 7 Then
            fechaResul = DateAdd("d", 2, fecha)
        End If

        If Weekday(fechaResul) = 1 Then
            fechaResul = DateAdd("d", 1, fecha)
        End If


    End Sub
End Class