﻿namespace WindowsManipulations
{
    partial class MouseTrackingForm
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
            this.components = new System.ComponentModel.Container();
            this.txtHwndList = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartTracking = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtHwndList
            // 
            this.txtHwndList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHwndList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtHwndList.Location = new System.Drawing.Point(12, 25);
            this.txtHwndList.Multiline = true;
            this.txtHwndList.Name = "txtHwndList";
            this.txtHwndList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtHwndList.Size = new System.Drawing.Size(160, 100);
            this.txtHwndList.TabIndex = 0;
            this.txtHwndList.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Window hwnds:";
            // 
            // btnStartTracking
            // 
            this.btnStartTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartTracking.Location = new System.Drawing.Point(178, 25);
            this.btnStartTracking.Name = "btnStartTracking";
            this.btnStartTracking.Size = new System.Drawing.Size(80, 23);
            this.btnStartTracking.TabIndex = 2;
            this.btnStartTracking.Text = "Start tracking";
            this.btnStartTracking.UseVisualStyleBackColor = true;
            this.btnStartTracking.Click += new System.EventHandler(this.btnStartTracking_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MouseTrackingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 137);
            this.Controls.Add(this.btnStartTracking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHwndList);
            this.Name = "MouseTrackingForm";
            this.ShowInTaskbar = false;
            this.Text = "Mouse tracking";
            this.Shown += new System.EventHandler(this.MouseTrackingForm_Shown);
            this.Resize += new System.EventHandler(this.MouseTrackingForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHwndList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartTracking;
        private System.Windows.Forms.Timer timer1;
    }
}