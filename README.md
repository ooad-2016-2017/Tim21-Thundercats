# Tim21- Thundercats


Dino Gafić , GitHub ime: DinoGaf

Nadza Vrazalica, GitHub ime: nadza

![header](https://cloud.githubusercontent.com/assets/20600359/24465550/b512138e-14ad-11e7-955e-baeef91ed4b6.jpg)



Tema:
International Space Station Mission Control

1. Generalni opis teme
Cilj ovog projekta jeste da se simulira održivi naćin rada i održavanja ISS. Svrha sistema je da osigura kontinualan i neprekidan
lanac dostave osoblja i tereta na samu stanicu , usklađen sa potrebama stanice i eksperimenata koji se vrše u stanici ili orbiti 
oko stanice.
Problemi koji se susreću jeste veoma ogranićen skladišni prostor u samoj ISS , dodavanje novih modula (ekstenzija) na stanicu
i najveći preoblem : redovno održavanje stanice. Da bi se rješili ovi problemi , pojavljuju se novi podproblemi : kako sve
potrebštine dovesti do stanice , i kako osigurati neprekidno snadbjevanje najosnovnijim potrebštinama.
Ovaj sistem rješava ovaj problem tako što traži od ISS da pošalje zahtjev zemlji za stavi koje treba. Nakon što taj zahtjev biva procesuiran na zemlji
, onda se šalje prijedlog plana na razmatranje stanici. Stanica može da da zeleno svjetlo da se dostave potrebni resursi po planu ,
modifikuje taj plan prema svojoj listi prioriteta i/ili odbije plan u potpunosti.
Razlog za kupovinu ovog sistema je očigledan : s obzirom na ogromni trošak izgradnje i održavanja ISS , kao i dostave resursa
u svemir , svaka optimizacija će uštediti milijone ako ne i milijarde (dolara , eura , maraka , jena , itd.) na globalnom nivou.
Tako da je cilj u tezama:
- Održavanje ISS u svemiru.
- Održavanje životne sredine u ISS i redovnih eksperimenata.
- Optimizacija resursa i osoblja.
- Dostava resursa i osoblja neovisno o položaju ISS.
+ Summoning the old ones to annihilate humans and make survivors submit to their new master - C'thulu. (Option 2 was letting J.J. Abrams reboot ISS. We can all agree mankind narrowly dodged a bullet there.) 

2. Aktori
Imamo tri kljućna aktora:

ISS - Internacionalna svemirska stanica. ISS radi dvije bitne stvari : narućuje misije i provjerava plan misije.
Narućivanje misije se vrši po internoj listi prioriteta , tj. po lićnom nahođenju , a provjeravanje se vrši nakon što
druga dva aktora proćitaju naruđbenicu i dadnu njihovu procjenu kako bi se misija mogla izvršiti. ISS daje zeleno svjetlo
(nazvano Finalni izvještaj (o misiji)) ukoliko je saglasan sa planom , te da se postupi po istom. Naravno , ISS može da 
odbije predloženi plan , ali ima i treću opciju , ukoliko je plan slićan predloženom planu , tada može da izmjeni naruđbenicu
, ali iz sigurnosnih razloga , izmjenjena naruđbenica prolazi kroz isti proces kao da je nova naruđbenica.

Houston - zajednićko ime za kontrolu lansiranja. Houston je zadužen da prati koje su platforme slobodne i koje su rakete/moduli
(ima putnićki modul i teretni modul za raketu) dostupne za koju platformu. Houston je takođe zadužen da prati koordinate
ISS da bi se resursi mogli lansirati i dovesti na stanicu bez pretjeranih odlaganja. Po registrovanju naruđbenice za misiju , 
houston šalje raspored leta , koji sadrži datum kada se teret može lansirati na ISS , te sa koje platforme se može lansirati za ISS , 
te koliko je letjelica dostupno za tu platformu.

NASA - zajednićko ime za proizvođaće resursa koji idu u svemir. Uloga nase jeste da proizvodi i skladišti sve neophodne resurse za ISS.
Po registrovanju naruđbenice za misiju , NASA poredi listu resursa datu u naruđbenici sa svojom listom resursa. Nakon procesiranja , NASA
šalje listu dostupnih (tj. uskladištenih) resursa , te još jednu listu , ukoliko je ISS narućio elemente koje NASA nema na lageru , tada
NASA stvara dodatnu listu u kojoj se nalazi ime resursa , da li se može proizvesti , i ukoliko se može proizvesti , kada će biti proizveden.

* NASA i Houston imaju pristup prethodnim Finalnim Izvještajima , na osnovu kojih mogu da interno stvore svoju listu najkorištenijih resursa
  da bi te iste mogli skladištiti i tako pomoći ubrzanom izvršavanju misija.

3.Procesi
Kljućni proces je: Narućivanje (ili biranje/smišljanje) Misije , koji vrši ISS.
Nakon što ISS na osnovu svoje interne liste prioriteta izabere šta mu treba , stvara tzv. obrazac , koji sadrži ime misije ,
datum (planiranog) poćetka misije , datum  (planiranog) kraja misije , kratki opis misije (npr. Održavanje mlaznica i eksperiment
formiranja manjih asteroida ) , i najbitnije , lista potrebnih resursa i osoblja (ukoliko nema astrounauta tražene struke
na ISS ) da se ta misija izvrši.
Nakon što se napravi naruđbenica , naruđba ide u tzv. "pending" stanje. Dok je u ovom stanju NASA i Houston pristupaju naruđbenici
i vrše sljedeće podprocese:
Houston - Stvaranje Rasporeda Leta - Ovaj proces ( Zajedno sa ukljućenim podprocesima : Provjera Dostupnih Modula/Letjelica , Provjera Lokacija Rampa za Lansiranje)
za cilj ima da stvori dokument koji sadrži ime i lokaciju slobodne rampe sa koje se može lansirati , letjelice koje su dostupne za tu rampu i moduli koji su dostupni
za te letjelice. Nakon što stvori dokument nazvan raspored leta , taj se šalje nazad u ISS da bude spreman za sljedeći proces.
NASA - Stvara Listu Djelova/Osoblja Potrebnog za Misiju - ( Zajedno sa ukljućenim podprocesima : Provjera Dospnih Astronauta , Provjera Djelova na Lageru , Provjera da li se 
Dio može Napraviti i Procjena kada će taj Dio biti Napravljen ) koji će kao cilj stvoriti dvije liste , jedna je lista resursa koji dostupni , a druga je lista resursa koji
se mogu ili ne mogu napraviti. Te dvije liste se šalju nazad u ISS da bude spreman za sljedeći proces.
Kada Houston i NASA pošalju njihove liste u ISS , naruđbenica izlazi iz "pending" stanja i ulazi u proces Predlaganja Kako se Misija Može Izvršiti.
Ovaj proces upoređuje liste i datume u naruđbenici sa onim koje su poslali Houston i NASA i stvara protip plana izvršavanja , tj. kako bi se resursi mogli dostaviti
u ISS tako da ISS radi bez zastoja. Nakon što se stvori ovaj prototip , ISS ga interno upoređuje sa listom prioriteta i stvaraju se tri stanja - Zeleno Svjetlo ( 
Prototip plana izvršavanja misije se slaže sa prioritetima ISS-a, tada se stvara završni raport i misija formalno poćinje) , Žuto Svjetlo ( Prototip plana izvršavanja 
misije je vrlo blizu blizu traženih prioriteta , tada se naruđbenica koriguje i ponovo se vrši narućivanje misije sa korigovanom naruđbenicom) , Crveno Svjetlo
(Ukoliko se protitp vrlo malo slaže sa prioritetima ISS , tada se naruđbenica otkazuje ).

4. Funkcionalnosti
Sistem nudi sljedeće funkcionalnosti:
- Mogućnost narućivanja i praćenja toka naruđbenice
- Najoptimalnije rješenje za svaku naruđbenicu
- Pregled i statistike resursa poslanih na prethodne misije kroz analizu finalnog izvještaja
- Pregled/Praćenje Dostupnog Osoblja
- Pregled/Praćenje Dostupnih Resursa 
- Pregled/Praćenje Osoblja u ISS
- Pregled/Praćenje Resursa u ISS
- Pregled/Praćenje Eksperimenata u ISS
- Narućivanje Resursa
- Praćenje Stanja ISS i Slanje Upozerenja u Slućaju Nedostatka Resursa
