﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsManipulations
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void topmostWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
            this.topmostWindowToolStripMenuItem.Checked = this.TopMost;
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.WordWrap = !this.richTextBox1.WordWrap;
            wordWrapToolStripMenuItem.Checked = this.richTextBox1.WordWrap;
        }

        // https://stackoverflow.com/questions/27561133/prevent-window-from-showing-in-alt-tab
        //
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // turn on WS_EX_TOOLWINDOW style bit
                cp.ExStyle |= 0x80;
                return cp;
            }
        }
    }
}