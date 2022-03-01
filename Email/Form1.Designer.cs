namespace Email
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
            this.btnSend = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckUseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.ckEnableSSL = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassWord = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UseDefaultCredentials = new System.Windows.Forms.CheckBox();
            this.port = new System.Windows.Forms.TextBox();
            this.EnableSsl = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listErrorBox = new System.Windows.Forms.ListBox();
            this.ComboComponent = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Location = new System.Drawing.Point(30, 404);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(515, 55);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(26, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(523, 353);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(515, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ComboComponent);
            this.groupBox4.Controls.Add(this.ckUseDefaultCredentials);
            this.groupBox4.Controls.Add(this.txtPort);
            this.groupBox4.Controls.Add(this.ckEnableSSL);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtUserName);
            this.groupBox4.Controls.Add(this.txtPassWord);
            this.groupBox4.Controls.Add(this.txtServer);
            this.groupBox4.Location = new System.Drawing.Point(26, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(437, 198);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mail Server";
            // 
            // ckUseDefaultCredentials
            // 
            this.ckUseDefaultCredentials.AutoSize = true;
            this.ckUseDefaultCredentials.Location = new System.Drawing.Point(37, 176);
            this.ckUseDefaultCredentials.Name = "ckUseDefaultCredentials";
            this.ckUseDefaultCredentials.Size = new System.Drawing.Size(131, 17);
            this.ckUseDefaultCredentials.TabIndex = 9;
            this.ckUseDefaultCredentials.Text = "UseDefaultCredentials";
            this.ckUseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(100, 110);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(57, 20);
            this.txtPort.TabIndex = 10;
            // 
            // ckEnableSSL
            // 
            this.ckEnableSSL.AutoSize = true;
            this.ckEnableSSL.Location = new System.Drawing.Point(36, 153);
            this.ckEnableSSL.Name = "ckEnableSSL";
            this.ckEnableSSL.Size = new System.Drawing.Size(73, 17);
            this.ckEnableSSL.TabIndex = 8;
            this.ckEnableSSL.Text = "EnableSsl";
            this.ckEnableSSL.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "PassWord";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "User";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(100, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(263, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassWord
            // 
            this.txtPassWord.Location = new System.Drawing.Point(100, 54);
            this.txtPassWord.Name = "txtPassWord";
            this.txtPassWord.Size = new System.Drawing.Size(263, 20);
            this.txtPassWord.TabIndex = 4;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(100, 80);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(263, 20);
            this.txtServer.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtFrom);
            this.groupBox3.Controls.Add(this.txtTo);
            this.groupBox3.Location = new System.Drawing.Point(26, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(437, 84);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "To";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(100, 19);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(263, 20);
            this.txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(100, 45);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(263, 20);
            this.txtTo.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UseDefaultCredentials);
            this.groupBox2.Controls.Add(this.port);
            this.groupBox2.Controls.Add(this.EnableSsl);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.user);
            this.groupBox2.Controls.Add(this.password);
            this.groupBox2.Controls.Add(this.server);
            this.groupBox2.Location = new System.Drawing.Point(26, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 198);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mail Server";
            // 
            // UseDefaultCredentials
            // 
            this.UseDefaultCredentials.AutoSize = true;
            this.UseDefaultCredentials.Location = new System.Drawing.Point(37, 176);
            this.UseDefaultCredentials.Name = "UseDefaultCredentials";
            this.UseDefaultCredentials.Size = new System.Drawing.Size(131, 17);
            this.UseDefaultCredentials.TabIndex = 9;
            this.UseDefaultCredentials.Text = "UseDefaultCredentials";
            this.UseDefaultCredentials.UseVisualStyleBackColor = true;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(100, 110);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(57, 20);
            this.port.TabIndex = 10;
            // 
            // EnableSsl
            // 
            this.EnableSsl.AutoSize = true;
            this.EnableSsl.Location = new System.Drawing.Point(36, 153);
            this.EnableSsl.Name = "EnableSsl";
            this.EnableSsl.Size = new System.Drawing.Size(73, 17);
            this.EnableSsl.TabIndex = 8;
            this.EnableSsl.Text = "EnableSsl";
            this.EnableSsl.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PassWord";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "User";
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(100, 28);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(263, 20);
            this.user.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(100, 54);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(263, 20);
            this.password.TabIndex = 4;
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(100, 80);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(263, 20);
            this.server.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.to);
            this.groupBox1.Location = new System.Drawing.Point(26, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 84);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // from
            // 
            this.from.Location = new System.Drawing.Point(100, 19);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(263, 20);
            this.from.TabIndex = 0;
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(100, 45);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(263, 20);
            this.to.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listErrorBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(515, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Errors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listErrorBox
            // 
            this.listErrorBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listErrorBox.FormattingEnabled = true;
            this.listErrorBox.Location = new System.Drawing.Point(6, 12);
            this.listErrorBox.Name = "listErrorBox";
            this.listErrorBox.Size = new System.Drawing.Size(501, 277);
            this.listErrorBox.TabIndex = 0;
            // 
            // ComboComponent
            // 
            this.ComboComponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboComponent.FormattingEnabled = true;
            this.ComboComponent.Items.AddRange(new object[] {
            "NetClient",
            "Mailkit"});
            this.ComboComponent.Location = new System.Drawing.Point(243, 153);
            this.ComboComponent.Name = "ComboComponent";
            this.ComboComponent.Size = new System.Drawing.Size(162, 21);
            this.ComboComponent.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emailer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckUseDefaultCredentials;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.CheckBox ckEnableSSL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassWord;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox UseDefaultCredentials;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.CheckBox EnableSsl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox from;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listErrorBox;
        private System.Windows.Forms.ComboBox ComboComponent;
    }
}

