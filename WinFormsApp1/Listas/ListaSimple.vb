Friend Class ListaSimple(Of T)
    Private Property Head As Node

    Public Sub New()
        Clear()
    End Sub

    Public Sub Agregar(data As Integer)
        ' Caso 0: Creamos un nodo nuevo
        Dim NewNode As New Node(data)
        ' Caso 1: Se inserta al inicio
        If IsEmpty() Then
            Head = NewNode
            Return
        End If
        ' Caso 2: Se impide repetir datos
        If Exist(NewNode.Data) Then
            Return
        End If
        ' Caso 3: Se inserta el dato al inicio de la lista 
        If NewNode.Data < Head.Data Then
            NewNode.Next = Head
            Head = NewNode
            Return
        End If
        ' Caso 4: Se recorre la lista
        Dim CurrentNode As Node = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.Data < NewNode.Data
            CurrentNode = CurrentNode.Next
        End While
        ' Caso 5: Se inserta en X posición o al final de la lista 
        NewNode.Next = CurrentNode.Next
        CurrentNode.Next = NewNode
    End Sub

    Public Sub Borrar(data As Integer, textBox As System.Windows.Forms.TextBox)
        textBox.Text = String.Empty
        ' Caso 1: Si la lista está vacía
        If IsEmpty() Then
            Return
        End If
        ' Caso 2: Si el dato está al inicio
        If Head.Data = data Then
            Head = Head.Next
            textBox.Text = $"- Dato[{data}] Eliminado de la lista"
            Return
        End If
        ' Caso 3: Recorremos la lista
        Dim CurrentNode As Node = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.Data < data
            CurrentNode = CurrentNode.Next
        End While
        ' Caso 4: Si el dato está en X posición
        If CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.Data = data Then
            CurrentNode.Next = CurrentNode.Next.Next
            textBox.Text = $"- Dato[{data}] Eliminado de la lista"
            Return
        End If
        ' Caso 5: No se encontró el dato
        textBox.Text = $"- Dato[{data}] No encontrado/eliminado de la lista"
    End Sub

    Public Sub Search(data As Integer, textBox As System.Windows.Forms.TextBox)
        textBox.Text = String.Empty
        ' Caso 1: Si la lista está vacía
        If IsEmpty() Then
            Return
        End If
        ' Caso 2: Si el dato está al inicio
        If Head.Data = data Then
            textBox.Text = $"- Dato[{data}] Existe en la lista"
            Return
        End If
        ' Caso 3: Recorremos la lista
        Dim CurrentNode As Node = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.Data <= data
            CurrentNode = CurrentNode.Next
        End While
        ' Caso 4: Si el dato está en X posición
        If CurrentNode.Data = data Then
            textBox.Text = $"- Dato[{data}] Existe en la lista"
            Return
        End If
        ' Caso 5: No existe el dato
        textBox.Text = $"- Dato[{data}] No Existe en la lista "
    End Sub

    Public Sub Show(textBox As System.Windows.Forms.TextBox)
        textBox.Text = String.Empty
        ' Caso 1: Si la lista está vacía
        If IsEmpty() Then
            textBox.Text = "Lista vacía"
            Return
        End If
        ' Caso 2: Recorremos la lista
        Dim i As Integer = 0
        Dim CurrentNode As Node = Head
        While CurrentNode IsNot Nothing
            textBox.Text += $"- Nodo[{i}] y dato: {CurrentNode.Data}{Environment.NewLine}"
            CurrentNode = CurrentNode.Next
            i += 1
        End While
    End Sub

    Public Function Exist(data As Integer) As Boolean
        ' Caso 1: Si la lista está vacía
        If IsEmpty() Then
            Return False
        End If
        ' Caso 2: Si el primer nodo contiene el dato
        If Head.Data = data Then
            Return True
        End If
        ' Caso 3: Empezamos a recorrer la lista
        Dim CurrentNode As Node = Head
        While CurrentNode.Next IsNot Nothing AndAlso CurrentNode.Next.Data <= data
            CurrentNode = CurrentNode.Next
        End While
        ' Caso 4: El dato existe en el último elemento
        If CurrentNode.Data = data Then
            Return True
        End If
        ' Caso 5: El dato no existe en la lista
        Return False
    End Function

    Public Function IsEmpty() As Boolean
        Return Head Is Nothing
    End Function

    Public Sub Clear()
        Head = Nothing
    End Sub
End Class
