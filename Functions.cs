using System;
using System.Collections.Generic;
using System.Linq;
public class Functions{
    public double sumar(List<double> numbers){

        var suma = 0.0;
        if (numbers.Count == 2){
            
                suma = (numbers.ElementAt(0) + numbers.ElementAt(1));
            
        }else{
            
                suma = numbers.ElementAt(0) + numbers.ElementAt(1) + numbers.ElementAt(2);
            
        }
        
        return suma;
    }
    public double restar(List<double> numbers){

        var resta = 0.0;
        if (numbers.Count == 2){
            
                resta = (numbers.ElementAt(0) - numbers.ElementAt(1));
            
        }else{
            
                resta = (numbers.ElementAt(0) - numbers.ElementAt(1)) - numbers.ElementAt(2);
            
        }
        
        return resta;
    }
    public double multiplicar(List<double> numbers){

        var multiplica = 1.0;
        for(var i = 0; i < numbers.Count; i++){
            var value = numbers.ElementAt(i);
            multiplica =  (multiplica * value);
        }
        return multiplica;
    }
    public double dividir(List<double> numbers){

        var result = 0.0;
        if(numbers[1] == 0){
            Console.WriteLine("No se puede dividir entre 0");        
        }else{
            var divide = numbers.ElementAt(0) / numbers.ElementAt(1);

            result = divide;
        }   
        return result;
    }
    public double porcentuar (List<double> numbers){
        var resultado = numbers.ElementAt(0) * Convert.ToDouble("0."+numbers.ElementAt(1));
            
        return resultado;  
    }
    public void salir(){
        Environment.Exit(0);
    }
}
