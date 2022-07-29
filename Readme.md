# Upravljanje ljekarnom
Windows Forms aplikacija napravljena koristeći .NET Framework i C# programski jezik koja služi za lakše upravljanje ljekarničkim dužnostima. Aplikacija je napravljena u sklopu timskog projekta na kolegiju Programsko inženjerstvo na Fakultetu organizacije i informatike. 

Funkcionalnosti navedene u nastavku predstavljaju moja zaduženja u projektu.
## Funkcionalnosti
### Popis proizvođača
Na sljedećoj slici je prikazan prozor popisa proizvođača koja prikazuje njihove informacije. Ako se prijavite u aplikaciju kao **običan korisnik** tada nemate pristup dodavanju, ažuriranju i brisanju proizvođača s popisa te se za te mogućnosti trebate prijaviti kao **administrator**.

![image](https://user-images.githubusercontent.com/92993079/181746853-79a77962-c8b3-48f9-8b7c-eb30ca4a0b00.png)

Ako želite dodati proizvođača na popis, potrebno je unijeti podatke u polja iznad. Ako želite ažurirati podatke ili obrisati određenog proizvođača tada ga trebate označiti u tablici i kliknuti na gumb.
### Naručivanje lijekova


![image](https://user-images.githubusercontent.com/92993079/181747512-61451f2b-2d96-4799-8b12-97b549b83a59.png)

## Korištenje
Kako se u projektu nalaze osjetljive informacije vezane uz centraliziranu bazu podataka, odlučio sam enkriptirati datoteku koja te informacije sadrži kako podaci ne bi bili dostupni u *plain textu*. Koristio sam RSA algoritam te ću ovdje navesti korake kako dekriptirati datoteku na vašem računalu kako biste mogli pristupiti bazi te pokrenuti aplikaciju.
***
Napomene: 
- potrebno je koristiti uređaj s Windows operacijskim sustavom
- Naredbeni redak (engl. Command Prompt, cmd) potrebno je pokrenuti kao administrator
***
### 1. Navigacija do putanje
Kako bi došli do lokacije gdje se nalazi aspnet_regiis.exe koji nam služi za enkripciju/dekripciju u *Command Prompt* unesite sljedeću naredbu:
```
cd %windir%\Microsoft.NET\Framework64\v4.0.30319
```
Lokacija ovog programa može se razlikovati ovisno o .NET Framework verziji, ovdje je korišten .NET Framework 4 na 64-bitnom računalu.
### 2. Importanje ključeva
Kako bi se aplikacija mogla pokrenuti na različitim računalima potrebno je uvesti (engl. import) javni i tajni ključ koji se koriste prilikom dekripcije.

Zbog jednostavnosti premjestite datoteku **kljucevi.xml** u izvorišni direktorij lokalnog diska po želji npr. `C:\kljucevi.xml` ili `D:\kljucevi.xml`

Tada u *Command Prompt* unesite sljedeću naredbu
```
aspnet_regiis.exe -pi “ParKljuceva” “C:\kljucevi.xml”
```
Nakon što ste to učinili preporučljivo je izbrisati datoteku **kljucevi.xml** jer ona predstavlja sigurnosni rizik pošto se može koristiti na računalima na kojima možda ne želimo uvesti te ključeve.

### 3. Pokretanje aplikacije
Ukoliko ste uspješno importali ključeve, dekripcija se odvija u prilikom izvršavanja aplikacije (engl. runtime).
***
Za više informacija možete proučiti ove izvore koje sam koristio kako bih napravio ovaj vodič: 
- https://www.c-sharpcorner.com/article/encrypting-app-config-for-multiple-machines/
- https://www.cognizantsoftvision.com/blog/encrypting-configuration-sections-in-net/
