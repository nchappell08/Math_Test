#pragma strict

public var UIAnswer:UI.Text;
public var UINumber1:UI.Text;
public var UINumber2:UI.Text;
public var UIAnswer2:UI.Text;
public var UIAnswer3:UI.Text;

private var number1:int;
private var number2:int;
private var answer1:int;
private var answer2:int;
private var answer3:int;

function Start ()
{
	number1 = Random.Range( 3.0, 9.0 );
	number2 = Random.Range( 3.0, 9.0 );
	
	answer1 = number1 + number2;
	answer2 = Random.Range( 6.0, 18.0 );
	answer3 = Random.Range( 6.0, 18.0 );
	
	UIAnswer.text = answer1.ToString();
	UIAnswer2.text = answer2.ToString();
	UIAnswer3.text = answer3.ToString();
	UINumber1.text = number1.ToString();
	UINumber2.text = number2.ToString();
}

function Update ()
{
	
}

