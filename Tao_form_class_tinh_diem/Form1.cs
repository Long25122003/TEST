using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tao_form_class_tinh_diem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten, msv;
           /* ten = txthoten.Text;
            msv =;

            txt_hoten.Text = ten;
            txt_msv.Text = msv;*/
           
           if (txtmsv.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                this.Close();
            }  
           
           if (txthoten.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel);
                this.Close();

            }
            if (txtnamsinh.Text =="")
            {
                MessageBox.Show("Yêu Cầu Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel); this.Close();
            }
           if (txta.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel); this.Close();
            }
           if (txtb.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel); this.Close();
            }
            if (txtc.Text == "")
            {
                MessageBox.Show("Yêu Cầu Nhập đủ thông tin", "Thông báo", MessageBoxButtons.OKCancel); this.Close();
            }



            Tinh_DTB s = new Tinh_DTB();
         
          
            s.a = float.Parse(txta.Text);
            s.b = float.Parse(txtb.Text);
            s.c = float.Parse(txtc.Text);
            s.hoten = txthoten.Text;
            txt_hoten.Text = s.hoten;
            s.msv = txtmsv.Text;
            txt_msv.Text = s.msv; 
            txt_diemtb.Text = s.tinhdtb().ToString();
            txt_xl.Text = s.xeploai().ToString();
            txt_dchu.Text = s.diemchu().ToString();
            txt_tl.Text = s.diemtl().ToString();
            



        }

        private void txtmsv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
