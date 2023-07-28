namespace KingOfLINQ
{
    partial class frmMain
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
            this.btnIntroduction = new System.Windows.Forms.Button();
            this.btnLinqAndExtensionMethods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIntroduction
            // 
            this.btnIntroduction.Location = new System.Drawing.Point(704, 12);
            this.btnIntroduction.Name = "btnIntroduction";
            this.btnIntroduction.Size = new System.Drawing.Size(168, 55);
            this.btnIntroduction.TabIndex = 0;
            this.btnIntroduction.Text = "Introduction";
            this.btnIntroduction.UseVisualStyleBackColor = true;
            this.btnIntroduction.Click += new System.EventHandler(this.btnIntroduction_Click);
            // 
            // btnLinqAndExtensionMethods
            // 
            this.btnLinqAndExtensionMethods.Location = new System.Drawing.Point(704, 83);
            this.btnLinqAndExtensionMethods.Name = "btnLinqAndExtensionMethods";
            this.btnLinqAndExtensionMethods.Size = new System.Drawing.Size(168, 57);
            this.btnLinqAndExtensionMethods.TabIndex = 1;
            this.btnLinqAndExtensionMethods.Text = "Linq And Extension Methods";
            this.btnLinqAndExtensionMethods.UseVisualStyleBackColor = true;
            this.btnLinqAndExtensionMethods.Click += new System.EventHandler(this.btnLinqAndExtensionMethods_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.btnLinqAndExtensionMethods);
            this.Controls.Add(this.btnIntroduction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KingOfLinq";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnIntroduction;
        private Button btnLinqAndExtensionMethods;
    }
}