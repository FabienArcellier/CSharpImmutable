using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Immutability;

namespace ImmutabilityTests
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]
        public void TestBasic()
        {
            IStack<int> s1 = Stack<int>.Empty;
            IStack<int> s2 = s1.Push(10);
            IStack<int> s3 = s2.Push(20);
            IStack<int> s4 = s2.Push(30); // shares its tail with s3.
            IStack<int> s5 = s4.Pop();

            Assert.AreEqual(s5, s2);
        }
    }

    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void TestBasic()
        {
            IQueue<int> q1 = Queue<int>.Empty;
            IQueue<int> q2 = q1.Enqueue(15);
            IQueue<int> q3 = q2.Enqueue(16);
            IQueue<int> q4 = q3.Dequeue();
        }
    }

    [TestClass]
    public class AnimalImmutableTests
    {
        [TestMethod]
        public void TestBasic()
        {
            AnimalImmutable animal = new AnimalImmutable(23.0, "test");
            AnimalImmutable animal2 = new AnimalImmutable(24.0, "test2");
            AnimalImmutable animal3 = animal.SetSize(25.0);

            Assert.AreNotEqual(animal, animal3);
        }
    }
}
