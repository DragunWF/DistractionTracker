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
        private int sessionId;
        private Session session;

        public ViewSession(int sessionId)
        {
            InitializeComponent();
            this.sessionId = sessionId;

            distractionsDataGridView.AllowUserToAddRows = false;
            distractionsDataGridView.ReadOnly = true;

            session = DataManager.GetSession(sessionId);
            LoadData();
        }

        private void LoadData()
        {
            sessionIdLabel.Text = sessionId.ToString();
            totalDistractionCountLabel.Text = session.TotalDistractionCount.ToString();

            List<Distraction> distractions = session.Distractions;
            foreach (Distraction distraction in distractions)
            {
                distractionsDataGridView.Rows.Add(
                    distraction.DistractionName,
                    distraction.DistractionCount
                );
            }
        }   
    }
}
