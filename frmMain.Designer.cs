namespace StreamlinkTwitchLoader {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tblPlayers = new System.Windows.Forms.TableLayoutPanel();
            this.lblStartStream = new System.Windows.Forms.Label();
            this.lblPlayerNo = new System.Windows.Forms.Label();
            this.lblTwitchHandle = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.btnPlayer1 = new System.Windows.Forms.Button();
            this.tblButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblPlayers.SuspendLayout();
            this.tblButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblPlayers
            // 
            this.tblPlayers.AutoScroll = true;
            this.tblPlayers.AutoSize = true;
            this.tblPlayers.ColumnCount = 3;
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPlayers.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPlayers.Controls.Add(this.lblStartStream, 2, 0);
            this.tblPlayers.Controls.Add(this.lblPlayerNo, 0, 0);
            this.tblPlayers.Controls.Add(this.lblTwitchHandle, 1, 0);
            this.tblPlayers.Controls.Add(this.lblPlayer1, 0, 1);
            this.tblPlayers.Controls.Add(this.txtPlayer1, 1, 1);
            this.tblPlayers.Controls.Add(this.btnPlayer1, 2, 1);
            this.tblPlayers.Controls.Add(this.tblButtons, 0, 2);
            this.tblPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPlayers.Location = new System.Drawing.Point(0, 0);
            this.tblPlayers.Name = "tblPlayers";
            this.tblPlayers.RowCount = 3;
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPlayers.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblPlayers.Size = new System.Drawing.Size(372, 325);
            this.tblPlayers.TabIndex = 0;
            // 
            // lblStartStream
            // 
            this.lblStartStream.AutoSize = true;
            this.lblStartStream.Location = new System.Drawing.Point(264, 0);
            this.lblStartStream.Name = "lblStartStream";
            this.lblStartStream.Size = new System.Drawing.Size(71, 15);
            this.lblStartStream.TabIndex = 4;
            this.lblStartStream.Text = "Start Stream";
            // 
            // lblPlayerNo
            // 
            this.lblPlayerNo.AutoSize = true;
            this.lblPlayerNo.Location = new System.Drawing.Point(3, 0);
            this.lblPlayerNo.Name = "lblPlayerNo";
            this.lblPlayerNo.Size = new System.Drawing.Size(49, 15);
            this.lblPlayerNo.TabIndex = 0;
            this.lblPlayerNo.Text = "Player #";
            // 
            // lblTwitchHandle
            // 
            this.lblTwitchHandle.AutoSize = true;
            this.lblTwitchHandle.Location = new System.Drawing.Point(58, 0);
            this.lblTwitchHandle.Name = "lblTwitchHandle";
            this.lblTwitchHandle.Size = new System.Drawing.Size(82, 15);
            this.lblTwitchHandle.TabIndex = 1;
            this.lblTwitchHandle.Text = "Twitch Handle";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(39, 23);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(13, 15);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Tag = "1";
            this.lblPlayer1.Text = "1";
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPlayer1.Location = new System.Drawing.Point(58, 19);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(200, 23);
            this.txtPlayer1.TabIndex = 0;
            this.txtPlayer1.Tag = "1";
            // 
            // btnPlayer1
            // 
            this.btnPlayer1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPlayer1.AutoSize = true;
            this.btnPlayer1.Location = new System.Drawing.Point(264, 18);
            this.btnPlayer1.Name = "btnPlayer1";
            this.btnPlayer1.Size = new System.Drawing.Size(81, 25);
            this.btnPlayer1.TabIndex = 1;
            this.btnPlayer1.Tag = "1";
            this.btnPlayer1.Text = "Start Stream";
            this.btnPlayer1.UseVisualStyleBackColor = true;
            // 
            // tblButtons
            // 
            this.tblButtons.ColumnCount = 2;
            this.tblPlayers.SetColumnSpan(this.tblButtons, 3);
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblButtons.Controls.Add(this.btnRemove, 1, 0);
            this.tblButtons.Controls.Add(this.btnAdd, 0, 0);
            this.tblButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.tblButtons.Location = new System.Drawing.Point(0, 46);
            this.tblButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tblButtons.Name = "tblButtons";
            this.tblButtons.RowCount = 1;
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblButtons.Size = new System.Drawing.Size(372, 30);
            this.tblButtons.TabIndex = 7;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(189, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(95, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Player";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(88, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 325);
            this.Controls.Add(this.tblPlayers);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tblPlayers.ResumeLayout(false);
            this.tblPlayers.PerformLayout();
            this.tblButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel tblPlayers;
        private Label lblPlayerNo;
        private Label lblStartStream;
        private Label lblTwitchHandle;
        private Label lblPlayer1;
        private TextBox txtPlayer1;
        private Button btnPlayer1;
        private TableLayoutPanel tblButtons;
        private Button btnRemove;
        private Button btnAdd;
    }
}