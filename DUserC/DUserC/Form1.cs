using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DUserC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetState_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("State id = {0}, name = {1}", ucState1.SelectedState.ID, ucState1.SelectedState.Name),"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
