using Godot;
using System;

public partial class MainCharacter : CharacterBody2D
{
	public const float Speed = 350.0f;
	public const float JumpVelocity = -1000.0f;

	private AnimatedSprite2D Sprite2D;

    public override void _Ready()
    {
        Sprite2D = GetNode<AnimatedSprite2D>("Sprite2D");
				//GD.Print(Sprite2D);
    }

    // Get the gravity from the project settings to be synced with RigidBody nodes.
    public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		//Animations
		if (Math.Abs(velocity.X) > 1)
			Sprite2D.Animation = "run";
		else 
			Sprite2D.Animation = "idle";

		// Add the gravity.
		if (!IsOnFloor()) {
			velocity.Y += gravity * (float)delta;
			Sprite2D.Animation = "jump";
		}
		// Handle Jump.
		if (Input.IsActionJustPressed("jump") && IsOnFloor())
			velocity.Y = JumpVelocity;

		// Get the input direction and handle the movement/deceleration.
		Vector2 direction = Input.GetVector("left", "right", "ui_up", "ui_down");
		if (direction != Vector2.Zero)
		{
			velocity.X = direction.X * Speed;
		}
		else
		{
			velocity.X = Mathf.MoveToward(Velocity.X, 0, 300);
		}

		Velocity = velocity;
		MoveAndSlide();

		// Flip sprite based on direction
		bool isLeft = velocity.X < 0;
		Sprite2D.FlipH = isLeft;

	}
}
