// https://www.hackerrank.com/challenges/30-operators
namespace operators;
class Solution {

    // Complete the solve function below.
    static void solve(double meal_cost, int tip_percent, int tax_percent) {
        int result = 0;
        double tip = (meal_cost * tip_percent)/100;
        double tax = (meal_cost * tax_percent)/100;
        double total_cost = meal_cost + tip + tax;
        Console.WriteLine(Math.Round(total_cost,0));
        
    }

    static void Main(string[] args) {
        double meal_cost = Convert.ToDouble(Console.ReadLine());

        int tip_percent = Convert.ToInt32(Console.ReadLine());

        int tax_percent = Convert.ToInt32(Console.ReadLine());

        solve(meal_cost, tip_percent, tax_percent);
    }
}
