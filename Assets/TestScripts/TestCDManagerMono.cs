using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CDManagerMono))]
public class TestCDManagerMono : MonoBehaviour
{
	public bool[] CDList;
	void Start()
	{
		CDList = new bool[GetComponent<CDManagerMono>().CDList.Length];
	}

	void FixedUpdate()
	{
		var cdList = GetComponent<CDManagerMono>().CDList;
		for (int index = 0; index < CDList.Length; ++index)
		{
			if (CDList[index])
			{
				if (cdList[index].IsCDRunning)
				{
					continue;
				}
				else
				{
					cdList[index].Start();
				}
			}
			else
			{
				if (cdList[index].IsCDRunning)
				{
					cdList[index].Clear();
				}
				else
				{
					continue;
				}
			}
		}
	}
	void OnCDFinished(int id)
	{
		Debug.LogFormat("{0} is finished", id);
		var cdList = GetComponent<CDManagerMono>().CDList;
		for (int index = 0; index < CDList.Length; ++index)
		{
			if (cdList[index].ID == id)
			{
				CDList[index] = false;
			}
		}
	}
	void OnCDRefresh(string info)
	{
		//Debug.LogFormat("{0}", info);
	}
}
