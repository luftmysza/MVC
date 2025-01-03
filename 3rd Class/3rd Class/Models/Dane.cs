using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _3rd_Class.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Podaj Imię!")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Podaj Email!")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj Temat!")]
        public string Temat { get; set; }

        [Required(ErrorMessage = "Dodaj Treść wiadomości!")]
        [MinLength(10), MaxLength(50)]
        public string Tresc { get; set; }
    }
}