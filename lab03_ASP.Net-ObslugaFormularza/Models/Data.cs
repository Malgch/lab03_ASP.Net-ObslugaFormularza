using System.ComponentModel.DataAnnotations;

namespace lab03_ASP.Net_ObslugaFormularza.Models
{
    public class Data
    {
        [Required(ErrorMessage = "Please fill your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please fill your e-mail address")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public string PhoneNumber { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        
        
    }
}

/* Imię (wymagane, minimum 2 znaki)
• Nazwisko (wymagane, minimum 2 znaki)
• Adres e-mail (wymagane, poprawny adres e-mail)
• Hasło (wymagane, minimum 8 znaków, co najmniej jedna cyfra, jedna duża litera i jedna
mała litera)
• Potwierdzenie hasła (wymagane, musi być takie samo jak pole hasło)
• Nr telefonu (odpowiedni typ)
• Wiek (powyżej 10 lat do 80 lat)
• Miasto (wybór z 5 propozycji) */ 