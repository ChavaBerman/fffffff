﻿using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_WinForm.Manager
{
    public partial class ManageReports : Form
    {
        public ManageReports()
        {
            InitializeComponent();
        }

        private void ManageReports_Load(object sender, EventArgs e)
        {
            reportViewer1.RefreshReport();
        }

    }
    }

