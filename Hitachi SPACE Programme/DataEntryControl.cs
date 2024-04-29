using Forecast.CSV;
using Forecast.Email;
using Forecast.ForecastModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hitachi_SPACE_Programme
{
    public partial class DataEntryControl : UserControl
    {
        public DataEntryControl()
        {
            InitializeComponent();
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            if (CultureName == "de")
            {
                InputFileLocationLabel.Text = "Bitte geben Sie den Speicherort des Ordners ein, der die CSV-Dateien enthält:\r\n";
                BrowseInputFolderBtn.Text = "Ordner durchsuchen";
                EnterEmailLabel.Text = "Bitte geben Sie folgende Daten ein:";
                SenderEmailInputLabel.Text = "E-Mail-Adresse des Absenders:";
                SenderPasswordLabel.Text = "E-Mail-Passwort des Absenders:";
                RecieverEmailLabel.Text = "E-Mail-Adresse des Empfängers:";
                HumidityLabel.Text = "Fügen Sie zusätzliche Kriterien für die maximale Luftfeuchtigkeit hinzu (optional):";
                ProcessDataBtn.Text = "Weitermachen";
            }
            else
            {
                InputFileLocationLabel.Text = "Please enter location of the folder contraining CSV files:";
                BrowseInputFolderBtn.Text = "Browse folder";
                EnterEmailLabel.Text = "Please enter the following data:";
                SenderEmailInputLabel.Text = "Sender email address:";
                SenderPasswordLabel.Text = "Sender email password:";
                RecieverEmailLabel.Text = "Reciever email address:";
                HumidityLabel.Text = "Add additional maximum humidity criteria(optional):";
                ProcessDataBtn.Text = "Continue";
            }
        }

        private void BrowseInputFolderBtn_Click(object sender, EventArgs e)
        {
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                InputPathTextBox.Text = diag.SelectedPath;
            }
            else
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("Sie haben den Ordner nicht ausgewählt!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("You didn't select the folder!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            string FilePathInput = InputPathTextBox.Text;
            string SenderEmail = SenderEmailTxtBox.Text;
            string SenderPassword = SenderPasswordTxtBox.Text;
            string RecieverEmail = RecieverEmailTxtBox.Text;
            string MaxHumidityString = MaxHumidityTxtBox.Text;

            List<ForecastIn> Forecasts = ReadCSV.ReadCsvFile(FilePathInput, MaxHumidityString);
            if (Forecasts.Any())
            {
                ForecastOut BestForecastStation = ForecastIn.GetBestForecastStation(Forecasts);

                WriteCSV.WriteCsvFile(FilePathInput, BestForecastStation);
                ForecastEmail.EmailSend(FilePathInput, SenderEmail, SenderPassword, RecieverEmail);
            }
        }
    }
}
