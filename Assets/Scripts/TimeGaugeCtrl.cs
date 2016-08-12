using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeGaugeCtrl : MonoBehaviour {

	private Image timeGauge;
	public float speed = 0.001f;

	// Use this for initialization
	void Start () {
		timeGauge = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {

		timeGauge.fillAmount -= speed;
	
	}
}
