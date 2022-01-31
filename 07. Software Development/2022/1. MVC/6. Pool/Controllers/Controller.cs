namespace _6._Pool.Controllers
{
    using _6._Pool.View;
    using _6._Pool.Model;

    internal class Controller
    {
        private View view;
        private Model model;

        public Controller()
        {
            view = new View();
            while (model is null)
            {
                try
                {
                    view.Input();
                    model = new Model(view.V, view.P1, view.P2, view.H);
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
