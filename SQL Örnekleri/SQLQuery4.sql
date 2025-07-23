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

-- Yeni bir sat�r eklemek i�in INSERT INTO kodu kullan�l�r.
INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (2,'Sefiller', 'Victor Hugo', 1962, 424)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (3,'SQL Giri� E�itimi', 'Tugay Tuna', 2025, 120)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) VALUES (4,'Veritaban� Y�netimi2', 'Ercan Bozkurt', 2023, 345)

-- KitapID'ye g�re filtreleme
SELECT * FROM Kitaplar WHERE KitapID = 1
SELECT * FROM Kitaplar WHERE BasimYili < 2000
SELECT * FROM Kitaplar WHERE YazarAd = 'Ercan Bozkurt'


USE KitaplikDB
-- Sayfa say�s� 500'den k���k olan sat�rlar� getir ve sadece KitapAd ve BasimYili kolonlar�yla listele
SELECT KitapAd, BasimYili FROM Kitaplar WHERE SayfaSayisi < 500

-- Kitaplar tablosundaki, sayfa say�s� de�erini g�ncelle, kural olarak; KitapId'sine g�re.
UPDATE Kitaplar SET SayfaSayisi = 945 WHERE KitapID = 2
UPDATE Kitaplar SET SayfaSayisi = 950 WHERE KitapAd = 'Sefiller'

SELECT * FROM Kitaplar
-- Kitaplar tablosunda BasimYili de�erine sat�rlar� silme kodu
DELETE FROM Kitaplar WHERE BasimYili > 2000
DELETE FROM Kitaplar WHERE KitapAd = 'Veritaban� Y�netimi2'

--K���kten b�y�ye do�ru s�ralama - veritaban�n� etkilemez sadece listelemek i�in kullan�l�r (A-Z)
SELECT * FROM Kitaplar ORDER BY SayfaSayisi
SELECT * FROM Kitaplar ORDER BY SayfaSayisi ASC
SELECT * FROM Kitaplar ORDER BY YazarAd

--B�y�kten k����e do�ru s�ralama (Z-A)
SELECT * FROM Kitaplar ORDER BY SayfaSayisi DESC

SELECT * FROM Kitaplar 
WHERE YazarAd = 'Ercan Bozkurt'  
ORDER BY SayfaSayisi DESC

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) 
VALUES (54,'Fareler Ve �nsanlar', 'John Steinbeck', 2012, 111)

INSERT INTO Kitaplar (KitapID, KitapAd, YazarAd, BasimYili, SayfaSayisi) 
VALUES (24, 'K�rm�z� Pazartesi', 'Ahmet �mit', 2000, 450)

-- Kitaplar tablosunu KitapID'ye g�re s�rala.
SELECT * FROM Kitaplar ORDER BY KitapID

-- KitapAd de�eri 'Fareler ve �nsanlar' olan de�erin KitapID'sini 7 yap
UPDATE Kitaplar 
SET KitapID = 7 
WHERE KitapAd = 'Fareler ve �nsanlar'

-- AND Kullanarak birden fazla ko�ul ifadesi ekleyebiliyoruz. (VE - AND)
SELECT KitapID,KitapAd, YazarAd FROM Kitaplar 
WHERE BasimYili > 2000 AND SayfaSayisi > 150

-- Okundu = 1 veya SayfaSay�s� 400'den k���k ise getir. (VEYA - OR)
SELECT * FROM Kitaplar 
WHERE Okundu = 1 OR SayfaSayisi < 400

-- WHERE NOT - Ko�ul do�ru de�ilse
SELECT * FROM Kitaplar
WHERE NOT Okundu = 1

UPDATE Kitaplar
SET Okundu = 1
WHERE KitapAd = 'Veritaban� Y�netimi'

-- A ile ba�layan yazarlar� getiriyor
SELECT * FROM Kitaplar
WHERE YazarAd LIKE 'a%'

-- Sayfa say�s� 1 ile ba�layanlar� getiriyor
SELECT * FROM Kitaplar
WHERE SayfaSayisi LIKE '1%'

-- Sayfa say�s� 200'den b�y�k 500'den k���k olan sat�rlar� getirdi.
SELECT * FROM Kitaplar 
WHERE SayfaSayisi > 200 AND SayfaSayisi < 500

-- Sayfa say�s� 200 ile 500 aras�ndaki sat�rlar� getirdi.
SELECT * FROM Kitaplar
WHERE SayfaSayisi BETWEEN 200 AND 500

-- Bas�m y�l� 2000 ile 2025 aras�ndakileri getirdi
SELECT * FROM Kitaplar
WHERE BasimYili BETWEEN 2000 AND 2025

-- YazarAd de�eri Tugay Tuna veya Ercan Bozkurt olanlar� getirdi.
SELECT * FROM Kitaplar 
WHERE YazarAd = 'Tugay Tuna' OR YazarAd = 'Ercan Bozkurt'

-- YazarAd de�eri Tugay Tuna veya Ercan Bozkurt olanlar� getirdi.
SELECT * FROM Kitaplar
WHERE YazarAd IN ('Tugay Tuna', 'Ercan Bozkurt')


UPDATE Kitaplar
SET BasimYili = 1995
WHERE KitapID = 7