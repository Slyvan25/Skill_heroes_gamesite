using System;
using System.Collections.Generic;

namespace Spellenwinkel.Models
{
    public partial class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Type { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int Duration { get; set; }
        public string Image {get; set;}

        public virtual Types IdNavigation { get; set; }
    }
}
