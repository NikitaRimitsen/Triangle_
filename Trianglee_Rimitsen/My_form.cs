using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Triangle_Rimitsen
{
    public partial class My_form : Form
    {
        public My_form()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            double a, h;

            if (txtA2.Text == "" || txtH.Text == "")
            {
                a = h = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA2.Text);
                h = Convert.ToDouble(txtH.Text);
            }
            Triangle triangle = new Triangle(a, h);
            listView2.Items.Add("Сторона A");//Начало - Что будет написано в/на listView1
            listView2.Items.Add("Сторона H");
            listView2.Items.Add("Средняя линия");
            listView2.Items.Add("Площадь");
            
            listView2.Items[0].SubItems.Add(triangle.outputA());//Начало - - Что будет показываться в/на listView1
            listView2.Items[1].SubItems.Add(triangle.outputH());
            listView2.Items[2].SubItems.Add(Convert.ToString(triangle.Sredanjalinija()));
            listView2.Items[3].SubItems.Add(Convert.ToString(triangle.Surface_Ploshad()));

            TextBoxHistory.Paste("Треугольник — геометрическая фигура, образованная тремя отрезками, которые соединяют три точки, не лежащие на одной прямой. Указанные три точки называются вершинами треугольника, а отрезки — сторонами треугольника.");
        }

        private void My_form_Load(object sender, EventArgs e)
        {

        }

        private void Run_button_Click2(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
