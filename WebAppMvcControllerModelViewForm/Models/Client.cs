//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppMvcControllerModelViewForm.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Client
    {
        public Client()
        {
            this.ProjectClients = new HashSet<ProjectClient>();
        }
    
        public int ClientId { get; set; }
        public string Name { get; set; }
        public Nullable<int> CategoryId { get; set; }
    
        public virtual ICollection<ProjectClient> ProjectClients { get; set; }
    }
}
