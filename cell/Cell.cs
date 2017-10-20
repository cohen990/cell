using System;
namespace cell
{
    public class Cell
    {
        protected void Bind<Hormone>(Action<Hormone> response) where Hormone: cell.Hormone
        {
        }

        protected void Emit(Hormone hormone)
        {
        }
    }
}
