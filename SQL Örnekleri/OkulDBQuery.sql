CREATE DATABASE Okul
USE Okul

CREATE TABLE Ogrenciler (
OgrenciId int PRIMARY KEY,
OgrenciAd NVARCHAR(50),
Sinif int,
NotOrtalamasi DECIMAL(10,2),
AktifOgrenci bit,
)

SELECT * FROM Ogrenciler

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi)
VALUES (100, 'Tugay', 10, 2.6)

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci)
VALUES (2, 'Levent', 11, 2.9, 1)

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci)
VALUES (3, 'Metin', 9, 3.2, 1)

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci)
VALUES (4, 'Sibel', 12, 2.5, 0)

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci)
VALUES (5, 'Tolga', 10, 2.1, 0)


SELECT * FROM Ogrenciler
WHERE Sinif = 10 AND AktifOgrenci = 1

SELECT OgrenciAd AS Ögrenci , Sinif, NotOrtalamasi FROM Ogrenciler
WHERE NotOrtalamasi > 2.5
ORDER BY NotOrtalamasi DESC

DELETE Ogrenciler
WHERE OgrenciId = 100

-- Toplam Kayýt-Satýr sayýsýný gösteriyor
SELECT COUNT(*) FROM Ogrenciler

-- Aktif öðrenci sayýsýný getiriyor
SELECT COUNT(*) FROM Ogrenciler
WHERE AktifOgrenci = 1

-- Ýlgili kolonun ortalamasýný getirir
SELECT AVG(NotOrtalamasi) FROM Ogrenciler

-- Not ortalamasý en yüksek olan notu getirir
SELECT MAX(NotOrtalamasi) FROM Ogrenciler

-- Not ortalamasý en yüksek olan öðrenciyi getiren kod
SELECT * FROM Ogrenciler
WHERE (SELECT MAX(NotOrtalamasi) FROM Ogrenciler) = NotOrtalamasi

-- Not ortalamasý en yüksek olan öðrenciyi getiren kod
SELECT TOP(1) * FROM Ogrenciler
ORDER BY NotOrtalamasi DESC

SELECT LEFT(OgrenciAd,1) AS ÖðrenciAdý , LEFT(NotOrtalamasi,3) FROM Ogrenciler

-- Tüm harfleri büyük þekilde yazdýrdýk
SELECT UPPER(OgrenciAd), Sinif FROM Ogrenciler

-- Sýnýf bilgisine göre gruplandýrma
-- Sýnýf ve sýnýftaki öðrenci sayýsýný gösteren tablo hazýrladýk
SELECT Sinif ,COUNT(Sinif) AS ÖðrenciSayýsý FROM Ogrenciler
GROUP BY Sinif

-- Having ile filtre yapabiliyoruz
-- Bu örnekte, kayýt sayýsý 1'den yüksek olan kayýtlar sýralanmýþtýr
SELECT Sinif ,COUNT(Sinif) AS ÖðrenciSayýsý FROM Ogrenciler
GROUP BY Sinif
HAVING COUNT(Sinif) > 1


SELECT * FROM Ogrenciler 
WHERE AktifOgrenci = 0 AND Sinif = 12 




