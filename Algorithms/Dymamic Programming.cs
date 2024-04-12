/* Coin Change II - no of ways to form a sum */
public int Change(int[] coins, int sum)
{
    int[,] dp = new int[coins.Length, sum + 1];

    for(int i = 0; i < coins.Length; i++)
    {
        for(int j = 0; j < sum + 1; j++)
        {
            dp[i, j] = -1;
        }
    }
    return Change(coins, sum, coins.Length, dp);
}
private int Change(int[] coins, int sum, int n, int[,] dp)
{
    if(sum == 0)
        return dp[n, sum] = 1;
    if(n == 0)
        return 0;
    if(dp[n, sum] != -1)
    {
        return dp[n, sum];
    }
    if(sum >= coins[n - 1])
    {
        return dp[n, sum] = Change(coins, sum - coins[n - 1], n, dp) +
                            Change(coins, sum, n - 1, dp);
    }
    else
    {
        return dp[n, sum] = Change(coins, sum, n - 1, dp);
    }
}
