using System;
public class Menu{

    public string Username { get; set;}
    public Functions functions { get; set; }
    public Menu()
    {
        functions = new Functions();
    }

    public void ShowInitialMessage(string user){

       Console.WriteLine("-------------------------------------");
       Console.WriteLine("");
        Console.WriteLine("BIENVENIDO --" + user.ToUpper() + "-- A SU CALCULADORA PERSONAL");
        Console.WriteLine("");
    }
    public void ShowMenu(){

        Console.WriteLine("1) Suma");
        Console.WriteLine("2) Resta");
        Console.WriteLine("3) Multiplicacion");
        Console.WriteLine("4) Division");
        Console.WriteLine("5) Porcentaje");

        Console.WriteLine("-------------------------------------");
    }

    public int GetOption(){
        Console.WriteLine("Por favor introduzca una opcion de estas");
        Console.WriteLine ("");
        
        var option = Convert.ToInt32(Console.ReadLine());
        return option;
    }

    public string GetUsername(){
        Console.WriteLine("Por favor introduzca su nombre de usuario.");
        var user = Console.ReadLine();
        return user;
    }

    public void ExecuteOperation(int option, int [] numbers, int quantity){

        var result = 0;
        switch(option){

            case 1:
                result = functions.sumar(numbers);
            break;

            case 2:
                result = functions.restar(numbers);
            break;

            case 3:
                result = functions.multiplicar(numbers);
            break;

            case 4:
                result = functions.dividir(numbers);
            break;
            case 5:
                result = functions.porcentuar(numbers);
            break;
        }
        Console.WriteLine("El resultado de su operacion es: " + result);
    }

    public int Quantity(){

        Console.WriteLine("Cuantos numeros va a operar?");
        Console.WriteLine ("");
        
        var quantity = Convert.ToInt32(Console.ReadLine());
        /* 
        while(option.GetType() != typeof(int)){
            Console.WriteLine("Debe ser una opcion numerica");  

        }
        */
        return quantity;
    
    }
}