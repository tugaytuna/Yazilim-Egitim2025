-- Yeni bir database oluşturuyoruz.
CREATE DATABASE CRMOrnek

USE CRMOrnek

CREATE TABLE Urunler (
UrunId int PRIMARY KEY IDENTITY(1,1),
  UrunAdi NVARCHAR(50),
  Fiyat int,
  Sutlu bit,
  Boyut int
)

CREATE TABLE Musteriler (
MusteriId int PRIMARY KEY IDENTITY(1,1),
  MusteriAd NVARCHAR(50),
  MusteriYasi int,
  MusteriIl NVARCHAR(50)
)

CREATE TABLE Siparisler (
  SiparisId int PRIMARY KEY IDENTITY(1,1),
  MusteriId int,
  UrunId int,
  Adet int,
  Paket bit,
  Nakit bit,
  SiparisTarihi Date,
  CONSTRAINT FK_MusteriId FOREIGN KEY (MusteriId) REFERENCES Musteriler(MusteriId),
  CONSTRAINT FK_UrunId FOREIGN KEY (UrunId) REFERENCES Urunler(UrunId)
)

-- En ucuz sütlü ürünü bulmak
SELECT TOP(1) * 
FROM Urunler
WHERE sutlu = 1
ORDER BY fiyat ASC

SELECT * FROM Urunler

INSERT INTO Urunler (UrunAdi, Fiyat, Sutlu, Boyut) VALUES
(N'Latte', 45, 1, 2),
(N'Americano', 38, 0, 2),
(N'Cappuccino', 47, 1, 2),
(N'Espresso', 30, 0, 1),
(N'Mocha', 50, 1, 3),
(N'Sıcak Çikolata', 42, 1, 2),
(N'Filtre Kahve', 35, 0, 2),
(N'Çay', 20, 0, 1),
(N'Buzlu Latte', 48, 1, 3),
(N'Flat White', 44, 1, 2);

INSERT INTO Musteriler (musteriad, musteriyasi, MusteriIl) VALUES 
('Ahmet', 30, 'Kadıköy'),
('Mehmet', 45, 'Beşiktaş'),
('Ayşe', 28, 'Üsküdar'),
('Fatma', 35, 'Bakırköy'),
('Ali', 40, 'Şişli'),
('Canan', 32, 'Ataşehir'),
('Murat', 27, 'Maltepe'),
('Zeynep', 22, 'Sancaktepe'),
('Emre', 38, 'Beylikdüzü'),
('Elif', 31, 'Kartal'),
('Hüseyin', 29, 'Sarıyer'),
('Esra', 26, 'Avcılar'),
('Yusuf', 36, 'Pendik'),
('Sevgi', 33, 'Tuzla'),
('Burak', 39, 'Esenler'),
('Seda', 25, 'Bayrampaşa'),
('Onur', 34, 'Gaziosmanpaşa'),
('Melisa', 23, 'Zeytinburnu'),
('Cem', 41, 'Bağcılar'),
('Nazlı', 37, 'Arnavutköy');

UPDATE Musteriler SEt MusteriIl = 'Beşiktaş'
WHERE MusteriId = 6

SELECT * From Musteriler

-- Aynı ilde birden fazla var olan müşteri
SELECT musteriIl ,COUNT(musteriIl)
FROM Musteriler
GROUP BY musteriIl
HAVING COUNT(musteriIl) > 1


INSERT INTO Siparisler (MusteriId, UrunId, Adet, Paket, Nakit, SiparisTarihi) VALUES
(1, 2, 1, 0, 1, '2025-07-29'),
(2, 5, 2, 1, 0, '2025-07-25'),
(3, 1, 1, 0, 1, '2025-07-28'),
(4, 4, 1, 0, 0, '2025-07-21'),
(5, 7, 3, 1, 1, '2025-07-23'),
(6, 3, 2, 0, 1, '2025-07-30'),
(7, 6, 1, 1, 0, '2025-07-18'),
(8, 8, 1, 0, 1, '2025-07-19'),
(9, 9, 2, 1, 1, '2025-07-20'),
(10, 10, 1, 0, 0, '2025-07-17'),
(11, 1, 2, 0, 1, '2025-07-27'),
(12, 4, 1, 1, 1, '2025-07-22'),
(13, 2, 1, 0, 0, '2025-07-30'),
(14, 6, 3, 1, 1, '2025-07-16'),
(15, 5, 1, 0, 0, '2025-07-24'),
(16, 3, 1, 0, 1, '2025-07-15'),
(17, 7, 2, 1, 1, '2025-07-26'),
(18, 8, 1, 0, 0, '2025-07-28'),
(19, 9, 2, 0, 1, '2025-07-29'),
(20, 10, 1, 1, 0, '2025-07-30'),
(1, 2, 1, 1, 1, '2025-07-14'),
(2, 1, 2, 0, 0, '2025-07-13'),
(3, 5, 1, 1, 1, '2025-07-12'),
(4, 7, 2, 0, 1, '2025-07-11'),
(5, 6, 1, 1, 0, '2025-07-10'),
(6, 3, 1, 0, 1, '2025-07-20'),
(7, 4, 2, 1, 0, '2025-07-22'),
(8, 2, 3, 0, 1, '2025-07-21'),
(9, 1, 2, 1, 1, '2025-07-23'),
(10, 8, 1, 0, 0, '2025-07-25'),
(11, 10, 2, 1, 1, '2025-07-27'),
(12, 9, 1, 0, 1, '2025-07-29'),
(13, 3, 3, 1, 0, '2025-07-30'),
(14, 6, 2, 0, 1, '2025-07-24'),
(15, 5, 1, 1, 0, '2025-07-28'),
(16, 4, 2, 0, 1, '2025-07-26'),
(17, 7, 3, 1, 1, '2025-07-15'),
(18, 2, 1, 0, 0, '2025-07-17'),
(19, 1, 1, 1, 1, '2025-07-19'),
(20, 10, 2, 0, 0, '2025-07-18'),
(1, 9, 1, 1, 1, '2025-07-20'),
(2, 8, 1, 0, 0, '2025-07-22'),
(3, 6, 2, 1, 1, '2025-07-21'),
(4, 3, 3, 0, 1, '2025-07-23'),
(5, 2, 1, 1, 0, '2025-07-25'),
(6, 5, 2, 0, 1, '2025-07-27'),
(7, 4, 1, 1, 1, '2025-07-29'),
(8, 1, 1, 0, 0, '2025-07-30'),
(9, 7, 2, 1, 1, '2025-07-28'),
(10, 10, 1, 0, 1, '2025-07-26');

SELECT * FROM Siparisler

SELECT Siparisler.SiparisId,Musteriler.MusteriAd, Urunler.UrunAdi, Siparisler.Adet, Siparisler.SiparisTarihi 
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId
ORDER BY Musteriler.MusteriAd

-- En çok satan 3 ürün
SELECT TOP(3) Urunler.UrunAdi, COUNT(Urunler.urunadi) AS SiparişAdeti
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
GROUP BY urunadi
ORDER BY COUNT(urunadi) DESC 


SELECT Siparisler.SiparisTarihi ,Urunler.UrunAdi, Siparisler.Adet, Urunler.Fiyat
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
WHERE Urunler.UrunAdi = 'Americano'
ORDER BY SiparisTarihi


-- Tüm Veriler 
SELECT * 
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId

-- En çok sipariş veren illerin/ilçelerin listesi
SELECT Musteriler.MusteriIl, COUNT(Musteriler.MusteriIl) AS SiparişAdeti
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId
GROUP By Musteriler.MusteriIl
ORDER BY COUNT(Musteriler.MusteriIl) DESC

-- tüm ürünlerin siparişi veren kişilerin ortalama yaşları
-- Urun adı - Sipariş verenlerin ortalama yaşı

SELECT Urunler.UrunAdi, AVG(Musteriler.MusteriYasi) AS OrtalamaYaş
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId
GROUP BY Urunler.UrunAdi
ORDER BY AVG(Musteriler.MusteriYasi)

-- En çok sipariş veren iller
SELECT Musteriler.MusteriIl ,COUNT(Siparisler.Adet) AS SiparişAdet
FROM Siparisler
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
GROUP BY Musteriler.MusteriIl
ORDER BY COUNT(Siparisler.Adet) DESC

CREATE VIEW TariheGoreSiparis AS
SELECT TOP(1000) Siparisler.SiparisTarihi,Musteriler.MusteriAd,Musteriler.MusteriId, Urunler.UrunAdi, Siparisler.Adet
FROM Siparisler
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
WHERE MusteriAd = 'Ali'
ORDER BY Adet DESC

-- Adete göre sıralanmış, en çok sipariş verilen ürünler
SELECT SiparisTarihi,MusteriAd, UrunAdi,Adet FROM TariheGoreSiparis
WHERE Adet > 2 
ORDER BY Adet DESC

SELECT SiparisTarihi ,COUNT(Adet) AS SiparişAdeti ,SUM(Adet) AS ToplamAdet
FROM TariheGoreSiparis
WHERE SiparisTarihi = '2025-07-21'
GROUP BY SiparisTarihi


CREATE PROCEDURE TarihSiparis
@Tarih DATE
AS
BEGIN 
-- Prosedürün içindeki kodlar-sorgular
	SELECT SiparisTarihi ,COUNT(Adet) AS SiparişAdeti ,SUM(Adet) AS ToplamAdet
	FROM TariheGoreSiparis
	WHERE SiparisTarihi = @Tarih
	GROUP BY SiparisTarihi
END;



EXEC TarihSiparis @Tarih = '2025-07-22'
EXEC TarihSiparis @Tarih = '2025-07-28'

-- Fiyat ve Adet bilgisini çarparak toplam sipariş tutarını çıkaran fonksiyondur.
-- 2 tane parametre alan, bu parametreleri çarpan bir fonksiyon oluşturduk
CREATE FUNCTION ToplamFiyat2 (@Fiyat INT, @Adet INT)
RETURNS INT
AS
BEGIN
RETURN @Fiyat * @Adet
END


-- Toplam sipariş fiyatını Fiyat * Adet formülü ile bulmamızı sağladık. Function oluşturarak.
SELECT Siparisler.SiparisTarihi, Musteriler.MusteriAd,Urunler.Fiyat, Siparisler.Adet, dbo.ToplamFiyat2(Urunler.Fiyat,Siparisler.Adet) AS ToplamFiyat
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId

-- Fiyat ve Adet bilgisini çarparak toplam sipariş tutarını çıkaran fonksiyondur.
-- 2 tane parametre alan, bu parametreleri çarpan ve sonuna tl ifadesi ekleyen bir fonksiyon oluşturduk
CREATE FUNCTION ToplamFiyatTL (@Fiyat INT, @Adet INT)
RETURNS NVARCHAR(50)
AS
BEGIN
RETURN CONVERT(NVARCHAR(50),(@Fiyat * @Adet)) + ' TL'
END

-- Oluşturduğumuz fonksiyon sayesinde gönderdiğimiz iki parametreyi çarptı ve sonuna TL ifadesini ekledi.
SELECT Siparisler.SiparisTarihi, Musteriler.MusteriAd,Urunler.Fiyat, Siparisler.Adet, dbo.ToplamFiyatTL(Urunler.Fiyat,Siparisler.Adet) AS ToplamFiyat
FROM Siparisler
INNER JOIN Urunler ON Urunler.UrunId = Siparisler.UrunId
INNER JOIN Musteriler ON Musteriler.MusteriId = Siparisler.MusteriId


-- Örnek sipariş ekleme
INSERT INTO Siparisler (MusteriId, UrunId, Adet, Paket, Nakit, SiparisTarihi) VALUES
(9, 5, 6, 0, 1, '2025-07-21')



