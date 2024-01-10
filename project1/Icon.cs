using Godot;
using System;

public partial class Icon : Sprite2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		float moveSpeed = 5;

		if (Input.IsKeyPressed((int)KeyList.W))
		{
			this.Position += new Vector2(0, -moveSpeed);
		}
		if (Input.IsKeyPressed((int)KeyList.S))
		{
			this.Position += new Vector2(0, moveSpeed);
		}
		if (Input.IsKeyPressed((int)KeyList.A))
		{
			this.Position += new Vector2(-moveSpeed, 0);
		}
		if (Input.IsKeyPressed((int)KeyList.D))
		{
			this.Position += new Vector2(moveSpeed, 0);
		}
	}
}
