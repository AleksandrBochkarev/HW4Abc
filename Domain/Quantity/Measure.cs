﻿using Abc.Data.Quantity;
using Abc.Data.Common;
using Domain.Quantity;

namespace Abc.Domain.Quantity
{
   public class Measure : Entity<MeasureData>

    {
        public Measure(MeasureData data) : base(data)
        {
        }
    }
}