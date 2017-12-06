﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsManipulations.Infrastructure;

namespace WindowsManipulations
{
    public partial class SendCommandToolPropertiesForm : Form
    {
        private string m_Commands = String.Empty;

        public string Commands
        {
            get
            {
                return m_Commands;
            }
            set
            {
                m_Commands = value;
                txtCommands.Text = m_Commands;
            }
        }

        public AnchorHorizontal AnchorH { get; set; }
        public AnchorVertical AnchorV { get; set; }
        public int ToolWidht { get; set; }
        public int ToolHeight { get; set; }
        public bool Clipboard { get; set; }

        public SendCommandToolPropertiesForm()
        {
            InitializeComponent();

            ToolWidht = 40;
            ToolHeight = 40;
            AnchorH = AnchorHorizontal.Left;
            AnchorV = AnchorVertical.Top;
        }

        private void SendCommandToolPropertiesForm_Shown(object sender, EventArgs e)
        {
            txtToolWidth.Text = ToolWidht.ToString();
            txtToolHeight.Text = ToolHeight.ToString();

            if (AnchorH == AnchorHorizontal.Left)
            {
                radioLeft.Checked = true;
            }
            else
            {
                radioRight.Checked = true;
            }

            if (AnchorV == AnchorVertical.Top)
            {
                radioTop.Checked = true;
            }
            else
            {
                radioBottom.Checked = true;
            }

            chkClipboard.Checked = this.Clipboard;
            txtCommands.Enabled = !this.Clipboard;
        }

        private void txtToolWidth_TextChanged(object sender, EventArgs e)
        {
            int w;
            if (int.TryParse(txtToolWidth.Text, out w))
            {
                ToolWidht = w;
            }
        }

        private void txtToolHeight_TextChanged(object sender, EventArgs e)
        {
            int h;
            if (int.TryParse(txtToolHeight.Text, out h))
            {
                ToolHeight = h;
            }
        }

        private void radioLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLeft.Checked)
            {
                AnchorH = AnchorHorizontal.Left;
            }
        }

        private void radioRight_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRight.Checked)
            {
                AnchorH = AnchorHorizontal.Right;
            }
        }

        private void radioTop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioTop.Checked)
            {
                AnchorV = AnchorVertical.Top;
            }
        }

        private void radioBottom_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBottom.Checked)
            {
                AnchorV = AnchorVertical.Bottom;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Commands = txtCommands.Text;
        }

        private void chkClipboard_CheckedChanged(object sender, EventArgs e)
        {
            this.Clipboard = chkClipboard.Checked;
            txtCommands.Enabled = !chkClipboard.Checked;
        }
    }
}
