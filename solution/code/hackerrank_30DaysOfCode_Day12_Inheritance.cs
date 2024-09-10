//https://www.hackerrank.com/challenges/30-inheritance
class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}

class Student : Person{
    private int[] testScores;  
  
    /*	
    *   Class Constructor
    *   
    *   Parameters: 
    *   firstName - A string denoting the Person's first name.
    *   lastName - A string denoting the Person's last name.
    *   id - An integer denoting the Person's ID number.
    *   scores - An array of integers denoting the Person's test scores.
    */
    // Write your constructor here
     public Student(string firstName, string lastName, int id,int[] scores)
     {
         base.firstName = firstName;
         base.lastName = lastName;
         base.id = id;
         this.testScores = scores;
     }
    
    /*	
    *   Method Name: Calculate
    *   Return: A character denoting the grade.
    */
    // Write your method here
    public string Calculate()
    {
        int total = 0;
        double avarage = 0.0;
        for(int i = 0; i<testScores.Length; i++)
        {
            total += testScores[i];
            
        }
        avarage = total/testScores.Length;
        //Console.WriteLine(avarage);
        if(avarage<40)
            return "T";
        else if(40<=avarage&&avarage<55)
            return "D";
        else if(55<=avarage&&avarage<70)
            return "P";
        else if(70<=avarage&&avarage<80)
            return "A";
        else if(80<=avarage&&avarage<90)
            return "E";
        else if(90<=avarage&&avarage<=100)
            return "O";
        
        return "X";
    }
}

class Inheritance {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.Calculate() + "\n");
	}
}