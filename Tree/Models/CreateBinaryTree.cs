using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Markiian
{
    public class CreateBinaryTree
    {
        public Node Root { get; set; }

        public CreateBinaryTree()
        {
            this.Root = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (Root == null)
            {
                Root = newNode;
            }
            else
            {
                AddRecursive(Root, newNode);
            }
        }

        private void AddRecursive(Node current, Node newNode)
        {
            if (newNode.Date < current.Date)
            {
                if (current.Left == null)
                {
                    current.Left = current.Left ?? newNode;
                }
                else
                {
                    AddRecursive(current.Left, newNode);
                }
            }
            else
            {
                if (current.Right == null)
                {
                    current.Right = newNode;
                }
                else
                {
                    AddRecursive(current.Right, newNode);
                }
            }
        }
        public void PrintTree()
        {
            PrintTree(Root, 0);
        }
        public string Seria(Node node)
        {
            return JsonConvert.SerializeObject(node, Formatting.Indented);
        }
        public void SaveToFile(string filePath)
        {
            string json = Seria(Root);
            File.WriteAllText(filePath, json);
        }
        public void LoadFromFile(string filePath)
        {
            string json = File.ReadAllText(filePath);
            Root = JsonConvert.DeserializeObject<Node>(json);
        }
        private void PrintTree(Node node, int space)
        {
            if (node == null)
                return;

            space += 5;

            PrintTree(node.Right, space);

            Console.WriteLine();
            for (int i = 5; i < space; i++)
                Console.Write(" ");
            Console.WriteLine(node.Date);

            PrintTree(node.Left, space);
        }
        public Node FindNode(int data)
        {
            return FindNodeRecurseve(Root, data);
        }
        public Node FindNodeRecurseve(Node current, int data)
        {
            if (current == null)
                return null;

            else if(current.Date == data)
                return current;

            else if (current.Date < data)
            {
               return FindNodeRecurseve(current.Right, data);
            }
            else
            {
               return FindNodeRecurseve(current.Left, data);
            }

            
        }
    }
}
