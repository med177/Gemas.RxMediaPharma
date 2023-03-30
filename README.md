# Gemas.RxMediaPharma

Uygulamaya ait veritabanı ayarı Gemas.RxMediaPharma/RxMediaPharma/App.Config içerisindeki connectionstring kısmından değiştirilmelidir.

```xml
<connectionStrings>
		<add name="SQLite" connectionString="Data Source=C:\Users\med\Desktop\GemasRxMediaPharma\Gemas.RxMediaPharma\RxMediaPharma\bin\Debug\DB\rxsample.db" />
</connectionStrings>
```

Barkod doğru görebilmek için Gemas.RxMediaPharma/RxMediaPharma/Resources/EAN-13.ttf dosyasını işletim sistemine yüklemeniz gerekmektedir.
