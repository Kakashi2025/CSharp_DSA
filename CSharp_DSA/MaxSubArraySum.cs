// Arrays

public class Solution {
    public int MaxSubArray(int[] nums) {
        int largest = int.MinValue, current =0;

        foreach(int num in nums){
            current += num;
            largest = Math.Max(largest, current);
            if(current < 0) current = 0;
        }
        return largest;
    }
}
