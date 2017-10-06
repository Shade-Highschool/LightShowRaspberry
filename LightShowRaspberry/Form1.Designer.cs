namespace LightShowRaspberry
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnected = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnCloseConn = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblText01 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblTitlePT01 = new System.Windows.Forms.Label();
            this.lblTitlePT02 = new System.Windows.Forms.Label();
            this.lblTitlePT03 = new System.Windows.Forms.Label();
            this.lblText02 = new System.Windows.Forms.Label();
            this.lblText03 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(17, 211);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(140, 41);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblConnected.Location = new System.Drawing.Point(72, 171);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(94, 16);
            this.lblConnected.TabIndex = 1;
            this.lblConnected.Text = "Disconnected";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(313, 210);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(461, 260);
            this.listBox1.TabIndex = 2;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(177, 211);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(118, 41);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play song";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Location = new System.Drawing.Point(17, 293);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(140, 42);
            this.btnUpload.TabIndex = 4;
            this.btnUpload.Text = "Upload song";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "MP3 |*.mp3";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSong.Location = new System.Drawing.Point(17, 339);
            this.btnRemoveSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(140, 42);
            this.btnRemoveSong.TabIndex = 5;
            this.btnRemoveSong.Text = "Remove song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(806, 210);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 270);
            this.trackBar1.TabIndex = 6;
            // 
            // btnCloseConn
            // 
            this.btnCloseConn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCloseConn.FlatAppearance.BorderSize = 0;
            this.btnCloseConn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCloseConn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnCloseConn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseConn.ForeColor = System.Drawing.Color.White;
            this.btnCloseConn.Location = new System.Drawing.Point(177, 340);
            this.btnCloseConn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseConn.Name = "btnCloseConn";
            this.btnCloseConn.Size = new System.Drawing.Size(118, 41);
            this.btnCloseConn.TabIndex = 7;
            this.btnCloseConn.Text = "Close connection";
            this.btnCloseConn.UseVisualStyleBackColor = false;
            this.btnCloseConn.Click += new System.EventHandler(this.btnCloseConn_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(177, 276);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(118, 41);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblText01
            // 
            this.lblText01.AutoSize = true;
            this.lblText01.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblText01.Location = new System.Drawing.Point(13, 171);
            this.lblText01.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText01.Name = "lblText01";
            this.lblText01.Size = new System.Drawing.Size(52, 16);
            this.lblText01.TabIndex = 9;
            this.lblText01.Text = "Status:";
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::LightShowRaspberry.Properties.Resources.raspberry_pi1600;
            this.pbLogo.Location = new System.Drawing.Point(17, 17);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
            // 
            // lblTitlePT01
            // 
            this.lblTitlePT01.AutoSize = true;
            this.lblTitlePT01.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitlePT01.Location = new System.Drawing.Point(123, 41);
            this.lblTitlePT01.Name = "lblTitlePT01";
            this.lblTitlePT01.Size = new System.Drawing.Size(141, 32);
            this.lblTitlePT01.TabIndex = 11;
            this.lblTitlePT01.Text = "LightShow";
            // 
            // lblTitlePT02
            // 
            this.lblTitlePT02.AutoSize = true;
            this.lblTitlePT02.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTitlePT02.Location = new System.Drawing.Point(206, 80);
            this.lblTitlePT02.Name = "lblTitlePT02";
            this.lblTitlePT02.Size = new System.Drawing.Size(26, 18);
            this.lblTitlePT02.TabIndex = 12;
            this.lblTitlePT02.Text = "for";
            // 
            // lblTitlePT03
            // 
            this.lblTitlePT03.AutoSize = true;
            this.lblTitlePT03.Font = new System.Drawing.Font("Arial", 12F);
            this.lblTitlePT03.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(17)))), ((int)(((byte)(66)))));
            this.lblTitlePT03.Location = new System.Drawing.Point(236, 80);
            this.lblTitlePT03.Name = "lblTitlePT03";
            this.lblTitlePT03.Size = new System.Drawing.Size(99, 18);
            this.lblTitlePT03.TabIndex = 13;
            this.lblTitlePT03.Text = "Raspberry Pi";
            // 
            // lblText02
            // 
            this.lblText02.AutoSize = true;
            this.lblText02.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblText02.Location = new System.Drawing.Point(309, 187);
            this.lblText02.Name = "lblText02";
            this.lblText02.Size = new System.Drawing.Size(62, 16);
            this.lblText02.TabIndex = 14;
            this.lblText02.Text = "Song list";
            // 
            // lblText03
            // 
            this.lblText03.AutoSize = true;
            this.lblText03.Font = new System.Drawing.Font("Arial", 10.2F);
            this.lblText03.Location = new System.Drawing.Point(800, 187);
            this.lblText03.Name = "lblText03";
            this.lblText03.Size = new System.Drawing.Size(54, 16);
            this.lblText03.TabIndex = 15;
            this.lblText03.Text = "Volume";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Arial", 18F);
            this.btnClose.Location = new System.Drawing.Point(837, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 41);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "×";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Arial", 18F);
            this.btnMinimize.Location = new System.Drawing.Point(790, 13);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(43, 41);
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(892, 512);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblText03);
            this.Controls.Add(this.lblText02);
            this.Controls.Add(this.lblTitlePT03);
            this.Controls.Add(this.lblTitlePT02);
            this.Controls.Add(this.lblTitlePT01);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.lblText01);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCloseConn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnConnect);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightShow Raspberry Pi";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnCloseConn;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblText01;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblTitlePT01;
        private System.Windows.Forms.Label lblTitlePT02;
        private System.Windows.Forms.Label lblTitlePT03;
        private System.Windows.Forms.Label lblText02;
        private System.Windows.Forms.Label lblText03;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
    }
}

