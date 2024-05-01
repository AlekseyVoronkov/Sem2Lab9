namespace CSharpLab8
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
            this.sourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.targetDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSynchronizeDirectories = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sourceDirectoryTextBox
            // 
            this.sourceDirectoryTextBox.BackColor = System.Drawing.Color.Wheat;
            this.sourceDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sourceDirectoryTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceDirectoryTextBox.Location = new System.Drawing.Point(304, 78);
            this.sourceDirectoryTextBox.Name = "sourceDirectoryTextBox";
            this.sourceDirectoryTextBox.Size = new System.Drawing.Size(484, 38);
            this.sourceDirectoryTextBox.TabIndex = 0;
            // 
            // targetDirectoryTextBox
            // 
            this.targetDirectoryTextBox.BackColor = System.Drawing.Color.Wheat;
            this.targetDirectoryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.targetDirectoryTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetDirectoryTextBox.Location = new System.Drawing.Point(304, 15);
            this.targetDirectoryTextBox.Name = "targetDirectoryTextBox";
            this.targetDirectoryTextBox.Size = new System.Drawing.Size(484, 38);
            this.targetDirectoryTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Source Directory Path: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(6, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Target Directory Path: ";
            // 
            // buttonSynchronizeDirectories
            // 
            this.buttonSynchronizeDirectories.BackColor = System.Drawing.Color.Firebrick;
            this.buttonSynchronizeDirectories.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSynchronizeDirectories.FlatAppearance.BorderSize = 10;
            this.buttonSynchronizeDirectories.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSynchronizeDirectories.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonSynchronizeDirectories.Location = new System.Drawing.Point(208, 480);
            this.buttonSynchronizeDirectories.Name = "buttonSynchronizeDirectories";
            this.buttonSynchronizeDirectories.Size = new System.Drawing.Size(393, 116);
            this.buttonSynchronizeDirectories.TabIndex = 5;
            this.buttonSynchronizeDirectories.Text = "Synchronize Directories";
            this.buttonSynchronizeDirectories.UseVisualStyleBackColor = false;
            this.buttonSynchronizeDirectories.Click += new System.EventHandler(this.buttonSynchronizeDirectories_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(607, 530);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "<== Scary Red Button";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(90, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Scary Red Button ==>";
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.Wheat;
            this.listBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 38;
            this.listBox.Location = new System.Drawing.Point(12, 145);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(779, 308);
            this.listBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(803, 632);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSynchronizeDirectories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.targetDirectoryTextBox);
            this.Controls.Add(this.sourceDirectoryTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourceDirectoryTextBox;
        private System.Windows.Forms.TextBox targetDirectoryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSynchronizeDirectories;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox;
    }
}

