using System;

namespace calculator
{
    class Program
    {
        public static Menu menu { get; set; }
        static void Main(string[] args)
        {
            var numbers = new int[50];
            menu = new Menu();
            var user = menu.GetUsername();
            menu.ShowInitialMessage(user);
            menu.ShowMenu();
            var option = menu.GetOption();
            var quantity = menu.Quantity();
            if(quantity > 3){
                Console.WriteLine("No se aceptan mas de 3 operandos");
            }else{
                for(var i = 0; i < quantity; i++){
                    Console.WriteLine("Por favor introduzca un numero");
                    numbers[i] = Convert.ToInt32(Console.ReadLine()); 
                }
                menu.ExecuteOperation(option, numbers, quantity);
            }
            
            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}
