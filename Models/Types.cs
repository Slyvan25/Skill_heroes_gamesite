using System;
using System.Collections.Generic;

namespace Spellenwinkel.Models
{
    public partial class Types
    {
        public int Id { get; set; }
        public string Typename { get; set; }

        public virtual Games Games { get; set; }
    }
}
