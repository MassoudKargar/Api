using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;

namespace Api.Domain.Models.Tags
{
    public class Tag
    {
        public Tag(int id, string name)
        {
            Id = id; 
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public int Id { get; private set; }
        public string Name { get; private set; }

    }
    
}
