using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue tres elementos con prioridades distintas.
    // Expected Result: El primero en salir debe ser el de mayor prioridad ("High").
    // Defect(s) Found: Originalmente devolvía "Low" porque el algoritmo no seleccionaba correctamente el máximo.
    public void TestPriorityQueue_HighestPriorityFirst()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("Low", 1);
        pq.Enqueue("High", 10);
        pq.Enqueue("Medium", 5);

        // El primero que debería salir es "High"
        var first = pq.Dequeue();
        Assert.AreEqual("High", first);
    }

    [TestMethod]
    // Scenario: Enqueue dos elementos con la misma prioridad
    // Expected Result: Debe respetar el orden FIFO, primero "A" luego "B"
    // Defect(s) Found: Si se usaba >= en la comparación, se rompía el FIFO.
    public void TestPriorityQueue_SamePriorityFIFO()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 2);
        pq.Enqueue("B", 2);

        // Si tienen la misma prioridad, respeta el orden de llegada
        var first = pq.Dequeue();
        var second = pq.Dequeue();

        Assert.AreEqual("A", first);
        Assert.AreEqual("B", second);
    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario: Intentar Dequeue en una cola vacía.
    // Expected Result: Debe lanzar InvalidOperationException con mensaje "The queue is empty."
    // Defect(s) Found: Si no se validaba, se producía IndexOutOfRangeException.
    public void TestPriorityQueue_EmptyQueueThrows()
    {
        var pq = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }

    [TestMethod]
    // Scenario: Enqueue con prioridades negativas y cero.
    // Expected Result: El mayor número (aunque sea negativo) debe salir primero.
    // Defect(s) Found: Confirmar que la comparación funciona correctamente con enteros negativos.
    public void TestPriorityQueue_NegativePriorities()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("MinusFive", -5);
        pq.Enqueue("MinusOne", -1);
        pq.Enqueue("Zero", 0);

        var first = pq.Dequeue();
        Assert.AreEqual("Zero", first); // 0 es mayor que -1 y -5
    }
}