# İhale Yönetim Projesi - Admin ve Kullanıcı Arayüzleri
Bu projem, iki ayrı bileşenden oluşmaktadır: Web API ve ASP.NET Core MVC uygulaması. Web API kısmında, ihale yönetimi için kullanılan veritabanı ve RESTful API oluşturulmuştur. Core MVC uygulamasında ise bu API'yi kullanmaktadır. Proje, admin panelindeki ihale işlemlerini gerçekleştirmek için kullanılmaktadır.

### Web API
- Veritabanı: Admin panelinde kullanılan veritabanı bu kısımda yer almaktadır.
- RESTful API: İhale yönetimi işlemleri için API'lar sunulmaktadır.

---

### Core MVC Uygulaması
Core MVC uygulaması iki ana kısımdan oluşmaktadır: Admin ve Kullanıcı.
- Admin Tarafı İşlevleri
* İhale Ekleme: Yeni bir ihale oluşturulabilir.
* İhaleye Araç Ekleme: Var olan bir ihaleye araç eklenerek katılım sağlanabilir.
* İhale Listeleme: Eklenen ihaleler bir tablo şeklinde listelenebilir.
* İhale Onaylama: İhaleye katılan kullanıcılar içerisinden seçilen bir kullanıcı onaylanabilir ve sonrasında bu kullanıcı görüntülebilir.
- Kullanıcı Tarafı İşlevleri
* İhalelere Katılım: Kullanıcılar, ihalelere katılabilir ve katılmak için bir ücret girer.

---

### Veri Tabanı ve Veri Erişimi
- Veri tabanı işlemleri, Code First yaklaşımı kullanılarak gerçekleştirilir.
- Web API, veritabanı işlemlerini yönetir ve ASP.NET Core MVC uygulaması bu API'yi kullanarak verilere erişir.
- Repository Pattern kullanılarak veritabanı işlemleri düzenlenir.

---

### Kimlik Doğrulama ve Yetkilendirme
- Kimlik doğrulama için Cookie Authentication ve Claim bazlı yetkilendirme kullanılır.
- Kullanıcıların oturum açması ve yetkilendirilmesi sağlanır.
