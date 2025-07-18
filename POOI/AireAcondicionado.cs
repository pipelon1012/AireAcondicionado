using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI
{
    class AireAcondicionado
    {
        /*Atributos
         Encapsulamiento:Es poner privados los atributos, para que sean utilizados,
         solo por la clase donde se encuentran*/
        private string marca;
        private string modelo;
        private string color;
        private int voltaje;
        private int btu;
        private int temperatura;


        /* Metodo constructor: Sirve para darles un valor inicial a los atributos*/
        public AireAcondicionado(string m, string mo, string co, int v, int b, int t)
        {
            marca = m;
            modelo = mo;
            color = co;
            voltaje = v;
            btu = b;
            temperatura = t;
        }

        /*Sobrecarga:Es crear varios constructores, pero con diferente cantidad de parametros*/

        public AireAcondicionado(string m, string mo, string co, int v, int b)
        {
            marca = m;
            modelo = mo;
            color = co;
            voltaje = v;
            btu = b;
            
        }

        public AireAcondicionado(string m, string mo, string co, int v) 
        { 
            marca = m;
            modelo = mo;
            color = co;
            voltaje = v;
            
        }


        /*Metodos get(devolver) y set(asignar), con esto puedo utilizar los atributos en otras clases, 
          asi sean privados*/

        public void setMarca(string m)
        {
            marca = m;
        }

        public string getMarca()
        {
            return marca;
        }

        public void setModelo(string mod)
        {
            modelo = mod;
        }

        public string getModelo()
        {
            return modelo;
        }

        public void setColor(string col)
        {
            color = col;
        }

        public string getColor()
        {
            return color;
        }

        public void setVoltaje(int volt)
        {
            voltaje = volt;
        }

        public int getVoltaje()
        {
            return voltaje;
        }

        public void setBtu(int bt)
        {
            btu = bt;
        }

        public int getBtu()
        {
            return btu;
        }

        public void setTemperatura(int temp)
        {
            temperatura = temp;
        }

        public int getTemperatura()
        {
            return temperatura;
        }

        //Metodos
        public void subirTemperatura()
        {   
            if(temperatura < 30)
            {
                temperatura++;
            }
            
        }
        /*Sobrecarga de metodos:mismo nombre pero diferentes parametros
          El valor maximo para la temperatura es 30 grados.*/
        public void subirTemperatura(int grados)
        {
            int temperaturaActual = temperatura + grados;
            if (temperaturaActual > 30)
            {
                temperatura = 30;
            }
            else
            {
                temperatura = temperaturaActual;
            }
        }

        public void bajarTemperatura()
        {
            if (temperatura > 16)
            {
                temperatura--;
            }
        }
        /*El valor minimo para la temperatura es 16.*/

        public void bajarTemperatura(int grados)
        {
            int temperaturaActual = temperatura - grados;
            if (temperaturaActual < 16)
            {
                temperatura = 16;
            }
            else
            {
                temperatura = temperaturaActual;
            }
        }

        public int darTemperaturaActual()
        {
            return temperatura;
        }
    }
}
