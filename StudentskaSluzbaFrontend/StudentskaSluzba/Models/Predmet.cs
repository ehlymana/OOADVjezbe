using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentskaSluzba.Models
{
    public class Predmet
    {
        #region Properties

        [Key]
        [Required]
        [DisplayName("ID predmeta:")]
        public int ID { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage = "Naziv predmeta smije imati između 3 i 50 karaktera!")]
        [RegularExpression(@"[0-9| |a-z|A-Z]*",
         ErrorMessage = "Dozvoljeno je samo korištenje velikih i malih slova, brojeva i razmaka!")]
        [DisplayName("Naziv predmeta:")]
        public string Naziv { get; set; }

        [Required]
        [Range(1.0, 10.0, ErrorMessage = "Broj ECTS bodova mora biti između 1 i 10!")]
        [DisplayName("Broj ECTS bodova:")]
        public double ECTS { get; set; }

        [NotMapped]
        public List<Student> UpisaniStudenti { get; set; }

        #endregion

        #region Konstruktor

        public Predmet() { }

        public Predmet(string name, double points)
        {
            ID = GenerišiID();
            Naziv = name;
            ECTS = points;
            UpisaniStudenti = new List<Student>();
        }

        #endregion

        #region Metode

        public int GenerišiID()
        {
            int id = 0;
            Random generator = new Random();
            for (int i = 0; i < 10; i++)
            {
                id += (int)Math.Pow(10, i) * generator.Next(0, 9);
            }
            return id;
        }

        #endregion
    }
}
