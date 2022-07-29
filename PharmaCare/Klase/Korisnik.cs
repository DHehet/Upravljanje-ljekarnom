namespace PharmaCare.Klase
{
    public enum UlogaKorisnika
    {
        ObicniKorisnik,
        Administrator
    }

    public class Korisnik
    {
        public int idKorisnika { get; set; }
        public string imeKorisnika { get; set; }
        public string prezimeKorisnika { get; set; }
        public string kontaktBrojKorisnika { get; set; }
        public string emailKorisnika { get; set; }
        public string korisnickoImeKorisnika { get; set; }
        public string lozinkaKorisnika { get; set; }
        public UlogaKorisnika ulogaKorisnika { get; set; }
    }
}
