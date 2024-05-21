/** 
    ///! Formato Compuesto 

    El formato compuesto usa marcadores de posicion dentro de una cadena.
    En tiempo de ejecucion, todo lo que hay dentro de las llaves se resolvera
    en un valor que tambien se pasa en funcion de su posicion.

    En este ejemplo de formato compuesto se usa un método Format() integrado en la palabra clave de tipo de datos string.
    Actualice el código en el editor de Visual Studio Code de la siguiente manera:

        ** string first = "Hello";
        ** string second = "World";
        ** string result = string.Format("{0} {1}", first, second);

        ** Console.WriteLine(result);

    Hay algunas aspectos importantes que tener en cuenta sobre este código.

    - Los tipos de datos y las variables de un tipo de datos determinado tienen "métodos auxiliares" integrados para facilitar tareas concretas.
    - La cadena literal "{0} {1}!" forma una plantilla, y algunos de sus elementos se reemplazarán en tiempo de ejecución.
    - El token {0} se reemplaza por el primer argumento después de la plantilla de cadena, es decir, el valor de la variable first.
    - El token {1} se reemplaza por el segundo argumento después de la plantilla de cadena, es decir, el valor de la variable second.

*/


/**
    ///! Interpolacion de Cadenas

    La interpolación de cadenas es una técnica que simplifica el formato compuesto.

    En lugar de usar un token numerado e incluir el valor literal o 
    el nombre de la variable en una lista de 
    argumentos para String.Format() o Console.WriteLine(), 
    puede usar simplemente el nombre de la variable dentro de las llaves.

    string first = "Hello";
    string second = "World";

    Console.WriteLine($"{first} {second}!");
    Console.WriteLine($"{second} {first}");
    Console.WriteLine($"{first} {first} {first}");

*/


/** 
    ///! Aplicacion de formato a valores de moneda

    El formato compuesto y la interpolación de cadenas se pueden usar para 
    dar formato a valores que se muestran en función de un idioma y una referencia cultural concretos. 
    En el ejemplo siguiente, se usa el especificador de formato de moneda 
    " :C " para presentar las variables price y discount como moneda. 
    Actualice el código de la manera siguiente:

    decimal price = 123.45m;
    int discount = 50; 

    Console.WriteLine($"Price: {price:C} (Save: {discount:C})");

*/

/** 
    ///! Aplicacion de formato a numeros

    Al trabajar con datos numéricos, podría
    querer dar formato al número para facilitar
    la lectura mediante la inclusión de puntos
    para delimitar miles, millones, miles de
    millones, etc.

    El especificador de formato numérico N hace
    que los números se lean mejor. Actualice el
    código de la manera siguiente:

    decimal measurement = 123456.78912m;
    Console.WriteLine($"Measurement: {measurement:N5} units");

    De forma predeterminada, el especificador de
    formato numérico N solo muestra dos dígitos
    después del separador decimal.

    Si quiere mostrar más precisión, puede
    agregar un número después del especificador.
    Ejemplo: N5
*/

/** 
    ///! Aplicacion de formato a porcentajes

    Use el especificador de formato P para dar
    formato a los porcentajes. Agregue un número
    después para controlar el número de valores
    que se muestran detrás del separador decimal.
    Actualice el código de la manera siguiente:

    decimal tax = .36785m;
    Console.WriteLine($"Tax: {tax:P1}"); // 36.79%
*/

/** 
    ///! Combinacion de enfoques de formato

    Las variables de cadena pueden almacenar
    cadenas creadas mediante técnicas de formato.
    En el ejemplo siguiente, se da formato a
    decimales y resultados matemáticos decimales
    y se almacenan en la cadena yourDiscount con
    formato compuesto.

    decimal price = 67.55m;
    decimal salePrice = 59.99m;

    string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

    yourDiscount += $"A discount of {(price - salePrice)/price:P2}!";

    Console.WriteLine($"{yourDiscount}");


    int invoiceNumber = 1201;
    decimal productShares = 25.4568m;
    decimal subtotal = 2750.00m;
    decimal taxPercentage = .15825m;
    decimal total = 3185.19m;

    Console.WriteLine($"Invoice Number: {invoiceNumber}");
    Console.WriteLine($"    Shares: {productShares:N3}");
    Console.WriteLine($"        Sub Total: {subtotal:C}");
    Console.WriteLine($"           Tax: {taxPercentage:P2}");
    Console.WriteLine($"     Total Billed: {total:C}");
*/

/** 
    ///? Ejercicio: Relleno y Alineacion

    Es posible que le pareciese un poco extraño
    que una palabra clave que representa un tipo
    de datos tuviese métodos a los que se puede
    llamar de la misma manera que se llama a los
    de la clase Console. La realidad es que hay
    muchos métodos similares en el tipo de datos
    string, así como cualquier cadena literal o
    variable de tipo cadena.
    

    Esta es una breve lista de categorías de estos métodos integrados para que se pueda hacer una idea de las posibilidades.

    - Métodos que agregan espacios en blanco para
    fines de formato (PadLeft(), PadRight())

    - Métodos que comparan dos cadenas o
    facilitan la comparación (Trim(), TrimStart
    (), TrimEnd(), GetHashcode(), la propiedad
    Length)

    - Métodos que ayudan a determinar lo que está
    dentro de una cadena, o incluso a recuperar
    solo una parte de la cadena (Contains(),
    StartsWith(), EndsWith(), Substring())

    - Métodos que cambian el contenido de la
    cadena mediante el reemplazo, la inserción o
    la eliminación de elementos (Replace(), Insert
    (), Remove(), RemoveRange(), RemoveStart()

    - Métodos que convierten una cadena en una
    matriz de cadenas o caracteres (Split(),
    ToCharArray())

    string input = "Pad this";
    Console.WriteLine(input.PadLeft(12, '-'));
    Console.WriteLine(input.PadRight(12, '-'));
*/