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
        private static bool _overallStatsFormInitialized = false;
        private static bool _sessionsFormInitialized = false;

        #region Open Form Methods

        public static void OpenDataSummaryForm()
        {
            if (_overallStatsFormInitialized)
            {
                return;
            }

            new OverallStatsForm().Show();
            _overallStatsFormInitialized = true;
        }

        public static void OpenSessionsForm()
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
            new ViewSession(sessionId).Show();
        }

        #endregion

        #region Close Form Methods

        public static void CloseOverallStatsForm() => _overallStatsFormInitialized = false;
        public static void CloseSessionsForm() => _sessionsFormInitialized = false;

        #endregion
    }
}
