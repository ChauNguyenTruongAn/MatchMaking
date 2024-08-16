using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swiper.Utils
{
    public class Picture
    {
        public Uri Uri { get; set; }

        public string Description { get; init; }

        public Picture()
        {
            Uri = new Uri($"https://picsum.photos/400/400/?random&ts={DateTime.Now.Ticks}");
            var generator = new DescriptionGenerator();
            Description = generator.Generate();
        }
    }
}
