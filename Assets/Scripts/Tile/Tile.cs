﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
	public ITile TileType { get; set; }
}

public interface ITile
{
	void Action();
}

public class StartTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a StartTile");
	}
}

public class PlotTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a PlotTile");
	}
}

public class GoToJailTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a GoToJailTile");
	}
}

public class JailTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a JailTile");
	}
}

public class ChanceTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a ChanceTile");
	}
}

public class SpecialPlotTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a SpecialPlotTile");
	}
}

public class FreeParkingTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a FreeParkingTile");
	}
}

public class ChestTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a ChestTile");
	}
}

public class TaxTile : ITile
{
	public virtual void Action()
	{
		Debug.Log("I am a TaxTile");
	}
}
