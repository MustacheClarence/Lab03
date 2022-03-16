namespace Laboratorio03.Models
{
    public class Vehiculo
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Propietario { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Serie { get; set; }

        internal Vehiculo() { }
        internal Vehiculo(string id, string email, string dueno, string color, string marca, string serie)
        {
            this.Id = id;
            this.Email = email;
            this.Propietario = dueno;
            this.Color = color;
            this.Marca = marca;
            this.Serie = serie;
        }
    }
}

