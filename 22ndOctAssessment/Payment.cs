using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _22ndOctAssessment
{

    //3. Create a class Payment having a static method payBill If you pay the bill by cash you are not eligible for any discount, method payBill(double amt)
    //If you pay by a mode you get 15% discount on the bill, method  payBill(double amt, String mode)

    public class Payment
    {

        public static void PayBill(double amt)
        {
            Console.WriteLine($"Payment of {amt} is done by cash");
        }

        public static void payBill(double amt,string mode)
        {
            double discount = amt * 0.15;
            amt = amt - discount;
            Console.WriteLine($"payment by {mode} discount = {discount} amount={amt}");
        }


        

    }
}
