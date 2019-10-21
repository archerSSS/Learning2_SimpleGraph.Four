using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures2;
using System.Collections.Generic;

namespace AlgoTest_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSillyFirst_1()
        {
            SimpleGraph<int> graph = new SimpleGraph<int>(5);
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            graph.AddEdge(0, 2);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 2);
            graph.AddEdge(1, 3);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);
            graph.AddEdge(3, 4);

            List<Vertex<int>> list = graph.WeakVertices();
            Assert.AreEqual(0, list.Count);
        }

        [TestMethod]
        public void TestSillyFirst_2()
        {
            SimpleGraph<int> graph = new SimpleGraph<int>(5);
            int[] array = new int[] { 1, 4 };
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);

            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 3);
            graph.AddEdge(2, 4);

            List<Vertex<int>> list = graph.WeakVertices();
            Assert.AreEqual(2, list.Count);

            int count = 0;
            foreach (Vertex<int> v in list)
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }
                
        }

        /*
         *          0   1   2   3   4   5   6   7   8   9
         *      
         * 
         * 0        0   1   1   0   1   0   0   0   0   0
         *      
         * 1        1   0   0   0   0   0   0   1   0   1
         *      
         * 2        1   0   0   1   0   0   0   0   0   0
         *      
         * 3        0   0   1   0   1   0   0   0   0   0
         *        
         * 4        1   0   0   1   0   1   1   0   0   0
         *      
         * 5        0   0   0   0   1   0   0   0   0   1
         *      
         * 6        0   0   0   0   1   0   0   1   0   0
         *      
         * 7        0   1   0   0   0   0   1   0   0   0
         *      
         * 8        0   0   0   0   0   0   0   0   0   0
         *      
         * 9        0   1   0   0   0   1   0   0   0   0
         */
        private SimpleGraph<int> GetGraphA()
        {
            SimpleGraph<int> graph = new SimpleGraph<int>(10);
            graph.AddVertex(0);
            graph.AddVertex(1);
            graph.AddVertex(2);
            graph.AddVertex(3);
            graph.AddVertex(4);
            graph.AddVertex(5);
            graph.AddVertex(6);
            graph.AddVertex(7);
            graph.AddVertex(8);
            graph.AddVertex(9);

            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 4);
            graph.AddEdge(1, 7);
            graph.AddEdge(1, 9);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 5);
            graph.AddEdge(4, 6);
            graph.AddEdge(5, 9);
            graph.AddEdge(6, 7);

            return graph;
        }
    }
}
