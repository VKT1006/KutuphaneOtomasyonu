using System;

public class Kullanici
{

	public int id { get; set; }
	public string kullaniciAdi { get; set; }
	public string parola { get; set; }
	

	public Kullanici() : this(0, "Bilgi Yok", "Bilgi Yok")
    {
		
    }

	public Kullanici(int id, string kullaniciAdi, string parola)
	{
		this.id = id;
		this.kullaniciAdi = kullaniciAdi;
		this.parola = parola;

	}

}