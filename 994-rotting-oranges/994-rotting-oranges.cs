public class Solution {
    public int OrangesRotting(int[][] grid)
{
    var result = 0;
    var rottenQueue = new Queue<int[]>();
    var freshCount = 0;
    for (var i = 0; i < grid.Length; i++)
    {
        for (var j = 0; j < grid[i].Length; j++)
        {
            switch (grid[i][j])
            {
                case 1:
                    freshCount++;
                    break;
                case 2:
                    rottenQueue.Enqueue(new[] { i, j });
                    break;
            }
        }
    }

    if (freshCount == 0) return 0;
    var directions = new[]
    {
        new[] { 1, 0 }, new[] { -1, 0 }, new[] { 0, 1 }, new[] { 0, -1 }
    };

    while (rottenQueue.Count > 0)
    {
        ++result;
        var size = rottenQueue.Count;
        for (var i = 0; i < size; i++)
        {
            var currentRotten = rottenQueue.Dequeue();
            foreach (var direction in directions)
            {
                var x = currentRotten[0] + direction[0];
                var y = currentRotten[1] + direction[1];
                if (x < 0 || y < 0 ||
                    x >= grid.Length || y >= grid[0].Length ||
                    grid[x][y] == 0 || grid[x][y] == 2)
                    continue;

                grid[x][y] = 2;
                rottenQueue.Enqueue(new[] { x, y });
                freshCount--;
            }
        }

    }

    return freshCount > 0 ? -1 : result - 1;
}
}