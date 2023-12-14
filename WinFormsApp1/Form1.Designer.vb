<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        ListBoxPila = New ListBox()
        Label1 = New Label()
        txtInput = New TextBox()
        btnPeek = New Button()
        btnPop = New Button()
        btnPush = New Button()
        TabPage2 = New TabPage()
        Label7 = New Label()
        Label6 = New Label()
        txtColaPrioridad = New TextBox()
        txtColaDoble = New TextBox()
        btnDequeuePrioridad = New Button()
        btnEnqueuePrioridad = New Button()
        btnDequeueFinal = New Button()
        btnEnqueueFinal = New Button()
        btnDequeueInicio = New Button()
        btnEnqueueInicio = New Button()
        btnDequeue = New Button()
        btnEnqueue = New Button()
        txtCola = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        listBoxColaPrioridad = New ListBox()
        listBoxColaDoble = New ListBox()
        listBoxCola = New ListBox()
        TabPage3 = New TabPage()
        btnDeleteTree = New Button()
        btnAddTree = New Button()
        txtNewNodeTree = New TextBox()
        txtFather = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        TabPage4 = New TabPage()
        TextBox2 = New TextBox()
        Label10 = New Label()
        textBox1 = New TextBox()
        btnListaDobleEnlazada = New Button()
        btnListaCircularDobleEnlazada = New Button()
        btnListaCircular = New Button()
        btnListaSimple = New Button()
        TabPage5 = New TabPage()
        Label12 = New Label()
        Label11 = New Label()
        btnAgregarBorde = New Button()
        txtOrigen = New TextBox()
        txtDestino = New TextBox()
        PTBGraphos = New PictureBox()
        btnAgregarVertice = New Button()
        txtVertice = New TextBox()
        txtTree = New TextBox()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        TabPage4.SuspendLayout()
        TabPage5.SuspendLayout()
        CType(PTBGraphos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Controls.Add(TabPage3)
        TabControl1.Controls.Add(TabPage4)
        TabControl1.Controls.Add(TabPage5)
        TabControl1.Location = New Point(12, 24)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1080, 508)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(ListBoxPila)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(txtInput)
        TabPage1.Controls.Add(btnPeek)
        TabPage1.Controls.Add(btnPop)
        TabPage1.Controls.Add(btnPush)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1072, 475)
        TabPage1.TabIndex = 0
        TabPage1.Text = "PILA"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' ListBoxPila
        ' 
        ListBoxPila.FormattingEnabled = True
        ListBoxPila.Location = New Point(670, 84)
        ListBoxPila.Name = "ListBoxPila"
        ListBoxPila.Size = New Size(281, 224)
        ListBoxPila.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(466, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 20)
        Label1.TabIndex = 4
        Label1.Text = "DATO"
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(442, 156)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 3
        ' 
        ' btnPeek
        ' 
        btnPeek.Location = New Point(152, 223)
        btnPeek.Name = "btnPeek"
        btnPeek.Size = New Size(94, 29)
        btnPeek.TabIndex = 2
        btnPeek.Text = "PEEK"
        btnPeek.UseVisualStyleBackColor = True
        ' 
        ' btnPop
        ' 
        btnPop.Location = New Point(152, 154)
        btnPop.Name = "btnPop"
        btnPop.Size = New Size(94, 29)
        btnPop.TabIndex = 1
        btnPop.Text = "POP"
        btnPop.UseVisualStyleBackColor = True
        ' 
        ' btnPush
        ' 
        btnPush.Location = New Point(152, 84)
        btnPush.Name = "btnPush"
        btnPush.Size = New Size(94, 29)
        btnPush.TabIndex = 0
        btnPush.Text = "PUSH"
        btnPush.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label7)
        TabPage2.Controls.Add(Label6)
        TabPage2.Controls.Add(txtColaPrioridad)
        TabPage2.Controls.Add(txtColaDoble)
        TabPage2.Controls.Add(btnDequeuePrioridad)
        TabPage2.Controls.Add(btnEnqueuePrioridad)
        TabPage2.Controls.Add(btnDequeueFinal)
        TabPage2.Controls.Add(btnEnqueueFinal)
        TabPage2.Controls.Add(btnDequeueInicio)
        TabPage2.Controls.Add(btnEnqueueInicio)
        TabPage2.Controls.Add(btnDequeue)
        TabPage2.Controls.Add(btnEnqueue)
        TabPage2.Controls.Add(txtCola)
        TabPage2.Controls.Add(Label5)
        TabPage2.Controls.Add(Label4)
        TabPage2.Controls.Add(Label3)
        TabPage2.Controls.Add(Label2)
        TabPage2.Controls.Add(listBoxColaPrioridad)
        TabPage2.Controls.Add(listBoxColaDoble)
        TabPage2.Controls.Add(listBoxCola)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1072, 475)
        TabPage2.TabIndex = 1
        TabPage2.Text = "COLA"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(15, 301)
        Label7.Name = "Label7"
        Label7.Size = New Size(158, 20)
        Label7.TabIndex = 19
        Label7.Text = "COLAS DE PRIORIDAD"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 20)
        Label6.TabIndex = 18
        Label6.Text = "COLAS DE DOBLE"
        ' 
        ' txtColaPrioridad
        ' 
        txtColaPrioridad.Location = New Point(15, 324)
        txtColaPrioridad.Name = "txtColaPrioridad"
        txtColaPrioridad.Size = New Size(232, 27)
        txtColaPrioridad.TabIndex = 17
        ' 
        ' txtColaDoble
        ' 
        txtColaDoble.Location = New Point(15, 168)
        txtColaDoble.Name = "txtColaDoble"
        txtColaDoble.Size = New Size(232, 27)
        txtColaDoble.TabIndex = 16
        ' 
        ' btnDequeuePrioridad
        ' 
        btnDequeuePrioridad.Location = New Point(143, 357)
        btnDequeuePrioridad.Name = "btnDequeuePrioridad"
        btnDequeuePrioridad.Size = New Size(104, 36)
        btnDequeuePrioridad.TabIndex = 15
        btnDequeuePrioridad.Text = "Dequeue"
        btnDequeuePrioridad.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueuePrioridad
        ' 
        btnEnqueuePrioridad.Location = New Point(15, 357)
        btnEnqueuePrioridad.Name = "btnEnqueuePrioridad"
        btnEnqueuePrioridad.Size = New Size(104, 36)
        btnEnqueuePrioridad.TabIndex = 14
        btnEnqueuePrioridad.Text = "Enqueue"
        btnEnqueuePrioridad.UseVisualStyleBackColor = True
        ' 
        ' btnDequeueFinal
        ' 
        btnDequeueFinal.Location = New Point(143, 243)
        btnDequeueFinal.Name = "btnDequeueFinal"
        btnDequeueFinal.Size = New Size(122, 36)
        btnDequeueFinal.TabIndex = 13
        btnDequeueFinal.Text = "Dequeue Final"
        btnDequeueFinal.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueueFinal
        ' 
        btnEnqueueFinal.Location = New Point(15, 243)
        btnEnqueueFinal.Name = "btnEnqueueFinal"
        btnEnqueueFinal.Size = New Size(122, 36)
        btnEnqueueFinal.TabIndex = 12
        btnEnqueueFinal.Text = "Enqueue Final"
        btnEnqueueFinal.UseVisualStyleBackColor = True
        ' 
        ' btnDequeueInicio
        ' 
        btnDequeueInicio.Location = New Point(143, 201)
        btnDequeueInicio.Name = "btnDequeueInicio"
        btnDequeueInicio.Size = New Size(122, 36)
        btnDequeueInicio.TabIndex = 11
        btnDequeueInicio.Text = "Dequeue Inicio"
        btnDequeueInicio.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueueInicio
        ' 
        btnEnqueueInicio.Location = New Point(15, 201)
        btnEnqueueInicio.Name = "btnEnqueueInicio"
        btnEnqueueInicio.Size = New Size(122, 36)
        btnEnqueueInicio.TabIndex = 10
        btnEnqueueInicio.Text = "Enqueue Inicio"
        btnEnqueueInicio.UseVisualStyleBackColor = True
        ' 
        ' btnDequeue
        ' 
        btnDequeue.Location = New Point(143, 110)
        btnDequeue.Name = "btnDequeue"
        btnDequeue.Size = New Size(104, 36)
        btnDequeue.TabIndex = 9
        btnDequeue.Text = "Dequeue"
        btnDequeue.UseVisualStyleBackColor = True
        ' 
        ' btnEnqueue
        ' 
        btnEnqueue.Location = New Point(15, 110)
        btnEnqueue.Name = "btnEnqueue"
        btnEnqueue.Size = New Size(104, 36)
        btnEnqueue.TabIndex = 8
        btnEnqueue.Text = "Enqueue"
        btnEnqueue.UseVisualStyleBackColor = True
        ' 
        ' txtCola
        ' 
        txtCola.Location = New Point(15, 57)
        txtCola.Name = "txtCola"
        txtCola.Size = New Size(232, 27)
        txtCola.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(26, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(54, 20)
        Label5.TabIndex = 6
        Label5.Text = "COLAS"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(593, 47)
        Label4.Name = "Label4"
        Label4.Size = New Size(158, 20)
        Label4.TabIndex = 5
        Label4.Text = "COLAS DE PRIORIDAD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(441, 47)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 20)
        Label3.TabIndex = 4
        Label3.Text = "COLAS DE DOBLE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(309, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 20)
        Label2.TabIndex = 3
        Label2.Text = "COLAS"
        ' 
        ' listBoxColaPrioridad
        ' 
        listBoxColaPrioridad.FormattingEnabled = True
        listBoxColaPrioridad.Location = New Point(593, 81)
        listBoxColaPrioridad.Name = "listBoxColaPrioridad"
        listBoxColaPrioridad.Size = New Size(157, 264)
        listBoxColaPrioridad.TabIndex = 2
        ' 
        ' listBoxColaDoble
        ' 
        listBoxColaDoble.FormattingEnabled = True
        listBoxColaDoble.Location = New Point(428, 81)
        listBoxColaDoble.Name = "listBoxColaDoble"
        listBoxColaDoble.Size = New Size(157, 264)
        listBoxColaDoble.TabIndex = 1
        ' 
        ' listBoxCola
        ' 
        listBoxCola.FormattingEnabled = True
        listBoxCola.Location = New Point(265, 81)
        listBoxCola.Name = "listBoxCola"
        listBoxCola.Size = New Size(157, 264)
        listBoxCola.TabIndex = 0
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(txtTree)
        TabPage3.Controls.Add(btnDeleteTree)
        TabPage3.Controls.Add(btnAddTree)
        TabPage3.Controls.Add(txtNewNodeTree)
        TabPage3.Controls.Add(txtFather)
        TabPage3.Controls.Add(Label9)
        TabPage3.Controls.Add(Label8)
        TabPage3.Location = New Point(4, 29)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1072, 475)
        TabPage3.TabIndex = 2
        TabPage3.Text = "ARBOL"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' btnDeleteTree
        ' 
        btnDeleteTree.Location = New Point(493, 300)
        btnDeleteTree.Name = "btnDeleteTree"
        btnDeleteTree.Size = New Size(94, 29)
        btnDeleteTree.TabIndex = 6
        btnDeleteTree.Text = "DELETE"
        btnDeleteTree.UseVisualStyleBackColor = True
        ' 
        ' btnAddTree
        ' 
        btnAddTree.Location = New Point(383, 300)
        btnAddTree.Name = "btnAddTree"
        btnAddTree.Size = New Size(94, 29)
        btnAddTree.TabIndex = 5
        btnAddTree.Text = "ADD"
        btnAddTree.UseVisualStyleBackColor = True
        ' 
        ' txtNewNodeTree
        ' 
        txtNewNodeTree.Location = New Point(390, 242)
        txtNewNodeTree.Name = "txtNewNodeTree"
        txtNewNodeTree.Size = New Size(197, 27)
        txtNewNodeTree.TabIndex = 4
        ' 
        ' txtFather
        ' 
        txtFather.Location = New Point(390, 119)
        txtFather.Name = "txtFather"
        txtFather.Size = New Size(197, 27)
        txtFather.TabIndex = 3
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(390, 201)
        Label9.Name = "Label9"
        Label9.Size = New Size(133, 20)
        Label9.TabIndex = 2
        Label9.Text = "NEW NODE NAME"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(390, 82)
        Label8.Name = "Label8"
        Label8.Size = New Size(197, 20)
        Label8.TabIndex = 1
        Label8.Text = "NOMBRE DEL NODO PADRE"
        ' 
        ' TabPage4
        ' 
        TabPage4.Controls.Add(TextBox2)
        TabPage4.Controls.Add(Label10)
        TabPage4.Controls.Add(textBox1)
        TabPage4.Controls.Add(btnListaDobleEnlazada)
        TabPage4.Controls.Add(btnListaCircularDobleEnlazada)
        TabPage4.Controls.Add(btnListaCircular)
        TabPage4.Controls.Add(btnListaSimple)
        TabPage4.Location = New Point(4, 29)
        TabPage4.Name = "TabPage4"
        TabPage4.Size = New Size(1072, 475)
        TabPage4.TabIndex = 3
        TabPage4.Text = "LISTA"
        TabPage4.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(516, 130)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(232, 27)
        TextBox2.TabIndex = 15
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(112, 42)
        Label10.Name = "Label10"
        Label10.Size = New Size(302, 20)
        Label10.TabIndex = 5
        Label10.Text = "¿CUANTOS ENTEROS TE GUSTARIA SUMAR?"
        ' 
        ' textBox1
        ' 
        textBox1.Location = New Point(185, 82)
        textBox1.Name = "textBox1"
        textBox1.Size = New Size(125, 27)
        textBox1.TabIndex = 4
        ' 
        ' btnListaDobleEnlazada
        ' 
        btnListaDobleEnlazada.Location = New Point(296, 262)
        btnListaDobleEnlazada.Name = "btnListaDobleEnlazada"
        btnListaDobleEnlazada.Size = New Size(138, 72)
        btnListaDobleEnlazada.TabIndex = 3
        btnListaDobleEnlazada.Text = "Doubly Linked List"
        btnListaDobleEnlazada.UseVisualStyleBackColor = True
        ' 
        ' btnListaCircularDobleEnlazada
        ' 
        btnListaCircularDobleEnlazada.Location = New Point(112, 262)
        btnListaCircularDobleEnlazada.Name = "btnListaCircularDobleEnlazada"
        btnListaCircularDobleEnlazada.Size = New Size(138, 72)
        btnListaCircularDobleEnlazada.TabIndex = 2
        btnListaCircularDobleEnlazada.Text = "Circular Doubly Linked List"
        btnListaCircularDobleEnlazada.UseVisualStyleBackColor = True
        ' 
        ' btnListaCircular
        ' 
        btnListaCircular.Location = New Point(296, 170)
        btnListaCircular.Name = "btnListaCircular"
        btnListaCircular.Size = New Size(138, 72)
        btnListaCircular.TabIndex = 1
        btnListaCircular.Text = "Circular List"
        btnListaCircular.UseVisualStyleBackColor = True
        ' 
        ' btnListaSimple
        ' 
        btnListaSimple.Location = New Point(112, 170)
        btnListaSimple.Name = "btnListaSimple"
        btnListaSimple.Size = New Size(138, 72)
        btnListaSimple.TabIndex = 0
        btnListaSimple.Text = "Simple List"
        btnListaSimple.UseVisualStyleBackColor = True
        ' 
        ' TabPage5
        ' 
        TabPage5.Controls.Add(Label12)
        TabPage5.Controls.Add(Label11)
        TabPage5.Controls.Add(btnAgregarBorde)
        TabPage5.Controls.Add(txtOrigen)
        TabPage5.Controls.Add(txtDestino)
        TabPage5.Controls.Add(PTBGraphos)
        TabPage5.Controls.Add(btnAgregarVertice)
        TabPage5.Controls.Add(txtVertice)
        TabPage5.Location = New Point(4, 29)
        TabPage5.Name = "TabPage5"
        TabPage5.Size = New Size(1072, 475)
        TabPage5.TabIndex = 4
        TabPage5.Text = "GRAFO"
        TabPage5.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(971, 265)
        Label12.Name = "Label12"
        Label12.Size = New Size(70, 20)
        Label12.TabIndex = 7
        Label12.Text = "DESTINO"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(971, 188)
        Label11.Name = "Label11"
        Label11.Size = New Size(62, 20)
        Label11.TabIndex = 6
        Label11.Text = "ORIGEN"
        ' 
        ' btnAgregarBorde
        ' 
        btnAgregarBorde.Location = New Point(881, 346)
        btnAgregarBorde.Name = "btnAgregarBorde"
        btnAgregarBorde.Size = New Size(94, 52)
        btnAgregarBorde.TabIndex = 5
        btnAgregarBorde.Text = "AGREGAR BORDE"
        btnAgregarBorde.UseVisualStyleBackColor = True
        ' 
        ' txtOrigen
        ' 
        txtOrigen.Location = New Point(811, 185)
        txtOrigen.Name = "txtOrigen"
        txtOrigen.Size = New Size(125, 27)
        txtOrigen.TabIndex = 4
        ' 
        ' txtDestino
        ' 
        txtDestino.Location = New Point(811, 262)
        txtDestino.Name = "txtDestino"
        txtDestino.Size = New Size(125, 27)
        txtDestino.TabIndex = 3
        ' 
        ' PTBGraphos
        ' 
        PTBGraphos.Location = New Point(420, 70)
        PTBGraphos.Name = "PTBGraphos"
        PTBGraphos.Size = New Size(359, 367)
        PTBGraphos.TabIndex = 2
        PTBGraphos.TabStop = False
        ' 
        ' btnAgregarVertice
        ' 
        btnAgregarVertice.Location = New Point(52, 262)
        btnAgregarVertice.Name = "btnAgregarVertice"
        btnAgregarVertice.Size = New Size(136, 60)
        btnAgregarVertice.TabIndex = 1
        btnAgregarVertice.Text = "AGREGAR VERTICE"
        btnAgregarVertice.UseVisualStyleBackColor = True
        ' 
        ' txtVertice
        ' 
        txtVertice.Location = New Point(52, 120)
        txtVertice.Name = "txtVertice"
        txtVertice.Size = New Size(125, 27)
        txtVertice.TabIndex = 0
        ' 
        ' txtTree
        ' 
        txtTree.Location = New Point(38, 135)
        txtTree.Name = "txtTree"
        txtTree.Size = New Size(197, 27)
        txtTree.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1174, 558)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        TabPage4.ResumeLayout(False)
        TabPage4.PerformLayout()
        TabPage5.ResumeLayout(False)
        TabPage5.PerformLayout()
        CType(PTBGraphos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ListBoxPila As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnPeek As Button
    Friend WithEvents btnPop As Button
    Friend WithEvents btnPush As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents txtColaPrioridad As TextBox
    Friend WithEvents txtColaDoble As TextBox
    Friend WithEvents btnDequeuePrioridad As Button
    Friend WithEvents btnEnqueuePrioridad As Button
    Friend WithEvents btnDequeueFinal As Button
    Friend WithEvents btnEnqueueFinal As Button
    Friend WithEvents btnDequeueInicio As Button
    Friend WithEvents btnEnqueueInicio As Button
    Friend WithEvents btnDequeue As Button
    Friend WithEvents btnEnqueue As Button
    Friend WithEvents txtCola As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listBoxColaPrioridad As ListBox
    Friend WithEvents listBoxColaDoble As ListBox
    Friend WithEvents listBoxCola As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnDeleteTree As Button
    Friend WithEvents btnAddTree As Button
    Friend WithEvents txtNewNodeTree As TextBox
    Friend WithEvents txtFather As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents textBox1 As TextBox
    Friend WithEvents btnListaDobleEnlazada As Button
    Friend WithEvents btnListaCircularDobleEnlazada As Button
    Friend WithEvents btnListaCircular As Button
    Friend WithEvents btnListaSimple As Button
    Friend WithEvents btnAgregarVertice As Button
    Friend WithEvents txtVertice As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btnAgregarBorde As Button
    Friend WithEvents txtOrigen As TextBox
    Friend WithEvents txtDestino As TextBox
    Friend WithEvents PTBGraphos As PictureBox
    Friend WithEvents txtTree As TextBox

End Class
