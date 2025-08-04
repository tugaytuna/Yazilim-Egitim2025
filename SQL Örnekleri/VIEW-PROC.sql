CREATE TABLE Ogrenciler (
  OgrenciId INT PRIMARY KEY IDENTITY(1,1),
  OgrenciAd NVARCHAR(50),
  Sinif INT,
  NotOrtalamasi DECIMAL(10,2),
  AktifOgrenci BIT
)

SELECT * FROM Ogrenciler


INSERT INTO Ogrenciler (OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci) VALUES
(N'Tuðba Çelik', 9, 77.40, 1),
(N'Okan Yalçýn', 10, 82.65, 0),
(N'Melisa Taþ', 11, 90.20, 1),
(N'Berkay Aslan', 12, 68.55, 1),
(N'Gizem Erdem', 9, 73.10, 0),
(N'Serdar Ekinci', 10, 79.95, 1),
(N'Nazlý Gül', 11, 85.80, 0),
(N'Alper Korkmaz', 12, 91.00, 1),
(N'Deniz Baþar', 9, 66.40, 1),
(N'Ýlayda Sevim', 10, 72.75, 1),
(N'Mertcan Yiðit', 11, 88.10, 0),
(N'Betül Arslan', 12, 93.25, 1),
(N'Enes Duman', 9, 60.50, 0),
(N'Ebru Kaan', 10, 76.35, 1),
(N'Yunus Er', 11, 81.90, 1),
(N'Selin Akar', 12, 87.60, 0),
(N'Harun Öztürk', 9, 70.10, 1),
(N'Nisa Gündüz', 10, 84.45, 1),
(N'Burak Kýlýç', 11, 79.20, 0),
(N'Ceren Ýnce', 12, 89.75, 1);

SELECT * FROM Ogrenciler

-- Having ile filtre yapabiliyoruz
-- Bu örnekte, kayýt sayýsý 1'den yüksek olan kayýtlar sýralanmýþtýr
SELECT Sinif ,COUNT(Sinif) AS ÖðrenciSayýsý 
FROM Ogrenciler
GROUP BY Sinif
HAVING COUNT(Sinif) > 1

-- Tüm sýnýftaki aktif öðrenci sayýsý ile aktif olmayan öðrenci sayýsý
SELECT AktifOgrenci,COUNT(AktifOgrenci) AS ToplamOgrenci 
FROM Ogrenciler
GROUP BY AktifOgrenci

SELECT OgrenciId,ogrenciad,sinif,notortalamasi, aktifogrenci 
FROM Ogrenciler
WHERE aktifogrenci = 1
ORDER BY notortalamasi DESC

UPDATE Ogrenciler SET aktifogrenci = 0
WHERE ogrenciid = 4


-- Tüm okuldaki en baþarýlý 5 öðrenci bilgisi
SELECT TOP(5) OgrenciAd, Sinif, NotOrtalamasi 
FROM Ogrenciler
ORDER BY NotOrtalamasi DESC

-- Tüm okuldaki en baþarýsýz 5 öðrenci bilgisi (aktif olan)
SELECT TOP(5) OgrenciAd, Sinif, NotOrtalamasi 
FROM Ogrenciler
WHERE AktifOgrenci = 1
ORDER BY NotOrtalamasi ASC

-- Sýnýflarda kaç öðrenci olduðunu görmek istiyorum (sadece aktif olan öðrenciler) + not ortalamalarý
SELECT Sinif, COUNT(Sinif) AS ÖðrenciSayisi, AVG(NotOrtalamasi) AS NotOrtalamasý 
FROM Ogrenciler
WHERE AktifOgrenci = 1
GROUP BY Sinif

-- Aktif olan tüm öðrencilerin not ortalamasýndan yüksek not ortalamasýna sahip öðrencilerin listesi
SELECT OgrenciAd,NotOrtalamasi, sinif 
FROM Ogrenciler
WHERE NotOrtalamasi > (SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1) 
ORDER BY NotOrtalamasi ASC

SELECT AVG(NotOrtalamasi) AS NotOrtalamasý
FROM Ogrenciler 
WHERE AktifOgrenci = 0


-- Dersler isminde tablo oluþturuldu. Tamamen baðýmsýz.
CREATE TABLE Dersler (
DersId INT PRIMARY KEY IDENTITY(1,1),
DersAdi NVARCHAR(50),
Ogretmen NVARCHAR(50),
DersSuresi INT,
GecerNot INT,
Uygulamali bit
)

SELECT * From Dersler

INSERT INTO Dersler (DersAdi, Ogretmen, DersSuresi, GecerNot, Uygulamali) VALUES
(N'Matematik', N'Ahmet Kara', 45, 50, 0),
(N'Fizik', N'Ayþe Gül', 50, 50, 1),
(N'Kimya', N'Mehmet Demir', 50, 50, 1),
(N'Tarih', N'Elif Yýldýz', 40, 45, 0),
(N'Coðrafya', N'Sinan Toprak', 40, 45, 0),
(N'Biyoloji', N'Zeynep Aksoy', 50, 50, 1),
(N'Ýngilizce', N'Canan Uslu', 45, 50, 0),
(N'Bilgisayar', N'Murat Özkan', 60, 60, 1),
(N'Müzik', N'Seda Tunç', 40, 40, 1),
( N'Görsel Sanatlar', N'Emre Altun', 40, 40, 1);




SELECT  derssuresi ,COUNT(derssuresi) as DersAdeti
FROM Dersler
GROUP BY derssuresi

CREATE TABLE OgrenciDers (
OgrenciDersId INT PRIMARY KEY IDENTITY(1,1),
  OgrenciId INT,
  DersId INT,
  CONSTRAINT FK_Ogrenci FOREIGN KEY (OgrenciId) REFERENCES Ogrenciler(OgrenciId),
  CONSTRAINT FK_Ders FOREIGN KEY (DersId) REFERENCES Dersler(DersId)
)


INSERT INTO OgrenciDers (OgrenciId,DersId) VALUES (6,10),(5,2),(5,10)



SELECT * FROM Dersler

-- Ýki tablo arasýnda baðlantý kuruldu, bu sayede hem öðrenci tablosuna hem de dersler tablosuna eriþim imkanýmýz oldu. 
-- Bu örnek, öðrencinin adý, not ortalamasý, sýnýfý, atandýðý dersin adý ve ders süresi ekrana yansýtýldý.
SELECT Ogrenciler.OgrenciAd, Ogrenciler.NotOrtalamasi,  Ogrenciler.Sinif, Dersler.DersAdi, Dersler.DersSuresi
FROM OgrenciDers
INNER JOIN Ogrenciler ON Ogrenciler.OgrenciId = OgrenciDers.OgrenciId
INNER JOIN Dersler ON Dersler.DersId = OgrenciDers.DersId


SELECT Ogrenciler.OgrenciAd, Ogrenciler.NotOrtalamasi, Dersler.DersAdi, Dersler.DersSuresi
FROM OgrenciDers 
INNER JOIN Ogrenciler ON Ogrenciler.OgrenciId = OgrenciDers.OgrenciId
INNER JOIN Dersler ON Dersler.DersId = OgrenciDers.DersId
WHERE Ogrenciler.AktifOgrenci = 1
ORDER BY notortalamasi DESC



SELECT * FROM Dersler
SELECT * FROM Ogrenciler

-- Ders Id'si 2 olan dersi almýþ öðrencilerin adýný ve not ortalamsýný gösteren sorgu
SELECT Ogrenciler.OgrenciAd, Ogrenciler.NotOrtalamasi, Dersler.DersAdi
FROM OgrenciDers
INNER JOIN Dersler ON Dersler.DersId = OgrenciDers.DersId 
INNER JOIN Ogrenciler ON Ogrenciler.OgrenciId = OgrenciDers.OgrenciId
WHERE Dersler.DersId = 2

-- Hangi dersten kaç öðrencinin kayýtlý olduðunu gösteren sorgu
SELECT Dersler.DersAdi,COUNT(Dersler.DersAdi) AS OgrenciSayýsý
FROM OgrenciDers
INNER JOIN Dersler ON Dersler.DersId = OgrenciDers.DersId 
INNER JOIN Ogrenciler ON Ogrenciler.OgrenciId = OgrenciDers.OgrenciId
GROUP BY Dersler.DersAdi
ORDER BY COUNT(Dersler.DersAdi) DESC

