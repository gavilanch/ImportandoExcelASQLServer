using Microsoft.EntityFrameworkCore;

namespace GenerandoExcel.Entidades
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        [Precision(12, 2)]
        public decimal Salario { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}
