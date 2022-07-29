namespace Canzar_dll
{
    public class UpraviteljKlijentima
    {
        public void OtvoriZdravstveniKartonKlijenta(Klijent odabraniKLijent)
        {
            FormKarton formaKarton = new FormKarton(odabraniKLijent);
            formaKarton.IspuniPodatke();
            formaKarton.ShowDialog();
        }
    }
}
