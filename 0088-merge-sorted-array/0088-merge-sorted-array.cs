public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
       var result = nums1.Take(m)
                          .Concat(nums2.Take(n))
                          .OrderBy(x => x)
                          .ToArray();
        Array.Copy(result, nums1, result.Length);
    }
}