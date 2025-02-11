using main;
using System;

class Program {
  static void Main(string[] args)
  {
      Maze maze = new Maze();
      maze.LoadMaze("maze.txt");
        maze.Solve(new QueeVisitList());
  }
}