Public Class Tree
    Private rootNode As TreeNode

    Public Sub AddNode(parentNodeName As String, newNodeName As String, textBox As TextBox)
        If rootNode Is Nothing Then
            rootNode = New TreeNode(parentNodeName)
        End If

        Dim parentNode As TreeNode = FindNode(rootNode, parentNodeName)

        If parentNode IsNot Nothing Then
            Dim newNode As New TreeNode(newNodeName)
            parentNode.Children.Add(newNode)

            ' No limpiar todo el contenido, solo actualizar el nuevo nodo
            UpdateTreeText(rootNode, textBox)

            textBox.AppendText(Environment.NewLine) ' Agregar un salto de línea al final

            textBox.ScrollToCaret() ' Desplazar al final del cuadro de texto
        Else
            MessageBox.Show("Nodo padre no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Public Async Sub DeleteNode(nodeName As String, textBox As TextBox)
        Dim nodeToDelete = FindNode(rootNode, nodeName)
        If nodeToDelete IsNot Nothing Then
            Dim parent = FindParentNode(rootNode, nodeName)

            If nodeToDelete Is rootNode Then
                If nodeToDelete.Children.Count > 0 Then
                    rootNode = nodeToDelete.Children(0)
                    textBox.Text = $"El nodo raíz '{nodeName}' se eliminó, y el primer hijo se convirtió en el nuevo raíz."
                Else
                    rootNode = Nothing
                    textBox.Text = $"El nodo raíz '{nodeName}' se eliminó."
                End If
            ElseIf parent IsNot Nothing Then
                If nodeToDelete.Children.Count > 0 Then
                    Dim firstChild = nodeToDelete.Children(0)
                    firstChild.Children.AddRange(nodeToDelete.Children.Skip(1))
                    parent.Children.Insert(parent.Children.IndexOf(nodeToDelete), firstChild)
                End If
                parent.Children.Remove(nodeToDelete)
                textBox.Text = $"El nodo '{nodeName}' se eliminó, y el primer hijo se convirtió en el nuevo padre sin cambiar la posición de la rama."
            End If
            Await Task.Delay(2000)
            textBox.Text = String.Empty
            UpdateTreeText(rootNode, textBox)
        Else
            textBox.Text = $"No se encontró el nodo '{nodeName}'."
        End If
    End Sub

    Private Sub UpdateTreeText(rootNode As TreeNode, textBox As TextBox)
        If rootNode Is Nothing Then
            textBox.Text = String.Empty
            Return
        End If

        Dim stack As New Stack(Of Tuple(Of TreeNode, String))()
        stack.Push(New Tuple(Of TreeNode, String)(rootNode, ""))

        While stack.Count > 0
            Dim current = stack.Pop()
            Dim node = current.Item1
            Dim indent = current.Item2

            textBox.AppendText(indent & "└─ " & node.Name & Environment.NewLine)

            For Each childNode In node.Children
                stack.Push(New Tuple(Of TreeNode, String)(childNode, indent & "    "))
            Next
        End While
    End Sub

    Private Function FindNode(parentNode As TreeNode, nodeName As String) As TreeNode
        If parentNode.Name = nodeName Then
            Return parentNode
        End If

        For Each childNode In parentNode.Children
            Dim foundNode As TreeNode = FindNode(childNode, nodeName)
            If foundNode IsNot Nothing Then
                Return foundNode
            End If
        Next

        Return Nothing
    End Function

    Private Function FindParentNode(parentNode As TreeNode, nodeName As String) As TreeNode
        For Each childNode In parentNode.Children
            If childNode.Name = nodeName Then
                Return parentNode
            End If

            Dim foundNode As TreeNode = FindParentNode(childNode, nodeName)
            If foundNode IsNot Nothing Then
                Return foundNode
            End If
        Next

        Return Nothing
    End Function
End Class
