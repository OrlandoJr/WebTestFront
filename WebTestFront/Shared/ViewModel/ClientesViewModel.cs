using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebTestFront.Shared.ViewModel
{
    public class ClientesViewModel
    {
        public ClientesViewModel()
        {

        }

        [Key]
        public int ClienteID { get; set; }

        [Required(ErrorMessage="O nome do Cliente é obrigatório", AllowEmptyStrings=false)]
        [StringLength(80, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Data de Nascimento do Cliente é obrigatório", AllowEmptyStrings = false)]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime Data_Nascimento { get; set; }

        [Required(ErrorMessage = "O nome do RG é obrigatório", AllowEmptyStrings = false)]
        public string RG { get; set; }

        [Required(ErrorMessage = "O CPF do Cliente é obrigatório", AllowEmptyStrings = false)]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O nome do Estado Civil é obrigatório", AllowEmptyStrings = false)]
        public string Estado_Civil { get; set; }
        public string Nome_Parceiro { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? Data_Nascimento_Parceiro { get; set; }
    }
    
}
