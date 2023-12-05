Imports System

Module Program
    Sub Main(args As String())
        Dim grafo As New Grafo(5)

        ' Agregar aristas
        grafo.AgregarArista(0, 1)
        grafo.AgregarArista(0, 4)
        grafo.AgregarArista(1, 2)
        grafo.AgregarArista(1, 3)
        grafo.AgregarArista(1, 4)
        grafo.AgregarArista(2, 3)
        grafo.AgregarArista(3, 4)

        ' Imprimir el grafo
        Console.WriteLine("Grafo no dirigido:")
        grafo.ImprimirGrafo()
    End Sub
End Module
