using System;
using System.Collections.Generic;
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
        public int ID { get; set; }

        [Required]
        public string Naziv { get; set; }

        [Required]
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
