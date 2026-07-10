public class Solution {
    public int MaxArea(int[] heights) {
        int i=0;
        int j=heights.Length-1;
        int MaxArea=0;

        while(i<j)
        {
            int height=Math.Min(heights[i],heights[j]);
            int width=j-i;
            int area=height*width;

            if(heights[i]<=heights[j])
            {
                i++;
            }
            else{
                j--;
            }
            MaxArea=Math.Max(area,MaxArea);
        }
        return MaxArea;

    }
}
