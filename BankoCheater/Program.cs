namespace BankoCheater
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] rasmus1Row1 = [1, 20, 32, 71, 80];
            int[] rasmus1Row2 = [3, 11, 21, 38, 44];
            int[] rasmus1Row3 = [15, 29, 49, 58, 68];

            Dictionary<string, Array> dic = new Dictionary<string, Array>();
            dic.Add("Rasmus1-row1", rasmus1Row1);
            dic.Add("Rasmus1-row2", rasmus1Row2);
            dic.Add("Rasmus1-row3", rasmus1Row3);

            foreach (KeyValuePair<string, Array> dict in dic)
            {
                
                /*if (dict.Value.Equals("68"))
                {
                    Console.WriteLine("ja");
                }*/
                
            }



            /*
            dic.Add("Rasmus1-row1", "1    20 32           71 80");
            dic.Add("Rasmus1-row2", "3 11 21 38 44            ");
            dic.Add("Rasmus1-row3", "  15 29    49 58 68      ");
            */

            /*
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("Rasmus1-row1", "1,    20,32,          71,80");
            dic.Add("Rasmus1-row2", "3,11,21,38,44            ");
            dic.Add("Rasmus1-row3", "  15,29,    49,58,68      ");
            foreach (KeyValuePair<string, string> dict in dic)
            {
                Console.WriteLine(dict.Value.Split(","));
                if (dict.Value.Equals("68"))
                {
                    Console.WriteLine("ja");
                }
                
            }
            */
        }
    }
}
