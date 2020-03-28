using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electro_Calk_2
{
    public partial class Form1 : Form
    {
        double I, R, U, P,sum_1,sum_2,R1, R2,U_in,U_out, R1_inc,R2_inc,U_in_inc,P_div;
        bool flag_sum,flag_sum_2,  chek_I, chek_R, chek_U, chek_P,chek_R1,chek_R2,chek_U_in;

       

        public Form1()
        {
            InitializeComponent();

            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "*Допустимо до заповнення лише два поля.";
            label13info.Text = "*Введіть данні в поля U вхідна, R1 та R2.";

        }


        private void tabPage2_MouseEnter(object sender, EventArgs e)
        {
           
        }


        private void trackBar4R2_MouseEnter(object sender, EventArgs e)
        {
           
        }

        private void trackBar3R1_MouseEnter(object sender, EventArgs e)
        {
           
        }
        private void trackBar1Uin_MouseEnter(object sender, EventArgs e)
        {
            
        }


        private void textBox5_Uin_Enter(object sender, EventArgs e)
        {
            if (flag_sum_2)
            {
                textBox6R1.Text = "";
                textBox7R2.Text = "";
                textBox5_Uin.Text = "";
                textBox5.Text = "";
                label6.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label13.Text = "";
                trackBar3R1.Value = 0;
                trackBar4R2.Value = 0;
                trackBar1Uin.Value = 0;
                flag_sum_2 = false;
            }
        }

        private void textBox6R1_Enter(object sender, EventArgs e)
        {
            if (flag_sum_2)
            {
                textBox6R1.Text = "";
                textBox7R2.Text = "";
                textBox5_Uin.Text = "";
                textBox5.Text = "";
                label6.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label13.Text = "";
                trackBar3R1.Value = 0;
                trackBar4R2.Value = 0;
                trackBar1Uin.Value = 0;
                flag_sum_2 = false;
            }
        }

        private void textBox7R2_Enter(object sender, EventArgs e)
        {
            if (flag_sum_2)
            {
                textBox6R1.Text = "";
                textBox7R2.Text = "";
                textBox5_Uin.Text = "";
                textBox5.Text = "";
                label6.Text = "";
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label13.Text = "";
                trackBar3R1.Value = 0;
                trackBar4R2.Value = 0;
                trackBar1Uin.Value = 0;

                flag_sum_2 = false;
            }
        }








        private void textBox5_Uin_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox6R1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox7R2_TextChanged(object sender, EventArgs e)
        {
         
        }




       


        private void trackBar3R1_Scroll(object sender, EventArgs e)
        {
            R1_inc = R1 + (trackBar3R1.Value * 10);
            textBox6R1.Text = R1_inc.ToString();
            label6.Text = textBox6R1.Text + "Ом";
            textBox5.Text = "";
            label11.Text = "";
            label13.Text = "";


        }

        private void trackBar4R2_Scroll(object sender, EventArgs e)
        {
            R2_inc = R2 + (trackBar4R2.Value * 10);
            textBox7R2.Text = R2_inc.ToString();
            label9.Text = textBox7R2.Text + "Ом";
            textBox5.Text = "";
            label11.Text = "";
            label13.Text = "";
        }



        private void trackBar1Uin_Scroll(object sender, EventArgs e)
        {
            U_in_inc = U_in + trackBar1Uin.Value;
            textBox5_Uin.Text = U_in_inc.ToString();
            label10.Text = textBox5_Uin.Text + "В";
            textBox5.Text = "";
            label11.Text = "";
            label13.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!(textBox5_Uin.Text == "") && !(textBox6R1.Text == "") && !(textBox7R2.Text == ""))
            {

                chek_R1 = double.TryParse(textBox6R1.Text, out R1);
                chek_R2 = double.TryParse(textBox7R2.Text, out R2);
                chek_U_in = double.TryParse(textBox5_Uin.Text, out U_in);





                if (chek_R1 && chek_R2 && chek_U_in)
                {
                    if (U_in < 0 || R1 < 0 || R2 < 0)
                    {
                        label13info.Text = "Не коректні вхідні данні.";

                        label6.Text = "!!!";
                        label9.Text = "!!!";
                        label10.Text = "!!!";
                        flag_sum_2 = true;

                    }
                    else
                    {
                        label6.Text = textBox6R1.Text + "Ом";
                        label9.Text = textBox7R2.Text + "Ом";
                        label10.Text = textBox5_Uin.Text + " В.";

                        U_out = R2 * (U_in / (R1 + R2));
                        textBox5.Text = U_out.ToString("F2") + " В.";
                        label11.Text = U_out.ToString("F2") + " В.";
                        P_div = ((U_in* U_in) / (R1 + R2));
                        label13.Text = "P= " + P_div.ToString("F3") + " Вт.";
                        flag_sum_2 = true;
                    }


                }
                else
                {
                    label13info.Text = "Не коректні вхідні данні.";

                    label6.Text =  "!!!";
                    label9.Text = "!!!";
                    label10.Text = "!!!";
                    flag_sum_2 = true;
                }


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {


           


          
           




        }





        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (flag_sum == false)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                richTextBox1.Text = "*Допустимо до заповнення лише два поля.";
                flag_sum = true;
            }
            
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (flag_sum == false)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                richTextBox1.Text = "*Допустимо до заповнення лише два поля.";
                flag_sum = true;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (flag_sum == false)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                richTextBox1.Text = "*Допустимо до заповнення лише два поля.";
                flag_sum = true;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (flag_sum == false)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                richTextBox1.Text = "*Допустимо до заповнення лише два поля.";
                flag_sum = true;
            }
        }

        // chek_I = double.TryParse(textBox1.Text, out I);
        // chek_R = double.TryParse(textBox2.Text, out R);
        // chek_U = double.TryParse(textBox3.Text, out U);
        //  chek_P = double.TryParse(textBox4.Text, out P);



        private void button1_Click(object sender, EventArgs e)
        {


            


            if (textBox1.Text == "" && textBox2.Text == "")
            {
               
                chek_U = double.TryParse(textBox3.Text, out U);
                chek_P = double.TryParse(textBox4.Text, out P);

                if (chek_U && chek_P) 
                {
                    sum_1 = (U * U) / P;
                    sum_2 = (P / U);
                    textBox1.Text = sum_2.ToString();//////////////////////////////////////1
                    textBox2.Text = sum_1.ToString();
                    flag_sum = false;
                   

                }
                else
                {
                    flag_sum = false;
                    richTextBox1.Text = "Помилка вхідних данних.\nСпробуйте замінити крапку на кому.";
                }

            }






            if (textBox1.Text == "" && textBox3.Text == "")
            {
                chek_R = double.TryParse(textBox2.Text, out R);
                chek_P = double.TryParse(textBox4.Text, out P);
                if (chek_R && chek_P)
                { 
                    sum_1= Math.Sqrt(P / R);
                    sum_2= Math.Sqrt(P * R);

                    textBox1.Text = sum_1.ToString();//////////////////////////////////////2
                    textBox3.Text = sum_2.ToString();
                    flag_sum = false;
                   

                }
                else
                {
                    flag_sum = false;
                    richTextBox1.Text = "Помилка вхідних данних.\nСпробуйте замінити крапку на кому.";
                }
            }
            






            if (textBox1.Text == "" && textBox4.Text == "" )
            {               
                chek_R = double.TryParse(textBox2.Text, out R);
                chek_U = double.TryParse(textBox3.Text, out U);               
                if (chek_U && chek_R)
                {
                    sum_1 = U / R;
                    sum_2 = (U * U) / R;


                    textBox1.Text = sum_1.ToString();////////////////////////////////////////////////3
                    textBox4.Text = sum_2.ToString();
                    flag_sum = false;
                    
                }
                else
                {
                    flag_sum = false;
                    richTextBox1.Text = "Помилка вхідних данних.\nСпробуйте замінити крапку на кому.";
                }
            }
           





            if (textBox2.Text == "" && textBox3.Text == "")
            {
                chek_I = double.TryParse(textBox1.Text, out I);               
                chek_P = double.TryParse(textBox4.Text, out P);
                if (chek_P && chek_I)
                {
                    sum_1 = P / (I * I);
                    sum_2 = P / I;

                    textBox2.Text = sum_1.ToString();///////////////////////////////////////////////4
                    textBox3.Text = sum_2.ToString();
                    flag_sum = false;
                   
                }
                else
                {
                    flag_sum = false;
                    richTextBox1.Text = "Помилка вхідних данних.\nСпробуйте замінити крапку на кому.";
                }
            }
           





            if (textBox2.Text == "" && textBox4.Text == "")
            {
                chek_I = double.TryParse(textBox1.Text, out I);
                chek_U = double.TryParse(textBox3.Text, out U);

                if (chek_U && chek_I)
                {
                    sum_1 = U/I ;
                    sum_2 = U*I ;

                    textBox2.Text = sum_1.ToString();/////////////////////////////////////////////////////////5
                    textBox4.Text = sum_2.ToString();
                    flag_sum = false;
                    
                }
                else
                {
                    flag_sum = false;
                    richTextBox1.Text = "Помилка вхідних данних.\nСпробуйте замінити крапку на кому.";
                }
            }
            
           





            if (textBox3.Text == "" && textBox4.Text == "")
            {
                chek_I = double.TryParse(textBox1.Text, out I);
                chek_R = double.TryParse(textBox2.Text, out R);

                if (chek_R && chek_I)
                {
                    sum_1 = R * I;
                    sum_2 = R * (I * I);


                    textBox3.Text = sum_1.ToString();///////////////////////////////////////////////////////////6
                    textBox4.Text = sum_2.ToString();
                    flag_sum = false;
                    
                }
                else
                {
                    flag_sum = false;
                    richTextBox1.Text = "Помилка вхідних данних.\nСпробуйте замінити крапку на кому.";
                }
            }
          







        }


    }
}
