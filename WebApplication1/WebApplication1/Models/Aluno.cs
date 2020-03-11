using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Aluno
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Permitido máximo 50 caracteres"), MinLength(3, ErrorMessage = "Permitido minimo 3 caracteres")]
        [Display(Name = "Primeiro Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Permitido máximo 50 caracteres"), MinLength(3, ErrorMessage = "Permitido minimo 3 caracteres")]
        [Display(Name = "Sobrenome")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(6, ErrorMessage = "Permitido maximo 6 caracteres")]
        [Display(Name = "RA")]
        public string RA { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(50, ErrorMessage = "Permitido maximo 50 caracteres")]
        [Display(Name = "Curso")]
        public string Curso { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(10, ErrorMessage = "Permitido maximo 10 caracteres")]
        [Display(Name = "Ativado : Pendente : Desativado")]
        public string Status { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:dd/MM/yyyy)", ApplyFormatInEditMode = true)]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:dd/MM/yyyy)", ApplyFormatInEditMode = true)]
        public DateTime DataTermino { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório!")]
        [StringLength(40, ErrorMessage = "Permitido máximo 40 caracteres")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(14, ErrorMessage = "Permitido máximo 14 caracteres")]
        [Display(Name = "Telefone")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(30, ErrorMessage = "Permitido máximo 30 caracteres")]
        [Display(Name = "Escola")]
        public string Escola { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(80, ErrorMessage = "Permitido máximo 80 caracteres")]
        [Display(Name = "Endereço")]
        public string Endereço { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [StringLength(11, ErrorMessage = "Permitido máximo 11 caracteres")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }
        
    }
}
