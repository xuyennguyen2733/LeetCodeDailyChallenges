public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        if (nums.Length==0) {
            return new int[]{-1,-1};
        }
        
        // find first index
        int lowIdx = 0;
        int highIdx = nums.Length-1;
        int midIdx = 0;
        int firstIdx = -1;
        int lastIdx = -1;
        while (lowIdx <= highIdx) {
            midIdx = (lowIdx+highIdx)/2;
            if (target == nums[midIdx]) {
                firstIdx = midIdx;
                highIdx = midIdx - 1;
            }
            else if (target > nums[midIdx]) {
                lowIdx = midIdx+1;
            }
            else {
                highIdx = midIdx-1;
            }
            Console.WriteLine("" + lowIdx + " " + midIdx + " " + highIdx);
        }
        lowIdx = 0;
        highIdx = nums.Length-1;
        midIdx = 0;
        while (lowIdx <= highIdx) {
            midIdx = (lowIdx+highIdx)/2;
            if (target == nums[midIdx]) {
                lastIdx = midIdx;
                lowIdx = midIdx + 1;
            }
            else if (target > nums[midIdx]) {
                lowIdx = midIdx+1;
            }
            else {
                highIdx = midIdx-1;
            }
            Console.WriteLine("" + lowIdx + " " + midIdx + " " + highIdx);
        }

        return new int[]{firstIdx,lastIdx};

        return new int[]{-1,-1};
    }
}