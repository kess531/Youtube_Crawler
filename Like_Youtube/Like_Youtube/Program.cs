using Like_Youtube.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Like_Youtube
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //20-11-21 민기 - 기본폼 출력이전에 시작폼 시작
            Application.Run(new StartForm());
            ////20-11-21 민기 - 기본폼 할당 후 시작
            Form1 form = new Form1();
            Application.Run(form);
        }
    }
}
