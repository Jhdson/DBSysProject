﻿using DBSysProj.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBSysProj.Forms
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            ucRooms uc = new ucRooms();
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox2, "Close");
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(pictureBox3, "Minimize");
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            ucRooms uc = new ucRooms();
            addUserControl(uc);
        }
    }
}