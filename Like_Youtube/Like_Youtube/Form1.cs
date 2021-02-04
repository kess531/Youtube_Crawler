using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Google.Apis.YouTube.v3.Data;
using System.IO;
using System.Net;
//using System.Security.Policy;

namespace Like_Youtube
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            // 로드 시 검색창에 포커스를 맞춰줌
            this.txtSearch.Focus();

            // 검색 필터 초기값 설정
            this.cbOrder.SelectedIndex = 0;
            this.cbDivision.SelectedIndex = 0;
            this.cbVideoType.SelectedIndex = 0;
            this.cbLength.SelectedIndex = 0;

            // 리스트박스 로드 시 안보임 설정
            this.lbLog.Visible = false;

            // 패널 초기값 설정
            this.pnFilter.Visible = false;

            panel1.Visible = false;

            // NotifyIcon에 메뉴 추가
            ContextMenu ctx = new ContextMenu();
            ctx.MenuItems.Add(new MenuItem("열기"));

            ctx.MenuItems.Add("-");

            ctx.MenuItems.Add(new MenuItem("종료", new EventHandler((s, ex) => Application.ExitThread())));
            notifyIcon1.ContextMenu = ctx;



            // 20-11-18 폼 중복 실행 방지
            int cnt = 0;
            Process[] procs = Process.GetProcesses();
            foreach (Process p in procs)
            {
                if (p.ProcessName.Equals("Like_Youtube") == true)
                    cnt++;
            }
            if (cnt > 1)
            {
                MessageBox.Show("이미 실행중입니다");
              this.Dispose();
                return;
            }
        }

        //20-11-12 검색타입 저장을 위한 전역변수 선언
        string searchType = "";

        // 20-11-05
        // 버튼서치 클릭 이벤트
        private void btnSearch_ClickAsync(object sender, EventArgs e)
        {
           
            //검색 버튼을 누를 때마다 결과창 초기화
            lvResult.Items.Clear();

            Search();

            // lbLog 리스트박스 닫기
            if (this.lbLog.Visible == true)
            {
                this.lbLog.Visible = false;
            }
        }
        // 20-11-04
        // 검색창이 비어있는지 검사하여 True와 False 반환
        private bool TextCheck()
        {
            if (this.txtSearch.Text != "")
            {
                return true;
            }
            else
                return false;
        }
        
        // 20-11-04
        // ListView 한 개의 아이템을 더블클릭 했을 때의 이벤트
        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems.Count > 0)
            {

                //YouTube 비디오 Play를 위한 URL 생성
                if (this.cbDivision.SelectedIndex == 0)
                {
                    string videoId = lvResult.SelectedItems[0].Name;
                    string youtubeUrl = "http://youtube.com/watch?v=" + videoId;
                    
                    // 디폴트 브라우져에서 실행
                    Process.Start(youtubeUrl);
                }
                else if(this.cbDivision.SelectedIndex == 1)
                {
                    string channelId = lvResult.SelectedItems[0].Name;
                    string youtubeUrl = "https://www.youtube.com/channel/" + channelId;

                    // 디폴트 브라우져에서 실행
                    Process.Start(youtubeUrl);
                }
                else if(this.cbDivision.SelectedIndex == 2)
                {
                    string playlistlId = lvResult.SelectedItems[0].Name;
                    string youtubeUrl = "https://www.youtube.com/playlist?list=" + playlistlId;

                    // 디폴트 브라우져에서 실행
                    Process.Start(youtubeUrl);
                }
                

                
            }
        }

        // 20-11-05
        // 엔터키가 눌렸을 때 검색을 해주는 메서드
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) //엔터키를 누를 때
            {
                e.Handled = true; // 소리 없앰

                // 20-11-05
                // 엔터를 누를 때마다 결과창 초기화
                lvResult.Items.Clear();

                Search();

                // lbLog 리스트박스 닫기
                if (this.lbLog.Visible == true)
                {
                    this.lbLog.Visible = false;
                }
            }
        }


        // 20-11-04
        // 유튜브 검색 메서드
        private async void Search()
        {
            var youtube = new YouTubeService(new BaseClientService.Initializer()
            {
                
                //유튜브 Data Api를 쓰기 위해 필요한 API 키 지정
                ApiKey = "키를 바꾸어주세요.",
                ApplicationName = "Youtube Search"
            });

            
            //Search용 Request 생성
            var request = youtube.Search.List("snippet");
            request.Q = txtSearch.Text; //ex : "코끼리"
            request.MaxResults = 2;

            if (this.cbDivision.SelectedIndex == 0)
            {
                // 비디오 검색
                request.Type = "video";
                searchType = "video";

                // 정렬
                switch (this.cbOrder.SelectedIndex)
                {
                    case 0:
                        // 관련성
                        request.Order = SearchResource.ListRequest.OrderEnum.Relevance;
                        break;
                    case 1:
                        // 조회수
                        request.Order = SearchResource.ListRequest.OrderEnum.ViewCount;
                        break;
                    case 2:
                        //날짜별로 역순
                        request.Order = SearchResource.ListRequest.OrderEnum.Date;
                        break;
                }
                
               

                // 동영상 타입별 필터
                switch (this.cbVideoType.SelectedIndex)
                {
                    case 0:
                        request.VideoType = SearchResource.ListRequest.VideoTypeEnum.Any;
                        break;
                    case 1:
                        request.VideoType = SearchResource.ListRequest.VideoTypeEnum.Episode;
                        break;
                    case 2:
                        request.VideoType = SearchResource.ListRequest.VideoTypeEnum.Movie;
                        break;
                }
                
                

                // 동영상 길이별 필터
                switch (this.cbLength.SelectedIndex)
                {

                    case 0:
                        request.VideoDuration = SearchResource.ListRequest.VideoDurationEnum.Any;
                        break;
                    case 1:
                        request.VideoDuration = SearchResource.ListRequest.VideoDurationEnum.Short__;
                        break;
                    case 2:
                        request.VideoDuration = SearchResource.ListRequest.VideoDurationEnum.Long__;
                        break;
                }
                 
            }
            else if (this.cbDivision.SelectedIndex == 1)
            {
                // 채널 검색
                request.Type = "channel";
                searchType = "channel";

                // 관련성, 조회순, 날짜별로 정렬
                if (cbOrder.SelectedIndex == 0)
                {
                    // 관련성
                    request.Order = SearchResource.ListRequest.OrderEnum.Relevance;
                }
                else if (cbOrder.SelectedIndex == 1)
                {
                    // 조회수
                    request.Order = SearchResource.ListRequest.OrderEnum.ViewCount;
                }
                else if (cbOrder.SelectedIndex == 2)
                {
                    //날짜별로 역순
                    request.Order = SearchResource.ListRequest.OrderEnum.Date;
                }

            }
            else if(this.cbDivision.SelectedIndex == 2)
            {
                // 플레이리스트 검색
                request.Type = "playlist";
                searchType = "playlist";

                // 관련성, 조회순, 날짜별로 정렬
                if (cbOrder.SelectedIndex == 0)
                {
                    // 관련성
                    request.Order = SearchResource.ListRequest.OrderEnum.Relevance;
                }
                else if (cbOrder.SelectedIndex == 1)
                {
                    // 조회수
                    request.Order = SearchResource.ListRequest.OrderEnum.ViewCount;
                }
                else if (cbOrder.SelectedIndex == 2)
                {
                    //날짜별로 역순
                    request.Order = SearchResource.ListRequest.OrderEnum.Date;
                }
            }
 

            //Search용 Request 실행
            var result = await request.ExecuteAsync();


            if (TextCheck() == true)
            {
                foreach (var item in result.Items)
                {   
                    switch (item.Id.Kind)
                    {
                        case "youtube#video" :
                            lvResult.Items.Add(item.Id.VideoId.ToString(), item.Snippet.Title, 0);
                            break;
                        case "youtube#channel":
                            lvResult.Items.Add(item.Id.ChannelId.ToString(), item.Snippet.ChannelTitle, 1);
                            break;
                        case "youtube#playlist":
                            lvResult.Items.Add(item.Id.PlaylistId.ToString(), item.Snippet.Title, 2);
                            break;
                    }
                }

                // 리스트박스에 검색목록 추가
                this.lbLog.Items.Add(this.txtSearch.Text);
            }
        }  
        
        
            
        

        // 20-11-09
        // 마우스 클릭 시 lbLog 리스트박스 보임/안보임 여부 판단
        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.lbLog.Visible == false)
            {
                this.lbLog.Visible = true;
            }
            else
            {
                this.lbLog.Visible = false;
            }
        }

        // 20-11-09
        // 폼 클릭 이벤트
        private void Form1_Click(object sender, EventArgs e)
        {
            if(this.lbLog.Visible == true)
            {
                this.lbLog.Visible = false;
            }

            if(this.pnFilter.Visible == true)
            {
                this.pnFilter.Visible = false;
            }
        }

        // 20-11-09
        // lbLog 리스트박스 더블클릭 이벤트
        private void lbLog_DoubleClick(object sender, EventArgs e)
        {
            this.txtSearch.Text = this.lbLog.SelectedItem.ToString();
            this.txtSearch.Focus();
        }

        //20-11-12
        //List View 한 개의 아이템을 클릭했을 때의 이벤트
        private async void lvResult_Click(object sender, EventArgs e)
        {
            var youtube = new YouTubeService(new BaseClientService.Initializer()
            {
                ApiKey = "키를 바꾸어주세요.",
                ApplicationName = "ThumNail Image"
            });

            if (lvResult.SelectedItems.Count > 0)
            {
                string contentId = lvResult.SelectedItems[0].Name;
                string thumUrl = "";

                if (searchType == "video")
                {
                    var request = youtube.Videos.List("snippet, statistics");
                    request.Id = contentId;
                    request.MaxResults = 1;

                    var result = await request.ExecuteAsync();

                    foreach (var item in result.Items)
                    {
                        thumUrl = item.Snippet.Thumbnails.High.Url;
                        lbContentName.Text = "제목 : ";
                        lbContentNameValue.Text = item.Snippet.Title;
                        lbContentViewCount.Text = "조회수 : ";
                        lbContentViewCountValue.Text = item.Statistics.ViewCount.ToString();
                        lbLikeCountValue.Text = item.Statistics.LikeCount.ToString();
                        lbDislikeCountValue.Text = item.Statistics.DislikeCount.ToString();
                        lbContentDescription.Text = item.Snippet.Description;
                    }

                }
                if (searchType == "channel")
                {
                    var request = youtube.Channels.List("snippet, statistics");
                    request.Id = contentId;
                    request.MaxResults = 1;

                    var result = await request.ExecuteAsync();

                    foreach (var item in result.Items)
                    {
                        thumUrl = item.Snippet.Thumbnails.High.Url;
                        lbContentName.Text = "채널명 : ";
                        lbContentNameValue.Text = item.Snippet.Title;
                        lbContentViewCount.Text = "구독자수 : ";
                        lbContentViewCountValue.Text = item.Statistics.SubscriberCount.ToString();
                        lbLikeCount.Visible = false; lbLikeCountValue.Visible = false;
                        lbDislikeCount.Visible = false; lbDislikeCountValue.Visible = false;
                        lbContentDescription.Text = item.Snippet.Description;
                    }
                }
                if (searchType == "playlist")
                {
                    var request = youtube.Playlists.List("snippet, ContentDetails");
                    request.Id = contentId;
                    request.MaxResults = 1;

                    var result = await request.ExecuteAsync();

                    foreach (var item in result.Items)
                    {
                        thumUrl = item.Snippet.Thumbnails.High.Url;
                        lbContentName.Text = "재생목록명 : ";
                        lbContentNameValue.Text = item.Snippet.Title;
                        lbContentViewCount.Text = "동영상수 : ";
                        lbContentViewCountValue.Text = item.ContentDetails.ItemCount.ToString();
                        lbLikeCount.Visible = false; lbLikeCountValue.Visible = false;
                        lbDislikeCount.Visible = false; lbDislikeCountValue.Visible = false;
                        lbContentDescription.Text = item.Snippet.Description;
                    }
                }

                string thumjpg = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName
                                            + @"\thum\" + contentId + ".jpg";
                FileInfo fileInfo = new FileInfo(thumjpg);

                if (fileInfo.Exists == false)
                {
                    DownloadRemoteImageFile(thumUrl, thumjpg);
                }
                picThumbnails.Load(thumjpg);
                picThumbnails.SizeMode = PictureBoxSizeMode.StretchImage;

                panel1.Visible = true;
                panel1.Focus();
            }

        }

        //20-11-11
        //Url의 이미지를 특정 경로에 저장해주는 메소드
        private bool DownloadRemoteImageFile(string uri, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            bool bImage = response.ContentType.StartsWith("image",
                StringComparison.OrdinalIgnoreCase);

            

            if ((response.StatusCode == HttpStatusCode.OK ||
                response.StatusCode == HttpStatusCode.Moved ||
                response.StatusCode == HttpStatusCode.Redirect) &&
                bImage)
            {
                using (Stream inputStream = response.GetResponseStream())

                using (Stream outputStream = File.OpenWrite(fileName))
                {
                    byte[] buffer = new byte[4096];
                    int bytesRead;
                    do
                    {
                        bytesRead = inputStream.Read(buffer, 0, buffer.Length);

                        outputStream.Write(buffer, 0, bytesRead);

                    }
                    while (bytesRead != 0);
                }

                return true;
            }
            else
            {
                return false;
            }
        }


        // 20-11-11
        // cbdivision 인덱스 변경 시 이벤트
        private void cbDivision_SelectedIndexChanged(object sender, EventArgs e)
        {
          if(this.cbDivision.SelectedIndex == 0)
            {
                this.cbVideoType.Visible = true;
                this.lblVideoType.Visible = true;
                this.cbLength.Visible = true;
                this.lblLength.Visible = true;
            }
          else if (this.cbDivision.SelectedIndex == 1)
            {
                this.cbVideoType.Visible = false;
                this.lblVideoType.Visible = false;
                this.cbLength.Visible = false;
                this.lblLength.Visible = false;
            }
          else if (this.cbDivision.SelectedIndex == 2)
            {
                this.cbVideoType.Visible = false;
                this.lblVideoType.Visible = false;
                this.cbLength.Visible = false;
                this.lblLength.Visible = false;
            }
        }

        // 20-11-11
        // 버튼 클릭 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            if(this.pnFilter.Visible == false)
            {
                this.pnFilter.Visible = true;
            }
            else
            {
                this.pnFilter.Visible = false;
            }
        }


    

       


        // 20-11-13
        // 클릭 시 다른 폼에서 보기
        private void lvResult_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (this.lvResult.SelectedItems.Count == 0)
                    MessageBox.Show("아이템을 선택하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    Form2 frm2 = new Form2();
                    if (this.cbDivision.SelectedIndex == 0)
                    {
                        string videoId2 = lvResult.SelectedItems[0].Name;
                        string youtubeUrl2 = "http://youtube.com/watch?v=" + videoId2;
                        frm2.SetWebUrl = youtubeUrl2;
                    }
                    else if (this.cbDivision.SelectedIndex == 1)
                    {
                        string channelId2 = lvResult.SelectedItems[0].Name;
                        string youtubeUrl2 = "https://www.youtube.com/channel/" + channelId2;
                        frm2.SetWebUrl = youtubeUrl2;

                    }
                    else if (this.cbDivision.SelectedIndex == 2)
                    {
                        string playlistlId2 = lvResult.SelectedItems[0].Name;
                        string youtubeUrl2 = "https://www.youtube.com/playlist?list=" + playlistlId2;
                        frm2.SetWebUrl = youtubeUrl2;
                    }
                    frm2.Show();
                }
            }
        }

        ////20-11-14  미리보기 패널 비활성화 시 패널 가림 이벤트
        private void panel1_Leave(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


        // 20-11-15
        // 아이콘 더블클릭 시 폼 화면을 보여줌
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // 아이콘을 더블클릭하면 폼 화면을 보여줌
            if (this.WindowState == FormWindowState.Minimized || this.Visible == false)
            {
                this.WindowState = FormWindowState.Normal;
                this.Visible = true; 
            }
            this.Activate();

        }

     

        private void VisibleChane(bool bVisible, bool bIconVisble)
        {
            this.Visible = bVisible; //폼 Visible 속성 변경
            this.notifyIcon1.Visible = bIconVisble; //트레이 아이콘 Visible 속성변경
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChane(false, true);
          
        }

     
       
        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            // 20-11-16
            //모달리스 중복 방지
            Form form =Application.OpenForms["Form3"];
           
           if(form !=null)
            {
                form.Close();
            }

            Form3 frm3 = new Form3();
            frm3.Show();

        }

    
    }
}
