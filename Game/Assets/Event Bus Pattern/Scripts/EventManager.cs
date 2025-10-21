using System;
using System.Collections.Generic;

public enum Condition
{
    START,
    PAUSE,
    EXIT
}

public static class EventManager
{
    private static Dictionary<Condition, Action> dictionary = new();
}
