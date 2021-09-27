using System;

static class AssemblyLine
{
    public static double ProductionRatePerHour(int speed)
    {
        if(speed < 0) { return 0; }
        else if(speed <= 4) { return 221 * speed; }
        else if(speed <= 8 && speed >= 5) { return 221 * speed * .9; }
        else if(speed == 9) { return 221 * speed * .8; }
        else if(speed == 10) { return 221 * speed * .77; }
        return speed;
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        return (int)ProductionRatePerHour(speed) / 60;
    }
}
