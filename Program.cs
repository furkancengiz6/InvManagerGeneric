

using InvManager.Data;
using InvManager.Entities.concretes;
using InvManager.Services.Concrete;

var productRepository = new Repository<Product>();

var invertoryService = new InventoryService(productRepository);

Product product = new Product();
product.Id = 1;
product.Name = "A";
product.Description = "B";
product.Category = "C";
product.Price = 20.5m;
product.CreatedDate = DateTime.Now;

invertoryService.Add(product);
var allProducts = productRepository.GetAll();
Console.WriteLine("Tum Urunler: ");
foreach (var p in allProducts)
{
    Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Quantity: {p.Quantity}, Price: {p.Price}");
}

product.Name = "Güncelle Urun  A";
invertoryService.Update(product);

Console.WriteLine($"Güncellenen Urun : {product.Name}");


invertoryService.Remove(product.Id);

Console.WriteLine($"Silinen Urun Id si : {product.Id}");




