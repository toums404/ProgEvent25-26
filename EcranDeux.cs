using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgEvent25_26
{
    public partial class EcranDeux : Form
    {
        public EcranDeux()
        {
            InitializeComponent();
        }

        private void EcranDeux_Load(object sender, EventArgs e)
        {

        }

        private void EcranDeux_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Fermeture de la fenêtre EcranDeux");
            Application.Exit();
        }
    }
}
