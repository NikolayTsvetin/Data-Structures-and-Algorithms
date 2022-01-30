using Microsoft.VisualStudio.TestTools.UnitTesting;
using BinarySearchTree;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTreeTests
{
    [TestClass]
    public class BinarySearchTreeTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void OnCreationTreeMustBeEmpty()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();

            binarySearchTree.GetRoot();
        }

        [TestMethod]
        public void MustAddDataCorrectly()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            int expectedRootValue = 10;
            int expectedLeftChildValue = 5;
            int expectedRightChildValue = 15;

            binarySearchTree.Add(expectedRootValue);
            binarySearchTree.Add(expectedLeftChildValue);
            binarySearchTree.Add(expectedRightChildValue);

            Assert.AreEqual(expectedRootValue, binarySearchTree.GetRoot().Data);
            Assert.AreEqual(expectedLeftChildValue, binarySearchTree.GetRoot().Left.Data);
            Assert.AreEqual(expectedRightChildValue, binarySearchTree.GetRoot().Right.Data);
        }

        [TestMethod]
        public void ValidateExistenceOfData()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            int expectedRootValue = 10;
            int expectedLeftChildValue = 5;
            int expectedRightChildValue = 15;

            binarySearchTree.Add(expectedRootValue);
            binarySearchTree.Add(expectedLeftChildValue);
            binarySearchTree.Add(expectedRightChildValue);

            Assert.AreEqual(true, binarySearchTree.Exists(5));
            Assert.AreEqual(false, binarySearchTree.Exists(45));
        }

        [TestMethod]
        public void TreeMustFindData()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            int expectedRootValue = 10;
            int expectedLeftChildValue = 5;
            int expectedRightChildValue = 15;

            binarySearchTree.Add(expectedRootValue);
            binarySearchTree.Add(expectedLeftChildValue);
            binarySearchTree.Add(expectedRightChildValue);

            Node<int> found = binarySearchTree.Find(5);

            Assert.AreEqual(expectedLeftChildValue, found.Data);
        }

        [TestMethod]
        public void TreeMustFindCorrectDepth()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(5);
            binarySearchTree.Add(3);
            binarySearchTree.Add(10);
            binarySearchTree.Add(25);

            int depth = binarySearchTree.GetDepth();

            Assert.AreEqual(3, depth);
        }

        [TestMethod]
        public void GetLeafNodesMustCollectOnlyLeaves()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(5);
            binarySearchTree.Add(3);
            binarySearchTree.Add(10);
            binarySearchTree.Add(25);

            List<int> expectedValues = new List<int>() { 3, 10, 25 };
            List<int> leafs = binarySearchTree.GetLeafNodes().Select(x => x.Data).ToList();

            bool areEqual = Enumerable.SequenceEqual(expectedValues, leafs);
            Assert.AreEqual(true, areEqual);
        }
    }
}