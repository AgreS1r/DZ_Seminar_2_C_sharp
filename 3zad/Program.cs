Console.WriteLine("Enter number (1-7) ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 7) {
    if (num >= 6 && num <= 7){
    Console.WriteLine("Да, выходной");
}
else{
    Console.WriteLine("Нет, будний");
}
}
else{  
    Console.WriteLine("Enter number (1-7)!!!");
}



