Public Class Grafo
    Private V As Integer ' Número de vértices
    Private adyacencia() As List(Of Integer) ' Lista de adyacencia

    ' Constructor
    Public Sub New(v As Integer)
        Me.V = v
        ReDim adyacencia(v - 1)
        For i As Integer = 0 To v - 1
            adyacencia(i) = New List(Of Integer)()
        Next
    End Sub

    ' Método para agregar una arista al grafo no dirigido
    Public Sub AgregarArista(v As Integer, w As Integer)
        adyacencia(v).Add(w)
        adyacencia(w).Add(v)
    End Sub

    ' Método para imprimir el grafo
    Public Sub ImprimirGrafo()
        For i As Integer = 0 To V - 1
            Console.Write("Vértice " & i & ": ")
            For Each adyacente As Integer In adyacencia(i)
                Console.Write(adyacente & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Class
