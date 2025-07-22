-- KitaplikDB isimli bir database (veritaban�) olu�turuldu.
CREATE DATABASE KitaplikDB

-- USE ile KitaplikDB'ye kod yazmam�z sa�land�.
USE KitaplikDB
--USE ilkDatabase

-- Tablo olu�turmak i�in
CREATE TABLE Kitaplar (
-- Column (kolon) ad�, veritipi, allow null
KitapID int,
KitapAd NVARCHAR(50),
YazarAd NVARCHAR(50),
BasimYili int,
SayfaSayisi int
);

--Kitaplar tablosundaki t�m elemanlar� getirir
SELECT * FROM Kitaplar
SELECT * FROM [KitaplikDB].[dbo].[Kitaplar]
-- �ki sat�r da ayn� sonucu verir.

SELECT TOP (1000) [KitapID]
      ,[KitapAd]
      ,[YazarAd]
      ,[BasimYili]
      ,[SayfaSayisi]
  FROM [KitaplikDB].[dbo].[Kitaplar]
  
-- Bellli kolonlar� ekranda g�stermek istedi�imde
SELECT KitapAd, YazarAd FROM Kitaplar

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (2,'Sefiller', 'Victor Hugo', 1962, 424)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (3,'SQL Giri� E�itimi', 'Tugay Tuna', 2025, 120)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (4,'Veritaban� Y�netimi', 'Ercan Bozkurt', 2023, 345)

-- KitapID'ye g�re filtreleme
SELECT * FROM Kitaplar WHERE KitapID = 1

SELECT * FROM Kitaplar WHERE BasimYili < 2000

SELECT KitapAd, BasimYili FROM Kitaplar WHERE SayfaSayisi < 500

-- Kitaplar tablosundaki, sayfa say�s� de�erini g�ncelle, kural olarak; KitapId'sine g�re.
UPDATE Kitaplar SET SayfaSayisi = 945 WHERE KitapID = 2

-- Kitaplar tablosunda BasimYili de�erine sat�rlar� silme kodu
DELETE FROM Kitaplar WHERE BasimYili > 2000

--K���kten b�y�ye do�ru s�ralama - veritaban�n� etkilemez sadece listelemek i�in kullan�l�r
SELECT * FROM Kitaplar ORDER BY SayfaSayisi
