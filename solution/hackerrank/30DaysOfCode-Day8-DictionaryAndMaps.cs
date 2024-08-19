//https://www.hackerrank.com/challenges/30-dictionaries-and-maps
class DictionaryAndMaps {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> phones = new Dictionary<string, string>();
        
        for(int i=0;i<n;i++)
        {
            string []row = Console.ReadLine().Split(' ');
            phones.Add(row[0], row[1]);
            
        }
        
        while(true)
        {
            string search = Console.ReadLine();
            if(search== null)
                break;
            if(phones.ContainsKey(search))
            {
                Console.WriteLine(search +"="+phones[search]);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            
        }
    }
}
