using UnityEngine;
using System.Collections;
[RequireComponent(typeof(ChargeEnergyMono))]
public class TestChargeEnergyMono : MonoBehaviour
{
	void OnButtonClick()
	{
		Debug.Log("OnButtonClick");
		if (!GetComponent<ChargeEnergyMono>().IsCharging)
		{
			gameObject.SendMessage("OnBegin");
		}
		else
		{
			gameObject.SendMessage("OnEnd");
		}
	}
	void OnChargeStart()
	{
		Debug.LogFormat("OnChargeStart");
	}
	void OnChargeFire(int level)
	{
		Debug.LogFormat("OnChargeFire {0}", level);
	}
	void OnChargeLevelUp(int level)
	{
		Debug.LogFormat("OnChargeLevelUp {0}", level);
	}
	void OnChargeFinished()
	{
		Debug.LogFormat("OnChargeFinished");
	}
	void OnChargeInterupt()
	{
		Debug.LogFormat("OnChargeInterupt");
	}
}
