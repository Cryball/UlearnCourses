﻿// <Summary>
// Карты Таро
// Вася нашел в интернете сайт, предсказывающий будущее на картах Таро.
// Он решил перенести сайт в Россию и заработать на доверчивых людях.
// Для этого сайт необходимо русифицировать.
// Вася справился с проблемой русификации мастей.Но решение длинное, 
// а русифицировать нужно еще много чего. Кажется, что эту задачу можно решить 
// немного веселее, с помощью массивов.Возможно даже всего в одну строчку кода.
// Сделайте это!
// </Summary>

using System;
using System.Collections.Generic;
using System.Text;

namespace LecturePractice.Lecture5
{
    public static class Task5
    {
		enum Suits
		{
			Wands,
			Coins,
			Cups,
			Swords
		}

		public static void Taro()
		{
			Console.WriteLine(GetSuit(Suits.Wands));
			Console.WriteLine(GetSuit(Suits.Coins));
			Console.WriteLine(GetSuit(Suits.Cups));
			Console.WriteLine(GetSuit(Suits.Swords));
		}
		private static string GetSuit(Suits suit)
		{
			return new string[] { "жезлов", "монет", "кубков", "мечей" }[(int)suit];
		}
	}
}
