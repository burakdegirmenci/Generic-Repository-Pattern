﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Domain.Entities
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}