namespace UVSimWindowsFormsUI
{
    partial class UVSimDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UVSimDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commandValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.submitCommandDirectButton = new System.Windows.Forms.Button();
            this.submitCommandEasyButton = new System.Windows.Forms.Button();
            this.operandValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.operationsDropdown = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currentProgramListbox = new System.Windows.Forms.ListBox();
            this.runProgramButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(126, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(24, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "The Old-Fashioned Way";
            // 
            // commandValue
            // 
            this.commandValue.Location = new System.Drawing.Point(214, 448);
            this.commandValue.Name = "commandValue";
            this.commandValue.Size = new System.Drawing.Size(172, 26);
            this.commandValue.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(130, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Commands";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(24, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 38);
            this.label4.TabIndex = 5;
            this.label4.Text = "The Easy Way";
            // 
            // submitCommandDirectButton
            // 
            this.submitCommandDirectButton.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.submitCommandDirectButton.Location = new System.Drawing.Point(45, 494);
            this.submitCommandDirectButton.Name = "submitCommandDirectButton";
            this.submitCommandDirectButton.Size = new System.Drawing.Size(171, 55);
            this.submitCommandDirectButton.TabIndex = 6;
            this.submitCommandDirectButton.Text = "Submit Command";
            this.submitCommandDirectButton.UseVisualStyleBackColor = true;
            this.submitCommandDirectButton.Click += new System.EventHandler(this.SubmitCommandDirectButton_Click);
            // 
            // submitCommandEasyButton
            // 
            this.submitCommandEasyButton.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.submitCommandEasyButton.Location = new System.Drawing.Point(45, 292);
            this.submitCommandEasyButton.Name = "submitCommandEasyButton";
            this.submitCommandEasyButton.Size = new System.Drawing.Size(171, 55);
            this.submitCommandEasyButton.TabIndex = 7;
            this.submitCommandEasyButton.Text = "Submit Command";
            this.submitCommandEasyButton.UseVisualStyleBackColor = true;
            this.submitCommandEasyButton.Click += new System.EventHandler(this.SubmitCommandEasyButton_Click);
            // 
            // operandValue
            // 
            this.operandValue.Location = new System.Drawing.Point(153, 250);
            this.operandValue.Name = "operandValue";
            this.operandValue.Size = new System.Drawing.Size(172, 26);
            this.operandValue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(40, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(40, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Operation:";
            // 
            // operationsDropdown
            // 
            this.operationsDropdown.FormattingEnabled = true;
            this.operationsDropdown.Location = new System.Drawing.Point(153, 195);
            this.operationsDropdown.Name = "operationsDropdown";
            this.operationsDropdown.Size = new System.Drawing.Size(172, 28);
            this.operationsDropdown.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(40, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Enter Command:";
            // 
            // currentProgramListbox
            // 
            this.currentProgramListbox.FormattingEnabled = true;
            this.currentProgramListbox.ItemHeight = 20;
            this.currentProgramListbox.Location = new System.Drawing.Point(82, 660);
            this.currentProgramListbox.Name = "currentProgramListbox";
            this.currentProgramListbox.Size = new System.Drawing.Size(212, 364);
            this.currentProgramListbox.TabIndex = 14;
            // 
            // runProgramButton
            // 
            this.runProgramButton.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.runProgramButton.Location = new System.Drawing.Point(82, 1038);
            this.runProgramButton.Name = "runProgramButton";
            this.runProgramButton.Size = new System.Drawing.Size(214, 85);
            this.runProgramButton.TabIndex = 15;
            this.runProgramButton.Text = "Run Program";
            this.runProgramButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(522, 148);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 876);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.consoleLabel.Location = new System.Drawing.Point(705, 105);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(116, 38);
            this.consoleLabel.TabIndex = 17;
            this.consoleLabel.Text = "Console";
            // 
            // UVSimDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 1152);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.runProgramButton);
            this.Controls.Add(this.currentProgramListbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.operationsDropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.operandValue);
            this.Controls.Add(this.submitCommandEasyButton);
            this.Controls.Add(this.submitCommandDirectButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.commandValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UVSimDashboard";
            this.Text = "UVSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox commandValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitCommandDirectButton;
        private System.Windows.Forms.Button submitCommandEasyButton;
        private System.Windows.Forms.TextBox operandValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox operationsDropdown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox currentProgramListbox;
        private System.Windows.Forms.Button runProgramButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label consoleLabel;
    }
}