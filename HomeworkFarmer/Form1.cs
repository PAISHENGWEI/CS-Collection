using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeworkFarmer
{
    public partial class Form1 : Form
    {
        private List<string> Leftlist;
        private List<string> Rightlist;

        public Form1()
        {
            InitializeComponent();
            CreateList();
            SetListBoxDatasource();
            ChangeData();

        }
        private void CreateList()
        {
            Leftlist = new List<string>
            {
                "Farmer","Sheep","Wolf","Vegetable"
            };
            Rightlist = new List<string>();
        }
        private void SetListBoxDatasource()
        {
            listBox1.SelectionMode = SelectionMode.One;
            listBox2.SelectionMode = SelectionMode.One;
        }
        private void ChangeData()
        {
            listBox1.DataSource = null;
            listBox2.DataSource = null;
            listBox1.DataSource = Leftlist;
            listBox2.DataSource = Rightlist;


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem !=null )//選到的東西是不是null
            {
                if(Leftlist.Contains("Farmer"))
                {
                    string item = (string)listBox1.SelectedItem;//把listBox1裡選擇的項目以String存進item
                    if (item == "Farmer")
                    {
                        Leftlist.Remove(item);
                        Rightlist.Add(item);
                    }
                    else
                    {
                        Leftlist.Remove(item);
                        Leftlist.Remove("Farmer");
                        Rightlist.Add(item);
                        Rightlist.Add("Farmer");
                    }                   
                    ChangeData();
                    if (Leftlist.Contains("Sheep") && Leftlist.Contains("Wolf")
                        && Rightlist.Contains("Farmer")) 
                    {
                        MessageBox.Show("Sheep is eaten by Wolf");
                        CreateList();
                        ChangeData();
                    }
                    if (Leftlist.Contains("Sheep") && Leftlist.Contains("Vegetable")
                        && Rightlist.Contains("Farmer"))
                    {
                        MessageBox.Show("Vegetable is eaten by Sheep");
                        CreateList();
                        ChangeData();
                    }
                   
                }
                
                if (Rightlist.Contains("Farmer") && Rightlist.Contains("Sheep")
                      && Rightlist.Contains("Wolf") && Rightlist.Contains("Vegetable"))
                 {
                    MessageBox.Show("YOU WIN");           
                }
               

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if(listBox2.SelectedItem != null)
            {
                if(Rightlist.Contains("Farmer"))//Contains有沒有Farmer
                {
                    
                    string item = (string)listBox2.SelectedItem;//把listBox2裡選擇的項目以String存進item。
                    if (item == "Farmer")//判斷是不是Farmer
                    {
                        Rightlist.Remove(item);
                        Leftlist.Add(item);
                    }
                    else
                    {
                        Rightlist.Remove("Farmer");
                        Rightlist.Remove(item);
                        Leftlist.Add("Farmer");
                        Leftlist.Add(item);
                    }
                }             
                ChangeData();

                if (Rightlist.Contains("Sheep") && Rightlist.Contains("Wolf")
                    && Leftlist.Contains("Farmer"))
                {
                    MessageBox.Show("Sheep is eaten by Wolf");
                   CreateList(); 
                   ChangeData();
                }
               
                
                if (Rightlist.Contains("Sheep") && Rightlist.Contains("Vegetable") 
                    && Leftlist.Contains("Farmer"))
                {
                    MessageBox.Show("Vegetable is eaten by Sheep");
                    CreateList();
                    ChangeData();
                }
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateList();
            ChangeData();
        }
       
    }
}
