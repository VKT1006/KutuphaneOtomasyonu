using System;

public class Kullanici
{

	private int id { get;set }
	private string kullaniciAdi { get; set; }
	private string parola { get; set; }


	

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
