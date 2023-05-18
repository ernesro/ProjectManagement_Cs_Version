using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Project_Management._02aplication.objects
{
    public static class WindowStyler
    {
        public static void ApplyCustomStyle(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.BackColor = Color.LightSalmon;
            form.MinimumSize = form.Size;
            form.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
