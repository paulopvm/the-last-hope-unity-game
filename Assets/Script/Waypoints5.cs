using UnityEngine;

public class Waypoints5 : MonoBehaviour {

	public static Transform[] points5;

	void Awake ()
	{
		points5 = new Transform[transform.childCount];
		for (int i = 0; i < points5.Length; i++)
		{
			points5[i] = transform.GetChild(i);
		}

	}
}
