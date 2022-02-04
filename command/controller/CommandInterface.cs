using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behaviour.command.model;
namespace Behaviour.command.model
{
    interface CommandInterface
    {
       void transform(CommandeLine commande);
        void addProduct(Panier p);
    }
}
