public class Solution {
    public void MoveZeroes(int[] nums) {
        int nextPosition = 0;
        int i = 0;
        while(i<nums.Length){
            if(nums[i]!=0){
                if(nums[nextPosition]==0){
                    nums[nextPosition] = nums[i];
                    nums[i]=0;
                }
                nextPosition++;
            }
            i++;
        }
    }
}
