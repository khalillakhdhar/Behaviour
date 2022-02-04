using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour.Observer.model
{
    class Message
    {
        public string Texte { get; set; }
        public string Date { get; set; }
        public UserGroupe usersGroupe { get; set; }
    }
}
