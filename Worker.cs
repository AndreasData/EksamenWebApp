namespace EksamenWebApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Worker
    {
        

        public int WorkerId { get; set; }
        
        public string WorkerName { get; set; }

        public string WorkerProf { get; set; }

    }
}
