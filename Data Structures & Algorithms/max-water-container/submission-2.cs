public class Solution {
    public int MaxArea(int[] heights) {
        
        int CurrentArea=0;
        int i=0;
        int j=heights.Length-1;

        while(i<j)
        {
            int width=j-i;
            int area=0;
            if(heights[i]<=heights[j])
            {
                 area=width*heights[i];
                i++;
            }
            else{
                area=width*heights[j];
                j--;

            }
          CurrentArea=Math.Max(CurrentArea,area);
        }
        return CurrentArea;
    }
}
