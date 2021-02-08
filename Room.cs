namespace EksamenWebApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room
    {
        

        public int Room_No { get; set; }

        public int RoomId { get; set; }

        public int Building_No { get; set; }

        public string Room_Type { get; set; }

       
    }
}
