CREATE TABLE Ogrenciler (
  OgrenciId INT PRIMARY KEY IDENTITY(1,1),
  OgrenciAd NVARCHAR(50),
  Sinif INT,
  NotOrtalamasi DECIMAL(10,2),
  AktifOgrenci BIT
)

SELECT * FROM Ogrenciler


INSERT INTO Ogrenciler (OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci) VALUES
(N'Tu�ba �elik', 9, 77.40, 1),
(N'Okan Yal��n', 10, 82.65, 0),
(N'Melisa Ta�', 11, 90.20, 1),
(N'Berkay Aslan', 12, 68.55, 1),
(N'Gizem Erdem', 9, 73.10, 0),
(N'Serdar Ekinci', 10, 79.95, 1),
(N'Nazl� G�l', 11, 85.80, 0),
(N'Alper Korkmaz', 12, 91.00, 1),
(N'Deniz Ba�ar', 9, 66.40, 1),
(N'�layda Sevim', 10, 72.75, 1),
(N'Mertcan Yi�it', 11, 88.10, 0),
(N'Bet�l Arslan', 12, 93.25, 1),
(N'Enes Duman', 9, 60.50, 0),
(N'Ebru Kaan', 10, 76.35, 1),
(N'Yunus Er', 11, 81.90, 1),
(N'Selin Akar', 12, 87.60, 0),
(N'Harun �zt�rk', 9, 70.10, 1),
(N'Nisa G�nd�z', 10, 84.45, 1),
(N'Burak K�l��', 11, 79.20, 0),
(N'Ceren �nce', 12, 89.75, 1);

SELECT * FROM Ogrenciler

-- Having ile filtre yapabiliyoruz
-- Bu �rnekte, kay�t say�s� 1'den y�ksek olan kay�tlar s�ralanm��t�r
SELECT Sinif ,COUNT(Sinif) AS ��renciSay�s� 
FROM Ogrenciler
GROUP BY Sinif
HAVING COUNT(Sinif) > 1

-- T�m s�n�ftaki aktif ��renci say�s� ile aktif olmayan ��renci say�s�
SELECT AktifOgrenci,COUNT(AktifOgrenci) AS ToplamOgrenci 
FROM Ogrenciler
GROUP BY AktifOgrenci

SELECT OgrenciId,ogrenciad,sinif,notortalamasi, aktifogrenci 
FROM Ogrenciler
WHERE aktifogrenci = 1
ORDER BY notortalamasi DESC

UPDATE Ogrenciler SET aktifogrenci = 0
WHERE ogrenciid = 4


-- T�m okuldaki en ba�ar�l� 5 ��renci bilgisi
SELECT TOP(5) OgrenciAd, Sinif, NotOrtalamasi 
FROM Ogrenciler
ORDER BY NotOrtalamasi DESC

-- T�m okuldaki en ba�ar�s�z 5 ��renci bilgisi (aktif olan)
SELECT TOP(5) OgrenciAd, Sinif, NotOrtalamasi 
FROM Ogrenciler
WHERE AktifOgrenci = 1
ORDER BY NotOrtalamasi ASC

-- S�n�flarda ka� ��renci oldu�unu g�rmek istiyorum (sadece aktif olan ��renciler) + not ortalamalar�
SELECT Sinif, COUNT(Sinif) AS ��renciSayisi, AVG(NotOrtalamasi) AS NotOrtalamas� 
FROM Ogrenciler
WHERE AktifOgrenci = 1
GROUP BY Sinif

-- Aktif olan t�m ��rencilerin not ortalamas�ndan y�ksek not ortalamas�na sahip ��rencilerin listesi
SELECT OgrenciAd,NotOrtalamasi, sinif 
FROM Ogrenciler
WHERE NotOrtalamasi > (SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1) 
ORDER BY NotOrtalamasi ASC

SELECT AVG(NotOrtalamasi) AS NotOrtalamas�
FROM Ogrenciler 
WHERE AktifOgrenci = 0


-- Dersler isminde tablo olu�turuldu. Tamamen ba��ms�z.
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
(N'Fizik', N'Ay�e G�l', 50, 50, 1),
(N'Kimya', N'Mehmet Demir', 50, 50, 1),
(N'Tarih', N'Elif Y�ld�z', 40, 45, 0),
(N'Co�rafya', N'Sinan Toprak', 40, 45, 0),
(N'Biyoloji', N'Zeynep Aksoy', 50, 50, 1),
(N'�ngilizce', N'Canan Uslu', 45, 50, 0),
(N'Bilgisayar', N'Murat �zkan', 60, 60, 1),
(N'M�zik', N'Seda Tun�', 40, 40, 1),
( N'G�rsel Sanatlar', N'Emre Altun', 40, 40, 1);




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

-- �ki tablo aras�nda ba�lant� kuruldu, bu sayede hem ��renci tablosuna hem de dersler tablosuna eri�im imkan�m�z oldu. 
-- Bu �rnek, ��rencinin ad�, not ortalamas�, s�n�f�, atand��� dersin ad� ve ders s�resi ekrana yans�t�ld�.
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

-- Ders Id'si 2 olan dersi alm�� ��rencilerin ad�n� ve not ortalams�n� g�steren sorgu
SELECT Ogrenciler.OgrenciAd, Ogrenciler.NotOrtalamasi, Dersler.DersAdi
FROM OgrenciDers
INNER JOIN Dersler ON Dersler.DersId = OgrenciDers.DersId 
INNER JOIN Ogrenciler ON Ogrenciler.OgrenciId = OgrenciDers.OgrenciId
WHERE Dersler.DersId = 2

-- Hangi dersten ka� ��rencinin kay�tl� oldu�unu g�steren sorgu
SELECT Dersler.DersAdi,COUNT(Dersler.DersAdi) AS OgrenciSay�s�
FROM OgrenciDers
INNER JOIN Dersler ON Dersler.DersId = OgrenciDers.DersId 
INNER JOIN Ogrenciler ON Ogrenciler.OgrenciId = OgrenciDers.OgrenciId
GROUP BY Dersler.DersAdi
ORDER BY COUNT(Dersler.DersAdi) DESC

