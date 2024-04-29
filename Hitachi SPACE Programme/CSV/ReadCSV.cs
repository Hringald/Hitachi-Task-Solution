using Forecast.Enumerators;
using Forecast.ForecastModels;
using Hitachi_SPACE_Programme.Enumerators;

namespace Forecast.CSV
{
    public class ReadCSV
    {
        public ReadCSV()
        {

        }

        public static List<ForecastIn> ReadCsvFile(string FilePath, string MaxHumidityString)
        {
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            var ForeCastList = new List<ForecastIn>();
            var BestForecasts = new List<ForecastIn>();
            int LocationEnumValueNumber;
            Location LocationEnumValue;
            try
            {
                var filePaths = Directory.GetFiles(FilePath, "*.csv");

                foreach (string filePath in filePaths)
                {
                    string FileNameTmp = Path.GetFileName(filePath);
                    string FileName = FileNameTmp.Replace(".csv", "");
                    var fileData = File.ReadAllLines(filePath);
                    try
                    {
                        LocationEnumValueNumber = EnumParser.GetIntFromEnumName(FileName);
                        LocationEnumValue = EnumParser.GetEnumValueFromInt(LocationEnumValueNumber);
                    }
                    catch (Exception)
                    {
                        if (CultureName == "de")
                        {
                            MessageBox.Show($"Der Name für die Datei: {FileNameTmp} ist nicht korrekt.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"The name for file: {FileNameTmp} is not correct.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        continue;
                    }

                    try
                    {
                        for (var i = 0; i < fileData.Length; i++)
                        {
                            var tmpData = fileData[i].Split(';');

                            for (var j = 0; j < tmpData.Length; j++)
                            {
                                var t1 = tmpData[j];
                                if (j == 0)
                                    continue;
                                switch (i)
                                {
                                    case 0:
                                        {
                                            var ForecastObject = new ForecastIn { Day = int.Parse(t1) };
                                            ForecastObject.Location = LocationEnumValue;
                                            ForeCastList.Add(ForecastObject);
                                        }
                                        break;
                                    case 1:
                                        {
                                            ForeCastList[j - 1].Temperature = int.Parse(t1);
                                        }
                                        break;
                                    case 2:
                                        {
                                            ForeCastList[j - 1].Wind = int.Parse(t1);
                                        }
                                        break;
                                    case 3:
                                        {
                                            ForeCastList[j - 1].Humidity = int.Parse(t1);
                                        }
                                        break;
                                    case 4:
                                        {
                                            ForeCastList[j - 1].Precipitation = int.Parse(t1);
                                        }
                                        break;
                                    case 5:
                                        {
                                            ForeCastList[j - 1].Lightning = t1;
                                        }
                                        break;
                                    case 6:
                                        {
                                            ForeCastList[j - 1].Clouds = t1;
                                        }
                                        break;
                                }

                            }
                        }
                    }
                    catch (Exception)
                    {
                        if (CultureName == "de")
                        {
                            MessageBox.Show($"Es gibt inkonsistente Daten in der Datei: {FileNameTmp}.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"There is inconsistent data in file: {FileNameTmp}.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        continue;
                    }

                    ForecastIn BestForecast = ForecastIn.SetBestForecast(ForeCastList, LocationEnumValue, MaxHumidityString);

                    ForeCastList = new List<ForecastIn>();

                    //Set best forecasts in list
                    if (BestForecast != null)
                    {
                        BestForecasts.Add(BestForecast);
                    }
                }
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("Am angegebenen Speicherort wurden keine CSV-Dateien gefunden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No CSV files are found in the given location.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return BestForecasts;
        }
    }

}