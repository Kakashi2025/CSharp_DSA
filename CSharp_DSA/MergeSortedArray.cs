public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(n == 0){
            return;
        }
        int length1 = nums1.Length;  // 6
        int end = length1 - 1; // 5

        while(n>0 && m>0){
            if(nums2[n-1] >= nums1[m-1]){  //nums2[0] >= nums1[1]  i.e. 2 >= 2
                nums1[end] = nums2[n-1];  // nums1[2] = 2
                n--;  //  n = 0                               [,,2,3,5,6]
            }else{
                nums1[end] = nums1[m-1]; // nums1[3] = 3
                m--; // m = 2
            }
            end--;  // end = 1
        }
        while(n>0){  // n = 1
            nums1[end] = nums2[n-1];  // nums1[3] = 3
            n--; // 0
            end--; // 2
        }
    }
}
