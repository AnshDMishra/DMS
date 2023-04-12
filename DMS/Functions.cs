using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS
{
    public static class  Functions
    {
        public static string systemFolder =  "C:\\Users\\Ansh\\Pictures\\DDMSImages";
        public static string Generator()
        {
            Random rnd = new Random();
            int month = rnd.Next(1, 13);
            int dice = rnd.Next(1, 7);
            int card = rnd.Next(52);

            string final = (card + "" + dice + "" + month).ToString();
            return final;
        }
    }
}
