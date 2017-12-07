using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Logger
{
    public partial class Form1 : Form
    {
        String eventType;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Logger logger;

           

            if(comboEventType.SelectedIndex == -1)
            {
                txtComments.AppendText("Choose type of event\n");
                return;
            }

            if(rbFile.Checked)
            {
                txtComments.AppendText("Sent to logger - log type: file.   message: " + txtLogMessage.Text + ".    Event type: " + eventType + "\n");
                logger = new Logger(txtLogFilePath.Text, LOGTYPE.FILE);
                logger.write(txtLogMessage.Text, eventType);
            }

            if(rbEventLog.Checked)
            {
                txtComments.AppendText("Sent to logger - log type: Sys. events.   message: " + txtLogMessage.Text + ".    Event type: " + eventType + "\n");
                logger = new Logger(txtLogFilePath.Text, LOGTYPE.SYSTEM);
                logger.write(txtLogMessage.Text, eventType);
            }

            if(rbDB.Checked)
            {
                //The first parameter should be the connection string.
                txtComments.AppendText("Sent to logger - log type: Database.   message: " + txtLogMessage.Text + ".    Event type: " + eventType + "\n");
                logger = new Logger("", LOGTYPE.DB);
                logger.write(txtLogMessage.Text, eventType);
            }

        }

        
        

        private void comboEventType_SelectedIndexChanged(object sender, EventArgs e)
        {
            eventType = comboEventType.SelectedItem.ToString();
        }
    }
}
