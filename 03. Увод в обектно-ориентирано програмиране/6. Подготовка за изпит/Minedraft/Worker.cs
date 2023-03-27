namespace Minedraft
{
    public abstract class Worker
    {
        protected Worker(string id)
        {
            this.Id = id;
        }

        public string Id { get; }
    }

}
