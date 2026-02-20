using System;
using System.IO;
using System.Collections.Generic;
					
public class Program
{
	public class QuizItem {
		public string Question { get; set; }
		public string Answer { get; set; }
		
		public static string[] ToStr(QuizItem item) {
			string str = "";
			str += ":";
			str += item.Question;
			str += "\n=";
			str += item.Answer;
			
			return str.Split('\n');
		}
		
		public static QuizItem? FromStr(string[] str) {
			if(str.Length != 2) return null;
			
			QuizItem item = new();
			string[] q = str[0].Split(':');
			if(q.Length != 2) return null;
			
			string[] a = str[1].Split('=');
			if(q.Length != 2) return null;
			
			item.Question = q[1];
			item.Answer = a[1];
			
			return item;
		}
	}
	
	// Quiz to save
	public static QuizItem[] _quiz = {
		new() {
			Question 	= "Which element has the chemical symbol 'O'?",
			Answer 		= "Oxygen"
		},
		new() {
			Question 	= "Which planet is known as the 'Morning Star' or 'Evening Star'?",
			Answer 		= "Venus"
		},
		new() {
			Question 	= "Which planet is known as the Red Planet?",
			Answer 		= "Mars"
		},
		new() {
			Question 	= "Who wrote '1984'?",
			Answer 		= "George Orwell"
		},
		new() {
			Question 	= "What is the capital of France?",
			Answer 		= "Paris"
		},
		new() {
			Question 	= "In what year did the United States declare its independence?",
			Answer 		= "1776"
		},
		new() {
			Question 	= "Who wrote 'Romeo and Juliet'?",
			Answer 		= "William Shakespeare"
		},
		new() {
			Question 	= "What is the longest river in the world?",
			Answer 		= "Amazon"
		},
		new() {
			Question 	= "Who is known as the 'Father of Computer Science'?",
			Answer 		= "Alan Turing"
		},
		new() {
			Question 	= "Who is the author of 'To Kill a Mockingbird'?",
			Answer 		= "Harper Lee"
		}
	};
	
	public static string file = "quiz.txt";
	
	public static void Main()
	{
		// Write to file
		List<string> _lines = new List<string>();
		for(int i = 0; i < _quiz.Length; i++) {
			string[] _item = QuizItem.ToStr(_quiz[i]);
			_lines.AddRange(_item);
		}
		File.WriteAllLines(file, _lines.ToArray());
		Console.WriteLine($"Total lines written to file: {_lines.Count}");
		
		string[] loaded = File.ReadAllLines(file);
		Console.WriteLine($"Total lines read from file: {loaded.Length}");
		
		QuizItem[] quiz = new QuizItem[loaded.Length / 2];
		int fi = 0;
		for(int i = 0; i < quiz.Length; i++) {
			string[] lines = {
				loaded[fi],
				loaded[fi + 1]
			};
			quiz[i] = QuizItem.FromStr(lines);
			if(quiz[i] == null) {
				Console.WriteLine("Failed to load from file");
				return;
			}
			
			fi += 2;
		}
		
		List<QuizItem> q = new List<QuizItem>(quiz);
		Random r = new Random();
		int score = 0;
		
		for(int i = 0; i < q.Count; i++) {
			QuizItem item = q[r.Next(0, q.Count)];
			
			// This is buggy but I think only in .NET fiddle
			// It seems to work when running using Visual Studio
			
			Console.WriteLine();
			Console.WriteLine(item.Question);
			Console.Write("Answer: ");
			string answer = Console.ReadLine().ToLower();
			
			if(item.Answer.ToLower() == answer) {
				Console.WriteLine("Correct");
				score++;
			} else {
				Console.WriteLine($"Incorrect (Answer: {item.Answer})");
			}
			
			q.Remove(item);
		}
			
		Console.WriteLine($"Score: {score}");
	}
}