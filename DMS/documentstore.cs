//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class documentstore
    {
        public int id { get; set; }
        public int studentId { get; set; }
        public int semesterId { get; set; }
        public string docCategory { get; set; }
        public string document { get; set; }
    
        public virtual student student { get; set; }
        public virtual semester semester { get; set; }
    }
}