using System;
using System.Collections;



List<string> Usuario = new List<string>();
List<string> Contraseña = new List<string>();
//List<string> Nombre = new List<string>();

Main();
        
void Main()
{
    Menu();
}

void Menu()
{
    int op = 0;
    string dato = "";


    do
    {
        Console.WriteLine("\n¿Que desea hacer?:\n1-Iniciar sesion\n2-Registrarse\n3-Salir");
        dato = Console.ReadLine();

                
        if (int.TryParse(dato, out op) && (op == 1 || op == 2 || op == 3 ))
        {
            switch (op)
            {
                case 1:
                    IniciarSesion();
                    break;
                case 2:
                    Registrarse();
                    break;
                case 3:
                    
                    //Salir();
                    break;
            }
            if(op == 3)
            {
                break;
            }
                    
        }
        else
        {
            Console.WriteLine("Error, Ingrese 1, 2 o 3 según lo que necesite");
        }


    } while (true);
}

void IniciarSesion()
{
    Console.WriteLine("\t\t##################################");
    Console.WriteLine("\t\t##\tINICIO DE SESIÓN\t##");
    Console.WriteLine("\t\t##################################\n");

    string usuario = "", contraseña = "", salir = "";
    bool seguir = true, inicioCorrecto = false;
    int getIndexUsuario = 0;
    do
    {
        Console.Write("Ingrese usuario: ");
        usuario = Console.ReadLine();

        usuario = usuario.Trim();

        Console.Write("Ingrese contraseña: ");
        contraseña = Console.ReadLine();

        contraseña = contraseña.Trim();

        if ( !(usuario.Length > 0 && usuario != "" && usuario != null) )
        {
            Console.WriteLine("Error, ingrese su usuario");
            continue;
        }

        if ( !(contraseña.Length > 0 && contraseña != "" && contraseña != null))
        {
            Console.WriteLine("Error, ingrese su contraseña");
            continue;
        }

        if (Usuario.Contains(usuario)) {
            if (Contraseña.Contains(contraseña))
            {
                //se obtiene el index en la lista Usuario del usuario para buscar en Contraseña que lo que haya en ese mismo indice sea igual a lo ingresado en contraseña
                getIndexUsuario = Usuario.IndexOf(usuario);

                if (Contraseña.ElementAt(getIndexUsuario) == contraseña)
                {
                    inicioCorrecto = true;
                    Console.WriteLine("Se ha iniciado sesión correctamente");
                    Salir();
                }
                else
                {
                    Console.WriteLine("Contraseña incorrecta");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
                break;
            }
        }
        else
        {
            Console.WriteLine("El usuario no existe");
            break;
        }
        

    } while (inicioCorrecto == false || !(usuario.Length > 0 && usuario != "" && usuario != null) || !(contraseña.Length > 0 && contraseña != "" && contraseña != null));
    //!(dato.Length > 0 && dato != "" && dato != null)
}


void Salir()
{
    string op = "";

    
        Console.WriteLine("Ingrese 1-si desea salir al menu principal u otra tecla para terminar la ejecución del programa");
        op = Console.ReadLine();
        
        if(op != "1"){
            Environment.Exit(0);
            Console.WriteLine("\nFin programa.\n");
    }   

    
}

void Registrarse()
{
    string nombre = "", usuario = "", contraseña = "";

    Console.WriteLine("\t\t##########################");
    Console.WriteLine("\t\t##\tREGISTRO\t##");
    Console.WriteLine("\t\t##########################\n");

    //comprobarNombre(nombre);
    comprobarUsuario(usuario);
    comprobarContraseña(contraseña);

    Console.WriteLine("Registro exitoso\n");

}

/*
void comprobarNombre(string dato)
{
    dato = "";

     
    do
    {
        Console.Write("Ingrese su nombre: ");
        dato = Console.ReadLine();
        dato = dato.Trim();

        

        if ( dato.Length > 0 && dato != "" && dato != null )
        {
            Nombre.Add(dato);
            break;
        }
        else
        {
            Console.WriteLine("Error, ingrese el campo nombre correctamente");
        }

    } while ( !(dato.Length > 0 && dato != "" && dato != null) );
}
*/

void comprobarUsuario(string dato)
{
    dato = "";

    do
    {
        Console.Write("Ingrese su usuario: ");
        dato = Console.ReadLine();
        dato = dato.Trim();



        if ( !(Usuario.Contains(dato)) && (dato.Length > 0 && dato != "" && dato != null) )
        {
            Usuario.Add(dato);
            break;
        }
        else
        {
            Console.WriteLine("Error, ingrese el campo usuario correctamente");
        }

    } while ( Usuario.Contains(dato) || !(dato.Length > 0 && dato != "" && dato != null));
}


void comprobarContraseña(string dato)
{
    dato = "";

    do
    {
        Console.Write("Ingrese su contraseña: ");
        dato = Console.ReadLine();
        dato = dato.Trim();



        if (dato.Length > 0 && dato != "" && dato != null)
        {
            Contraseña.Add(dato);
            break;
        }
        else
        {
            Console.WriteLine("Error, ingrese el campo contraseña correctamente");
        }

    } while (!(dato.Length > 0 && dato != "" && dato != null));
}






