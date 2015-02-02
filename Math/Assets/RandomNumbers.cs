using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomNumbers : MonoBehaviour 
{
	public Text Num1;
	public Text Num2;
	public Text Ans1;
	public Text Ans2;
	public Text Ans3;
	public Text Correct;
	public Text Incorrect;

	private int number1;
	private int number2;
	private int answer1;
	private int answer2;
	private int answer3;

	private float N1; 
	private float N2;
	private float A1;
	private float A2;
	private float A3;
	
	public void Click(string text)
	{
		Correct.text = ("Correct");
	}

	public void Click2(string text)
	{
		Incorrect.text = ("Incorrect");
	}

	// Use this for initialization
	void Start () 
	{
		N1 = Random.Range (3.0f, 9.0f);
		N2 = Random.Range (3.0f, 9.0f);
		A2 = Random.Range (6.0f, 18.0f);
		A3 = Random.Range (6.0f, 18.0f);

		int number1 = (int)N1;
		int number2 = (int)N2;

		int answer1 = number1 + number2;
		int answer2 = (int)A2;
		int answer3 = (int)A3;

		Num1.text = number1.ToString ();
		Num2.text = number2.ToString ();
		Ans1.text = answer1.ToString ();
		Ans2.text = answer2.ToString ();
		Ans3.text = answer3.ToString ();
	}

	// Update is called once per frame
	void Update () 
	{
	}
}