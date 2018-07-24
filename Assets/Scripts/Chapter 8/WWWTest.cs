using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WWWTest : MonoBehaviour {

    public string url = "http://img.juimg.com/tuku/yulantu/140703/330746-140F302191731.jpg";

    IEnumerator Start()
    {
        WWW www = new WWW(url);
        yield return www;
        Debug.Log("Image Downloaded.");
        GetComponent<Renderer>().material.mainTexture = www.texture;
    }
}
