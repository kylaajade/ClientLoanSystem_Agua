using ClientLoanSystem.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanSystem.Forms
{
    public partial class ScheduleForm : Form
    {
        private int _loanID, _clientID;
        private int loanID;

        public ScheduleForm(int _loanID, int _clientID)
        {
            InitializeComponent();
            this._loanID = _loanID;
            this._clientID = _clientID;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            Text = $"Loan #{_loanID} : # {_clientID}";

            using (aguadbEntities1 _con = new aguadbEntities1())
            {
                List<Schedule> _source = _con.Schedules.Where(_ => _.LoanID == loanID && _clientID == _clientID).ToList();
                scheduleBindingSource.DataSource = _source;
            }
        }
    }
}
    
