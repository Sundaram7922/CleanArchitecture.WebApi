using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities
{
    public class Blog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Author { get; set; }

        public string ImageUrl { get; set; }
    }
}
