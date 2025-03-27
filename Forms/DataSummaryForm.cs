using DistractionsTracker.Helpers;
using DistractionsTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistractionsTracker.Forms
{
    public partial class DataSummaryForm : Form
    {
        private int _totalWorkSessions, _totalDistractionCount, _totalDistractionTypes;

        private int _maxFrequency, _minFrequency;
        private string _mostFrequentDistraction, _leastFrequentDistraction;

        private HashSet<string> _uniqueDistractions;
        private Dictionary<string, int> _distractionFrequencies;

        public DataSummaryForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            this.FormClosed += DataSummary_FormClosed;

            LoadData();
        }

        #region Events

        private void DataSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseDataSummaryForm();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        #endregion

        #region Utility Methods

        private void LoadData()
        {
            ResetData();
            SummarizeData();
            SetData();
        }

        private void ResetData()
        {
            _totalWorkSessions = 0;
            _totalDistractionCount = 0;
            _totalDistractionTypes = 0;

            _maxFrequency = int.MinValue;
            _mostFrequentDistraction = "";

            _minFrequency = int.MaxValue;
            _leastFrequentDistraction = "";

            _uniqueDistractions = new();
            _distractionFrequencies = new();
        }

        private void SummarizeData()
        {
            List<Session> sessions = DataManager.GetSessions();

            // Decide TotalWorkSessions, TotalDistractionCount, and TotalDistractionTypes
            _totalWorkSessions = sessions.Count;
            foreach (Session session in sessions)
            {
                _totalDistractionCount += session.TotalDistractionCount;

                // Set unique distractions and frequencies of distractions
                foreach (Distraction distraction in session.Distractions)
                {
                    string name = distraction.DistractionName;
                    _uniqueDistractions.Add(name);

                    if (_distractionFrequencies.ContainsKey(name))
                    {
                        _distractionFrequencies[name] += distraction.DistractionCount;
                    }
                    else
                    {
                        _distractionFrequencies[name] = distraction.DistractionCount;
                    }
                }
            }
            _totalDistractionTypes = _uniqueDistractions.Count;

            // Set most and least frequent distraction
            foreach (string distraction in _distractionFrequencies.Keys)
            {
                int frequency = _distractionFrequencies[distraction];
                if (frequency > _maxFrequency)
                {
                    _maxFrequency = frequency;
                    _mostFrequentDistraction = distraction;
                }
                if (frequency < _minFrequency)
                {
                    _minFrequency = frequency;
                    _leastFrequentDistraction = distraction;
                }
            }
        }

        private void SetData()
        {
            const string DEFAULT_TEXT = "No Data Available";

            totalWorkSessionsLabel.Text = _totalWorkSessions.ToString();
            totalDistractionCountLabel.Text = _totalDistractionCount.ToString();
            totalDistractionTypesLabel.Text = _totalDistractionTypes.ToString();

            if (_maxFrequency == int.MinValue)
            {
                mostFrequentDistractionLabel.Text = DEFAULT_TEXT;
            }
            else
            {
                mostFrequentDistractionLabel.Text = $"{_mostFrequentDistraction} ({_maxFrequency})";
            }
            if (_minFrequency == int.MaxValue)
            {
                leastFrequentDistractionLabel.Text = DEFAULT_TEXT;
            }
            else
            {
                leastFrequentDistractionLabel.Text = $"{_leastFrequentDistraction} ({_minFrequency})";
            }
        }

        #endregion
    }
}
