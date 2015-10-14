namespace ReadParameters {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.readParams = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.writeButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readParams
            // 
            this.readParams.Location = new System.Drawing.Point(13, 55);
            this.readParams.Name = "readParams";
            this.readParams.Size = new System.Drawing.Size(151, 70);
            this.readParams.TabIndex = 0;
            this.readParams.Text = "Read";
            this.readParams.UseVisualStyleBackColor = true;
            this.readParams.Click += new System.EventHandler(this.reaedParams_Click);
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(500, 55);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(151, 70);
            this.quit.TabIndex = 1;
            this.quit.Text = "Quit";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // writeButton
            // 
            this.writeButton.Enabled = false;
            this.writeButton.Location = new System.Drawing.Point(170, 55);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(151, 70);
            this.writeButton.TabIndex = 2;
            this.writeButton.Text = "Write";
            this.writeButton.UseVisualStyleBackColor = true;
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(327, 55);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(151, 70);
            this.aboutButton.TabIndex = 3;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 137);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.writeButton);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.readParams);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readParams;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.Button aboutButton;
    }
}