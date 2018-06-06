using UnityEngine;

public class Waypoints4 : MonoBehaviour {

	public static Transform[] points4;

	void Awake ()
	{
		points4 = new Transform[transform.childCount];
		for (int i = 0; i < points4.Length; i++)
		{
			points4[i] = transform.GetChild(i);
		}

	}
}
