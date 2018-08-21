using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber
{
    public partial class Form1 : Form
    {

        private List<string> number;
        private List<string> list;

        public Form1()
        {
            InitializeComponent();


        }
        private void Guess()
        {
            list= new List<string>();
            int A = 0;
            string d = textBox1.Text;
            
            foreach (var item in d)
            {
                list.Add(item.ToString());
            }
            var B = number.Intersect(list).Count();
            for (var i = 0; i < 4; i++)
            {
                if (number[i] == d[i].ToString())
                {
                    A++;
                    B--;
                }
            }
            
            textBox2.Text +=textBox1.Text + ":" + A + "A" + B + "B"+"\r\n";
            if (A == 4 && B == 0)
            {
                MessageBox.Show("過關");
            }
        }

        private void ramdom()
        {
            number = new List<string>();
            Random num = new Random();
            string t = "";
            int count = 0;
            do
            {

                int z = num.Next(1, 10);
                bool result = number.Any((x) => x == z.ToString());
                if (result==false)
                {
                    number.Add(z.ToString());
                    count ++;
                }
            } while (count < 4);

            foreach(var i in number)
            {
                t += i.ToString();
            }

            MessageBox.Show(t);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            button1.Enabled = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ramdom();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Guess();



        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            button1.Enabled = true;
        }
    }
}
