Public Class UiWindowClassFile
    Implements UiWindowClassFileInterface

    Const KM2MI = 1.609344

    Public Function convertKilometrsToMiles(ByRef kilometers As Double) As Double Implements UiWindowClassFileInterface.convertKilometrsToMiles
        Return kilometers / KM2MI
    End Function
End Class
