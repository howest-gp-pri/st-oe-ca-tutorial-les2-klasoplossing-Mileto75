﻿namespace Pri.Ca.Core.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}