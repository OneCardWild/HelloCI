using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;


[System.Serializable]
public class LocalizedString
{
    public int ID;
    public String String;
  
}

public class LocalizedStrings
{
    public LocalizedString[] _localizedStrings;
}