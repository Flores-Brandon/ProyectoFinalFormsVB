Public Class Form1
    Private random As Random
    Private auto As Auto
    Private stringStack As MiPila(Of String)
    Private cola As Queue(Of String)
    Private bicola As LinkedList(Of String)
    Private colaPrioridad As SortedDictionary(Of Integer, Queue(Of String))
    Private tree As Tree = New Tree()
    Private graph As Graph = New Graph()
    Public Sub New()
        InitializeComponent()
        random = New Random()
        auto = New Auto()
        stringStack = New MiPila(Of String)()
        cola = New Queue(Of String)()
        colaPrioridad = New SortedDictionary(Of Integer, Queue(Of String))()
        bicola = New LinkedList(Of String)()
    End Sub

    Private Function ArrayReset(arr As Integer()) As Integer()
        arr(0) = 9
        arr(1) = 1
        arr(2) = 8
        arr(3) = 2
        arr(4) = 7
        Return arr
    End Function

    ' Código de la Pila

    Private Sub ActualizarStackListBox()
        ListBoxPila.Items.Clear()
        For i As Integer = stringStack.Count - 1 To 0 Step -1
            Dim item As String = stringStack(i)
            ListBoxPila.Items.Add(item)
        Next
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPush_Click(sender As Object, e As EventArgs) Handles btnPush.Click
        Dim item As String = txtInput.Text
        stringStack.Push(item)
        ActualizarStackListBox()
        txtInput.Clear()
    End Sub

    Private Sub btnPop_Click(sender As Object, e As EventArgs) Handles btnPop.Click
        Try
            Dim poppedItem As String = stringStack.Pop()
            MessageBox.Show("Elemento desapilado: " & poppedItem)
            ActualizarStackListBox()
        Catch ex As InvalidOperationException
            MessageBox.Show("La pila está vacía. No se pueden desapilar elementos.")
        End Try
    End Sub

    Private Sub btnPeek_Click(sender As Object, e As EventArgs) Handles btnPeek.Click
        Try
            Dim topItem As String = stringStack.Peek()
            MessageBox.Show("Elemento en la cima de la pila: " & topItem)
        Catch ex As InvalidOperationException
            MessageBox.Show("La pila está vacía. No hay elementos para ver.")
        End Try
    End Sub
    ' Fin del código de la Pila

    ' Inicio del código de la Cola
    Private Sub btnEnqueue_Click(sender As Object, e As EventArgs) Handles btnEnqueue.Click
        ' Agregar elementos a la cola
        Dim elemento As String = txtCola.Text
        cola.Enqueue(elemento)
        ActualizarListaCola()
    End Sub

    Private Sub ActualizarListaCola()
        listBoxCola.Items.Clear()
        For Each elemento As String In cola
            listBoxCola.Items.Add(elemento)
        Next
    End Sub

    Private Sub btnDequeue_Click(sender As Object, e As EventArgs) Handles btnDequeue.Click
        ' Verificar si la cola está vacía
        If cola.Count > 0 Then
            ' Eliminar el elemento de la cola
            Dim elementoEliminar As String = cola.Dequeue()
            MessageBox.Show($"Se eliminó el elemento: {elementoEliminar}")
            ActualizarListaCola()
        Else
            MessageBox.Show("La cola está vacía. No se pueden eliminar elementos.")
        End If
    End Sub
    Private Sub ActualizarListaColaDoble()
        ' Mostrar la cola doble en el ListBox
        listBoxColaDoble.Items.Clear()
        For Each elemento As String In bicola
            listBoxColaDoble.Items.Add((elemento))
        Next
    End Sub

    Private Sub btnEnqueueInicio_Click(sender As Object, e As EventArgs) Handles btnEnqueueInicio.Click
        ' Agregar el elemento al inicio de la cola doble
        Dim elemento As String = txtColaDoble.Text
        bicola.AddFirst(elemento)

        ' Actualizar ListBox
        ActualizarListaColaDoble()
    End Sub

    Private Sub btnDequeueInicio_Click(sender As Object, e As EventArgs) Handles btnDequeueInicio.Click
        ' Verificar si la cola doble está vacía.
        If bicola.Count > 0 Then
            ' Eliminar el elemento del inicio de la cola doble
            Dim elementoEliminar As String = bicola.First.Value
            bicola.RemoveFirst()
            MessageBox.Show($"Se eliminó el primer elemento: {elementoEliminar}")

            ' Actualizar la lista de los elementos de la cola doble
            ActualizarListaColaDoble()
        Else
            MessageBox.Show("La cola doble está vacía. No se pueden eliminar elementos al inicio.")
        End If
    End Sub

    Private Sub btnEnqueueFinal_Click(sender As Object, e As EventArgs) Handles btnEnqueueFinal.Click
        ' Agregar un elemento al final de la cola doble
        Dim elemento As String = txtColaDoble.Text
        bicola.AddLast(elemento)

        ' Actualizar la lista de elementos en la cola doble
        ActualizarListaColaDoble()
    End Sub

    Private Sub btnDequeueFinal_Click(sender As Object, e As EventArgs) Handles btnDequeueFinal.Click
        ' Verificar si la cola doble está vacía.
        If bicola.Count > 0 Then
            ' Eliminar el elemento del final de la cola doble
            Dim elementoEliminar As String = bicola.Last.Value
            bicola.RemoveLast()
            MessageBox.Show($"Se eliminó el último elemento: {elementoEliminar}")

            ' Actualizar la lista de los elementos de la cola doble
            ActualizarListaColaDoble()
        Else
            MessageBox.Show("La cola doble está vacía. No se pueden eliminar elementos al final.")
        End If
    End Sub

    Private Sub btnEnqueuePrioridad_Click(sender As Object, e As EventArgs) Handles btnEnqueuePrioridad.Click
        Dim elemento As String = txtColaPrioridad.Text
        Dim prioridad As Integer

        If Integer.TryParse(txtColaPrioridad.Text, prioridad) Then
            If Not colaPrioridad.ContainsKey(prioridad) Then
                colaPrioridad(prioridad) = New Queue(Of String)()
            End If
            colaPrioridad(prioridad).Enqueue(elemento)
            ' Actualizar la lista de elementos de la cola de prioridad
            ActualizarListaColaPrioridad()
        Else
            MessageBox.Show("Por favor, ingrese una prioridad válida (número entero).")
        End If
    End Sub
    Private Sub ActualizarListaColaPrioridad()
        ' Mostrar la cola de prioridad en ListBox
        listBoxColaPrioridad.Items.Clear()
        For Each kvp As KeyValuePair(Of Integer, Queue(Of String)) In colaPrioridad
            For Each elemento As String In kvp.Value
                listBoxColaPrioridad.Items.Add($"{elemento} - Prioridad: {kvp.Key}")
            Next
        Next
    End Sub

    Private Sub btnDequeuePrioridad_Click(sender As Object, e As EventArgs) Handles btnDequeuePrioridad.Click
        ' Verificamos si la cola de prioridad está vacía.
        If colaPrioridad.Count > 0 Then
            ' Encontrar la cola con la prioridad más baja
            Dim primeraCola = colaPrioridad.Keys.Min()
            Dim elementoEliminado = colaPrioridad(primeraCola).Dequeue()

            ' Si la cola está vacía, eliminarla de la cola de prioridad
            If colaPrioridad(primeraCola).Count = 0 Then
                colaPrioridad.Remove(primeraCola)
            End If

            ' Mostrar un mensaje con el elemento eliminado
            MessageBox.Show($"Se eliminó el elemento: {elementoEliminado}")

            ' Actualizar la lista de elementos en la cola de prioridad
            ActualizarListaColaPrioridad()
        Else
            MessageBox.Show("La cola de prioridad está vacía. No se pueden eliminar elementos.")
        End If
    End Sub
    ' Final del código de la Cola

    ' Inicio del código de Listas

    Private Async Function btnListaSimple_ClickAsync(sender As Object, e As EventArgs) As Task Handles btnListaSimple.Click
        Dim Lista_Simple As New ListaSimple(Of Integer)()
        auto.Auto_Add_SimpleList(Lista_Simple, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Delete_SimpleList(Lista_Simple, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Search_SimpleList(Lista_Simple, random, TextBox2, Integer.Parse(textBox1.Text))

    End Function

    Private Async Function btnListaCircular_ClickAsync(sender As Object, e As EventArgs) As Task Handles btnListaCircular.Click
        Dim Circular_List As New ListaCircular(Of Integer)()

        auto.Auto_Add_CircularList(Circular_List, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Delete_CircularList(Circular_List, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Search_CircularList(Circular_List, random, TextBox2, Integer.Parse(textBox1.Text))

    End Function

    Private Async Function btnListaCircularDobleEnlazada_ClickAsync(sender As Object, e As EventArgs) As Task Handles btnListaCircularDobleEnlazada.Click
        Dim Circular_Doubly_Linked_List As New ListaCircularDobleEnlazada(Of Integer)()
        auto.Auto_Add_CircularDoublyLinkedList(Circular_Doubly_Linked_List, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Delete_CircularDoublyLinkedList(Circular_Doubly_Linked_List, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Search_CircularDoublyLinkedList(Circular_Doubly_Linked_List, random, TextBox2, Integer.Parse(textBox1.Text))

    End Function

    Private Async Function btnListaDobleEnlazada_ClickAsync(sender As Object, e As EventArgs) As Task Handles btnListaDobleEnlazada.Click
        Dim Doubly_List_Linked As New ListaDobleEnlazada(Of Integer)()
        auto.Auto_Add_DoublyListLinked(Doubly_List_Linked, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Delete_DoublyListLinked(Doubly_List_Linked, random, TextBox2, Integer.Parse(textBox1.Text))
        Await Task.Delay(2000)
        auto.Auto_Search_DoublyListLinked(Doubly_List_Linked, random, TextBox2, Integer.Parse(textBox1.Text))

    End Function
    ' Final del código de Listas

    ' Inicio del código del Árbol

    Private Sub btnAddTree_Click(sender As Object, e As EventArgs) Handles btnAddTree.Click
        Dim parentNodeName As String = txtFather.Text
        Dim newNodeName As String = txtNewNodeTree.Text
        tree.AddNode(parentNodeName, newNodeName, txtTree)
    End Sub

    Private Sub btnDeleteTree_Click(sender As Object, e As EventArgs) Handles btnDeleteTree.Click
        Dim nodeNameToDelete As String = txtFather.Text
        tree.DeleteNode(nodeNameToDelete, txtTree)
    End Sub

    Private Sub btnAgregarVertice_Click(sender As Object, e As EventArgs) Handles btnAgregarVertice.Click
        Dim verticeLabel As String = txtVertice.Text

        If Not String.IsNullOrEmpty(verticeLabel) Then
            Dim location As New Point(graph.Vertices.Count * 50, graph.Vertices.Count * 50)
            Dim vertex As New Vertex(verticeLabel, location)
            graph.AddVertex(vertex)

            ' Dibujar el grafo
            DibujarGrafo()
        Else
            MessageBox.Show("Ingrese un vértice válido.")
        End If
    End Sub

    Private Sub btnAgregarBorde_Click(sender As Object, e As EventArgs) Handles btnAgregarBorde.Click
        Dim origenLabel As String = txtOrigen.Text
        Dim destinoLabel As String = txtDestino.Text

        Dim origen As Vertex = graph.Vertices.Find(Function(v) v.Label = origenLabel)
        Dim destino As Vertex = graph.Vertices.Find(Function(v) v.Label = destinoLabel)

        If origen IsNot Nothing AndAlso destino IsNot Nothing Then
            Dim edge As New Edge(origen, destino)
            graph.AddEdge(edge)

            ' Dibujar el grafo
            DibujarGrafo()
        Else
            MessageBox.Show("Ingrese un origen y destino válidos.")
        End If
    End Sub
    Private Sub DibujarGrafo()
        Using g As Graphics = PTBGraphos.CreateGraphics()
            graph.DrawGraph(g)
        End Using
    End Sub
End Class
