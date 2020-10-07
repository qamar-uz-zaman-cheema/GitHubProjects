using System;
using System.IO;
using System.Text.RegularExpressions;
using System.ServiceModel.Channels;
using System.ServiceModel;

    /// <summary>
    /// Summary description for LogError
    /// </summary>
    public class Log
    {
        static string LogFileDirectory = System.Configuration.ConfigurationSettings.AppSettings["LogFileDirectory"].ToString().Trim();


        public static void LogErrorTextFile(string IP, string errTXT, string errorTrace, string methodname, string errorCode, string CurrentTranID, string ParameterInputs)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(LogFileDirectory + "WebApiLog.txt", true))
                {
                    
                    //sw.WriteLine("IP            : " + IP);
                    sw.WriteLine("Date          : " + System.DateTime.Now.ToString());
                    //sw.WriteLine("ErrorCode     : " + errorCode);
                    //sw.WriteLine("TranID        : " + CurrentTranID);
                    sw.WriteLine("Method/Module : " + methodname);
                    sw.WriteLine("Input Param   : " + (ParameterInputs != null ? ParameterInputs.TrimStart(',').Trim() : ParameterInputs));
                    sw.WriteLine("Error         : " + Regex.Replace(errTXT, @"\t|\n|\r", " "));
                    sw.WriteLine("Error Trace   : " + Regex.Replace(errorTrace, @"\t|\n|\r", " "));
                    sw.WriteLine("======================================================================================");

                    //sw.Close(); 
                }
            }
            catch (Exception )
            {


            }
        }


    }
