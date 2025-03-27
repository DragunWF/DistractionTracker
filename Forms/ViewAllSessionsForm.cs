using DistractionsTracker.Helpers;
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
    public partial class ViewAllSessionsForm : Form
    {
        public ViewAllSessionsForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            sessionDataGridView.ReadOnly = true;
            sessionDataGridView.AllowUserToAddRows = false;
            sessionDataGridView.CellContentClick += sessionDataGridView_CellContentClick;
            this.FormClosed += Session_FormClosed;

            PopulateDataGridView();
        }

        #region Miscellenous Events

        private void Session_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseViewAllSessionsForm();
        }

        private void sessionDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            const int buttonColumnIndex = 5;
            if (e.ColumnIndex == buttonColumnIndex && e.RowIndex >= 0)
            {
                try
                {
                    int sessionId = int.Parse(sessionDataGridView.Rows[e.RowIndex].Cells[0].Value?.ToString());
                    FormManager.OpenSessionForm(sessionId);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"An unexpected error has occurred! {err.Message}", "Error");
                }
            }
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

        #region Utility Methods

        private void PopulateDataGridView()
        {
            sessionDataGridView.Rows.Clear();

            List<Session> sessions = DataManager.GetSessions();
            foreach (Session session in sessions)
            {
                sessionDataGridView.Rows.Add(
                    session.Id,
                    session.StartDate,
                    session.EndDate,
                    session.TotalDistractionCount,
                    session.DistractionTypes
                );
            }
        }

        #endregion
    }
}
