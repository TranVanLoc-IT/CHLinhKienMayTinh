using PM_LKMT.Controls;
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
    public partial class ViewDetails : Form
    {
        public ViewDetails(ProductDetails detail)
        {
            InitializeComponent();
            detail.Dock = DockStyle.Fill;
            this.Size = detail.Size;
            this.Controls.Add(detail);
            detail.Disposed += Detail_Disposed;
        }

        private void Detail_Disposed(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
