using System;

namespace calculator
{
    class Program
    {
        public static Menu menu { get; set; }
        public static bool isMenuActive = true;
        static void Main(string[] args)
        {
            var numbers = new double[50];
            menu = new Menu();
            var user = menu.GetUsername();

            while(isMenuActive){
                
                menu.ShowInitialMessage(user);
                menu.ShowMenu();
                var option = menu.GetOption();
                var quantity = menu.Quantity();
                if(quantity > 3){
                    Console.WriteLine("No se aceptan mas de 3 operandos");
                }else{
                    if(option == 4 || option == 5 && quantity > 2){
                        
                        Console.WriteLine("Esta operacion solo trabaja con 2 numeros");
                        return;
                    }
                    for(var i = 0; i < quantity; i++){
                        Console.WriteLine("Por favor introduzca un numero");
                        numbers[i] = Convert.ToInt32(Console.ReadLine()); 
                    }
                    menu.ExecuteOperation(option, numbers, quantity);
                    Console.WriteLine("--PRESIONE ENTER PARA VOLVER AL MENU--");
                    Console.ReadKey();
                }
            }
        }
    }
}
