using System;
using Task04.Model;
using Task04.Views;

namespace Task04.Controllers
{
    public class PasswordController
    {
        private Display display;
        private Password password;

        public PasswordController()
        {
            display = new Display();
            while (password is null)
            {
                try
                {
                    display.Input();
                    password = new Password(display.n, display.l);
                }
                catch (Exception e) 
                { 
                    display.Response = e.Message; 
                    display.ShowResponse(); 
                }
            }
            display.Response = password.Calculate();
            display.ShowResponse();
        }
    }
}
