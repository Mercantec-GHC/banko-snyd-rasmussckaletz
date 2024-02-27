using System.Numerics;

namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rasmus1Row1 = new int[] { 1, 20, 32, 71, 80 };
            int[] rasmus1Row2 = new int[] { 3, 11, 21, 38, 44 };
            int[] rasmus1Row3 = new int[] { 15, 29, 49, 58, 68 };

            int[] rasmus2Row1 = new int[] { 1, 11, 21, 54, 64 };
            int[] rasmus2Row2 = new int[] { 2, 12, 22, 36, 86 };
            int[] rasmus2Row3 = new int[] { 16, 39, 47, 75, 89 };

            int[] rasmus3Row1 = new int[] { 10, 25, 32, 42, 52 };
            int[] rasmus3Row2 = new int[] { 28, 33, 48, 56, 88 };
            int[] rasmus3Row3 = new int[] { 8, 14, 38, 69, 72 };

            Dictionary<string, int[]> threePlatesDic = new Dictionary<string, int[]>();
            threePlatesDic.Add("Rasmus1-row1", rasmus1Row1);
            threePlatesDic.Add("Rasmus1-row2", rasmus1Row2);
            threePlatesDic.Add("Rasmus1-row3", rasmus1Row3);
            threePlatesDic.Add("Rasmus2-row1", rasmus2Row1);
            threePlatesDic.Add("Rasmus2-row2", rasmus2Row2);
            threePlatesDic.Add("Rasmus2-row3", rasmus2Row3);
            threePlatesDic.Add("Rasmus3-row1", rasmus3Row1);
            threePlatesDic.Add("Rasmus3-row2", rasmus3Row2);
            threePlatesDic.Add("Rasmus3-row3", rasmus3Row3);

            HandlePlates(threePlatesDic);
        }



        static void HandlePlates(Dictionary<string, int[]> dic)
        {
            int plate1row1Counter = 0;
            int plate1row2Counter = 0;
            int plate1row3Counter = 0;

            int plate2row1Counter = 0;
            int plate2row2Counter = 0;
            int plate2row3Counter = 0;

            int plate3row1Counter = 0;
            int plate3row2Counter = 0;
            int plate3row3Counter = 0;

            bool plate1Full = false;
            bool plate2Full = false;
            bool plate3Full = false;

            int selectedNumber;
            bool gameActive = true;


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
                                plate1row1Counter++;
                            }
                            else if (row.Key == "Rasmus1-row2")
                            {
                                plate1row2Counter++;
                            }
                            else if (row.Key == "Rasmus1-row3")
                            {
                                plate1row3Counter++;
                            }
                            else if (row.Key == "Rasmus2-row1")
                            {
                                plate2row1Counter++;
                            }
                            else if (row.Key == "Rasmus2-row2")
                            {
                                plate2row2Counter++;
                            }
                            else if (row.Key == "Rasmus2-row3")
                            {
                                plate2row3Counter++;
                            }
                            else if (row.Key == "Rasmus3-row1")
                            {
                                plate3row1Counter++;
                            }
                            else if (row.Key == "Rasmus3-row2")
                            {
                                plate3row2Counter++;
                            }
                            else if (row.Key == "Rasmus3-row3")
                            {
                                plate3row3Counter++;
                            }
                        }
                    }

                    if (plate1row1Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 1 - Row1");
                        plate1row1Counter++;
                    }
                    if (plate1row2Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 1 - Row2");
                        plate1row2Counter++;
                    }
                    if (plate1row3Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 1 - Row3");
                        plate1row3Counter++;
                    }



                    if (plate2row1Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 2 - Row1");
                        plate2row1Counter++;
                    }
                    if (plate2row2Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 2 - Row2");
                        plate2row2Counter++;
                    }
                    if (plate2row3Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 2 - Row3");
                        plate2row3Counter++;
                    }



                    if (plate3row1Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 3 - Row1");
                        plate3row1Counter++;
                    }
                    if (plate3row2Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 3 - Row2");
                        plate3row2Counter++;
                    }
                    if (plate3row3Counter == 5)
                    {
                        Console.WriteLine("BANKO! Plate 3 - Row3");
                        plate3row3Counter++;
                    }



                    if (plate1row1Counter == 6 && plate1row2Counter == 6 && plate1row3Counter == 6 && plate1Full == false)
                    {
                        Console.WriteLine("FULL PLATE - PLATE 1!");
                        plate1Full = true;
                    }

                    if (plate2row1Counter == 6 && plate2row2Counter == 6 && plate2row3Counter == 6 && plate2Full == false)
                    {
                        Console.WriteLine("FULL PLATE - PLATE 2!");
                        plate2Full = true;
                    }

                    if (plate3row1Counter == 6 && plate3row2Counter == 6 && plate3row3Counter == 6 && plate3Full == false)
                    {
                        Console.WriteLine("FULL PLATE - PLATE 3!");
                        plate3Full = true;
                    }

                    if (plate1Full && plate2Full && plate3Full)
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
