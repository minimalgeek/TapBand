﻿using UnityEngine;
using System.Collections;

[System.Serializable]
public class EquipmentState {
	private int drumEquipmentId;
	private int guitarEquipmentId;
	private int bassEquipmentId;
	private int keyboardEquipmentId;

	public int DrumEquipmentId
	{
		get
		{
			return drumEquipmentId;
		}
		
		set
		{
			drumEquipmentId = value;
		}
	}

	public int GuitarEquipmentId
	{
		get
		{
			return guitarEquipmentId;
		}
		
		set
		{
			guitarEquipmentId = value;
		}
	}

	public int BassEquipmentId
	{
		get
		{
			return bassEquipmentId;
		}
		
		set
		{
			bassEquipmentId = value;
		}
	}

	public int KeyboardEquipmentId
	{
		get
		{
			return keyboardEquipmentId;
		}
		
		set
		{
			keyboardEquipmentId = value;
		}
	}

	public EquipmentData CurrentDrumEquipment
	{
		get
		{
			if (drumEquipmentId == 0)
			{
				return null;
			}
			return GameData.instance.EquipmentDataList.Find(x => x.id == drumEquipmentId);
		}
	}

	public EquipmentData CurrentGuitarEquipmentId
	{
		get
		{
			if (guitarEquipmentId == 0)
			{
				return null;
			}
			return GameData.instance.EquipmentDataList.Find(x => x.id == guitarEquipmentId);
		}
	}

	public EquipmentData CurrentBassEquipmentId
	{
		get
		{
			if (bassEquipmentId == 0)
			{
				return null;
			}
			return GameData.instance.EquipmentDataList.Find(x => x.id == bassEquipmentId);
		}
	}

	public EquipmentData CurrentKeyboardEquipmentId
	{
		get
		{
			if (keyboardEquipmentId == 0)
			{
				return null;
			}
			return GameData.instance.EquipmentDataList.Find(x => x.id == keyboardEquipmentId);
		}
	}

	public EquipmentData NextDrumEquipment
	{
		
	}

	public EquipmentData NextGuitarEquipment
	{
		
	}

	public EquipmentData NextBassEquipment
	{
		
	}

	public EquipmentData NextKeyboardEquipment
	{
		
	}

}
