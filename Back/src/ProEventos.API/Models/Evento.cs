namespace ProEventos.API.Models
{
    public class Evento
    {


        public int EventoId { get; set; }

        public string Local { get; set; }
        public string DataEvento { get; set; }

        public string Tema { get; set; }

        public int QntdPessoas { get; set; }

        public string Lote { get; set; }

        public string ImageUrl { get; set; }


    }
}