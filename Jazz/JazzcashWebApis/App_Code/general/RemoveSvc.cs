﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for RemoveSvc
/// </summary>
public class RemoveSvc : IHttpModule
{
    public void Dispose()
    {
    }
    public void Init(HttpApplication context)
    {
        context.BeginRequest += delegate
        {
            HttpContext cxt = HttpContext.Current;
            string path = cxt.Request.AppRelativeCurrentExecutionFilePath;
            int i = path.IndexOf('/', 2);
            if (i > 0)
            {
                string a = path.Substring(0, i) + ".svc";
                string b = path.Substring(i, path.Length - i);
                string c = cxt.Request.QueryString.ToString();
                cxt.RewritePath(a, b, c, false);
            }
        };
    }
}