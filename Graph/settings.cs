using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph
{
    public partial class settings : Form
    {
        private int[,] graf = null;
        Random rnd;
        public settings()
        {
            InitializeComponent();
            rnd = new Random();
        }

        public void get_data(out int _num_of_vertex, out int _red, out int _blue, out int[,] _graf)
        {
            _num_of_vertex = 0;
            _red = 0;
            _blue = 0;
            _graf = null;
            _num_of_vertex = Convert.ToInt16(in_vertex.Text);
            _red = Convert.ToInt16(in_red.Text);
            _blue = Convert.ToInt16(in_blue.Text);
            _graf = graf;
            this.DialogResult = DialogResult.OK;
        }

        private void build_graph_Click(object sender, EventArgs e)
        {
            int i, j;
            try
            {
                int num_of_vertex = Convert.ToInt16(in_vertex.Text);
                if (num_of_vertex <= 0)
                    throw new ArgumentNullException("Вершина");
                view_graph.AppendText(num_of_vertex.ToString());
                graf = new int[num_of_vertex, num_of_vertex];
                for (i = 0; i < num_of_vertex; i++)
                {
                    for (j = 0; j < num_of_vertex; j++)
                    {
                        if (i >= j)
                            graf[i, j] = 0;
                        else
                            graf[i, j] = rnd.Next(2);
                    }
                }

                //проверяем граф на связи - все вершины должны быть в связке
                for (j = 0; j < num_of_vertex; j++)
                {
                    bool flag = false;
                    for (i = 0; i < j; i++)
                        if (graf[i, j] != 0)
                            flag = true;
                    if (!flag && i > 0)
                        graf[i - 1, j] = 1; //если вершина не связана, то связываем ее с предыдущей по номеру
                }

                //вывод графа в текстбокс
                view_graph.Clear();
                for (i = 0; i < num_of_vertex; i++)
                {
                    for (j = 0; j < num_of_vertex; j++)
                        view_graph.AppendText(graf[i, j].ToString());
                    view_graph.AppendText("\n");
                }
            }
            catch
            {
                MessageBox.Show("Неверно задано число вершин", "Ошибка");
            }
        }

        private void draw_graf_Click(object sender, EventArgs e)
        {
            int _num_of_vertex = 0,
                _red = 0,
                _blue = 0;
            int[,] _graf = null;
            try
            {
                if (graf == null)
                    throw new ArgumentNullException("Граф не задан");
                _num_of_vertex = Convert.ToInt16(in_vertex.Text);
                _red = Convert.ToInt16(in_red.Text);
                _blue = Convert.ToInt16(in_blue.Text);
                _graf = graf;
                if (_num_of_vertex < 0 || _red < 0 || _blue < 0)
                    throw new ArgumentNullException("Параметры графа");
                this.DialogResult = DialogResult.OK;
            }
            catch
            {
                MessageBox.Show("Неверно задан один из параметров, либо не задан граф", "Ошибка");
            }            
        }

        private void in_blue_TextChanged(object sender, EventArgs e)
        {
            if (in_blue.Text == "-" || in_blue.Text == "")
                in_blue.Text = "0";
            else
            {
                if (Convert.ToInt16(in_blue.Text) > 100 || Convert.ToInt16(in_blue.Text) < 0)
                    in_blue.Text = "100";
                in_red.Text = (100 - Convert.ToInt16(in_blue.Text)).ToString();
            }
        }

        private void in_red_TextChanged(object sender, EventArgs e)
        {
            if (in_red.Text == "-" || in_red.Text == "")
                in_red.Text = "0";
            else
            {
                if (Convert.ToInt16(in_red.Text) > 100)
                    in_red.Text = "100";
                in_blue.Text = (100 - Convert.ToInt16(in_red.Text)).ToString();
            }
        }
    }
}
