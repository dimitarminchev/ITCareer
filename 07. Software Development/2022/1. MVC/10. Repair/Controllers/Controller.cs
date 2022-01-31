namespace _10._Repair.Controllers
{
    using _10._Repair.Model;
    using _10._Repair.View;

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
                    model = new Model(view.N, view.W, view.L, view.M, view.O);
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
