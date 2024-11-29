using System;
using System.Linq;

public class BirdCount(int[] birdsPerDay)
{
    private const int BusyDayThreshold = 4;
    public static int[] LastWeek() => [0, 2, 5, 3, 7, 8, 4];
    public int Today() => birdsPerDay[^1];
    public void IncrementTodaysCount() =>  birdsPerDay[^1]++;
    public bool HasDayWithoutBirds() => birdsPerDay.Any((d) => d == 0);
    public int CountForFirstDays(int numberOfDays) => birdsPerDay.Take(numberOfDays).Sum();
    public int BusyDays() => birdsPerDay.Count(d => d > BusyDayThreshold);
}
