using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AEA.LoadTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contentA = siteALog.Text;
            var contentB = siteBLog.Text;

            if(!string.IsNullOrEmpty(contentA) && !string.IsNullOrEmpty(contentB))
            {
                int linesInA = 0, linesInB = 0;
                var parsedFileA = ParseLogFile(contentA, out linesInA);
                var parsedFileB = ParseLogFile(contentB, out linesInB);

                if(linesInA != linesInB)
                {
                    warningLbl1.Text = "Status: Line count dosnt match...";
                }

                var modelA = GetCompareDataFromLog(parsedFileA, "Site A");
                var modelB = GetCompareDataFromLog(parsedFileB, "Site B");

                // Result
                CompareData(modelA, modelB);
            }
        }

        private void CompareData(CompareModel modelA, CompareModel modelB)
        {
            // Display data
            lblSiteABytesReceived.Text = "Bytes recevied: " + modelA.BytesRecevied.ToString();
            lblSiteABytesSent.Text = "Bytes sent: " + modelA.BytesSent.ToString();
            lblSiteATimeTaken.Text = "Time taken: " + modelA.TimeTaken.ToString();

            lblSiteBBytesReceived.Text = "Bytes recevied: " + modelB.BytesRecevied.ToString();
            lblSiteBBytesSent.Text = "Bytes sent: " + modelB.BytesSent.ToString();
            lblSiteBTimeTaken.Text = "Time taken: " + modelB.TimeTaken.ToString();

            // Bytes recevied
            if (modelA.BytesRecevied > modelB.BytesRecevied)
            {
                int diff = modelA.BytesRecevied - modelB.BytesRecevied;
                int oneProcentage = modelA.BytesRecevied / 100;
                int saved = diff / oneProcentage;

                lblResultBytesReceived.Text = "Bytes recevied: " + saved + "% less";
            }
            else if (modelA.BytesRecevied < modelB.BytesRecevied)
            {
                int diff = modelB.BytesRecevied - modelA.BytesRecevied;
                int oneProcentage = modelA.BytesRecevied / 100;
                int saved = diff / oneProcentage;

                lblResultBytesReceived.Text = "Bytes recevied: " + saved + "% increase";
            }
            else
            {
                lblResultBytesReceived.Text = "Bytes recevied: Equal load";
            }

            // Bytes sent
            if (modelA.BytesSent > modelB.BytesSent)
            {
                int diff = modelA.BytesSent - modelB.BytesSent;
                int oneProcentage = modelA.BytesSent / 100;
                int saved = diff / oneProcentage;

                lblResultBytesSent.Text = "Bytes sent: " + saved + "% less";
            }
            else if (modelA.BytesSent < modelB.BytesSent)
            {
                int diff = modelB.BytesSent - modelA.BytesSent;
                int oneProcentage = modelA.BytesSent / 100;
                int saved = diff / oneProcentage;

                lblResultBytesSent.Text = "Bytes sent: " + saved + "% increase";
            }
            else
            {
                lblResultBytesSent.Text = "Bytes sent: Equal load";
            }
            
            // Time taken
            if (modelA.TimeTaken > modelB.TimeTaken)
            {
                int diff = modelA.TimeTaken - modelB.TimeTaken;
                int oneProcentage = modelA.TimeTaken / 100;
                int saved = diff / oneProcentage;

                lblResultTimeTaken.Text = "Time taken: " + saved + "% less";
                lblResultWinner.Text = "Winner: " + modelB.LogName;
            }
            else if (modelA.TimeTaken < modelB.TimeTaken)
            {
                int diff = modelB.TimeTaken - modelA.TimeTaken;
                int oneProcentage = modelA.TimeTaken / 100;
                int saved = diff / oneProcentage;

                lblResultTimeTaken.Text = "Time taken: " + saved + "% increase";
                lblResultWinner.Text = "Winner: " + modelA.LogName;
            }
            else
            {
                lblResultTimeTaken.Text = "Time taken: Equal load";
                lblResultWinner.Text = "Winner: tie";
            }

        }

        private CompareModel GetCompareDataFromLog(string log, string logName)
        {
            StringReader reader = new StringReader(log);
            var model = new CompareModel();
            int totalBytesSent = 0, totalBytesRecevied = 0, totalTimeTaken = 0;

            try
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parameters = line.Split(' ');

                    int bytesSent = 0, bytesRecevied = 0, timeTaken = 0;

                    int.TryParse(parameters[6], out bytesSent);
                    int.TryParse(parameters[7], out bytesRecevied);
                    int.TryParse(parameters[8], out timeTaken);

                    totalBytesSent += bytesSent;
                    totalBytesRecevied += bytesRecevied;
                    totalTimeTaken += timeTaken;
                }
            }
            catch { }

            return new CompareModel
            {
                BytesRecevied = totalBytesRecevied,
                BytesSent = totalBytesSent,
                TimeTaken = totalTimeTaken,
                LogName = logName
            };
        }

        private string ParseLogFile(string log, out int lines)
        {
            StringReader reader = new StringReader(log);
            StringBuilder builder = new StringBuilder();
            lines = 0;

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("#"))
                    continue;

                builder.AppendLine(line);
                lines++;
            }

            return builder.ToString();
        }
    }
}
