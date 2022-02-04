using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behaviour.Observer.model;

namespace Behaviour.Observer.repository
{
    interface MessageController
    {
        void sendMessage(Message message);
        void notifierUsers(Message message);
    }
}
