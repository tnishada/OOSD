namespace OOSD
{
    partial class reportWindow
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.UserHistory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNamechkbox = new System.Windows.Forms.CheckBox();
            this.UserInfo = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TextUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBookId = new System.Windows.Forms.TextBox();
            this.bookDetailsViewer = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UserHistory);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.userNamechkbox);
            this.tabPage1.Controls.Add(this.UserInfo);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.TextUserName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "User Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // UserHistory
            // 
            this.UserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserHistory.Location = new System.Drawing.Point(199, 207);
            this.UserHistory.Name = "UserHistory";
            this.UserHistory.Size = new System.Drawing.Size(460, 121);
            this.UserHistory.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "User History";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "User Information";
            // 
            // userNamechkbox
            // 
            this.userNamechkbox.AutoSize = true;
            this.userNamechkbox.Location = new System.Drawing.Point(39, 15);
            this.userNamechkbox.Name = "userNamechkbox";
            this.userNamechkbox.Size = new System.Drawing.Size(67, 17);
            this.userNamechkbox.TabIndex = 8;
            this.userNamechkbox.Text = "All Users";
            this.userNamechkbox.UseVisualStyleBackColor = true;
            this.userNamechkbox.CheckedChanged += new System.EventHandler(this.userNamechkbox_CheckedChanged);
            // 
            // UserInfo
            // 
            this.UserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserInfo.Location = new System.Drawing.Point(195, 56);
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(464, 95);
            this.UserInfo.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextUserName
            // 
            this.TextUserName.Location = new System.Drawing.Point(39, 111);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Size = new System.Drawing.Size(100, 20);
            this.TextUserName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Single User";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bookDetailsViewer);
            this.tabPage2.Controls.Add(this.textBookId);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Book Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(50, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Book ID";
            // 
            // textBookId
            // 
            this.textBookId.Location = new System.Drawing.Point(47, 93);
            this.textBookId.Name = "textBookId";
            this.textBookId.Size = new System.Drawing.Size(100, 20);
            this.textBookId.TabIndex = 2;
            // 
            // bookDetailsViewer
            // 
            this.bookDetailsViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookDetailsViewer.Location = new System.Drawing.Point(189, 34);
            this.bookDetailsViewer.Name = "bookDetailsViewer";
            this.bookDetailsViewer.Size = new System.Drawing.Size(480, 190);
            this.bookDetailsViewer.TabIndex = 3;
            // 
            // reportWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 426);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "reportWindow";
            this.Text = "Reports";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView UserInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox userNamechkbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView UserHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bookDetailsViewer;
        private System.Windows.Forms.TextBox textBookId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;

    }
}