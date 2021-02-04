namespace Like_Youtube
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.searchIcon = new System.Windows.Forms.ImageList(this.components);
            this.lvResult = new System.Windows.Forms.ListView();
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chChannel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smImgList = new System.Windows.Forms.ImageList(this.components);
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.pnFilter = new System.Windows.Forms.Panel();
            this.lblLength = new System.Windows.Forms.Label();
            this.cbLength = new System.Windows.Forms.ComboBox();
            this.lblVideoType = new System.Windows.Forms.Label();
            this.cbVideoType = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.cbDivision = new System.Windows.Forms.ComboBox();
            this.filterIcon = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbContentDescription = new System.Windows.Forms.Label();
            this.lbContentNameValue = new System.Windows.Forms.Label();
            this.lbContentViewCountValue = new System.Windows.Forms.Label();
            this.lbLikeCountValue = new System.Windows.Forms.Label();
            this.lbDislikeCountValue = new System.Windows.Forms.Label();
            this.lbDislikeCount = new System.Windows.Forms.Label();
            this.lbLikeCount = new System.Windows.Forms.Label();
            this.lbContentViewCount = new System.Windows.Forms.Label();
            this.lbContentName = new System.Windows.Forms.Label();
            this.picThumbnails = new System.Windows.Forms.PictureBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnFilter.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(57, 99);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(513, 25);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // searchIcon
            // 
            this.searchIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("searchIcon.ImageStream")));
            this.searchIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.searchIcon.Images.SetKeyName(0, "search.png");
            // 
            // lvResult
            // 
            this.lvResult.BackColor = System.Drawing.Color.White;
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTitle,
            this.chChannel});
            this.lvResult.FullRowSelect = true;
            this.lvResult.GridLines = true;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(57, 214);
            this.lvResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(604, 464);
            this.lvResult.SmallImageList = this.smImgList;
            this.lvResult.TabIndex = 2;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.List;
            this.lvResult.Click += new System.EventHandler(this.lvResult_Click);
            this.lvResult.DoubleClick += new System.EventHandler(this.lvResult_DoubleClick);
            this.lvResult.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lvResult_MouseUp);
            // 
            // chTitle
            // 
            this.chTitle.Text = "제목";
            this.chTitle.Width = 237;
            // 
            // chChannel
            // 
            this.chChannel.Text = "채널";
            this.chChannel.Width = 158;
            // 
            // smImgList
            // 
            this.smImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smImgList.ImageStream")));
            this.smImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.smImgList.Images.SetKeyName(0, "videoIcon.ico");
            this.smImgList.Images.SetKeyName(1, "channel.png");
            this.smImgList.Images.SetKeyName(2, "playlist.png");
            // 
            // cbOrder
            // 
            this.cbOrder.BackColor = System.Drawing.Color.White;
            this.cbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Items.AddRange(new object[] {
            "관련성",
            "조회순",
            "날짜순"});
            this.cbOrder.Location = new System.Drawing.Point(115, 31);
            this.cbOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(87, 23);
            this.cbOrder.TabIndex = 3;
            // 
            // lbLog
            // 
            this.lbLog.BackColor = System.Drawing.Color.White;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(57, 128);
            this.lbLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(509, 139);
            this.lbLog.TabIndex = 10;
            this.lbLog.Visible = false;
            this.lbLog.DoubleClick += new System.EventHandler(this.lbLog_DoubleClick);
            // 
            // pnFilter
            // 
            this.pnFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnFilter.Controls.Add(this.lblLength);
            this.pnFilter.Controls.Add(this.cbLength);
            this.pnFilter.Controls.Add(this.lblVideoType);
            this.pnFilter.Controls.Add(this.cbVideoType);
            this.pnFilter.Controls.Add(this.lblOrder);
            this.pnFilter.Controls.Add(this.lblDivision);
            this.pnFilter.Controls.Add(this.cbDivision);
            this.pnFilter.Controls.Add(this.cbOrder);
            this.pnFilter.Location = new System.Drawing.Point(143, 128);
            this.pnFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnFilter.Name = "pnFilter";
            this.pnFilter.Size = new System.Drawing.Size(434, 80);
            this.pnFilter.TabIndex = 11;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(371, 10);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(67, 15);
            this.lblLength.TabIndex = 19;
            this.lblLength.Text = "영상길이";
            // 
            // cbLength
            // 
            this.cbLength.BackColor = System.Drawing.Color.White;
            this.cbLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLength.FormattingEnabled = true;
            this.cbLength.Items.AddRange(new object[] {
            "기본",
            "단편(4분 이하)",
            "장편(20분 이상)"});
            this.cbLength.Location = new System.Drawing.Point(343, 31);
            this.cbLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLength.Name = "cbLength";
            this.cbLength.Size = new System.Drawing.Size(87, 23);
            this.cbLength.TabIndex = 18;
            // 
            // lblVideoType
            // 
            this.lblVideoType.AutoSize = true;
            this.lblVideoType.Location = new System.Drawing.Point(257, 10);
            this.lblVideoType.Name = "lblVideoType";
            this.lblVideoType.Size = new System.Drawing.Size(67, 15);
            this.lblVideoType.TabIndex = 17;
            this.lblVideoType.Text = "영상유형";
            // 
            // cbVideoType
            // 
            this.cbVideoType.BackColor = System.Drawing.Color.White;
            this.cbVideoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVideoType.FormattingEnabled = true;
            this.cbVideoType.Items.AddRange(new object[] {
            "모든 동영상",
            "에피소드",
            "영화"});
            this.cbVideoType.Location = new System.Drawing.Point(230, 31);
            this.cbVideoType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbVideoType.Name = "cbVideoType";
            this.cbVideoType.Size = new System.Drawing.Size(87, 23);
            this.cbVideoType.TabIndex = 16;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(143, 10);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(67, 15);
            this.lblOrder.TabIndex = 15;
            this.lblOrder.Text = "정렬기준";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(56, 10);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(37, 15);
            this.lblDivision.TabIndex = 14;
            this.lblDivision.Text = "구분";
            // 
            // cbDivision
            // 
            this.cbDivision.BackColor = System.Drawing.Color.White;
            this.cbDivision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDivision.FormattingEnabled = true;
            this.cbDivision.Items.AddRange(new object[] {
            "동영상",
            "채널",
            "재생목록"});
            this.cbDivision.Location = new System.Drawing.Point(6, 31);
            this.cbDivision.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDivision.Name = "cbDivision";
            this.cbDivision.Size = new System.Drawing.Size(87, 23);
            this.cbDivision.TabIndex = 5;
            this.cbDivision.SelectedIndexChanged += new System.EventHandler(this.cbDivision_SelectedIndexChanged);
            // 
            // filterIcon
            // 
            this.filterIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("filterIcon.ImageStream")));
            this.filterIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.filterIcon.Images.SetKeyName(0, "Filter.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.lbContentDescription);
            this.panel1.Controls.Add(this.lbContentNameValue);
            this.panel1.Controls.Add(this.lbContentViewCountValue);
            this.panel1.Controls.Add(this.lbLikeCountValue);
            this.panel1.Controls.Add(this.lbDislikeCountValue);
            this.panel1.Controls.Add(this.lbDislikeCount);
            this.panel1.Controls.Add(this.lbLikeCount);
            this.panel1.Controls.Add(this.lbContentViewCount);
            this.panel1.Controls.Add(this.lbContentName);
            this.panel1.Controls.Add(this.picThumbnails);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(705, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 826);
            this.panel1.TabIndex = 13;
            this.panel1.Leave += new System.EventHandler(this.panel1_Leave);
            // 
            // lbContentDescription
            // 
            this.lbContentDescription.AutoSize = true;
            this.lbContentDescription.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContentDescription.ForeColor = System.Drawing.Color.White;
            this.lbContentDescription.Location = new System.Drawing.Point(48, 536);
            this.lbContentDescription.Name = "lbContentDescription";
            this.lbContentDescription.Size = new System.Drawing.Size(53, 23);
            this.lbContentDescription.TabIndex = 18;
            this.lbContentDescription.Text = "Value";
            // 
            // lbContentNameValue
            // 
            this.lbContentNameValue.AutoEllipsis = true;
            this.lbContentNameValue.AutoSize = true;
            this.lbContentNameValue.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContentNameValue.ForeColor = System.Drawing.Color.White;
            this.lbContentNameValue.Location = new System.Drawing.Point(158, 86);
            this.lbContentNameValue.Name = "lbContentNameValue";
            this.lbContentNameValue.Size = new System.Drawing.Size(54, 23);
            this.lbContentNameValue.TabIndex = 17;
            this.lbContentNameValue.Text = "Value";
            // 
            // lbContentViewCountValue
            // 
            this.lbContentViewCountValue.AutoSize = true;
            this.lbContentViewCountValue.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContentViewCountValue.ForeColor = System.Drawing.Color.White;
            this.lbContentViewCountValue.Location = new System.Drawing.Point(155, 139);
            this.lbContentViewCountValue.Name = "lbContentViewCountValue";
            this.lbContentViewCountValue.Size = new System.Drawing.Size(54, 23);
            this.lbContentViewCountValue.TabIndex = 16;
            this.lbContentViewCountValue.Text = "Value";
            // 
            // lbLikeCountValue
            // 
            this.lbLikeCountValue.AutoSize = true;
            this.lbLikeCountValue.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLikeCountValue.ForeColor = System.Drawing.Color.White;
            this.lbLikeCountValue.Location = new System.Drawing.Point(155, 178);
            this.lbLikeCountValue.Name = "lbLikeCountValue";
            this.lbLikeCountValue.Size = new System.Drawing.Size(79, 32);
            this.lbLikeCountValue.TabIndex = 15;
            this.lbLikeCountValue.Text = "Value";
            // 
            // lbDislikeCountValue
            // 
            this.lbDislikeCountValue.AutoSize = true;
            this.lbDislikeCountValue.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDislikeCountValue.ForeColor = System.Drawing.Color.White;
            this.lbDislikeCountValue.Location = new System.Drawing.Point(325, 178);
            this.lbDislikeCountValue.Name = "lbDislikeCountValue";
            this.lbDislikeCountValue.Size = new System.Drawing.Size(79, 32);
            this.lbDislikeCountValue.TabIndex = 14;
            this.lbDislikeCountValue.Text = "Value";
            // 
            // lbDislikeCount
            // 
            this.lbDislikeCount.AutoSize = true;
            this.lbDislikeCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDislikeCount.ForeColor = System.Drawing.Color.White;
            this.lbDislikeCount.Location = new System.Drawing.Point(239, 178);
            this.lbDislikeCount.Name = "lbDislikeCount";
            this.lbDislikeCount.Size = new System.Drawing.Size(87, 32);
            this.lbDislikeCount.TabIndex = 13;
            this.lbDislikeCount.Text = "싫어요";
            // 
            // lbLikeCount
            // 
            this.lbLikeCount.AutoSize = true;
            this.lbLikeCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLikeCount.ForeColor = System.Drawing.Color.White;
            this.lbLikeCount.Location = new System.Drawing.Point(48, 178);
            this.lbLikeCount.Name = "lbLikeCount";
            this.lbLikeCount.Size = new System.Drawing.Size(87, 32);
            this.lbLikeCount.TabIndex = 12;
            this.lbLikeCount.Text = "좋아요";
            // 
            // lbContentViewCount
            // 
            this.lbContentViewCount.AutoSize = true;
            this.lbContentViewCount.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContentViewCount.ForeColor = System.Drawing.Color.White;
            this.lbContentViewCount.Location = new System.Drawing.Point(48, 130);
            this.lbContentViewCount.Name = "lbContentViewCount";
            this.lbContentViewCount.Size = new System.Drawing.Size(81, 32);
            this.lbContentViewCount.TabIndex = 11;
            this.lbContentViewCount.Text = "count";
            // 
            // lbContentName
            // 
            this.lbContentName.AutoSize = true;
            this.lbContentName.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbContentName.ForeColor = System.Drawing.Color.White;
            this.lbContentName.Location = new System.Drawing.Point(48, 78);
            this.lbContentName.Name = "lbContentName";
            this.lbContentName.Size = new System.Drawing.Size(68, 32);
            this.lbContentName.TabIndex = 10;
            this.lbContentName.Text = "title ";
            // 
            // picThumbnails
            // 
            this.picThumbnails.Location = new System.Drawing.Point(48, 214);
            this.picThumbnails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picThumbnails.Name = "picThumbnails";
            this.picThumbnails.Size = new System.Drawing.Size(439, 296);
            this.picThumbnails.TabIndex = 9;
            this.picThumbnails.TabStop = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(57, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 79);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.filterIcon;
            this.button1.Location = new System.Drawing.Point(57, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 52);
            this.button1.TabIndex = 12;
            this.button1.Text = "    Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.ImageIndex = 0;
            this.btnSearch.ImageList = this.searchIcon;
            this.btnSearch.Location = new System.Drawing.Point(583, 98);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 55);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_ClickAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1239, 826);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "검색";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.pnFilter.ResumeLayout(false);
            this.pnFilter.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chChannel;
        private System.Windows.Forms.ComboBox cbOrder;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox picThumbnails;
        private System.Windows.Forms.ListBox lbLog;
        private System.Windows.Forms.ImageList smImgList;
        private System.Windows.Forms.Panel pnFilter;
        private System.Windows.Forms.ComboBox cbDivision;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblVideoType;
        private System.Windows.Forms.ComboBox cbVideoType;
        private System.Windows.Forms.ComboBox cbLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ImageList filterIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList searchIcon;
        private System.Windows.Forms.Label lbContentDescription;
        private System.Windows.Forms.Label lbContentNameValue;
        private System.Windows.Forms.Label lbContentViewCountValue;
        private System.Windows.Forms.Label lbLikeCountValue;
        private System.Windows.Forms.Label lbDislikeCountValue;
        private System.Windows.Forms.Label lbDislikeCount;
        private System.Windows.Forms.Label lbLikeCount;
        private System.Windows.Forms.Label lbContentViewCount;
        private System.Windows.Forms.Label lbContentName;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

