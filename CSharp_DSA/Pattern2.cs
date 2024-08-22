class Solution
{
    //Complete this function
    public void printTriangle(int n)
    {
        
        for(int i=0; i<n; i++){
            
            for(int j = 0; j<= i;j++){
                Console.Write("* ");
            }
            Console.WriteLine("");
        }
        //Your code here
    }

}

//Output if n = 3

//  *
//  * *
//  * * *
