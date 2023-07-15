/*   Hard
____________
Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.
Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.*/
public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
       int m = nums1.Length;
    int n = nums2.Length;
    int[] merged = new int[m + n];

    int i = 0, j = 0, k = 0;
    while (i < m && j < n)
    {
        if (nums1[i] <= nums2[j])
            merged[k++] = nums1[i++];
        else
            merged[k++] = nums2[j++];
    }

    while (i < m)
        merged[k++] = nums1[i++];

    while (j < n)
        merged[k++] = nums2[j++];

    int mid = (m + n) / 2;
    if ((m + n) % 2 == 0)
        return (merged[mid - 1] + merged[mid]) / 2.0;
    else
        return merged[mid]; 
    }
}
