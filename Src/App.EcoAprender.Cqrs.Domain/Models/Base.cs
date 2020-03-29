namespace App.EcoAprender.Cqrs.Domain.Models
{
    public abstract class Base
    {
        public int Id { get; private set; }

        protected void PreencherId(int id)
        {
            Id = id;
        }
    }
}
