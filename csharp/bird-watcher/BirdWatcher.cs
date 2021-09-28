using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] lastWeekCount = { 0, 2, 5, 3, 7, 8, 4 };
        return lastWeekCount;
    }

    public int Today()
    {
        return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] = Today() + 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach(int visits in birdsPerDay)
        {
            if(visits == 0) return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int initialCount = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            initialCount += birdsPerDay[i];
        }

        return initialCount;
    }

    public int BusyDays()
    {
        int initialCount = 0;
        foreach(int visits in birdsPerDay)
        {
            if (visits >= 5) initialCount += 1;
        }

        return initialCount;
        
    }
}
