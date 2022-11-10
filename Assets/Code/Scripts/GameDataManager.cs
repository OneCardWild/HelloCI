using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class GameDataManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro _tmp_text;
    //private String textKeyPath;
    [SerializeField]
    private TextAsset textKeyData;
    
    private void Awake()
    {
     Debug.Log(textKeyData);
   }
    
    string ReadTextKeys()
    {
       
        LocalizedStrings locaStringsFromJson  = JsonUtility.FromJson<LocalizedStrings>(textKeyData.text);

        foreach (LocalizedString locaString in locaStringsFromJson._localizedStrings)
        {
            Debug.Log("read in string ID " + locaString.ID + "with a value of " + locaString.String);
        }

        return locaStringsFromJson._localizedStrings[0].String;
            
    }
    
    void Start()
    {
        String helloWorld = ReadTextKeys();
        _tmp_text.text = helloWorld;
    }

    
}
