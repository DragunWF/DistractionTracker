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
    public partial class ViewSession : Form
    {
        private readonly int _sessionId;
        private readonly Session _session;

        public ViewSession(int sessionId)
        {
            InitializeComponent();
            this._sessionId = sessionId;

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            this.FormClosed += ViewSession_FormClosed;

            distractionsDataGridView.AllowUserToAddRows = false;
            distractionsDataGridView.ReadOnly = true;

            _session = DataManager.GetSession(sessionId);
            LoadData();
        }

        #region Events

        private void ViewSession_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseSessionForm(_sessionId);
        }

        #endregion

        #region Utility Methods

        private void LoadData()
        {
            sessionIdLabel.Text = _sessionId.ToString();
            totalDistractionCountLabel.Text = _session.TotalDistractionCount.ToString();

            List<Distraction> distractions = _session.Distractions;
            foreach (Distraction distraction in distractions)
            {
                distractionsDataGridView.Rows.Add(
                    distraction.DistractionName,
                    distraction.DistractionCount
                );
            }
        }

        #endregion
    }
}
