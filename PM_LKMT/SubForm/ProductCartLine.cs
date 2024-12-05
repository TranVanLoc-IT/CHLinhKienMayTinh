using BLL;
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
        private ConvertMoneyUnitBLL _unit;
        public decimal _giaBan = 0;
        public ProductCartLine()
        {
            InitializeComponent();
            _unit = new ConvertMoneyUnitBLL();

        }

        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            if (quantity.Value > 0)
            {
                price.Text = _unit.ConvertToVND(_giaBan * quantity.Value);
            }

        }
    }
}
