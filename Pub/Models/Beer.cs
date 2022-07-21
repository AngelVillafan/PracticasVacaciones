using System;
using System.Collections.Generic;

namespace Pub.Models
{
    public partial class Beer
    {
        public int IdBeer { get; set; }
        public string Name { get; set; } = null!;
        public int? BrandId { get; set; }

        public virtual Brand? Brand { get; set; }
    }
}
