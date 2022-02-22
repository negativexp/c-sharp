﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingBar
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            timerCheckClosing.Start();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerCheckClosing_Tick(object sender, EventArgs e)
        {
            if (KeyboardHook.Pressed2)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }
    }
}
