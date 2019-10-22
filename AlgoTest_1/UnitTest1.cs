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

        [TestMethod]
        public void TestWeak_1()
        {
            SimpleGraph<int> graph = GetGraphA();
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<Vertex<int>> list = graph.WeakVertices();
            Assert.AreEqual(10, list.Count);

            int count = 0;
            foreach (Vertex<int> v in list)
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }
        }

        [TestMethod]
        public void TestWeak_2()
        {
            SimpleGraph<int> graph = GetGraphA();
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<Vertex<int>> list = graph.WeakVertices();
            Assert.AreEqual(10, list.Count);

            int count = 0;
            foreach (Vertex<int> v in list)
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }
        }

        [TestMethod]
        public void TestWeak_3()
        {
            SimpleGraph<int> graph = GetGraphD();
            int[] array = new int[] { 1, 2, 3, 4, 7 };

            List<Vertex<int>> list = graph.WeakVertices();
            Assert.AreEqual(5, list.Count);

            int count = 0;
            foreach (Vertex<int> v in list)
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }
        }

        [TestMethod]
        public void TestWeak_4()
        {
            SimpleGraph<int> graph = GetGraphD();
            graph.AddEdge(2, 4);
            int[] array = new int[] {  3, 7 };


            List<Vertex<int>> list = graph.WeakVertices();
            Assert.AreEqual(2, list.Count);

            int count = 0;
            foreach (Vertex<int> v in list)
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }
        }

        [TestMethod]
        public void TestWeak_5()
        {
            SimpleGraph<int> graph = GetGraphD();
            graph.AddEdge(2, 4);
            graph.AddEdge(5, 7);
            
            Assert.AreEqual(0, graph.WeakVertices().Count);
        }

        [TestMethod]
        public void TestWeak_6()
        {
            SimpleGraph<int> graph = GetGraphEdgeless();
            graph.AddEdge(0, 9);
            graph.AddEdge(2, 9);

            Assert.AreEqual(10, graph.WeakVertices().Count);
        }

        [TestMethod]
        public void TestWeak_7()
        {
            SimpleGraph<int> graph = GetGraphEdgeless();
            graph.AddEdge(0, 9);
            graph.AddEdge(0, 5);
            graph.AddEdge(2, 9);
            graph.AddEdge(2, 5);

            Assert.AreEqual(10, graph.WeakVertices().Count);
        }

        [TestMethod]
        public void TestWeak_8()
        {
            SimpleGraph<int> graph = GetGraphEdgeless();
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(3, 4);

            Assert.AreEqual(10, graph.WeakVertices().Count);
        }

        [TestMethod]
        public void TestWeak_9()
        {
            SimpleGraph<int> graph = GetGraphEdgeless();
            graph.AddEdge(0, 1);
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(1, 4);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 4);
            Assert.AreEqual(7, graph.WeakVertices().Count);

            graph.RemoveEdge(0, 1);
            Assert.AreEqual(7, graph.WeakVertices().Count);

            graph.RemoveEdge(2, 3);
            Assert.AreEqual(10, graph.WeakVertices().Count);
        }

        [TestMethod]
        public void TestWeakComb_3_4()
        {
            int[] array = new int[] { 1, 2, 3, 4, 7 };
            SimpleGraph<int> graph = GetGraphD();
            
            int count = 0;
            Assert.AreEqual(5, graph.WeakVertices().Count);
            foreach (Vertex<int> v in graph.WeakVertices())
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }

            graph.AddEdge(2, 4);
            int[] array2 = new int[] { 3, 7 };

            count = 0;
            Assert.AreEqual(2, graph.WeakVertices().Count);
            foreach (Vertex<int> v in graph.WeakVertices())
            {
                Assert.AreEqual(array2[count], v.Value);
                count++;
            }
        }

        [TestMethod]
        public void TestWeakComb_3_4_5()
        {
            int[] array = new int[] { 1, 2, 3, 4, 7 };
            SimpleGraph<int> graph = GetGraphD();

            int count = 0;
            Assert.AreEqual(5, graph.WeakVertices().Count);
            foreach (Vertex<int> v in graph.WeakVertices())
            {
                Assert.AreEqual(array[count], v.Value);
                count++;
            }

            graph.AddEdge(2, 4);
            int[] array2 = new int[] { 3, 7 };

            count = 0;
            Assert.AreEqual(2, graph.WeakVertices().Count);
            foreach (Vertex<int> v in graph.WeakVertices())
            {
                Assert.AreEqual(array2[count], v.Value);
                count++;
            }

            graph.AddEdge(5, 7);
            Assert.AreEqual(0, graph.WeakVertices().Count);
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
         * 4        1   0   0   1   0   1   0   0   0   0
         *      
         * 5        0   0   0   0   1   0   0   0   0   1
         *      
         * 6        0   0   0   0   0   0   0   1   0   1
         *      
         * 7        0   1   0   0   0   0   1   0   0   0
         *      
         * 8        0   0   0   0   0   0   0   0   0   0
         *      
         * 9        0   1   0   0   0   1   1   0   0   0
         */
        private SimpleGraph<int> GetGraphB()
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
            graph.AddEdge(5, 9);
            graph.AddEdge(6, 7);
            graph.AddEdge(6, 9);

            return graph;
        }

        /*
         *          0   1   2   3   4   5   6   7   8   9
         *      
         * 
         * 0        0   0   0   0   0   0   0   0   0   0
         *      
         * 1        0   0   0   0   0   0   0   0   0   0
         *      
         * 2        0   0   0   0   0   0   0   0   0   0
         *      
         * 3        0   0   0   0   0   0   0   0   0   0
         *        
         * 4        0   0   0   0   0   0   0   0   0   0
         *      
         * 5        0   0   0   0   0   0   0   0   0   0
         *      
         * 6        0   0   0   0   0   0   0   0   0   0
         *      
         * 7        0   0   0   0   0   0   0   0   0   0
         *      
         * 8        0   0   0   0   0   0   0   0   0   0
         *      
         * 9        0   0   0   0   0   0   0   0   0   0
         */
        private SimpleGraph<int> GetGraphClear()
        {
            SimpleGraph<int> graph = new SimpleGraph<int>(10);

            return graph;
        }


        /*
         *          0   1   2   3   4   5   6   7   8   9
         *      
         * 
         * 0        0   0   1   0   1   1   0   0   1   0
         *      
         * 1        0   0   1   0   1   0   0   0   0   0
         *      
         * 2        1   1   0   0   0   0   0   0   0   0
         *      
         * 3        0   0   0   0   0   1   0   1   0   0
         *        
         * 4        1   1   0   0   0   0   0   0   0   0
         *      
         * 5        1   0   0   1   0   0   0   0   1   1
         *      
         * 6        0   0   0   0   0   0   0   0   1   1
         *      
         * 7        0   0   0   1   0   0   0   0   0   0
         *      
         * 8        1   0   0   0   0   1   1   0   0   1
         *      
         * 9        0   0   0   0   0   1   1   0   1   0
         */
        private SimpleGraph<int> GetGraphD()
        {
            SimpleGraph<int> graph = GetGraphEdgeless();
            graph.AddEdge(0, 2);
            graph.AddEdge(0, 4);
            graph.AddEdge(0, 5);
            graph.AddEdge(0, 8);

            graph.AddEdge(1, 2);
            graph.AddEdge(1, 4);

            graph.AddEdge(3, 5);
            graph.AddEdge(3, 7);

            graph.AddEdge(5, 8);
            graph.AddEdge(5, 9);

            graph.AddEdge(6, 8);
            graph.AddEdge(6, 9);

            graph.AddEdge(8, 9);

            return graph;
        }


        /*
         *          0   1   2   3   4   5   6   7   8   9
         *      
         * 
         * 0        0   0   0   0   0   0   0   0   0   0
         *      
         * 1        0   0   0   0   0   0   0   0   0   0
         *      
         * 2        0   0   0   0   0   0   0   0   0   0
         *      
         * 3        0   0   0   0   0   0   0   0   0   0
         *        
         * 4        0   0   0   0   0   0   0   0   0   0
         *      
         * 5        0   0   0   0   0   0   0   0   0   0
         *      
         * 6        0   0   0   0   0   0   0   0   0   0
         *      
         * 7        0   0   0   0   0   0   0   0   0   0
         *      
         * 8        0   0   0   0   0   0   0   0   0   0
         *      
         * 9        0   0   0   0   0   0   0   0   0   0
         */
        private SimpleGraph<int> GetGraphEdgeless()
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

            return graph;
        }
    }
}
