namespace RandomNumber
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.draw_btn = new System.Windows.Forms.Button();
            this.settingPanel = new System.Windows.Forms.Panel();
            this.maxBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.num_label = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.remainLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.settingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.remainLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.draw_btn);
            this.panel1.Controls.Add(this.settingPanel);
            this.panel1.Controls.Add(this.num_label);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 213);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(80)))), ((int)(((byte)(46)))));
            this.label2.Location = new System.Drawing.Point(141, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "번";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // draw_btn
            // 
            this.draw_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this.draw_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.draw_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this.draw_btn.FlatAppearance.BorderSize = 0;
            this.draw_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.draw_btn.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.draw_btn.ForeColor = System.Drawing.Color.White;
            this.draw_btn.Location = new System.Drawing.Point(0, 168);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(265, 45);
            this.draw_btn.TabIndex = 1;
            this.draw_btn.Text = "추첨하기";
            this.draw_btn.UseVisualStyleBackColor = false;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // settingPanel
            // 
            this.settingPanel.Controls.Add(this.maxBox);
            this.settingPanel.Controls.Add(this.label3);
            this.settingPanel.Controls.Add(this.closeBtn);
            this.settingPanel.Controls.Add(this.label1);
            this.settingPanel.Location = new System.Drawing.Point(9, 8);
            this.settingPanel.Name = "settingPanel";
            this.settingPanel.Size = new System.Drawing.Size(247, 66);
            this.settingPanel.TabIndex = 15;
            this.settingPanel.Visible = false;
            this.settingPanel.DoubleClick += new System.EventHandler(this.settingPanel_DoubleClick);
            // 
            // maxBox
            // 
            this.maxBox.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.maxBox.Location = new System.Drawing.Point(27, 26);
            this.maxBox.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.maxBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(43, 29);
            this.maxBox.TabIndex = 12;
            this.maxBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.maxBox.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.maxBox.ValueChanged += new System.EventHandler(this.maxBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "(번)";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(130, 14);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(97, 41);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = "나가기";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "최대 번호";
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Font = new System.Drawing.Font("맑은 고딕", 40F);
            this.num_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(80)))), ((int)(((byte)(46)))));
            this.num_label.Location = new System.Drawing.Point(71, 74);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(90, 72);
            this.num_label.TabIndex = 7;
            this.num_label.Text = "00";
            this.num_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 25F);
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(80)))), ((int)(((byte)(46)))));
            this.title.Location = new System.Drawing.Point(43, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(178, 46);
            this.title.TabIndex = 9;
            this.title.Text = "랜덤 번호!";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.DoubleClick += new System.EventHandler(this.title_DoubleClick);
            // 
            // remainLbl
            // 
            this.remainLbl.AutoSize = true;
            this.remainLbl.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.remainLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(80)))), ((int)(((byte)(46)))));
            this.remainLbl.Location = new System.Drawing.Point(8, 146);
            this.remainLbl.Name = "remainLbl";
            this.remainLbl.Size = new System.Drawing.Size(57, 19);
            this.remainLbl.TabIndex = 16;
            this.remainLbl.Text = "00 / 22";
            this.remainLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(165)))), ((int)(((byte)(109)))));
            this.ClientSize = new System.Drawing.Size(271, 220);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "랜덤 번호";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.settingPanel.ResumeLayout(false);
            this.settingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel settingPanel;
        private System.Windows.Forms.NumericUpDown maxBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label remainLbl;
    }
}

