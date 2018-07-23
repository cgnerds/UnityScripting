using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCoroutineTest : MonoBehaviour {

    // Use this for initialization
    IEnumerator Start()
    {
        StartCoroutine("DoSomething", 2.0f);
        yield return new WaitForSeconds(1);
        StopCoroutine("DoSomething");
    }

    IEnumerator DoSomething(float someParameter)
    {
        while(true)
        {
            print("DoSomething Loop");
            yield return null;
        }
    }
}
