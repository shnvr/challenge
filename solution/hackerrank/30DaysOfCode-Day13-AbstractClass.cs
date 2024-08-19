//https://www.hackerrank.com/challenges/30-abstract-classes
abstract class Book
{
    
    protected String title;
    protected  String author;
    
    public Book(String t,String a){
        title=t;
        author=a;
    }
    public abstract void display();


}

//Write MyBook class
class MyBook :Book{
    public int price = 0;
    public MyBook(String t,String a, int p):base(t,a)
    {
      this.price = p;   
    }
    
    public override void display()
    {
        Console.WriteLine("Title: " + base.title + "\nAuthor: " + base.author + "\nPrice: " + price);
    }
}

class AbstractClass {
    static void Main(String[] args) {
      String title=Console.ReadLine();
      String author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}