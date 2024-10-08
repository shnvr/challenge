//https://www.hackerrank.com/challenges/30-linked-list
namespace linked_list_example;
class Node
{
	public int data;
	public Node next;
    public Node(int d){
        data=d;
        next=null;
    }
		
}
class LinkedListExample {

	public static  Node insert(Node head,int data)
	{
      //Complete this method
        Node newNode = new Node(data);
        if(head==null)
        {
            head = newNode;
            return head;
        }
        
        Node last = head;
        while(last.next!= null)
            last = last.next;
        
        last.next = newNode;
        return head;
        
    }

	public static void display(Node head)
	{
		Node start=head;
		while(start!=null)
		{
			Console.Write(start.data+" ");
			start=start.next;
		}
	}
    static void Main(String[] args) {
	
		Node head=null;
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            int data=Int32.Parse(Console.ReadLine());
            head=insert(head,data);
        }
		display(head);
	}
}
	