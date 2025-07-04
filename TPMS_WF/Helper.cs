using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPMS_WF
{
    public static class Helper
    {
        public static void ExInvoke(this Control control, Action act)
        {
            if (control?.InvokeRequired == true)
                control.Invoke(act);
            else
                act();
        }
    }
}
