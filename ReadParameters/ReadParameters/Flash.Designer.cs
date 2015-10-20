﻿namespace ReadParameters {
    partial class Flash {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flash));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.authorLink = new System.Windows.Forms.LinkLabel();
            this.parametersTextBox = new System.Windows.Forms.TextBox();
            this.closeFlash = new System.Windows.Forms.Button();
            this.udCounterCtrl1 = new Automation.BDaq.UdCounterCtrl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Exercise 4 - 2015";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Version 0.0.1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Copyright 2015";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Edoardo Odorico -";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // authorLink
            // 
            this.authorLink.AutoSize = true;
            this.authorLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.authorLink.Location = new System.Drawing.Point(282, 128);
            this.authorLink.Name = "authorLink";
            this.authorLink.Size = new System.Drawing.Size(75, 13);
            this.authorLink.TabIndex = 5;
            this.authorLink.TabStop = true;
            this.authorLink.Text = "edoardoo.com";
            this.authorLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLink_LinkClicked);
            // 
            // parametersTextBox
            // 
            this.parametersTextBox.AcceptsReturn = true;
            this.parametersTextBox.AcceptsTab = true;
            this.parametersTextBox.BackColor = System.Drawing.Color.LightGray;
            this.parametersTextBox.Location = new System.Drawing.Point(186, 167);
            this.parametersTextBox.Multiline = true;
            this.parametersTextBox.Name = "parametersTextBox";
            this.parametersTextBox.Size = new System.Drawing.Size(318, 245);
            this.parametersTextBox.TabIndex = 6;
            this.parametersTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // closeFlash
            // 
            this.closeFlash.Location = new System.Drawing.Point(428, 436);
            this.closeFlash.Name = "closeFlash";
            this.closeFlash.Size = new System.Drawing.Size(75, 23);
            this.closeFlash.TabIndex = 7;
            this.closeFlash.Text = "Close";
            this.closeFlash.UseVisualStyleBackColor = true;
            this.closeFlash.Click += new System.EventHandler(this.closeFlash_Click);
            // 
            // udCounterCtrl1
            // 
            this.udCounterCtrl1._StateStream = ((Automation.BDaq.DeviceStateStreamer)(resources.GetObject("udCounterCtrl1._StateStream")));
            // 
            // Flash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 488);
            this.ControlBox = false;
            this.Controls.Add(this.closeFlash);
            this.Controls.Add(this.parametersTextBox);
            this.Controls.Add(this.authorLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Flash";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ReadParameters";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel authorLink;
        private System.Windows.Forms.TextBox parametersTextBox;
        private System.Windows.Forms.Button closeFlash;
        private Automation.BDaq.UdCounterCtrl udCounterCtrl1;
    }
}

