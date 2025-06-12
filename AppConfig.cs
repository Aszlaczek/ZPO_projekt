using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_AWzorek_167366
{
    internal class AppConfig
    {
        public string font { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string color { get; set; }
        public AppConfig() { }
        public AppConfig(string font, int width, int height, string color)
        {
            this.font = font;
            this.width = width;
            this.height = height;
            this.color = color;
        }
    }
}
