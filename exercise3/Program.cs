﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node Next;
    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
