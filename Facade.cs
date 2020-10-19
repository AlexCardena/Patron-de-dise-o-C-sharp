using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFacade
{
    class Facade
    {
        private CompraEntrada compra;

        public Facade()
        {
            compra = new CompraEntrada("Multicine","Vengadores",2, 64.99);   
        }

        public void comprar_entrada_par_taquillera()
        {
            compra.comprar_entrada();
        }
        public void cancelar_entrada_par_taquillera()
        {
            compra.cancelar_compra();
        }
    }
}
