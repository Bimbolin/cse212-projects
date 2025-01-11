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
        //  Create an array of size 'length' to store the multiples
        double[] multiples = new double[length];

        // Use a loop to generate multiples of the 'number' and store them in the array
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Return the array containing the multiples
        return multiples;
    }



    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// <summary> 
    public static void RotateListRight(List<int> data, int amount) 
    {
        // Step 1: Calculate the effective rotation amount
        amount = amount % data.Count;

        // Step 2: Extract the last 'amount' elements from the list 
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // Step 3: Remove these elements from the original list
        data.RemoveRange(data.Count - amount, amount); 

        // Step 4: Insert the extracted elements at the beginning of the list
        data.InsertRange(0, lastPart);
    } 
    public static void Run()
    {
            // Testing MultiplesOf function 
            var numbers = MultiplesOf(3, 5); // Example usage
            Console.WriteLine(string.Join(", ", numbers)); // Should output: 3, 6, 9, 12, 15

             List<int> data = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
              int amount = 3; 
              RotateListRight(data, amount); 
              Console.WriteLine(string.Join(", ", data)); // Should output: 7, 8, 9, 1, 2, 3, 4, 5, 6 
    }

}