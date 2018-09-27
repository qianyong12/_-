using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _用户信息的输入输出流
{
    class Program
    {
        static void Main(string[] args)
        {
           
            String str1;
            String str2;
            String str;
            Console.WriteLine("欢迎登陆WHU系统");
            Console.WriteLine("登陆或注册");
            str=Console.ReadLine();
            switch (str)
            {
                case "登陆":
                    DataAccessor sp1 = new DataAccessor();
                    Console.WriteLine("请输入用户名：");
                    str1 = Console.ReadLine();
                    Console.WriteLine("请输入密码：");
                    str2 = Console.ReadLine();
                    bool flag1 = sp1.checkuser(str1, str2);
                    if (flag1)
                    {
                        Console.WriteLine("登陆成功！");
                    }
                    else
                    {
                        Console.WriteLine("登陆失败！");
                    }
                    Console.ReadKey();
                    break;
                case "注册":
                    DataWriter sp2 = new DataWriter();
                    Console.WriteLine("请输入用户名：");
                    str1 = Console.ReadLine();
                    Console.WriteLine("请输入密码：");
                    str2 = Console.ReadLine();
                    bool flag2 = sp2.writeuser(str1, str2);
                    if (flag2)
                    {
                        Console.WriteLine("注册成功！");
                    }
                    else
                    {
                        Console.WriteLine("注册失败！");
                    }
                    Console.ReadKey();
                    break;
            }
            }
    }
}
