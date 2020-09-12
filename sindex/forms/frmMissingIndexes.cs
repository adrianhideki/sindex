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
    public partial class frmMissingIndexes : Form
    {
        Configuration conf;
        frmMain main;

        public frmMissingIndexes(MetroStyleManager metroStyleManager, Configuration conf, frmMain main)
        {
            this.main = main;
            this.conf = conf;

            InitializeComponent();

            this.metroStyleManager.Theme = metroStyleManager.Theme;
            this.metroStyleManager.Style = metroStyleManager.Style;
        }
    }
}
