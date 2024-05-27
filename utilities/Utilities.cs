using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_Hotelera.utilities
{
    internal class Utilities
    {
        private static Utilities instance;
        public static Utilities getInstance
        {
            get
            {
                if (instance == null)
                    instance = new Utilities();
                return instance;
            }
        }

        public string username { get; set; }

        public void numberValidate(object sender, KeyPressEventArgs e, System.Windows.Forms.TextBox txt)
        {
            string decimalSeparator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar.ToString() != decimalSeparator)
            {
                e.Handled = true;
            }
            else if ((e.KeyChar.ToString() == decimalSeparator) && txt.Text.Contains(decimalSeparator))
            {
                e.Handled = true;
            }
        }
    }
}
