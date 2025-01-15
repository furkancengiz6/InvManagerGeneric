# InvManagerGeneric

**InvManagerGeneric** projesi, **generic yapıları** öğrenmek ve pratik yapmak amacıyla geliştirilmiştir. Bu proje, envanter yönetim sistemini temel alarak, generic sınıfların ve metodların kullanımını örneklemektedir. Projede, verilerin yönetilmesi için `Repository` ve `InventoryService` gibi generic yapılar kullanılmıştır.

## Amacım

Bu proje, **generic yapıları** daha iyi anlayabilmek ve uygulamalı olarak kullanabilmek için geliştirilmiştir. Generic sınıfların ve metodların nasıl çalıştığını anlamak için çeşitli özellikler eklenmiş ve güncellenmiştir.

## Özellikler

- **Generic Repository:** Veri eklemek, silmek, güncellemek ve listelemek için generic `Repository` sınıfı kullanılmıştır.
- **Generic Service:** Envanter yönetimi için generic `InventoryService` sınıfı oluşturulmuştur.
- **BaseEntity:** Tüm varlıkların türeyeceği temel sınıf olarak `BaseEntity` kullanılmıştır.
- **Product Örneği:** Ürünler üzerinde işlem yapmak için `Product` sınıfı örnek olarak kullanılmıştır.

## Teknolojiler

- C#
- Generic Yapılar (Classes ve Methods)
- LINQ

## Kullanım

1. **Projenin Çalıştırılması:**

   Projeyi bilgisayarınıza indirip Visual Studio veya başka bir IDE üzerinden açabilirsiniz.

2. **Yeni Bir Ürün Ekleme:**
   
   Aşağıdaki gibi bir ürün ekleyebilirsiniz:

   ```csharp
   var product = new Product
   {
       Id = 1,
       Name = "Product A",
       Quantity = 100,
       Price = 20.5m,
       CreatedDate = DateTime.Now
   };

   inventoryService.Add(product);

2. **Ürünleri Listeleme:**

   Tüm ürünleri listelemek için:

   ```csharp
   var allProducts = productRepository.GetAll();

   product.Name = "Updated Product A";
   inventoryService.Update(product);
   inventoryService.Remove(product.Id);
