using System.Collections;
using UnityEngine;
using System;

public class WaitForSecondsTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Example");
	}
	
    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }

}
