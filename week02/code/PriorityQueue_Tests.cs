using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities and dequeue them.
    // Expected Result: Items are dequeued in order of their priorities.
    // Defect(s) Found: 
    public void TestPriorityQueue_EnqueueDequeueSamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 1);
        priorityQueue.Enqueue("Second", 1);
        priorityQueue.Enqueue("Third", 1);
        Assert.AreEqual("First", priorityQueue.Dequeue());
        Assert.AreEqual("Second", priorityQueue.Dequeue());
        Assert.AreEqual("Third", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue. 
    // Expected Result: Exception should be thrown with appropriate error message. 
    // Defect(s) Found: 
    public void TestPriorityQueue_DequeueEmptyQueue()
    {
        var priorityQueue = new PriorityQueue(); 
        try 
        { priorityQueue.Dequeue(); 
        Assert.Fail("Exception should have been thrown."); 
        } 
        catch (InvalidOperationException e) 
        { 
            Assert.AreEqual("The queue is empty.", e.Message); 
        }
    }

    [TestMethod] 
    // Scenario: Enqueue items with mixed priorities and dequeue them. 
    // Expected Result: Items are dequeued in order of their priorities, with FIFO order for same priority. 
    // Defect(s) Found:
    public void TestPriorityQueue_DequeueMixedPriorities() 
    { 
        var priorityQueue = new PriorityQueue(); 
        priorityQueue.Enqueue("Medium1", 2); 
        priorityQueue.Enqueue("High", 3); 
        priorityQueue.Enqueue("Medium2", 2); 
        priorityQueue.Enqueue("Low", 1); 
        Assert.AreEqual("High", priorityQueue.Dequeue()); 
        Assert.AreEqual("Medium1", priorityQueue.Dequeue()); 
        Assert.AreEqual("Medium2", priorityQueue.Dequeue()); 
        Assert.AreEqual("Low", priorityQueue.Dequeue()); 
    }

}