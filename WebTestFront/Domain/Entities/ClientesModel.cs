using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("tb_Clientes")]
    public class ClientesModel
    {
        public ClientesModel()
        {

        }

        [Key]
        public int ClienteID { get; set; }

        [StringLength(80)]
        public string Nome { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime Data_Nascimento { get; set; }

        [StringLength(20)]
        public string RG { get; set; }

        [StringLength(25)]
        public string CPF { get; set; }

        [StringLength(20)]
        public string Estado_Civil { get; set; }

        [StringLength(80)]
        public string Nome_Parceiro { get; set; }

        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        public DateTime? Data_Nascimento_Parceiro { get; set; }



    }

}
