// See https://aka.ms/new-console-template for more information
char letra ;

Console.WriteLine("Informe a letra: ");
   letra = char.Parse (Console.ReadLine());

if (letra == 'A' && letra == 'E' && letra == 'I' && letra == 'O' && letra == 'U'){
    Console.WriteLine ("E uma vogal! ");

}else 
    Console.WriteLine("E uma consoante");
