namespace Graph
{
    partial class settings
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.in_vertex = new System.Windows.Forms.TextBox();
            this.in_red = new System.Windows.Forms.TextBox();
            this.in_blue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.view_graph = new System.Windows.Forms.RichTextBox();
            this.build_graph = new System.Windows.Forms.Button();
            this.draw_graf = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // in_vertex
            // 
            this.in_vertex.Location = new System.Drawing.Point(131, 40);
            this.in_vertex.Name = "in_vertex";
            this.in_vertex.Size = new System.Drawing.Size(42, 20);
            this.in_vertex.TabIndex = 0;
            // 
            // in_red
            // 
            this.in_red.Location = new System.Drawing.Point(131, 132);
            this.in_red.Name = "in_red";
            this.in_red.Size = new System.Drawing.Size(42, 20);
            this.in_red.TabIndex = 1;
            this.in_red.TextChanged += new System.EventHandler(this.in_red_TextChanged);
            // 
            // in_blue
            // 
            this.in_blue.Location = new System.Drawing.Point(131, 162);
            this.in_blue.Name = "in_blue";
            this.in_blue.Size = new System.Drawing.Size(42, 20);
            this.in_blue.TabIndex = 2;
            this.in_blue.TextChanged += new System.EventHandler(this.in_blue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Число вершин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Красный:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Синий:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(52, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Раскраска:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(167, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Рисование графа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(232, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "В матричном представлении:";
            // 
            // view_graph
            // 
            this.view_graph.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.view_graph.Location = new System.Drawing.Point(236, 77);
            this.view_graph.Name = "view_graph";
            this.view_graph.ReadOnly = true;
            this.view_graph.Size = new System.Drawing.Size(232, 181);
            this.view_graph.TabIndex = 9;
            this.view_graph.Text = "";
            // 
            // build_graph
            // 
            this.build_graph.Location = new System.Drawing.Point(236, 272);
            this.build_graph.Name = "build_graph";
            this.build_graph.Size = new System.Drawing.Size(126, 23);
            this.build_graph.TabIndex = 10;
            this.build_graph.Text = "Задать граф";
            this.build_graph.UseVisualStyleBackColor = true;
            this.build_graph.Click += new System.EventHandler(this.build_graph_Click);
            // 
            // draw_graf
            // 
            this.draw_graf.Location = new System.Drawing.Point(380, 272);
            this.draw_graf.Name = "draw_graf";
            this.draw_graf.Size = new System.Drawing.Size(75, 23);
            this.draw_graf.TabIndex = 11;
            this.draw_graf.Text = "DRAW!";
            this.draw_graf.UseVisualStyleBackColor = true;
            this.draw_graf.Click += new System.EventHandler(this.draw_graf_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.in_blue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.in_red);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.in_vertex);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 204);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры графа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(179, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(179, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "%";
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.draw_graf);
            this.Controls.Add(this.build_graph);
            this.Controls.Add(this.view_graph);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "settings";
            this.Text = "settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox in_vertex;
        private System.Windows.Forms.TextBox in_red;
        private System.Windows.Forms.TextBox in_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox view_graph;
        private System.Windows.Forms.Button build_graph;
        private System.Windows.Forms.Button draw_graf;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}