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
            this.tabControlVictory = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelWelcome = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTitle = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.linkLabelProtipAmbient = new System.Windows.Forms.LinkLabel();
            this.buttonRemoveAmbient = new System.Windows.Forms.Button();
            this.buttonAddAmbient = new System.Windows.Forms.Button();
            this.listBoxSongListAmbient = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonRemoveVictory = new System.Windows.Forms.Button();
            this.buttonAddVictory = new System.Windows.Forms.Button();
            this.listBoxSongListVictory = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.buttonRemoveDefeat = new System.Windows.Forms.Button();
            this.buttonAddDefeat = new System.Windows.Forms.Button();
            this.listBoxSongListDefeat = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.labelDone = new System.Windows.Forms.Label();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonShuffleAmbient = new System.Windows.Forms.Button();
            this.buttonShuffleVictory = new System.Windows.Forms.Button();
            this.buttonShuffleDefeat = new System.Windows.Forms.Button();
            this.tabControlVictory.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVictory
            // 
            this.tabControlVictory.Controls.Add(this.tabPage1);
            this.tabControlVictory.Controls.Add(this.tabPage2);
            this.tabControlVictory.Controls.Add(this.tabPage3);
            this.tabControlVictory.Controls.Add(this.tabPage5);
            this.tabControlVictory.Controls.Add(this.tabPage6);
            this.tabControlVictory.Controls.Add(this.tabPage4);
            this.tabControlVictory.Location = new System.Drawing.Point(12, 12);
            this.tabControlVictory.Name = "tabControlVictory";
            this.tabControlVictory.SelectedIndex = 0;
            this.tabControlVictory.Size = new System.Drawing.Size(620, 253);
            this.tabControlVictory.TabIndex = 0;
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
            this.tabPage3.Controls.Add(this.buttonShuffleAmbient);
            this.tabPage3.Controls.Add(this.linkLabelProtipAmbient);
            this.tabPage3.Controls.Add(this.buttonRemoveAmbient);
            this.tabPage3.Controls.Add(this.buttonAddAmbient);
            this.tabPage3.Controls.Add(this.listBoxSongListAmbient);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Playlist (Ambient)";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // linkLabelProtipAmbient
            // 
            this.linkLabelProtipAmbient.AutoSize = true;
            this.linkLabelProtipAmbient.Location = new System.Drawing.Point(544, 104);
            this.linkLabelProtipAmbient.Name = "linkLabelProtipAmbient";
            this.linkLabelProtipAmbient.Size = new System.Drawing.Size(47, 13);
            this.linkLabelProtipAmbient.TabIndex = 3;
            this.linkLabelProtipAmbient.TabStop = true;
            this.linkLabelProtipAmbient.Text = "PROTIP";
            this.linkLabelProtipAmbient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelProtip_LinkClicked);
            // 
            // buttonRemoveAmbient
            // 
            this.buttonRemoveAmbient.Location = new System.Drawing.Point(531, 196);
            this.buttonRemoveAmbient.Name = "buttonRemoveAmbient";
            this.buttonRemoveAmbient.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveAmbient.TabIndex = 2;
            this.buttonRemoveAmbient.Text = "Remove";
            this.buttonRemoveAmbient.UseVisualStyleBackColor = true;
            this.buttonRemoveAmbient.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAddAmbient
            // 
            this.buttonAddAmbient.Location = new System.Drawing.Point(531, 7);
            this.buttonAddAmbient.Name = "buttonAddAmbient";
            this.buttonAddAmbient.Size = new System.Drawing.Size(75, 23);
            this.buttonAddAmbient.TabIndex = 1;
            this.buttonAddAmbient.Text = "Add";
            this.buttonAddAmbient.UseVisualStyleBackColor = true;
            this.buttonAddAmbient.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxSongListAmbient
            // 
            this.listBoxSongListAmbient.FormattingEnabled = true;
            this.listBoxSongListAmbient.Location = new System.Drawing.Point(6, 7);
            this.listBoxSongListAmbient.Name = "listBoxSongListAmbient";
            this.listBoxSongListAmbient.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSongListAmbient.Size = new System.Drawing.Size(519, 212);
            this.listBoxSongListAmbient.TabIndex = 0;
            this.listBoxSongListAmbient.DoubleClick += new System.EventHandler(this.listBoxSongList_DoubleClick);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonShuffleVictory);
            this.tabPage5.Controls.Add(this.buttonRemoveVictory);
            this.tabPage5.Controls.Add(this.buttonAddVictory);
            this.tabPage5.Controls.Add(this.listBoxSongListVictory);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(612, 227);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Playlist (Victory)";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveVictory
            // 
            this.buttonRemoveVictory.Location = new System.Drawing.Point(531, 196);
            this.buttonRemoveVictory.Name = "buttonRemoveVictory";
            this.buttonRemoveVictory.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveVictory.TabIndex = 6;
            this.buttonRemoveVictory.Text = "Remove";
            this.buttonRemoveVictory.UseVisualStyleBackColor = true;
            this.buttonRemoveVictory.Click += new System.EventHandler(this.buttonRemoveVictory_Click);
            // 
            // buttonAddVictory
            // 
            this.buttonAddVictory.Location = new System.Drawing.Point(531, 7);
            this.buttonAddVictory.Name = "buttonAddVictory";
            this.buttonAddVictory.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVictory.TabIndex = 5;
            this.buttonAddVictory.Text = "Add";
            this.buttonAddVictory.UseVisualStyleBackColor = true;
            this.buttonAddVictory.Click += new System.EventHandler(this.buttonAddVictory_Click);
            // 
            // listBoxSongListVictory
            // 
            this.listBoxSongListVictory.FormattingEnabled = true;
            this.listBoxSongListVictory.Location = new System.Drawing.Point(6, 7);
            this.listBoxSongListVictory.Name = "listBoxSongListVictory";
            this.listBoxSongListVictory.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSongListVictory.Size = new System.Drawing.Size(519, 212);
            this.listBoxSongListVictory.TabIndex = 4;
            this.listBoxSongListVictory.DoubleClick += new System.EventHandler(this.listBoxSongListVictory_DoubleClick);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.buttonShuffleDefeat);
            this.tabPage6.Controls.Add(this.buttonRemoveDefeat);
            this.tabPage6.Controls.Add(this.buttonAddDefeat);
            this.tabPage6.Controls.Add(this.listBoxSongListDefeat);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(612, 227);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Playlist (Defeat)";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveDefeat
            // 
            this.buttonRemoveDefeat.Location = new System.Drawing.Point(531, 196);
            this.buttonRemoveDefeat.Name = "buttonRemoveDefeat";
            this.buttonRemoveDefeat.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDefeat.TabIndex = 6;
            this.buttonRemoveDefeat.Text = "Remove";
            this.buttonRemoveDefeat.UseVisualStyleBackColor = true;
            this.buttonRemoveDefeat.Click += new System.EventHandler(this.buttonRemoveDefeat_Click);
            // 
            // buttonAddDefeat
            // 
            this.buttonAddDefeat.Location = new System.Drawing.Point(531, 7);
            this.buttonAddDefeat.Name = "buttonAddDefeat";
            this.buttonAddDefeat.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDefeat.TabIndex = 5;
            this.buttonAddDefeat.Text = "Add";
            this.buttonAddDefeat.UseVisualStyleBackColor = true;
            this.buttonAddDefeat.Click += new System.EventHandler(this.buttonAddDefeat_Click);
            // 
            // listBoxSongListDefeat
            // 
            this.listBoxSongListDefeat.FormattingEnabled = true;
            this.listBoxSongListDefeat.Location = new System.Drawing.Point(6, 7);
            this.listBoxSongListDefeat.Name = "listBoxSongListDefeat";
            this.listBoxSongListDefeat.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSongListDefeat.Size = new System.Drawing.Size(519, 212);
            this.listBoxSongListDefeat.TabIndex = 4;
            this.listBoxSongListDefeat.DoubleClick += new System.EventHandler(this.listBoxSongListDefeat_DoubleClick);
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
            // buttonShuffleAmbient
            // 
            this.buttonShuffleAmbient.Location = new System.Drawing.Point(531, 120);
            this.buttonShuffleAmbient.Name = "buttonShuffleAmbient";
            this.buttonShuffleAmbient.Size = new System.Drawing.Size(75, 23);
            this.buttonShuffleAmbient.TabIndex = 4;
            this.buttonShuffleAmbient.Text = "Shuffle";
            this.buttonShuffleAmbient.UseVisualStyleBackColor = true;
            this.buttonShuffleAmbient.Click += new System.EventHandler(this.buttonShuffleAmbient_Click);
            // 
            // buttonShuffleVictory
            // 
            this.buttonShuffleVictory.Location = new System.Drawing.Point(531, 120);
            this.buttonShuffleVictory.Name = "buttonShuffleVictory";
            this.buttonShuffleVictory.Size = new System.Drawing.Size(75, 23);
            this.buttonShuffleVictory.TabIndex = 7;
            this.buttonShuffleVictory.Text = "Shuffle";
            this.buttonShuffleVictory.UseVisualStyleBackColor = true;
            this.buttonShuffleVictory.Click += new System.EventHandler(this.buttonShuffleVictory_Click);
            // 
            // buttonShuffleDefeat
            // 
            this.buttonShuffleDefeat.Location = new System.Drawing.Point(531, 120);
            this.buttonShuffleDefeat.Name = "buttonShuffleDefeat";
            this.buttonShuffleDefeat.Size = new System.Drawing.Size(75, 23);
            this.buttonShuffleDefeat.TabIndex = 7;
            this.buttonShuffleDefeat.Text = "Shuffle";
            this.buttonShuffleDefeat.UseVisualStyleBackColor = true;
            this.buttonShuffleDefeat.Click += new System.EventHandler(this.buttonShuffleDefeat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 277);
            this.Controls.Add(this.tabControlVictory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlVictory.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVictory;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonRemoveAmbient;
        private System.Windows.Forms.Button buttonAddAmbient;
        private System.Windows.Forms.ListBox listBoxSongListAmbient;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.LinkLabel linkLabelProtipAmbient;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonRemoveVictory;
        private System.Windows.Forms.Button buttonAddVictory;
        private System.Windows.Forms.ListBox listBoxSongListVictory;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button buttonRemoveDefeat;
        private System.Windows.Forms.Button buttonAddDefeat;
        private System.Windows.Forms.ListBox listBoxSongListDefeat;
        private System.Windows.Forms.Button buttonShuffleAmbient;
        private System.Windows.Forms.Button buttonShuffleVictory;
        private System.Windows.Forms.Button buttonShuffleDefeat;
    }
}

