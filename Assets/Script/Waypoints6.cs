using UnityEngine;

public class Waypoints6 : MonoBehaviour {

	public static Transform[] points6;

	void Awake ()
	{
		points6 = new Transform[transform.childCount];
		for (int i = 0; i < points6.Length; i++)
		{
			points6[i] = transform.GetChild(i);
		}

	}
}
