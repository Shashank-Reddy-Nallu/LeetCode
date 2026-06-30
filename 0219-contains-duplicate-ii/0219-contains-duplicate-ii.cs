public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int,int> dictMap = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++) {
            if (dictMap.ContainsKey(nums[i]) && Math.Abs(i-dictMap[nums[i]]) <= k) {
                return true;
            }

            dictMap[nums[i]] = i;
        }
        return false;
    }
}