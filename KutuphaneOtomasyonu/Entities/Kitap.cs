using System;

public class Kitap
{

	public int id { get; set; }
	public int yazarId { get; set; }
	public string ISBN { get; set; }
	public string kitapAdi { get; set; }
	public string sayfaSayisi { get; set; }

	public Kitap() : this(0, 0, "Bilgi Yok", "Bilgi Yok", "Bilgi Yok")
	{
		
	}

	public Kitap(int id, int yazarId, string isbn, string kitapAdi, string sayfaSayisi)
    {
		this.id = id;
		this.yazarId = yazarId;
		this.ISBN = isbn;
		this.kitapAdi = kitapAdi;
		this.sayfaSayisi = sayfaSayisi;
    }

}
