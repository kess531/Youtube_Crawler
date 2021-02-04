using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Like_Youtube
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblExplain.Text = "이런 불필요한 요소를 원하지 않는 사용자를 대상으로" +Environment.NewLine + Environment.NewLine
                + " 기존의 추천 영상 위주의 구조 대신 검색엔진처럼 원하는 " + Environment.NewLine+Environment.NewLine+
                "정보를 직관적이고 최적의 수준에서 제공하는 솔루션을 " + Environment.NewLine + Environment.NewLine +
                "구축한다.";
        }
    }
}
