using System;

static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (!knightIsAwake) { return true; } return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake || archerIsAwake || prisonerIsAwake) {  return true; } return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if(!archerIsAwake && prisonerIsAwake) return true;  return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (!knightIsAwake && !archerIsAwake && !prisonerIsAwake && !petDogIsPresent) return false;
        else if (knightIsAwake && archerIsAwake) return false;
        else if (knightIsAwake && !petDogIsPresent) return false;
        else if (archerIsAwake) return false;
            return true;
    }
}
