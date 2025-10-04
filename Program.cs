using OOPAss03.Q1;
using OOPAss03.Q2;
using OOPAss03.Q3;

namespace OOPAss03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part01

            /*
             * Q1: To define a blueprint for a class
             * 
             * Q2: private
             * 
             * Q3: NO
             * 
             * Q4: Yes, interfaces can inherit from multiple interfaces
             * 
             * Q5: implements
             * 
             * Q6: Yes
             * 
             * Q7: No, all members are implicitly public
             * 
             * Q8: To hide the interface members from outside access
             * 
             * Q9: No, interfaces cannot have constructors
             * 
             * Q10: By separating interface names with commas
             * 
             */

            #endregion

            #region Q1
            //Circle circle = new Circle(5);
            //Rectangle rectangle = new Rectangle(6, 7);
            //circle.DisplayShapeInfo();
            //rectangle.DisplayShapeInfo();
            #endregion


            #region Q2

            //IAuthenticationService authenticationService = new BasicAuthenticationService();


            //if(authenticationService.AuthenticateUser("seif","123"))
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("InValid");


            //if (authenticationService.AuthenticateUser("amr","123"))
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("InValid");


            //if(authenticationService.AuthorizeUser("seif","user"))
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("InValid");


            //if (authenticationService.AuthorizeUser("seif", "admin"))
            //    Console.WriteLine("Valid");
            //else
            //    Console.WriteLine("InValid");


            #endregion

            #region Q3

            INotificationService emailService = new EmailNotificationService();
            INotificationService smsService = new SmsNotificationService();
            INotificationService pushService = new PushNotificationService();

            emailService.SendNotification("Ali","study hard");
            smsService.SendNotification("Amr", "Keep going to GYM");
            pushService.SendNotification("Ammar", "stop buying shity things");

            #endregion

        }
    }
}
