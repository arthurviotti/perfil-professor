using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace perfil_professor.Models
{
    [Table("Professores")]
    public class Professor
    {
        [Key]

        [Required(ErrorMessage = "Obrigatório informar o nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Username")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Email")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Mudarsenha")]

        public string Mudarsenha { get; set; }



    }
}
