using Godot;
using System;

public partial class Knight : Sprite2D
{
	private float _speed = 150;
	private float _angularSpeed = Mathf.Pi;

	public override void _Ready()
	{
		GD.Print("hellow from knight!");
		GD.Print("disgrasa");
	}

	public override void _Process(double delta)
	{
		
		var velocity = Vector2.Zero;
		if (Input.IsActionPressed("ui_up"))
		{
			velocity = Vector2.Up * _speed;
		}

		if (Input.IsActionPressed("ui_down")) {
			velocity = Vector2.Down * _speed;
		}

		if (Input.IsActionPressed("ui_left")) {
			velocity = Vector2.Left * _speed;
		}

		if (Input.IsActionPressed("ui_right")) {
			velocity = Vector2.Right * _speed;
		}

		if (Input.IsActionPressed("ui_right") && Input.IsActionPressed("ui_up")) {
			velocity = (Vector2.Right + Vector2.Up) * _speed;
		}

		if (Input.IsActionPressed("ui_right") && Input.IsActionPressed("ui_down")) {
			velocity = (Vector2.Right + Vector2.Down) * _speed;
		}

		if (Input.IsActionPressed("ui_left") && Input.IsActionPressed("ui_up")) {
			velocity = (Vector2.Left + Vector2.Up) * _speed;
		}
		
		if (Input.IsActionPressed("ui_left") && Input.IsActionPressed("ui_down")) {
			velocity = (Vector2.Left + Vector2.Down) * _speed;
		}




		Position += velocity * (float)delta;
	}
}
