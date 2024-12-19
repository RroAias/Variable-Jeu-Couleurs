using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class ColorSet
    {
        float yellow;
        float red;
        float blue;
        float totalTime;

        public void RunOnColor(string color, float seconds)
        {
            totalTime += seconds;

            switch (color.ToLower())
            {
                case "yellow":
                    yellow = yellow + (3 * seconds);
                    if (yellow > 100) yellow = 100;

                    red = red - seconds;
                    if (red < 100) red = 0;

                    blue = blue - seconds;
                    if (blue < 100) blue = 0;
                    break;

                case "red":
                    red = red + (3 * seconds);
                    if (red > 100) red = 100;

                    yellow = yellow - seconds;
                    if (yellow < 0) yellow = 0;

                    blue = blue - seconds;
                    if (blue < 0) blue = 0;
                    break;

                case "blue":
                    blue = blue + (3 * seconds);
                    if (blue > 100) blue = 100;

                    yellow = yellow - seconds;
                    if (yellow < 0) yellow = 0;

                    red = red - seconds;
                    if (red < 0) red = 0;
                    break;
            }

        }

        public string GetColor()
        {
            bool hasYellow = yellow >= 3;
            bool hasRed = red >= 3;
            bool hasBlue = blue >= 3;

            if (hasYellow && hasRed && hasBlue)
                return "black";

            if (hasYellow && hasRed)
                return "orange";

            if (hasRed && hasBlue)
                return "purple";
            if (hasYellow && hasBlue)
                return "green";
            if (hasYellow)
                return "yellow";
            if (hasRed)
                return "red";
            if (hasBlue)
                return "blue";
            return "none";
        }
        public (float Yellow, float Red, float Blue, float Time) GetStatus()
        {
            return (yellow, red, blue, totalTime);
        }
    }

}
