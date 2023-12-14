Public Class Edge
    Public Property Origin As Vertex
    Public Property Destination As Vertex

    Public Sub New(origin As Vertex, destination As Vertex)
        Me.Origin = origin
        Me.Destination = destination
    End Sub
End Class