using Core.Project;
using Godot;
using System;

public partial class Control : Godot.Control
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public int AddTwoNumbers(int x, int y)
	{
		var cl = new Class1();
		var res = cl.AddTwoNumbers(x, y);
		GetNode<Label>("%ResultLabel").Text = res.ToString();

		return res;
	}
}
