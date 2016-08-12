using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeGaugeCtrl : MonoBehaviour {

	private Image timeGauge;
	public float speed = 0.001f;

	private int problemNum = 0;

	// Use this for initialization
	void Start () {
		timeGauge = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if(timeGauge.fillAmount == 0)
		{    
			GameObject expiredProblem = GameObject.Find("problem"+ problemNum);
			timeGauge.fillAmount = 1;
			problemNum++;
			Destroy(expiredProblem);
	    }else
			timeGauge.fillAmount -= speed;
	
	}
}
