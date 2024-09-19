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
    // we are given two values: number and length
    // to start off, we would like to make code that begins with the first number
    // for example, if we are given (7, 5), then we want to make a loop that lasts 5 steps
    // each step, we add an item to a new list, probably called multiples
    // step one: add an item to the list; the item should be the number * whatever step we are at in the loop
    // for example, if our loop is about to end at step 5, then the number should be 35, but at step one, it would be 7
    // this should give us a list of elements that work.

        // start out by making array
        double[] multiples = new double[length];

        // make loop
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

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
        // we are given a list of numbers and a number to determine how many times to rotate
        // next, loop for the specified amount of times (amount)
        // in each loop iteration, remove the last element from the list and insert it at the front
        // after completing all the rotations, the list should be in the correct order

        for (int i = 0; i < amount; i++)
        {
            // Store the last element of the list
            int lastElement = data[data.Count - 1];

            // Remove the last element
            data.RemoveAt(data.Count - 1);

            // Insert the stored last element at the beginning of the list
            data.Insert(0, lastElement);
        }
    }
}
