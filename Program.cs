using System;
//Este es la clase principal aqui realizamos lacompra de entradas por medio de la clase Facade
//Podemos cancelar esta compra si descomentamos la linea 12
namespace PatronFacade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade tienda = new Facade();
            tienda.comprar_entrada_par_taquillera();
            //tienda.cancelar_entrada_par_taquillera();
        }
    }
}
