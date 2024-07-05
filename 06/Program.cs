int  numb1,numb2,numb3;

Console.WriteLine("Informe o numero:");
    numb1 = int.Parse(Console.ReadLine());
    numb2 = int.Parse(Console.ReadLine());
    numb3 = int.Parse(Console.ReadLine());


if (numb1>numb2){

    if (numb1>numb3)
    {
        Console.WriteLine($"o maior numero e {numb1}");
    }
    else{
        Console.WriteLine($"o maior numero e {numb3}");}
        }
    
    else
    {
        if (numb2>numb3) {
            Console.WriteLine($"o maior numero e {numb2}");
            
        }
        else{
            Console.WriteLine($"o maior numero e {numb3}");
        }
    }
if (numb1<numb2){

    if (numb1<numb3)
    {
        Console.WriteLine($"o menor numero e {numb1}");
    }
    else{
        Console.WriteLine($"o menor numero e {numb3}");}
        }
    
    else
    {
        if (numb2<numb3) {
            Console.WriteLine($"o menor numero e {numb2}");
            
        }
        else{
            Console.WriteLine($"o menor numero e {numb3}");
        }
    }