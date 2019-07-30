namespace UVSimWindowsFormsUI
{
    partial class UVSimForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UVSimForm));
            this.launchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.memorySizeText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // launchButton
            // 
            this.launchButton.Location = new System.Drawing.Point(182, 123);
            this.launchButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(218, 87);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch App";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 233);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Memory Size:";
            // 
            // memorySizeText
            // 
            this.memorySizeText.Location = new System.Drawing.Point(321, 230);
            this.memorySizeText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memorySizeText.Name = "memorySizeText";
            this.memorySizeText.Size = new System.Drawing.Size(87, 26);
            this.memorySizeText.TabIndex = 2;
            this.memorySizeText.Text = "1000";
            // 
            // UVSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 394);
            this.Controls.Add(this.memorySizeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.launchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UVSimForm";
            this.Text = "UVSim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memorySizeText;
    }
}

