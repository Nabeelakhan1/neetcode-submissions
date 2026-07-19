public class Solution {
    public int Trap(int[] height) {
        int lt=0;int rt=0; int area=0;

        for(int i=0;i<height.Length;i++)
        {
            lt=0;rt=0;
            //find talles from left 
            for(int j=i;j>=0;j--)
            {
                if(lt<height[j])
                    lt=height[j];
            }
            for(int k=i;k<height.Length;k++)
            {
                if(rt<height[k])
                    rt=height[k];
            }
            int currentArea=Math.Min(rt,lt)-height[i];
            if(currentArea>0)
            {
                area+=currentArea;
            }

        }
        return area;
    }
}
