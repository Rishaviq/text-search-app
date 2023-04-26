using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace text_search_app
{
    internal class Node
    {
        public Words data;
        public Node left, right;
        public Node(Words data) {
            this.data = data;
            this.left = null;
            this.right = null;

        }
        public Node() {
        
        
        }

        

    }
}
