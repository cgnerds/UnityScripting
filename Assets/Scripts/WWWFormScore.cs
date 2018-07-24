using System.Collections;
using UnityEngine;

public class WWWFormScore : MonoBehaviour {

    string highscore_url = "http://www.my-site.com/highscores.pl";
    string playName = "Player 1";
    int score = -1;

	// Use this for initialization
	IEnumerator Start () {
        WWWForm form = new WWWForm();
        form.AddField("game", "MyGameName");
        form.AddField("playerName", playName);
        form.AddField("score", score);

        WWW download = new WWW(highscore_url, form);

        yield return download;

        if(!string.IsNullOrEmpty(download.error))
        {
            print("Error downloading: " + download.error);
        }
        else
        {
            Debug.Log(download.text);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
