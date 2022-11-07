using System;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();
        List<int> array = new List<int>();

        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);
            while (AfterWards >= ThisMoment)
            {
                Application.DoEvents();
                ThisMoment = DateTime.Now;
            }
            return DateTime.Now;
        }


        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            if (e.Button != MouseButtons.Left)
                return;

            
            this.Left = Left + (e.X - ((Point)s.Tag).X);
            this.Top = Top + (e.Y - ((Point)s.Tag).Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            var s = sender as Panel;
            s.Tag = new Point(e.X, e.Y);
        }

        private void draw_btn_Click(object sender, EventArgs e) {
            if (timer.Enabled) return;

            if (settingPanel.Visible) {
                MessageBox.Show("설정 창을 꺼주세요", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (array.Count >= maxBox.Value) {
                MessageBox.Show("이제 뽑을 사람이 없어요", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            remainLbl.Text = $"{(array.Count+1).ToString().PadLeft(2, '0')} / {maxBox.Value}";
            num_label.ForeColor = Color.Silver;
            label2.ForeColor = Color.Silver;

            Random r = new Random();
            int count = 0;
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += (object _sender, EventArgs _e) => {
                if (count == 20) {
                    int temp = r.Next(1, (int)maxBox.Value);
                    while(true) {
                        if (!array.Contains(temp)) break;
                        else temp = r.Next(1, (int)maxBox.Value+1);
                    }

                    num_label.Text = temp.ToString().PadLeft(2, '0');
                    num_label.ForeColor = Color.FromArgb(255, 131, 80, 46);
                    label2.ForeColor = Color.FromArgb(255, 131, 80, 46);
                    array.Add(temp);
                    timer.Stop();
                } else {
                    if (count == 10) timer.Interval = 100;
                    else if (count == 15) timer.Interval = 200;
                    string temp;
                    while(true) {
                        temp = r.Next(1, (int)maxBox.Value+1).ToString().PadLeft(2, '0');
                        if (temp != num_label.Text) break;
                        else r.Next(1, (int)maxBox.Value+1).ToString().PadLeft(2, '0');
                    }
                    num_label.Text = temp;
                    count++;
                }
            };
            timer.Start();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Show();
            for (double i = 0; i <= 1.02; i += 0.02) {
                this.Opacity = i;
                Delay(1);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (double i = 1.00; i >= -0.02; i -= 0.02) {
                this.Opacity = i;
                Delay(1);
            }
        }

        private void title_DoubleClick(object sender, EventArgs e)
        {
            if (timer.Enabled) return;
            title.Visible = false;
            settingPanel.Visible = true;
            array.Clear();
            remainLbl.Text = $"00 / {maxBox.Value}";
            num_label.Text = "00";
        }

        private void settingPanel_DoubleClick(object sender, EventArgs e) {
            title.Visible = true;
            settingPanel.Visible = false;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maxBox_ValueChanged(object sender, EventArgs e)
        {
            array.Clear();
            remainLbl.Text = $"00 / {maxBox.Value}";
        }
    }
}
