using System.Collections;
using UnityEngine;
using System;

public class WaitForFixedUpdateTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine("Example");
	}

    IEnumerator Example()
    {
        while(true)
        {
            Debug.Log(Time.frameCount);
            Debug.Log(Time.time);
            yield return new WaitForFixedUpdate();
        }
    }
}
