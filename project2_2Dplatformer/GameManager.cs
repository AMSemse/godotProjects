using Godot;
using System;
using System.Drawing;

public partial class GameManager : Node
{
	int points = 0;
	private PointsLabel Label;
	public override void _Ready()
	{
		Label = GetNode<PointsLabel>("../UI/Panel/PointsLabel");
		Label.Text = points.ToString() + "/6";
	}

	public void AddPoints()
	{
		points++;
		//GD.Print(points);
		Label.Text = points.ToString() + "/6";
	}
}
