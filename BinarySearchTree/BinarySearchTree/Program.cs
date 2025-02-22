﻿using System;

namespace BinarySearchTree
{
    class Program
    {
        public class Node
        {
            public int key;
            public Node left, right;

            public Node(int item)
            {
                key = item;
                left = right = null;
            }
        }

        // Root of BST
        Node root;

        // Constructor
        Program()
        {
            root = null;
        }

        // This method mainly calls insertRec()
        void insert(int key)
        {
            root = insertRec(root, key);
        }

        // A recursive function to insert
        // a new key in BST
        Node insertRec(Node root, int key)
        {

            // If the tree is empty,
            // return a new node
            if (root == null)
            {
                root = new Node(key);
                return root;
            }

            // Otherwise, recur down the tree
            if (key < root.key)
                root.left = insertRec(root.left, key);
            else if (key > root.key)
                root.right = insertRec(root.right, key);

            // Return the (unchanged) node pointer
            return root;
        }

        // This method mainly calls InorderRec()
        void inorder()
        {
            inorderRec(root);
        }

        // A utility function to
        // do inorder traversal of BST
        void inorderRec(Node root)
        {
            if (root != null)
            {
                inorderRec(root.left);
                Console.WriteLine(root.key);
                inorderRec(root.right);
            }
        }

        // Driver Code
        public static void Main(String[] args)
        {
            Program tree = new Program();
            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            // Print inorder traversal of the BST
            tree.inorder();
        }
    }
}
    
    

