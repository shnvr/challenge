//https://www.hackerrank.com/challenges/30-queues-stacks
using System.Collections;

namespace QueueAndStack;
class Solution{
    //Write your code here
    Stack s = new Stack();
    Queue q = new Queue();
    void pushCharacter(char ch)
    {
        s.Push(ch);
    }
    void enqueueCharacter(char ch)
    {
        q.Enqueue(ch);
    }
    char popCharacter()
    {
        object obj = s.Pop();
        return Convert.ToChar(obj);
    }
    char dequeueCharacter()
    {
        object obj = q.Dequeue();
        return Convert.ToChar(obj);
    }
    

    static void Main(String[] args) {
        // read the string s.
        string s = Console.ReadLine();
        
        // create the Solution class object p.
        Solution obj = new Solution();
        
        // push/enqueue all the characters of string s to stack.
        foreach (char c in s) {
            obj.pushCharacter(c);
            obj.enqueueCharacter(c);
        }
        
        bool isPalindrome = true;
        
        // pop the top character from stack.
        // dequeue the first character from queue.
        // compare both the characters.
        for (int i = 0; i < s.Length / 2; i++) {
            if (obj.popCharacter() != obj.dequeueCharacter()) {
                isPalindrome = false;
                
                break;
            }
        }
        
        // finally print whether string s is palindrome or not.
        if (isPalindrome) {
            Console.Write("The word, {0}, is a palindrome.", s);
        } else {
            Console.Write("The word, {0}, is not a palindrome.", s);
        }
    }
}