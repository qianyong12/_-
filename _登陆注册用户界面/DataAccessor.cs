using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _登陆注册用户界面
{
    public class DataAccessor
    {
        public bool checkuser(String username, String password)
        {
            Log.Writelog("读取[user.db]数据文件，进行用户登陆验证，用户名：" + username + " 密码：" + password);
            StreamReader sr = null;
            bool f = false;
            try
            {
                sr = new StreamReader("user.db");
                while (sr.Peek() > 0)
                 {
                    String line = sr.ReadLine();
                    if (line != null)
                    {
                        String[] tokens = line.Trim().Split('=');
                        if (tokens.Length == 2 && username != null && password != null)
                        {
                            tokens[0] = tokens[0].Trim();
                            tokens[1] = tokens[1].Trim();
                            if (username.Equals(tokens[0]) && password.Equals(tokens[1]))
                            {
                                f = true;
                                Log.Writelog("验证用户登陆成功！");
                            }                                     
                        }
                    }
               }
                                  if(f==false)
                              Log.Writelog("验证用户登陆失败！");
            }
            catch (Exception)
            {
                Log.Writelog("验证用户登陆出现错误！");

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
                    Log.Writelog("验证用户登陆，关闭流出现异常！" + e.Message);
                }
                }
            return f;
            }
        }
    }
