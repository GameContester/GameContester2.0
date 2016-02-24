using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameContester.Domain.Entities
{
    public interface IEntity<TKEy>
    {
        TKEy Id { get; set; }
    }
}
