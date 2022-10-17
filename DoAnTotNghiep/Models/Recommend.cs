using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAnTotNghiep.Models
{
    [Table("Recommendation")]
    public class Recommend
    {
        [Key]
        [Column(Order = 0)]
        public string idUser { get; set; }

        [Key]
        [Column(Order = 1)]
        public string idProduct { get; set; }

        [Key]
        [Column(Order = 2)]
        public string thumbnail_url { get; set; }

        [Key]
        [Column(Order = 3)]
        public string nameProduct { get; set; }

        [Key]
        [Column(Order = 4)]
        public string category { get; set; }
    }
}