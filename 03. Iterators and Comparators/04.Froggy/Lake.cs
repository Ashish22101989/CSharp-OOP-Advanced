using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Lake : IEnumerable<int>
{
    private readonly List<int> stones;

    public Lake(params int[] stones)
    {
        this.stones = new List<int>(stones);
    }


    public IEnumerator<int> GetEnumerator()
    {
        for (int i = 0; i < stones.Count; i += 2)
        {
            yield return this.stones[i];
        }

        for (int i = stones.Count - 1; i >= 0; i -= 2)
        {
            if (this.stones.Count % 2 == 1 && i == stones.Count - 1)
            {
                i++;
                continue;
            }
            yield return this.stones[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

