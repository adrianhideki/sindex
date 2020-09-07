using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;

namespace sindex.utils
{
    public static class metroFunctions
    {
        public static DialogResult ShowMessage(IWin32Window parent, string message, string title, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return MetroMessageBox.Show(parent, message, title, buttons, icon);
        }
    }
}
