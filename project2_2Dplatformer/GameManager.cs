using Godot;
using System;

public partial class GameManager : Node
{
	int points = 0;

	public void AddPoints()
	{
		points++;
		GD.Print(points);
	}
}
