Public Class UiWindowClassFile
    Implements UiWindowClassFileInterface

    Const KM2MI = 1.609344

    Private miilid As Double = 0

    Public Function convertKilometrsToMiles(ByRef kilometers As Double) As Double Implements UiWindowClassFileInterface.convertKilometrsToMiles
        miilid = kilometers / KM2MI
        Return miilid
    End Function
End Class
