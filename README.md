# Products.NetCore
Örnek projemiz bir ASP.NET CORE MVC projesidir.<br> 
# Controllers klasörümüzdeki mevcut dosyamız: Home Controller, Products Controller ve AccountController <br>
## ProductsController sınıfımız ile ASP.NET Core MVC projemizde bir denetleyici sınıfı oluşturduk ve bu sınıf ile "Index", "Add", "Update" ve "Remove" gibi işlemleri tanımladık.
Aşağıda, her bir eylemin ne yaptığını açıklayan bir açıklama bulunmaktadır:<br>
1. Index(): Bu eylem, veritabanındaki ürünleri alır ve bu ürünleri "Index" görünümüne aktarır. Ürünlerin listesini görüntülemek için kullanılır.<br>
2. Remove(int id): Bu eylem, veritabanından belirli bir ürünü siler. İlk olarak, veritabanından ilgili ürünü bulur, sonra bu ürünü siler ve değişiklikleri kaydeder. Son olarak, "Index" eylemine yönlendirilirken bir geçici veri olarak "status" mesajını taşır.
3. Add() [HttpGet]: Bu eylem, yeni bir ürün eklemek için kullanıcının gireceği bir formu içeren "Add" görünümünü döndürür.
4. Add(Product newProduct) [HttpPost]: Bu eylem, kullanıcının gönderdiği yeni ürün bilgilerini alır, bunu veritabanına ekler ve değişiklikleri kaydeder. Son olarak, "Index" eylemine yönlendirilirken bir geçici veri olarak "status" mesajını taşır.
5. Update(int id) [HttpGet]: Bu eylem, güncellenecek bir ürünün bilgilerini içeren bir formu doldurmak için kullanıcıya "Update" görünümünü döndürür.
6. Update(Product updateProduct) [HttpPost]: Bu eylem, kullanıcının gönderdiği güncellenmiş ürün bilgilerini alır, bunları veritabanında günceller ve değişiklikleri kaydeder. Son olarak, "Index" eylemine yönlendirilirken bir geçici veri olarak "status" mesajını taşır.<br>
Bu kodlar, bir ürün veritabanını kullanarak temel CRUD (oluşturma, okuma, güncelleme, silme) işlemlerini gerçekleştirmek için kullanılabilir.<br>
## HomeController sınıfımız ile ASP.NET Core MVC projemizde bir denetleyici sınıfı oluşturduk ve bu sınıf ile , ana sayfa, gizlilik sayfası ve hata yönetimi işlemlerini tanımladık.
Aşağıda, her bir eylemin ne yaptığını açıklayan bir açıklama bulunmaktadır:<br>
1. Index(): Bu eylem, uygulamanın ana sayfasını göstermek için kullanılır. "Index" görünümünü döndürür.
2. Privacy(): Bu eylem, uygulamanın gizlilik sayfasını göstermek için kullanılır. "Privacy" görünümünü döndürür.
3. Error(): Bu eylem, bir hata durumunda çalışır. "Error" görünümünü döndürür ve hata ile ilgili bilgileri içeren bir ErrorViewModel nesnesini görünüme aktarır.
Bu kodlar, temel bir ana sayfa, gizlilik sayfası ve hata yönetimi işlevselliği sağlayan bir HomeController denetleyici sınıfıdır.<br>

## AccountController sınıfımız ile  .NET Core ile oluşturulan bir web uygulamasında kullanıcı girişi işlemlerini gerçekleştiren bir hesap kontrolcüsünü temsil ediyor. İşlevlerini açıklayalım:<br>
Login() metodu:
Bu metot HTTP GET isteğiyle çağrılır ve kullanıcı girişi yapmak için gerekli olan formu içeren bir görünümü döndürür.
return View(); ifadesi, Login.cshtml adlı bir görünümün kullanıcıya gönderilmesini sağlar.<br>
Login(UserModel user) metodu:
Bu metot HTTP POST isteğiyle çağrılır ve kullanıcının giriş bilgilerini alır.<br>
Gelen user parametresi, UserModel sınıfından bir nesnedir ve kullanıcının giriş yaparken girdiği kullanıcı adı ve parolayı içerir.
Ardından girilen kullanıcı adı ve parola kontrol edilir.<br> Eğer kullanıcı adı "admin" ve parola "12345" ise, başarılı bir giriş işlemi olduğu varsayılır ve Products kontrolcüsünün Index metoduyla yönlendirme yapılır.
Eğer kullanıcı adı veya parola hatalı ise, kullanıcıya hata mesajını göstermek üzere ViewBag.ErrorMessage değişkeni ayarlanır ve aynı Login görünümü tekrar döndürülür.
Bu kod örneği, kullanıcıların kullanıcı adı ve parola ile giriş yapmalarını sağlayan basit bir hesap kontrolcüsüdür.<br> Kullanıcılar doğru bilgileri girdiğinde Products kontrolcüsüne yönlendirilirken, yanlış bilgileri girdiklerinde hata mesajıyla birlikte aynı giriş sayfası tekrar gösterilir. Bu örnekte, kullanıcı bilgileri doğrulama için basit bir şart kontrolü kullanılmıştır, ancak gerçek bir uygulamada genellikle daha karmaşık ve güvenli bir kimlik doğrulama yöntemi kullanılması tavsiye edilir.

# Models klasörümüzdeki  mevcut dosyalarımız: AppDbContext.cs; Product.cs; ProductRepository.cs; ErrorViewModels.cs; UserModel.cs<br>
## AppDbContext.cs dosyasındaki kodlar , Entity Framework Core kullanarak veritabanı işlemleri için bir DbContext sınıfı olan "AppDbContext" sınıfını tanımlar.
Bu sınıfta yapılan işlemleri açıklayan bir açıklama:<br>
1. AppDbContext(): Bu birincil kurucu metot, varsayılan olarak boş bir AppDbContext nesnesi oluşturur. Bu kullanımda, DbContext sınıfının varsayılan kurucusunu çağırır.
2. AppDbContext(DbContextOptions<AppDbContext> options): Bu ikincil kurucu metot, DbContextOptions nesnesini alır ve DbContext sınıfının kurucusunu çağırır. Bu kullanımda, DbContextOptions nesnesi, veritabanı bağlantısı ve diğer yapılandırma seçeneklerini içerir.
3. DbSet<Product> Products: Bu özellik, "Product" sınıfının veritabanındaki karşılığını temsil eder. DbSet, veritabanı işlemleri yapabilmek için Entity Framework Core tarafından sağlanan bir koleksiyonu temsil eder. Bu özellik, veritabanındaki "Products" tablosuna erişmek için kullanılabilir.
Bu kodlar, Entity Framework Core'un DbContext sınıfından türetilen bir AppDbContext sınıfı tanımlar ve "Products" adlı bir DbSet özelliği içerir. Bu, veritabanı işlemlerini gerçekleştirmek için kullanılan DbContext sınıfının temel yapılandırmasını sağlar ve "Product" sınıfını temsil eden "Products" tablosuna erişimi mümkün kılar.<br>

### Product.cs dosyasındaki kodlar , "Products.NetCore.Models " namespace'i içinde "Product" adlı bir sınıfı tanımlar.<br>
Aşağıda, Product sınıfının içerisinde yer alan özelliklerin anlamlarını bulabilirsiniz:<br>
1. Id: Ürünün benzersiz bir kimlik numarasını temsil eden bir tamsayı.
2. Name: Ürünün adını temsil eden bir dize (string).
3. Price: Ürünün fiyatını temsil eden bir ondalık (decimal) değer.
4. Stock: Ürünün mevcut stok miktarını temsil eden bir tamsayı.
5. Description: Ürünün açıklamasını temsil eden bir dize (string).
6. IsStock: Ürünün stokta olup olmadığını temsil eden bir boolean değeri. True ise stokta, false ise stokta olmadığı anlamına gelir.
Bu Product sınıfı, bir ürünün özelliklerini temsil etmek için kullanılır. Bu özellikler, bir ürünün veritabanında saklanabilecek bilgilerini içerir. Örneğimizdeki gibi, bir e-ticaret sitesindeki ürünlerin veritabanında saklanması için kullanılabilir.
### ProductRepository.cs dosyasındaki kodlar ; Products.NetCore.Models namespace'i içinde ProductRepository adında bir sınıfı temsil ediyor. Bu sınıf, ürünlerin ekleme, güncelleme, silme ve listeleme gibi işlemlerini gerçekleştiren bir ürün veritabanı işlem sınıfını içeriyor. İşlevlerini açıklayalım:
AppDbContext:_context adlı bir AppDbContext nesnesi, veritabanı bağlantısını temsil eder.<br>
Bu bağlantı, ProductRepository sınıfının constructor (yapıcı) metodu içinde oluşturulur.<br>
Remove(int id) metodu: Verilen bir ürün ID'siyle bir ürünü veritabanından kaldırır.<br>
_context.Products.Find(id) ifadesi, veritabanında verilen ID'ye sahip ürünü bulmayı sağlar.<br>
Eğer ürün bulunursa, _context.Products.Remove(product) ifadesiyle ürün veritabanından kaldırılır.<br>
Son olarak, _context.SaveChanges() ifadesiyle yapılan değişiklikler veritabanına kaydedilir.<br>
_products:
_products adlı bir List<Product> nesnesi, ürünleri bellekte tutmak için kullanılır.<br>
GetAll() metodu:
_products listesindeki tüm ürünleri döndürür.<br>
Add(Product newProduct) metodu:
Verilen bir Product nesnesini _products listesine ekler.<br>
Update(Product updateProduct) metodu:
Verilen bir Product nesnesiyle _products listesindeki ilgili ürünü günceller.<br>
İlk olarak, güncellenecek ürünü _products listesinde arar.
Eğer ürün bulunmazsa, bir istisna (Exception) fırlatır.<br>
Eğer ürün bulunursa, ilgili ürünün adını, fiyatını ve stok miktarını günceller.
Son olarak, _products listesindeki güncellenen ürünü günceller.<br>
Bu ProductRepository sınıfı, _products listesini kullanarak bellekte ürünleri yönetir ve _context nesnesi üzerinden veritabanı işlemlerini gerçekleştirir. 
## Views klasörlerimiz ile  ise kullanıcı görünümlerini ayarlıyoruz. Account, Home ve Products klasörlerimiz var. 
Account klasörümüzde Login.cshtml;Home klasörümüzde Index.cshtml; Privacy.cshtml: Products klasörümüzde Add.cshtml; Update.cshtml; Index.cshtml dosyalarımız mevcut.
### Account- Login.cshtml ile bir kullanıcı giriş formunu temsil eden bir Razor görünümünü göstermektedir. Bu görünüm, kullanıcının kullanıcı adı ve parola bilgilerini girmesine ve giriş yapmasına olanak tanır. İşlevlerini açıklayalım:
@model UserModel:
Bu satır, Razor görünümüne UserModel sınıfının kullanılacağını belirtir. UserModel, kullanıcının giriş yaparken kullanacağı kullanıcı adı ve parola bilgilerini içeren bir modeldir.<br>
@if (!string.IsNullOrEmpty(ViewBag.ErrorMessage)):
Bu ifade, ViewBag.ErrorMessage değişkeninin boş olup olmadığını kontrol eder.<br>
Eğer ViewBag.ErrorMessage boş değilse, hata mesajını içeren bir alert-danger sınıfına sahip bir div öğesi görüntülenir.
form asp-action="Login" method="post":<br>
Bu form öğesi, kullanıcı girişi için bir HTML formunu temsil eder.<br>
asp-action özelliği, formun gönderileceği eylemi belirtir. Bu durumda, form Login eylemine gönderilir.<br>
method="post" ifadesi, formun POST yöntemiyle gönderileceğini belirtir.<br>
input öğeleri:
İki adet input öğesi, kullanıcı adı ve parola bilgilerini girmek için kullanılır.<br>
placeholder özelliği, öneri metnini belirtir. Örneğin, kullanıcı adı için admin ve parola için 12345 önerileri vardır.<br>
type="text" ve type="password" ifadeleri, sırasıyla kullanıcı adı ve parola alanları için metin girişi ve şifre girişi olarak belirtilir.<br>
id ve name özellikleri, alanların kimliklerini ve isimlerini belirtir.<br>
class="form-control" özelliği, görünümü Bootstrap form düzenine uygun hale getirir.<br>
required özelliği, alanların boş bırakılamayacağını belirtir.<br>
<button type="submit" class="btn btn-primary">Giriş</button>:
Bu düğme, formun gönderilmesini sağlar. type="submit" ifadesi, düğmenin formun gönderme işlemini tetikleyeceğini belirtir.
class="btn btn-primary" özelliği, düğmeyi Bootstrap stilinde birincil bir düğme olarak görüntüler.<br>
Bu görünüm, kullanıcıların kullanıcı adı ve parola bilgilerini girmeleri için bir giriş formu sunar. Form gönderildiğinde, giriş işlemi Login eylemine yönlendirilir ve gerekli doğrulama işlemleri gerçekleştirilir. Eğer giriş başarılı ise, kullanıcı Products kontrolcüsünün Index eylemine yönlendirilir. Eğer giriş başarısız ise, hata mesajı görüntülenerek aynı giriş formu tekrar gösterilir.
Home- Index.cshtml ile ana sayfa (`Home Page`) için bir Razor görünümünü temsil etmektedir. Bu görünüm, hoş geldiniz mesajı, resimler ve bir keşfetme bağlantısı gibi içeriği içerir. İşlevlerini açıklayalım:

Bu görünüm, ana sayfa içeriğini temsil eder. Hoş geldiniz mesajı, resimler ve keşfetme bağlantısı aracılığıyla kullanıcıları siteyi keşfetmeye teşvik eder. Resimlerin yolu, `Images` klasörü içinde bulunan dosyaların göreceli yollarıyla belirtilir. Keşfetme bağlantısı, `Products` kontrolcüsündeki `Urunler` eylemine yönlendirilir.<br>
Home- Privacy.cshml ile  "Gizlilik Politikası" sayfası için bir Razor görünümünü temsil etmektedir. Bu görünüm, kullanıcılara şirketin gizlilik politikasını açıklamak için bir metin içeriği sunar. İşlevlerini açıklayalım:<br>
<br>
Bu görünüm, gizlilik politikasını açıklayan bir sayfayı temsil eder. İlgili başlıklar altında, kullanıcıların kişisel bilgilerin nasıl toplandığı, kullanıldığı, paylaşıldığı ve güvende tutulduğu gibi konular açıklanır. Ayrıca çerezler, diğer web sitelerine bağlantılar ve iletişim bilgileri gibi diğer önemli bilgiler de sunulur.<br>
Products- Add.cshtml ile  bir ürünün eklenmesi için bir Razor görünümünü temsil etmektedir. Bu görünüm, kullanıcının ürün bilgilerini girmesine ve bir form aracılığıyla sunucuya göndermesine olanak tanır. İşlevlerini açıklayalım:
<br>
Bu görünüm, kullanıcının ürün bilgilerini girmesi için bir form sağlar. Kullanıcı, ürün adı, fiyatı, stok miktarı, açıklama ve stok durumu gibi bilgileri girebilir. Form gönderildiğinde, belirtilen eyleme yönlendirilir ve sunucu tarafında ilgili işlemler gerçekleştirilir.<br>
Products - Index.cshtml ile  bir ürün listesini gösteren bir Razor görünümünü temsil etmektedir. Bu görünüm, mevcut ürünleri listeleyen bir tablo oluşturur. İşlevlerini açıklayalım:
<br>
Bu görünüm, `List<Product>` modeline sahip bir ürün listesini temsil eder. Her bir ürün için bir tablo satırı oluşturulur ve her satırda ürünün özellikleri görüntülenir. Kullanıcı, "Ürün Ekle" düğmesini kullanarak yeni bir ürün ekleyebilir veya her ürün için "Sil" veya "Güncelle" düğmelerini kullanarak ilgili işlemleri gerçekleştirebilir.<br>
Products - Update.cshtml ile  bir ürünü güncellemek için kullanılan bir Razor görünümünü temsil etmektedir. Bu görünüm, mevcut bir ürünün bilgilerini düzenlemek için bir form sağlar.<br>
<br>
Bu görünüm, `Product` modeline sahip bir ürünün güncellenmesini sağlar. Formdaki giriş alanları, mevcut ürünün bilgilerini görüntüler ve kullanıcıya bu bilgileri düzenleme imkanı sunar. Kullanıcı, "Ürün Güncelle" düğmesini tıklayarak formu gönderebilir ve ürünün güncellenmesi gerçekleşir.<br>
Products - Urunler.cshtml ile "Urunler" olarak adlandırılan bir Razor görünümünü temsil etmektedir. Bu görünüm, ürünleri listeleyen bir tablo içerir.<br>
<br>
Bu görünüm, bir ürün listesini tablo şeklinde görüntüler. Her bir ürün için, ilgili özellikler tablo hücrelerinde yer alır. Ayrıca, her ürün için "Sepete Ekle" ve "Sepetten Çıkar" düğmeleri mevcuttur. Bu düğmelere tıklandığında, ilgili işlemler gerçekleştirilir.<br>
Veritabanı bağlantılarımızı migration dosyalarıyla code first yaklaşımıyla yaptık. Migration dosyaları Entity Framework Core Migration işlemleri için bir Migration sınıfını temsil etmektedir. Bu Migration, bir `Products` tablosunun veritabanında oluşturulmasını ve tanımlanan sütunların eklenmesini sağlar.<br>
1. `Up` metodu:<br>
    Bu metot, veritabanı şemasını güncellemek için yukarıya doğru bir Migration işlemi gerçekleştirir.<br>
    `CreateTable` metodu ile `Products` tablosu oluşturulur.<br>
    Tablo sütunları ve özellikleri (`Id`, `Name`, `Price`, vb.) tanımlanır.<br>
    `PrimaryKey` metodu ile `Id` sütunu belirtilerek birincil anahtar tanımlanır.<br>
2. `Down` metodu:<br>
    Bu metot, yukarıda yapılan değişiklikleri geri almak için aşağıya doğru bir Migration işlemi gerçekleştirir.<br>
    `DropTable` metodu ile `Products` tablosu silinir.<br>
Bu Migration sınıfı, Entity Framework Core Code First yaklaşımı kullanılarak veritabanında bir `Products` tablosunun oluşturulmasını ve yönetilmesini sağlar. Bu tablo, `Id`, `Name`, `Price`, `Stock`, `Description` ve `IsStock` sütunlarını içerir. 
_Layout.cshtml dosyası bir Razor view dosyasını temsil eder. Bu view, bir HTML belgesi oluşturur ve bir web sitesinin ana sayfasını göstermek için kullanılır. İşlevlerini açıklayalım:

Bu Razor view dosyası, statik HTML içeriği yanı sıra dinamik öğeleri de içerir. Bu sayede bir web sitesinin üstbilgisi, navigasyon çubuğu, ana içerik alanı ve altbilgisi gibi bölümleri oluşturulmuş olur. Ayrıca, CSS ve JavaScript bağlantıları da eklenerek stil ve işlevsellik sağlanmıştır.
