using DistractionsTracker.Helpers;
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

            this.FormClosed += Session_FormClosed;
        }

        #region Miscellenous Events

        private void Session_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormManager.CloseSessionsForm();
        }

        #endregion
    }
}
