using System.Collections;
using UnityEngine;
using System;

public class CoroutineTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // GetComponent<MeshRenderer>().material.color = Color.yellow;
		if(Input.GetKeyDown(KeyCode.F))
        {
            StartCoroutine("Fade");
        }
	}

    IEnumerator Fade()
    {
        Debug.Log("Fading...");
        for(float f = 1.0f; f >= 0; f -= 0.1f)
        {
            Color c = GetComponent<MeshRenderer>().material.color;
            c.a = f;
            GetComponent<MeshRenderer>().material.color = c;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
