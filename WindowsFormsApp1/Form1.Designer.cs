namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.textBoxFolderPath = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Select = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.setlists = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Setlisttooltip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panelStatus);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel3);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel2);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.Select);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.setlists);
            this.splitContainer1.Panel2.Controls.Add(this.button10);
            this.splitContainer1.Panel2.Controls.Add(this.button19);
            this.splitContainer1.Panel2.Controls.Add(this.button9);
            this.splitContainer1.Panel2.Controls.Add(this.button18);
            this.splitContainer1.Panel2.Controls.Add(this.button8);
            this.splitContainer1.Panel2.Controls.Add(this.button17);
            this.splitContainer1.Panel2.Controls.Add(this.button7);
            this.splitContainer1.Panel2.Controls.Add(this.button6);
            this.splitContainer1.Panel2.Controls.Add(this.button15);
            this.splitContainer1.Panel2.Controls.Add(this.button5);
            this.splitContainer1.Panel2.Controls.Add(this.button4);
            this.splitContainer1.Panel2.Controls.Add(this.button13);
            this.splitContainer1.Panel2.Controls.Add(this.button3);
            this.splitContainer1.Panel2.Controls.Add(this.button12);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button11);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(526, 426);
            this.splitContainer1.SplitterDistance = 312;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panelStatus
            // 
            this.panelStatus.Controls.Add(this.textBoxFolderPath);
            this.panelStatus.Controls.Add(this.labelStatus);
            this.panelStatus.Controls.Add(this.buttonSelectFolder);
            this.panelStatus.Location = new System.Drawing.Point(7, 294);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(146, 50);
            this.panelStatus.TabIndex = 3;
            this.panelStatus.Paint += new System.Windows.Forms.PaintEventHandler(this.panelStatus_Paint);
            // 
            // textBoxFolderPath
            // 
            this.textBoxFolderPath.Location = new System.Drawing.Point(32, 6);
            this.textBoxFolderPath.Multiline = true;
            this.textBoxFolderPath.Name = "textBoxFolderPath";
            this.textBoxFolderPath.Size = new System.Drawing.Size(73, 20);
            this.textBoxFolderPath.TabIndex = 2;
            this.textBoxFolderPath.Text = "/BGM";
            this.textBoxFolderPath.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(0, 29);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(108, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status : Not Selected";
            this.labelStatus.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(3, 4);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(28, 23);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.button11_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.linkLabel3.Location = new System.Drawing.Point(7, 381);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(117, 17);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "🌍Speedrun.com";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.linkLabel2.Location = new System.Drawing.Point(7, 364);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 17);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "🌍Website";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.linkLabel1.Location = new System.Drawing.Point(7, 347);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 17);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "🌍Twitch";
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Select.Font = new System.Drawing.Font("Consolas", 10.25F);
            this.Select.Location = new System.Drawing.Point(4, 4);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(276, 409);
            this.Select.TabIndex = 0;
            this.Select.Text = resources.GetString("Select.Text");
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(146, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(14, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.Setlisttooltip.SetToolTip(this.pictureBox1, "Set list \"a\" and set list \"b\" alternate between entering garage and \r\nsewers. For" +
        " instance, Chuo into RDH passes through garage so \r\nChuo uses set-list 2a and RD" +
        "H uses set-list 2b.");
            // 
            // setlists
            // 
            this.setlists.AutoSize = true;
            this.setlists.BackColor = System.Drawing.Color.Transparent;
            this.setlists.Font = new System.Drawing.Font("Verdana", 14.25F);
            this.setlists.Location = new System.Drawing.Point(57, 31);
            this.setlists.Name = "setlists";
            this.setlists.Size = new System.Drawing.Size(92, 23);
            this.setlists.TabIndex = 1;
            this.setlists.Text = "Set Lists";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(66, 324);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 0;
            this.button10.Text = "Garage";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(108, 295);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 0;
            this.button19.Text = "Chapter 9b";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(27, 295);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "Chapter 9a";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button1_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(108, 266);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(75, 23);
            this.button18.TabIndex = 0;
            this.button18.Text = "Chapter 8b";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button1_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(27, 266);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "Chapter 8a";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(108, 237);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(75, 23);
            this.button17.TabIndex = 0;
            this.button17.Text = "Chapter 7b";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(27, 237);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Chapter 7a";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(61, 208);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Chapter 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(108, 179);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "Chapter 5b";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 179);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Chapter 5a";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(61, 150);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Chapter 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(108, 121);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            this.button13.Text = "Chapter 3b";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Chapter 3a";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(108, 92);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 0;
            this.button12.Text = "Chapter 2b";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Chapter 2a";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Location = new System.Drawing.Point(108, 63);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 0;
            this.button11.Text = "Chapter 1b";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(27, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Chapter 1a";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Setlisttooltip
            // 
            this.Setlisttooltip.BackColor = System.Drawing.SystemColors.ControlText;
            this.Setlisttooltip.ShowAlways = true;
            this.Setlisttooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Setlisttooltip.ToolTipTitle = "Set Lists";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Jet Set Radio Future Music Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private new System.Windows.Forms.Label Select;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxFolderPath;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label setlists;
        private System.Windows.Forms.ToolTip Setlisttooltip;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

