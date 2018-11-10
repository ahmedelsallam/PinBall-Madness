using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

	public int playerOneScore, playerTwoScore;

	public BallScript pinball;

	PauseMenu pauseMenu;


	public Text player1ScoreText;
	public Text player2ScoreText;


	public GameObject winnerCanvas;
	public GameObject bluePlayerWinScreen;
	public GameObject redPlayerWinScreen;


	public void Start () {

		//start the game pause as we using the same scene for everything
		pauseMenu = GetComponent<PauseMenu> ();
		pauseMenu.StartGamePause ();

		//sets each player at 0 for goals

		playerOneScore = 0;
		playerTwoScore = 0;
		
	}


	public void GoalScored (int playerNumber){

		// to increase the score for whoever scores and change the score text accordingly

		if (playerNumber == 1) {

			playerOneScore++;
			player1ScoreText.text = playerOneScore.ToString ();
//			Debug.Log ("you are such a bad player, hahaha!!");
			pinball.Reset();

		} else if (playerNumber == 2) {

			playerTwoScore++;
			player2ScoreText.text = playerTwoScore.ToString ();
//			Debug.Log ("owned you!!");
			pinball.Reset();

		}

		// check which player has won

		if (playerOneScore == 5){
			
			GameOver (playerOneScore);
			winnerCanvas.SetActive (true);
			bluePlayerWinScreen.SetActive (true);
			redPlayerWinScreen.SetActive (false);
			player1ScoreText.text = playerOneScore.ToString ();

		} 
		else if (playerTwoScore == 5){
			
			GameOver (playerTwoScore);
			winnerCanvas.SetActive (true);
			redPlayerWinScreen.SetActive (true);
			bluePlayerWinScreen.SetActive (false);
			player2ScoreText.text = playerTwoScore.ToString ();
		}
	}

	void GameOver(int winner){

		//when one player wins this will reset the game

		playerOneScore = 0;
		player1ScoreText.text = playerOneScore.ToString ();

		playerTwoScore = 0;
		player2ScoreText.text = playerTwoScore.ToString ();

		pinball.Reset();
	}
}
