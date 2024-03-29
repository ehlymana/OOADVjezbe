﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrvaASPNETAplikacija.Models
{
    public class ValidateDate : ValidationAttribute
    {
        protected override ValidationResult IsValid
                         (object date, ValidationContext validationContext)
        {
            return ((DateTime)date >= DateTime.Now.AddDays(-14) && (DateTime)date <= DateTime.Now)
                ? ValidationResult.Success
                : new ValidationResult("Validan je upis između 14 dana u prošlosti i danas!");
        }
    }

    public class UpisNaPredmet
    {
        [Key]
        public int ID { get; set; }

        [ValidateDate]
        [DataType(DataType.Date)]
        public DateTime DatumUpisa { get; set; }

        [ForeignKey("Student")]
        public int StudentId { get; set; }

        [ForeignKey("Predmet")]
        public int PredmetId { get; set; }

        public Student Student { get; set; }

        public Predmet Predmet { get; set; }

        public UpisNaPredmet() { }
    }
}
