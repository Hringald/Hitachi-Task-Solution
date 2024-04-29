using System.Net.Mail;
using System.Text;
using System.Xml;

namespace Forecast.Email
{
    public class ForecastEmail
    {
        public ForecastEmail()
        {

        }

        public static void EmailSend(string FilePathTemp, string SenderEmail, string SenderPassword, string RecieverEmail)
        {
            var Culture = Thread.CurrentThread.CurrentCulture;
            string CultureName = Culture.Name;

            StringBuilder FilePath = new StringBuilder();
            FilePath.Append(FilePathTemp);
            FilePath.Append(@"\Output\LaunchAnalysisReport.csv");

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");

            try
            {
                mail.From = new MailAddress(SenderEmail);
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("Es gibt keine solche Absender-E-Mail oder die E-Mail hat nicht das richtige Format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("There is no such sender email or the email is not in the right format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            try
            {
                mail.To.Add(RecieverEmail);
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("Es gibt keine solche Empfänger-E-Mail oder die E-Mail hat nicht das richtige Format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("There is no such reciever email or the email is not in the right format.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (CultureName == "de")
            {
                mail.Subject = "Beste Station und Tag für den Start.";
                mail.Body = "Diese E-Mail enthält die Daten für den besten Tag und die beste Station für den Start.";
            }
            else
            {
                mail.Subject = "Best station and day for launch.";
                mail.Body = "This email contains the data for the best day and station for the launch.";
            }

            System.Net.Mail.Attachment attachment;
            try
            {
                attachment = new System.Net.Mail.Attachment(FilePath.ToString());
                mail.Attachments.Add(attachment);
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("In diesem Ordner befindet sich keine Datei mit den besten Startdaten.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("No file with best launch data is located in this folder.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            SmtpServer.Port = 587;
            try
            {
                SmtpServer.Credentials = new System.Net.NetworkCredential(SenderEmail, SenderPassword);
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("E-Mail-Name oder Passwort ist falsch.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Email name or password is incorrect.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            SmtpServer.EnableSsl = true;

            try
            {
                SmtpServer.Send(mail);
                if (CultureName == "de")
                {
                    MessageBox.Show("Die E-Mail mit der besten Station und dem Starttag wurde erfolgreich gesendet.", "Success");
                }
                else
                {
                    MessageBox.Show("The email with the best station and launch day are successfully sent.", "Success");
                }
                Application.Exit();
            }
            catch (Exception)
            {
                if (CultureName == "de")
                {
                    MessageBox.Show("E-Mail wird nicht gesendet.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Email is not sent.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
