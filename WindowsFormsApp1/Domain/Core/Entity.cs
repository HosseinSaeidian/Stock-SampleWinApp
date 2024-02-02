using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Domain.Core;

namespace WindowsFormsApp1.Domain.Core
{
    public class Entity<Key> : IEntity<Key>
        where Key : struct
    {
        public Key Id { get; set; }
    }
}
