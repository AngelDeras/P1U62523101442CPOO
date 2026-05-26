using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1U62523101442CPOO
{
    public static class NotepadMode
    {
        public static void SetDarkMode(Control control)
        {
            control.BackColor = Color.Black;
            control.ForeColor = Color.White;
        }

        public static void SetLightMode(Control control)
        {
            control.BackColor = Color.White;
            control.ForeColor = Color.Black;
        }
    }
}
