# Products.NetCore
Örnek projemiz bir ASP.NET CORE MVC projesidir. 
##Controllers klasörümüzdeki mevcut dosyamız: Home Controller, Products Controller ve AccountController
#ProductsController sınıfımız ile ASP.NET Core MVC projemizde bir denetleyici sınıfı oluşturduk ve bu sınıf ile "Index", "Add", "Update" ve "Remove" gibi işlemleri tanımladık.
Aşağıda, her bir eylemin ne yaptığını açıklayan bir açıklama bulunmaktadır:
1. Index(): Bu eylem, veritabanındaki ürünleri alır ve bu ürünleri "Index" görünümüne aktarır. Ürünlerin listesini görüntülemek için kullanılır.
2. Remove(int id): Bu eylem, veritabanından belirli bir ürünü siler. İlk olarak, veritabanından ilgili ürünü bulur, sonra bu ürünü siler ve değişiklikleri kaydeder. Son olarak, "Index" eylemine yönlendirilirken bir geçici veri olarak "status" mesajını taşır.
3. Add() [HttpGet]: Bu eylem, yeni bir ürün eklemek için kullanıcının gireceği bir formu içeren "Add" görünümünü döndürür.
4. Add(Product newProduct) [HttpPost]: Bu eylem, kullanıcının gönderdiği yeni ürün bilgilerini alır, bunu veritabanına ekler ve değişiklikleri kaydeder. Son olarak, "Index" eylemine yönlendirilirken bir geçici veri olarak "status" mesajını taşır.
5. Update(int id) [HttpGet]: Bu eylem, güncellenecek bir ürünün bilgilerini içeren bir formu doldurmak için kullanıcıya "Update" görünümünü döndürür.
6. Update(Product updateProduct) [HttpPost]: Bu eylem, kullanıcının gönderdiği güncellenmiş ürün bilgilerini alır, bunları veritabanında günceller ve değişiklikleri kaydeder. Son olarak, "Index" eylemine yönlendirilirken bir geçici veri olarak "status" mesajını taşır.
Bu kodlar, bir ürün veritabanını kullanarak temel CRUD (oluşturma, okuma, güncelleme, silme) işlemlerini gerçekleştirmek için kullanılabilir.
#HomeController sınıfımız ile ASP.NET Core MVC projemizde bir denetleyici sınıfı oluşturduk ve bu sınıf ile , ana sayfa, gizlilik sayfası ve hata yönetimi işlemlerini tanımladık.
Aşağıda, her bir eylemin ne yaptığını açıklayan bir açıklama bulunmaktadır:
1. Index(): Bu eylem, uygulamanın ana sayfasını göstermek için kullanılır. "Index" görünümünü döndürür.
2. Privacy(): Bu eylem, uygulamanın gizlilik sayfasını göstermek için kullanılır. "Privacy" görünümünü döndürür.
3. Error(): Bu eylem, bir hata durumunda çalışır. "Error" görünümünü döndürür ve hata ile ilgili bilgileri içeren bir ErrorViewModel nesnesini görünüme aktarır.
Bu kodlar, temel bir ana sayfa, gizlilik sayfası ve hata yönetimi işlevselliği sağlayan bir HomeController denetleyici sınıfıdır.

#AccountController sınıfımız ile  .NET Core ile oluşturulan bir web uygulamasında kullanıcı girişi işlemlerini gerçekleştiren bir hesap kontrolcüsünü temsil ediyor. İşlevlerini açıklayalım:
Login() metodu:
Bu metot HTTP GET isteğiyle çağrılır ve kullanıcı girişi yapmak için gerekli olan formu içeren bir görünümü döndürür.
return View(); ifadesi, Login.cshtml adlı bir görünümün kullanıcıya gönderilmesini sağlar.
Login(UserModel user) metodu:
Bu metot HTTP POST isteğiyle çağrılır ve kullanıcının giriş bilgilerini alır.
Gelen user parametresi, UserModel sınıfından bir nesnedir ve kullanıcının giriş yaparken girdiği kullanıcı adı ve parolayı içerir.
Ardından girilen kullanıcı adı ve parola kontrol edilir. Eğer kullanıcı adı "admin" ve parola "12345" ise, başarılı bir giriş işlemi olduğu varsayılır ve Products kontrolcüsünün Index metoduyla yönlendirme yapılır.
Eğer kullanıcı adı veya parola hatalı ise, kullanıcıya hata mesajını göstermek üzere ViewBag.ErrorMessage değişkeni ayarlanır ve aynı Login görünümü tekrar döndürülür.
Bu kod örneği, kullanıcıların kullanıcı adı ve parola ile giriş yapmalarını sağlayan basit bir hesap kontrolcüsüdür. Kullanıcılar doğru bilgileri girdiğinde Products kontrolcüsüne yönlendirilirken, yanlış bilgileri girdiklerinde hata mesajıyla birlikte aynı giriş sayfası tekrar gösterilir. Bu örnekte, kullanıcı bilgileri doğrulama için basit bir şart kontrolü kullanılmıştır, ancak gerçek bir uygulamada genellikle daha karmaşık ve güvenli bir kimlik doğrulama yöntemi kullanılması tavsiye edilir.

##Models klasörümüzdeki  mevcut dosyalarımız: AppDbContext.cs; Product.cs; ProductRepository.cs; ErrorViewModels.cs; UserModel.cs
#AppDbContext.cs dosyasındaki kodlar , Entity Framework Core kullanarak veritabanı işlemleri için bir DbContext sınıfı olan "AppDbContext" sınıfını tanımlar.
Bu sınıfta yapılan işlemleri açıklayan bir açıklama:
1. AppDbContext(): Bu birincil kurucu metot, varsayılan olarak boş bir AppDbContext nesnesi oluşturur. Bu kullanımda, DbContext sınıfının varsayılan kurucusunu çağırır.
2. AppDbContext(DbContextOptions<AppDbContext> options): Bu ikincil kurucu metot, DbContextOptions nesnesini alır ve DbContext sınıfının kurucusunu çağırır. Bu kullanımda, DbContextOptions nesnesi, veritabanı bağlantısı ve diğer yapılandırma seçeneklerini içerir.
3. DbSet<Product> Products: Bu özellik, "Product" sınıfının veritabanındaki karşılığını temsil eder. DbSet, veritabanı işlemleri yapabilmek için Entity Framework Core tarafından sağlanan bir koleksiyonu temsil eder. Bu özellik, veritabanındaki "Products" tablosuna erişmek için kullanılabilir.
Bu kodlar, Entity Framework Core'un DbContext sınıfından türetilen bir AppDbContext sınıfı tanımlar ve "Products" adlı bir DbSet özelliği içerir. Bu, veritabanı işlemlerini gerçekleştirmek için kullanılan DbContext sınıfının temel yapılandırmasını sağlar ve "Product" sınıfını temsil eden "Products" tablosuna erişimi mümkün kılar.

#Product.cs dosyasındaki kodlar , "Products.NetCore.Models " namespace'i içinde "Product" adlı bir sınıfı tanımlar.
Aşağıda, Product sınıfının içerisinde yer alan özelliklerin anlamlarını bulabilirsiniz:
1. Id: Ürünün benzersiz bir kimlik numarasını temsil eden bir tamsayı.
2. Name: Ürünün adını temsil eden bir dize (string).
3. Price: Ürünün fiyatını temsil eden bir ondalık (decimal) değer.
4. Stock: Ürünün mevcut stok miktarını temsil eden bir tamsayı.
5. Description: Ürünün açıklamasını temsil eden bir dize (string).
6. IsStock: Ürünün stokta olup olmadığını temsil eden bir boolean değeri. True ise stokta, false ise stokta olmadığı anlamına gelir.
Bu Product sınıfı, bir ürünün özelliklerini temsil etmek için kullanılır. Bu özellikler, bir ürünün veritabanında saklanabilecek bilgilerini içerir. Örneğimizdeki gibi, bir e-ticaret sitesindeki ürünlerin veritabanında saklanması için kullanılabilir.
#ProductRepository.cs dosyasındaki kodlar ; Products.NetCore.Models namespace'i içinde ProductRepository adında bir sınıfı temsil ediyor. Bu sınıf, ürünlerin ekleme, güncelleme, silme ve listeleme gibi işlemlerini gerçekleştiren bir ürün veritabanı işlem sınıfını içeriyor. İşlevlerini açıklayalım:
AppDbContext:
_context adlı bir AppDbContext nesnesi, veritabanı bağlantısını temsil eder.
Bu bağlantı, ProductRepository sınıfının constructor (yapıcı) metodu içinde oluşturulur.
Remove(int id) metodu: Verilen bir ürün ID'siyle bir ürünü veritabanından kaldırır.
_context.Products.Find(id) ifadesi, veritabanında verilen ID'ye sahip ürünü bulmayı sağlar.
Eğer ürün bulunursa, _context.Products.Remove(product) ifadesiyle ürün veritabanından kaldırılır.
Son olarak, _context.SaveChanges() ifadesiyle yapılan değişiklikler veritabanına kaydedilir.
_products:
_products adlı bir List<Product> nesnesi, ürünleri bellekte tutmak için kullanılır.
GetAll() metodu:
_products listesindeki tüm ürünleri döndürür.
Add(Product newProduct) metodu:
Verilen bir Product nesnesini _products listesine ekler.
Update(Product updateProduct) metodu:
Verilen bir Product nesnesiyle _products listesindeki ilgili ürünü günceller.
İlk olarak, güncellenecek ürünü _products listesinde arar.
Eğer ürün bulunmazsa, bir istisna (Exception) fırlatır.
Eğer ürün bulunursa, ilgili ürünün adını, fiyatını ve stok miktarını günceller.
Son olarak, _products listesindeki güncellenen ürünü günceller.
Bu ProductRepository sınıfı, _products listesini kullanarak bellekte ürünleri yönetir ve _context nesnesi üzerinden veritabanı işlemlerini gerçekleştirir. 
##Views klasörlerimiz ile  ise kullanıcı görünümlerini ayarlıyoruz. Account, Home ve Products klasörlerimiz var. 
Account klasörümüzde Login.cshtml;Home klasörümüzde Index.cshtml; Privacy.cshtml: Products klasörümüzde Add.cshtml; Update.cshtml; Index.cshtml dosyalarımız mevcut.
#Account- Login.cshtml ile bir kullanıcı giriş formunu temsil eden bir Razor görünümünü göstermektedir. Bu görünüm, kullanıcının kullanıcı adı ve parola bilgilerini girmesine ve giriş yapmasına olanak tanır. İşlevlerini açıklayalım:
@model UserModel:
Bu satır, Razor görünümüne UserModel sınıfının kullanılacağını belirtir. UserModel, kullanıcının giriş yaparken kullanacağı kullanıcı adı ve parola bilgilerini içeren bir modeldir.
@if (!string.IsNullOrEmpty(ViewBag.ErrorMessage)):
Bu ifade, ViewBag.ErrorMessage değişkeninin boş olup olmadığını kontrol eder.
Eğer ViewBag.ErrorMessage boş değilse, hata mesajını içeren bir alert-danger sınıfına sahip bir div öğesi görüntülenir.
<form asp-action="Login" method="post">:
Bu form öğesi, kullanıcı girişi için bir HTML formunu temsil eder.
asp-action özelliği, formun gönderileceği eylemi belirtir. Bu durumda, form Login eylemine gönderilir.
method="post" ifadesi, formun POST yöntemiyle gönderileceğini belirtir.
input öğeleri:
İki adet input öğesi, kullanıcı adı ve parola bilgilerini girmek için kullanılır.
placeholder özelliği, öneri metnini belirtir. Örneğin, kullanıcı adı için admin ve parola için 12345 önerileri vardır.
type="text" ve type="password" ifadeleri, sırasıyla kullanıcı adı ve parola alanları için metin girişi ve şifre girişi olarak belirtilir.
id ve name özellikleri, alanların kimliklerini ve isimlerini belirtir.
class="form-control" özelliği, görünümü Bootstrap form düzenine uygun hale getirir.
required özelliği, alanların boş bırakılamayacağını belirtir.
<button type="submit" class="btn btn-primary">Giriş</button>:
Bu düğme, formun gönderilmesini sağlar. type="submit" ifadesi, düğmenin formun gönderme işlemini tetikleyeceğini belirtir.
class="btn btn-primary" özelliği, düğmeyi Bootstrap stilinde birincil bir düğme olarak görüntüler.
Bu görünüm, kullanıcıların kullanıcı adı ve parola bilgilerini girmeleri için bir giriş formu sunar. Form gönderildiğinde, giriş işlemi Login eylemine yönlendirilir ve gerekli doğrulama işlemleri gerçekleştirilir. Eğer giriş başarılı ise, kullanıcı Products kontrolcüsünün Index eylemine yönlendirilir. Eğer giriş başarısız ise, hata mesajı görüntülenerek aynı giriş formu tekrar gösterilir.
#Home- Index.cshtml ile ana sayfa (`Home Page`) için bir Razor görünümünü temsil etmektedir. Bu görünüm, hoş geldiniz mesajı, resimler ve bir keşfetme bağlantısı gibi içeriği içerir. İşlevlerini açıklayalım:
1. `@{ ViewData["Title"] = "Home Page"; }`:
   - Bu kod bloğu, görünümün başlığını `"Home Page"` olarak belirler.
2. `<div class="text-center">`:
   - Bu `div` öğesi, içeriği ortalamak için bir Bootstrap sınıfını temsil eder.
3. `<h1 class="display-5">Hoş Geldiniz</h1>`:
   - Bu `h1` başlık öğesi, hoş geldiniz mesajını temsil eder.
4. `<img src="~/Images/indir (3).png" />`:
   - Bu `img` öğesi, bir resmin görüntülenmesini temsil eder. Resim dosyasının yolu `~/Images/indir (3).png` olarak belirtilir.
5. `<p style="font-style:italic">EN İYİ ÜRÜNLERİ SİZİN İÇİN DERLEDİK</p>`:
   - Bu `p` öğesi, italik stilinde bir açıklama metnini temsil eder.
6. `<p>` ve `<img>` öğeleri:
   - Bu öğeler, bir paragraf metni ve resimlerin bir kombinasyonunu temsil eder.
7. `<a class="text-dark "  asp-area="" asp-controller="Products" asp-action="Urunler">`:
   - Bu `a` öğesi, bir keşfetme bağlantısını temsil eder.
   - `asp-controller` ve `asp-action` özellikleri, bağlantının yönlendirileceği kontrolcü ve eylemi belirtir.
   - `asp-area` özelliği boş bırakıldığı için alan belirtilmez.
8. `<p class="ridge"> Hemen Keşfedin</p>`:
   - Bu `p` öğesi, keşfetme bağlantısı içindeki metni temsil eder.
   - `class="ridge"` özelliği, metni hafif bir kabartma (ridge) stiliyle görüntüler.
Bu görünüm, ana sayfa içeriğini temsil eder. Hoş geldiniz mesajı, resimler ve keşfetme bağlantısı aracılığıyla kullanıcıları siteyi keşfetmeye teşvik eder. Resimlerin yolu, `Images` klasörü içinde bulunan dosyaların göreceli yollarıyla belirtilir. Keşfetme bağlantısı, `Products` kontrolcüsündeki `Urunler` eylemine yönlendirilir.
#Home- Privacy.cshml ile  "Gizlilik Politikası" sayfası için bir Razor görünümünü temsil etmektedir. Bu görünüm, kullanıcılara şirketin gizlilik politikasını açıklamak için bir metin içeriği sunar. İşlevlerini açıklayalım:
1. `@{ ViewData["Title"] = "Gizlilik Politikası"; }`:
   - Bu kod bloğu, görünümün başlığını `"Gizlilik Politikası"` olarak belirler.
2. `<h1>@ViewData["Title"]</h1>`:
   - Bu `h1` başlık öğesi, sayfa başlığını görüntüler. Başlık, ViewData'dan alınır.
3. `<p style="text-align:justify">`:
   - Bu `p` öğesi, metni sağa ve sola hizalamak için `text-align:justify` stilini kullanır.
4. `<h6>` ve `<p>` öğeleri:
   - Bu öğeler, gizlilik politikasının başlıklarını ve açıklamalarını temsil eder.
   - `<h6>` başlık öğeleri, metinleri altıncı seviye başlıklar olarak stilize eder.
   - `<p>` paragraf öğeleri, açıklama metnini temsil eder.
5. `<ul>` öğeleri:
   - Bu öğeler, sıralı olmayan listeleri temsil eder. İlgili maddelerin listelenmesi için kullanılır.
6. `<a>`, `<img>`, ve diğer öğeler:
   - Bu öğeler, bağlantılar ve resimlerin görüntülenmesini temsil eder.
Bu görünüm, gizlilik politikasını açıklayan bir sayfayı temsil eder. İlgili başlıklar altında, kullanıcıların kişisel bilgilerin nasıl toplandığı, kullanıldığı, paylaşıldığı ve güvende tutulduğu gibi konular açıklanır. Ayrıca çerezler, diğer web sitelerine bağlantılar ve iletişim bilgileri gibi diğer önemli bilgiler de sunulur.
#Products- Add.cshtml ile  bir ürünün eklenmesi için bir Razor görünümünü temsil etmektedir. Bu görünüm, kullanıcının ürün bilgilerini girmesine ve bir form aracılığıyla sunucuya göndermesine olanak tanır. İşlevlerini açıklayalım:
1. `@{ ViewData["Title"] = "Add"; }`:
   - Bu kod bloğu, görünümün başlığını `"Add"` olarak belirler.
2. `<h1>Ürün Ekle</h1>`:
   - Bu `h1` başlık öğesi, sayfa başlığını görüntüler. Başlık, ViewData'dan alınır.
3. `@model Product`:
   - Bu ifade, görünümün model sınıfını `Product` olarak belirler. Bu, ürün bilgilerini taşıyacak bir modelin kullanıldığını gösterir.
4. `<form>` etiketi:
   - Bu etiket, ürün bilgilerinin sunucuya gönderileceği bir formu temsil eder.
   - `asp-controller` ve `asp-action` öznitelikleri, formun gönderileceği kontrolcü ve eylemi belirtir.
   - `method` özniteliği, formun `post` yöntemiyle gönderileceğini belirtir.
5. `<div>` ve `<label>` öğeleri:
   - Bu öğeler, ürün bilgilerinin girileceği alanların etiketlerini ve giriş alanlarını temsil eder.
   - `asp-for` özniteliği, alanın hangi model özelliğine bağlı olduğunu belirtir.
   - `class="form-control"` sınıfı, giriş alanlarının stilini uygular.
6. `<div class="form-check">`:
   - Bu `div` öğesi, bir onay kutusu için bir alanı temsil eder.
   - `asp-for` özniteliği, onay kutusunun hangi model özelliğine bağlı olduğunu belirtir.
7. `<button>` öğesi:
   - Bu öğe, formun sunucuya gönderilmesini tetikleyen bir düğmeyi temsil eder.
   - `class="btn btn-success"` sınıfları, düğmenin stilini uygular.
Bu görünüm, kullanıcının ürün bilgilerini girmesi için bir form sağlar. Kullanıcı, ürün adı, fiyatı, stok miktarı, açıklama ve stok durumu gibi bilgileri girebilir. Form gönderildiğinde, belirtilen eyleme yönlendirilir ve sunucu tarafında ilgili işlemler gerçekleştirilir.
#Products - Index.cshtml ile  bir ürün listesini gösteren bir Razor görünümünü temsil etmektedir. Bu görünüm, mevcut ürünleri listeleyen bir tablo oluşturur. İşlevlerini açıklayalım:
1. `@{ ViewData["Title"] = "Index"; }`:
   - Bu kod bloğu, görünümün başlığını `"Index"` olarak belirler.
2. `@model List<Product>`:
   - Bu ifade, görünümün model sınıfını `List<Product>` olarak belirler. Bu, ürünlerin bir listesini taşıyan bir modelin kullanıldığını gösterir.
3. `<h1>Ürünler</h1>`:
   - Bu `h1` başlık öğesi, sayfa başlığını görüntüler.
4. `@if (TempData["status"] != null)`:
   - Bu ifade, TempData'da "status" adında bir veri varsa, bir `alert` bileşeni içinde bu veriyi görüntüler. Bu genellikle bir işlem sonucunda kullanıcıya geri bildirim sağlamak için kullanılır.
5. `<button>` ve `<a>` öğeleri:
   - Bu öğeler, "Ürün Ekle" düğmesini temsil eder.
   - `asp-controller` ve `asp-action` öznitelikleri, düğmenin tıklandığında yönlendirileceği kontrolcü ve eylemi belirtir.
   - `style="color:white"` özniteliği, bağlantının beyaz renkte görüntülenmesini sağlar.
6. `<table>` etiketi:
   - Bu etiket, ürünlerin listelendiği bir tabloyu temsil eder.
7. `<thead>` ve `<tbody>` öğeleri:
   - Bu öğeler, tablonun başlık ve içerik kısımlarını temsil eder.
8. `@foreach` döngüsü:
   - Bu döngü, her bir ürün için bir tablo satırı oluşturur.
   - Her sütun, `@item` üzerinden ilgili ürün özelliğine erişir.
   - `asp-controller` ve `asp-action` öznitelikleri, düğmelerin tıklandığında yönlendirileceği kontrolcü ve eylemi belirtir.
   - `asp-route-id` özniteliği, düğmelerin tıklandığında ilgili ürünün ID'sini yönlendirme parametresi olarak belirtir.
Bu görünüm, `List<Product>` modeline sahip bir ürün listesini temsil eder. Her bir ürün için bir tablo satırı oluşturulur ve her satırda ürünün özellikleri görüntülenir. Kullanıcı, "Ürün Ekle" düğmesini kullanarak yeni bir ürün ekleyebilir veya her ürün için "Sil" veya "Güncelle" düğmelerini kullanarak ilgili işlemleri gerçekleştirebilir.
#Products - Update.cshtml ile  bir ürünü güncellemek için kullanılan bir Razor görünümünü temsil etmektedir. Bu görünüm, mevcut bir ürünün bilgilerini düzenlemek için bir form sağlar. İşlevlerini açıklayalım:
1. `@{ ViewData["Title"] = "Update"; }`:
   - Bu kod bloğu, görünümün başlığını "Update" olarak belirler.
2. `@model Product`:
   - Bu ifade, görünümün model sınıfını `Product` olarak belirler. Bu, bir ürün nesnesinin kullanıldığını gösterir.
3. `<h1>Ürün Güncelle</h1>`:
   - Bu `h1` başlık öğesi, sayfa başlığını görüntüler.
4. `<form>` etiketi:
   - Bu etiket, ürün bilgilerini güncellemek için bir formu temsil eder.
   - `asp-controller` ve `asp-action` öznitelikleri, formun gönderildiğinde yönlendirileceği kontrolcü ve eylemi belirtir.
   - `method="post"` özniteliği, formun POST yöntemiyle gönderileceğini belirtir.
5. `<div>` ve `<label>` öğeleri:
   - Bu öğeler, ürün bilgilerini düzenlemek için giriş alanlarının etiketlerini temsil eder.
   - `asp-for` özniteliği, giriş alanının `Product` modelindeki ilgili özellikle eşleştirildiğini belirtir.
6. `<input>` öğeleri:
   - Bu öğeler, ürün bilgilerini düzenlemek için giriş alanlarını temsil eder.
   - `asp-for` özniteliği, giriş alanının `Product` modelindeki ilgili özellikle eşleştirildiğini belirtir.
   - `class="form-control"` özniteliği, giriş alanının Bootstrap form kontrolü olarak biçimlendirilmesini sağlar.
7. `<div class="form-check">` ve `<input>` öğeleri:
   - Bu öğeler, bir onay kutusu (checkbox) kullanarak ürünün stok durumunu güncellemek için kullanılır.
   - `asp-for` özniteliği, onay kutusunun `Product` modelindeki ilgili özellikle eşleştirildiğini belirtir.
8. `<button>` öğesi:
   - Bu öğe, "Ürün Güncelle" düğmesini temsil eder.
   - `type="submit"` özniteliği, düğmenin bir formu gönderme işlevi göreceğini belirtir.
Bu görünüm, `Product` modeline sahip bir ürünün güncellenmesini sağlar. Formdaki giriş alanları, mevcut ürünün bilgilerini görüntüler ve kullanıcıya bu bilgileri düzenleme imkanı sunar. Kullanıcı, "Ürün Güncelle" düğmesini tıklayarak formu gönderebilir ve ürünün güncellenmesi gerçekleşir.
#Products - Urunler.cshtml ile "Urunler" olarak adlandırılan bir Razor görünümünü temsil etmektedir. Bu görünüm, ürünleri listeleyen bir tablo içerir. İşlevlerini açıklayalım:
1. `@{ ViewData["Title"] = "Urunler"; Layout = "~/Views/Shared/_Layout.cshtml"; }`:
   - Bu kod bloğu, görünümün başlığını "Urunler" olarak belirler ve paylaşılan bir layout (`_Layout.cshtml`) dosyasını kullanır.
2. `@model List<Product>`:
   - Bu ifade, görünümün model sınıfını `List<Product>` olarak belirler. Bu, ürünlerin bir listesinin kullanıldığını gösterir.
3. `<h1>Ürünler</h1>`:
   - Bu `h1` başlık öğesi, sayfa başlığını görüntüler.
4. `@if (TempData["status"] != null)`:
   - Bu ifade, `TempData` içinde "status" adında bir veri varsa, bir bildirim mesajını görüntüler.
5. `<table>` etiketi:
   - Bu etiket, ürünleri listeleyen bir tabloyu temsil eder.
6. `<thead>` ve `<tr>` etiketleri:
   - Bu etiketler, tablonun başlığını temsil eder. Tablonun sütun başlıkları burada tanımlanır.
7. `<tbody>` etiketi:
   - Bu etiket, tablonun içeriğini temsil eder.
8. `@foreach` döngüsü:
   - Bu döngü, `Model` içindeki her bir `Product` öğesi için bir tablo satırı oluşturur.
   - Her bir öğenin özellikleri (`Id`, `Name`, `Price`, vb.) tablo hücrelerinde görüntülenir.
   - Her ürün için "Sepete Ekle" ve "Sepetten Çıkar" düğmeleri yer alır.
9. `<button>` ve `<a>` öğeleri:
   - Bu öğeler, "Sepete Ekle" ve "Sepetten Çıkar" işlemlerini gerçekleştirmek için bağlantıları temsil eder.
   - `asp-controller` ve `asp-action` öznitelikleri, bağlantının yönlendirileceği kontrolcü ve eylemi belirtir.
   - `asp-route-id` özniteliği, bağlantıya eklenen ürün kimliğini belirtir.
Bu görünüm, bir ürün listesini tablo şeklinde görüntüler. Her bir ürün için, ilgili özellikler tablo hücrelerinde yer alır. Ayrıca, her ürün için "Sepete Ekle" ve "Sepetten Çıkar" düğmeleri mevcuttur. Bu düğmelere tıklandığında, ilgili işlemler gerçekleştirilir.
##Veritabanı bağlantılarımızı migration dosyalarıyla code first yaklaşımıyla yaptık. Migration dosyaları Entity Framework Core Migration işlemleri için bir Migration sınıfını temsil etmektedir. Bu Migration, bir `Products` tablosunun veritabanında oluşturulmasını ve tanımlanan sütunların eklenmesini sağlar. İşlevlerini açıklayalım:
1. `Up` metodu:
   - Bu metot, veritabanı şemasını güncellemek için yukarıya doğru bir Migration işlemi gerçekleştirir.
   - `CreateTable` metodu ile `Products` tablosu oluşturulur.
   - Tablo sütunları ve özellikleri (`Id`, `Name`, `Price`, vb.) tanımlanır.
   - `PrimaryKey` metodu ile `Id` sütunu belirtilerek birincil anahtar tanımlanır.
2. `Down` metodu:
   - Bu metot, yukarıda yapılan değişiklikleri geri almak için aşağıya doğru bir Migration işlemi gerçekleştirir.
   - `DropTable` metodu ile `Products` tablosu silinir.
Bu Migration sınıfı, Entity Framework Core Code First yaklaşımı kullanılarak veritabanında bir `Products` tablosunun oluşturulmasını ve yönetilmesini sağlar. Bu tablo, `Id`, `Name`, `Price`, `Stock`, `Description` ve `IsStock` sütunlarını içerir. 
##_Layout.cshtml dosyası bir Razor view dosyasını temsil eder. Bu view, bir HTML belgesi oluşturur ve bir web sitesinin ana sayfasını göstermek için kullanılır. İşlevlerini açıklayalım:
1. `<head>` bölümü:
   - Bu bölüm, HTML belgesinin başlık kısmını içerir.
   - `@ViewData["Title"]` kullanarak sayfa başlığı dinamik olarak belirlenir.
   - `link` etiketleri ile kullanılan CSS dosyaları ve stilleri belirtilir.
2. `<body>` bölümü:
   - Bu bölüm, sayfa içeriğini içerir.
   - `<header>` etiketi ile sayfa üstbilgisi oluşturulur. Bir navigasyon çubuğu içerir.
   - `<nav>` etiketi ile navigasyon çubuğu oluşturulur. Birkaç bağlantı içerir.
   - `<div class="container">` ile ana içerik alanı oluşturulur.
   - `@RenderBody()` kullanarak alt sayfalardan gelen içerik bu alana yerleştirilir.
   - `<footer>` etiketi ile sayfa altbilgisi oluşturulur. Birkaç özellik kutusu ve telif hakkı bilgisi içerir.
3. `<script>` bölümü:
   - Bu bölüm, JavaScript dosyalarını ve bağımlılıklarını belirtir.
   - `script` etiketleri içinde jQuery ve Bootstrap gibi kütüphanelerin yolunu belirtir.
   - `@await RenderSectionAsync("Scripts", required: false)` ile sayfa spesifik JavaScript kodları için bir bölüm oluşturulur.
Bu Razor view dosyası, statik HTML içeriği yanı sıra dinamik öğeleri de içerir. Bu sayede bir web sitesinin üstbilgisi, navigasyon çubuğu, ana içerik alanı ve altbilgisi gibi bölümleri oluşturulmuş olur. Ayrıca, CSS ve JavaScript bağlantıları da eklenerek stil ve işlevsellik sağlanmıştır.
