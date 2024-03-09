



static void suma()
{

    int val1, res, val2 = 0;
    Console.WriteLine("INGRESE VALOR 1");
    val1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("INGRESE VALOR 2");
    val2 = Convert.ToInt32(Console.ReadLine());
    res = val1 + val2;
    Console.WriteLine("suma :  " + res);

    Console.WriteLine("");





}


static void datos()
{



    Console.WriteLine("¿Cual es su nombre?");
    string nombre = Console.ReadLine();

    Console.WriteLine("!MUCHO GUSTO! " + nombre);


}



static void Edad()
{

    Console.WriteLine("INGRESE SU AÑO DE NACIMIENTO");

    int anio = Convert.ToInt32(Console.ReadLine());
    int edad = 2024 - anio;
    Console.WriteLine("su edad es = " + edad);
}


int opi = 0;

do
{

    Console.WriteLine("***********************************");
    Console.WriteLine("Elija una opción:");
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("1. Suma");
    Console.WriteLine("2. Datos");
    Console.WriteLine("3. Edad");
    Console.WriteLine("4. Salir");
    Console.WriteLine("**************************************");

    opi = int.Parse(Console.ReadLine());

    switch (opi)
    {
        
        case 1: suma();
            break;


        case 2:
            datos();
            break;
        case 3:
            Edad();
            break;

        case 4:
            Console.WriteLine("SALIENDO DEL PROGRAMA");
            break;



        default: Console.WriteLine("OPCION INCORRECTA");
            break;



    }




}while (opi !=4);
Console.WriteLine(":)");
static int suma2 (int var1, int var2){

    int resi = var1 + var2;
    return resi;    

}
int sumanum = suma2(10, 20);
Console.WriteLine(sumanum);

static string nombre1 ()
{

    string nombre1 = "";
    Console.WriteLine("Ingrese el nombre");
    nombre1 = Console.ReadLine();
    return nombre1;





}