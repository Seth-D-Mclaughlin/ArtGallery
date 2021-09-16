using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery.POCO
{
    public interface IArt
    {
        string Name { get; set; }
        string Artist { get; set; }
        DateTime Start { get; set; }
        DateTime Finish { get; set; }
        int TimeToCreate { get; }

        
    }
}
