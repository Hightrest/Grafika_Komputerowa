CREATE TABLE [Kategorie] (
	Id_Kategorii integer NOT NULL,
	Nazwa_kategorii char(50) NOT NULL UNIQUE,
  CONSTRAINT [PK_KATEGORIE] PRIMARY KEY CLUSTERED
  (
  [Id_Kategorii] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Zamowienia] (
	Id_Zamowienia integer NOT NULL,
	Id_Kategorii integer NOT NULL,
	Koszt integer NOT NULL,
  CONSTRAINT [PK_ZAMOWIENIA] PRIMARY KEY CLUSTERED
  (
  [Id_Zamowienia] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Dane_Adresowe] (
	Id_Adresowe integer NOT NULL,
	Ulica char(50) NOT NULL,
	Adres char(50) NOT NULL,
	Misato char(60) NOT NULL,
	Kod_pocztowy char(15) NOT NULL,
	Kraj varchar(40) NOT NULL,
  CONSTRAINT [PK_DANE_ADRESOWE] PRIMARY KEY CLUSTERED
  (
  [Id_Adresowe] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Klienci] (
	Id_Klienta integer NOT NULL,
	Imie char(60) NOT NULL,
	Nazwisko char(60) NOT NULL,
	Id_Adresowe integer NOT NULL,
	Numer_telefonu char(15) NOT NULL,
	Email varchar(40) NOT NULL,
	Pesel varchar(15),
  CONSTRAINT [PK_KLIENCI] PRIMARY KEY CLUSTERED
  (
  [Id_Klienta] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Faktury] (
	Id_Faktury integer NOT NULL,
	Id_Klienta integer NOT NULL,
	Id_Zamówienia integer NOT NULL,
	Termin_do_zaplaty date NOT NULL,
	Id_Bonusu integer,
	Kwota_do_zaplaty integer NOT NULL,
	Data_wplaty date NOT NULL,
  CONSTRAINT [PK_FAKTURY] PRIMARY KEY CLUSTERED
  (
  [Id_Faktury] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [Bonusy] (
	Id_Bonusu integer NOT NULL,
	Nazwa_bonusu char(100) NOT NULL,
	Wartosc_bonusu char(60) NOT NULL,
  CONSTRAINT [PK_BONUSY] PRIMARY KEY CLUSTERED
  (
  [Id_Bonusu] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [Zamowienia] WITH CHECK ADD CONSTRAINT [Zamowienia_fk0] FOREIGN KEY ([Id_Kategorii]) REFERENCES [Kategorie]([Id_Kategorii])
ON UPDATE CASCADE
GO
ALTER TABLE [Zamowienia] CHECK CONSTRAINT [Zamowienia_fk0]
GO


ALTER TABLE [Klienci] WITH CHECK ADD CONSTRAINT [Klienci_fk0] FOREIGN KEY ([Id_Adresowe]) REFERENCES [Dane_Adresowe]([Id_Adresowe])
ON UPDATE CASCADE
GO
ALTER TABLE [Klienci] CHECK CONSTRAINT [Klienci_fk0]
GO

ALTER TABLE [Faktury] WITH CHECK ADD CONSTRAINT [Faktury_fk0] FOREIGN KEY ([Id_Klienta]) REFERENCES [Klienci]([Id_Klienta])
ON UPDATE CASCADE
GO
ALTER TABLE [Faktury] CHECK CONSTRAINT [Faktury_fk0]
GO
ALTER TABLE [Faktury] WITH CHECK ADD CONSTRAINT [Faktury_fk1] FOREIGN KEY ([Id_Zamówienia]) REFERENCES [Zamowienia]([Id_Zamowienia])
ON UPDATE CASCADE
GO
ALTER TABLE [Faktury] CHECK CONSTRAINT [Faktury_fk1]
GO
ALTER TABLE [Faktury] WITH CHECK ADD CONSTRAINT [Faktury_fk2] FOREIGN KEY ([Id_Bonusu]) REFERENCES [Bonusy]([Id_Bonusu])
ON UPDATE CASCADE
GO
ALTER TABLE [Faktury] CHECK CONSTRAINT [Faktury_fk2]
GO


