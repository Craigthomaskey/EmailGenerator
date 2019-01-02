namespace EmailGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RelaseNotesList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearReleaseNotesBttn = new System.Windows.Forms.Button();
            this.GetReleaseNotesBttn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.NotesBox = new System.Windows.Forms.TextBox();
            this.SendBttn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ClearAttachmentsBttn = new System.Windows.Forms.Button();
            this.GetAttachmentsBttn = new System.Windows.Forms.Button();
            this.AttachmentsList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.DataTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // RelaseNotesList
            // 
            this.RelaseNotesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RelaseNotesList.BackColor = System.Drawing.SystemColors.Control;
            this.RelaseNotesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RelaseNotesList.FormattingEnabled = true;
            this.RelaseNotesList.HorizontalScrollbar = true;
            this.RelaseNotesList.Items.AddRange(new object[] {
            "Release Notes",
            "Clear this at load",
            "Just for testing"});
            this.RelaseNotesList.Location = new System.Drawing.Point(5, 9);
            this.RelaseNotesList.Name = "RelaseNotesList";
            this.RelaseNotesList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RelaseNotesList.Size = new System.Drawing.Size(123, 91);
            this.RelaseNotesList.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ClearReleaseNotesBttn);
            this.panel1.Controls.Add(this.GetReleaseNotesBttn);
            this.panel1.Controls.Add(this.RelaseNotesList);
            this.panel1.Location = new System.Drawing.Point(233, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 132);
            this.panel1.TabIndex = 1;
            // 
            // ClearReleaseNotesBttn
            // 
            this.ClearReleaseNotesBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearReleaseNotesBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearReleaseNotesBttn.Location = new System.Drawing.Point(68, 103);
            this.ClearReleaseNotesBttn.Name = "ClearReleaseNotesBttn";
            this.ClearReleaseNotesBttn.Size = new System.Drawing.Size(62, 23);
            this.ClearReleaseNotesBttn.TabIndex = 6;
            this.ClearReleaseNotesBttn.Text = "Clear";
            this.ClearReleaseNotesBttn.UseVisualStyleBackColor = true;
            this.ClearReleaseNotesBttn.Click += new System.EventHandler(this.ClearReleaseNotesBttn_Click);
            // 
            // GetReleaseNotesBttn
            // 
            this.GetReleaseNotesBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GetReleaseNotesBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetReleaseNotesBttn.Location = new System.Drawing.Point(3, 103);
            this.GetReleaseNotesBttn.Name = "GetReleaseNotesBttn";
            this.GetReleaseNotesBttn.Size = new System.Drawing.Size(62, 23);
            this.GetReleaseNotesBttn.TabIndex = 6;
            this.GetReleaseNotesBttn.Text = "Get";
            this.GetReleaseNotesBttn.UseVisualStyleBackColor = true;
            this.GetReleaseNotesBttn.Click += new System.EventHandler(this.GetReleaseNotesBttn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Release Notes";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.Control;
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailBox.Location = new System.Drawing.Point(3, 3);
            this.EmailBox.Multiline = true;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(187, 253);
            this.EmailBox.TabIndex = 3;
            this.EmailBox.Text = "This will be the body of the email.\r\n\r\nThis will give a basic look at the email b" +
    "efor it is sent.\r\n";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Previews";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DataTabs);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 302);
            this.panel2.TabIndex = 4;
            // 
            // DataTabs
            // 
            this.DataTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTabs.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.DataTabs.Controls.Add(this.tabPage1);
            this.DataTabs.Controls.Add(this.tabPage2);
            this.DataTabs.Location = new System.Drawing.Point(6, 9);
            this.DataTabs.Multiline = true;
            this.DataTabs.Name = "DataTabs";
            this.DataTabs.SelectedIndex = 0;
            this.DataTabs.Size = new System.Drawing.Size(201, 288);
            this.DataTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EmailBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(193, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Email Body";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.NotesBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(193, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Notes File";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // NotesBox
            // 
            this.NotesBox.BackColor = System.Drawing.SystemColors.Control;
            this.NotesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NotesBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesBox.Location = new System.Drawing.Point(3, 3);
            this.NotesBox.Multiline = true;
            this.NotesBox.Name = "NotesBox";
            this.NotesBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NotesBox.Size = new System.Drawing.Size(187, 253);
            this.NotesBox.TabIndex = 4;
            this.NotesBox.Text = "This will be a bunch of files brought into one txt file.\r\n\r\nThis will mainly be f" +
    "or release notes.\r\n\r\nAdditional tabs may be created for aditional files.\r\n";
            this.NotesBox.WordWrap = false;
            // 
            // SendBttn
            // 
            this.SendBttn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendBttn.Location = new System.Drawing.Point(233, 290);
            this.SendBttn.Name = "SendBttn";
            this.SendBttn.Size = new System.Drawing.Size(65, 24);
            this.SendBttn.TabIndex = 6;
            this.SendBttn.Text = "Send";
            this.SendBttn.UseVisualStyleBackColor = true;
            this.SendBttn.Click += new System.EventHandler(this.SendBttn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.ClearAttachmentsBttn);
            this.panel3.Controls.Add(this.GetAttachmentsBttn);
            this.panel3.Controls.Add(this.AttachmentsList);
            this.panel3.Location = new System.Drawing.Point(233, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 132);
            this.panel3.TabIndex = 1;
            // 
            // ClearAttachmentsBttn
            // 
            this.ClearAttachmentsBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ClearAttachmentsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAttachmentsBttn.Location = new System.Drawing.Point(68, 103);
            this.ClearAttachmentsBttn.Name = "ClearAttachmentsBttn";
            this.ClearAttachmentsBttn.Size = new System.Drawing.Size(62, 23);
            this.ClearAttachmentsBttn.TabIndex = 6;
            this.ClearAttachmentsBttn.Text = "Clear";
            this.ClearAttachmentsBttn.UseVisualStyleBackColor = true;
            this.ClearAttachmentsBttn.Click += new System.EventHandler(this.ClearAttachmentsBttn_Click);
            // 
            // GetAttachmentsBttn
            // 
            this.GetAttachmentsBttn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GetAttachmentsBttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetAttachmentsBttn.Location = new System.Drawing.Point(3, 103);
            this.GetAttachmentsBttn.Name = "GetAttachmentsBttn";
            this.GetAttachmentsBttn.Size = new System.Drawing.Size(62, 23);
            this.GetAttachmentsBttn.TabIndex = 6;
            this.GetAttachmentsBttn.Text = "Get";
            this.GetAttachmentsBttn.UseVisualStyleBackColor = true;
            this.GetAttachmentsBttn.Click += new System.EventHandler(this.GetAttachmentsBttn_Click);
            // 
            // AttachmentsList
            // 
            this.AttachmentsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttachmentsList.BackColor = System.Drawing.SystemColors.Control;
            this.AttachmentsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttachmentsList.FormattingEnabled = true;
            this.AttachmentsList.HorizontalScrollbar = true;
            this.AttachmentsList.Items.AddRange(new object[] {
            "List files here",
            "Will attach these to email",
            "This txt is for testing"});
            this.AttachmentsList.Location = new System.Drawing.Point(5, 9);
            this.AttachmentsList.Name = "AttachmentsList";
            this.AttachmentsList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AttachmentsList.Size = new System.Drawing.Size(123, 91);
            this.AttachmentsList.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Attachments";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 322);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SendBttn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(394, 360);
            this.Name = "Form1";
            this.Text = "Email Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.DataTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RelaseNotesList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ClearReleaseNotesBttn;
        private System.Windows.Forms.Button GetReleaseNotesBttn;
        private System.Windows.Forms.TabControl DataTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox NotesBox;
        private System.Windows.Forms.Button SendBttn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ClearAttachmentsBttn;
        private System.Windows.Forms.Button GetAttachmentsBttn;
        private System.Windows.Forms.ListBox AttachmentsList;
        private System.Windows.Forms.Label label3;
    }
}

