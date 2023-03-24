using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corotuine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        var text = System.IO.File.ReadAllText(@"Assets\Text.txt");
        Debug.Log(text);
        yield break;
    }
}
