using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Class1
    {
        public List<int> path;
        public List<_Color> path_color;
        public int colored;
        public Class1()
        {
            path = new List<int>();
            path_color = new List<_Color>();
            colored = 0;
        }
        public Class1(Class1 _other)
        {
            path = new List<int>();
            path_color = new List<_Color>();
            for (int i = 0; i < _other.path.Count; i++)
                path.Add(_other.path[i]);
            for (int i = 0; i < _other.path_color.Count; i++)
                path_color.Add(_other.path_color[i]);
        }
    }
}
