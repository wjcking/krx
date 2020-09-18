using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business;

namespace Contexts
{
    /// <summary>
    /// Contexts 
    /// </summary>
    public class Contexts
    {

        public static string GetJson(HttpContext context)
        {
            var body = context.Request.InputStream;
            var encoding = context.Request.ContentEncoding;

            var reader = new System.IO.StreamReader(body, encoding);
            string json = reader.ReadToEnd();
           reader.Close();

            return json;
        }
    }
}