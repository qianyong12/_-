using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _登陆注册用户界面
{
    public class Log
    {
        static String fname = "logfile.log";
        static FileInfo finfo = new FileInfo(fname);
        public static void Writelog(String logstr)
        {
            if (finfo.Exists && finfo.Length > 2048 * 1024)
            {
                finfo.Delete();
            }
            using (FileStream fs = finfo.OpenWrite())
            {
                StreamWriter w = new StreamWriter(fs);
                w.BaseStream.Seek(0, SeekOrigin.End);
                w.Write("\nLog Entry:");
                w.Write("{0}{1} \r\n", DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
                w.Write(logstr + "\r\n");
                w.Flush();
                w.Close();

            }
        }
    }
}
