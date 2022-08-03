using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace AppBanHang
{
    public partial class Login : Form
    {
        BLLLogin Log = new BLLLogin();

        public Login()
        {
            InitializeComponent();

        }


        private void LoginFunction(string u, string p)
        {
            DataTable logc = Log.Login(u,p);
            if (logc.Rows.Count > 0)
            {
                string CapQuyen = logc.Rows[0][0].ToString();
                string ten = logc.Rows[0][1].ToString();
                string TK = logc.Rows[0][2].ToString();
                string maNV = logc.Rows[0][3].ToString();
                switch (CapQuyen)
                {
                    case "1":
                        UI.ManagerUI M = new UI.ManagerUI();
                        M.Ten.Text = "Chào " + ten;
                        M.TK.Text = "Tài Khoản " + TK;
                        M.Show();
                        this.Visible = false;
                        break;
                    case "2":
                        UI.KeToanUI K = new UI.KeToanUI();
                        K.Ten.Text = "Chào " + ten;
                        K.TK.Text = "Tài Khoản " + TK;
                        K.Show();
                        this.Visible = false;
                        break;
                    case "3":
                        UI.KhoUI KHO = new UI.KhoUI();
                        KHO.Ten.Text = "Chào " + ten;
                        KHO.TK.Text = "Tài Khoản " + TK;
                        KHO.Show();
                        this.Visible = false;
                        break;
                    case "4":
                        UI.NVUI NV = new UI.NVUI();
                        NV.Ten.Text = "Chào " + ten;
                        NV.TK.Text = "Tài Khoản " + TK;
                        NV.Show();
                        this.Visible = false;
                        break;
                }

                Program.user = maNV;
                Program.userlevel = CapQuyen;

            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập");
            }

        }
        private void loginBTN_Click(object sender, EventArgs e)
        {
            if(autologTB.Checked == true)
            {
                Log.AutoLogin(userTB.Text);
            }
            else
            {
                Log.AutoLogin("");
            }
            LoginFunction(userTB.Text, passTB.Text);
            
        }

        private void Login_Load(object sender, EventArgs e)
        {


            this.Shown += new EventHandler(Login_Shown);
        }

        private void Login_Shown(Object sender, EventArgs e)
        {
            DataTable autolog = Log.CheckAutoLogin();

            if (autolog.Rows.Count > 0)
            {
                string u = autolog.Rows[0][0].ToString();
                string p = autolog.Rows[0][1].ToString();
                LoginFunction(u, p);

            }
        }
    }
}
