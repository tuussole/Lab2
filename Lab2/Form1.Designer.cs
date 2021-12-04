
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
            this.filterButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.middleNameComboBox = new System.Windows.Forms.ComboBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fillButton = new System.Windows.Forms.Button();
            this.saxReaderRadioButton = new System.Windows.Forms.RadioButton();
            this.domReaderRadioButton = new System.Windows.Forms.RadioButton();
            this.linqReaderRadioButton = new System.Windows.Forms.RadioButton();
            this.clearFilters = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(362, 199);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 2;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(263, 352);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(110, 24);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.firstNameComboBox.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(29, 27);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(64, 15);
            this.firstNameLabel.TabIndex = 6;
            this.firstNameLabel.Text = "First Name";
            // 
            // middleNameComboBox
            // 
            this.middleNameComboBox.FormattingEnabled = true;
            this.middleNameComboBox.Location = new System.Drawing.Point(110, 53);
            this.middleNameComboBox.Name = "middleNameComboBox";
            this.middleNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.middleNameComboBox.TabIndex = 4;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(14, 56);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(79, 15);
            this.middleNameLabel.TabIndex = 6;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(110, 82);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 23);
            this.lastNameComboBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(30, 85);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(63, 15);
            this.lastNameLabel.TabIndex = 6;
            this.lastNameLabel.Text = "Last Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fillButton);
            this.groupBox1.Controls.Add(this.saxReaderRadioButton);
            this.groupBox1.Controls.Add(this.domReaderRadioButton);
            this.groupBox1.Controls.Add(this.linqReaderRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(315, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Readers";
            // 
            // fillButton
            // 
            this.fillButton.Location = new System.Drawing.Point(64, 97);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(75, 23);
            this.fillButton.TabIndex = 8;
            this.fillButton.Text = "Fill";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // saxReaderRadioButton
            // 
            this.saxReaderRadioButton.AutoSize = true;
            this.saxReaderRadioButton.Location = new System.Drawing.Point(16, 72);
            this.saxReaderRadioButton.Name = "saxReaderRadioButton";
            this.saxReaderRadioButton.Size = new System.Drawing.Size(106, 19);
            this.saxReaderRadioButton.TabIndex = 0;
            this.saxReaderRadioButton.TabStop = true;
            this.saxReaderRadioButton.Text = "SAX Api Reader";
            this.saxReaderRadioButton.UseVisualStyleBackColor = true;
            this.saxReaderRadioButton.CheckedChanged += new System.EventHandler(this.readerRadioButton_CheckedChanged);
            // 
            // domReaderRadioButton
            // 
            this.domReaderRadioButton.AutoSize = true;
            this.domReaderRadioButton.Location = new System.Drawing.Point(15, 47);
            this.domReaderRadioButton.Name = "domReaderRadioButton";
            this.domReaderRadioButton.Size = new System.Drawing.Size(113, 19);
            this.domReaderRadioButton.TabIndex = 0;
            this.domReaderRadioButton.TabStop = true;
            this.domReaderRadioButton.Text = "DOM Api Reader";
            this.domReaderRadioButton.UseVisualStyleBackColor = true;
            this.domReaderRadioButton.CheckedChanged += new System.EventHandler(this.readerRadioButton_CheckedChanged);
            // 
            // linqReaderRadioButton
            // 
            this.linqReaderRadioButton.AutoSize = true;
            this.linqReaderRadioButton.Location = new System.Drawing.Point(16, 22);
            this.linqReaderRadioButton.Name = "linqReaderRadioButton";
            this.linqReaderRadioButton.Size = new System.Drawing.Size(123, 19);
            this.linqReaderRadioButton.TabIndex = 0;
            this.linqReaderRadioButton.TabStop = true;
            this.linqReaderRadioButton.Text = "LinqToXML Reader";
            this.linqReaderRadioButton.UseVisualStyleBackColor = true;
            this.linqReaderRadioButton.CheckedChanged += new System.EventHandler(this.readerRadioButton_CheckedChanged);
            // 
            // clearFilters
            // 
            this.clearFilters.Location = new System.Drawing.Point(474, 199);
            this.clearFilters.Name = "clearFilters";
            this.clearFilters.Size = new System.Drawing.Size(109, 23);
            this.clearFilters.TabIndex = 2;
            this.clearFilters.Text = "Clear Filters";
            this.clearFilters.UseVisualStyleBackColor = true;
            this.clearFilters.Click += new System.EventHandler(this.clearFilters_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.middleNameComboBox);
            this.groupBox2.Controls.Add(this.firstNameComboBox);
            this.groupBox2.Controls.Add(this.lastNameLabel);
            this.groupBox2.Controls.Add(this.lastNameComboBox);
            this.groupBox2.Controls.Add(this.middleNameLabel);
            this.groupBox2.Controls.Add(this.firstNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(315, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 131);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Author";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.clearFilters);
            this.Controls.Add(this.filterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ComboBox middleNameComboBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton saxReaderRadioButton;
        private System.Windows.Forms.RadioButton domReaderRadioButton;
        private System.Windows.Forms.RadioButton linqReaderRadioButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button clearFilters;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

