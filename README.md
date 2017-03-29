# Tim21- Thundercats


Dino Gafić , GitHub ime: DinoGaf

Nadza Vrazalica, GitHub ime: nadza

![header2](https://cloud.githubusercontent.com/assets/20600359/24466287/a9efd9b6-14b0-11e7-8b54-abc87a6f8b9b.jpg)



Tema:
International Space Station Mission Control

1. Opis teme

Cilj ovog projekta jeste da se simulira održivi nacin rada i održavanja ISS. Svrha sistema je da osigura kontinualan i neprekidan
lanac dostave osoblja i tereta na samu stanicu, usklađen sa potrebama stanice i eksperimenata koji se vrše u stanici ili orbiti 
oko stanice.

Problemi koji se susreću jeste veoma ogranićen skladišni prostor u samoj ISS, dodavanje novih modula (ekstenzija) na stanicu
i najveći preoblem: redovno održavanje stanice. Da bi se rješili ovi problemi, pojavljuju se novi podproblemi : kako sve
potrepštine dovesti do stanice, i kako osigurati neprekidno snadbjevanje najosnovnijim potrebštinama.

Ovaj sistem rješava ovaj problem tako što traži od ISS da pošalje zahtjev zemlji za stavi koje treba. Nakon što taj zahtjev biva procesuiran na zemlji,
onda se šalje prijedlog plana na razmatranje stanici. Stanica može da da zeleno svjetlo da se dostave potrebni resursi po planu ili odbije plan u potpunosti.

Razlog za kupovinu ovog sistema: s obzirom na ogromni trošak izgradnje i održavanja ISS, kao i dostave resursa
u svemir, svaka optimizacija u komunikaciji ce ustedjeti na globalnom nivou.

Tako da je cilj sljedeci:
- Održavanje ISS u svemiru.
- Održavanje životne sredine u ISS i redovnih eksperimenata.
- Optimizacija resursa i osoblja.
- Dostava resursa i osoblja neovisno o položaju ISS.

3. Procesi

ISS: Narudžba Misije - Ovaj proces je u suštini i kljucni proces sistem. Na osnovu njega se odvijaju svi ostali procesi ukljucujuci i procese
drugih aktera. Nakon što ISS na osnovu svoje interne liste prioriteta izabere neophodne zalihe, stvara obrazac, koji sadrži ime misije,
datum (planiranog) pocetka misije, kratki opis misije (npr. Održavanje mlaznica, Eksperiment
formiranja manjih asteroida), zatim lista osoblja (ukoliko nema astrounauta tražene struke vec na stanici ) da se ta misija izvrši.
Nakon što se ispuni i podnese narudžba ide u "pending" stanje. Dok je u ovom stanju NASA i Houston pristupaju narudžbenici te vrše svoje analize narudžbe misije.

Houston: Stvaranje Rasporeda Leta - Ovaj proces, zajedno sa podprocesima: Provjera Dostupnih Modula/Letjelica, Provjera Lokacija Rampa za Lansiranje)
za cilj ima da stvori dokument koji sadrži ime i lokaciju slobodne rampe sa koje se može lansirati, letjelice koje su dostupne za tu rampu i moduli koji su dostupni
za te letjelice. Nakon što formira raspored leta, on se proslijedjuje ISS-u na razmatranje.

NASA: Stvara Listu Djelova/Osoblja Potrebnog za Misiju - Ovaj proces, zajedno sa podprocesima: Provjera Dospnih Astronauta, Provjera Djelova na Lageru , Provjera da li se 
Dio može Napraviti i Procjena kada će taj Dio biti Napravljen, će kao cilj stvoriti dvije liste, jedna je lista resursa koji dostupni, a druga je lista resursa koji
se trebaju naruciti. 

Sljedeci proces upoređuje liste i datume u narudžbenici sa onim koje su poslali Houston i NASA i stvara protip plana izvršavanja, tj. kako bi se resursi mogli dostaviti
u ISS tako da ISS radi bez zastoja. Nakon što se stvori ovaj prototip, ISS ima opciju da da zeleno svijetlo izvršavanju misije ili da odbije misiju.

4. Funkcionalnosti

Sistem nudi sljedeće funkcionalnosti:
- Mogucnost narućivanja i praćenja toka naruđbenice
- Najoptimalnije rješenje za svaku naruđbenicu
- Pregled i statistike resursa poslanih na prethodne misije kroz analizu finalnog izvještaja
- Pregled/Pracenje dostupnog osoblja
- Pregled/Pracenje dostupnih resursa 
- Pregled/Pracenje osoblja u ISS
- Pregled/Pracenje resursa u ISS
- Pregled/Pracenje eksperimenata u ISS
- Narucivanje resursa
- Praćenje stanja ISS i slanje upozerenja u slućaju nedostatka resursa

2. Akteri
Imamo tri kljućna aktera:

ISS - Internacionalna svemirska stanica. 
ISS radi dvije bitne stvari : narucuje misije i provjerava plan misije.
Narucivanje misije se vrši po internoj listi prioriteta i potreba stanice, a provjeravanje se vrši nakon što
druga dva aktora analiziraju narudžbenicu te sastave plan i strategiju kako bi se misija mogla izvršiti. ISS daje zeleno svjetlo
ukoliko je saglasan sa planom. Naravno, ISS može da odbije predloženi plan.

Houston - zajednicko ime za kontrolu lansiranja. 
Houston je zadužen da prati koje su platforme slobodne i koje su rakete/moduli (kako putnicke tako i teretne, zavisno od potreba misije) dostupne za koju platformu. Houston je takođe zadužen da prati koordinate
ISS da bi se resursi mogli lansirati i dovesti na stanicu bez pretjeranih odlaganja. Po registrovanju naruđbenice za misiju, 
houston šalje raspored leta, koji sadrži datum kada se teret može lansirati na ISS, te sa koje platforme se može lansirati za ISS, 
te koliko je letjelica dostupno za tu platformu.

NASA - zajednicko ime za proizvođace resursa koji idu u svemir. 
Uloga nase jeste da proizvodi i skladišti sve neophodne resurse za ISS.
Nakon analize narudžbenice, NASA šalje listu dostupnih resursa.

* NASA i Houston imaju pristup prethodnim Finalnim Izvještajima , na osnovu kojih mogu da interno stvore svoju listu najkorištenijih resursa
  da bi te iste mogli skladištiti i tako pomoći ubrzanom izvršavanju misija.
