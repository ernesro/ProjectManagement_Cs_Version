using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Management._02aplication.objects
{
    internal static class Alert
    {
        public static void ErrorAlert(string error = "Error when performing the operation") 
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void SuccesAlert()
        {
            MessageBox.Show("Operación realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
