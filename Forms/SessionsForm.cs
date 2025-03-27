﻿using DistractionsTracker.Helpers;
using DistractionsTracker.Models;
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
    public partial class SessionsForm : Form
    {
        public SessionsForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            sessionDataGridView.ReadOnly = true;
            sessionDataGridView.AllowUserToAddRows = false;
            this.FormClosed += Session_FormClosed;

            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            sessionDataGridView.Rows.Clear();

            List<Session> sessions = DataManager.GetSessions();
            foreach (Session session in sessions)
            {
                sessionDataGridView.Rows.Add(
                    session.StartDate,
                    session.EndDate,
                    session.DistractionTypes,
                    session.TotalDistractionCount
                );
            }
        }

        #region Miscellenous Events

        private void Session_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseSessionsForm();
        }

        #endregion

        #region Button Click Events

        private void resetBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to delete all data related to your deep work sessions? This action cannot be undone!",
                "Sessions Data Reset Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                DataManager.ResetData();
                PopulateDataGridView();
                MessageBox.Show("Sessions data has been successfully reset!", "Operation Complete");
            }
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        #endregion
    }
}
