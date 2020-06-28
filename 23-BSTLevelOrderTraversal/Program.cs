using System;
using System.Collections;
using System.Collections.Generic;

namespace BSTLevelOrderTraversal
{
    class Program
    {
        static void levelOrder(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                Node tempNode = queue.Dequeue();
                Console.Write(tempNode.data + " ");

                if (tempNode.left != null)
                {
                    queue.Enqueue(tempNode.left);
                }
                if(tempNode.right != null)
                {
                    queue.Enqueue(tempNode.right);
                }
            }
        }
    }
}
