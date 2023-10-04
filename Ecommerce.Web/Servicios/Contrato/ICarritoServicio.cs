using Ecommerce.DTO;

namespace Ecommerce.Web.Servicios.Contrato
{
    public interface ICarritoServicio
    {
        event Action MostrarItems;

        int CantidadProducto();
        Task AgregarCarrito(CarritoDTO modelo);
        Task EliminarCarrito(int idProducto);
        Task<List<CarritoDTO>> DevolverCarrito();
        Task LimpiarCarrito();
    }
}
