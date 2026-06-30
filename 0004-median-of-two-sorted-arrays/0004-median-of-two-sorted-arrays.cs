public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n1 = nums1.Length;
        int n2 = nums2.Length;
        int n3 = n1+n2;

        int[] merged = new int[n3];
        int i=0, j=0, k=0;
        
        while (i<n1 && j<n2)
        {
            if (nums1[i] <= nums2[j]) merged[k++] = nums1[i++];
            else merged[k++] = nums2[j++];
        }

        if (i<n1) Array.Copy(nums1, i, merged, k, n1-i);
        else if (j<n2) Array.Copy(nums2, j, merged, k, n2-j);

        if (n3%2 == 0)
        {
            // even
            int middleIdx = n3/2;
            return (merged[middleIdx-1]+merged[middleIdx])/2.0;
        }
        else
        {
            //odd
            return merged[n3/2];
        }
    }
}