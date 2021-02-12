using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskaSluzba.Models
{
    public class UpisNaPredmet
    {
        #region Properties

        [Required]
        public int AkademskaGodina { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DatumUpisa { get; set; }

        [Key]
        [Required]
        public string BrojProtokola { get; set; }

        #endregion

        #region Konstruktor

        public UpisNaPredmet() { }

        public UpisNaPredmet(int year, DateTime date, string number)
        {
            AkademskaGodina = year;
            DatumUpisa = date;
            BrojProtokola = number;
        }

        #endregion
    }
}
