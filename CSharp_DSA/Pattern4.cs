class Solution
    {
        //Complete this function
        //Function to print n number of stars.
        public void printTriangle(int n)
        {
            for(int i=1; i<=n; i++){
                
                for(int j =1; j <= i; j++){
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
            
            //Your code here
        }

    }

//  Output for pattern

// 1
// 22
// 333
// 4444
