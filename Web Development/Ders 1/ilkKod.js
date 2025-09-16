console.log("İlk Javascript Kodu!");
console.log("Bu da başka bir yazı");

document.getElementsByTagName("h2")[0].innerHTML = "Güncel Değer";
// C# Karşılığı
// label1.Text = "güncel değer";

function ButonTiklama() {
  console.log("butona tıklandı");
}

document.getElementsByTagName("button")[0].onclick = ButonTiklama;
