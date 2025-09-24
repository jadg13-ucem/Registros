using Productos.Modelos;


namespace Productos.Dao
{
    public class ProductoDao
    {
        //ok
        private Producto[] carrito = new Producto[10];
        private int pos = 0;
        public void Agregar(Producto prod)
        {
            carrito[pos++] = prod;
        }

    }
}
