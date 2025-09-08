public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] grid = new int[m, n];

        for (int i = 0; i < m; i++)// 1st row aur column ko 1 se fill kr do kyuki uska value hmesa 1 hi rhega
        {
            grid[i, 0] = 1;
        }
        for (int j = 0; j < n; j++)
        {
            grid[0, j] = 1;
        }
        for (int i = 1; i < m; i++)//uske baad baaki saare elemeents ko fill kro
        {
            for (int j = 1; j < n; j++)
            {
                grid[i, j] = grid[i - 1, j] + grid[i, j - 1]; //[1,1] ko fill krne k liye m aur ka possibility dkhna prega
            }
        }
        return grid[m - 1, n - 1];
    }
}