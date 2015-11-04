using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Vertex
    {
        public readonly int X, Y; //координаты вершины
        public readonly int number; //порядковый номер вершины
        public Vertex()
        {
            X = 0;
            Y = 0;
            number = 0;
        }
        public Vertex(int _X, int _Y, int _number)
        {
            X = _X;
            Y = _Y;
            number = _number;
        }
    }
}
