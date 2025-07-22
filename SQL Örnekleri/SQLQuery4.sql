-- KitaplikDB isimli bir database (veritabaný) oluþturuldu.
CREATE DATABASE KitaplikDB

-- USE ile KitaplikDB'ye kod yazmamýz saðlandý.
USE KitaplikDB
--USE ilkDatabase

-- Tablo oluþturmak için
CREATE TABLE Kitaplar (
-- Column (kolon) adý, veritipi, allow null
KitapID int,
KitapAd NVARCHAR(50),
YazarAd NVARCHAR(50),
BasimYili int,
SayfaSayisi int
);

--Kitaplar tablosundaki tüm elemanlarý getirir
SELECT * FROM Kitaplar
SELECT * FROM [KitaplikDB].[dbo].[Kitaplar]
-- Ýki satýr da ayný sonucu verir.

SELECT TOP (1000) [KitapID]
      ,[KitapAd]
      ,[YazarAd]
      ,[BasimYili]
      ,[SayfaSayisi]
  FROM [KitaplikDB].[dbo].[Kitaplar]
  
-- Bellli kolonlarý ekranda göstermek istediðimde
SELECT KitapAd, YazarAd FROM Kitaplar

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (2,'Sefiller', 'Victor Hugo', 1962, 424)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (3,'SQL Giriþ Eðitimi', 'Tugay Tuna', 2025, 120)

SELECT * FROM Kitaplar WHERE KitapID = 1

SELECT * FROM Kitaplar WHERE BasimYili < 2000

SELECT KitapAd, BasimYili FROM Kitaplar WHERE SayfaSayisi < 500
