using UnityEngine;
using System.Collections;

public class CoroutineExample2 : MonoBehaviour
{
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
