//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetoesw3rd.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interview
    {
        public int interview_id { get; set; }
        public int interview_admin_id { get; set; }
        public int interview_users_id { get; set; }
        public System.DateTime interview_date { get; set; }
        public string interview_subject { get; set; }
        public System.TimeSpan interview_time { get; set; }
        public string interview_room { get; set; }
        public string interview_place { get; set; }
    }
}