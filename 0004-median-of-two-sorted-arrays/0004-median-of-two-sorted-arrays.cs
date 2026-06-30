public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Always perform binary search on the smaller array
        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int firstArrayLength = nums1.Length;
        int secondArrayLength = nums2.Length;

        int left = 0;
        int right = firstArrayLength;

        while (left <= right)
        {
            int firstPartition = (left + right) / 2;
            int secondPartition = (firstArrayLength + secondArrayLength + 1) / 2 - firstPartition;

            int firstLeftMax = (firstPartition == 0)
                ? int.MinValue
                : nums1[firstPartition - 1];

            int firstRightMin = (firstPartition == firstArrayLength)
                ? int.MaxValue
                : nums1[firstPartition];

            int secondLeftMax = (secondPartition == 0)
                ? int.MinValue
                : nums2[secondPartition - 1];

            int secondRightMin = (secondPartition == secondArrayLength)
                ? int.MaxValue
                : nums2[secondPartition];

            if (firstLeftMax <= secondRightMin &&
                secondLeftMax <= firstRightMin)
            {
                if ((firstArrayLength + secondArrayLength) % 2 == 0)
                {
                    return (Math.Max(firstLeftMax, secondLeftMax) +
                            Math.Min(firstRightMin, secondRightMin)) / 2.0;
                }

                return Math.Max(firstLeftMax, secondLeftMax);
            }

            if (firstLeftMax > secondRightMin)
            {
                right = firstPartition - 1;
            }
            else
            {
                left = firstPartition + 1;
            }
        }

        throw new ArgumentException("Input arrays must be sorted.");
    }
}