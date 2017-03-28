using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cats
{
    public interface IFeedable
    {
        int Age { get; set; }

        void Eat();
    }
}
