using System;
using System.Collections.Generic;
using System.Text;

public class TrafficLight : ITrafficLight
{
    public Light Light { get; private set; }

    public TrafficLight(string light)
    {
        this.Light = (Light)Enum.Parse(typeof(Light), light);
    }

    public void Cycle()
    {
        this.Light++;

        if ((int)this.Light > 2)
        {
            this.Light = 0;
        }
    }

    public override string ToString()
    {
        return $"{this.Light}";
    }
}
