


public class Solution {
    public int Trap(int[] height) {

        int rt=0;int lt=0; int area=0;
        for (int i=0;i<height.Length;i++)
        {
             lt=0;
             rt=0;

            for(int j=i-1;j>=0;j--)
            {
                if(height[j]>lt)
                    lt=height[j];
            }
            for(int k=i+1;k<height.Length;k++)
            {
                if(height[k]>rt)
                    rt=height[k];
            }
            int Carea=Math. Min(lt,rt)-height[i];
            if(Carea>0)
            {
                  area+=Carea;
            }
          
        }
        return area;
    }
}
