using System;

public class Uye
{

	private int id { get; set; };
	private string ad { get; set; };
	private string soyad { get; set; };
	private int adresId { get; set; };
	private string aciklama { get; set; };

	public Uye()
	{
		this(0, "Bilgi Yok", "Bilgi Yok",0);

	}

	public Uye(int id, string ad, string soyad, int adresId)
    {
		this.id = id;
		this.ad = ad;
		this.soyad = soyad;
		this.adresId = adresId;
    }

}
