Friend Class TreeNode
    Public Property Name As String
    Public Property Children As List(Of TreeNode)

    Public Sub New(name As String)
        Me.Name = name
        Me.Children = New List(Of TreeNode)()
    End Sub
End Class
