//https://www.hackerrank.com/challenges/time-conversion
class TimeConversion {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        string a = s.Substring(s.Length - 2,2);
        s = s.Substring(0, s.Length - 2);
        int hour = Convert.ToInt32(s.Substring(0, s.IndexOf(":")));
        if(a == "AM")
        {
            hour = (hour + 12)%12;    
        }
        else if(a == "PM")
        {          
            hour = hour<12 ? hour+12: hour ;           
        }
        s = hour.ToString("00") + s.Substring(s.IndexOf(":"));
        return s;
    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
