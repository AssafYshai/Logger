using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Collections;

namespace Logger
{

    enum LOGTYPE
    {
        FILE,
        SYSTEM,
        DB
    }
    class Logger
    {
        

        string logFilePath;
        string logDbConStr;
        string logSource;
        LOGTYPE log;


        /// <summary>
        /// Logger constructor.
        /// </summary>
        /// <param name="sLogSource">The log source - file path, connection string or source name - according to the log type.</param>
        /// <param name="logtype">enum LOGTYPE</param>
        public Logger(string sLogSource, LOGTYPE logtype)
        {
            switch(logtype)
            {
                case LOGTYPE.FILE:
                    logFilePath = sLogSource;
                    if(logFilePath.Trim().Length == 0)
                    {
                        logFilePath = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".log";
                    }
                    log = logtype;
                    break;
                case LOGTYPE.SYSTEM:
                    logSource = sLogSource;
                    log = logtype;
                    break;
                case LOGTYPE.DB:
                    logDbConStr = sLogSource;
                    log = logtype;
                    break;
            }
        }

        /// <summary>
        /// Add line to the log.
        /// </summary>
        /// <param name="sMsg">The event message</param>
        /// <param name="eventType">Event type - "Warning", "Information" or "Error"</param>
        public void write(string sMsg, string evntType)
        {
            switch (log)
            {
                case LOGTYPE.FILE:
                    writeToFile(sMsg, evntType);
                    break;
                case LOGTYPE.SYSTEM:
                    writeToEventLog(sMsg, evntType);
                    break;
                case LOGTYPE.DB:
                    writeToDB(sMsg, evntType);
                    break;
            }
            
        }

        private void writeToFile(string sMsg, string eventType)
        {

            bool isNewFile = true;

            using (var file = File.Open(logFilePath, FileMode.OpenOrCreate))
            {
                if(file.Seek(0, SeekOrigin.End) > 0) 
                {
                    isNewFile = false;
                }
                string strDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
                using (var stream = new StreamWriter(file))
                {
                    if(isNewFile)
                    {
                        stream.WriteLine("- " + strDate + " : File Created.");
                    }
                    stream.WriteLine("- " + strDate + " : " + eventType + " - " + sMsg);
                    stream.Close();
                }
            }         
        }


        
        private void writeToEventLog(string sMsg, string eventType)
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string appVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            EventLogEntryType entryType = new EventLogEntryType();

            switch(eventType)
            {
                case "Error":
                    entryType = EventLogEntryType.Error;
                    break;
                case "Warning":
                    entryType = EventLogEntryType.Warning;
                    break;
                case "Information":
                    entryType = EventLogEntryType.Information;
                    break;
            }

            if (!EventLog.SourceExists(appName))
            {
                EventLog.CreateEventSource(appName, logSource);
            }
          
            EventLog eventLog = new EventLog();
            
            eventLog.Source = appName;

            
            eventLog.WriteEntry(sMsg, entryType, 1002);
        }


        public void writeToDB(string sMsg, string eventType)
        {

            //I left this function empty so just rewrite according to your
            //database details.
            //The Hashtable was created to simulate how the table record should look like.
            

            Hashtable ht;

            ht = new Hashtable();

            string strDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

        
            ht.Add("EventType", eventType);
            ht.Add("DateAndTime", strDate);
            ht.Add("Event", sMsg);
        }
    }
}
