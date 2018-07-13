using LiquorLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiquorReports
{
    public partial class LiquorReport : Form
    {
        private List<LiquorModel> selectedDate = new List<LiquorModel>();

        public LiquorReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            LiquorModel l = new LiquorModel();

            l.CreateStartDate = startTimeText.Text;
            l.CreateEndDate = createEndDate.Text;
        }
    }
}
