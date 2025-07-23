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

-- Yeni bir satýr eklemek için INSERT INTO kodu kullanýlýr.
INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (2,'Sefiller', 'Victor Hugo', 1962, 424)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (3,'SQL Giriþ Eðitimi', 'Tugay Tuna', 2025, 120)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (4,'Veritabaný Yönetimi2', 'Ercan Bozkurt', 2023, 345)

-- KitapID'ye göre filtreleme
SELECT * FROM Kitaplar WHERE KitapID = 1
SELECT * FROM Kitaplar WHERE BasimYili < 2000
SELECT * FROM Kitaplar WHERE YazarAd = 'Ercan Bozkurt'


USE KitaplikDB
-- Sayfa sayýsý 500'den küçük olan satýrlarý getir ve sadece KitapAd ve BasimYili kolonlarýyla listele
SELECT KitapAd, BasimYili FROM Kitaplar WHERE SayfaSayisi < 500

-- Kitaplar tablosundaki, sayfa sayýsý deðerini güncelle, kural olarak; KitapId'sine göre.
UPDATE Kitaplar SET SayfaSayisi = 945 WHERE KitapID = 2
UPDATE Kitaplar SET SayfaSayisi = 950 WHERE KitapAd = 'Sefiller'

SELECT * FROM Kitaplar
-- Kitaplar tablosunda BasimYili deðerine satýrlarý silme kodu
DELETE FROM Kitaplar WHERE BasimYili > 2000
DELETE FROM Kitaplar WHERE KitapAd = 'Veritabaný Yönetimi2'

--Küçükten büyüye doðru sýralama - veritabanýný etkilemez sadece listelemek için kullanýlýr (A-Z)
SELECT * FROM Kitaplar ORDER BY SayfaSayisi
SELECT * FROM Kitaplar ORDER BY SayfaSayisi ASC
SELECT * FROM Kitaplar ORDER BY YazarAd

--Büyükten küçüðe doðru sýralama (Z-A)
SELECT * FROM Kitaplar ORDER BY SayfaSayisi DESC

SELECT * FROM Kitaplar 
WHERE YazarAd = 'Ercan Bozkurt'  
ORDER BY SayfaSayisi DESC

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) 
VALUES (54,'Fareler Ve Ýnsanlar', 'John Steinbeck', 2012, 111)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) 
VALUES (24, 'Kýrmýzý Pazartesi', 'Ahmet Ümit', 2000, 450)

-- Kitaplar tablosunu KitapID'ye göre sýrala.
SELECT * FROM Kitaplar ORDER BY KitapID

-- KitapAd deðeri 'Fareler ve Ýnsanlar' olan deðerin KitapID'sini 7 yap
UPDATE Kitaplar 
SET KitapID = 7 
WHERE KitapAd = 'Fareler ve Ýnsanlar'

-- AND Kullanarak birden fazla koþul ifadesi ekleyebiliyoruz. (VE - AND)
SELECT KitapID,KitapAd, YazarAd FROM Kitaplar 
WHERE BasimYili > 2000 AND SayfaSayisi > 150

-- Okundu = 1 veya SayfaSayýsý 400'den küçük ise getir. (VEYA - OR)
SELECT * FROM Kitaplar 
WHERE Okundu = 1 OR SayfaSayisi < 400

-- WHERE NOT - Koþul doðru deðilse
SELECT * FROM Kitaplar
WHERE NOT Okundu = 1

UPDATE Kitaplar
SET Okundu = 1
WHERE KitapAd = 'Veritabaný Yönetimi'

-- A ile baþlayan yazarlarý getiriyor
SELECT * FROM Kitaplar
WHERE YazarAd LIKE 'a%'

-- Sayfa sayýsý 1 ile baþlayanlarý getiriyor
SELECT * FROM Kitaplar
WHERE SayfaSayisi LIKE '1%'

-- Sayfa sayýsý 200'den büyük 500'den küçük olan satýrlarý getirdi.
SELECT * FROM Kitaplar 
WHERE SayfaSayisi > 200 AND SayfaSayisi < 500

-- Sayfa sayýsý 200 ile 500 arasýndaki satýrlarý getirdi.
SELECT * FROM Kitaplar
WHERE SayfaSayisi BETWEEN 200 AND 500

-- Basým yýlý 2000 ile 2025 arasýndakileri getirdi
SELECT * FROM Kitaplar
WHERE BasimYili BETWEEN 2000 AND 2025

-- YazarAd deðeri Tugay Tuna veya Ercan Bozkurt olanlarý getirdi.
SELECT * FROM Kitaplar 
WHERE YazarAd = 'Tugay Tuna' OR YazarAd = 'Ercan Bozkurt'

-- YazarAd deðeri Tugay Tuna veya Ercan Bozkurt olanlarý getirdi.
SELECT * FROM Kitaplar
WHERE YazarAd IN ('Tugay Tuna', 'Ercan Bozkurt')


UPDATE Kitaplar
SET BasimYili = 1995
WHERE KitapID = 7