public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        for(int row=0;row<9;row++)
        {
            HashSet<char> set=new();
            for(int col=0;col<9;col++)
            {
                if(board[row][col]=='.') continue;
                if(set.Contains(board[row][col]))
                {
                    return false;
                }
                else{
                    set.Add(board[row][col]);
                }
            }
        }

        for(int col=0;col<9;col++)
        {
            HashSet<char> sett=new();
            for(int row=0;row<9;row++)
            {
                if(board[row][col]=='.')continue;
                if(sett.Contains(board[row][col]))
                    return false;
                else{
                    sett.Add(board[row][col]);
                }
            }
        }
     

    for(int br=0;br<9;br+=3)
    {
        for(int bc=0;bc<9;bc+=3)
        {
            HashSet<char> fset=new();
            for(int r=br;r<br+3;r++)
            {
                for(int c=bc;c<bc+3;c++)
                {
                    char cr=board[r][c];
                    if(cr=='.') continue;
                    if(fset.Contains(cr))
                    {
                        return false;
                    }
                    fset.Add(cr);
                }
            }
        }
    }
    
    return true;
}
}
