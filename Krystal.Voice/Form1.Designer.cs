namespace Krystal.Voice
{
    partial class Kristal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kristal));
            this.MovieButton = new System.Windows.Forms.Button();
            this.MusicButton = new System.Windows.Forms.Button();
            this.PPButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MovieButton
            // 
            resources.ApplyResources(this.MovieButton, "MovieButton");
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.UseVisualStyleBackColor = true;
            // 
            // MusicButton
            // 
            resources.ApplyResources(this.MusicButton, "MusicButton");
            this.MusicButton.Name = "MusicButton";
            this.MusicButton.UseVisualStyleBackColor = true;
            // 
            // PPButton
            // 
            resources.ApplyResources(this.PPButton, "PPButton");
            this.PPButton.Name = "PPButton";
            this.PPButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Status
            // 
            resources.ApplyResources(this.Status, "Status");
            this.Status.Name = "Status";
            // 
            // Kristal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PPButton);
            this.Controls.Add(this.MusicButton);
            this.Controls.Add(this.MovieButton);
            this.Name = "Kristal";
            this.Load += new System.EventHandler(this.Kristal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MovieButton;
        private System.Windows.Forms.Button MusicButton;
        private System.Windows.Forms.Button PPButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Status;

        
    }
}

