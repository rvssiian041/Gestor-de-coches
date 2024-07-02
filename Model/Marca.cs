using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Una API que tenga como modelos Marca {Id, Nombre, Descripcion} Coche {Id, Modelo, Marca, Precio} Pedido {Id, IdCoche, Cantidad}
 * Estructurada como en el ejemplo que se pueda agregar una marca un modelo y un pedido
 * consultar los 3 tambien y hacer los test necesarios de los controladores.
 * (Un controlador y un repositorio por entidad) hacer las migraciones necesarias para usar SQL 
 **/


namespace modelo
{

    public class Marca
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}
