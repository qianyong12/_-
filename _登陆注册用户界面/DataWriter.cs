using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _登陆注册用户界面
{
    public class DataWriter
    {
        public bool writeuser(String username, String password)
        {
            Log.Writelog("写入[user.db]数据文件，进行用户注册，用户名：" + username + " 密码：" + password);
            StreamWriter sr = null;
            bool f = false;
            try
            {
                sr = new StreamWriter( "user.db",true);
                sr.BaseStream.Seek(0, SeekOrigin.End);
                sr.WriteLine(username+"="+password);
                f = true;
                Log.Writelog("注册用户成功！");
            }
            catch (Exception)
            {
                Log.Writelog("注册用户时出现错误！");
            }
            finally
            {
                try
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
                catch (Exception e)
                {
                    sr = null;
                    Log.Writelog("注册用户，关闭流出现异常！" + e.Message);
                }
            }
            return f;
        }
    }
}
