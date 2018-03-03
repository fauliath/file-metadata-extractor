namespace File_Metadata
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BUTTON_CLOSE = new File_Metadata.OnetsButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BUTTON_MINIMISE = new File_Metadata.OnetsButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TEXTBOX_FOLDER_PATH = new System.Windows.Forms.TextBox();
            this.SELECT_FOLDER_BUTTON = new File_Metadata.OnetsButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SELECT_CSV_BUTTON = new File_Metadata.OnetsButton();
            this.TEXTBOX_CSV_PATH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PANEL_CHECKBOX = new System.Windows.Forms.Panel();
            this.CHECKBOX_FILENAME = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_PATH = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_EXT = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_CREATED = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_MODIFIED = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_ACCESSED = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_AUTHOR = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_READONLY = new System.Windows.Forms.CheckBox();
            this.CHECKBOX_SIZE = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.TEXTBOX_ERROR_LOG = new System.Windows.Forms.TextBox();
            this.BUTTON_BEGIN = new System.Windows.Forms.Label();
            this.LABEL_ABOUT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.PANEL_CHECKBOX.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.LABEL_ABOUT);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.PANEL_CHECKBOX);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 526);
            this.panel1.TabIndex = 0;
            // 
            // BUTTON_CLOSE
            // 
            this.BUTTON_CLOSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BUTTON_CLOSE.FlatAppearance.BorderSize = 0;
            this.BUTTON_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BUTTON_CLOSE.Location = new System.Drawing.Point(543, 3);
            this.BUTTON_CLOSE.Name = "BUTTON_CLOSE";
            this.BUTTON_CLOSE.Size = new System.Drawing.Size(24, 22);
            this.BUTTON_CLOSE.TabIndex = 0;
            this.BUTTON_CLOSE.TabStop = false;
            this.BUTTON_CLOSE.Text = "X";
            this.BUTTON_CLOSE.UseVisualStyleBackColor = false;
            this.BUTTON_CLOSE.Click += new System.EventHandler(this.BUTTON_CLOSE_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.BUTTON_MINIMISE);
            this.panel2.Controls.Add(this.BUTTON_CLOSE);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 28);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_Form);
            // 
            // BUTTON_MINIMISE
            // 
            this.BUTTON_MINIMISE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BUTTON_MINIMISE.FlatAppearance.BorderSize = 0;
            this.BUTTON_MINIMISE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BUTTON_MINIMISE.ForeColor = System.Drawing.Color.White;
            this.BUTTON_MINIMISE.Location = new System.Drawing.Point(513, 3);
            this.BUTTON_MINIMISE.Name = "BUTTON_MINIMISE";
            this.BUTTON_MINIMISE.Size = new System.Drawing.Size(24, 22);
            this.BUTTON_MINIMISE.TabIndex = 1;
            this.BUTTON_MINIMISE.TabStop = false;
            this.BUTTON_MINIMISE.Text = "-";
            this.BUTTON_MINIMISE.UseVisualStyleBackColor = false;
            this.BUTTON_MINIMISE.Click += new System.EventHandler(this.BUTTON_MINIMISE_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SELECT_FOLDER_BUTTON);
            this.panel3.Controls.Add(this.TEXTBOX_FOLDER_PATH);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(11, 34);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 76);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the folder";
            // 
            // TEXTBOX_FOLDER_PATH
            // 
            this.TEXTBOX_FOLDER_PATH.BackColor = System.Drawing.Color.White;
            this.TEXTBOX_FOLDER_PATH.Location = new System.Drawing.Point(20, 40);
            this.TEXTBOX_FOLDER_PATH.Name = "TEXTBOX_FOLDER_PATH";
            this.TEXTBOX_FOLDER_PATH.Size = new System.Drawing.Size(461, 20);
            this.TEXTBOX_FOLDER_PATH.TabIndex = 3;
            // 
            // SELECT_FOLDER_BUTTON
            // 
            this.SELECT_FOLDER_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SELECT_FOLDER_BUTTON.FlatAppearance.BorderSize = 0;
            this.SELECT_FOLDER_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SELECT_FOLDER_BUTTON.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT_FOLDER_BUTTON.Location = new System.Drawing.Point(487, 40);
            this.SELECT_FOLDER_BUTTON.Name = "SELECT_FOLDER_BUTTON";
            this.SELECT_FOLDER_BUTTON.Size = new System.Drawing.Size(44, 20);
            this.SELECT_FOLDER_BUTTON.TabIndex = 3;
            this.SELECT_FOLDER_BUTTON.TabStop = false;
            this.SELECT_FOLDER_BUTTON.Text = "...";
            this.SELECT_FOLDER_BUTTON.UseVisualStyleBackColor = false;
            this.SELECT_FOLDER_BUTTON.Click += new System.EventHandler(this.SELECT_FOLDER_BUTTON_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SELECT_CSV_BUTTON);
            this.panel4.Controls.Add(this.TEXTBOX_CSV_PATH);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(540, 73);
            this.panel4.TabIndex = 3;
            // 
            // SELECT_CSV_BUTTON
            // 
            this.SELECT_CSV_BUTTON.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SELECT_CSV_BUTTON.FlatAppearance.BorderSize = 0;
            this.SELECT_CSV_BUTTON.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SELECT_CSV_BUTTON.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SELECT_CSV_BUTTON.Location = new System.Drawing.Point(487, 26);
            this.SELECT_CSV_BUTTON.Name = "SELECT_CSV_BUTTON";
            this.SELECT_CSV_BUTTON.Size = new System.Drawing.Size(44, 20);
            this.SELECT_CSV_BUTTON.TabIndex = 4;
            this.SELECT_CSV_BUTTON.TabStop = false;
            this.SELECT_CSV_BUTTON.Text = "...";
            this.SELECT_CSV_BUTTON.UseVisualStyleBackColor = false;
            this.SELECT_CSV_BUTTON.Click += new System.EventHandler(this.SELECT_CSV_BUTTON_Click);
            // 
            // TEXTBOX_CSV_PATH
            // 
            this.TEXTBOX_CSV_PATH.BackColor = System.Drawing.Color.White;
            this.TEXTBOX_CSV_PATH.Location = new System.Drawing.Point(20, 26);
            this.TEXTBOX_CSV_PATH.Name = "TEXTBOX_CSV_PATH";
            this.TEXTBOX_CSV_PATH.Size = new System.Drawing.Size(461, 20);
            this.TEXTBOX_CSV_PATH.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.label2.Location = new System.Drawing.Point(17, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select the destination for the CSV";
            // 
            // PANEL_CHECKBOX
            // 
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_SIZE);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_READONLY);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_AUTHOR);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_ACCESSED);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_MODIFIED);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_CREATED);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_EXT);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_PATH);
            this.PANEL_CHECKBOX.Controls.Add(this.CHECKBOX_FILENAME);
            this.PANEL_CHECKBOX.Location = new System.Drawing.Point(11, 195);
            this.PANEL_CHECKBOX.Name = "PANEL_CHECKBOX";
            this.PANEL_CHECKBOX.Size = new System.Drawing.Size(540, 82);
            this.PANEL_CHECKBOX.TabIndex = 4;
            // 
            // CHECKBOX_FILENAME
            // 
            this.CHECKBOX_FILENAME.AutoSize = true;
            this.CHECKBOX_FILENAME.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_FILENAME.Location = new System.Drawing.Point(20, 3);
            this.CHECKBOX_FILENAME.Name = "CHECKBOX_FILENAME";
            this.CHECKBOX_FILENAME.Size = new System.Drawing.Size(85, 21);
            this.CHECKBOX_FILENAME.TabIndex = 0;
            this.CHECKBOX_FILENAME.Text = "File Name";
            this.CHECKBOX_FILENAME.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_PATH
            // 
            this.CHECKBOX_PATH.AutoSize = true;
            this.CHECKBOX_PATH.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_PATH.Location = new System.Drawing.Point(20, 30);
            this.CHECKBOX_PATH.Name = "CHECKBOX_PATH";
            this.CHECKBOX_PATH.Size = new System.Drawing.Size(75, 21);
            this.CHECKBOX_PATH.TabIndex = 1;
            this.CHECKBOX_PATH.Text = "Full Path";
            this.CHECKBOX_PATH.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_EXT
            // 
            this.CHECKBOX_EXT.AutoSize = true;
            this.CHECKBOX_EXT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_EXT.Location = new System.Drawing.Point(20, 57);
            this.CHECKBOX_EXT.Name = "CHECKBOX_EXT";
            this.CHECKBOX_EXT.Size = new System.Drawing.Size(82, 21);
            this.CHECKBOX_EXT.TabIndex = 2;
            this.CHECKBOX_EXT.Text = "Extension";
            this.CHECKBOX_EXT.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_CREATED
            // 
            this.CHECKBOX_CREATED.AutoSize = true;
            this.CHECKBOX_CREATED.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_CREATED.Location = new System.Drawing.Point(188, 57);
            this.CHECKBOX_CREATED.Name = "CHECKBOX_CREATED";
            this.CHECKBOX_CREATED.Size = new System.Drawing.Size(94, 21);
            this.CHECKBOX_CREATED.TabIndex = 3;
            this.CHECKBOX_CREATED.Text = "Created On";
            this.CHECKBOX_CREATED.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_MODIFIED
            // 
            this.CHECKBOX_MODIFIED.AutoSize = true;
            this.CHECKBOX_MODIFIED.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_MODIFIED.Location = new System.Drawing.Point(188, 3);
            this.CHECKBOX_MODIFIED.Name = "CHECKBOX_MODIFIED";
            this.CHECKBOX_MODIFIED.Size = new System.Drawing.Size(101, 21);
            this.CHECKBOX_MODIFIED.TabIndex = 4;
            this.CHECKBOX_MODIFIED.Text = "Modified On";
            this.CHECKBOX_MODIFIED.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_ACCESSED
            // 
            this.CHECKBOX_ACCESSED.AutoSize = true;
            this.CHECKBOX_ACCESSED.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_ACCESSED.Location = new System.Drawing.Point(188, 30);
            this.CHECKBOX_ACCESSED.Name = "CHECKBOX_ACCESSED";
            this.CHECKBOX_ACCESSED.Size = new System.Drawing.Size(102, 21);
            this.CHECKBOX_ACCESSED.TabIndex = 5;
            this.CHECKBOX_ACCESSED.Text = "Accessed On";
            this.CHECKBOX_ACCESSED.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_AUTHOR
            // 
            this.CHECKBOX_AUTHOR.AutoSize = true;
            this.CHECKBOX_AUTHOR.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_AUTHOR.Location = new System.Drawing.Point(360, 57);
            this.CHECKBOX_AUTHOR.Name = "CHECKBOX_AUTHOR";
            this.CHECKBOX_AUTHOR.Size = new System.Drawing.Size(66, 21);
            this.CHECKBOX_AUTHOR.TabIndex = 6;
            this.CHECKBOX_AUTHOR.Text = "Author";
            this.CHECKBOX_AUTHOR.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_READONLY
            // 
            this.CHECKBOX_READONLY.AutoSize = true;
            this.CHECKBOX_READONLY.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_READONLY.Location = new System.Drawing.Point(360, 3);
            this.CHECKBOX_READONLY.Name = "CHECKBOX_READONLY";
            this.CHECKBOX_READONLY.Size = new System.Drawing.Size(87, 21);
            this.CHECKBOX_READONLY.TabIndex = 8;
            this.CHECKBOX_READONLY.Text = "Read Only";
            this.CHECKBOX_READONLY.UseVisualStyleBackColor = true;
            // 
            // CHECKBOX_SIZE
            // 
            this.CHECKBOX_SIZE.AutoSize = true;
            this.CHECKBOX_SIZE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHECKBOX_SIZE.Location = new System.Drawing.Point(360, 30);
            this.CHECKBOX_SIZE.Name = "CHECKBOX_SIZE";
            this.CHECKBOX_SIZE.Size = new System.Drawing.Size(121, 21);
            this.CHECKBOX_SIZE.TabIndex = 9;
            this.CHECKBOX_SIZE.Text = "File Size in Bytes";
            this.CHECKBOX_SIZE.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.BUTTON_BEGIN);
            this.panel6.Controls.Add(this.TEXTBOX_ERROR_LOG);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(11, 283);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(540, 212);
            this.panel6.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Error log";
            // 
            // TEXTBOX_ERROR_LOG
            // 
            this.TEXTBOX_ERROR_LOG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TEXTBOX_ERROR_LOG.Enabled = false;
            this.TEXTBOX_ERROR_LOG.Location = new System.Drawing.Point(20, 67);
            this.TEXTBOX_ERROR_LOG.Multiline = true;
            this.TEXTBOX_ERROR_LOG.Name = "TEXTBOX_ERROR_LOG";
            this.TEXTBOX_ERROR_LOG.Size = new System.Drawing.Size(511, 130);
            this.TEXTBOX_ERROR_LOG.TabIndex = 5;
            // 
            // BUTTON_BEGIN
            // 
            this.BUTTON_BEGIN.AutoSize = true;
            this.BUTTON_BEGIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BUTTON_BEGIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BUTTON_BEGIN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_BEGIN.ForeColor = System.Drawing.Color.White;
            this.BUTTON_BEGIN.Location = new System.Drawing.Point(209, 10);
            this.BUTTON_BEGIN.Margin = new System.Windows.Forms.Padding(10);
            this.BUTTON_BEGIN.Name = "BUTTON_BEGIN";
            this.BUTTON_BEGIN.Padding = new System.Windows.Forms.Padding(17, 8, 17, 8);
            this.BUTTON_BEGIN.Size = new System.Drawing.Size(81, 36);
            this.BUTTON_BEGIN.TabIndex = 4;
            this.BUTTON_BEGIN.Text = "Begin";
            this.BUTTON_BEGIN.Click += new System.EventHandler(this.BUTTON_BEGIN_Click);
            // 
            // LABEL_ABOUT
            // 
            this.LABEL_ABOUT.AutoSize = true;
            this.LABEL_ABOUT.BackColor = System.Drawing.SystemColors.Window;
            this.LABEL_ABOUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LABEL_ABOUT.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_ABOUT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.LABEL_ABOUT.Location = new System.Drawing.Point(206, 505);
            this.LABEL_ABOUT.Name = "LABEL_ABOUT";
            this.LABEL_ABOUT.Size = new System.Drawing.Size(120, 13);
            this.LABEL_ABOUT.TabIndex = 4;
            this.LABEL_ABOUT.Text = "About the application";
            this.LABEL_ABOUT.Click += new System.EventHandler(this.LABEL_ABOUT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "File Metadata Extractor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(49)))), ((int)(((byte)(57)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(4, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 11);
            this.label5.TabIndex = 5;
            this.label5.Text = "version 0.23";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(572, 528);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.PANEL_CHECKBOX.ResumeLayout(false);
            this.PANEL_CHECKBOX.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OnetsButton BUTTON_CLOSE;
        private System.Windows.Forms.Panel panel2;
        private OnetsButton BUTTON_MINIMISE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TEXTBOX_FOLDER_PATH;
        private OnetsButton SELECT_FOLDER_BUTTON;
        private System.Windows.Forms.Panel panel4;
        private OnetsButton SELECT_CSV_BUTTON;
        private System.Windows.Forms.TextBox TEXTBOX_CSV_PATH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PANEL_CHECKBOX;
        private System.Windows.Forms.CheckBox CHECKBOX_PATH;
        private System.Windows.Forms.CheckBox CHECKBOX_FILENAME;
        private System.Windows.Forms.CheckBox CHECKBOX_CREATED;
        private System.Windows.Forms.CheckBox CHECKBOX_EXT;
        private System.Windows.Forms.CheckBox CHECKBOX_ACCESSED;
        private System.Windows.Forms.CheckBox CHECKBOX_MODIFIED;
        private System.Windows.Forms.CheckBox CHECKBOX_AUTHOR;
        private System.Windows.Forms.CheckBox CHECKBOX_READONLY;
        private System.Windows.Forms.CheckBox CHECKBOX_SIZE;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TEXTBOX_ERROR_LOG;
        private System.Windows.Forms.Label BUTTON_BEGIN;
        private System.Windows.Forms.Label LABEL_ABOUT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

