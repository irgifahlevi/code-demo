public class Mahasiswa
{
    public int Id { get; set; }
    public string Nama { get; set; }
    public string Alamat { get; set; }


    public Mahasiswa(int id, string nama, string alamat)
    {
        Id = id;
        Nama = nama;
        Alamat = alamat;
    }
}