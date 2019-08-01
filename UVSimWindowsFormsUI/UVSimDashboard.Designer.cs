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
            this.label3 = new System.Windows.Forms.Label();
            this.submitCommandEasyButton = new System.Windows.Forms.Button();
            this.operandValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.operationsDropdown = new System.Windows.Forms.ComboBox();
            this.currentProgramListbox = new System.Windows.Forms.ListBox();
            this.runProgramButton = new System.Windows.Forms.Button();
            this.memoryTextblock = new System.Windows.Forms.RichTextBox();
            this.consoleLabel = new System.Windows.Forms.Label();
            this.outputTextblock = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dumpMemoryButton = new System.Windows.Forms.Button();
            this.clearOutputButton = new System.Windows.Forms.Button();
            this.resetProgramButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shouldBreakHere = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.displayUserManual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label3.Location = new System.Drawing.Point(82, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Commands";
            // 
            // submitCommandEasyButton
            // 
            this.submitCommandEasyButton.BackColor = System.Drawing.Color.PaleGreen;
            this.submitCommandEasyButton.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.submitCommandEasyButton.Location = new System.Drawing.Point(43, 424);
            this.submitCommandEasyButton.Name = "submitCommandEasyButton";
            this.submitCommandEasyButton.Size = new System.Drawing.Size(171, 55);
            this.submitCommandEasyButton.TabIndex = 7;
            this.submitCommandEasyButton.Text = "Submit Command";
            this.submitCommandEasyButton.UseVisualStyleBackColor = false;
            this.submitCommandEasyButton.Click += new System.EventHandler(this.SubmitCommandEasyButton_Click);
            // 
            // operandValue
            // 
            this.operandValue.Location = new System.Drawing.Point(151, 306);
            this.operandValue.Name = "operandValue";
            this.operandValue.Size = new System.Drawing.Size(172, 26);
            this.operandValue.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(38, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Operand:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(38, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 28);
            this.label6.TabIndex = 11;
            this.label6.Text = "Operation:";
            // 
            // operationsDropdown
            // 
            this.operationsDropdown.FormattingEnabled = true;
            this.operationsDropdown.Location = new System.Drawing.Point(151, 265);
            this.operationsDropdown.Name = "operationsDropdown";
            this.operationsDropdown.Size = new System.Drawing.Size(172, 28);
            this.operationsDropdown.TabIndex = 12;
            // 
            // currentProgramListbox
            // 
            this.currentProgramListbox.FormattingEnabled = true;
            this.currentProgramListbox.ItemHeight = 20;
            this.currentProgramListbox.Location = new System.Drawing.Point(45, 518);
            this.currentProgramListbox.Name = "currentProgramListbox";
            this.currentProgramListbox.Size = new System.Drawing.Size(134, 364);
            this.currentProgramListbox.TabIndex = 14;
            // 
            // runProgramButton
            // 
            this.runProgramButton.BackColor = System.Drawing.Color.PaleGreen;
            this.runProgramButton.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.runProgramButton.Location = new System.Drawing.Point(43, 897);
            this.runProgramButton.Name = "runProgramButton";
            this.runProgramButton.Size = new System.Drawing.Size(136, 50);
            this.runProgramButton.TabIndex = 15;
            this.runProgramButton.Text = "Run Program";
            this.runProgramButton.UseVisualStyleBackColor = false;
            this.runProgramButton.Click += new System.EventHandler(this.RunProgramButton_Click);
            // 
            // memoryTextblock
            // 
            this.memoryTextblock.Location = new System.Drawing.Point(483, 553);
            this.memoryTextblock.Name = "memoryTextblock";
            this.memoryTextblock.Size = new System.Drawing.Size(253, 420);
            this.memoryTextblock.TabIndex = 16;
            this.memoryTextblock.Text = "";
            // 
            // consoleLabel
            // 
            this.consoleLabel.AutoSize = true;
            this.consoleLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.consoleLabel.Location = new System.Drawing.Point(542, 512);
            this.consoleLabel.Name = "consoleLabel";
            this.consoleLabel.Size = new System.Drawing.Size(121, 38);
            this.consoleLabel.TabIndex = 17;
            this.consoleLabel.Text = "Memory";
            // 
            // outputTextblock
            // 
            this.outputTextblock.Location = new System.Drawing.Point(483, 250);
            this.outputTextblock.Name = "outputTextblock";
            this.outputTextblock.Size = new System.Drawing.Size(401, 252);
            this.outputTextblock.TabIndex = 18;
            this.outputTextblock.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label8.Location = new System.Drawing.Point(632, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 38);
            this.label8.TabIndex = 19;
            this.label8.Text = "Output";
            // 
            // dumpMemoryButton
            // 
            this.dumpMemoryButton.BackColor = System.Drawing.Color.PaleGreen;
            this.dumpMemoryButton.Location = new System.Drawing.Point(483, 990);
            this.dumpMemoryButton.Name = "dumpMemoryButton";
            this.dumpMemoryButton.Size = new System.Drawing.Size(167, 54);
            this.dumpMemoryButton.TabIndex = 20;
            this.dumpMemoryButton.Text = "Dump Memory";
            this.dumpMemoryButton.UseVisualStyleBackColor = false;
            this.dumpMemoryButton.Click += new System.EventHandler(this.DumpMemoryButton_Click);
            // 
            // clearOutputButton
            // 
            this.clearOutputButton.BackColor = System.Drawing.Color.PaleGreen;
            this.clearOutputButton.Location = new System.Drawing.Point(890, 467);
            this.clearOutputButton.Name = "clearOutputButton";
            this.clearOutputButton.Size = new System.Drawing.Size(78, 35);
            this.clearOutputButton.TabIndex = 21;
            this.clearOutputButton.Text = "Clear";
            this.clearOutputButton.UseVisualStyleBackColor = false;
            this.clearOutputButton.Click += new System.EventHandler(this.ClearOutputButton_Click);
            // 
            // resetProgramButton
            // 
            this.resetProgramButton.BackColor = System.Drawing.Color.PaleGreen;
            this.resetProgramButton.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.resetProgramButton.Location = new System.Drawing.Point(43, 953);
            this.resetProgramButton.Name = "resetProgramButton";
            this.resetProgramButton.Size = new System.Drawing.Size(136, 50);
            this.resetProgramButton.TabIndex = 22;
            this.resetProgramButton.Text = "Reset Program";
            this.resetProgramButton.UseVisualStyleBackColor = false;
            this.resetProgramButton.Click += new System.EventHandler(this.ResetProgramButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label1.Location = new System.Drawing.Point(138, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "- 3 Digit Memory Addressing";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label2.Location = new System.Drawing.Point(138, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "- 4 Digits For All Other Operands";
            // 
            // shouldBreakHere
            // 
            this.shouldBreakHere.AutoSize = true;
            this.shouldBreakHere.Location = new System.Drawing.Point(59, 394);
            this.shouldBreakHere.Name = "shouldBreakHere";
            this.shouldBreakHere.Size = new System.Drawing.Size(141, 24);
            this.shouldBreakHere.TabIndex = 25;
            this.shouldBreakHere.Text = "Set Breakpoint";
            this.shouldBreakHere.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F);
            this.label4.Location = new System.Drawing.Point(412, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 96);
            this.label4.TabIndex = 26;
            this.label4.Text = "UVSim";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label7.Location = new System.Drawing.Point(950, 1046);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 38);
            this.label7.TabIndex = 27;
            this.label7.Text = "A JCB Project";
            // 
            // displayUserManual
            // 
            this.displayUserManual.BackColor = System.Drawing.Color.PaleGreen;
            this.displayUserManual.Font = new System.Drawing.Font("Segoe UI", 7.875F);
            this.displayUserManual.Location = new System.Drawing.Point(445, 108);
            this.displayUserManual.Name = "displayUserManual";
            this.displayUserManual.Size = new System.Drawing.Size(171, 55);
            this.displayUserManual.TabIndex = 28;
            this.displayUserManual.Text = "Display User Manual";
            this.displayUserManual.UseVisualStyleBackColor = false;
            this.displayUserManual.Click += new System.EventHandler(this.DisplayUserManual_Click);
            // 
            // UVSimDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1142, 1050);
            this.Controls.Add(this.displayUserManual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shouldBreakHere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resetProgramButton);
            this.Controls.Add(this.clearOutputButton);
            this.Controls.Add(this.dumpMemoryButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.outputTextblock);
            this.Controls.Add(this.consoleLabel);
            this.Controls.Add(this.memoryTextblock);
            this.Controls.Add(this.runProgramButton);
            this.Controls.Add(this.currentProgramListbox);
            this.Controls.Add(this.operationsDropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.operandValue);
            this.Controls.Add(this.submitCommandEasyButton);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UVSimDashboard";
            this.Text = "UVSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button submitCommandEasyButton;
        private System.Windows.Forms.TextBox operandValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox operationsDropdown;
        private System.Windows.Forms.ListBox currentProgramListbox;
        private System.Windows.Forms.Button runProgramButton;
        private System.Windows.Forms.RichTextBox memoryTextblock;
        private System.Windows.Forms.Label consoleLabel;
        private System.Windows.Forms.RichTextBox outputTextblock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button dumpMemoryButton;
        private System.Windows.Forms.Button clearOutputButton;
        private System.Windows.Forms.Button resetProgramButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox shouldBreakHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button displayUserManual;
    }
}