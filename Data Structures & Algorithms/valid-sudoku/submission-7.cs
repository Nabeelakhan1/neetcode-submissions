public class Solution {
    public bool IsValidSudoku(char[][] board) {

        HashSet<char> Set=new();
        for(int row=0;row<board.Length;row++)
        {
            for(int col=0;col<board.Length;col++)
            {
                if(board[row][col]=='.')
                {
                    continue;
                }
                char c=board[row][col];
                if(!Set.Contains(c))
                {
                    Set.Add(c);
                }
                else{
                    return false;
                }
            }
            Set.Clear();
        }
        for(int col=0;col<board.Length;col++)
        {
            for(int row=0;row<board.Length;row++)
            {
                if(board[row][col]=='.')
                {
                    continue;
                }
                char c=board[row][col];
                if(!Set.Contains(c))
                {
                    Set.Add(c);
                }
                else{
                    return false;
                }
            }
            Set.Clear();
        }

        for(int boxRow=0;boxRow<9;boxRow+=3)
        {
            for(int boxCol=0;boxCol<9;boxCol+=3)
            {
                HashSet<char> Sett=new();
                for(int r=boxRow;r<boxRow+3;r++)
                {
                    for(int c=boxCol;c<boxCol+3;c++)
                    {
                        char val=board[r][c];
                        if(val=='.') continue;
                        if(Sett.Contains(val))
                        {
                            return false;
                        }
                        Sett.Add(val);
                    }
                }
            }
        }

        return true;
        
    }
}
