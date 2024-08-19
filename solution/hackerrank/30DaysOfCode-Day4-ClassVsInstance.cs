//https://www.hackerrank.com/challenges/30-class-vs-instance
class Person1 {
    public int age;     
	public Person1(int initialAge) {
        // Add some more code to run some checks on initialAge
        if(initialAge<0)
        {
            this.age = 0;
            Console.WriteLine("Age is not valid, setting age to 0.");
        }
        else this.age = initialAge;
     }
     public void amIOld() {
        // Do some computations in here and print out the correct statement to the console 
        if(age<13)
            Console.WriteLine("You are young.");
        else if(13<=age && age<18)
            Console.WriteLine("You are a teenager.");
        else
            Console.WriteLine("You are old.");
     }

     public void yearPasses() {
        // Increment the age of the person in here
        age++;
     }

static void Main(String[] args) {
        int T=int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++) {
            int age=int.Parse(Console.In.ReadLine());
            Person1 p=new Person1(age);
             p.amIOld();
                for (int j = 0; j < 3; j++) {
                  p.yearPasses();
                }
                p.amIOld();
                Console.WriteLine();
        }
    }
}