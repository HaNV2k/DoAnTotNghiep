namespace DoAnTotNghiep.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public string sku { get; set; }

        [Key]
        [Column(Order = 2)]
        public string name { get; set; }

        [Key]
        [Column(Order = 3)]
        public double price { get; set; }

        [Key]
        [Column(Order = 4)]
        public double original_price { get; set; }

        [Key]
        [Column(Order = 5)]
        public double rating_average { get; set; }

        [Key]
        [Column(Order = 6)]
        public string thumbnail_url { get; set; }

        [Key]
        [Column(Order = 7)]

        public string brand_id { get; set; }

        [Key]
        [Column(Order = 8)]
        public string brand_name { get; set; }

        [Key]
        [Column(Order = 9)]
        public double review_count { get; set; }

        [Key]
        [Column(Order = 10)]
        public double value { get; set; }
        [Key]
        [Column(Order = 11)]
        public string Address { get; set; }
        [Key]
        [Column(Order = 12)]
        public double discount { get; set; }


    }
}
