using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_forms_prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                const double Pi = 3.1415;
                double R, h, S_bichne, S_krigiv, S_zagalne;
                R = double.Parse(textBox1.Text);
                h = double.Parse(textBox2.Text);
                S_bichne = 2 * Pi * R * h;
                S_krigiv = 2 * Pi * R * R;
                S_zagalne = S_bichne + S_krigiv;
                label2.Text = "Площа бокової поверхні циліндра = "+ S_bichne.ToString()+ "см2" ;
                label4.Text = "Площа верхньої та нижньої поверхонь = " + S_krigiv.ToString()+ "см2";
                label5.Text = "Загальна площа циліндра = " + S_zagalne.ToString()+ "см2";

            }
            catch (FormatException ex)
            {
                label2.Text = "Помилка- " + ex.Message;

            }




            }
    }
}
