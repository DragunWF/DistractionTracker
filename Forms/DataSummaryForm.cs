﻿using DistractionsTracker.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistractionsTracker.Forms
{
    public partial class OverallStatsForm : Form
    {
        public OverallStatsForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            this.FormClosed += DataSummary_FormClosed;
        }

        #region Miscellenous Events

        private void DataSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseDataSummaryForm();
        }

        #endregion
    }
}
