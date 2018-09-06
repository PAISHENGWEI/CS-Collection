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
    public partial class InquiryForm2 : Form
    {
        public InquiryForm2()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime start = dateTimePicker1.Value;
            DateTime end = dateTimePicker2.Value;
            var context = new OilModel();
            var list = context.OilTable.ToList();
            var time = list.Where((x) => x.RefuelingDate >= start && x.RefuelingDate <=end).ToList();
            
            dataGridView1.DataSource = time;
            var KMax = time.Max(x => x.Kilometer);
            var KMin = time.Min(x => x.Kilometer);
            var LMax = time.Max(x => x.Liter);
            var LMin = time.Min(x => x.Liter);
            var average = ((KMax - KMin) / (LMax- LMin));

            label4.Text = average.ToString();



        }
    }
}
