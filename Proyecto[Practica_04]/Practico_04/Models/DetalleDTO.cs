namespace Practico_04.Models
{
    public class DetalleDTO : IDataTransferObject
    {
        public int Id { get; set; }
        public string Observaciones { get; set; }

        public bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}
