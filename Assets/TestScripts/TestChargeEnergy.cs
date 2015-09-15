using UnityEngine;
using System.Collections;

public class TestChargeEnergy : MonoBehaviour
{
	private ChargeEnergy m_chargeEnergy;
	void Start()
	{
		m_chargeEnergy = new ChargeEnergy();
		m_chargeEnergy.IsFireOnEnd = true;
		m_chargeEnergy.PreTime = 1.0f;
		m_chargeEnergy.Duration = 1.0f;
		m_chargeEnergy.MaxLevel = 5;

		m_chargeEnergy.OnChargeStart = OnChargeStart;
		m_chargeEnergy.OnChargeFire = OnChargeFire;
		m_chargeEnergy.OnChargeLevelUp = OnChargeLevelUp;
		m_chargeEnergy.OnChargeFinished = OnChargeFinished;
		m_chargeEnergy.OnChargeInterupt = OnChargeInterupt;
	}
	void OnButtonClick()
	{
		Debug.Log("OnButtonClick");
		if (!m_chargeEnergy.IsCharging)
		{
			m_chargeEnergy.OnBegin();
		}
		else
		{
			m_chargeEnergy.OnEnd();
		}
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		m_chargeEnergy.FixedUpdate();
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
