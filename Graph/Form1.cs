using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//Даны N точек, занумерованных числами 1, 2, ..., N. От каждой точки с меньшим номером к каждой точке с большим номером 
//ведет стрелка красного или синего цвета. Раскраска стрелок называется однотонной, если нет двух таких точек A и B, что 
//от A до B можно добраться как только по красным стрелкам, так и только по синим. 
//Ваша задача — по заданной раскраске определить, является ли она однотонной.

namespace Graph
{
    public partial class Form1 : Form
    {
        int[,] graf; //представление графа в виде матрицы
        int num_of_vertex; //число вершин графа
        int red,
            blue; //вероятность цвета в раскраске графа (в процентах)
        int X, Y; //координаты вершины
        Random rnd;
        List<Vertex> mas_vert; //вершины
        List<Line> mas_line; //дуги
        List<Class1> mas_path; //всевозможные пути графа
        Graphics g;
        Pen p;
        public Form1()
        {
            InitializeComponent();
            num_of_vertex = 0;
            red = 0;
            blue = 0;
            rnd = new Random();
            g = img.CreateGraphics();
            p = new Pen(Color.Black, 3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X = 150;
            Y = 0;
            settings w = new settings();
            w.ShowDialog();
            g.Clear(Color.White);
            p.Width = 3;
            p.Color = Color.Black;
            if (w.DialogResult == DialogResult.OK)
                w.get_data(out num_of_vertex, out red, out blue, out graf);
            mas_vert = new List<Vertex>();
            mas_line = new List<Line>();
            mas_path = new List<Class1>();
            for (int i = 0; i < num_of_vertex; i++)
            {
                int er1 = rnd.Next(225) + 10;
                int er2 = rnd.Next(225) + 10;
                //задаем координаты вершины
                X += 500 / num_of_vertex; //масштаб
                Y  = (img.Height / 2) + (er1 - er2);
                //ver = new Vertex(X, Y, i);
                mas_vert.Add(new Vertex(X, Y, i));//ver;
                g.DrawEllipse(p, X, Y, 10, 10); //рисуем вершину
                g.DrawString((i + 1).ToString(), new System.Drawing.Font("Arial Black", 12, FontStyle.Regular, GraphicsUnit.Point), new SolidBrush(Color.Black), new Point(X - 10, Y + 10));
            }
            //int cnt = 0;
            int pos_color = Convert.ToInt16((Convert.ToDouble(num_of_vertex) / 100.000) * red); //определяем долю линий красного цвета
            for (int i = 0; i < num_of_vertex; i++)
                for (int j = 0; j < num_of_vertex; j++)
                    if (graf[i, j] == 1)
                    {
                        //определяем цвет дуги
                        _Color c = _Color.DEFAULT;
                        pos_color = rnd.Next(100) + 1;
                        if (pos_color <= red)
                        {
                            p.Color = Color.Red;
                            c = _Color.RED;
                        }
                        else
                        {
                            p.Color = Color.Blue;
                            c = _Color.BLUE;
                        }
                        p.Width = 1;
                        double angle = Math.Atan2(mas_vert[i].X - mas_vert[j].X, mas_vert[i].Y - mas_vert[j].Y);
                        mas_line.Add(new Line(mas_vert[i].X + 5, mas_vert[i].Y + 5, mas_vert[j].X + 5, mas_vert[j].Y + 5, c));
                        //cnt++;
                        //рисуем линию и "крылья" стрелки
                        g.DrawLine(p, mas_vert[i].X + 5, mas_vert[i].Y + 5, mas_vert[j].X + 5, mas_vert[j].Y + 5);
                        g.DrawLine(p, mas_vert[j].X + 5, mas_vert[j].Y + 5, Convert.ToInt16(mas_vert[j].X + 15 * Math.Sin(angle + Math.PI / 4)), Convert.ToInt16(mas_vert[j].Y + 15 * Math.Cos(angle + Math.PI / 4)));
                        g.DrawLine(p, mas_vert[j].X + 5, mas_vert[j].Y + 5, Convert.ToInt16(mas_vert[j].X + 15 * Math.Sin(angle - Math.PI / 4)), Convert.ToInt16(mas_vert[j].Y + 15 * Math.Cos(angle - Math.PI / 4)));
                    }
            get_all_ways();
            if (check_color())
                st.Text = "Неоднотонная";
            else
                st.Text = "Однотонная";
        }

        //проверка на однотонность.
        //СУТЬ: составляем список всевозможных маршрутов в графе. Для каждого запоминаем точки, через которые он проходит
        //и цвета его линий
        private void get_all_ways()
        {
            //сначала составляем предварительный список из маршрутов, в которых всего 2 точки - потом из них будут составлены
            //болеее сложные маршруты
            int cnt = 0;
                for (int i = 0; i < num_of_vertex - 1; i++)
                    for (int j = 0; j < num_of_vertex; j++)
                        //1 в матрице означает, что между точками есть путь
                        if (graf[i, j] == 1)
                        {
                            Class1 sf = new Class1();
                            //запоминает начальную и конечную точки и цвет линии
                            sf.path.Add(i);
                            sf.path.Add(j);
                            sf.path_color.Add(mas_line[cnt++].color);
                            mas_path.Add(sf);
                        }
            //далее добавляем маршруты, состаящие из 3-х и более точек. Для этого сравниваем полученные простые маршруты
            //друг с другом (обход списка начинаем с конца, идем до первого просмотренного), и если начальная точка одного из них равна конечной точке другого,
            //то создаем из них новый маршрут и добавляем в список
            //
            //так продолжаем до тех пор, пока все маршруты не будут получены
            bool flag = false;
            int oldlen = 0, step = 1;
            while (!flag)
            {
                flag = true; //предполагаем, что маршрутов ббольше нет
                cnt = 0;
                int len = mas_path.Count - 1; //фиксируем длину, т.к. в процессе она может измениться
                //идем от конца списка до первого проверенного элемента, сравниваем эти элементы со всеми в массиве
                for (int i = len; i > oldlen; i--)
                    for (int j = len - 1; j >= 0; j--)
                        //если совпали начальная и конечная точки
                        if (mas_path[i].path[0] == mas_path[j].path[mas_path[j].path.Count - 1])
                        {
                            Class1 sf = new Class1(mas_path[j]);
                            //то добаляем к найденному маршруту те точки, которых в нем нет, и которые есть в конечном
                            for (int _k = mas_path[i].path.Count - step; _k < mas_path[i].path.Count; _k++)
                            {
                                sf.path.Add(mas_path[i].path[_k]);
                                //аналогично с цветами
                                sf.path_color.Add(mas_path[i].path_color[_k - 1]);
                                //MessageBox.Show(_k.ToString(), "DeadCheck");
                            }
                            mas_path.Add(sf);
                            flag = false; //маршрут добавлен
                            cnt++; //число новых добавленных (непроверенных)
                        }
                oldlen = mas_path.Count - cnt - 1; //определяем позицию крайнего проверенного элемента - чтобы
                //не добавить один и тот же маршрут 2 раза
                step++;
            }
            //MessageBox.Show(mas_path.Count.ToString(), "DeadCheck");
            //далее определяем расцветку. Если все цвета в маршруте синие, то значение расцветки будет 1, для красных - 2
            //если разные, то 0
            for (int i = 0; i < mas_path.Count; i++)
            {
                _Color oldcolor = mas_path[i].path_color[0];
                int j = 0;
                while (j < mas_path[i].path_color.Count && mas_path[i].path_color[j] == oldcolor)
                {
                    oldcolor = mas_path[i].path_color[j];
                    j++;
                }
                if (j >= mas_path[i].path_color.Count)
                    switch (oldcolor)
                    {
                        case _Color.BLUE:
                            mas_path[i].colored = 1;
                            break;
                        case _Color.RED:
                            mas_path[i].colored = 2;
                            break;
                    }
                else
                    mas_path[i].colored = 0;

            }
        }

        //Условие на однотонность: если у маршрута одинаковы начальная и конечные точки, а их расцветки различны и одноцветны,
        //то расцветка графа - неоднотонная
        private bool check_color()
        {
            for (int i = 0; i < mas_path.Count - 1; i++)
                for (int j = i; j < mas_path.Count; j++)
                    if (mas_path[i].path[0] == mas_path[j].path[0] && mas_path[i].path[mas_path[i].path.Count - 1] == mas_path[j].path[mas_path[j].path.Count - 1] && mas_path[i].colored != mas_path[j].colored && mas_path[i].colored != 0 && mas_path[j].colored != 0)
                        return true;
            return false;
        }
    }
}
