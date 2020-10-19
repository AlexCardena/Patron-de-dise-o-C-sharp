using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFacade
{
    class CompraEntrada
    {
        private String nombre_cine;
        private String nombre_pelicula;
        private int cantidad_entradas;
        private double precio_entrada;

        public CompraEntrada(String nc,String np,int ce, double pe)
        {
            nombre_cine = nc;
            nombre_pelicula = np;
            cantidad_entradas = ce;
            precio_entrada = pe;
        }
        public String getNombre_cine()
        {
            return nombre_cine;
        }

        public void setNombre_cine(String nombre_cine)
        {
            this.nombre_cine = nombre_cine;
        }

        public String getNombre_pelicula()
        {
            return nombre_pelicula;
        }

        public void setNombre_pelicula(String nombre_pelicula)
        {
            this.nombre_pelicula = nombre_pelicula;
        }

        public int getCantidad_entradas()
        {
            return cantidad_entradas;
        }

        public void setCantidad_entradas(int cantidad_entradas)
        {
            this.cantidad_entradas = cantidad_entradas;
        }

        public double getPrecio_entrada()
        {
            return precio_entrada;
        }

        public void setPrecio_entrada(double precio_entrada)
        {
            this.precio_entrada = precio_entrada;
        }

        public void comprar_entrada()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Felicidades por adquirir su entrada en el cine " + nombre_cine);
            Console.WriteLine("Pelicula: " + nombre_pelicula);
            Console.WriteLine("Cantidad de entradas: " + cantidad_entradas);
            Console.WriteLine("Costo: " + (cantidad_entradas * precio_entrada));
            Console.WriteLine("***************************************************************");
        }
        public void cancelar_compra()
        {
            Console.WriteLine("***************************************************************");
            Console.WriteLine("Usted cancelo su compra para la pelicula " + nombre_pelicula);
            Console.WriteLine("Cine: " + nombre_cine);
            Console.WriteLine("Reembolso: " + (cantidad_entradas * precio_entrada));
            Console.WriteLine("***************************************************************");
        }

    }
}
