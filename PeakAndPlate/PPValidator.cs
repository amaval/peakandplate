using System;
using System.Windows.Forms;
using PeakAndPlate.Model;
using PeakAndPlate.Controller;
using System.Text.RegularExpressions;

namespace PicoPlaca
{
    public partial class PPValidator : Form
    {
        public PPValidator()
        {
            InitializeComponent();
            Agency = new Agency();
        }

        public Agency Agency { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan _hourSelected = new TimeSpan(Convert.ToInt16(tbHour.Text.Substring(0, 2)),
            Convert.ToInt16(tbHour.Text.Substring(3, 2)), 00);

            Car Car = new Car(tbPlate.Text);
            label4.Text = Agency.PeakAndPlate(Car, dtpDateTime.Value, _hourSelected);
        }

        private void tbPlate_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPlate.Text) || tbPlate.Text == "")
            {
                e.Cancel = true;
                errorPPProvider.SetError(tbPlate, "Please, Enter the Plate");
            }
            else
            {
                e.Cancel = false;
                errorPPProvider.SetError(tbPlate, null);
            }
        }

        private void tbHour_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Regex _hourFormat = new Regex(@"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$");

            if (!_hourFormat.IsMatch(tbHour.Text))
            {
                e.Cancel = true;
                errorPPProvider.SetError(tbHour, "Please, Enter Correct Format");
            }
            else
            {
                e.Cancel = false;
                errorPPProvider.SetError(tbHour, null);
            }
        }

        private void tbPlate_Enter(object sender, EventArgs e)
        {
            toolTipPP.Show("Formats: ABC-0000, ABC-000", tbPlate);
        }

        private void tbPlate_Leave(object sender, EventArgs e)
        {
            toolTipPP.Hide(tbPlate);
        }

        private void tbHour_Enter(object sender, EventArgs e)
        {
            toolTipPP.Show("Format: HH:MM", tbHour);
        }

        private void tbHour_Leave(object sender, EventArgs e)
        {
            toolTipPP.Hide(tbHour);
        }
    }
}
