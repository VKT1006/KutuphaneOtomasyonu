using System;

public class Uye
{

	public int id { get; set; }
	public string ad { get; set; }
	public string soyad { get; set; }
	public int adresId { get; set; }
	public string aciklama { get; set; }

	public Uye(): this(0, "Bilgi Yok", "Bilgi Yok", 0)
	{
	}

	public Uye(int id, string ad, string soyad, int adresId)
    {
		this.id = id;
		this.ad = ad;
		this.soyad = soyad;
		this.adresId = adresId;
    }

}
