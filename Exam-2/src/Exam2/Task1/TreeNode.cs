using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class TreeNode<T>
    {
        public T? NodeValue { get; set; }
        public TreeNode<T>? LeftChild { get; set; }
        public TreeNode<T>? RightChild { get; set; }

        public TreeNode(T inputValue)
        {
            NodeValue = inputValue;
            LeftChild = null;
            RightChild = null;
        }
    }
}
