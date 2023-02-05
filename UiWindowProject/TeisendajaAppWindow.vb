Imports PrjTeisendajaKomponent

Public Class TeisendajaApp

    Private Sub BtnTeisendaja_Click(sender As Object, e As EventArgs) Handles BtnTeisendaja.Click
        Dim Teisendaja As PrjTeisendajaKomponent.UiWindowClassFileInterface
        Teisendaja = New PrjTeisendajaKomponent.UiWindowClassFile
        Try
            MiiliOut.Text = Teisendaja.convertKilometrsToMiles(KiloEntry.Text)
        Catch ex As Exception
            MiiliOut.Text = "Viga sisendis!"
        End Try

    End Sub
End Class
