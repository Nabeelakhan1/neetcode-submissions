public class Solution
{
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        List<List<int>> result = new();

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        List<int> triplet = new()
                        {
                            nums[i],
                            nums[j],
                            nums[k]
                        };

                        bool exists = false;

                        foreach (var item in result)
                        {
                            if (item[0] == triplet[0] &&
                                item[1] == triplet[1] &&
                                item[2] == triplet[2])
                            {
                                exists = true;
                                break;
                            }
                        }

                        if (!exists)
                        {
                            result.Add(triplet);
                        }
                    }
                }
            }
        }

        return result;
    }
}