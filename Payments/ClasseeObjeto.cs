using System;

namespace Payments
{
    public static class ClasseeObjeto
    {
        public static void Show()
        {
            //objeto é um tipo de referencia , contem propriedades, métodos e eventos, tipo de referencia
            // -> Endereço dos dados
            //diferença do class pro struct é a maneira como as informações são armazenadas
            
            //instanciando uma váriavel e dando um valor para a referencia
            var customer = new Customer();
            customer.Name = "teste";
        }
    }

    struct Customer{
        public string Name;
    }
}