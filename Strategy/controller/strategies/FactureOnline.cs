using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behaviour.Strategy.model;
namespace Behaviour.Strategy.controller.strategies
{
    class FactureOnline:Facture
    {
        void genererFacture(Client cl, Bonus b, List<Produit> produits, string source)
        {
            Console.WriteLine("generation de la facture");


        }
    }
}
