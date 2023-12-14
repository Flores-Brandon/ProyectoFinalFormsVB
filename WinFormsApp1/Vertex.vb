Public Class Vertex
    Public Property Label As String
    Public Property Location As Point

    Public Sub New(label As String, location As Point)
        Me.Label = label
        Me.Location = location
    End Sub
End Class