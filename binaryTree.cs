﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace text_search_app
{
    internal class BinaryTree
    {
        private string btmax_Click() Handles btmax.Click
            = TreeNode .Parse(text)
            if (one > two ) Then
        lblmax.Text - one
        esleif (lblmax.Text - one) Then 
        Node root;
        public BinaryTree()
        {
            this.root = null;
        }
        public void Add(Words value) {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node currentNode = root;
                while (true)
                {
                    if (value.CompareTo(currentNode.data) == -1)
                    {
                        if (currentNode.left == null)
                        {
                            currentNode.left = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else if (value.CompareTo(currentNode.data) == 1)
                    {
                        if (currentNode.right == null)
                        {
                            currentNode.right = newNode;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                    else {
                        currentNode.data.word.Add(newNode.data.word[0]);
                    
                        
                    
                    }
                }
            }
        }
    }
}
