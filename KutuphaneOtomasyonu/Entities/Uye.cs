using System;

public class Uye
{

	public int id { get; set; }
	public string ad { get; set; }
	public string soyad { get; set; }
	public int adresId { get; set; }
	public int  iletisim_bilgileri_id { get; set; }

	public Uye(): this(0, "Bilgi Yok", "Bilgi Yok", 0,0)
	{
	}

	public Uye(int id, string ad, string soyad, int adresId, int iletisim_bilgileri_id)
    {
		this.id = id;
		this.ad = ad;
		this.soyad = soyad;
		this.adresId = adresId;
		this.iletisim_bilgileri_id = iletisim_bilgileri_id;
    }

}
