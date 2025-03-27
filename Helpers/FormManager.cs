using DistractionsTracker.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistractionsTracker.Helpers
{
    internal class FormManager
    {
        private static HashSet<int> _initializedSessionForms = new();
        private static bool _dataSummaryFormInitialized = false;
        private static bool _sessionsFormInitialized = false;

        #region Open Form Methods

        public static void OpenDataSummaryForm()
        {
            if (_dataSummaryFormInitialized)
            {
                return;
            }

            new DataSummaryForm().Show();
            _dataSummaryFormInitialized = true;
        }

        public static void OpenViewAllSessionsForm()
        {
            if (_sessionsFormInitialized)
            {
                return;
            }

            new ViewAllSessionsForm().Show();
            _sessionsFormInitialized = true;
        }

        public static void OpenSessionForm(int sessionId)
        {
            if (_initializedSessionForms.Contains(sessionId))
            {
                return;
            }

            _initializedSessionForms.Add(sessionId);
            new ViewSession(sessionId).Show();
        }

        #endregion

        #region Close Form Methods

        public static void CloseDataSummaryForm() => _dataSummaryFormInitialized = false;
        public static void CloseViewAllSessionsForm() => _sessionsFormInitialized = false;
        public static void CloseSessionForm(int sessionId) => _initializedSessionForms.Remove(sessionId);

        #endregion
    }
}
