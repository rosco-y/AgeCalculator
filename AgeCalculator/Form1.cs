using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        const double ApproxDaysPerMonth = 30.4375;
        const double ApproxDaysPerYear = 365.25;
        DateTime _birthDate;
        StringBuilder ageReport;

        public Form1()
        {
            InitializeComponent();
            ageReport = new StringBuilder();
            birthTime.Enabled = chkUseTime.Checked;
        }

        private void cmdCalculateAge_Click(object sender, EventArgs e)
        {
            _birthDate = dtBirthDate.Value;
            if (chkUseTime.Checked)
                _birthDate = _birthDate.Date.Add(birthTime.Value.TimeOfDay);            
            tmrAging.Enabled = true;
        }

        private void tmrAging_Tick(object sender, EventArgs e)
        {

            TimeSpan totalTime = DateTime.Now.Subtract(_birthDate);

            int iDays = (int)totalTime.TotalDays;
            int iYear = (int)(iDays / ApproxDaysPerYear);
            int iMonths = (int)(iYear * 12);
            int iWeeks = (int)(iMonths / ApproxDaysPerMonth) * 7;
            int iHours = (int)totalTime.TotalHours;
            int iMinutes = (int)totalTime.TotalHours * 60;
            int iSeconds = (int)totalTime.TotalSeconds;

            //StringBuilder ageReport = new StringBuilder();
            ageReport.Clear();
            ageReport.Append($"You are {iYear:N0} years old..." + Environment.NewLine + Environment.NewLine);
            ageReport.Append($"\tor {iMonths:N0} months old" + Environment.NewLine);
            ageReport.Append($"\tor {iWeeks:N0} weeks old" + Environment.NewLine);
            ageReport.Append($"\tor {iDays:N0} days old" + Environment.NewLine);
            ageReport.Append($"\tor {iHours:N0} hours old" + Environment.NewLine);
            ageReport.Append($"\tor {iMinutes:N0} minutes old" + Environment.NewLine);
            ageReport.Append($"\tor {iSeconds:N0} seconds old." + Environment.NewLine + Environment.NewLine);
            ageReport.Append(NextBirthday(_birthDate.AddYears(iYear)));
            txtAgeReport.Text = ageReport.ToString();

            

        }

        string NextBirthday(DateTime nextBirthday)
        {
            string nextDate = string.Empty;
            TimeSpan untilThen = DateTime.Now.Subtract(nextBirthday); // nextBirthday.Subtract(DateTime.Now); 

            nextDate = $"and your next birthday celebration is in: {Environment.NewLine} {365 - untilThen.TotalDays:N0} days!";// {untilThen.Hours} hrs {untilThen.Minutes} minutes and {untilThen.Seconds}";


            return nextDate;
        }

        private void chkUseTime_CheckedChanged(object sender, EventArgs e)
        {
            birthTime.Enabled = chkUseTime.Checked;
        }
    }
}
