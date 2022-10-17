using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAnTotNghiep.Models
{
    [Table("Cart")]
    public class Cart
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DateTime createDate { get; set; }

        [Key]
        [Column(Order = 1)]
        public string idUser { get; set; }

        [Key]
        [Column(Order = 2)]
        public string idProduct { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Quantiy { get; set; }

        [Key]
        [Column(Order = 4)]
        public string isDelete { get; set; }


    }
}