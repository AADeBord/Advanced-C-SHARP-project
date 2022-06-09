using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleApp
{
    public partial class Schedule : Form
    {
        public Schedule()
        {
            InitializeComponent();
        }
        public Schedule(DataTable data)
        {
            InitializeComponent();
            consultantName.Text = "Schedule";
            DGV.DataSource = data;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
