using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProEventos.Application.Dtos
{
    public class EventoDto
    {
        public int Id { get; set; }
        public string Local { get; set; }
        public string DataEvento { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigt�rio."),
       //MinLength(3, ErrorMessage = "{0} deve ter no m�nimo 4 caracteres."),
       //MaxLength(50, ErrorMessage = "{0} deve ter no m�ximo 50 caracteres.")
       StringLength(50, MinimumLength = 3,
                        ErrorMessage = "Intervalo permitido de 3 a 50 caracteres.")]
        public string Tema { get; set; }
        [Display(Name = "Qtd Pessoas")]
        [Range(1, 120000, ErrorMessage = "{0} n�o pode ser menor que 1 e maior que 120.000")]
        public int QtdPessoas { get; set; }
        [RegularExpression(@".*\.(gif|jpe?g|bmp|png)$",
                         ErrorMessage = "N�o � uma imagem v�lida. (gif, jpg, jpeg, bmp ou png)")]
        public string ImagemURL { get; set; }
        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [Phone(ErrorMessage = "O campo {0} est� com n�mero inv�lido")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} � obrigat�rio")]
        [Display(Name = "e-mail")]
        [EmailAddress(ErrorMessage = "� necess�rio ser um {0} v�lido")]
        public string Email { get; set; }
        public IEnumerable<LoteDto> Lotes { get; set; }
        public IEnumerable<RedeSocialDto> RedesSociais { get; set; }
        public IEnumerable<PalestranteDto> Palestrantes { get; set; } 
    }
}

