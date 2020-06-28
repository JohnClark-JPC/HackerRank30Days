using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            static int getHeight(Node root)
            {
                if (root == null)
                {
                    return -1;
                }
                else
                {
                    int leftDepth = getHeight(root.left);
                    int rightDepth = getHeight(root.right);

                    if (leftDepth > rightDepth)
                    {
                        return leftDepth + 1;
                    }
                    else
                    {
                        return rightDepth + 1;
                    }
                }
            }
        }
    }
}
