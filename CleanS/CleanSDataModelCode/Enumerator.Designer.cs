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
namespace CleanS.CleanS
{

    public partial class Enumerator : XPLiteObject
    {
        int fIdEnumerator;
        [Key(true)]
        public int IdEnumerator
        {
            get { return fIdEnumerator; }
            set { SetPropertyValue<int>("IdEnumerator", ref fIdEnumerator, value); }
        }
        string fObjectKey;
        [Size(50)]
        public string ObjectKey
        {
            get { return fObjectKey; }
            set { SetPropertyValue<string>("ObjectKey", ref fObjectKey, value); }
        }
        int fRefKeyValue;
        public int RefKeyValue
        {
            get { return fRefKeyValue; }
            set { SetPropertyValue<int>("RefKeyValue", ref fRefKeyValue, value); }
        }
        string fDescription;
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
    }

}
