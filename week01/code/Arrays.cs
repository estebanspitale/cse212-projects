public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Paso 1: Crear un arreglo de tamaño 'length'
        double[] multiples = new double[length];

        // Paso 2: Usar un bucle for desde 0 hasta length-1
        for (int i = 0; i < length; i++)
        {
            // Paso 3: Guardar en cada posición el múltiplo correspondiente
            multiples[i] = number * (i + 1);
        }

        // Paso 4: Devolver el arreglo
        return multiples;
    }
        
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Paso 1: Normalizar la cantidad de rotaciones
        amount = amount % data.Count;

        // Paso 2: Tomar los últimos 'amount' elementos
        var tail = data.GetRange(data.Count - amount, amount);

        // Paso 3: Tomar los primeros elementos restantes
        var head = data.GetRange(0, data.Count - amount);

        // Paso 4: Limpiar la lista original
        data.Clear();

        // Paso 5: Agregar primero los últimos y luego los primeros
        data.AddRange(tail);
        data.AddRange(head);
    }
}
