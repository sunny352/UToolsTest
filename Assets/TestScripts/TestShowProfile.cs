using UnityEngine;
using System.Collections;

public class TestShowProfile : MonoBehaviour
{
	void Start()
	{
		ShowProfile.SampleTime = 1.0f;
	}
	void Update()
	{
		ShowProfile.Update();
	}
	void FixedUpdate()
	{
		ShowProfile.FixedUpdate();
	}
	void OnGUI()
	{
		ShowProfile.OnGUI();
	}
}
