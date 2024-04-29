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
    public partial class IndexControl : UserControl
    {
        public IndexControl()
        {
            InitializeComponent();

            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            if (CultureName == "de")
            {
                IndexTitle.Text = "SPACE Programm";
                IndexContinueBtn.Text = "Weitermachen";
                IndexTextContent.Text = "Diese Anwendung analysiert die Startbedingungen des Space Shuttles im Hinblick auf Wetter und Standort.\r\nFindet anhand der\r\nWetterkriterien das am besten geeignete Datum/den besten Ort für den Start des Space Shuttles.\r\nSendet den besten Tag und die beste Raumstation für den Start und sendet eine CSV-Datei an die vom Benutzer\nangegebene E-Mail.\r\n\r\nDie verfügbaren Raumstationen sind:\r\nKourou, Französisch-Guayana \r\nTanagashima, Japan\r\nCape Canaveral, USA \r Mahia, Neuseeland\r\nKodiak, USA\r\n\r\n Die Dateien müssen im CSV-Format vorliegen und die Namen für jede Station müssen sein:\r\nKourou,\r\nTanagashima,\r\nCapeCanaveral, \r\nMahia,\r\nKodiak";
            }
            else
            {
                IndexTitle.Text = "SPACE Programme";
                IndexContinueBtn.Text = "Continue";
                IndexTextContent.Text = "This application analyses the space shuttle launch conditions with regard to weather and location.\r\nFinds the most appropriate date/location for the space shuttle launch based on the\r\nweather criteria.\r\nSends the best day and space station for the launch and sends CSV file to email given by the user.\r\n\r\nThe Available space stations are:\r\nKourou, French Guyana \r\nTanagashima, Japan\r\nCape Canaveral, USA \r\nMahia, New Zealand\r\nKodiak, USA\r\n\r\nThe files need to be in csv format and the names for each station must to be:\r\nKourou,\r\nTanagashima,\r\nCapeCanaveral,\r\nMahia,\r\nKodiak";
            }

        }

        private void IndexTextContent_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
