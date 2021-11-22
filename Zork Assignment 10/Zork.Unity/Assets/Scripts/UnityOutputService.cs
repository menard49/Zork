using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zork;
using System;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    public void Clear() => Console.Clear();

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value) => Write(value.ToString());

    public void WriteLine(string value)
    {
        OutputText.text = value;
    }

    public void WriteLine(object value) => WriteLine(value.ToString());
    
    void Start()
    {
        
    }
    void Update()
    {
        
    }

   [SerializeField]
   private TextMeshProUGUI OutputText;
}
