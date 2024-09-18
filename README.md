# Products.NetCore

**Products.NetCore** projesi, bir **ASP.NET Core MVC** uygulamasıdır. Bu proje, temel ürün yönetimi, kullanıcı girişi ve ana sayfa işlemlerini gerçekleştirmek üzere geliştirilmiştir. 

## Proje Yapısı

### 1. **Controllers Klasörü**
- **HomeController**: Ana sayfa, gizlilik sayfası ve hata yönetimi işlemlerini yönetir.
  - `Index()`: Ana sayfayı gösterir.
  - `Privacy()`: Gizlilik sayfasını gösterir.
  - `Error()`: Hata yönetimini sağlar.
  
- **ProductsController**: Ürün yönetimi ile ilgili işlemleri gerçekleştirir.
  - `Index()`: Ürün listesini görüntüler.
  - `Add()`: Yeni ürün ekler.
  - `Update()`: Mevcut bir ürünü günceller.
  - `Remove()`: Ürünü siler.
  
- **AccountController**: Kullanıcı girişi işlemlerini yönetir.
  - `Login()`: Kullanıcı girişi işlemini gerçekleştirir.
  - `Password()`: Parola işlemleri ve şifre yenileme fonksiyonlarını içerir.

### 2. **Models Klasörü**
- **AppDbContext.cs**: Veritabanı işlemleri için kullanılan bir **DbContext** sınıfını içerir. Entity Framework Core kullanarak veritabanı bağlantısını yönetir.
  
- **Product.cs**: Ürünlere ait verileri temsil eden bir modeldir. Şu özellikleri içerir:
  - **Id**: Ürünün benzersiz kimlik numarası.
  - **Name**: Ürünün adı.
  - **Price**: Ürünün fiyatı.
  - **Stock**: Ürünün stok miktarı.
  - **Description**: Ürün açıklaması.
  - **IsStock**: Ürünün stok durumunu belirten boolean değer.

- **ProductRepository.cs**: Ürünlerin veritabanında eklenmesi, güncellenmesi, silinmesi ve listelenmesi işlemlerini sağlayan bir sınıftır.

- **ErrorViewModel.cs**: Hata yönetimi için kullanılan model.

- **UserModel.cs**: Kullanıcı bilgilerini içeren model.

### 3. **Views Klasörü**
Bu klasörde, kullanıcıya sunulan görünümler yer alır:
- **Account**
  - `Login.cshtml`: Kullanıcı giriş formunu içeren sayfa.
  
- **Home**
  - `Index.cshtml`: Ana sayfa görünümü.
  - `Privacy.cshtml`: Gizlilik politikası sayfası.

- **Products**
  - `Index.cshtml`: Ürünlerin listelendiği sayfa.
  - `Add.cshtml`: Yeni ürün ekleme formu.
  - `Update.cshtml`: Ürün güncelleme formu.

## Kurulum

Projeyi çalıştırmak için şu adımları izleyin:
1. Projeyi bilgisayarınıza klonlayın:  
   ```bash
   git clone https://github.com/username/Products.NetCore.git
   ```

2. Gerekli bağımlılıkları yükleyin:  
   ```bash
   dotnet restore
   ```

3. Veritabanı bağlantısını yapılandırın. `AppDbContext.cs` dosyasında veritabanı bağlantı dizesini ayarlayın.

4. Projeyi çalıştırın:  
   ```bash
   dotnet run
   ```

5. Tarayıcınızda projeyi görüntüleyin:  
   ```
   http://localhost:5000
   ```

## Teknolojiler
- ASP.NET Core MVC
- Entity Framework Core
- MsSQL
- Razor Pages
- Bootstrap (Kullanıcı arayüzleri için)

## Gelecekteki Çalışmalar
- Ürün yönetimi süreçlerine kategori eklenmesi.
- Kullanıcı yetkilendirme ve rollerin tanımlanması.
- Yapay zeka ile ürün stok ve satış tahminlerinin yapılması.

## Katkıda Bulunma
Projeye katkıda bulunmak için lütfen bir **pull request** gönderin veya bir **issue** açın.
