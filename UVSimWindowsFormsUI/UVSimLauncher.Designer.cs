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
            this.launchButton.Location = new System.Drawing.Point(242, 154);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(290, 109);
            this.launchButton.TabIndex = 0;
            this.launchButton.Text = "Launch App";
            this.launchButton.UseVisualStyleBackColor = true;
            this.launchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Memory Size:";
            // 
            // memorySizeText
            // 
            this.memorySizeText.Location = new System.Drawing.Point(428, 288);
            this.memorySizeText.Name = "memorySizeText";
            this.memorySizeText.Size = new System.Drawing.Size(115, 31);
            this.memorySizeText.TabIndex = 2;
            this.memorySizeText.Text = "100";
            // 
            // UVSimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 493);
            this.Controls.Add(this.memorySizeText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.launchButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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

