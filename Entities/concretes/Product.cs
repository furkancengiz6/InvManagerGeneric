using InvManager.Entities.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvManager.Entities.concretes
{
    public class Product : BaseEntity
    {
        public decimal Price { get; set; }
        public string Category { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public string Description { get; set; }

    }
}
