using Clases_Entidades;
using Entidades;
using System.Collections;
using System.Timers;

int op;
bool sigue = true;
var usuarios = new List<Usuario>();
//int ok = 1;

while (sigue)
{
    Console.WriteLine("MENU");
    Console.WriteLine("1- ABM DE PRODUCTO\n" +
        "2- ABM DE USUARIO\n" +
        "0- SALIR");

    Console.WriteLine("\n¿Que desea realizar? "); op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
           case 0: Console.WriteLine("Fin programa");
            sigue = false;
                break;
           case 1: Console.WriteLine("ABM PRODUCTO en construccion\n\n----------------------------------------\n");
                break;
            case 2: 
            ABMUsuarios();
            Console.WriteLine("\n\n----------------------------------------\n");
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
void ABMUsuarios()
{
    int op;
    Console.WriteLine("ABM DE USUARIOS\n");
    Console.WriteLine("¿Que desea hacer?\n1- Alta de usuario\t2-Baja de usuario\t3-Modificar usuario\t4- Ver listado de usuarios");
    op = Convert.ToInt16(Console.ReadLine());
    switch (op)
    {
        case 1:
            int ok = 1;
            while (ok == 1)
            {
                
                Console.Write("Ingrese dni: "); int d = Convert.ToInt32(Console.ReadLine());
                var us = BuscadorPorDNI(d);
                //var us = Buscador(d);
                if (us == null)
                {
                    Console.Write("Ingrese nombre: "); string nom = Console.ReadLine();
                    Console.Write("Ingrese apellido: "); string ape = Console.ReadLine();
                    Console.Write("Ingrese email: "); string email = Console.ReadLine();
                    Usuario u = new Usuario(d, nom, ape, email);
                    usuarios.Add(u);
                    Console.WriteLine("Usuario n° {0}, creado exitosamente", u.Id);
                }
                else
                {
                    Console.WriteLine("El dni ingresado ya corresponde a un usuario registrado");
                }
                
                Console.Write("¿Desea ingresar otro usuario?\n1:Si - 2:No -> "); ok = Convert.ToInt16(Console.ReadLine());
            }
            break;
        case 2:
            {
                Console.WriteLine("BAJA DE USUARIO\n");
                var u = Buscador();
                if (u != null)
                {
                    Console.WriteLine("Usuario encontrado.\nId: {0}\nDni: {1}\n{2} {3}", u.Id, u.Dni, u.Nombre, u.Apellido);
                    Console.Write("¿Dar de baja?\n1:SI - 2:NO  ->  ");
                    op = Convert.ToInt16(Console.ReadLine());
                    if (op == 1)
                    {
                        usuarios.Remove(u);
                        Console.WriteLine("USUARIO ELIMINADO");
                    }

                }
            }
            break;
        case 3:
            {
                Console.WriteLine("MODIFICAR USUARIO");
                var u = Buscador();
                if (u != null)
                {
                    Console.WriteLine("Usuario encontrado.\nId: {0}\nDni: {1}\n{2} {3}", u.Id, u.Dni, u.Nombre, u.Apellido);
                    Console.Write("¿Modificar usuario?\n1:SI - 2:NO -> "); 
                    int opc = Convert.ToInt16(Console.ReadLine());
                    if (opc == 1)
                    {
                        Console.Write("Nombre actual: {0}\tIngrese nombre nuevo: ", u.Nombre); u.Nombre = Console.ReadLine();
                        Console.Write("Apellido actual: {0}\tIngrese apellido nuevo: ", u.Apellido); u.Apellido = Console.ReadLine();
                        Console.Write("Email actual: {0}\tIngrese email nuevo: ", u.Email); u.Email = Console.ReadLine();
                    }
                }

                break;
            }
        case 4: Console.WriteLine("LISTADO DE USUARIOS A LA FECHA: {0}", DateTime.Now);
            for (int i=0; i < usuarios.Count(); i++) 
            { 
                Console.WriteLine("{0}\t|\t{1}\t|\t{2}\t{3}\t|\t{4}", usuarios[i].Id, usuarios[i].Dni, usuarios[i].Nombre, usuarios[i].Apellido, usuarios[i].Email); 
            }
            break;
    }
}


Usuario Buscador()   // Buscador de usuarios por dni
{
    Console.WriteLine("Ingrese dni del usuario: ");
    int d = Convert.ToInt32(Console.ReadLine());
    foreach (Usuario u in usuarios)
    {
        if (d == u.Dni)
        {
            return u;
        }
    }
    Console.WriteLine("Usuario con dni {0} inexistente", d);
    return null; 
}


Usuario BuscadorPorDNI(int d)   // Buscador de usuarios - sobrecarga - con dni como parametro
//Usuario Buscador(int d)
{
    foreach (Usuario u in usuarios)
    {
        if (d == u.Dni)
        {
            return u;
        }
    }
    return null; ;
}



// HACER ABM DE USUARIOS EN UNA LISTA, HARDCODEADO Y SOLAMENTE ESO EN CONSOLA.    TAMBIEN HACER UN WINFORM
// DESPUES DE LAS VACACIONES HAY QUE PERSISITIR CON BD