public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        
        int left=0; 
        int right=matrix.Length-1;
        int midRow;

        

        while(left<=right)
        {
          midRow=(left+right)/2;
       int first=matrix[midRow][0];
        int last=matrix[midRow][matrix[midRow].Length-1];
        
        if(target<first)
        {
            right=midRow-1;
        }
        else if(target>last)
        {
            left=midRow+1;
        }
        else{
            //binary search for this row
            int l=0;
            int r= matrix[midRow].Length-1;
            while(l<=r)
            {
                int mid=(l+r)/2;
                if(matrix[midRow][mid]<target)
                {
                    l=mid+1;
                }
                else if(matrix[midRow][mid]>target)
                {
                    r=mid-1;
                }
                else{
                    return true;
                }
               
            }
             return false;
        }

        
        }
        return false;
    }
}
