namespace Make_orchestra.txt_file
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxSongList = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelDone = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.linkLabelProtip = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 253);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelWelcome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(612, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Welcome";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Location = new System.Drawing.Point(30, 30);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(49, 13);
            this.labelWelcome.TabIndex = 7;
            this.labelWelcome.Text = "welcome";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelTitle);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Title song";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(30, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(391, 13);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "To choose a title music, simply name is \"title.ogg\" and put it in the music direc" +
    "tory.";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.linkLabelProtip);
            this.tabPage3.Controls.Add(this.buttonRemove);
            this.tabPage3.Controls.Add(this.buttonAdd);
            this.tabPage3.Controls.Add(this.listBoxSongList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Build ingame playlist";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(531, 195);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(531, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxSongList
            // 
            this.listBoxSongList.FormattingEnabled = true;
            this.listBoxSongList.Location = new System.Drawing.Point(6, 6);
            this.listBoxSongList.Name = "listBoxSongList";
            this.listBoxSongList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSongList.Size = new System.Drawing.Size(519, 212);
            this.listBoxSongList.TabIndex = 0;
            this.listBoxSongList.DoubleClick += new System.EventHandler(this.listBoxSongList_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.labelDone);
            this.tabPage4.Controls.Add(this.buttonExport);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(612, 227);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Create orchestra.txt";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDone.Location = new System.Drawing.Point(76, 153);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(458, 16);
            this.labelDone.TabIndex = 1;
            this.labelDone.Text = "Export complete! Copy all the files to your music folder and enjoy.";
            this.labelDone.Visible = false;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(151, 73);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(276, 23);
            this.buttonExport.TabIndex = 0;
            this.buttonExport.Text = "Create orchestra.txt in current directory";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // linkLabelProtip
            // 
            this.linkLabelProtip.AutoSize = true;
            this.linkLabelProtip.Location = new System.Drawing.Point(544, 103);
            this.linkLabelProtip.Name = "linkLabelProtip";
            this.linkLabelProtip.Size = new System.Drawing.Size(47, 13);
            this.linkLabelProtip.TabIndex = 3;
            this.linkLabelProtip.TabStop = true;
            this.linkLabelProtip.Text = "PROTIP";
            this.linkLabelProtip.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProtip_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 277);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxSongList;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelProtip;
    }
}

