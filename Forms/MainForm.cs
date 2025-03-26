using DistractionsTracker.Helpers;
using System.Runtime.CompilerServices;

namespace DistractionsTracker
{
    public partial class MainForm : Form
    {
        private HashSet<string> recentDistractions = new();

        public MainForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            distractionDataGridView.AllowUserToAddRows = false;

            this.FormClosed += Main_FormClosed;
        }

        #region Miscellenous Events

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Button Click Events

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (recentDistractions.Count == 0)
            {
                MessageBox.Show("There are no distractions listed in this session to save!");
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
                // TODO: Implement saving of session data
                ResetInputs();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (recentDistractions.Count == 0)
            {
                MessageBox.Show("There is nothing to reset!");
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
            FormManager.OpenSessionsForm();
        }

        private void viewOverallStatsBtn_Click(object sender, EventArgs e)
        {
            FormManager.OpenOverallStatsForm();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string distractionInput = distractionComboBox.Text.Trim();
            if (string.IsNullOrWhiteSpace(distractionInput))
            {
                MessageBox.Show("Make sure to type something in the distraction combo box!");
                return;
            }

            SubmitDistraction(distractionInput);
            distractionComboBox.Text = "";
        }

        #endregion

        #region Main Form Utility Functions

        private void SubmitDistraction(string submittedDistraction)
        {
            bool isNewDistraction = true;

            // Increments a distraction's count if it already exists
            foreach (DataGridViewRow row in distractionDataGridView.Rows)
            {
                if (!row.IsNewRow)
                {
                    string distraction = row.Cells[0].Value?.ToString();
                    distraction ??= "[No Name]"; // Default value

                    string countStr = row.Cells[1].Value?.ToString();
                    int count;
                    try
                    {
                        count = countStr != null ? int.Parse(countStr) : 1;
                    }
                    catch (FormatException)
                    {
                        count = 1;
                    }

                    // Case-insensitivity
                    if (distraction.ToLower() == submittedDistraction.ToLower())
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
                recentDistractions.Add(submittedDistraction);
                UpdateDistractionComboBox();
            }
        }

        private void UpdateDistractionComboBox()
        {
            distractionComboBox.Items.AddRange(recentDistractions.ToArray());
        }

        private void ResetInputs()
        {
            distractionComboBox.Text = "";
            distractionDataGridView.Rows.Clear();
            distractionComboBox.Items.Clear();
            recentDistractions.Clear();
        }

        #endregion
    }
}
