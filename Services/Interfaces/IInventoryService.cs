using InvManager.Entities.concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvManager.Services.Interfaces
{
    public interface IInventoryService
    {

        void Add(Product product);

        void Remove(int  productId);

        void Update(Product product);




    }
}
