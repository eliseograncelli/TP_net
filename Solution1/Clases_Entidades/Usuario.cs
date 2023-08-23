using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        private static int ultimoId = 0;
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private string email;

        public int Id { get; set; }
        public int Dni { get; set; }
        public string Nombre { get; set;}
        public string Apellido { get; set;}
        public string Email { get; set;}

        public Usuario(int dni, string nombre, string apellido, string email)
        {
            incrementaId();
            this.Id = ultimoId;
            this.Dni = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Email = email;
        }

        private static void incrementaId()
        {
            ultimoId++ ;
        }


        public Usuario()
        {

        }

        public void ABMUsuarios(List<Usuario> usuarios)
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

                        /*  Console.Write("Ingrese dni: "); int d = Convert.ToInt32(Console.ReadLine());
                          var us = BuscadorPorDNI(d, usuarios);
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

                          Console.Write("¿Desea ingresar otro usuario?\n1:Si - 2:No -> "); ok = Convert.ToInt16(Console.ReadLine()); */
                        //ALTAAAAAAAAAAAAAAAa
                        alta(usuarios);
                        Console.Write("¿Desea ingresar otro usuario?\n1:Si - 2:No -> "); ok = Convert.ToInt16(Console.ReadLine());
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("BAJA DE USUARIO\n");
                        var u = Buscador(usuarios);
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
                        var u = Buscador(usuarios);
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
                case 4:
                    Console.WriteLine("LISTADO DE USUARIOS A LA FECHA: {0}", DateTime.Now);
                    for (int i = 0; i < usuarios.Count(); i++)
                    {
                        Console.WriteLine("{0}\t|\t{1}\t|\t{2}\t{3}\t|\t{4}", usuarios[i].Id, usuarios[i].Dni, usuarios[i].Nombre, usuarios[i].Apellido, usuarios[i].Email);
                    }
                    break;
            }
        }


        Usuario Buscador(List<Usuario> usuarios)   // Buscador de usuarios por dni
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


Usuario BuscadorPorDNI(int d, List<Usuario> usuarios)   // Buscador de usuarios - sobrecarga - con dni como parametro
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
        
        public void alta(List<Usuario> usuarios)
        {
            Console.Write("Ingrese dni: "); int d = Convert.ToInt32(Console.ReadLine());
            var us = BuscadorPorDNI(d, usuarios);
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
        }



    }
}
