//**Задача 18:** Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти оси координат: ");
int o = int.Parse(Console.ReadLine());

if(o == 1){
    Console.WriteLine("X>0; Y>0");
}   
if(o == 2){
    Console.WriteLine("X<0; Y>0");
}
if(o == 3){
    Console.WriteLine("X<0; Y<0");
}
if(o == 4){
    Console.WriteLine("X>0; Y<0");
}
