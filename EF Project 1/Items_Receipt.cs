namespace EF_Project_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Items_Receipt
    {
        public int Receipt_ID { get; set; }

        public int Item_ID { get; set; }

        public int Quantity { get; set; }

        public int Person_ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime P_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime EX_Date { get; set; }

        [Key]
        public int Item_Receipt_ID { get; set; }

        public virtual Item Item { get; set; }

        public virtual Person Person { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
