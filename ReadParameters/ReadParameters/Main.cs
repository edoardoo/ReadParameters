using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadParameters {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
        }

        private void reaedParams_Click(object sender, EventArgs e) {
            Flash readParamsWindow = new Flash();
            readParamsWindow.ShowDialog();
            
        }

        private void quit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void aboutButton_Click(object sender, EventArgs e) {
            About aboutWindow = new About();
            aboutWindow.ShowDialog();
        }
    }
}
