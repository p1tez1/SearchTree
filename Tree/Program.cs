
using System;
namespace Markiian
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateBinaryTree tree = new CreateBinaryTree();

            Console.WriteLine("In-Order Traversal:\n");
            string FilePath = @"D:\Programing\C#\Tree\BinaryTree.json";
            tree.LoadFromFile(FilePath);
            Console.WriteLine("Binary tree loaded from file:");
            tree.PrintTree();
            Console.WriteLine("Enter a number to check:");
            int number = int.Parse(Console.ReadLine());
            Node node = tree.FindNode(number);
            if (node != null)
            {
                node.LeafofBrench();
            }
            else
            {
                Console.WriteLine($"{number} not found in the tree.");
            }
        }
    }
}