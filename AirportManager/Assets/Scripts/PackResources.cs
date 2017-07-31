using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public struct PackResources
{
	public Dictionary <TYPE_RESOURCES,float> resources;

	public static PackResources operator + (PackResources a, PackResources b)
	{
		PackResources outResources;
		outResources.resources = new Dictionary<TYPE_RESOURCES, float> ();
		for (int i = 0; i < (int)TYPE_RESOURCES.COUNT; i ++) 
		{
			if(a.resources.ContainsKey((TYPE_RESOURCES) i) && b.resources.ContainsKey((TYPE_RESOURCES) i))
			{
				outResources.resources.Add((TYPE_RESOURCES) i, a.resources[(TYPE_RESOURCES)i] + b.resources[(TYPE_RESOURCES)i]);
			}
			else if(a.resources.ContainsKey((TYPE_RESOURCES) i))
			{
				outResources.resources.Add((TYPE_RESOURCES) i, a.resources[(TYPE_RESOURCES)i]);
			}
			else if(b.resources.ContainsKey((TYPE_RESOURCES) i))
			{
				outResources.resources.Add((TYPE_RESOURCES) i, b.resources[(TYPE_RESOURCES)i]);
			}
		}
		return outResources;
	}
	
	public static PackResources operator * (PackResources a, float amount)
	{
		PackResources outResources;
		outResources.resources = new Dictionary<TYPE_RESOURCES, float> ();
		for (int i = 0; i < (int)TYPE_RESOURCES.COUNT; i ++) 
		{
			if(a.resources.ContainsKey((TYPE_RESOURCES) i))
			{
				outResources.resources.Add((TYPE_RESOURCES) i, a.resources[(TYPE_RESOURCES)i] * amount);
			}
		}
		return outResources;
	}

	public static PackResources operator * (float amount, PackResources a)
	{	
		return a * amount;
	}

	public static PackResources operator / (PackResources a, float amount)
	{
		return a * (1f / amount);
	}
}
