namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* PLATE 1 */
            int[] rasmus1Row1 = new int[] { 1, 20, 32, 71, 80 };
            int[] rasmus1Row2 = new int[] { 3, 11, 21, 38, 44 };
            int[] rasmus1Row3 = new int[] { 15, 29, 49, 58, 68 };

            Dictionary<string, int[]> plate1 = new Dictionary<string, int[]>();
            plate1.Add("Rasmus1-row1", rasmus1Row1);
            plate1.Add("Rasmus1-row2", rasmus1Row2);
            plate1.Add("Rasmus1-row3", rasmus1Row3);


            /* PLATE 2 */
            int[] rasmus2Row1 = new int[] { 1, 11, 21, 54, 64 };
            int[] rasmus2Row2 = new int[] { 2, 12, 22, 36, 86 };
            int[] rasmus2Row3 = new int[] { 16, 39, 47, 75, 89 };

            Dictionary<string, int[]> plate2 = new Dictionary<string, int[]>();
            plate2.Add("Rasmus2-row1", rasmus2Row1);
            plate2.Add("Rasmus2-row2", rasmus2Row2);
            plate2.Add("Rasmus2-row3", rasmus2Row3);


            /* PLATE 3 */
            int[] rasmus3Row1 = new int[] { 10, 25, 32, 42, 52 };
            int[] rasmus3Row2 = new int[] { 28, 33, 48, 56, 88 };
            int[] rasmus3Row3 = new int[] { 8, 14, 38, 69, 72 };

            Dictionary<string, int[]> plate3 = new Dictionary<string, int[]>();
            plate3.Add("Rasmus3-row1", rasmus3Row1);
            plate3.Add("Rasmus3-row2", rasmus3Row2);
            plate3.Add("Rasmus3-row3", rasmus3Row3);


            HandlePlate(plate1);
            HandlePlate(plate2);
            HandlePlate(plate3);
        }

        static void HandlePlate(Dictionary<string, int[]> dic)
        {
            int row1Counter = 0;
            int row2Counter = 0;
            int row3Counter = 0;
            int selectedNumber;
            bool fullPlate = false;


            do
            {
                Console.Write("Enter a number: ");
                try
                {
                    selectedNumber = int.Parse(Console.ReadLine());

                    foreach (var row in dic)
                    {
                        if (row.Value.Contains(selectedNumber))
                        {
                            if (row.Key == "Rasmus1-row1")
                            {
                                row1Counter++;
                            }
                            else if (row.Key == "Rasmus1-row2")
                            {
                                row2Counter++;
                            }
                            else if (row.Key == "Rasmus1-row3")
                            {
                                row3Counter++;
                            }
                        }
                    }

                    if (row1Counter == 5)
                    {
                        Console.WriteLine("BANKO! Row1");
                        row1Counter++;
                    }
                    if (row2Counter == 5)
                    {
                        Console.WriteLine("BANKO! Row2");
                        row2Counter++;
                    }
                    if (row3Counter == 5)
                    {
                        Console.WriteLine("BANKO! Row3");
                        row3Counter++;
                    }

                    if (row1Counter == 6 && row2Counter == 6 && row3Counter == 6)
                    {
                        fullPlate = true;
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers only.");
                }


            } while (fullPlate == false);

            Console.WriteLine("FULD PLADE!");
        }
    }
}
