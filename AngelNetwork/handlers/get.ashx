<%@ WebHandler Language="C#" Class="Get" %>

using System;
using System.Web;
using Newtonsoft.Json;
using Business;

public class Get : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        //mind the method GET not the post
        //var json = HttpUtility.UrlDecode(context.Request.QueryString.ToString());

        //var result = Handlers.Get(json);

        //context.Response.ContentType = "text/json";
     //   context.Response.Write(result);
        //var path = context.Server.MapPath(@"content\") + "role_info.js";
        //System.IO.File.WriteAllText(path,result);
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}