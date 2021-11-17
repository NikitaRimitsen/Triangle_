using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_Rimitsen
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Run_button_Click(object sender, EventArgs e)//Главная большая кнопка, и в ней расписаны дальнейшие действия(указания)
        {
            listView1.Items.Clear();
            double a, b, c;
            if (txtA.Text == "" || txtB.Text == "" || txtC.Text == "")
            {
                a = b = c = 0;
            }
            else
            {
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);

            }
            
            Triangle triangle = new Triangle(a, b, c);
            listView1.Items.Add("Сторона a");//Начало - Что будет написано в/на listView1
            listView1.Items.Add("Сторона b");
            listView1.Items.Add("Сторона c");
            listView1.Items.Add("Периметр");
            listView1.Items.Add("Площадь");
            listView1.Items.Add("Высота");
            listView1.Items.Add("Средняя линия");
            listView1.Items.Add("Угол a");
            listView1.Items.Add("Существует?");
            listView1.Items.Add("Спецификатор");//Конец - Что будет написано в/на listView1
            listView1.Items[0].SubItems.Add(triangle.outputA());//Начало - - Что будет показываться в/на listView1
            listView1.Items[1].SubItems.Add(triangle.outputB());
            listView1.Items[2].SubItems.Add(triangle.outputC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Vesota()));
            listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Sredanjalinija()));
            listView1.Items[7].SubItems.Add(Convert.ToString(triangle.Ugol()) + "°");
            if (triangle.ExistTriange) { listView1.Items[8].SubItems.Add("Существует"); }
            else listView1.Items[8].SubItems.Add("Не существует");
            listView1.Items[9].SubItems.Add(triangle.TriangleType);
            if (triangle.TriangleType == "Это равносторонний")//если треугольник равносторонний, то будет показана картинка равносторонного треугольника
            {
                pictureBox1.Image = Properties.Resources.ravnosto;
            }
            else if (triangle.TriangleType == "Это равнобедренный")//если треугольник равнобедренный, то будет показана картинка равнобедренного треугольника
            {
                pictureBox1.Image = Properties.Resources.ravno;
            }
            else if (triangle.TriangleType == "Это разносторонний")//если треугольник разносторонний, то будет показана картинка равносторонного треугольника
            {
                pictureBox1.Image = Properties.Resources.raznosto;
            }
            else if (triangle.TriangleType == "Это ломаная")//если треугольник ломаная, то будет показана картинка ломаного треугольника или ломаной линии
            {
                pictureBox1.Image = Properties.Resources.lomanaya;
            }
            else if (triangle.TriangleType == "Нет такого треугольника")
            {

            }
        }   //Конец- Что будет показываться в/на listView1

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            /*My_form frm = new frm My_form();
            frm.Show();*/
        }

        private void Run_button_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        //Тест для чего можно было бы использовать кнопку
        private void Variant1_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = true;
        }

        private void Variants1_Click(object sender, EventArgs e)
        {
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = true;
        }
        //Тест окончен
        private void Run_button_Click2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            My_form frm = new My_form();
            frm.Show();
            this.Hide();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
