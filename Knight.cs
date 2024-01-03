using Godot;
using System;

public partial class Knight : Sprite2D
{
	private float _speed = 400;
	private float _angularSpeed = Mathf.Pi;

	public override void _Ready()
	{
		GD.Print("hellow from knight!");
	}

	public override void _Process(double delta)
	{
		var direction = 0;
		if (Input.IsActionPressed("ui_left"))
		{
			direction = -1;
		}
		if (Input.IsActionPressed("ui_right"))
		{
			direction = 1;
		}

		Rotation += _angularSpeed * direction * (float)delta;

		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("ui_up"))
		{
			velocity = Vector2.Up.Rotated(Rotation) * _speed;
		}

		Position += velocity * (float)delta;
	}
}
