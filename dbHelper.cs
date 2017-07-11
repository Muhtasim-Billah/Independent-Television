//Author: Muhtasim Billah
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Count_Down
{
    public partial class Entities 
    {

        public int getDuration(string day,int hour,int sequence)
        {
            try
            {
                int i = (from q in genTimings where q.TDay .Equals(day) && q.THour == hour && q.TSequence == sequence  select q.TDuration).ToList().ElementAt(0);
                return i;
            }
            catch (Exception ex)
            {
                return -1;
            }
        }

       /* public string getTime(string time)
        {
            string s = (from m in genTimings where m.TDate.Equals(time) select m.TDate).ToList().ElementAt(0);
        }
        */

    }
}
