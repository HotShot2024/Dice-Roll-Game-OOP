﻿using Dice_Roll_Game_OOP.Game;

var random  = new Random();
var dice  = new Dice(random);
var guessingGame = new GuessingGame(dice);

GameResult gameResult = guessingGame.Play();
GuessingGame.Printresult(gameResult);   


Console.ReadKey();

