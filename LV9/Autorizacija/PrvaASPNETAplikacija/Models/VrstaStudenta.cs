using System.ComponentModel.DataAnnotations;

namespace PrvaASPNETAplikacija.Models
{
    public enum VrstaStudenta
    {
        [Display(Name = "Redovni student")]
        Redovni,
        [Display(Name = "Redovni samofinansirajući student")]
        RedovniSF,
        [Display(Name = "Vanredni student")]
        Vanredni
    }
}
