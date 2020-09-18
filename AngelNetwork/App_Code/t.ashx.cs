using Beautiful;
using Business; 
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web; 
using System.IO;
 

public class T : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {


    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}