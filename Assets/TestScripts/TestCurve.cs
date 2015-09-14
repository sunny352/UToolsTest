using UnityEngine;
using System.Collections;

public class TestCurve : MonoBehaviour
{
	public SlerpCurve curve;
	private float m_startTime;
	// Use this for initialization
	void Start()
	{
		m_startTime = Time.time;
	}
	// Update is called once per frame
	void Update()
	{
		transform.position = curve.GetLinedPoints((Time.time - m_startTime) / 10.0f);
	}
}
