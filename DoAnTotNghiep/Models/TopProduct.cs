
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoAnTotNghiep.Models
    {
    [Table("TopProduct")]
    public partial class TopProduct
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
        public string price { get; set; }

        [Key]
        [Column(Order = 4)]
        public string original_price { get; set; }

        [Key]
        [Column(Order = 5)]
        public string rating_average { get; set; }

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
        public string review_count { get; set; }

        [Key]
        [Column(Order = 10)]
        public string value { get; set; }
        [Key]
        [Column(Order = 11)]
        public string Address { get; set; }
        [Key]
        [Column(Order = 12)]
        public double discount { get; set; }

    }
}
