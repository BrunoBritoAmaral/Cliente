using System;

namespace AtuCadastro.Domain.Entities
{
    /// <summary>
    /// Clente
    /// </summary>
    public class Cliente
    {
        /// <summary>
        /// Id
        /// </summary>
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
