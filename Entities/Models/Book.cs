using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{

    /* 

     Öncelikle amacımız Bütün projeleri katmanlara ayırmak ilk olarak daha önce yapmış olduğumuz 
    projemiz içinde Models klasörümüzden kurtuluyoruz.
    Daha sonra orada içeride bulunna Book propslarını ve class'ı buraya kopyalıyoruz.

        Şimdi iki adet farklı projemiz var ve bunlar birbirine bağlı değil.
            Ana Projemizin içinde  Dependencies kısmını kullanarak bu bağlantıyı sağlayacağız.
            Öncelikle yapmamız gereken,
                Ana projemize geçiş yapıp bu proje üzerinden Dependencies kısmının üstüne gidip sağ tıklayarak.
                    Add Project Referance diyip Entities projemizi seçiyoruz.
                        Seçtikten sonra Dependencies kısmının altında Entities olarak bir klasör göreceğiz.
                            Bu noktada uygulamamızı birbirlerine bağlamış olduk fakat NameSpace Bağlantılarını yapmadık.

      Bunun için ilk olarak Models olarak gösterilen bütün datalara müdahale etmemiz lazım.
        Öncelikle Controllers altına geçerek burada bulunan Model isimli import kısmını çözümlememiz lazım.
            Projemizin içine girip Controllers klasörünün altında bulunan ,
                Bookscontrollers'a girelim ve buradan 
                    using WebApplication1.Models; ismini kaldıralım.
                        Daha sonra Entities.Models olarak ctrl+ . komutu ile import edelim. 
                            Şimdi ise amacımız şu başka yerlerde de biz Models yapısını kullandık bunlarıda dışarıdan aldığımız şekilde düzenlememiz lazım.
                                Daha sonra Tekrar projemizi yeniden başlatmaya çalışalım .
                                    Herhangi bir sorun Yok !!! 
                                        Artık başarılı bir şekilde katmanlı mimariye giriş Yaptık. !! 


    Şimdi ikinci kısma geçiş yapaklım. 
        projemizde oluşturduğumuz ilk aşamaya benzer olarak tekrar projemizin geneline yeni bir proje ekleyeceğiz.
            Repositories isimli projemize geçiş yapalım.









     */


    public class Book
    {

        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }
    }
}
