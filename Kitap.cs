tausing System;

public class Kitap
{

	private int id { get; set; };
	private int yazarId { get; set; };
	private string ISBN { get; set; };
	private string kitapAdi { get; set; };
	private string sayfaSayisi { get; set; };
	private string aciklama { get; set; };

	public Kitap()
	{
		this(0,0,"Bilgi Yok", "Bilgi Yok", "Bilgi Yok", "Bilgi Yok");
	}

	public Kitap(int id, int yazarId, string isbn, string kitapAdi, string sayfaSayisi, string aciklama)
    {
		this.id = id;
		this.yazarId = yazarId;
		this.ISBN = isbn;
		this.kitapAdi = kitapAdi;
		this.sayfaSayisi = sayfaSayisi;
		this.aciklama = aciklama;
    }

}
