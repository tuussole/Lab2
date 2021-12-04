
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameComboBox = new System.Windows.Forms.ComboBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(263, 352);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(411, 64);
            this.firstNameComboBox.Name = "comboBox1";
            this.firstNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.firstNameComboBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Author";
            // 
            // label2
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(330, 67);
            this.firstNameLabel.Name = "label2";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // comboBox2
            // 
            this.middleNameComboBox.FormattingEnabled = true;
            this.middleNameComboBox.Location = new System.Drawing.Point(411, 93);
            this.middleNameComboBox.Name = "comboBox2";
            this.middleNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.middleNameComboBox.TabIndex = 4;
            // 
            // label3
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(315, 96);
            this.middleNameLabel.Name = "label3";
            this.middleNameLabel.Size = new System.Drawing.Size(79, 15);
            this.middleNameLabel.TabIndex = 6;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // comboBox3
            // 
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(411, 122);
            this.lastNameComboBox.Name = "comboBox3";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.lastNameComboBox.TabIndex = 4;
            // 
            // label4
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(331, 125);
            this.lastNameLabel.Name = "label4";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameComboBox);
            this.Controls.Add(this.middleNameComboBox);
            this.Controls.Add(this.firstNameComboBox);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ComboBox middleNameComboBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.Label lastNameLabel;
    }
}

