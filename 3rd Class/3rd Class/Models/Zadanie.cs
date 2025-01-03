using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _3rd_Class.Models
{
    public class Zadanie
    {
        [Required(ErrorMessage = "Podaj Imię, co najmniej 2 znaki!")]
        [MinLength(2), MaxLength(20)]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Podaj Nazwisko, co najmniej 2 znaki!")]
        [MinLength(2), MaxLength(20)]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Podaj Email w poprawnym formacie!")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj Hasło: co najmniej 1 wielka litera, 1 mala litera, 1 cyfra!")]
        [RegularExpression("^(?=.*[A-Z])(?=.*[a-z])(?=.*\\d)[A-Za-z\\d@$!%*?&]{8,20}$")]
        [MinLength(8), MaxLength(20)]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Compare("Haslo", ErrorMessage = "Hasla sie nie zgadzaja!")]
        [DisplayName("Potwierdz Haslo")]
        [Required(ErrorMessage = "Podaj Hasło: co najmniej 1 wielka litera, 1 mala litera, 1 cyfra!")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)[A-Za-z\d@]{8,20}$")]
        [MinLength(8), MaxLength(20)]
        [DataType(DataType.Password)]
        public string HasloPotw { get; set; }

        [RegularExpression(@"^\(\d{3}\)\(\d{3}\)\(\d{3}\)$")]
        [DataType(DataType.PhoneNumber)]
        public string Telnumer {  get; set; }

        // [Required(ErrorMessage = "Podaj Temat!")]
        [Range(12,80)]
        public int Wiek { get; set; }

        // [Required(ErrorMessage = "Dodaj Treść wiadomości!")]
        // [MinLength(10), MaxLength(50)]
        
        public string Miasto { get; set; }
        public enum Miasta
        {
            Krakow = 0,
            Warszawa = 1,
            Gdansk = 2,
            Wroclaw = 3,
            Katowice = 4
        }
    }
}