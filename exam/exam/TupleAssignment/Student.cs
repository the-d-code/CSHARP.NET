//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TupleAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int Stid { get; set; }
        public string Stname { get; set; }
        public int Cid { get; set; }
        public int Sid { get; set; }
    
        public virtual Class Class { get; set; }
        public virtual Schl Schl { get; set; }
    }
}
