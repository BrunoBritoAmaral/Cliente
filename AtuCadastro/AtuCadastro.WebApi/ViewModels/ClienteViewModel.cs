using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AtuCadastro.WebApi.ViewModels
{
    /// <summary>
    /// Cliente View Model
    /// </summary>
    public class ClienteViewModel
    {
        /// <summary>
        /// Id
        /// </summary>
        [Key]
        public int ClienteId { get; set; }
        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Número do telefone residencial
        /// </summary>
        public string NroTelefoneResidencial { get; set; }

        /// <summary>
        /// Endereço
        /// </summary>
        public string Endereco { get; set; }

        /// <summary>
        /// Data Nascimento
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Número telefone celular
        /// </summary>
        public string NroTelefoneCelular { get; set; }
    }
}