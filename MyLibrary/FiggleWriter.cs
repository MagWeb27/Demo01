using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class FiggleWriter
    {
        public void Write (String message)
        {
            Console.WriteLine(Figgle.FiggleFonts.Standard.Render(message));
        }
    }
}
