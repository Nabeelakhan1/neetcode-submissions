public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        Dictionary<int,int> map=new();
        int[] result=new int[k];
        for(int i=0;i<nums.Length;i++)
        {
            if(map.ContainsKey(nums[i]))
            {
                map[nums[i]]+=1;;
            }
            else{
                map[nums[i]]=1;
            }
        }
        for(int i=0;i<k;i++)
        {
            int maxNum=0;
            int maxFreq=-1;

            foreach(var pair in map)
            {
                if(pair.Value>maxFreq)
                {
                    maxFreq=pair.Value;
                    maxNum=pair.Key;
                }
            }
            result[i]=maxNum;
            map.Remove(maxNum);
        }
        return result;

    }
}
