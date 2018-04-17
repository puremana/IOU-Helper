﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOU_Helper
{
    public partial class ChangeName : Form
    {
        TabPage _tab;

        private readonly Form1 _form1;
        public ChangeName(TabPage tab, Form1 form1)
        {
            _form1 = form1;
            _tab = tab;
            InitializeComponent();
        }

        private void ChangeName_Load(object sender, EventArgs e)
        {
            textBoxName.Text = _tab.Text;
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            _tab.Text = textBoxName.Text;
            this.Close();
        }
    }
}
