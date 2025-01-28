using System.ComponentModel.DataAnnotations;

namespace WebFormContact.Models
{
    public class ContactMessages
    {

        public int IdContacto { get; set; }

        [Required(ErrorMessage = "El nombre no puede ser nulo")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres ")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo no puede ser nulo")]
        [EmailAddress(ErrorMessage = "Ingrese un correo valido")]
        [StringLength(100, ErrorMessage = "No puede exceder los 100 caracteres ")]
        public string Corrreo { get; set; }
        [Required(ErrorMessage = "El mensaje no puede ser nulo")]
        [StringLength(255, ErrorMessage = "No puede exceder los 255 caracteres ")]
        public string Mensaje { get; set; }



    }
}
