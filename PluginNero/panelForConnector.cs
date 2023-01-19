using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackConnector
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            Color baseColorPlacedPayload = Color.DarkGray;//Color.DarkKhaki;
            Random r = new Random();
            HSLColor hslColor = new HSLColor(baseColorPlacedPayload);
            hslColor.Luminosity *= (0.5 + (1.0 * r.NextDouble())); // 0,5 to 1,5
            hslColor.Hue *= (0.5 + (1.0 * r.NextDouble())); // 0,5 to 1,5
            this.getPanel().BackColor = hslColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}
