using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoBatSuKien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Bắt sự kiện textbox Username và Password bỏ trống.
            //if(user.Text.Length == 0 && pass.Text.Length == 0)
            //{
            //    MessageBox.Show("Username và password không được bỏ trống");
            //}
            //else
            //{
            //    MessageBox.Show("Thành công!");
            //}

            //Bắt sự kiện username và password không đúng
            if(user.Text == "admin" && pass.Text =="123")
            {
                MessageBox.Show("Tài khoản đúng");
            } else
            {
                MessageBox.Show("Tài khoản không đúng");
            }
        }
    }
}
