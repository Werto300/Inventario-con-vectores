using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {
        int tamaño = 0;
        Producto[] Inve1 = new Producto[15];
        

        public void Agregar(Producto prod)
        {
            int aux = 0;
            if (tamaño==0)
            {
                Inve1[tamaño] = prod;
                tamaño++;
            }
            else
            {
                for (int i = 0; i < tamaño && aux == 0; i++)
                {
                    if (Inve1[i].regresaCodigo() == prod.regresaCodigo())
                    {
                        aux = 1;
                    }
                }
                if (aux!=1 && tamaño != 15)
                {
                    Inve1[tamaño] = prod;
                    tamaño++;
                }
            }
        }

        public void Eliminar(int codigo)
        {
            for (int i = 0; i < tamaño; i++)
            {
                if(Inve1[i].regresaCodigo() == codigo)
                {
                    while (i < tamaño)
                    {
                        Inve1[i] = Inve1[i + 1];
                        i++;
                    }
                    Inve1[tamaño] = null;
                    tamaño--;
                }
            }
        }

        public Producto Buscar(int codigo)
        {
            int saber = 0, i;
            for (i = 0; i < tamaño&& saber != 1; i++)
            {
                if (Inve1[i].regresaCodigo() == codigo)
                {
                    saber = 1;
                }
                else
                {
                    saber = 0;
                }
            }
            if(saber == 1)
            {
                return Inve1[i-1];
            }
            else
            {
                return null;
            }
        }

        public string Reporte()
        {
            string salida = "";
            for (int i = 0; i < tamaño; i++)
            {
                salida += Inve1[i].ToString() + Environment.NewLine;
            }
            return salida;
        }

        public void Insertar(Producto prod, int pos)
        {
            tamaño++;
            Producto auxiliar;
            if (tamaño <= pos)
            {
                Inve1[tamaño-1] = prod;
            }
            else
            {
                for (int i = pos - 1; i < tamaño; i++)
                {
                    auxiliar = Inve1[i];
                    Inve1[i] = prod;
                    prod = auxiliar;
                }
            }
        }
    }
}
