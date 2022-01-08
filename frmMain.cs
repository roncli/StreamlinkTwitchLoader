using System.Collections.ObjectModel;
using System.Diagnostics;

namespace StreamlinkTwitchLoader {
    public partial class frmMain : Form {
        public frmMain() {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) {
            lblPlayer1.Tag = 1;
            txtPlayer1.Tag = 1;
            btnPlayer1.Tag = 1;
            btnPlayer1.Click += start_Click;
            btnAdd.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            tblPlayers.RowCount++;

            var id = tblPlayers.RowCount - 2;
            tblPlayers.SetRow(tblButtons, tblPlayers.RowCount - 1);
            tblPlayers.Controls.Add(new Label() {
                Name = $"lblPlayer{id}",
                Text = $"{id}",
                Anchor = AnchorStyles.Right,
                AutoSize = true,
                Tag = id
            }, 0, id);
            tblPlayers.Controls.Add(new TextBox() {
                Name = $"txtPlayer{id}",
                Anchor = AnchorStyles.Left,
                TabIndex = id * 2 - 2,
                Tag = id,
                Width = 200
            }, 1, id);
            tblPlayers.Controls.Add(new Button() {
                Name = $"btnPlayer{id}",
                Text = "Start Stream",
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                TabIndex = id * 2 - 1,
                Tag = id
            }, 2, id);

            tblPlayers.RowStyles.RemoveAt(tblPlayers.RowStyles.Count - 2);
            tblPlayers.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
            tblPlayers.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
            tblPlayers.RowStyles.RemoveAt(tblPlayers.RowStyles.Count - 2);
            tblPlayers.RowStyles.RemoveAt(tblPlayers.RowStyles.Count - 2);
            tblPlayers.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));
            tblPlayers.RowStyles.Add(new RowStyle(SizeType.AutoSize, 0));

            ((Button)tblPlayers.Controls.Find($"btnPlayer{id}", false)[0]).Click += start_Click;

            tblButtons.TabIndex = id * 2;
        }

        private void btnRemove_Click(object sender, EventArgs e) {
            var id = tblPlayers.RowCount - 2;

            if (id == 1) {
                return;
            }

            ((Button)tblPlayers.Controls.Find($"btnPlayer{id}", false)[0]).Click -= start_Click;

            tblPlayers.Controls.Remove(tblPlayers.Controls.Find($"lblPlayer{id}", false)[0]);
            tblPlayers.Controls.Remove(tblPlayers.Controls.Find($"txtPlayer{id}", false)[0]);
            tblPlayers.Controls.Remove(tblPlayers.Controls.Find($"btnPlayer{id}", false)[0]);

            tblPlayers.SetRow(tblButtons, tblPlayers.RowCount - 2);
            tblPlayers.RowStyles.RemoveAt(tblPlayers.RowStyles.Count - 1);
            tblPlayers.RowCount--;
        }

        private void start_Click(object? sender, EventArgs e) {
            if (sender == null) {
                return;
            }

            var btnStart = (Button)sender;
            var id = (int)btnStart.Tag;
            var txtPlayer1 = (TextBox)tblPlayers.Controls.Find($"txtPlayer{id}", false)[0];
            if (txtPlayer1.Text.Length > 0) {
                Process process = new Process();
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                process.StartInfo.CreateNoWindow = true;

                process.StartInfo.FileName = "streamlink.exe";
                
                process.StartInfo.ArgumentList.Add("--twitch-disable-hosting");
                
                process.StartInfo.ArgumentList.Add("--twitch-disable-ads");

                process.StartInfo.ArgumentList.Add("--player");
                process.StartInfo.ArgumentList.Add("C:\\Program Files\\VideoLAN\\VLC\\vlc.exe");

                process.StartInfo.ArgumentList.Add("--player-args");
                process.StartInfo.ArgumentList.Add($"--no-one-instance --play-and-exit --input-title-format \"Player {id}\" --qt-minimal-view --no-audio");

                process.StartInfo.ArgumentList.Add("--hls-live-edge");
                process.StartInfo.ArgumentList.Add("3");

                process.StartInfo.ArgumentList.Add("--hls-segment-threads");
                process.StartInfo.ArgumentList.Add("1");

                process.StartInfo.ArgumentList.Add("--retry-open");
                process.StartInfo.ArgumentList.Add("1");

                process.StartInfo.ArgumentList.Add("--retry-max");
                process.StartInfo.ArgumentList.Add("5");

                process.StartInfo.ArgumentList.Add("--retry-streams");
                process.StartInfo.ArgumentList.Add("1");

                process.StartInfo.ArgumentList.Add($"twitch.tv/{txtPlayer1.Text}");

                process.StartInfo.ArgumentList.Add("best");

                process.Start();
            }
        }
    }
}