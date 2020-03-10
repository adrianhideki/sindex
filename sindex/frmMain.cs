using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace sindex
{
    public partial class frmMain : MetroForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Theme = metroStyleManager.Theme;
            this.Style = metroStyleManager.Style;
        }
    }
}
