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

SELECT OgrenciAd AS �grenci , Sinif, NotOrtalamasi FROM Ogrenciler
WHERE NotOrtalamasi > 2.5
ORDER BY NotOrtalamasi DESC

DELETE Ogrenciler
WHERE OgrenciId = 100

-- Toplam Kay�t-Sat�r say�s�n� g�steriyor
SELECT COUNT(*) FROM Ogrenciler

-- Aktif ��renci say�s�n� getiriyor
SELECT COUNT(*) FROM Ogrenciler
WHERE AktifOgrenci = 1

-- �lgili kolonun ortalamas�n� getirir
SELECT AVG(NotOrtalamasi) FROM Ogrenciler

-- Not ortalamas� en y�ksek olan notu getirir
SELECT MAX(NotOrtalamasi) FROM Ogrenciler

-- Not ortalamas� en y�ksek olan ��renciyi getiren kod
SELECT * FROM Ogrenciler
WHERE (SELECT MAX(NotOrtalamasi) FROM Ogrenciler) = NotOrtalamasi

-- Not ortalamas� en y�ksek olan ��renciyi getiren kod
SELECT TOP(1) * FROM Ogrenciler
ORDER BY NotOrtalamasi DESC

SELECT LEFT(OgrenciAd,1) AS ��renciAd� , LEFT(NotOrtalamasi,3) FROM Ogrenciler

-- T�m harfleri b�y�k �ekilde yazd�rd�k
SELECT UPPER(OgrenciAd), Sinif FROM Ogrenciler

-- S�n�f bilgisine g�re grupland�rma
-- S�n�f ve s�n�ftaki ��renci say�s�n� g�steren tablo haz�rlad�k
SELECT Sinif ,COUNT(Sinif) AS ��renciSay�s� FROM Ogrenciler
GROUP BY Sinif

-- Having ile filtre yapabiliyoruz
-- Bu �rnekte, kay�t say�s� 1'den y�ksek olan kay�tlar s�ralanm��t�r
SELECT Sinif ,COUNT(Sinif) AS ��renciSay�s� FROM Ogrenciler
GROUP BY Sinif
HAVING COUNT(Sinif) > 1


SELECT * FROM Ogrenciler 
WHERE AktifOgrenci = 0 AND Sinif = 12 




