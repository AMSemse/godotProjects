using Godot;
using System;


public partial class Collectible : Area2D
{

	private GameManager Node;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		Node = GetNode<GameManager>("Node");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	private void OnCollectibleBodyEntered(PhysicsBody2D body)
	{
		QueueFree();
		Node.AddPoints();
	}

}

