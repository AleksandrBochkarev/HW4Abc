using Abc.Data.Quantity;
using Abc.Data.Common;

namespace Abc.Domain.Quantity
{
   public class Measure : Entity<MeasureData>

    {
        public Measure(MeasureData data) : base(data)
        {
        }
    }

   public abstract class Entity<T> where T : PeriodData
   {
        public T Data { get; }

        protected Entity(T data)
        {
            Data = data;
        }
   }
}
