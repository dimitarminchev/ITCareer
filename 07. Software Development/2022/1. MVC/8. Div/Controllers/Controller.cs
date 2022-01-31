namespace _8._Div.Controllers
{
    using _8._Div.Model;
    using _8._Div.View;

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
                    model = new Model(view.numbers);
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
