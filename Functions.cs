public class Functions{
    public int sumar(int[] numbers){

        var suma =0;
        foreach(var number in numbers){
            suma += number; 
        }

        return suma;
    }
    public int restar(int[] numbers){

        var resta =0;
        foreach(var number in numbers){
            resta -= number; 
        }

        return resta;
    }
    public int multiplicar(int[] numbers){

        var multiplica =0;
        foreach(var number in numbers){
            multiplica *= number; 
        }

        return multiplica;
    }
    public int dividir(int[] numbers){

        var divide =0;
        foreach(var number in numbers){
            divide /= number; 
        }

        return divide;
    }
    public int porcentuar(int[] numbers){

        var porcentaje =0;
        foreach(var number in numbers){
            porcentaje += number; 
        }

        return porcentaje;
    }
}
