/*Numero mayor ingresado y el menor*/
static void maomi()
{
    int num = 0;
    int max = int.MinValue;
    int min = int.MaxValue;
    int centi= 0;
    Console.WriteLine("Si desea salir ingrese 0");
    do
    {

        Console.WriteLine("Ingrese valores mayores a 0:");
        num = int.Parse(Console.ReadLine());
        if (num != 0)
        {
            max = Math.Max(max, num);
            min = Math.Min(min, num);
            centi++;
        }

    } while (num != 0);
    if (centi !=0)
    {
        Console.WriteLine("El numero mayor es " + max);
        Console.WriteLine("El numero menor es " + min);
    }
    Console.WriteLine("Presione enter para volver al menu de opciones");
    Console.ReadKey();
}

/*Adivinir el numero */
static void adivin()
{
    Console.WriteLine("Ingrese el numero");
    int num1= int.Parse(Console.ReadLine());
    int numpor = num1 * 2;
    int nummas = numpor + 8;
    int numpor2 = nummas * 5;
    string n = Convert.ToString (numpor2);
    string no = n.Substring (0,n.Length -1);
    int resul = Convert.ToInt32(no) - 4;
    Console.WriteLine("El numero ingresado fue: " + resul);
    Console.WriteLine("Presione enter para volver al menu de opciones");
    Console.ReadKey();
}


/*Contador de palabras*/
static void conta() { 
int l = 1;
int i = 0;
int v = 0;
Console.WriteLine("Ingrese una frase: ");
string fra = Console.ReadLine().ToLower().Trim();

    while (i < fra.Length)
    {
        if (fra[i] == ' ')
        {
            l++;

        }

        if (fra[i] == 'a'|| (fra[i] == 'e') || (fra[i] == 'i') || (fra[i] == 'o') || (fra[i] == 'u'))
        {
            v++;

        }
    i++;
}
Console.WriteLine("La frase tiene {0} palabras",l);
Console.WriteLine("La frase tiene {0} de vocales", v);
Console.WriteLine("Presione enter para volver al menu de opciones");
Console.ReadKey();

}

/*Palindromo*/

static void palito()
{
    Console.WriteLine("Ingrese la palabra que desea saber si es o no un palindromo ");
    string es = Console.ReadLine().ToLower().Trim();
    string spa = "";

    for (int p = es.Length - 1; p >= 0; p--)
    {
        spa = spa + es[p];

    }
    if (es == spa)
    {
        Console.WriteLine("Si es un palindromo");
    }
    else
    {
        Console.WriteLine("No es un palindromo");

    }
    Console.WriteLine("Presione enter para volver al menu de opciones");
    Console.ReadKey();
}
try
{
    int ope = 0;
    do
    {
        Console.Clear();
        Console.WriteLine("\t\tBienvenido al menu de opciones");
        Console.WriteLine("1. Numeros eneteros positivos");
        Console.WriteLine("2. Adivinar el numero que esta pensando");
        Console.WriteLine("3.Contador de palabras");
        Console.WriteLine("4. Palindromos");
        Console.WriteLine("0. Salir");
        ope = int.Parse(Console.ReadLine());
        if (ope != 0)
        {
            switch (ope)
            {
                case 1:
                    maomi();
                    break;
                case 2:
                    adivin();
                    break;
                case 3:
                    conta();
                    break;
                case 4:
                    palito();
                    break;
                default:
                    Console.WriteLine("Opcion ingresada no valida");
                    break;
            }
        }

    } while (ope != 0);
    Console.WriteLine("Fin del Programa");

}
catch (Exception ex)
{
    Console.WriteLine("Valor invalido");
}