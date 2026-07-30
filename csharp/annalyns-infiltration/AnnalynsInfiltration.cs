static class QuestLogic
{
    //? TODO: define the 'CanFastAttack()' method
    //* 1. Check if a fast attack can be made
    /* ---------------------------------------------------------------------------------
    Implement the (static) QuestLogic.CanFastAttack() method that takes a Boolean value
    that indicates if the knight is awake. This method returns true if a fast attack can
    be made based on the state of the knight. Otherwise, returns false.
    ex.
        var knightIsAwake = true;
        QuestLogic.CanFastAttack(knightIsAwake);
        => false
    */
    public static bool CanFastAttack(bool knightIsAwake)
    {
        bool canAttack = false;
        if (knightIsAwake)
        {
            // knightIsAwake = true
            canAttack = true;
        }

        return canAttack;
    }

    //? TODO: define the 'CanSpy()' method
    //* 2. Check if the group can be spied upon
    /* ---------------------------------------------------------------------------------
    Implement the (static) QuestLogic.CanSpy() method that takes three Boolean values,
    indicating if the knight, archer and the prisoner, respectively, are awake. The
    method returns true if the group can be spied upon, based on the state of the three
    characters. Otherwise, returns false.
    ex.
        var knightIsAwake = false;
        var archerIsAwake = true;
        var prisonerIsAwake = false;
        QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake);
        => true
    */
    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    }

    //? TODO: define the 'CanSignalPrisoner()' method
    //* 3. Check if the prisoner can be signalled
    /* ---------------------------------------------------------------------------------
    Implement the (static) QuestLogic.CanSignalPrisoner() method that takes two Boolean
    values, indicating if the archer and the prisoner, respectively, are awake. The
    method returns true if the prisoner can be signalled, based on the state of the two
    characters. Otherwise, returns false.
    ex.
        var archerIsAwake = false;
        var prisonerIsAwake = true;
        QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake);
        => true
    */
    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    }

    //? TODO: define the 'CanFreePrisoner()' method
    //* 4. Check if the prisoner can be freed
    /* ---------------------------------------------------------------------------------
    Implement the (static) QuestLogic.CanFreePrisoner() method that takes four Boolean
    values. The first three parameters indicate if the knight, archer and the prisoner,
    respectively, are awake. The last parameter indicates if Annalyn's pet dog is
    present. The method returns true if the prisoner can be freed based on the state of
    the three characters and Annalyn's pet dog presence. Otherwise, it returns false.
    ex.
        var knightIsAwake = false;
        var archerIsAwake = true;
        var prisonerIsAwake = false;
        var petDogIsPresent = false;
        QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent);
        => false
    */
    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    }
}
