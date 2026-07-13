class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    //* 1. Just send back the specified array
    /* ---------------------------------------------------------------------------------
    For comparison purposes, you always keep a copy of last week's counts nearby, 
    which were: 0, 2, 5, 3, 7, 8 and 4. Implement the (static) BirdCount.LastWeek() 
    method that returns last week's counts:
    */
    public static int[] LastWeek()
    {
        int[] copy = new int[] { 0, 2, 5, 3, 7, 8, 4};
        return copy;
    }

    //* 2. Check how many birds visited today
    /* ---------------------------------------------------------------------------------
    Implement the BirdCount.Today() method to return how many birds visited your 
    garden today. The bird counts are ordered by day, with the first element being 
    the count of the oldest day, and the last element being today's count.
    ex. 
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.Today();
        => 1
    */
    public int Today()
    {
        int lastElm = birdsPerDay.Length - 1;
        var today = birdsPerDay[lastElm];
        return today;
    }

    //* 3. Increment today's count
    /* ---------------------------------------------------------------------------------
    Implement the BirdCount.IncrementTodaysCount() method to increment today's count:
    ex. 
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.IncrementTodaysCount();
        birdCount.Today();
        => 2
    */
    public void IncrementTodaysCount()
    {
        int lastElm = birdsPerDay.Length - 1;
        birdsPerDay[lastElm]++;
    }

    //* 4. Increment today's count
    /*
    Implement the BirdCount.HasDayWithoutBirds() method that returns true if there was a day at which zero birds visited the garden; otherwise, return false:
    ex.
        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.HasDayWithoutBirds();
        => true

    */
    public bool HasDayWithoutBirds()
    {
        foreach (char count in birdsPerDay)
        {
            if (count == 0)
            {
                return true;
            }
        }
        return false;
    }

    //* 5.  Calculate the number of visiting birds for the first number of days
    /*
    Implement the BirdCount.CountForFirstDays() method that returns the number of birds that have visited your garden from the start of the week, but limit the count to the specified number of days from the start of the week.

        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.CountForFirstDays(4);
        => 14
    */
    public int CountForFirstDays(int numberOfDays)
    {
        int totalWeeklyBirds = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            totalWeeklyBirds = totalWeeklyBirds + birdsPerDay[i];
        }
        return totalWeeklyBirds;
    }

    //* 6.  Calculate the number of busy days
    /*
    Some days are busier than others. A busy day is one where five or more birds have visited your garden. Implement the BirdCount.BusyDays() method to return the number of busy days:

        int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        var birdCount = new BirdCount(birdsPerDay);
        birdCount.BusyDays();
        => 2
    */
    public int BusyDays()
    {
        int numOfBusyDays = 0;
        for (int i = 0; i < birdsPerDay.Length; i++)
        {
            if (birdsPerDay[i] >= 5)
            {
                numOfBusyDays++;
            }
        }

        return numOfBusyDays;
    }
}
