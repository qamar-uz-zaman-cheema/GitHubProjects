using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;
using System.IO;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IActivity" in both code and config file together.
[ServiceContract]
public interface IActivity
{
    //[OperationContract]
    [OperationContract]
    [WebInvoke(Method = "POST",
               ResponseFormat = WebMessageFormat.Json,
               RequestFormat = WebMessageFormat.Json)]
    string doActivityEnc(string req);
    
    /*
    [OperationContract]
    [WebInvoke(Method = "POST",
               ResponseFormat = WebMessageFormat.Json,
               RequestFormat = WebMessageFormat.Json)]
    string doActivity(string req);
    */
}
