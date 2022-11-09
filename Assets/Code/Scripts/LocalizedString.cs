using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


[System.Serializable]
public class LocalizedString
{
    public int stringID;
    public String myString;
  
}

public class LocalizedStrings
{
    public LocalizedString[] _localizedStrings;
}