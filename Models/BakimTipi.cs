using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeGCore3._1Project.Models
{
    public class BakimTipi
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Bakım adı alanı boş geçilemez.")]
        public string BakimAdi { get; set; }

        [Required(ErrorMessage ="Bakım fiyatı alanı boş geçilemez.")]        
        public double BakimFiyati{ get; set; }

    }
}
