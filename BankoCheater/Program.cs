using System.Numerics;

namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int[]> threePlatesDic = new Dictionary<string, int[]>
            {
                { "Rasmus1-row1", new int[] { 1, 20, 32, 71, 80 } },
                { "Rasmus1-row2", new int[] { 3, 11, 21, 38, 44 } },
                { "Rasmus1-row3", new int[] { 15, 29, 49, 58, 68 } },
                { "Rasmus2-row1", new int[] { 1, 11, 21, 54, 64 } },
                { "Rasmus2-row2", new int[] { 2, 12, 22, 36, 86 } },
                { "Rasmus2-row3", new int[] { 16, 39, 47, 75, 89 } },
                { "Rasmus3-row1", new int[] { 10, 25, 32, 42, 52 } },
                { "Rasmus3-row2", new int[] { 28, 33, 48, 56, 88 } },
                { "Rasmus3-row3", new int[] { 8, 14, 38, 69, 72 } }
            };


            HandlePlates(threePlatesDic);

        }

        static void HandlePlates(Dictionary<string, int[]> dic)
        {
            List<int> drawnNumbers = new List<int>();

            int[] plate1Counter = new int[3];
            int[] plate2Counter = new int[3];
            int[] plate3Counter = new int[3];

            bool[] platesFull = new bool[3];

            int selectedNumber;
            bool gameActive = true;


            do
            {
                Console.Write("Enter a number: ");
                try
                {
                    selectedNumber = int.Parse(Console.ReadLine());

                    if (drawnNumbers.Contains(selectedNumber))
                    {
                        Console.WriteLine($"{selectedNumber} has already been used. Pick a different number.");
                        continue;
                    }

                    foreach (var row in dic)
                    {
                        if (row.Value.Contains(selectedNumber))
                        {
                            if (row.Key == "Rasmus1-row1")
                            {
                                plate1Counter[0]++;
                            }
                            else if (row.Key == "Rasmus1-row2")
                            {
                                plate1Counter[1]++;
                            }
                            else if (row.Key == "Rasmus1-row3")
                            {
                                plate1Counter[2]++;
                            }
                            else if (row.Key == "Rasmus2-row1")
                            {
                                plate2Counter[0]++;
                            }
                            else if (row.Key == "Rasmus2-row2")
                            {
                                plate2Counter[1]++;
                            }
                            else if (row.Key == "Rasmus2-row3")
                            {
                                plate2Counter[2]++;
                            }
                            else if (row.Key == "Rasmus3-row1")
                            {
                                plate3Counter[0]++;
                            }
                            else if (row.Key == "Rasmus3-row2")
                            {
                                plate3Counter[1]++;
                            }
                            else if (row.Key == "Rasmus3-row3")
                            {
                                plate3Counter[2]++;
                            }
                        }
                    }


                    drawnNumbers.Add(selectedNumber);


                    if (plate1Counter[0] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 1 - Row1");
                        plate1Counter[0]++;
                    }

                    if (plate1Counter[1] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 1 - Row2");
                        plate1Counter[1]++;
                    }

                    if (plate1Counter[2] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 1 - Row3");
                        plate1Counter[2]++;
                    }



                    if (plate2Counter[0] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 2 - Row1");
                        plate2Counter[0]++;
                    }
                    if (plate2Counter[1] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 2 - Row2");
                        plate2Counter[1]++;
                    }
                    if (plate2Counter[2] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 2 - Row3");
                        plate2Counter[2]++;
                    }



                    if (plate3Counter[0] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 3 - Row1");
                        plate3Counter[0]++;
                    }
                    if (plate3Counter[1] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 3 - Row2");
                        plate3Counter[1]++;
                    }
                    if (plate3Counter[2] == 5)
                    {
                        Console.WriteLine("BANKO! Plate 3 - Row3");
                        plate3Counter[2]++;
                    }



                    if (plate1Counter[0] == 6 && plate1Counter[1] == 6 && plate1Counter[2] == 6 && platesFull[0] == false)
                    {
                        Console.WriteLine("FULL PLATE - PLATE 1!");
                        platesFull[0] = true;
                    }

                    if (plate2Counter[0] == 6 && plate2Counter[1] == 6 && plate2Counter[2] == 6 && platesFull[1] == false)
                    {
                        Console.WriteLine("FULL PLATE - PLATE 2!");
                        platesFull[1] = true;
                    }

                    if (plate3Counter[0] == 6 && plate3Counter[1] == 6 && plate3Counter[2] == 6 && platesFull[2] == false)
                    {
                        Console.WriteLine("FULL PLATE - PLATE 3!");
                        platesFull[2] = true;
                    }

                    if (platesFull[0] && platesFull[1] && platesFull[2])
                    {
                        Console.WriteLine("ALL PLATES FULL!");
                        gameActive = false;
                    }


                }
                catch (FormatException)
                {
                    Console.WriteLine("Numbers only.");
                }


            } while (gameActive == true);
        }
    }
}
