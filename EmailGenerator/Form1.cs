using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailGenerator
{
    public partial class Form1 : Form
    {
        string tempPath;
        string ConfigDirectory = @"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\";
        List<string> FilesList = new List<string>();
        string RandomFact = "";
        string FillerResultsFile = @"C:\Users\" + Environment.UserName + @"\Google Drive\Craig\Filler Results\KDM TAS " + DateTime.Now.ToString("yyyy-MM-dd") + ".png";
        string EmailConfig = @"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\Emailer-Emails.txt";
        string ReleaseNotes = @"C:\Users\" + Environment.UserName + @"\Documents\KDM\Config\Emailer-ReleaseNotes.txt";

        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed) {
                string path = Directory.GetCurrentDirectory();
                File.Copy(System.IO.Path.Combine(path, "ReleaseNotes - Emailer.txt"), ReleaseNotes, true);
            }
            ClearReleaseNotesBttn.PerformClick();
            GetReleaseNotesBttn.PerformClick();
            GetAttachmentsBttn.PerformClick();
            StartEmailBody();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)        { if (res != null) res.Dispose();      if (File.Exists(tempPath)) File.Delete(tempPath);        }

        private void SendBttn_Click(object sender, EventArgs e)
        {
            Text = SendMail(false);
        }
        private void TestBttn_Click(object sender, EventArgs e)
        {
            Text = SendMail(true);
        }

        void StartEmailBody()
        {
            EmailBox.Clear();
            EmailBox.Text = Environment.NewLine + "Filler results : " + Environment.NewLine + Environment.NewLine;
            if (File.Exists(FillerResultsFile)) EmailBox.Text = EmailBox.Text + Path.GetFileName(FillerResultsFile);
            //adds a cat fact
            string jsonData = GET("https://catfact.ninja/fact"); dynamic result = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonData);
            RandomFact = result.fact;
            EmailBox.Text = EmailBox.Text + Environment.NewLine + Environment.NewLine + RandomFact;
            EmailBox.Text = EmailBox.Text + Environment.NewLine + Environment.NewLine + "Attached files : " + Environment.NewLine + Environment.NewLine + Path.GetFileName(tempPath);
        }
        string GET(string url) { var req = (HttpWebRequest)WebRequest.Create(url); var response = req.GetResponse(); Stream Strm = response.GetResponseStream(); StreamReader StrmRdr = new StreamReader(Strm); return StrmRdr.ReadToEnd(); }

        private void GetReleaseNotesBttn_Click(object sender, EventArgs e) { FilesList.Clear(); RelaseNotesList.Items.Clear(); NotesBox.Clear(); GetReleaseNotes(); }
        private void ClearReleaseNotesBttn_Click(object sender, EventArgs e) { RelaseNotesList.Items.Clear(); NotesBox.Clear(); }
        public void GetReleaseNotes()
        {
            foreach (string s in Directory.GetFiles(ConfigDirectory)) { if (s.Contains("ReleaseNotes")) { RelaseNotesList.Items.Add(Path.GetFileName(s)); FilesList.Add(s); } }
            CombineFiles(FilesList, NotesBox);
            CreateTempFile(FilesList);
        }
        void CombineFiles(List<string> files, TextBox TB)
        {
            foreach (string path in files)
            {
                List<string> list = File.ReadLines(path).ToList();
                for (int i = 0; i < list.Count; i++) TB.Text = TB.Text + list[i] + Environment.NewLine;
                TB.Text = TB.Text + Environment.NewLine + Environment.NewLine;
            }
        }
        void CreateTempFile(List<string> files)
        {
            tempPath = Path.GetTempFileName(); FileInfo fileInfo = new FileInfo(tempPath); fileInfo.Attributes = FileAttributes.Temporary; StreamWriter SWrtr = File.AppendText(tempPath);
            foreach (string path in files)
            {
                List<string> list = File.ReadLines(path).ToList();
                for (int i = 0; i < list.Count; i++) SWrtr.WriteLine(list[i]);
                SWrtr.WriteLine(); SWrtr.WriteLine();
            }
            SWrtr.Flush(); SWrtr.Close();
        }

        void GetAttachments() { if (File.Exists(FillerResultsFile)) { AttachmentsList.Items.Add(Path.GetFileName(FillerResultsFile)); } AttachmentsList.Items.Add(Path.GetFileName(tempPath));  }
        private void GetAttachmentsBttn_Click(object sender, EventArgs e) { AttachmentsList.Items.Clear(); GetAttachments(); }
        private void ClearAttachmentsBttn_Click(object sender, EventArgs e) { AttachmentsList.Items.Clear(); StartEmailBody(); }

        string SendMail(bool test)
        {
            try
            {
                string EmailList = "";
                List<string> list = File.ReadLines(EmailConfig).ToList(); List<int> Emails = new List<int>();
                for (int i = 0; i < list.Count; i++) EmailList = EmailList + ", " + list[i];

                MailMessage message = new MailMessage();

                if (test) message.To.Add("craigthomaskey@gmail.com");
                else message.To.Add(EmailList);

                message.Subject = "Filler Results - " + DateTime.Now.ToString("dddd, MMMM dd") + DaySuffix();
                message.From = new System.Net.Mail.MailAddress("craig.key@wiklundtradingllc.com");
                message.IsBodyHtml = true;
                if (File.Exists(FillerResultsFile)) message.AlternateViews.Add(getEmbeddedImage(FillerResultsFile));
                else return "No Results file.";

                Attachment Attchmnt = new Attachment(tempPath);
                Attchmnt.Name = "ReleaseNotes.txt";
                message.Attachments.Add(Attchmnt);

                SmtpClient smtp = new SmtpClient("smtpout.secureserver.net");
                smtp.Port = 25;
                smtp.Credentials = new NetworkCredential("craig.key@wiklundtradingllc.com", "Ct251603*");
                smtp.EnableSsl = true;
                smtp.Send(message);
                return "Email Sent";
            }
            catch (Exception e) { return "Email Failed - " + e.ToString(); }
        }
        LinkedResource res;
        private AlternateView getEmbeddedImage(String filePath)
        {
            res = new LinkedResource(filePath);
            res.ContentId = "FillerResults" + DateTime.Now.ToString("yyy-MM-dd");
            res.ContentType = new ContentType("image/bmp");           
            string htmlBody = EmailBox.Text.Replace(Environment.NewLine, "<br />");
            htmlBody = htmlBody.Replace(Path.GetFileName(FillerResultsFile), "<img src='cid:" + res.ContentId + "'/>");
            AlternateView alternateView = AlternateView.CreateAlternateViewFromString(htmlBody, null, MediaTypeNames.Text.Html);
            alternateView.LinkedResources.Add(res);
            return alternateView;
        }


        string DaySuffix()
        {
            if (DateTime.Now.Day % 10 == 1 && DateTime.Now.Day != 11) return "st";
            else if (DateTime.Now.Day % 10 == 2 && DateTime.Now.Day != 12) return "nd";
            else if (DateTime.Now.Day % 10 == 3 && DateTime.Now.Day != 13) return "rd";
            else return "th";
        }


    }
}
