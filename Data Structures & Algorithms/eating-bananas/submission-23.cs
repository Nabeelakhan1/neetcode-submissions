public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        //so i am gonna do is that 
        int l=1; int r=piles.Max();
        int mid=(l+r)/2;

        
        while(l<r)
        {
            mid=(l+r)/2;
            double hrs=0;
            for(int i=0;i<piles.Length;i++)
            {
                hrs += (piles[i] + mid - 1) / mid;
            }
            if(hrs<=h)
            {
                r=mid;
            }
            else{
                l=mid+1;
            }
        }
        return l;
    }
}
