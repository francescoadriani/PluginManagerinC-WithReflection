using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualConnectors;

namespace PluginManager
{
    public partial class Form1 : Form
    {
        VirtualConnector connector = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRefresh.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connector != null)
                connector.execCommand();
        }

        private void cmbPlugin_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Type> typeOnCombo = VirtualConnectors.VirtualConnectors.getTypeConnectors();
            if (cmbPlugin.SelectedIndex >= 0)
            {
                Type type = null;
                foreach (Type t in typeOnCombo)
                    if (t.Name.ToString() == cmbPlugin.SelectedItem.ToString())
                        type = t;
                connector = (VirtualConnector)Activator.CreateInstance(type);
            }
            if (connector != null)
            {
                lblTitolo.Text = connector.getTitle();
                pnlContainer.Controls.Clear();
                pnlContainer.Controls.Add(connector.getSettingsPanel());
                connector.getSettingsPanel().Dock = DockStyle.Fill;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            cmbPlugin.Items.Clear();
            List<Type> typeOnCombo = VirtualConnectors.VirtualConnectors.getTypeConnectors();
            foreach (Type t in typeOnCombo)
            {
                cmbPlugin.Items.Add(t.Name);
            }
            if (cmbPlugin.SelectedIndex == -1 && cmbPlugin.Items.Count > 0)
                cmbPlugin.SelectedIndex = 0;
        }
    }
}
