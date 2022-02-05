using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behaviour.Observer.repository;
using Behaviour.Observer.model;
namespace Behaviour.Observer.controller
{
    class MessageController : MessageInterface
    {
        public void notifierUsers(Message message)
        {
            List<User> users = message.usersGroupe.users;
            foreach (var us in users)
            {
                Console.WriteLine("notification envoyé à " + us.UserName);
            }


        }

        public void sendMessage(Message message)
        {
            Console.WriteLine("message envoyé");
            this.notifierUsers(message);
        }
    }
}
