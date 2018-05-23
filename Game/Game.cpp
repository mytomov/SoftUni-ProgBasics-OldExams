// ConsoleApplication23.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <string>
#include <cctype>
#include <conio.h>

using namespace std;


int main()
{
	std::string input;
	string name;
	int health = 1000;
	int damage = 75;
	int stamina = 300;
	int currentHealth;
	int currentStamina;
	int potion = 300;

	cout << "Just in time! We need someone to fight the monster which is terrorising our village." << endl << "Hey, what's your name?" << endl;

	std::getline(std::cin, name);

	cout << "Would you help us?\n1. Yes\n2. No" << endl;

	cin >> input;

	if (input == "Yes")
	{
		cout << "Oh, thank you! You will be greatly rewarded...if you don't die, that is..." << endl;
	}
	else if (input == "No")
	{
		cout << "You're going to die anyway...eventually...WHy not? You've got nothing to lose...I mean, look at yourself!" << endl;
	}
	else
	{
		cout << "Ugh, okay...It's not like you have a choice. You're coming, like it or not!" << endl;
	}

	std::getline(std::cin, input);

	cout << "*after miles and miles of walking (because this is the past, apparently, and cars were not invented)...*" << endl << "There it is, the monster! Please, kill it....like, now!" << endl;

	cout << "Well, aren't you gonna attack it? Or are you going to flee?\n1. Attack\n2. Flee" << endl;

	std::getline(std::cin, input);

	if (input == "attack")
	{
		cout << "You attacked the monster! The monster died." << endl << "Wow, that was unbelievably tough, right?! Here, take this sword!" << endl;
	}
	else if (input == "Flee")
	{
		cout << "You are of the cowardly ones, aren't you? Well, can't say I didn't expected it from you..." << endl;
	}
	else
	{
		cout << "Why am I even asking you?! Go and fight it" << endl;
	}

	currentHealth = health - (damage * 5);
	cout << "You were hit 5 times by that monster. Your health:" << currentHealth << endl;

	currentHealth = currentHealth + potion;
	cout << "Take this potion, it will help" << currentHealth << endl;

	cout << "Would you be willing to help us with another monster?\n1 Why not\n2 Hell no" << endl;

	std::getline(std::cin, input);

	if (input == "Why not")
	{
		cout << "Great! Follow me!" << endl;
	}
	else if (input == "Hell no")
	{
		cout << "Again, it's not like you have a choice. You're coming!" << endl;
	}
	else
	{
		cout << "Okaaay...Follow me!" << endl;
	}

	cout << "It's in that house!" << endl;

	int n = 35;
	string dashes, stars;

	int roof_rows = (n + 1) / 2;
	int stars_count = 1;
	int dash_count;

	if (n % 2 == 0)
	{
		stars_count = 2;
	}

	for (int rows = 1; rows <= roof_rows; rows++)
	{
		dash_count = (n - stars_count) / 2;
		stars = string(stars_count, '*');
		dashes = string(dash_count, '-');
		cout << dashes << stars << dashes << endl;
		stars_count += 2;
	}

	for (int row = 1; row <= n - roof_rows; row++)
	{
		cout << '|' << string(n - 2, '*') << '|' << endl;
	}

	cout << "*entering the house*" << endl << "*a wild beast appears*" << "\n1 Do you attack it\n2 Do you flee" << endl;

	std::getline(std::cin, input);

	if (input == "Yes")
	{
		cout << "You attacked the beast and you died. Nice..." << endl;
	}
	else if (input == "No")
	{
		cout << "Wow, that's brave of you...Sadly, the beast is faster than you and now you are dead...." << endl;
	}
	else
	{
		cout << "The beast killed you" << endl;
	}

	cout << "GAME OVER!!!" << endl;


	return 0;
}
