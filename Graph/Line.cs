using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    enum _Color 
    {
        RED,
        BLUE,
        DEFAULT
    }
    class Line
    {
        public readonly int X1, Y1; //координаты начала дуги
        public readonly int X2, Y2; //координаты конца дуги
        public readonly _Color color; //цвет дуги 
        public Line()
        {
            X1 = Y1 = 0;
            X2 = Y2 = 0;
            color = _Color.DEFAULT;
        }
        public Line(int _X1, int _Y1, int _X2, int _Y2, _Color _color)
        {
            X1 = _X1;
            Y1 = _Y1;
            X2 = _X2;
            Y2 = _Y2;
            color = _color;
        }
    }
}
