namespace _4._PasswordGenerator.Controllers
{
    using _4._PasswordGenerator.View;
    using _4._PasswordGenerator.Model;

    internal class Controller
    {
        private Model model;
        private View view;

        public Controller()
        {
            view = new View();
            while (model is null)
            {
                try
                {
                    view.Input();
                    model = new Model(view.n, view.l);
                }
                catch (Exception e)
                {
                    view.Response = e.Message;
                    view.ShowResponse();
                }
            }
            view.Response = model.Calculate();
            view.ShowResponse();
        }
    }
}
