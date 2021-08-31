namespace ContribuinteForm.Data
{
    public class Contribuinte
    {
        public string Identificacao { get; set; }
        public TipoContribuinte TipoContribuinte { get; set; }
        public string Documento { get; set; }
        public string Cartao { get; set; }
    }
}
