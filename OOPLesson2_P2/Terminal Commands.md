```bash
cd KlasorAdi

# Örnek

cd ConsoleAppProject

# Bir üst klasöre çıkmak için

cd ..

# Mevcut bulunduğum klasörü görmek için

pwd

# Bir projeye başka bir projeyi eklemek(Yani referans almak) için
# Önce projenin ekleneceği projenin olduğu klasöre gidiyorum
cd ConsoleAppProject
# Sonra eklenecek olan projeyi yazıyorum
dotnet add reference ../ConsoleAppLibraryProject

```