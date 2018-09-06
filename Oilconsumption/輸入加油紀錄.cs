using Oilconsumption.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oilconsumption
{
    public partial class 輸入加油紀錄 : Form
    {
        public 輸入加油紀錄()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OilTable data = new OilTable()
            {
                 RefuelingDate = dateTimePicker1.Value,
                 Liter = (double)numericUpDown1.Value,
                 Kilometer = (double)numericUpDown2.Value,

            };
            try
            {
                OilModel context = new OilModel();
                context.OilTable.Add(data);
                context.SaveChanges();
                MessageBox.Show("存檔完成");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤{ex.ToString()}");
            }
        }
        private void Clear()
        {
            numericUpDown1.Value=0;
            numericUpDown2.Value = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
