using System;
namespace cell
{
    public abstract class Cell<T> where T : Hormone
    {
        public abstract Action<T> GetHormonalResponse();

        protected void Emit(Hormone hormone)
        {
            EndocrineSystem.Inject(hormone);
        }
    }
}
