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

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (4,'Veritabaný Yönetimi', 'Ercan Bozkurt', 2023, 345)

-- KitapID'ye göre filtreleme
SELECT * FROM Kitaplar WHERE KitapID = 1

SELECT * FROM Kitaplar WHERE BasimYili < 2000

SELECT KitapAd, BasimYili FROM Kitaplar WHERE SayfaSayisi < 500

-- Kitaplar tablosundaki, sayfa sayýsý deðerini güncelle, kural olarak; KitapId'sine göre.
UPDATE Kitaplar SET SayfaSayisi = 945 WHERE KitapID = 2

-- Kitaplar tablosunda BasimYili deðerine satýrlarý silme kodu
DELETE FROM Kitaplar WHERE BasimYili > 2000

--Küçükten büyüye doðru sýralama - veritabanýný etkilemez sadece listelemek için kullanýlýr
SELECT * FROM Kitaplar ORDER BY SayfaSayisi
