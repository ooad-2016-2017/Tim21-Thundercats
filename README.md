# Tim21-Hepek
Dino Gafiæ , GitHub ime: DinoGaf
Nadza Vrazalica

Tema:
International Space Station (ISS)
"Of the people , by the people , for the people" - Abraham Lincoln

1. Generalni opis teme
Cilj ovog projekta jeste da se simulira održivi naæin rada i održavanja ISS. Svrha sistema je da osigura kontinualan i neprekidan
lanac dostave osoblja i tereta na samu stanicu , usklaðen sa potrebama stanice i eksperimenata koji se vrše u stanici ili orbiti 
oko stanice.
Problemi koji se susreæu jeste veoma ograniæen skladišni prostor u samoj ISS , dodavanje novih modula (ekstenzija) na stanicu
i najveæi preoblem : redovno održavanje stanice. Da bi se rješili ovi problemi , pojavljuju se novi podproblemi : kako sve
potrebštine dovesti do stanice , i kako osigurati neprekidno snadbjevanje najosnovnijim potrebštinama.
Ovaj sistem rješava ovaj problem tako što traži od ISS da pošalje zahtjev zemlji za stavi koje treba. Nakon što taj zahtjev biva procesuiran na zemlji
, onda se šalje prijedlog plana na razmatranje stanici. Stanica može da da zeleno svjetlo da se dostave potrebni resursi po planu ,
modifikuje taj plan prema svojoj listi prioriteta i/ili odbije plan u potpunosti.
Razlog za kupovinu ovog sistema je oèigledan : s obzirom na ogromni trošak izgradnje i održavanja ISS , kao i dostave resursa
u svemir , svaka optimizacija æe uštediti milijone ako ne i milijarde (dolara , eura , maraka , jena , itd.) na globalnom nivou.
Tako da je cilj u tezama:
- Održavanje ISS u svemiru.
- Održavanje životne sredine u ISS i redovnih eksperimenata.
- Optimizacija resursa i osoblja.
- Dostava resursa i osoblja neovisno o položaju ISS.
+ Summoning the old ones to annihilate humans and make survivors submit to their new master - C'thulu. (Option 2 was letting J.J. Abrams reboot ISS. We can all agree mankind narrowly dodged a bullet there.) 

2. Aktori
Imamo tri kljuæna aktora:

ISS - Internacionalna svemirska stanica. ISS radi dvije bitne stvari : naruæuje misije i provjerava plan misije.
Naruæivanje misije se vrši po internoj listi prioriteta , tj. po liænom nahoðenju , a provjeravanje se vrši nakon što
druga dva aktora proæitaju naruðbenicu i dadnu njihovu procjenu kako bi se misija mogla izvršiti. ISS daje zeleno svjetlo
(nazvano Finalni izvještaj (o misiji)) ukoliko je saglasan sa planom , te da se postupi po istom. Naravno , ISS može da 
odbije predloženi plan , ali ima i treæu opciju , ukoliko je plan sliæan predloženom planu , tada može da izmjeni naruðbenicu
, ali iz sigurnosnih razloga , izmjenjena naruðbenica prolazi kroz isti proces kao da je nova naruðbenica.

Houston - zajedniæko ime za kontrolu lansiranja. Houston je zadužen da prati koje su platforme slobodne i koje su rakete/moduli
(ima putniæki modul i teretni modul za raketu) dostupne za koju platformu. Houston je takoðe zadužen da prati koordinate
ISS da bi se resursi mogli lansirati i dovesti na stanicu bez pretjeranih odlaganja. Po registrovanju naruðbenice za misiju , 
houston šalje raspored leta , koji sadrži datum kada se teret može lansirati na ISS , te sa koje platforme se može lansirati za ISS , 
te koliko je letjelica dostupno za tu platformu.

NASA - zajedniæko ime za proizvoðaæe resursa koji idu u svemir. Uloga nase jeste da proizvodi i skladišti sve neophodne resurse za ISS.
Po registrovanju naruðbenice za misiju , NASA poredi listu resursa datu u naruðbenici sa svojom listom resursa. Nakon procesiranja , NASA
šalje listu dostupnih (tj. uskladištenih) resursa , te još jednu listu , ukoliko je ISS naruæio elemente koje NASA nema na lageru , tada
NASA stvara dodatnu listu u kojoj se nalazi ime resursa , da li se može proizvesti , i ukoliko se može proizvesti , kada æe biti proizveden.

* NASA i Houston imaju pristup prethodnim Finalnim Izvještajima , na osnovu kojih mogu da interno stvore svoju listu najkorištenijih resursa
  da bi te iste mogli skladištiti i tako pomoæi ubrzanom izvršavanju misija.

3.Procesi
Kljuæni proces je: Naruæivanje (ili biranje/smišljanje) Misije , koji vrši ISS.
Nakon što ISS na osnovu svoje interne liste prioriteta izabere šta mu treba , stvara tzv. obrazac , koji sadrži ime misije ,
datum (planiranog) poæetka misije , datum  (planiranog) kraja misije , kratki opis misije (npr. Održavanje mlaznica i eksperiment
formiranja manjih asteroida ) , i najbitnije , lista potrebnih resursa i osoblja (ukoliko nema astrounauta tražene struke
na ISS ) da se ta misija izvrši.
Nakon što se napravi naruðbenica , naruðba ide u tzv. "pending" stanje. Dok je u ovom stanju NASA i Houston pristupaju naruðbenici
i vrše sljedeæe podprocese:
Houston - Stvaranje Rasporeda Leta - Ovaj proces ( Zajedno sa ukljuæenim podprocesima : Provjera Dostupnih Modula/Letjelica , Provjera Lokacija Rampa za Lansiranje)
za cilj ima da stvori dokument koji sadrži ime i lokaciju slobodne rampe sa koje se može lansirati , letjelice koje su dostupne za tu rampu i moduli koji su dostupni
za te letjelice. Nakon što stvori dokument nazvan raspored leta , taj se šalje nazad u ISS da bude spreman za sljedeæi proces.
NASA - Stvara Listu Djelova/Osoblja Potrebnog za Misiju - ( Zajedno sa ukljuæenim podprocesima : Provjera Dospnih Astronauta , Provjera Djelova na Lageru , Provjera da li se 
Dio može Napraviti i Procjena kada æe taj Dio biti Napravljen ) koji æe kao cilj stvoriti dvije liste , jedna je lista resursa koji dostupni , a druga je lista resursa koji
se mogu ili ne mogu napraviti. Te dvije liste se šalju nazad u ISS da bude spreman za sljedeæi proces.
Kada Houston i NASA pošalju njihove liste u ISS , naruðbenica izlazi iz "pending" stanja i ulazi u proces Predlaganja Kako se Misija Može Izvršiti.
Ovaj proces uporeðuje liste i datume u naruðbenici sa onim koje su poslali Houston i NASA i stvara protip plana izvršavanja , tj. kako bi se resursi mogli dostaviti
u ISS tako da ISS radi bez zastoja. Nakon što se stvori ovaj prototip , ISS ga interno uporeðuje sa listom prioriteta i stvaraju se tri stanja - Zeleno Svjetlo ( 
Prototip plana izvršavanja misije se slaže sa prioritetima ISS-a, tada se stvara završni raport i misija formalno poæinje) , Žuto Svjetlo ( Prototip plana izvršavanja 
misije je vrlo blizu blizu traženih prioriteta , tada se naruðbenica koriguje i ponovo se vrši naruæivanje misije sa korigovanom naruðbenicom) , Crveno Svjetlo
(Ukoliko se protitp vrlo malo slaže sa prioritetima ISS , tada se naruðbenica otkazuje ).

4. Funkcionalnosti
Sistem nudi sljedeæe funkcionalnosti:
- Moguænost naruæivanja i praæenja toka naruðbenice
- Najoptimalnije rješenje za svaku naruðbenicu
- Pregled i statistike resursa poslanih na prethodne misije kroz analizu finalnog izvještaja
- Pregled/Praæenje Dostupnog Osoblja
- Pregled/Praæenje Dostupnih Resursa 
- Pregled/Praæenje Osoblja u ISS
- Pregled/Praæenje Resursa u ISS
- Pregled/Praæenje Eksperimenata u ISS
- Naruæivanje Resursa
- Praæenje Stanja ISS i Slanje Upozerenja u Sluæaju Nedostatka Resursa