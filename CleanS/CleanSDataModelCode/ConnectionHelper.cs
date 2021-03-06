﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;

namespace CleanS.CleanS
{
    public static class ConnectionHelper
    {
        //public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=WRC0A108;user id=sa;password=MANOSm!11;initial catalog=CleanS;Persist Security Info=true";
        //public const string ConnectionStringSql = @"data source=WRC0A108;user id=sa;password=MANOSm!11;initial catalog=CleanS;Persist Security Info=true";

        //public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=.;user id=sa;password=MANOSm!11;initial catalog=CleanS;Persist Security Info=true";
        //public const string ConnectionStringSql = @"data source=.;user id=sa;password=MANOSm!11;initial catalog=CleanS;Persist Security Info=true";
        /// <summary>
        /// 
        /// </summary>
        public static String ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["XPOServiceConnection"].ConnectionString;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static String ConnectionStringSql
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ServiceConnection"].ConnectionString;
            }
        }

        //public const string ConnectionString = @"XpoProvider=MSSqlServer;data source=DESKTOP-7NMQF6A;user id=sa;password=111111;initial catalog=CleanS;Persist Security Info=true";

        //public const string ConnectionStringSql = @"data source=DESKTOP-7NMQF6A;user id=sa;password=111111;initial catalog=CleanS;Persist Security Info=true";

        public static void Connect(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
            XpoDefault.Session = null;
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption);
        }
        public static DevExpress.Xpo.DB.IDataStore GetConnectionProvider(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption, out IDisposable[] objectsToDisposeOnDisconnect)
        {
            return XpoDefault.GetConnectionProvider(ConnectionString, autoCreateOption, out objectsToDisposeOnDisconnect);
        }
        public static IDataLayer GetDataLayer(DevExpress.Xpo.DB.AutoCreateOption autoCreateOption)
        {
            return XpoDefault.GetDataLayer(ConnectionString, autoCreateOption);
        }
    }

}
