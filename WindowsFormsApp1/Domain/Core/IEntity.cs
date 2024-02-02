using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Domain.Core
{
    public interface IEntity<key> 
        where key : struct
    {
        key Id { get; set; }

    }
}
