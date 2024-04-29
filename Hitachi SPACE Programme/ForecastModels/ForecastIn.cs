using Forecast.Enumerators;

namespace Forecast.ForecastModels
{
    public class ForecastIn
    {
        public Location Location { get; set; }
        public int Day { get; set; }
        public int Temperature { get; set; }
        public int Wind { get; set; }
        public int Humidity { get; set; }
        public int Precipitation { get; set; }
        public string? Lightning { get; set; }
        public string? Clouds { get; set; }

        public static ForecastOut GetBestForecastStation(List<ForecastIn> Forecasts)
        {
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            try
            {
                ForecastIn BestForecast = Forecasts
               .OrderBy(x => (int)(x.Location))
               .ToList().First();

                ForecastOut BestForecastStation = new ForecastOut();
                BestForecastStation.StationName = BestForecast.Location.ToString();
                BestForecastStation.BestDay = BestForecast.Day.ToString();
                return BestForecastStation;
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("Es ist keine Station mit geeigneten Prognosestatistiken verfügbar.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("There is no station with suitable forecast statistics available.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }
        }

        public static ForecastIn SetBestForecast(List<ForecastIn> Forecasts, Location LocationEnumValue, string MaxHumidityString)
        {
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            int MaxHumidity = 55;

            //Check if there is valid input for max humidity
            if (MaxHumidityString != "")
            {
                if (int.TryParse(MaxHumidityString, out int MaxHumidityInput))
                {
                    MaxHumidity = MaxHumidityInput;
                }
                else
                {
                    if (CultureName == "de")
                    {
                        MessageBox.Show("Die maximale Luftfeuchtigkeit hat kein gültiges Format und wird nicht berücksichtigt.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Max humidity is not in valid format and is not concidered.", "Warning",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

            //Get best day for launch for each spaceport
            try
            {
                List<ForecastIn> OrderedForecasts = Forecasts.Where
                   (
                   f => f.Temperature >= 1 &&
                   f.Temperature <= 32 &&
                   f.Wind <= 11 &
                   f.Humidity < MaxHumidity &&
                   f.Precipitation == 0 &&
                   f.Lightning == "No" &&
                   f.Clouds != "Cumulus" &&
                   f.Clouds != "Nimbus" &&
                   f.Location == LocationEnumValue
                   ).OrderBy(f => f.Wind)
                    .ThenBy(f => f.Humidity)
                   .ToList();

                return OrderedForecasts.First();
            }
            catch (Exception e)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show($"Für die Station {LocationEnumValue} wurde kein passender Tag gefunden.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show($"No suitable day is found for station: {LocationEnumValue}.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }
        }
    }
}
