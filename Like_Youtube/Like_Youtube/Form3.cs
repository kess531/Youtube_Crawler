using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Timers; 

namespace Like_Youtube
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            int x = Screen.PrimaryScreen.WorkingArea.Width - this.Width;   //스크린의 가로위치
            int y = Screen.PrimaryScreen.WorkingArea.Height - this.Height;      //스크린의 세로위치

          
            

            DesktopLocation = new Point(x, y); //폼의 위치 설정
            this.Size = new Size(350, 350);      //폼의 크기 설정

          



            InitializeComponent();
        }
       
        private static System.Timers.Timer TimerEvent; //Timer 개체 생성

        private delegate void OnDelegateHeight(int Flag); //델리게이트 선언
        private OnDelegateHeight OnHeight = null; //델리게이트 개체 생성

        private void Form3_Load(object sender, EventArgs e)
        {
            OnHeight = new OnDelegateHeight(LikeYoutube);
            this.Size = new System.Drawing.Size(350, 0);
            this.Location = new System.Drawing.Point
                (Screen.PrimaryScreen.WorkingArea.Width - this.Width ,
                Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            TimerEvent = new System.Timers.Timer(3);
            
            TimerEvent.Elapsed += new ElapsedEventHandler(OnPopUp);
          
            TimerEvent.Start();
           
        }

        private void LikeYoutube(int Flag)
        {
            if (Flag == 0)
            {     
               
                    Height+= 10; //세로 크기 늘리기
                    Top-= 10; //세로 위치를 올려, 폼을 올리는 효과 
              
            }
            else
            {
                this.Close();
            }
        }

        private void OnPopUp(object sender, ElapsedEventArgs e)
        {
            if (Height < 350)
            {
                Invoke(OnHeight, 0);
            }
            else
            {
                TimerEvent.Stop();
                TimerEvent.Elapsed -= new ElapsedEventHandler(OnPopUp);
               
                TimerEvent.Interval = 3000;
                
               

            }
            Application.DoEvents();
           

        }

        private void btnOpenThumbnail_Click(object sender, EventArgs e)
        {
            this.Visible =false;
            Process.Start(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName
                                            + @"\thum\");
        }

        private void Form3_Leave(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //종료 버튼
        {
  
            
            this.Close();
            TimerEvent.Stop();
            Application.ExitThread();

        }

        // 도움말 버튼 클릭 이벤트
        private void btn_Help_Click(object sender, EventArgs e)
        {
            // 중복 폼 제거 및 폼 생성
            Form form = Application.OpenForms["Form4"];

            if (form != null)
            {
                form.Close();
            }

            Form4 frm4 = new Form4();
            frm4.Show();
        }
    }
}
