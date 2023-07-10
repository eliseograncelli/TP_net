using Clases_Entidades;

int op;
bool sigue = true;

while (sigue)
{
    Console.WriteLine("MENU");
    Console.WriteLine("1- ABM DE PRODUCTO\n" +
        "2- ABM DE USUARIO\n" +
        "0- SALIR");

    Console.Write("\n¿Que desea realizar? "); op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
           case 0: Console.WriteLine("Fin programa");
            sigue = false;
                break;
           case 1: Console.WriteLine("ABM PRODUCTO");
                break;
            case 2: Console.WriteLine("ABM USUARIO");
                break;
    }
   
}


/* ABM PRODUCTOS
void ABMProd()
{
    Producto p;
    int op;
    Console.WriteLine("ABM DE PRODUCTOS\n");
    Console.Write("¿Que desea hacer?\n1- Alta de producto\t2-Baja de producto\t3-Modificar producto");
    op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            p = new Producto(); 
            break;
    }
}*/


// ABM USUARIOS
/*void ABMUsuarios()
{
    Cliente c;
    int op;
    Console.WriteLine("ABM DE PRODUCTOS\n");
    Console.Write("¿Que desea hacer?\n1- Alta de producto\t2-Baja de producto\t3-Modificar producto");
    op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            p = new Producto();
            break;
    }
*/

// HACER ABM DE USUARIOS EN UNA LISTA, HARDCODEADO Y SOLAMENTE ESO EN CONSOLA.    TAMBIEN HACER UN WINFORM
// DESPUES DE LAS VACACIONES HAY QUE PERSISITIR CON BD