int  pro1,pro2,pro3;

Console.WriteLine("Informe o valor dos produtos: ");
    pro1 = int.Parse(Console.ReadLine());
    pro2 = int.Parse(Console.ReadLine());
    pro3 = int.Parse(Console.ReadLine());


if (pro1<pro2){

    if (pro1<pro3)
    {
        Console.WriteLine($"o menor valor e: {pro1}$");
    }
    else{
        Console.WriteLine($"o menor valor e:  {pro3}$");}
        }
    
    else
    {
        if (pro1<pro3) {
            Console.WriteLine($"o menor valor e:  {pro2}$");
            
        }
        else{
            Console.WriteLine($"o menor valor e:  {pro3}$");
        }
    }

