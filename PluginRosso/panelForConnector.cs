using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RedConnector
{
    public partial class panelForConnector : UserControl
    {
        public panelForConnector()
        {
            InitializeComponent();
        }
        public System.Windows.Forms.Panel getPanel()
        {
            return panel1;
        }

        private void PanelForConnector_Load(object sender, EventArgs e)
        {

        }
    }


}
