using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class HttpTest : MonoBehaviour {
    private Action<WWW> onSuccess;
   
	// Use this for initialization
	void Start () {
        this.onSuccess += this.SuccessMethod;
        HttpWrapper hw = GetComponent<HttpWrapper>();
        hw.GET("http://img.juimg.com/tuku/yulantu/140703/330746-140F302191731.jpg", this.onSuccess);
	}

    private void SuccessMethod(WWW www)
    {
        if (www == null)
            return;
        Texture tex = www.texture;
        GetComponent<Renderer>().material.mainTexture = tex;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
