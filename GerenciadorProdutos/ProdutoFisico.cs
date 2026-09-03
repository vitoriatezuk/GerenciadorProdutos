using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdutos
{
    internal class ProdutoFisico : Produto
    {
        public double Pesokg { get; set; }

        //Sobrecarga de construtores chamando o constutor base 
        public ProdutoFisico(string nome, decimal precoBase, double pesoKg) : base(nome, precoBase)
        {
            Pesokg = pesoKg;
        }
        //Polimorfismo: sobrescrevendo o mètodo abstrato da classe base 
        // físico possuiu um acrescimo baseado no preço
        public override decimal CalcularPrecoFinal()
        {
            decimal frete = (decimal)(Pesokg * 2.50);
            return PrecoBase + frete;
        }
    }
}
