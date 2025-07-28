-- Sýnýf bilgisine göre gruplandýrma
-- Sýnýf ve sýnýftaki öðrenci sayýsýný gösteren tablo hazýrladýk
SELECT Sinif ,COUNT(Sinif) AS ÖðrenciSayýsý FROM Ogrenciler
GROUP BY Sinif

-- Having ile filtre yapabiliyoruz
-- Bu örnekte, kayýt sayýsý 1'den yüksek olan kayýtlar sýralanmýþtýr
SELECT Sinif ,COUNT(Sinif) AS ÖðrenciSayýsý FROM Ogrenciler
GROUP BY Sinif
HAVING COUNT(Sinif) > 1

INSERT INTO Ogrenciler (OgrenciId, OgrenciAd, Sinif, NotOrtalamasi, AktifOgrenci) VALUES
(20, N'Tuðba Çelik', 9, 77.40, 1),
(21, N'Okan Yalçýn', 10, 82.65, 0),
(22, N'Melisa Taþ', 11, 90.20, 1),
(23, N'Berkay Aslan', 12, 68.55, 1),
(24, N'Gizem Erdem', 9, 73.10, 0),
(25, N'Serdar Ekinci', 10, 79.95, 1),
(26, N'Nazlý Gül', 11, 85.80, 0),
(27, N'Alper Korkmaz', 12, 91.00, 1),
(28, N'Deniz Baþar', 9, 66.40, 1),
(29, N'Ýlayda Sevim', 10, 72.75, 1),
(30, N'Mertcan Yiðit', 11, 88.10, 0),
(31, N'Betül Arslan', 12, 93.25, 1),
(32, N'Enes Duman', 9, 60.50, 0),
(33, N'Ebru Kaan', 10, 76.35, 1),
(34, N'Yunus Er', 11, 81.90, 1),
(16, N'Selin Akar', 12, 87.60, 0),
(17, N'Harun Öztürk', 9, 70.10, 1),
(18, N'Nisa Gündüz', 10, 84.45, 1),
(19, N'Burak Kýlýç', 11, 79.20, 0),
(35, N'Ceren Ýnce', 12, 89.75, 1);


UPDATE Ogrenciler SET AktifOgrenci = 1
WHERE NotOrtalamasi > 80 AND AktifOgrenci = 0

USE Okul
SELECT * FROM Ogrenciler
WHERE NOT AktifOgrenci = 1

-- Tüm sýnýftaki aktif öðrenci sayýsý ile aktif olmayan öðrenci sayýsý
SELECT AktifOgrenci,COUNT(AktifOgrenci) AS ToplamOgrenci 
FROM Ogrenciler
GROUP BY AktifOgrenci

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

SELECT Sinif, NotOrtalamasi 
FROM Ogrenciler
WHERE AktifOgrenci = 0
ORDER BY NotOrtalamasi DESC

-- 12.Sýnýflarda puaný en düþük olan öðrenci.
SELECT TOP(1) * 
FROM Ogrenciler
WHERE Sinif = 12 
ORDER BY NotOrtalamasi ASC

-- Aktif olan tüm öðrencilerin not ortalamasýndan yüksek not ortalamasýna sahip öðrencilerin listesi
SELECT OgrenciAd,NotOrtalamasi, AktifOgrenci 
FROM Ogrenciler
WHERE NotOrtalamasi > (SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1) 
ORDER BY NotOrtalamasi ASC

SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1

-- Sýnýflara göre aktif olan tüm öðrencilerin not ortalamasýndan yüksek not ortalamasýna sahip öðrenci sayýsý ve not ortalamalarý
SELECT Sinif,COUNT(Sinif) AS ÖðrenciSayýsý, LEFT(AVG(NotOrtalamasi),5) AS NotOrtalamasý
FROM Ogrenciler
WHERE NotOrtalamasi > (SELECT AVG(NotOrtalamasi) FROM Ogrenciler WHERE AktifOgrenci = 1) 
GROUP BY Sinif
ORDER BY Sinif ASC





-- Dersler isminde tablo oluþturuldu. Tamamen baðýmsýz.
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
(2, N'Fizik', N'Ayþe Gül', 50, 50, 1),
(3, N'Kimya', N'Mehmet Demir', 50, 50, 1),
(4, N'Tarih', N'Elif Yýldýz', 40, 45, 0),
(5, N'Coðrafya', N'Sinan Toprak', 40, 45, 0),
(6, N'Biyoloji', N'Zeynep Aksoy', 50, 50, 1),
(7, N'Ýngilizce', N'Canan Uslu', 45, 50, 0),
(8, N'Bilgisayar', N'Murat Özkan', 60, 60, 1),
(9, N'Müzik', N'Seda Tunç', 40, 40, 1),
(10, N'Görsel Sanatlar', N'Emre Altun', 40, 40, 1);

-- Uygulamalý olan dersleri, ders süresine göre sýraladýk.
SELECT * 
FROM Dersler
WHERE Uygulamali = 1
ORDER BY DersSuresi DESC








