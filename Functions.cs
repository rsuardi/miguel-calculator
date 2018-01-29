using System;
using System.Collections.Generic;
public class Functions{
    public double sumar(double[] numbers){

        var suma =0.0;
        foreach(var number in numbers){
            suma += number; 
        }

        return Math.Round(suma);
    }
    public double restar(double[] numbers){

        var resta =0.0;
        foreach(var number in numbers){
            resta -= number; 
        }

        return Math.Round(resta);
    }
    public double multiplicar(double[] numbers){

        var multiplica =0.0;
        foreach(var number in numbers){
            multiplica *= number; 
        }

        return Math.Round(multiplica,2);
    }
    public double dividir(double [] numbers){

        var result = 0.0;
        if(numbers[1] == 0){
            Console.WriteLine("No se puede dividir entre 0");        
        }else{
            var divide = numbers[0] / numbers[1];

            result = divide;
        }   
        return result;
    }
    public double porcentuar (double[] numbers){
        var resultado = numbers[0] * Convert.ToDouble("0."+numbers[1]);
            
        return resultado;  
    }
    public void salir(){
        Environment.Exit(0);
    }
}
