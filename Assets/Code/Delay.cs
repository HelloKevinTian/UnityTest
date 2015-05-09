using UnityEngine;
using System.Collections;

public class Delay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("delay test begin...");
		StartCoroutine(WaitAndPrint(3.0F));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	//定义 WaitAndPrint（）方法  
	IEnumerator WaitAndPrint(float waitTime)  
	{
		yield return new WaitForSeconds(waitTime);
		//等待之后执行的动作
		Debug.Log("delay print !!!!!!!!!");
	}
}
