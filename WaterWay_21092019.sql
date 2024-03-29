USE [WaterWay]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[AdminID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[Parola] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[AdminID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Adres]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Adres](
	[AdresID] [int] IDENTITY(1,1) NOT NULL,
	[Il] [nvarchar](30) NOT NULL,
	[Ilce] [nvarchar](30) NOT NULL,
	[Mahalle] [nvarchar](50) NOT NULL,
	[Sokak] [nvarchar](50) NULL,
	[ApartNo] [int] NOT NULL,
	[DaireNo] [int] NOT NULL,
 CONSTRAINT [PK_Adres] PRIMARY KEY CLUSTERED 
(
	[AdresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Müsteri]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Müsteri](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriAd] [nvarchar](30) NOT NULL,
	[MusteriSoyad] [nvarchar](30) NOT NULL,
	[Mail] [nvarchar](40) NOT NULL,
	[Parola] [nvarchar](16) NOT NULL,
	[AdresID] [int] NULL,
 CONSTRAINT [PK_Müsteri] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[SiparisID] [int] IDENTITY(1,1) NOT NULL,
	[SiparisZamani] [datetime] NULL,
	[TeslimZamani] [datetime] NULL,
	[MusteriID] [int] NULL,
	[SiparisTutar] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[SiparisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparisUrun]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisUrun](
	[SiparisID] [int] NOT NULL,
	[UrunID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sirket]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sirket](
	[SirketID] [int] IDENTITY(1,1) NOT NULL,
	[SirketAdi] [nvarchar](30) NULL,
	[Mail] [nvarchar](50) NULL,
	[Parola] [nvarchar](50) NULL,
	[SirketAdresID] [int] NULL,
 CONSTRAINT [PK_Sirket] PRIMARY KEY CLUSTERED 
(
	[SirketID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SirketAdres]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SirketAdres](
	[SirketAdresID] [int] IDENTITY(1,1) NOT NULL,
	[Mahalle] [varchar](30) NULL,
	[Sokak] [varchar](30) NULL,
	[Ilce] [varchar](30) NOT NULL,
	[Il] [varchar](30) NOT NULL,
 CONSTRAINT [PK_SirketAdres] PRIMARY KEY CLUSTERED 
(
	[SirketAdresID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SirketUrun]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SirketUrun](
	[SirketID] [int] NOT NULL,
	[UrunID] [int] NULL,
	[SirketUrunID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_SirketUrun] PRIMARY KEY CLUSTERED 
(
	[SirketUrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 21.09.2019 18:36:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[UrunID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](50) NULL,
	[UrunUcreti] [decimal](18, 0) NULL,
	[UrunBoyut] [float] NULL,
	[UrunStok] [int] NULL,
 CONSTRAINT [PK_Urun] PRIMARY KEY CLUSTERED 
(
	[UrunID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([AdminID], [KullaniciAdi], [Parola]) VALUES (1, N'Admin', N'1234')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Adres] ON 

INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (1, N'İstanbul', N'Besiktas', N'Abbasağa', NULL, 46, 3)
INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (2, N'Ankara', N'Cebeci', N'Atatürk', N'Cumhuriyet', 34, 1)
INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (3, N'istanbul', N'besiktas', N'abbasğa', N'bjk', 46, 3)
INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (5, N'sadasd', N'asdsad', N'sadasd', N'sadsad', 1, 123)
INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (1004, N'asdasd', N'asdasdas', N'asdasd', N'asdasd', 12, 12)
INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (1005, N'asdasd', N'asdasdas', N'asdasd', N'asdasd', 12, 12)
INSERT [dbo].[Adres] ([AdresID], [Il], [Ilce], [Mahalle], [Sokak], [ApartNo], [DaireNo]) VALUES (1006, N'asdasd', N'asdasdas', N'asdasd', N'asdasd', 12, 12)
SET IDENTITY_INSERT [dbo].[Adres] OFF
SET IDENTITY_INSERT [dbo].[Müsteri] ON 

INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (1, N'Mehmet', N'Polat', N'mehmeteminpolat3@gmail.com', N'12345', 1)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (2, N'Hasan', N'Sayir', N'hasan@hasan.com', N'12345', 2)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (3, N'asd', N'asd', N'sadasd', N'123123', 1)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (6, N'asdasdasd', N'asdasd', N'mehmet.mehmet', N'12345', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (7, N'asdasdasd', N'asdasd', N'mehmet.mehmet', N'12345', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (8, N'sad', N'asdasd', N'asd', N'123123', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (14, N'q', N'q', N'q', N'q', 1)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (15, N'asdasd', N'asdasda', N'asdad123', N'123123', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (16, N'asdasd', N'asdasda', N'asdad123', N'123123', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (17, N'xcasd', N'asdasd', N'adsasd', N'123131', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (18, N'Lucky', N'day', N'q', N'1234', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (19, N'yeliz reyis', N'dilara', N'sadsad', N'1234', NULL)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (20, N'hasan reyis', N'mehmet', N'asdasd', N'1234', 5)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (1019, N'eyüp', N'polat', N'asdasd', N'123123', 1004)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (1020, N'eyüp', N'polat', N'eyüp', N'123123', 1005)
INSERT [dbo].[Müsteri] ([MusteriID], [MusteriAd], [MusteriSoyad], [Mail], [Parola], [AdresID]) VALUES (1021, N'eyüp', N'polat', N'eyüp', N'12345', 1006)
SET IDENTITY_INSERT [dbo].[Müsteri] OFF
SET IDENTITY_INSERT [dbo].[Siparis] ON 

INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (1, CAST(N'2019-02-21T00:00:00.000' AS DateTime), CAST(N'2019-03-21T00:00:00.000' AS DateTime), 1, NULL)
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (2, CAST(N'2019-09-16T15:52:45.203' AS DateTime), CAST(N'2019-09-16T15:52:38.403' AS DateTime), 1, CAST(30 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (3, CAST(N'2019-09-16T15:53:40.880' AS DateTime), CAST(N'2019-09-27T15:53:23.000' AS DateTime), 2, CAST(60 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (4, CAST(N'2019-09-16T16:08:31.207' AS DateTime), CAST(N'2019-09-16T16:08:24.027' AS DateTime), 14, CAST(2 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (5, CAST(N'2019-09-16T16:36:57.287' AS DateTime), CAST(N'2019-09-16T16:36:29.287' AS DateTime), 14, CAST(27 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (6, CAST(N'2019-09-16T16:38:29.437' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (7, CAST(N'2019-09-16T16:39:11.867' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (8, CAST(N'2019-09-16T16:39:24.853' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (9, CAST(N'2019-09-16T16:39:28.060' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (10, CAST(N'2019-09-16T16:39:29.670' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (11, CAST(N'2019-09-16T16:39:31.243' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (12, CAST(N'2019-09-16T16:39:32.733' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
INSERT [dbo].[Siparis] ([SiparisID], [SiparisZamani], [TeslimZamani], [MusteriID], [SiparisTutar]) VALUES (13, CAST(N'2019-09-16T16:40:43.550' AS DateTime), CAST(N'2019-09-26T16:38:18.000' AS DateTime), 14, CAST(36 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Siparis] OFF
SET IDENTITY_INSERT [dbo].[Sirket] ON 

INSERT [dbo].[Sirket] ([SirketID], [SirketAdi], [Mail], [Parola], [SirketAdresID]) VALUES (1, N'Polat A.Ş', N'polat@polat.com', N'1234', 1)
INSERT [dbo].[Sirket] ([SirketID], [SirketAdi], [Mail], [Parola], [SirketAdresID]) VALUES (18, N'a', N'a', N'a', 11)
INSERT [dbo].[Sirket] ([SirketID], [SirketAdi], [Mail], [Parola], [SirketAdresID]) VALUES (21, N'b', N'b', N'b', 12)
INSERT [dbo].[Sirket] ([SirketID], [SirketAdi], [Mail], [Parola], [SirketAdresID]) VALUES (22, N'c', N'c', N'c', 13)
SET IDENTITY_INSERT [dbo].[Sirket] OFF
SET IDENTITY_INSERT [dbo].[SirketAdres] ON 

INSERT [dbo].[SirketAdres] ([SirketAdresID], [Mahalle], [Sokak], [Ilce], [Il]) VALUES (1, N'sadad', N'asdasd', N'asdasd', N'asdsad')
INSERT [dbo].[SirketAdres] ([SirketAdresID], [Mahalle], [Sokak], [Ilce], [Il]) VALUES (11, N'a', N'a', N'a', N'a')
INSERT [dbo].[SirketAdres] ([SirketAdresID], [Mahalle], [Sokak], [Ilce], [Il]) VALUES (12, N'b', N'b', N'b', N'b')
INSERT [dbo].[SirketAdres] ([SirketAdresID], [Mahalle], [Sokak], [Ilce], [Il]) VALUES (13, N'c', N'c', N'c', N'c')
SET IDENTITY_INSERT [dbo].[SirketAdres] OFF
SET IDENTITY_INSERT [dbo].[SirketUrun] ON 

INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (1, 1, 1)
INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (18, 2, 2)
INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (18, 3, 3)
INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (18, 4, 4)
INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (18, 5, 5)
INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (1, 2, 6)
INSERT [dbo].[SirketUrun] ([SirketID], [UrunID], [SirketUrunID]) VALUES (18, 1009, 7)
SET IDENTITY_INSERT [dbo].[SirketUrun] OFF
SET IDENTITY_INSERT [dbo].[Urun] ON 

INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1, N'Su', CAST(2 AS Decimal(18, 0)), 1, 10)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (2, N'Damacana', CAST(10 AS Decimal(18, 0)), 19, 1000)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (3, N'Cam şişe', CAST(1 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (4, N'onlitre', CAST(12 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (5, N'mehmet', CAST(12 AS Decimal(18, 0)), 12, 12)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (6, N'mehmet', CAST(12 AS Decimal(18, 0)), 12, 12)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1003, N'yeliz reyis', CAST(12 AS Decimal(18, 0)), 1, 1)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1005, N'dsdsf', CAST(12 AS Decimal(18, 0)), 1, 12)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1006, N'kitap', CAST(12 AS Decimal(18, 0)), 19, 399)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1007, N'Cam su', CAST(3 AS Decimal(18, 0)), 1, 50)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1008, N'Damacana', CAST(10 AS Decimal(18, 0)), 19, 1000)
INSERT [dbo].[Urun] ([UrunID], [UrunAdi], [UrunUcreti], [UrunBoyut], [UrunStok]) VALUES (1009, N'qwe', CAST(123 AS Decimal(18, 0)), 12, 10)
SET IDENTITY_INSERT [dbo].[Urun] OFF
ALTER TABLE [dbo].[Müsteri]  WITH CHECK ADD  CONSTRAINT [FK_Müsteri_Adres] FOREIGN KEY([AdresID])
REFERENCES [dbo].[Adres] ([AdresID])
GO
ALTER TABLE [dbo].[Müsteri] CHECK CONSTRAINT [FK_Müsteri_Adres]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Müsteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Müsteri] ([MusteriID])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Müsteri]
GO
ALTER TABLE [dbo].[SiparisUrun]  WITH CHECK ADD  CONSTRAINT [FK_SiparisUrun_Siparis] FOREIGN KEY([SiparisID])
REFERENCES [dbo].[Siparis] ([SiparisID])
GO
ALTER TABLE [dbo].[SiparisUrun] CHECK CONSTRAINT [FK_SiparisUrun_Siparis]
GO
ALTER TABLE [dbo].[SiparisUrun]  WITH CHECK ADD  CONSTRAINT [FK_SiparisUrun_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[SiparisUrun] CHECK CONSTRAINT [FK_SiparisUrun_Urun]
GO
ALTER TABLE [dbo].[Sirket]  WITH CHECK ADD  CONSTRAINT [FK_Sirket_SirketAdres] FOREIGN KEY([SirketAdresID])
REFERENCES [dbo].[SirketAdres] ([SirketAdresID])
GO
ALTER TABLE [dbo].[Sirket] CHECK CONSTRAINT [FK_Sirket_SirketAdres]
GO
ALTER TABLE [dbo].[SirketUrun]  WITH CHECK ADD  CONSTRAINT [FK_SirketUrun_Sirket] FOREIGN KEY([SirketID])
REFERENCES [dbo].[Sirket] ([SirketID])
GO
ALTER TABLE [dbo].[SirketUrun] CHECK CONSTRAINT [FK_SirketUrun_Sirket]
GO
ALTER TABLE [dbo].[SirketUrun]  WITH CHECK ADD  CONSTRAINT [FK_SirketUrun_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([UrunID])
GO
ALTER TABLE [dbo].[SirketUrun] CHECK CONSTRAINT [FK_SirketUrun_Urun]
GO
