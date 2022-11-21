class Enteros{
    public int nums;
    public int acumulador;
    public void NumerosEnteros(){
        acumulador=1;
        do{
        Console.WriteLine("Ingrese los números que desee indefinidamente, si escribe 0 el programa finalizara");
        acumulador++;
        nums=Convert.ToInt32(Console.ReadLine());
        }while(nums!=0);
        Console.WriteLine("El programa a finalizado");
    }

}