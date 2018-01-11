using rs12_2011.UI.Database;
using System;
using System.Collections.Generic;
using model = rs12_2011.model;

namespace rs12_2011.UI.DataAccess
{
    public class DatabaseAccess
    {
        private SalonDatabase dbcontext;

        public DatabaseAccess()
        {
            dbcontext = new SalonDatabase();
        }

        //GET
        public List<model.Namestaj> GetAllNamestaj()
        {
            var namestaj = dbcontext.Namestaj;
            var result = new List<model.Namestaj>();

            foreach (var n in namestaj)
            {
                result.Add(ToModelNamestaj(n));
            }

            return result;
        }

        public List<model.Akcija> GetAllAkcije()
        {
            var akcije = dbcontext.Akcija;
            var result = new List<model.Akcija>();

            foreach (var a in akcije)
            {
                result.Add(ToModelAkcija(a));
            }

            return result;
        }

        public List<model.Korisnik> GetAllKorisnici()
        {
            var korisnici = dbcontext.Korisnik;
            var result = new List<model.Korisnik>();

            foreach (var k in korisnici)
            {
                result.Add(ToModelKorisnik(k));
            }

            return result;
        }

        public model.Salon GetSalon()
        {
            var saloni = dbcontext.Salon;
            var result = new List<model.Salon>();

            foreach (var s in saloni)
            {
                result.Add(ToModelSalon(s));
            }

            return result[0];
        }

        public List<model.IstorijaKupovine> GetIstorijaKupovineZaKorisnika(string korisnickoIme)
        {
            var result = new List<model.IstorijaKupovine>();
            foreach (var ik in dbcontext.IstorijaKupovine)
            {
                if (ik.Korisnik.KorisnickoIme == korisnickoIme)
                {
                    result.Add(ToModelIstorijaKupovine(ik));
                }
            }

            return result;
        }

        public List<model.IstorijaKupovine> GetAllIstorijaKupovine()
        {
            var result = new List<model.IstorijaKupovine>();
            foreach (var ik in dbcontext.IstorijaKupovine)
            {
                result.Add(ToModelIstorijaKupovine(ik));

            }

            return result;
        }

        public List<model.IstorijaKupovine> GetIstorijaKupovineZaKorisnikaIDatum(string korisnickoIme, DateTime datumKupovine)
        {
            List<model.IstorijaKupovine> result = new List<model.IstorijaKupovine>();
            foreach (var ik in dbcontext.IstorijaKupovine)
            {
                if (ik.Korisnik.KorisnickoIme == korisnickoIme && ik.DatumKupovine == datumKupovine)
                {
                    result.Add(ToModelIstorijaKupovine(ik));
                }
            }

            return result;
        }

        //INSERT
        public void InsertNamestaj(model.Namestaj namestaj)
        {
            dbcontext.Namestaj.Add(ToDbNamestaj(namestaj));
            dbcontext.SaveChanges();
        }

        public void InsertKorisnik(model.Korisnik korisnik)
        {
            dbcontext.Korisnik.Add(ToDbKorisnik(korisnik));
            dbcontext.SaveChanges();
        }

        public void InsertAkcija(model.Akcija akcija)
        {
            dbcontext.Akcija.Add(ToDbAkcija(akcija));
            dbcontext.SaveChanges();
        }

        public void InsertIstorijaKupovine(model.IstorijaKupovine ik)
        {
            dbcontext.IstorijaKupovine.Add(ToDbIstorijaKupovine(ik));
            dbcontext.SaveChanges();
        }

        public void InsertAkcijaIPopusti(model.Akcija ak)
        {
            dbcontext.Akcija.Add(ToDbAkcija(ak));
            dbcontext.SaveChanges();
        }

        //UPDATE
        public void UpdateNamestaj(model.Namestaj namestaj)
        {
            foreach (var n in dbcontext.Namestaj)
            {
                if (n.Sifra == namestaj.Sifra)
                {
                    n.Aktivan = namestaj.Aktivan == "Neaktivan" ? false : true;
                    n.JedinicnaCena = namestaj.JedinicnaCena;
                    n.KolicinaUMagacinu = namestaj.KolicinaUMagacinu;
                    n.Naziv = namestaj.Naziv;
                    n.Sifra = namestaj.Sifra;
                    n.TipNamestajaId = FindTipNamestajaId(namestaj.TipNamestaja.ToString());
                }
            }

            dbcontext.SaveChanges();
        }

        public void UpdateKorisnik(model.Korisnik korisnik)
        {
            foreach (var n in dbcontext.Korisnik)
            {
                if (n.KorisnickoIme == korisnik.KorisnickoIme)
                {
                    n.Aktivan = korisnik.Aktivan == "Neaktivan" ? false : true;
                    n.Ime = korisnik.Ime;
                    n.Prezime = korisnik.Prezime;
                    n.KorisnickoIme = korisnik.KorisnickoIme;
                    n.Lozinka = korisnik.Lozinka;
                    n.TipKorisnikaId = FindTipkorisnikId(korisnik.TipKorisnika.ToString());
                }
            }
            dbcontext.SaveChanges();
        }

        public void UpdateAkcija(model.Akcija akcija)
        {
            foreach (var n in dbcontext.Akcija)
            {
                if (n.Naziv == akcija.Naziv)
                {
                    n.Aktivan = akcija.Aktivan == "Neaktivan" ? false : true;
                    n.DatumPocetka = akcija.DatumPocetka;
                    n.DatumKraja = akcija.DatumKraja;
                    n.Naziv = akcija.Naziv;
                    foreach (var p in akcija.Popusti)
                    {
                        n.Popusti.Add(new Popusti
                        {
                            AkcijaId = FindAkcijaId(akcija.Naziv),
                            NamestajId = FindNamestajId(p.Key),
                            Popust = p.Value
                        });
                    }
                }
            }
            dbcontext.SaveChanges();
        }

        public void UpdateSalon(model.Salon salon)
        {
            foreach (var s in dbcontext.Salon)
            {
                s.Adresa = salon.Adresa;
                s.Mail = salon.Mail;
                s.Naziv = salon.Naziv;
                s.Sajt = salon.Sajt;
                s.Telefon = salon.Telefon;
                s.ZiroRacun = salon.ZiroRacun;
            }
            dbcontext.SaveChanges();
        }

        //KONVERZIJE
        //To app model
        private model.Namestaj ToModelNamestaj(Namestaj n)
        {
            return new model.Namestaj
            {
                Aktivan = n.Aktivan == false ? "Neaktivan" : "Aktivan",
                JedinicnaCena = n.JedinicnaCena,
                KolicinaUMagacinu = n.KolicinaUMagacinu.Value,
                Naziv = n.Naziv,
                Sifra = n.Sifra,
                TipNamestaja = (model.TipNamestaja)Enum.Parse(typeof(model.TipNamestaja), n.TipNamestaja.Naziv)
            };
        }

        private model.Korisnik ToModelKorisnik(Korisnik k)
        {
            return new model.Korisnik
            {
                Aktivan = k.Aktivan == false ? "Neaktivan" : "Aktivan",
                Ime = k.Ime,
                KorisnickoIme = k.KorisnickoIme,
                Lozinka = k.Lozinka,
                Prezime = k.Prezime,
                TipKorisnika = (model.TipKorisnika)Enum.Parse(typeof(model.TipKorisnika), k.TipKorisnika.Naziv),
            };
        }

        private model.Akcija ToModelAkcija(Akcija a)
        {
            var akcija = new model.Akcija
            {
                Aktivan = a.Aktivan == false ? "Neaktivan" : "Aktivan",
                Naziv = a.Naziv,
                DatumKraja = a.DatumKraja.Value,
                DatumPocetka = a.DatumPocetka.Value,
            };

            var popusti = new Dictionary<string, int>();
            foreach (var p in a.Popusti)
            {
                popusti.Add(p.Namestaj.Sifra, p.Popust);
            }
            akcija.Popusti = popusti;

            return akcija;
        }

        private model.IstorijaKupovine ToModelIstorijaKupovine(IstorijaKupovine i)
        {
            return new model.IstorijaKupovine
            {
                DatumKupovine = i.DatumKupovine,
                Kolicina = i.Kolicina,
                Korisnik = ToModelKorisnik(i.Korisnik),
                Namestaj = ToModelNamestaj(i.Namestaj)
            };
        }

        private model.Salon ToModelSalon(Salon s)
        {
            return new model.Salon
            {
                Adresa = s.Adresa,
                Aktivan = true,
                Magacin = GetAllNamestaj(),
                Mail = s.Mail,
                MaticniBr = s.MaticniBr,
                Naziv = s.Naziv,
                PIB = s.PIB,
                Sajt = s.Sajt,
                Telefon = s.Telefon,
                ZiroRacun = s.ZiroRacun,
                Akcije = GetAllAkcije(),
                Korisnici = GetAllKorisnici()
            };
        }

        //To database
        private Namestaj ToDbNamestaj(model.Namestaj n)
        {
            return new Namestaj
            {
                Aktivan = n.Aktivan == "Neaktivan" ? false : true,
                JedinicnaCena = n.JedinicnaCena,
                KolicinaUMagacinu = n.KolicinaUMagacinu,
                Naziv = n.Naziv,
                Sifra = n.Sifra,
                TipNamestajaId = FindTipNamestajaId(n.TipNamestaja.ToString())
            };
        }

        private Korisnik ToDbKorisnik(model.Korisnik k)
        {
            return new Korisnik
            {
                Ime = k.Ime,
                KorisnickoIme = k.KorisnickoIme,
                Lozinka = k.Lozinka,
                Prezime = k.Prezime,
                TipKorisnikaId = FindTipkorisnikId(k.TipKorisnika.ToString()),
                Aktivan = k.Aktivan == "Neaktivan" ? false : true,
            };
        }

        private Akcija ToDbAkcija(model.Akcija a)
        {
            var akcija = new Akcija
            {
                Aktivan = a.Aktivan == "Neaktivan" ? false : true,
                Naziv = a.Naziv,
                DatumKraja = a.DatumKraja,
                DatumPocetka = a.DatumPocetka,
            };

            akcija.Popusti = new List<Popusti>();
            foreach (var p in a.Popusti)
            {
                akcija.Popusti.Add(new Popusti
                {
                    AkcijaId = akcija.Id,
                    NamestajId = FindNamestajId(p.Key),
                    Popust = p.Value
                });
            }

            return akcija;
        }

        private IstorijaKupovine ToDbIstorijaKupovine(model.IstorijaKupovine i)
        {
            return new IstorijaKupovine
            {
                DatumKupovine = i.DatumKupovine,
                Kolicina = i.Kolicina,
                KorisnikId = FindKorisnikId(i.Korisnik.KorisnickoIme),
                NamestajId = FindNamestajId(i.Namestaj.Sifra)
            };
        }

        private Salon ToDbSalon(model.Salon s)
        {
            return new Salon
            {
                Adresa = s.Adresa,
                Mail = s.Mail,
                MaticniBr = s.MaticniBr,
                Naziv = s.Naziv,
                PIB = s.PIB,
                Sajt = s.Sajt,
                Telefon = s.Telefon,
                ZiroRacun = s.ZiroRacun,
            };
        }

        private Popusti ToDbPopust(string sifra, int kolicina, int akcijaId)
        {
            return new Popusti
            {
                AkcijaId = akcijaId,
                NamestajId = FindNamestajId(sifra),
                Popust = kolicina
            };
        }

        //Pomocne metode za pronalazenje IDeva
        private int FindNamestajId(string sifra)
        {
            var namestaji = dbcontext.Namestaj;

            foreach (var n in namestaji)
            {
                if (n.Sifra == sifra)
                {
                    return n.Id;
                }
            }

            return -1;
        }

        private int FindTipNamestajaId(string naziv)
        {
            foreach (var tn in dbcontext.TipNamestaja)
            {
                if (tn.Naziv == naziv)
                {
                    return tn.Id;
                }
            }

            return -1;
        }

        private int FindTipkorisnikId(string naziv)
        {
            foreach (var tk in dbcontext.TipKorisnika)
            {
                if (tk.Naziv == naziv)
                {
                    return tk.Id;
                }
            }

            return -1;
        }

        private int FindKorisnikId(string korisnickoIme)
        {
            foreach (var k in dbcontext.Korisnik)
            {
                if (k.KorisnickoIme == korisnickoIme)
                {
                    return k.Id;
                }
            }

            return -1;
        }

        private int FindAkcijaId(string ime)
        {
            foreach (var k in dbcontext.Akcija)
            {
                if (k.Naziv == ime)
                {
                    return k.Id;
                }
            }

            return -1;
        }
    }
}
