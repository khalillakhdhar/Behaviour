using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Behaviour.Strategy.model;
namespace Behaviour.Strategy.controller.strategies
{
    class VerifCoupons
    {
        public void verifCoupon(Client cl, int idCoupons)
        {
            Console.WriteLine("verification du coupon de"+cl.Nom);

        }
    }
}
