using UnityEngine;
using System.Collections;

public class Contants{
	public static string LAST_CONNECTION = "LastConnection";
	public static string USER_STATE = "LastConnection";
	public static string RESOURCE_KEY = "ResourceKey_";

	public static void AddResource(float amount, TYPE_RESOURCES aType)
	{
		PlayerPrefs.SetFloat (RESOURCE_KEY + aType.ToString (), amount);
	}

	public static float GetResource(TYPE_RESOURCES aType)
	{
		return PlayerPrefs.GetFloat (RESOURCE_KEY + aType.ToString ());
	}

}
