using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Fake_Identity_Generator
{
    public class Persona
    {
        public string? NombreCompleto { get; set; }
        public string? DNI { get; set; }
        public string? Numero { get; set; }
        public string? Genero { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string? Pais { get; set; }
        public double? Peso { get; set; }
        public double? Altura { get; set; }
        public Color ColorFavorito { get; set; }
        public List<CreditCard>? CreditCardInfo { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? EMail { get; set; }
        public string? UUID { get; set; }
        public string? SitioWeb { get; set; }
        public string? Navegador { get; set; }
        public string? BitcoinAddress { get; set; }
        public string? MoneroAddress { get; set; }
        public string? EthereumAddress { get; set; }
        public string? RippleAddress { get; set; }
    }

    public class CreditCard
    {
        public string? CreditCardNum { get; set; }
        public string? CCV { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
