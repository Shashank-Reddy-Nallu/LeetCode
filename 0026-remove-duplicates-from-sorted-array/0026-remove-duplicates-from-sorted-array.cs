public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int res = 0;

        for (int i=0; i< nums.Length; i++){
            if(nums[i] > nums[res]){
                res++;
                nums[res] = nums[i];
            }
        }
        return res+1;
    }
}