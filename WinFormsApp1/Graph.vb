Imports System.Drawing

Public Class Graph
    Public ReadOnly Property Vertices As New List(Of Vertex)()
    Public ReadOnly Property Edges As New List(Of Edge)()

    Public Sub AddVertex(vertex As Vertex)
        Vertices.Add(vertex)
    End Sub

    Public Sub AddEdge(edge As Edge)
        Edges.Add(edge)
    End Sub

    Public Sub DrawGraph(g As Graphics)
        g.Clear(Color.White)

        ' Dibujar vértices
        For Each vertex In Vertices
            g.FillEllipse(Brushes.Blue, vertex.Location.X, vertex.Location.Y, 30, 30)
            g.DrawString(vertex.Label, New Font("Arial", 8), Brushes.Black, vertex.Location.X, vertex.Location.Y)
        Next

        ' Dibujar bordes
        For Each edge In Edges
            Dim origin As Point = edge.Origin.Location
            Dim destination As Point = edge.Destination.Location
            g.DrawLine(Pens.Red, origin.X + 15, origin.Y + 15, destination.X + 15, destination.Y + 15)
        Next
    End Sub
End Class
