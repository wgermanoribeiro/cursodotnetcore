using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(50), MinLength(2)]
        [Display(Name = "Primeiro Nome")]
        public string PrimeiroNome { get; set; }

        [Required]
        [StringLength(50), MinLength(2)]
        [Display(Name = "Último Nome")]
        public string UltimoNome { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Permitido máximo 20 caracteres"), MinLength(5, ErrorMessage = "Permitido minimo 5 caracteres")]
        [Display(Name = "Login")]
        public string Login { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:dd/MM/yyyy)", ApplyFormatInEditMode = true)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Permitido máximo 50 caracteres"), MinLength(5, ErrorMessage = "Permitido minimo 5 caracteres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Permitido máximo 20 caracteres"), MinLength(5, ErrorMessage = "Permitido minimo 5 caracteres")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }
    }
}
