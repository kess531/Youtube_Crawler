using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

//20-11-21 , by 민기 - 프로그램 시작 시 로고 폼
namespace Like_Youtube.Properties
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private static System.Timers.Timer TimerEvent;

        private delegate void OnDelegateLogo(int Flag);
        private OnDelegateLogo OnLogo = null;

        private void StartForm_Load(object sender, EventArgs e)
        {
            OnLogo = new OnDelegateLogo(ViewLogo);
            TimerEvent = new System.Timers.Timer(1);
            TimerEvent.Elapsed += new ElapsedEventHandler(OnShow);
            TimerEvent.Start();
        }

        private void ViewLogo(int Flag)
        {
            if (Flag == 0)
            {
                this.Opacity += 0.01;
            }
            else if (Flag == 1)
            {
                this.Opacity -= 0.01;
            }
            else if (Flag == 2)
            {
                this.Close();
            }
        }

        private void OnShow(object sender, ElapsedEventArgs e)
        {
            if (this.Opacity < 1)
            {
                Invoke(OnLogo, 0);
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new ElapsedEventHandler(OnShow);
                TimerEvent.Elapsed += new ElapsedEventHandler(OnHide);
                TimerEvent.Interval = 1000;
                TimerEvent.Start();
            }
            Application.DoEvents();
        }
        private void OnHide(object sender, ElapsedEventArgs e)
        {
            while (this.Opacity > 0)
            {
                Invoke(OnLogo, 1);
            }
            TimerEvent.Stop();
            Application.DoEvents();
            Invoke(OnLogo, 2);
        }
    }
}
