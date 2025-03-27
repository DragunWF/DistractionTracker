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
        private int _totalWorkSessions = 0;
        private int _totalDistractionCount = 0;
        private int _totalDistractionTypes = 0;

        private int _maxFrequency = int.MinValue;
        private string _mostFrequentDistraction = "None";

        private int _minFrequency = int.MaxValue;
        private string _leastFrequentDistraction = "None";

        private HashSet<string> _uniqueDistractions = new();
        private Dictionary<string, int> _distractionFrequencies = new();

        public DataSummaryForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            this.FormClosed += DataSummary_FormClosed;

            SummarizeData();
            LoadData();
        }

        #region Events

        private void DataSummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseDataSummaryForm();
        }

        #endregion

        #region Utility Methods

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

        private void LoadData()
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
