class Solution
{
    //Complete this function
    public void printTriangle(int n)
    {
        for(int i=0; i<n; i++){
            for(int j=n; j> i; j--){
                Console.Write(n - j + 1 + " ");
            }
            Console.WriteLine("");
        }
        
        //Your code here
    }
}

// Output for n = 5
// 12345
// 1234
// 123
// 12
//1
