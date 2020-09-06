using MetroFramework.Components;
using sindex.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sindex.forms
{
    public partial class frmAjuda : Form
    {
        Configuration conf;
        frmMain main;

        public frmAjuda(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            this.main = main;
            this.conf = conf;

            InitializeComponent();
        }
    }
}
