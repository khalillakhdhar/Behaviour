using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behaviour.Strategy.model;
namespace Behaviour.Strategy.repository
{
    interface ClientInterface
    {
        void CreateClient(Client client);
        void ReadClient();
        void DeleteClient(int id);

    }
}
