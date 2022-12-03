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
    public partial class ucState : UserControl
    {
        public ucState()
        {
            InitializeComponent();
        }

        public States SelectedState
        {
            get
            {
                return (States)cboState.SelectedItem;
            }
        }
        private void ucState_Load(object sender, EventArgs e)
        {
            List<States> list = new List<States>();
            list.Add(new States() { ID=1,Name="farah"});
            list.Add(new States() { ID = 2, Name = "ayman" });
            list.Add(new States() { ID = 3, Name = "moh" });
            list.Add(new States() { ID = 1, Name = "saad" });
            cboState.ValueMember = "ID";
            cboState.DisplayMember = "Name";
          
        }
    }
}
