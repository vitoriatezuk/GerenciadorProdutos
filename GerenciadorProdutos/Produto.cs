using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdutos
{
    public abstract class Produto
    { 
        //Encapsulamento através de propriedades automàticas 
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal PrecoBase { get; set; }

        //Construtor da classe base 

        protected Produto(string nome, decimal precoBase)
        {
            Nome = nome;
            PrecoBase = precoBase;
        }

        // Método abstrato que força a subclasse a implementar o polimorfismo
        public abstract decimal CalcularPrecoFinal();
    }
}
