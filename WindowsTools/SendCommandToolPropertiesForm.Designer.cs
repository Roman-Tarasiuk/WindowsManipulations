﻿namespace WindowsTools
{
    partial class SendCommandToolPropertiesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtToolWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtToolHeight = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioTop = new System.Windows.Forms.RadioButton();
            this.radioBottom = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioLeft = new System.Windows.Forms.RadioButton();
            this.radioRight = new System.Windows.Forms.RadioButton();
            this.txtCommands = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkSleep = new System.Windows.Forms.CheckBox();
            this.txtSleepTimeout = new System.Windows.Forms.TextBox();
            this.chkRunOnAllWindowsWithSameTitle = new System.Windows.Forms.CheckBox();
            this.txtTop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLeft = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBorder = new System.Windows.Forms.Label();
            this.btnBorderColor = new System.Windows.Forms.Button();
            this.btnBorderHoverColor = new System.Windows.Forms.Button();
            this.lblBorderHover = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtTitlePattern = new System.Windows.Forms.TextBox();
            this.radioCommand = new System.Windows.Forms.RadioButton();
            this.radioClipboard = new System.Windows.Forms.RadioButton();
            this.radioActivateWindow = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHostHwnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radioLastN = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Width:";
            // 
            // txtToolWidth
            // 
            this.txtToolWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtToolWidth.Location = new System.Drawing.Point(390, 172);
            this.txtToolWidth.Name = "txtToolWidth";
            this.txtToolWidth.Size = new System.Drawing.Size(63, 20);
            this.txtToolWidth.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Height:";
            // 
            // txtToolHeight
            // 
            this.txtToolHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtToolHeight.Location = new System.Drawing.Point(390, 198);
            this.txtToolHeight.Name = "txtToolHeight";
            this.txtToolHeight.Size = new System.Drawing.Size(63, 20);
            this.txtToolHeight.TabIndex = 15;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(379, 260);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Anchor";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioTop);
            this.panel2.Controls.Add(this.radioBottom);
            this.panel2.Location = new System.Drawing.Point(96, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 45);
            this.panel2.TabIndex = 5;
            // 
            // radioTop
            // 
            this.radioTop.AutoSize = true;
            this.radioTop.Checked = true;
            this.radioTop.Location = new System.Drawing.Point(3, 3);
            this.radioTop.Name = "radioTop";
            this.radioTop.Size = new System.Drawing.Size(44, 17);
            this.radioTop.TabIndex = 6;
            this.radioTop.TabStop = true;
            this.radioTop.Text = "Top";
            this.radioTop.UseVisualStyleBackColor = true;
            // 
            // radioBottom
            // 
            this.radioBottom.AutoSize = true;
            this.radioBottom.Location = new System.Drawing.Point(3, 26);
            this.radioBottom.Name = "radioBottom";
            this.radioBottom.Size = new System.Drawing.Size(58, 17);
            this.radioBottom.TabIndex = 7;
            this.radioBottom.TabStop = true;
            this.radioBottom.Text = "Bottom";
            this.radioBottom.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioLeft);
            this.panel1.Controls.Add(this.radioRight);
            this.panel1.Location = new System.Drawing.Point(6, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 45);
            this.panel1.TabIndex = 2;
            // 
            // radioLeft
            // 
            this.radioLeft.AutoSize = true;
            this.radioLeft.Checked = true;
            this.radioLeft.Location = new System.Drawing.Point(3, 3);
            this.radioLeft.Name = "radioLeft";
            this.radioLeft.Size = new System.Drawing.Size(43, 17);
            this.radioLeft.TabIndex = 3;
            this.radioLeft.TabStop = true;
            this.radioLeft.Text = "Left";
            this.radioLeft.UseVisualStyleBackColor = true;
            // 
            // radioRight
            // 
            this.radioRight.AutoSize = true;
            this.radioRight.Location = new System.Drawing.Point(3, 26);
            this.radioRight.Name = "radioRight";
            this.radioRight.Size = new System.Drawing.Size(50, 17);
            this.radioRight.TabIndex = 4;
            this.radioRight.TabStop = true;
            this.radioRight.Text = "Right";
            this.radioRight.UseVisualStyleBackColor = true;
            // 
            // txtCommands
            // 
            this.txtCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCommands.Location = new System.Drawing.Point(12, 25);
            this.txtCommands.Multiline = true;
            this.txtCommands.Name = "txtCommands";
            this.txtCommands.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCommands.Size = new System.Drawing.Size(441, 85);
            this.txtCommands.TabIndex = 17;
            this.txtCommands.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Commands:";
            // 
            // chkSleep
            // 
            this.chkSleep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkSleep.AutoSize = true;
            this.chkSleep.Location = new System.Drawing.Point(12, 139);
            this.chkSleep.Name = "chkSleep";
            this.chkSleep.Size = new System.Drawing.Size(110, 17);
            this.chkSleep.TabIndex = 19;
            this.chkSleep.Text = "With timeout (ms):";
            this.chkSleep.UseVisualStyleBackColor = true;
            // 
            // txtSleepTimeout
            // 
            this.txtSleepTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSleepTimeout.Location = new System.Drawing.Point(128, 137);
            this.txtSleepTimeout.Name = "txtSleepTimeout";
            this.txtSleepTimeout.Size = new System.Drawing.Size(59, 20);
            this.txtSleepTimeout.TabIndex = 20;
            // 
            // chkRunOnAllWindowsWithSameTitle
            // 
            this.chkRunOnAllWindowsWithSameTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkRunOnAllWindowsWithSameTitle.AutoSize = true;
            this.chkRunOnAllWindowsWithSameTitle.Location = new System.Drawing.Point(208, 116);
            this.chkRunOnAllWindowsWithSameTitle.Name = "chkRunOnAllWindowsWithSameTitle";
            this.chkRunOnAllWindowsWithSameTitle.Size = new System.Drawing.Size(187, 17);
            this.chkRunOnAllWindowsWithSameTitle.TabIndex = 21;
            this.chkRunOnAllWindowsWithSameTitle.Text = "Run on all windows with same title";
            this.chkRunOnAllWindowsWithSameTitle.UseVisualStyleBackColor = true;
            this.chkRunOnAllWindowsWithSameTitle.Click += new System.EventHandler(this.chkRunOnAllWindowsWithSameTitle_click);
            // 
            // txtTop
            // 
            this.txtTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTop.Location = new System.Drawing.Point(261, 198);
            this.txtTop.Name = "txtTop";
            this.txtTop.Size = new System.Drawing.Size(63, 20);
            this.txtTop.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Top:";
            // 
            // txtLeft
            // 
            this.txtLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLeft.Location = new System.Drawing.Point(261, 172);
            this.txtLeft.Name = "txtLeft";
            this.txtLeft.Size = new System.Drawing.Size(63, 20);
            this.txtLeft.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Left:";
            // 
            // lblBorder
            // 
            this.lblBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBorder.AutoSize = true;
            this.lblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBorder.Location = new System.Drawing.Point(275, 225);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(30, 19);
            this.lblBorder.TabIndex = 23;
            this.lblBorder.Text = "     ";
            // 
            // btnBorderColor
            // 
            this.btnBorderColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorderColor.Location = new System.Drawing.Point(214, 223);
            this.btnBorderColor.Name = "btnBorderColor";
            this.btnBorderColor.Size = new System.Drawing.Size(55, 23);
            this.btnBorderColor.TabIndex = 24;
            this.btnBorderColor.Text = "Border,,,";
            this.btnBorderColor.UseVisualStyleBackColor = true;
            this.btnBorderColor.Click += new System.EventHandler(this.btnBorderColor_Click);
            // 
            // btnBorderHoverColor
            // 
            this.btnBorderHoverColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBorderHoverColor.Location = new System.Drawing.Point(324, 223);
            this.btnBorderHoverColor.Name = "btnBorderHoverColor";
            this.btnBorderHoverColor.Size = new System.Drawing.Size(93, 23);
            this.btnBorderHoverColor.TabIndex = 26;
            this.btnBorderHoverColor.Text = "Border hover,,,";
            this.btnBorderHoverColor.UseVisualStyleBackColor = true;
            this.btnBorderHoverColor.Click += new System.EventHandler(this.btnBorderHoverColor_Click);
            // 
            // lblBorderHover
            // 
            this.lblBorderHover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBorderHover.AutoSize = true;
            this.lblBorderHover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBorderHover.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBorderHover.Location = new System.Drawing.Point(423, 225);
            this.lblBorderHover.Name = "lblBorderHover";
            this.lblBorderHover.Size = new System.Drawing.Size(30, 19);
            this.lblBorderHover.TabIndex = 25;
            this.lblBorderHover.Text = "     ";
            // 
            // txtTitlePattern
            // 
            this.txtTitlePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitlePattern.Location = new System.Drawing.Point(208, 137);
            this.txtTitlePattern.Name = "txtTitlePattern";
            this.txtTitlePattern.Size = new System.Drawing.Size(245, 20);
            this.txtTitlePattern.TabIndex = 27;
            // 
            // radioCommand
            // 
            this.radioCommand.AutoSize = true;
            this.radioCommand.Checked = true;
            this.radioCommand.Location = new System.Drawing.Point(75, 7);
            this.radioCommand.Name = "radioCommand";
            this.radioCommand.Size = new System.Drawing.Size(60, 17);
            this.radioCommand.TabIndex = 28;
            this.radioCommand.TabStop = true;
            this.radioCommand.Text = "Custom";
            this.radioCommand.UseVisualStyleBackColor = true;
            this.radioCommand.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // radioClipboard
            // 
            this.radioClipboard.AutoSize = true;
            this.radioClipboard.Location = new System.Drawing.Point(141, 7);
            this.radioClipboard.Name = "radioClipboard";
            this.radioClipboard.Size = new System.Drawing.Size(69, 17);
            this.radioClipboard.TabIndex = 29;
            this.radioClipboard.Text = "Clipboard";
            this.radioClipboard.UseVisualStyleBackColor = true;
            this.radioClipboard.CheckedChanged += new System.EventHandler(this.radioClipboard_CheckedChanged);
            // 
            // radioActivateWindow
            // 
            this.radioActivateWindow.AutoSize = true;
            this.radioActivateWindow.Location = new System.Drawing.Point(216, 7);
            this.radioActivateWindow.Name = "radioActivateWindow";
            this.radioActivateWindow.Size = new System.Drawing.Size(103, 17);
            this.radioActivateWindow.TabIndex = 30;
            this.radioActivateWindow.Text = "Activate window";
            this.radioActivateWindow.UseVisualStyleBackColor = true;
            this.radioActivateWindow.CheckedChanged += new System.EventHandler(this.radioActivateWindow_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(128, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 20);
            this.textBox1.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Track interval (ms):";
            // 
            // txtHostHwnd
            // 
            this.txtHostHwnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtHostHwnd.Location = new System.Drawing.Point(86, 262);
            this.txtHostHwnd.Name = "txtHostHwnd";
            this.txtHostHwnd.Size = new System.Drawing.Size(87, 20);
            this.txtHostHwnd.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Host window:";
            // 
            // radioLastN
            // 
            this.radioLastN.AutoSize = true;
            this.radioLastN.Enabled = false;
            this.radioLastN.Location = new System.Drawing.Point(324, 7);
            this.radioLastN.Name = "radioLastN";
            this.radioLastN.Size = new System.Drawing.Size(59, 17);
            this.radioLastN.TabIndex = 38;
            this.radioLastN.TabStop = true;
            this.radioLastN.Text = "Last -N";
            this.radioLastN.UseVisualStyleBackColor = true;
            // 
            // SendCommandToolPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 289);
            this.Controls.Add(this.radioLastN);
            this.Controls.Add(this.txtHostHwnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioActivateWindow);
            this.Controls.Add(this.radioClipboard);
            this.Controls.Add(this.radioCommand);
            this.Controls.Add(this.txtTitlePattern);
            this.Controls.Add(this.btnBorderHoverColor);
            this.Controls.Add(this.lblBorderHover);
            this.Controls.Add(this.btnBorderColor);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.txtTop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkRunOnAllWindowsWithSameTitle);
            this.Controls.Add(this.txtSleepTimeout);
            this.Controls.Add(this.chkSleep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCommands);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtToolHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtToolWidth);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SendCommandToolPropertiesForm";
            this.Text = "Tool properties";
            this.Shown += new System.EventHandler(this.SendCommandToolPropertiesForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToolWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtToolHeight;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBottom;
        private System.Windows.Forms.RadioButton radioTop;
        private System.Windows.Forms.RadioButton radioRight;
        private System.Windows.Forms.RadioButton radioLeft;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCommands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkSleep;
        private System.Windows.Forms.TextBox txtSleepTimeout;
        private System.Windows.Forms.CheckBox chkRunOnAllWindowsWithSameTitle;
        private System.Windows.Forms.TextBox txtTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Button btnBorderColor;
        private System.Windows.Forms.Button btnBorderHoverColor;
        private System.Windows.Forms.Label lblBorderHover;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtTitlePattern;
        private System.Windows.Forms.RadioButton radioCommand;
        private System.Windows.Forms.RadioButton radioClipboard;
        private System.Windows.Forms.RadioButton radioActivateWindow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHostHwnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioLastN;
    }
}