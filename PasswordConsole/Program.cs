﻿// PROGRAMA DE TAREA CURSO C# - COMISION 58430 - GASTON TEJADA


// Contraseña establecida
string passwordCorrecta = "usSystem-2022";

// Número de intentos permitidos
int intentosPermitidos = 5;

// Contador de intentos
int intentos = 0;

// variable para alojar el valor de respuesta del usuario
string respuesta;

// variable para manejar el valor de respuesta correcta o incorrecta
bool contraseñaCorrecta = false; 


while ( intentos < intentosPermitidos )
{
    if ( intentos == 0 )
    {
        Console.WriteLine($"Ingrese una contraseña. Tiene {intentosPermitidos} intentos");
    }
    else
    {
        int intentosRestantes = intentosPermitidos - intentos;
        Console.WriteLine($"Ingrese una contraseña. Le quedan {intentosRestantes} intentos");
    }

    respuesta = Console.ReadLine();

    if ( String.IsNullOrEmpty(respuesta))
    {
        Console.WriteLine();
        Console.WriteLine("La contraseña ingresada es vacia o nula, intente nuevamente.");
    }
    else
    {
        if (respuesta.Equals(passwordCorrecta))
        {
            intentos = intentosPermitidos;
            contraseñaCorrecta = true;
        }
        else
        {
            intentos++;                                      
            Console.WriteLine("La contraseña es incorrecta, intente nuevamente...");
            Console.WriteLine();
          
        }
     }
}

            // Si se alcanzó el número máximo de intentos
if (intentos == intentosPermitidos)
{
    if (contraseñaCorrecta)
    {
        Console.WriteLine();
        Console.WriteLine("La contraseña es correcta. Acceso permitido.");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("No es posible acceder al sistema. El sistema se cerrará.");
    }

}
