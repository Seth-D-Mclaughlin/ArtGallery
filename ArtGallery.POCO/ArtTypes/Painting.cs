using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.POCO
{
    public class Painting : IArt
    {
        public Painting(string name, string artist, DateTime start, DateTime finish, double height, double width)
        {
            Name = name;
            Artist = artist;
            Start = start;
            Finish = finish;
            Height = height;
            Width = width;
        }

        public string Name { get; set; }
        public string Artist { get; set; }
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public int TimeToCreate
        {
            get
            {
                TimeSpan differenceInTime = Start - Finish;
                int days = (int)differenceInTime.TotalDays;
                return days;
            }
        }

        public double Height { get; set; }
        public double Width { get; set; }

        
    }
}
