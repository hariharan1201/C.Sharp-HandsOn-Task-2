using HandsOn2;
using System.ComponentModel;

//object initialization
Operation op  = new Operation();

Console.WriteLine("Calculation:\n1.Add\n2.Sub\n3.Multiply\n4.Division");   
Console.Write("Enter the operation:");
String choice= Console.ReadLine();

switch(choice.ToUpper())
{
    case "ADD" or "ADDITION":
        Console.Write("Enter value 1:");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter value 2:");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine(op.addnum(a,b));
        break;
    case "SUB" or "SUBRACTION" or "SUBRACT":
        Console.Write("Enter value 1:");
        int a2 = int.Parse(Console.ReadLine()); 
        Console.Write("Enter value 2:");
        int b2 = int .Parse(Console.ReadLine());
        if (a2> b2)
        {
            Console.WriteLine(op.subnum(a2,b2));
        }
        else
        {
            Console.WriteLine(op.subnum(b2,a2));
        }
        break;
    case "MUL" or "MULTI" or "MULTIPLY":
        Console.Write("Enter value 1:");
        int mula = int.Parse(Console.ReadLine());   
        Console.Write("Enter value 2:");
        int mulb = int.Parse(Console.ReadLine());
        Console.WriteLine(op.mulnum(mula,mulb));
        break;
    case "DIV" or "DIVISION":
        Console.Write("Enter value 1:");
        int diva = int.Parse(Console.ReadLine());
        Console.Write("Enter value 2:");
        int divb = int.Parse(Console.ReadLine());
        if(diva== 0 || divb ==0){
            Console.WriteLine("ERROR");
        }
    break;
}
   