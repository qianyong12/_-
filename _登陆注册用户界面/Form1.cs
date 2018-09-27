using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _登陆注册用户界面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
              
        private void button1_Click(object sender, EventArgs e)
        {
              String str1;
              String str2;
            DataAccessor sp1 = new DataAccessor();            
            str1 = textBox1.ToString();           
            str2 = textBox2.ToString();
            bool flag1 = sp1.checkuser(str1, str2);
            if (flag1)
            {
                MessageBox.Show("登陆成功！");
            }
            else
            {
                MessageBox.Show("登陆失败！");
            }           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            fr2.Show();           
        }
    }
}
