namespace EF_Project_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            Items_Receipt = new HashSet<Items_Receipt>();
        }

        public int ID { get; set; }

        public int Wearhouse_ID { get; set; }

        public DateTime receipt_date { get; set; }

        public bool Type { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Items_Receipt> Items_Receipt { get; set; }

        public virtual Warehouse Warehouse { get; set; }
    }
}
