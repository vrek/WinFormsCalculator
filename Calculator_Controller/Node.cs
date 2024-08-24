using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Controller
{
    public class Node <T>
    {
        public string? Data { get; set; }
        public Node<T>? Next { get; internal set; }
        public Node(string data) => this.Data = data;
    }
}
