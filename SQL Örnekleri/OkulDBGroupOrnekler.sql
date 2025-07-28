-- S�n�f bilgisine g�re grupland�rma
-- S�n�f ve s�n�ftaki ��renci say�s�n� g�steren tablo haz�rlad�k
SELECT Sinif ,COUNT(Sinif) AS ��renciSay�s� FROM Ogrenciler
GROUP BY Sinif

-- Having ile filtre yapabiliyoruz
-- Bu �rnekte, kay�t say�s� 1'den y�ksek olan kay�tlar s�ralanm��t�r
SELECT Sinif ,COUNT(Sinif) AS ��renciSay�s� FROM Ogrenciler
GROUP BY Sinif
HAVING COUNT(Sinif) > 1

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci) VALUES
(20, N'Tu�ba �elik', 9, 77.40, 1),
(21, N'Okan Yal��n', 10, 82.65, 0),
(22, N'Melisa Ta�', 11, 90.20, 1),
(23, N'Berkay Aslan', 12, 68.55, 1),
(24, N'Gizem Erdem', 9, 73.10, 0),
(25, N'Serdar Ekinci', 10, 79.95, 1),
(26, N'Nazl� G�l', 11, 85.80, 0),
(27, N'Alper Korkmaz', 12, 91.00, 1),
(28, N'Deniz Ba�ar', 9, 66.40, 1),
(29, N'�layda Sevim', 10, 72.75, 1),
(30, N'Mertcan Yi�it', 11, 88.10, 0),
(31, N'Bet�l Arslan', 12, 93.25, 1),
(32, N'Enes Duman', 9, 60.50, 0),
(33, N'Ebru Kaan', 10, 76.35, 1),
(34, N'Yunus Er', 11, 81.90, 1),
(16, N'Selin Akar', 12, 87.60, 0),
(17, N'Harun �zt�rk', 9, 70.10, 1),
(18, N'Nisa G�nd�z', 10, 84.45, 1),
(19, N'Burak K�l��', 11, 79.20, 0),
(35, N'Ceren �nce', 12, 89.75, 1);


UPDATE Ogrenciler SET AktifOgrenci = 1
WHERE NotOrtalamasi > 80 AND AktifOgrenci = 0

USE Okul
SELECT * FROM Ogrenciler
WHERE NOT AktifOgrenci = 1

-- T�m s�n�ftaki aktif ��renci say�s� ile aktif olmayan ��renci say�s�
SELECT AktifOgrenci,COUNT(AktifOgrenci) AS ToplamOgrenci 
FROM Ogrenciler
GROUP BY AktifOgrenci

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

SELECT Sinif, NotOrtalamasi 
FROM Ogrenciler
WHERE AktifOgrenci = 0
ORDER BY NotOrtalamasi DESC

-- 12.S�n�flarda puan� en d���k olan ��renci.
SELECT TOP(1) * 
FROM Ogrenciler
WHERE Sinif = 12 
ORDER BY NotOrtalamasi ASC

-- Aktif olan t�m ��rencilerin not ortalamas�ndan y�ksek not ortalamas�na sahip ��rencilerin listesi
SELECT OgrenciAd,NotOrtalamasi, AktifOgrenci 
FROM Ogrenciler
WHERE NotOrtalamasi > (SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1) 
ORDER BY NotOrtalamasi ASC

SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1

-- S�n�flara g�re aktif olan t�m ��rencilerin not ortalamas�ndan y�ksek not ortalamas�na sahip ��renci say�s� ve not ortalamalar�
SELECT Sinif,COUNT(Sinif) AS ��renciSay�s�, LEFT(AVG(NotOrtalamasi),5) AS NotOrtalamas�
FROM Ogrenciler
WHERE NotOrtalamasi > (SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1) 
GROUP BY Sinif
ORDER BY Sinif ASC





-- Dersler isminde tablo olu�turuldu. Tamamen ba��ms�z.
CREATE TABLE Dersler (
DersId INT PRIMARY KEY,
DersAdi NVARCHAR(50),
Ogretmen NVARCHAR(50),
DersSuresi INT,
GecerNot INT,
Uygulamali bit
)

INSERT INTO Dersler (DersId, DersAdi, Ogretmen, DersSuresi, GecerNot, Uygulamali) VALUES
(1, N'Matematik', N'Ahmet Kara', 45, 50, 0),
(2, N'Fizik', N'Ay�e G�l', 50, 50, 1),
(3, N'Kimya', N'Mehmet Demir', 50, 50, 1),
(4, N'Tarih', N'Elif Y�ld�z', 40, 45, 0),
(5, N'Co�rafya', N'Sinan Toprak', 40, 45, 0),
(6, N'Biyoloji', N'Zeynep Aksoy', 50, 50, 1),
(7, N'�ngilizce', N'Canan Uslu', 45, 50, 0),
(8, N'Bilgisayar', N'Murat �zkan', 60, 60, 1),
(9, N'M�zik', N'Seda Tun�', 40, 40, 1),
(10, N'G�rsel Sanatlar', N'Emre Altun', 40, 40, 1);

-- Uygulamal� olan dersleri, ders s�resine g�re s�ralad�k.
SELECT * 
FROM Dersler
WHERE Uygulamali = 1
ORDER BY DersSuresi DESC








