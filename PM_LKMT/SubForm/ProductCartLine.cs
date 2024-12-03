using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PM_LKMT.SubForm
{
    public partial class ProductCartLine : UserControl
    {
        public ProductCartLine()
        {
            InitializeComponent();
        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            price.Text = (decimal.Parse(price.Text.Substring(0, price.Text.Length - 4)) * quantity.Value).ToString();

        }
    }
}
