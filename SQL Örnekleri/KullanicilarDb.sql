CREATE DATABASE Kullanicilar

USE Kullanicilar

CREATE TABLE KullaniciKayitlari (
KullaniciId int PRIMARY KEY IDENTITY(1,1),
KullaniciAdi NVARCHAR(50),
Sifre NVARCHAR(50),
Aktif bit,
TakipciSayisi int,
TakipEdilenSayisi int,
)

SELECT * FROM KullaniciKayitlari

INSERT INTO KullaniciKayitlari (KullaniciAdi, Sifre, Aktif, TakipciSayisi, TakipEdilenSayisi) VALUES
('tugaytuna', 12345, 1, 150,120),('metinok', 5465, 1, 170,110), ('oner', 4444, 1, 500,100), ('sibel', 8888, 1, 800,150), ('ahmet', 5555, 0, 100, 160)

INSERT INTO KullaniciKayitlari (KullaniciAdi, Sifre, Aktif, TakipciSayisi, TakipEdilenSayisi) VALUES
('mehmet', 4545, 0, 180,100)

CREATE VIEW AktifKullanicilar AS
SELECT KullaniciAdi, TakipciSayisi, TakipEdilenSayisi
FROM KullaniciKayitlari
WHERE Aktif = 1
ORDER BY TakipciSayisi DESC

SELECT * FROM AktifKullanicilar
