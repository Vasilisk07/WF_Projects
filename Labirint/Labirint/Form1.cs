using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{


    public partial class Form1 : Form
    {
        string Rang;
        int m, s, Score = 100;
        int Sec_05 = 0;
        public Form1()
        {
            InitializeComponent();
            timer2.Interval = 500;
            timer1.Interval = 1000;
            m = 00;
            s = 00;
            



        }

        

        private void Form1_Load(object sender, EventArgs e)//zagruzka
        {
            
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
            label72.Text = "00";
            label73.Text = "00";
            richTextBox1.Text = "\nСуть гри- перенести курсор з поля SART до поля FINISH, не доторкнувшись його вiстрям до стiнок лабiринта.\n" +
                "Все це потрiбно зробити за вiдведений час, а саме: 1хв.40сек. В рерультатi по завершенню гри буде нарахована певна кiлькысть очок " +
                "та буде присвоєно один iз 9 можливих рангiв.\n" +
                "Отож удачі Вам, та твердої руки!!!";



        }


        private void label1_MouseEnter(object sender, EventArgs e)//stenka
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)//major panel enter
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            richTextBox1.Visible=false;
            


        }
        private void Form1_MouseEnter(object sender, EventArgs e)//   major form enter
        {

        }
        private void label57_MouseEnter(object sender, EventArgs e)//finish
        {
            timer1.Enabled = false;
            timer2.Enabled = false;           
            if (Score > 0 && Score <= 10) { Rang = "Тремтяча рука."; }
            if (Score > 10 && Score <= 20) { Rang = "Я просто на ноутбуці i без мишки."; }
            if (Score > 20 && Score <= 30) { Rang = "Впертий і наполегливий."; }
            if (Score > 30 && Score <= 40) { Rang = "Швидкий кабанчик."; }
            if (Score > 40 && Score <= 50) { Rang = "Учень джедая."; }
            if (Score > 50 && Score <= 60) { Rang = "Найшвидша рука дикого заходу."; }
            if (Score > 60 && Score <= 70) { Rang = "Король лабіринта."; }
            if (Score > 70) { Rang = "Хитрий жук."; }

            var result = MessageBox.Show("Вiтаю Ви пройшли лабiринт!!!\nВаш рейтинг: " + Score.ToString() +"\nВаш ранг: "+Rang+ "\nЗiграєм ще?", "Labirint", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                Close();
            }
            if (result == DialogResult.Yes)
            {
                Score = 100;
                m = 0;
                s = 0;
                label72.Text = "00";
                label73.Text = "00";
                Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
                timer1.Enabled = false;
                timer2.Enabled = false;
                label75.Visible = true;
            }

        }

        private void label68_Click(object sender, EventArgs e)
        {
            label63.Text = Cursor.Position.ToString();
        }

        private void label63_MouseEnter(object sender, EventArgs e)///            Kontur
        {
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
        }
        //u////////////////////////////////////////////////////////////////////////////////////////////////////
        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)///////////////////////////////////////////////////////////////////timer       
        {

            
            Score--;
            s++;
            textBox1.Text = "Рейтинг: "+ Score;
            if (s > 59)
            {
                m++;
                s = 0;
            }
            if (m > 59)
            {
                m = 0;
                s = 0;
            }

            if (s%2==0)
            {
                label47.Visible = false;
            }
            else 
            {
                label47.Visible = true;
            }

            if (m < 10)
            {

                label72.Text = "0" + m.ToString();
            }
            else
            {
                label72.Text = m.ToString();
            }


            if (s < 10)
            {

                label73.Text = "0" + s.ToString();
            }
            else
            {
                label73.Text = s.ToString();
            }

            if (Score==0)
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                Score = 0;
                var result = MessageBox.Show("Надто довго....\nЦе програш.  \nВаш ранг: Черепаха Джо." + "\nЗiграэм ще?", "Labirint", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.No)
                {
                    Close();
                }
                if (result == DialogResult.Yes)
                {
                    Score = 100;
                    m = 0;
                    s = 0;
                    label72.Text = "00";
                    label73.Text = "00";
                    Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    label75.Visible = true;
                }
               



            }
        }

        private void timer2_Tick(object sender, EventArgs e)//timer2 500
        {
            
            Sec_05++;
            if (Sec_05 % 2 == 0)
            {
                label74.Visible = false;
                label60.Visible = true;
                label54.Visible = false;
            }
            else
            {
                label54.Visible = true;
                label74.Visible = true;
                label60.Visible = false;
            }
            if (Sec_05>10)
            {
                Sec_05 = 0;
            }



        }

        private void button1_Click(object sender, EventArgs e)//zanovo
        {
            Score = 100;
            m = 0;
            s = 0;
            label72.Text = "00";
            label73.Text = "00";
            Cursor.Position = new Point(this.Location.X + 55, this.Location.Y + 60);
            timer1.Enabled = false;
            timer2.Enabled = false;
            label75.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)//exit
        {
            Close();
        }

        private void label75_MouseEnter(object sender, EventArgs e)
        {
            int bonus;
            bonus = Score + 20;
            Score = bonus;
            label75.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        


    }  
}
