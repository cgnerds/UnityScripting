using UnityEngine;
using UnityEditor;

public class ExportAssetBundles {

    [MenuItem("Assets/Build AssetBundle From Selection - Track dependencies")]
    [System.Obsolete]
    static void ExportResource()
    {
        string path = "Assets/myAssetBundle.unity3d";
        if(path.Length != 0)
        {
            Object[] selection = Selection.GetFiltered(typeof(Object), SelectionMode.DeepAssets);
            BuildPipeline.BuildAssetBundle(Selection.activeObject, selection,
                path, BuildAssetBundleOptions.CollectDependencies, BuildTarget.StandaloneWindows);
            Selection.objects = selection;
        }
    }

    [MenuItem("Assets/Build AssetBundle From Selection - No dependency tracking")]
    [System.Obsolete]
    static void ExportResourceNoTrack()
    {
        string path = "Assets/myAssetBundle.unity3d";
        if(path.Length != 0)
        {
            BuildPipeline.BuildAssetBundle(Selection.activeObject, Selection.objects, 
                path, BuildAssetBundleOptions.CollectDependencies, BuildTarget.StandaloneWindows);
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
