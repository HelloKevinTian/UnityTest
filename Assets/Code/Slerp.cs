using UnityEngine;
using System.Collections;


//弧形插值示例
public class Slerp : MonoBehaviour {
	public Transform sunrise;

	public Transform sunset;

	public float journeyTime = 1.0f;

	private float startTime;

	private Vector3 offset = new Vector3(-20,0,0);

	void Start() {
		startTime = 0;
		Debug.Log ("startTime: " + startTime);

		StartCoroutine(nextSlerp(journeyTime + 1));
	}
	void Update() {
		sunSlerp (sunrise, sunset);
	}

	IEnumerator nextSlerp (float delay) {
		yield return new WaitForSeconds (delay);

		startTime = Time.time;
		Debug.Log("do sth=====================");

		sunrise.position = sunrise.position + offset;
		sunset.position = sunset.position + offset;

		StartCoroutine(nextSlerp(journeyTime + 1));
	}

	void sunSlerp(Transform trans1,Transform trans2) {
		Vector3 center = (trans1.position + trans2.position) * 0.5F;
		center -= new Vector3(0, 1, 0);
		Vector3 riseRelCenter = trans1.position - center;
		Vector3 setRelCenter = trans2.position - center;
		float fracComplete = (Time.time - startTime) / journeyTime;
		Debug.Log ("fracComplete:  " + fracComplete);
		transform.position = Vector3.Slerp(riseRelCenter, setRelCenter, fracComplete);
		transform.position += center;
	}
}










