USE [POP]
GO
/****** Object:  Table [dbo].[Akcija]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Akcija](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](255) NOT NULL,
	[DatumPocetka] [datetime] NULL,
	[DatumKraja] [datetime] NULL,
	[Aktivan] [bit] NOT NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[IstorijaKupovine]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IstorijaKupovine](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KorisnikId] [int] NOT NULL,
	[NamestajId] [int] NOT NULL,
	[Kolicina] [int] NOT NULL,
	[DatumKupovine] [datetime] NOT NULL,
 CONSTRAINT [PK_IstorijaKupovine] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Korisnik]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Korisnik](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [nvarchar](50) NOT NULL,
	[Prezime] [nvarchar](50) NOT NULL,
	[KorisnickoIme] [nvarchar](50) NOT NULL,
	[Lozinka] [nvarchar](50) NOT NULL,
	[TipKorisnikaId] [int] NOT NULL,
	[Aktivan] [bit] NULL,
 CONSTRAINT [PK_Korisnik] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Namestaj]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Namestaj](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Sifra] [nvarchar](50) NOT NULL,
	[JedinicnaCena] [decimal](10, 3) NOT NULL,
	[KolicinaUMagacinu] [bigint] NULL,
	[TipNamestajaId] [int] NOT NULL,
	[Aktivan] [bit] NOT NULL,
 CONSTRAINT [PK_Namestaj] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Popusti]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Popusti](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NamestajId] [int] NOT NULL,
	[Popust] [int] NOT NULL,
	[AkcijaId] [int] NULL,
 CONSTRAINT [PK_Popusti] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Salon]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Salon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](255) NOT NULL,
	[Adresa] [nvarchar](255) NOT NULL,
	[Telefon] [nvarchar](255) NULL,
	[Mail] [nvarchar](255) NULL,
	[Sajt] [nvarchar](255) NULL,
	[PIB] [nvarchar](255) NOT NULL,
	[MaticniBr] [nvarchar](255) NOT NULL,
	[ZiroRacun] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Salon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipKorisnika]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipKorisnika](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](20) NULL,
 CONSTRAINT [PK_TipKorisnika] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipNamestaja]    Script Date: 1/11/2018 5:55:01 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipNamestaja](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](80) NOT NULL,
	[Obrisan] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Akcija] ON 

GO
INSERT [dbo].[Akcija] ([Id], [Naziv], [DatumPocetka], [DatumKraja], [Aktivan]) VALUES (1, N'Shok akcija - Januar 2018', CAST(0x0000A85B00000000 AS DateTime), CAST(0x0000A87900000000 AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Akcija] OFF
GO
SET IDENTITY_INSERT [dbo].[Korisnik] ON 

GO
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [KorisnickoIme], [Lozinka], [TipKorisnikaId], [Aktivan]) VALUES (1, N'Administrator', N'Administrator', N'admin', N'123456', 1, 1)
GO
INSERT [dbo].[Korisnik] ([Id], [Ime], [Prezime], [KorisnickoIme], [Lozinka], [TipKorisnikaId], [Aktivan]) VALUES (2, N'Prodavac', N'Test', N'prodavac', N'123456', 2, 1)
GO
SET IDENTITY_INSERT [dbo].[Korisnik] OFF
GO
SET IDENTITY_INSERT [dbo].[Namestaj] ON 

GO
INSERT [dbo].[Namestaj] ([Id], [Naziv], [Sifra], [JedinicnaCena], [KolicinaUMagacinu], [TipNamestajaId], [Aktivan]) VALUES (14, N'Stolica', N'st12', CAST(3000.000 AS Decimal(10, 3)), 10, 3, 1)
GO
INSERT [dbo].[Namestaj] ([Id], [Naziv], [Sifra], [JedinicnaCena], [KolicinaUMagacinu], [TipNamestajaId], [Aktivan]) VALUES (15, N'Bracni krevet', N'bk5', CAST(40000.000 AS Decimal(10, 3)), 15, 1, 1)
GO
INSERT [dbo].[Namestaj] ([Id], [Naziv], [Sifra], [JedinicnaCena], [KolicinaUMagacinu], [TipNamestajaId], [Aktivan]) VALUES (16, N'Cipelarnik', N'cp43', CAST(7480.000 AS Decimal(10, 3)), 3, 2, 1)
GO
INSERT [dbo].[Namestaj] ([Id], [Naziv], [Sifra], [JedinicnaCena], [KolicinaUMagacinu], [TipNamestajaId], [Aktivan]) VALUES (17, N'Viseca Kuhinja', N'vk24', CAST(12300.000 AS Decimal(10, 3)), 6, 3, 1)
GO
SET IDENTITY_INSERT [dbo].[Namestaj] OFF
GO
SET IDENTITY_INSERT [dbo].[Popusti] ON 

GO
INSERT [dbo].[Popusti] ([Id], [NamestajId], [Popust], [AkcijaId]) VALUES (1, 14, 30, 1)
GO
INSERT [dbo].[Popusti] ([Id], [NamestajId], [Popust], [AkcijaId]) VALUES (2, 16, 30, 1)
GO
INSERT [dbo].[Popusti] ([Id], [NamestajId], [Popust], [AkcijaId]) VALUES (3, 17, 30, 1)
GO
SET IDENTITY_INSERT [dbo].[Popusti] OFF
GO
SET IDENTITY_INSERT [dbo].[Salon] ON 

GO
INSERT [dbo].[Salon] ([Id], [Naziv], [Adresa], [Telefon], [Mail], [Sajt], [PIB], [MaticniBr], [ZiroRacun]) VALUES (2, N'Salon Aleksandar', N'Licka 14', N'012343245345', N'test@test.com', N'www.test.com', N'123456', N'1234567', N'123-1234567890-23')
GO
SET IDENTITY_INSERT [dbo].[Salon] OFF
GO
SET IDENTITY_INSERT [dbo].[TipKorisnika] ON 

GO
INSERT [dbo].[TipKorisnika] ([Id], [Naziv]) VALUES (1, N'Administrator')
GO
INSERT [dbo].[TipKorisnika] ([Id], [Naziv]) VALUES (2, N'Prodavac')
GO
SET IDENTITY_INSERT [dbo].[TipKorisnika] OFF
GO
SET IDENTITY_INSERT [dbo].[TipNamestaja] ON 

GO
INSERT [dbo].[TipNamestaja] ([Id], [Naziv], [Obrisan]) VALUES (1, N'Kreveti', 0)
GO
INSERT [dbo].[TipNamestaja] ([Id], [Naziv], [Obrisan]) VALUES (2, N'Predsoblje', 0)
GO
INSERT [dbo].[TipNamestaja] ([Id], [Naziv], [Obrisan]) VALUES (3, N'Kuhinja', 0)
GO
SET IDENTITY_INSERT [dbo].[TipNamestaja] OFF
GO
ALTER TABLE [dbo].[IstorijaKupovine]  WITH CHECK ADD  CONSTRAINT [FK_IstorijaKupovine_Korisnik] FOREIGN KEY([KorisnikId])
REFERENCES [dbo].[Korisnik] ([Id])
GO
ALTER TABLE [dbo].[IstorijaKupovine] CHECK CONSTRAINT [FK_IstorijaKupovine_Korisnik]
GO
ALTER TABLE [dbo].[IstorijaKupovine]  WITH CHECK ADD  CONSTRAINT [FK_IstorijaKupovine_Namestaj] FOREIGN KEY([NamestajId])
REFERENCES [dbo].[Namestaj] ([Id])
GO
ALTER TABLE [dbo].[IstorijaKupovine] CHECK CONSTRAINT [FK_IstorijaKupovine_Namestaj]
GO
ALTER TABLE [dbo].[Korisnik]  WITH CHECK ADD  CONSTRAINT [FK_Korisnik_TipKorisnika] FOREIGN KEY([TipKorisnikaId])
REFERENCES [dbo].[TipKorisnika] ([Id])
GO
ALTER TABLE [dbo].[Korisnik] CHECK CONSTRAINT [FK_Korisnik_TipKorisnika]
GO
ALTER TABLE [dbo].[Popusti]  WITH CHECK ADD  CONSTRAINT [FK_Popusti_Akcija] FOREIGN KEY([AkcijaId])
REFERENCES [dbo].[Akcija] ([Id])
GO
ALTER TABLE [dbo].[Popusti] CHECK CONSTRAINT [FK_Popusti_Akcija]
GO
ALTER TABLE [dbo].[Popusti]  WITH CHECK ADD  CONSTRAINT [FK_Popusti_ToTable] FOREIGN KEY([NamestajId])
REFERENCES [dbo].[Namestaj] ([Id])
GO
ALTER TABLE [dbo].[Popusti] CHECK CONSTRAINT [FK_Popusti_ToTable]
GO
