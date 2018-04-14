//Given the angle (in degrees) of the hour-hand, return the time in HH:MM format. Round down to the nearest minute.

        static void Main(string[] args)
        {
            var res = WhatTimeIsIt(6.50);

            Console.WriteLine(res);

            Console.ReadKey();
        }

        public static string WhatTimeIsIt(double angle)
        {
            if (angle == 0 || angle == 360)
                return "12:00";

            int overall_minutes = (int)angle * 2;           //1d = 2 min

            double hours = overall_minutes / 60;
            double minutes = overall_minutes - hours*60;

            string ang = angle.ToString();
            int dot_index = ang.IndexOf(',');
            
            if (dot_index > 0)
            {
                if (ang[dot_index + 1] > '4')
                    minutes++;
            }

            //Console.WriteLine(hours + " : " + minutes);

            string result = "";

            if (hours >= 10)
                result += hours.ToString();
            else
                result += "0" + hours.ToString();

            if (result == "00")
                result = "12";

            result += ":";

            if (minutes >= 10)
                result += minutes.ToString();
            else
                result += "0" + minutes.ToString();

            return result;
        }
