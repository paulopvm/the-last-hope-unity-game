using UnityEngine;

public class Waypoints3 : MonoBehaviour {

	public static Transform[] points3;

	void Awake ()
	{
		points3 = new Transform[transform.childCount];
		for (int i = 0; i < points3.Length; i++)
		{
			points3[i] = transform.GetChild(i);
		}

	}
}
