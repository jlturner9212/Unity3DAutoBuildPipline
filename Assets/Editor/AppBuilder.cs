using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class AppBuilder : MonoBehaviour {
	public static AppBuilder Instance;

	//string [] GameScenes;

	string BuildVersion;
	string BuildNumber;
	string BuildName;

	[MenuItem("Build/Set Version")]
	public static void Set_Version()
	{
		//TODO: get; set version and get build number
		Debug.Log("Version has been set");
	}

    [MenuItem("Build/Set Build Name")]
    public static void Set_BuildName()
    {
        //TODO: get; set build name
        Debug.Log("Build Name has been set");
    }

    [MenuItem("Build/Build All")]
	public static void Build_All()
	{
		Build_iOS ();
		Build_Android ();
		Debug.Log("All Platforms have been built");
	}

	[MenuItem("Build/Build All Optimized")]
	public static void Build_All_Opt()
	{
		Debug.LogError("Feature Not Implemented Yet");
	}
		
	public static void Build_App(BuildPlayerOptions buildPlayerOptions)
	{
		//TODO: GET ASSET BUNDLES

		string mPlayer = buildPlayerOptions.target.ToString ();
		string[] GameScenes = {
			"Assets/Scenes/01####.unity",
			"Assets/Scenes/02####.unity",
			"Assets/Scenes/03####.unity"
		};
		buildPlayerOptions.scenes = GameScenes;
		buildPlayerOptions.locationPathName = "Builds/" + mPlayer;

		//TODO: CHECK IF BUILD FAILED
		//if (BuildPipeline.BuildPlayer (buildPlayerOptions)) {
			Debug.Log (mPlayer + " Platform has been built");
		//} else {
		//	Debug.LogWarning ("Something went wrong building " + mPlayer);
		//
	}

	[MenuItem("Build/Build iOS")]
	public static void Build_iOS()
	{
		//string buildExt = ".ipa";
		BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
		buildPlayerOptions.target = BuildTarget.iOS;
		buildPlayerOptions.options = BuildOptions.None;
		Build_App (buildPlayerOptions);
	}

	[MenuItem("Build/Build Android")]
	public static void Build_Android()
	{
		//string buildExt = ".apk";
		BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
		buildPlayerOptions.target = BuildTarget.Android;
		buildPlayerOptions.options = BuildOptions.None;
		Build_App (buildPlayerOptions);

	}

	//	IEnumerator Build_App_Opt(BuildPlayerOptions buildPlayerOptions)
	//	{
	//		string mPlayer = buildPlayerOptions.target.ToString ();
	//		string[] GameScenes = {
	//			"Assets/Scenes/01_Splash.unity",
	//			"Assets/Scenes/02_Reco.unity",
	//			"Assets/Scenes/03_Settings.unity"
	//		};
	//		buildPlayerOptions.scenes = GameScenes;
	//		buildPlayerOptions.locationPathName = "Builds/" + mPlayer;
	//		Debug.Log (mPlayer + " Platform has been built");
	//		yield return buildPlayerOptions;
	//	}
}
