public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int index = 0;
        int[] listOfSmth = new int[nums.Length];
        Dictionary<int, int> dictOfSmth = new();
        foreach(var i in nums) 
        {
            int multiplicator = 1;
            if(dictOfSmth.TryGetValue(i, out var mult))
            {
                listOfSmth[index] = mult;
                index++;
                continue;
            }
            for(int p = 0; p < nums.Length; p++) 
            {
                if (p == index) continue;
                if (nums[p] == 0) multiplicator = 0;
                else multiplicator *= nums[p];
            }
            listOfSmth[index] = multiplicator;
            dictOfSmth[i] = multiplicator;
            multiplicator = 1;
            index++;
        }
        return listOfSmth;
    }
}
