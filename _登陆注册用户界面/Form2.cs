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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str1;
            String str2;
            DataWriter sp2 = new DataWriter();           
            str1 = this.textBox1.ToString();
            str2 = this.textBox2.ToString();
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            bool flag2 = sp2.writeuser(str1, str2);
            if (flag2)
            {
                MessageBox.Show("注册成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败！");
                this.Close();
            }
        }
    }
}
