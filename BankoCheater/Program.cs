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
                            switch (row.Key)
                            {
                                case "Rasmus1-row1":
                                    plate1Counter[0]++;
                                    break;
                                case "Rasmus1-row2":
                                    plate1Counter[1]++;
                                    break;
                                case "Rasmus1-row3":
                                    plate1Counter[2]++;
                                    break;
                                case "Rasmus2-row1":
                                    plate2Counter[0]++;
                                    break;
                                case "Rasmus2-row2":
                                    plate2Counter[1]++;
                                    break;
                                case "Rasmus2-row3":
                                    plate2Counter[2]++;
                                    break;
                                case "Rasmus3-row1":
                                    plate3Counter[0]++;
                                    break;
                                case "Rasmus3-row2":
                                    plate3Counter[1]++;
                                    break;
                                case "Rasmus3-row3":
                                    plate3Counter[2]++;
                                    break;
                            }
                        }
                    }

                    drawnNumbers.Add(selectedNumber);


                    for (int i = 0; i < 3; i++)
                    {
                        plate1Counter[i] += HandleBankoOnPlate(plate1Counter[i], 1, (i + 1));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        plate2Counter[i] += HandleBankoOnPlate(plate2Counter[i], 2, (i + 1));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        plate3Counter[i] += HandleBankoOnPlate(plate3Counter[i], 3, (i + 1));
                    }


                    platesFull[0] = HandleFullPlate(plate1Counter[0], plate1Counter[1], plate1Counter[2], platesFull[0], 1);
                    platesFull[1] = HandleFullPlate(plate2Counter[0], plate2Counter[1], plate2Counter[2], platesFull[1], 2);
                    platesFull[2] = HandleFullPlate(plate3Counter[0], plate3Counter[1], plate3Counter[2], platesFull[2], 3);


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



        static int HandleBankoOnPlate(int plateCounter, int plateID, int rowID)
        {
            if (plateCounter == 5)
            {
                Console.WriteLine($"BANKO! Plate {plateID} - Row {rowID}");
                return 1;
            }

            return 0;
        }


        static bool HandleFullPlate(int firstRowCounter, int secondRowCounter, int thirdRowCounter, bool plateFull, int plateID) 
        {
            if (!plateFull)
            {
                if (firstRowCounter == 6 && secondRowCounter == 6 && thirdRowCounter == 6 && !plateFull)
                {
                    Console.WriteLine($"FULL PLATE - PLATE {plateID}!");
                    return true;
                }
            } 
            else
            {
                return true;
            }

            return false;
        }
    }
}
