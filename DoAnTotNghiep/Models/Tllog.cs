using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DoAnTotNghiep.Models
{
    [Table("Tllog")]
    public class Tllog
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
        public string skuProduct { get; set; }

        [Key]
        [Column(Order = 4)]
        public string action { get; set; }

        [Key]
        [Column(Order = 5)]
        public int itTllog { get; set; }


    }
}