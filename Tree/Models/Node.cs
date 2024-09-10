using System.Security.Cryptography.X509Certificates;

namespace Markiian
{
    public class Node
    {
        public int Date { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data) 
        {
            this.Date = data;
            this.Left = null;
            this.Right = null;
        }
        public void LeafofBrench()
        {
            if (Left == null && Right == null)
            {
                Console.WriteLine("This is a leaf");
            }
            else
            {
                Console.WriteLine("This is a branch");
            }
        }
    }
}
