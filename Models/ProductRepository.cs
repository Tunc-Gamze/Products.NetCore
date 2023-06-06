namespace Products.NetCore.Models
{
    public class ProductRepository
    {
        private AppDbContext _context; // Veritabanı bağlantısı

        public ProductRepository()
        {
            _context = new AppDbContext(); // Veritabanı bağlantısını oluşturun
        }


        public void Remove(int id)
        {
            var product = _context.Products.Find(id); // Silinecek ürünü bulun

            if (product != null)
            {
                _context.Products.Remove(product); // Ürünü veritabanından kaldırın
                _context.SaveChanges(); // Değişiklikleri kaydedin
            }
        }

        private static List<Product> _products = new List<Product>()
        {
            //    //new () { Id = 1, Name = "Kalem1", Price = 100, Stock = 200 },
            //    //new () { Id = 2, Name = "Kalem2", Price = 100, Stock = 200 },
            //    //new () { Id = 3, Name = "Kalem3", Price = 100, Stock = 200 }

        };


        public List<Product> GetAll() => _products;

        public void Add(Product newProduct) => _products.Add(newProduct);

        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateProduct.Id);

            if (hasProduct == null)
            {
                throw new Exception($"Bu id ({updateProduct.Id}) ait ürün bulunmamaktadır.");
            }
            hasProduct.Name = updateProduct.Name;
            hasProduct.Price = updateProduct.Price;
            hasProduct.Stock = updateProduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateProduct.Id);

            _products[index] = hasProduct;

        }

    }
}


