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

    public partial class AppointmentEmployee : XPLiteObject
    {
        int fIdAppointmentEmployee;
        [Key(true)]
        public int IdAppointmentEmployee
        {
            get { return fIdAppointmentEmployee; }
            set { SetPropertyValue<int>("IdAppointmentEmployee", ref fIdAppointmentEmployee, value); }
        }
        int fIdEmployee;
        public int IdEmployee
        {
            get { return fIdEmployee; }
            set { SetPropertyValue<int>("IdEmployee", ref fIdEmployee, value); }
        }
        Appointments fUniqueID;
        [Association(@"AppointmentEmployeeReferencesAppointments")]
        public Appointments UniqueID
        {
            get { return fUniqueID; }
            set { SetPropertyValue<Appointments>("UniqueID", ref fUniqueID, value); }
        }
    }

}
