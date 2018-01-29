using System;
using System.Collections.Generic;

namespace calculator
{
    class Program
    {
        //public static Menu menu { get; set; }
        public static bool isMenuActive = true;
        static void Main(string[] args)        
        {

            var numbers = new List<double>();
            var _menu = new Menu();
            var user = _menu.GetUsername();

            while(isMenuActive){
                var menu = new Menu();
                menu.ShowInitialMessage(user);
                menu.ShowMenu();
                var option = menu.GetOption();
                var quantity = menu.Quantity();
                if(quantity > 3){
                    Console.WriteLine("No se aceptan mas de 3 operandos");
                }else{

                    if(option == 4 && quantity > 2){
                        
                        Console.WriteLine("Esta operacion solo trabaja con 2 numeros");
                    }else if(option == 5 && quantity > 2){
                        Console.WriteLine("Esta operacion solo trabaja con 2 numeros");
                    }else{

                        for(var i = 0; i < quantity; i++){
                            Console.WriteLine("Por favor introduzca un numero");
                            numbers.Add(Convert.ToInt32(Console.ReadLine())); 
                        }
                        var result = menu.ExecuteOperation(option, numbers, quantity);
                        Console.WriteLine("El resultado de su operacion es: " + result);
                        result = 0.0;
                    }
                    
                    Console.WriteLine("--PRESIONE ENTER PARA VOLVER AL MENU--");
                    Console.ReadKey();
                }
            }
        }
    }
}
