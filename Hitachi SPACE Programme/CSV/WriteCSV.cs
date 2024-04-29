using System.Linq;
using System.Text;
using Forecast.ForecastModels;

namespace Forecast.CSV
{
    public class WriteCSV
    {
        public WriteCSV()
        {

        }
        public static void WriteCsvFile(string FilePathTemp, ForecastOut BestForecast)
        {
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            StringBuilder FilePath = new StringBuilder();
            FilePath.Append(FilePathTemp);
            FilePath.Append(@"\Output\");

            if (!Directory.Exists(FilePath.ToString()))
            {
                Directory.CreateDirectory(FilePath.ToString());
            }
            FilePath.Append(@"LaunchAnalysisReport.csv");

            String separator = ";";
            StringBuilder output = new StringBuilder();
            String[] headings = { "Station Name", "Best Day" };
            output.AppendLine(string.Join(separator, headings));

            String[] newLine = { BestForecast.StationName, BestForecast.BestDay };
            output.AppendLine(string.Join(separator, newLine));


            try
            {
                File.WriteAllText(FilePath.ToString(), output.ToString());
            }
            catch (Exception ex)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("Daten konnten nicht in die CSV-Datei geschrieben werden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Data could not be written to the CSV file.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
        }
    }
}
