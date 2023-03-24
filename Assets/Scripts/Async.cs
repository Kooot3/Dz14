using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class Async : MonoBehaviour
{
    private static async Task Text()
    {
        var text = await System.IO.File.ReadAllTextAsync(@"Assets\Text.txt");
        Debug.Log(text);
    }

    private void Awake()
    { 
         Text();
    }
}
