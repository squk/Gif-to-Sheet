namespace Gif_to_Sheet
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
            this.tbFile = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pbSprite = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderGoButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.outputFolderBox = new System.Windows.Forms.TextBox();
            this.exportFolderButton = new System.Windows.Forms.Button();
            this.inputFolderBox = new System.Windows.Forms.TextBox();
            this.inputFolderButton = new System.Windows.Forms.Button();
            this.squareCheck = new System.Windows.Forms.CheckBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFile
            // 
            this.tbFile.Location = new System.Drawing.Point(6, 19);
            this.tbFile.Name = "tbFile";
            this.tbFile.ReadOnly = true;
            this.tbFile.Size = new System.Drawing.Size(189, 20);
            this.tbFile.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(201, 17);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panelMain
            // 
            this.panelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Controls.Add(this.pbSprite);
            this.panelMain.Location = new System.Drawing.Point(12, 227);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(390, 355);
            this.panelMain.TabIndex = 5;
            // 
            // pbSprite
            // 
            this.pbSprite.Location = new System.Drawing.Point(0, 0);
            this.pbSprite.Name = "pbSprite";
            this.pbSprite.Size = new System.Drawing.Size(100, 50);
            this.pbSprite.TabIndex = 0;
            this.pbSprite.TabStop = false;
            this.pbSprite.Visible = false;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(201, 40);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbFile);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 76);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Single File";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.folderGoButton);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.outputFolderBox);
            this.groupBox2.Controls.Add(this.exportFolderButton);
            this.groupBox2.Controls.Add(this.inputFolderBox);
            this.groupBox2.Controls.Add(this.inputFolderButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 104);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folder";
            // 
            // folderGoButton
            // 
            this.folderGoButton.Location = new System.Drawing.Point(336, 75);
            this.folderGoButton.Name = "folderGoButton";
            this.folderGoButton.Size = new System.Drawing.Size(39, 23);
            this.folderGoButton.TabIndex = 7;
            this.folderGoButton.Text = "Go!";
            this.folderGoButton.UseVisualStyleBackColor = true;
            this.folderGoButton.Click += new System.EventHandler(this.folderGoButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output";
            // 
            // outputFolderBox
            // 
            this.outputFolderBox.Location = new System.Drawing.Point(51, 49);
            this.outputFolderBox.Name = "outputFolderBox";
            this.outputFolderBox.ReadOnly = true;
            this.outputFolderBox.Size = new System.Drawing.Size(235, 20);
            this.outputFolderBox.TabIndex = 4;
            // 
            // exportFolderButton
            // 
            this.exportFolderButton.Location = new System.Drawing.Point(292, 47);
            this.exportFolderButton.Name = "exportFolderButton";
            this.exportFolderButton.Size = new System.Drawing.Size(83, 23);
            this.exportFolderButton.TabIndex = 3;
            this.exportFolderButton.Text = "Choose Folder";
            this.exportFolderButton.UseVisualStyleBackColor = true;
            this.exportFolderButton.Click += new System.EventHandler(this.exportFolderButton_Click);
            // 
            // inputFolderBox
            // 
            this.inputFolderBox.Location = new System.Drawing.Point(51, 20);
            this.inputFolderBox.Name = "inputFolderBox";
            this.inputFolderBox.ReadOnly = true;
            this.inputFolderBox.Size = new System.Drawing.Size(235, 20);
            this.inputFolderBox.TabIndex = 2;
            // 
            // inputFolderButton
            // 
            this.inputFolderButton.Location = new System.Drawing.Point(292, 18);
            this.inputFolderButton.Name = "inputFolderButton";
            this.inputFolderButton.Size = new System.Drawing.Size(83, 23);
            this.inputFolderButton.TabIndex = 0;
            this.inputFolderButton.Text = "Choose Folder";
            this.inputFolderButton.UseVisualStyleBackColor = true;
            this.inputFolderButton.Click += new System.EventHandler(this.inputFolderButton_Click);
            // 
            // squareCheck
            // 
            this.squareCheck.AutoSize = true;
            this.squareCheck.Checked = true;
            this.squareCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.squareCheck.Location = new System.Drawing.Point(12, 204);
            this.squareCheck.Name = "squareCheck";
            this.squareCheck.Size = new System.Drawing.Size(122, 17);
            this.squareCheck.TabIndex = 11;
            this.squareCheck.Text = "Make Image Square";
            this.squareCheck.UseVisualStyleBackColor = true;
            this.squareCheck.CheckedChanged += new System.EventHandler(this.squareCheck_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 594);
            this.Controls.Add(this.squareCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelMain);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GIF to Spritesheet";
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSprite)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFile;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pbSprite;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox inputFolderBox;
        private System.Windows.Forms.Button inputFolderButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox outputFolderBox;
        private System.Windows.Forms.Button exportFolderButton;
        private System.Windows.Forms.Button folderGoButton;
        private System.Windows.Forms.CheckBox squareCheck;
    }
}

