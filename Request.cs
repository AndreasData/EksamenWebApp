namespace EksamenWebApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

   
    public partial class Request
    {
        public int RequestId { get; set; }

        public int? RoomId { get; set; }

        public int? WorkerId { get; set; }


        public string Requestinfo { get; set; }

        public virtual Room Room { get; set; }

        public virtual Worker Worker { get; set; }
    }
}
