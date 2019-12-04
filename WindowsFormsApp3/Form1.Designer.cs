namespace WindowsFormsApp3
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.label1 = new System.Windows.Forms.Label();
            this.playerName1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerName2 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.box1 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentPlayerName = new System.Windows.Forms.RichTextBox();
            this.newButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.score1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.score2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.leaderboard = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player1 Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerName1
            // 
            this.playerName1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerName1.Location = new System.Drawing.Point(131, 15);
            this.playerName1.Name = "playerName1";
            this.playerName1.Size = new System.Drawing.Size(185, 13);
            this.playerName1.TabIndex = 1;
            this.playerName1.TextChanged += new System.EventHandler(this.playerName1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(356, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player2 Name";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // playerName2
            // 
            this.playerName2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.playerName2.Location = new System.Drawing.Point(433, 15);
            this.playerName2.Name = "playerName2";
            this.playerName2.Size = new System.Drawing.Size(185, 13);
            this.playerName2.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(627, 11);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 20);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.box1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.box2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.box3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.box4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.box5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.box6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.box7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.box8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.box9, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(266, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(278, 163);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.box1.Enabled = false;
            this.box1.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.box1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.box1.Location = new System.Drawing.Point(4, 4);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(85, 47);
            this.box1.TabIndex = 0;
            this.box1.UseVisualStyleBackColor = false;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box2
            // 
            this.box2.Enabled = false;
            this.box2.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.Location = new System.Drawing.Point(96, 4);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(85, 46);
            this.box2.TabIndex = 0;
            this.box2.UseVisualStyleBackColor = true;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box3
            // 
            this.box3.Enabled = false;
            this.box3.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box3.Location = new System.Drawing.Point(188, 4);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(85, 46);
            this.box3.TabIndex = 0;
            this.box3.UseVisualStyleBackColor = true;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // box4
            // 
            this.box4.Enabled = false;
            this.box4.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box4.Location = new System.Drawing.Point(4, 58);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(85, 46);
            this.box4.TabIndex = 0;
            this.box4.UseVisualStyleBackColor = true;
            this.box4.Click += new System.EventHandler(this.button6_Click);
            // 
            // box5
            // 
            this.box5.Enabled = false;
            this.box5.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box5.Location = new System.Drawing.Point(96, 58);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(85, 46);
            this.box5.TabIndex = 0;
            this.box5.UseVisualStyleBackColor = true;
            this.box5.Click += new System.EventHandler(this.button7_Click);
            // 
            // box6
            // 
            this.box6.Enabled = false;
            this.box6.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box6.Location = new System.Drawing.Point(188, 58);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(85, 46);
            this.box6.TabIndex = 0;
            this.box6.UseVisualStyleBackColor = true;
            this.box6.Click += new System.EventHandler(this.button8_Click);
            // 
            // box7
            // 
            this.box7.Enabled = false;
            this.box7.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box7.Location = new System.Drawing.Point(4, 112);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(85, 46);
            this.box7.TabIndex = 0;
            this.box7.UseVisualStyleBackColor = true;
            this.box7.Click += new System.EventHandler(this.button9_Click);
            // 
            // box8
            // 
            this.box8.Enabled = false;
            this.box8.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box8.Location = new System.Drawing.Point(96, 112);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(85, 46);
            this.box8.TabIndex = 0;
            this.box8.UseVisualStyleBackColor = true;
            this.box8.Click += new System.EventHandler(this.button10_Click);
            // 
            // box9
            // 
            this.box9.Enabled = false;
            this.box9.Font = new System.Drawing.Font("MS Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box9.Location = new System.Drawing.Point(188, 112);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(85, 46);
            this.box9.TabIndex = 0;
            this.box9.UseVisualStyleBackColor = true;
            this.box9.Click += new System.EventHandler(this.button11_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result.Enabled = false;
            this.result.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(283, 242);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(245, 43);
            this.result.TabIndex = 5;
            this.result.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(54, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Current Player";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // currentPlayerName
            // 
            this.currentPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.currentPlayerName.Enabled = false;
            this.currentPlayerName.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPlayerName.Location = new System.Drawing.Point(57, 98);
            this.currentPlayerName.Name = "currentPlayerName";
            this.currentPlayerName.Size = new System.Drawing.Size(144, 36);
            this.currentPlayerName.TabIndex = 7;
            this.currentPlayerName.Text = "";
            // 
            // newButton
            // 
            this.newButton.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newButton.Location = new System.Drawing.Point(708, 11);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 20);
            this.newButton.TabIndex = 8;
            this.newButton.Text = "New Game";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Visible = false;
            this.newButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(56, 280);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "How to play?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(634, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Scores";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 57);
            this.label5.TabIndex = 11;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(569, 126);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(49, 57);
            this.score1.TabIndex = 11;
            this.score1.Text = "0";
            this.score1.Click += new System.EventHandler(this.score1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 57);
            this.label7.TabIndex = 11;
            this.label7.Text = ":";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(698, 126);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(49, 57);
            this.score2.TabIndex = 11;
            this.score2.Text = "0";
            this.score2.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(564, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 26);
            this.label9.TabIndex = 10;
            this.label9.Text = "Player1";
            this.label9.Click += new System.EventHandler(this.label4_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(687, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Player2";
            this.label10.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(627, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 12;
            this.button1.Text = "Continue";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(708, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 20);
            this.button2.TabIndex = 8;
            this.button2.Text = "Restart";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginButton
            // 
            this.loginButton.AutoSize = true;
            this.loginButton.Location = new System.Drawing.Point(126, 280);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(33, 13);
            this.loginButton.TabIndex = 9;
            this.loginButton.TabStop = true;
            this.loginButton.Text = "Login";
            this.loginButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.loginButton_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(165, 280);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(42, 13);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "SignUp";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpButton_LinkClicked);
            // 
            // leaderboard
            // 
            this.leaderboard.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.leaderboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.leaderboard.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leaderboard.ForeColor = System.Drawing.SystemColors.Highlight;
            this.leaderboard.FormattingEnabled = true;
            this.leaderboard.Location = new System.Drawing.Point(57, 181);
            this.leaderboard.Name = "leaderboard";
            this.leaderboard.Size = new System.Drawing.Size(144, 93);
            this.leaderboard.TabIndex = 13;
            this.leaderboard.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(54, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Leaderboard";
            this.label6.Click += new System.EventHandler(this.label3_Click);
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.leaderboard);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.score2);
            this.Controls.Add(this.score1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.currentPlayerName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.playerName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerName1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerName1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox playerName2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.RichTextBox result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox currentPlayerName;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.LinkLabel loginButton;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ListBox leaderboard;
        private System.Windows.Forms.Label label6;
    }
}

