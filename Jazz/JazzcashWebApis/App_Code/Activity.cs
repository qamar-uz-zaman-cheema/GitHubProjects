using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Web;

public class Activity : IActivity
{


    public string doActivityEnc(string req)
    {

        string resp = "";

        wsLocal.LocalClient ws = new wsLocal.LocalClient();

        try
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback += delegate { return true; };
            resp = ws.doActivity(req);
        }
        catch (Exception ex)
        {
            Log.LogErrorTextFile("", ex.Message, ex.StackTrace, "doActivityEnc", "","", req);
        }
        finally
        {
            if (ws != null)
            {
                ws.Close();
            }
        }

        return resp;
    }



   
}

