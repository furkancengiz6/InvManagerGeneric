using InvManager.Entities.abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Repository sınıfını generic yapmak ve yalnızca BaseEntity sınıfından türetilmiş türlerle çalışmasını sağlamak. Bu, sadece BaseEntity sınıfından türeyen varlıkların işlenmesini garanti eder.
namespace InvManager.Data
{
    public class Repository<T> where T :BaseEntity
    {
        //Veri tutmak için List<T> kullanacağız. Buradaki T dinamik bir tür olduğu için, herhangi bir BaseEntity sınıfından türemiş tür (örneğin Product) ile çalışabiliriz.
        private readonly List<T>_entities;


        public Repository() 
        {

            _entities = new List<T>();
        
        }

        public void Add(T entity) 
        {
            
            _entities.Add(entity);
        
        }

        public T GetById(int id) 
        {
            return _entities.FirstOrDefault(x => x.Id == id);
                  
        }

        public void Remove(int id) 
        { 
            var entityToRemove = _entities.FirstOrDefault(x => x.Id == id);

            if (entityToRemove != null)
            {
                _entities.Remove(entityToRemove);

            }
            else
            {
                Console.WriteLine("Id Not Found");
            }


        }

        public void Update(T entity) 
        {
            var entityToUpdate = _entities.FirstOrDefault(X => X.Id == entity.Id);


            if (entityToUpdate != null) {
                entityToUpdate.Name = entity.Name;
                entityToUpdate.Quantity = entity.Quantity;
                
                Console.WriteLine("Updated");
                
            
            }
            else
            {
                Console.WriteLine("NOT FOUND");
            }


        }


        public List<T> GetAll() 
        {
        
            return _entities;
        
        }



    }
}
