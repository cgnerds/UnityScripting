using UnityEngine;
using System.Collections;

public class CoroutineExample1 : MonoBehaviour {

	// Use this for initialization
	IEnumerator Start () {
        print("Starting " + Time.time);
        yield return StartCoroutine(WaitAndPrint(2.0f));
        print("Done " + Time.time);
	}

    IEnumerator WaitAndPrint(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndPrint " + Time.time);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
