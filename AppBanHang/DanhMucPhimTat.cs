using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBanHang
{
    public partial class DanhMucPhimTat : Form
    {
        public DanhMucPhimTat()
        {
            InitializeComponent();
        }

 

        private void DanhMucPhimTat_Load(object sender, EventArgs e)
        {

        }

        private void DanhMucPhimTat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home)
            {
                this.Close();
            }
        }
    }
}
