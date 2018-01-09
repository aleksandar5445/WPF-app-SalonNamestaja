--seed.sql

INSERT INTO TipNamestaja(Naziv,Obrisan) VALUES('Polica',0); 
INSERT INTO TipNamestaja(Naziv,Obrisan) VALUES('Stolica',0);
INSERT INTO TipNamestaja(Naziv,Obrisan) VALUES('Krevet',0);

INSERT INTO Namestaj(TipNamestajaId,Naziv,Sifra,Cena,Kolicina,Obrisan)
VALUES (1,'Ultra Polica','UL1',123.5,2,0);

INSERT INTO Namestaj(TipNamestajaId,Naziv,Sifra,Cena,Kolicina,Obrisan)
VALUES (1,'Regal','UL4',220,2,0);