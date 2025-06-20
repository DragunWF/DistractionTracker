using DistractionsTracker.Helpers;
using DistractionsTracker.Models;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DistractionsTracker
{
    public partial class MainForm : Form
    {
        private HashSet<string> _recentDistractions = new();
        private string _startSessionDate;

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            distractionDataGridView.AllowUserToAddRows = false;
            distractionDataGridView.CellEndEdit += distractionDataGridView_CellEndEdit;
            distractionComboBox.KeyDown += distractionComboBox_KeyDown;

            _startSessionDate = Utils.GetCurrentDateTimeString();
        }

        #region Miscellenous Events

        private void distractionDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // This deletes a row if the user sets the count to zero or a negative value
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                object newValue = distractionDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                int count = Utils.ConvertCountCellToNumber((string)newValue);
                if (count <= 0)
                {
                    distractionDataGridView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void distractionComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SubmitDistraction();
            }
        }

        #endregion

        #region Button Click Events

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (_recentDistractions.Count == 0)
            {
                MessageBox.Show("There are no distractions listed in this session to save!", "Alert");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to save this session? This will clear all distractions you've listed for the current session and will start a new session.",
                "Save Session and Start New Session (Confirmation)",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                Session session = new Session(
                    _startSessionDate,
                    Utils.GetCurrentDateTimeString(),
                    GetDistractionTypes(),
                    GetTotalDistractionCount(),
                    GetDistractions()
                );
                DataManager.AddSession(session);

                ResetInputs();
                _startSessionDate = Utils.GetCurrentDateTimeString();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (_recentDistractions.Count == 0)
            {
                MessageBox.Show("There is nothing to reset!", "Alert");
                return;
            }

            var result = MessageBox.Show(
                "Are you sure you want to reset your distraction list? This will clear all distractions you've listed for the current session.",
                "Reset Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                ResetInputs();
            }
        }

        private void viewSessionsBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenViewAllSessionsForm();
        }

        private void viewOverallStatsBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenDataSummaryForm();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            SubmitDistraction();
        }

        #endregion

        #region Main Form Utility Functions

        private void SubmitDistraction()
        {
            string distractionInput = distractionComboBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(distractionInput))
            {
                MessageBox.Show("Make sure to type something in the distraction combo box!", "Alert");
                return;
            }

            AddDistractionToList(distractionInput);
            distractionComboBox.Text = "";
        }

        private void AddDistractionToList(string submittedDistraction)
        {
            const string DEFAULT_VALUE = "[no name]";
            bool isNewDistraction = true;
            submittedDistraction = Utils.ToTitleCase(submittedDistraction);

            // Increments a distraction's count if it already exists
            foreach (DataGridViewRow row in distractionDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string distraction = row.Cells[0].Value?.ToString();
                    distraction ??= DEFAULT_VALUE;

                    int count = Utils.GetCountCellValue(row.Cells[1].Value?.ToString());
                    

                    // Case-insensitivity
                    if (distraction == submittedDistraction)
                    {
                        row.Cells[1].Value = count + 1;
                        isNewDistraction = false;
                        break;
                    }
                }
            }

            if (isNewDistraction)
            {
                distractionDataGridView.Rows.Add(submittedDistraction, 1);
                _recentDistractions.Add(submittedDistraction);
                UpdateDistractionComboBox();
            }
        }

        private void UpdateDistractionComboBox()
        {
            distractionComboBox.Items.Clear();
            distractionComboBox.Items.AddRange(_recentDistractions.ToArray());
        }

        private void ResetInputs()
        {
            distractionComboBox.Text = "";
            distractionDataGridView.Rows.Clear();
            distractionComboBox.Items.Clear();
            _recentDistractions.Clear();
        }

        private List<Distraction> GetDistractions()
        {
            List<Distraction> distractions = new();
            foreach (DataGridViewRow row in distractionDataGridView.Rows)
            {
                string distraction = row.Cells[0].Value?.ToString();
                distraction ??= "[No Name]"; // Default value

                int count = Utils.GetCountCellValue(row.Cells[1].Value?.ToString());
                distractions.Add(new Distraction(distraction, count));
            }
            return distractions;
        }

        private int GetTotalDistractionCount()
        {
            int totalCount = 0;
            foreach (DataGridViewRow row in distractionDataGridView.Rows)
            {
                string countStr = row.Cells[1].Value?.ToString();
                int count;
                try
                {
                    count = int.Parse(countStr);
                }
                catch (FormatException)
                {
                    continue;
                }
                totalCount += count;
            }
            return totalCount;
        }

        private int GetDistractionTypes()
        {
            return distractionDataGridView.Rows.Count;
        }

        #endregion
    }
}
