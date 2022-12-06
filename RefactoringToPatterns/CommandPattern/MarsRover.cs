using System.Linq;

namespace RefactoringToPatterns.CommandPattern
{
    public class MarsRover
    {
        private int x;
        private int y;
        private char direction;
        private readonly string availableDirections = "NESW";
        private readonly string[] obstacles;
        private bool obstacleFound;

        public MarsRover(int x, int y, char direction, string[] obstacles)
        {
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.obstacles = obstacles;
        }
        
        public string GetState()
        {
            return !obstacleFound ? $"{x}:{y}:{direction}" : $"O:{x}:{y}:{direction}";
        }

        public void Execute(string commands)
        {
            foreach(char command in commands)
            {
                if (command == 'M')
                {
                    switch (direction)
                    {
                        case 'E':
                            obstacleFound = obstacles.Contains($"{x + 1}:{y}");
                            // check if rover reached plateau limit or found an obstacle
                            x = x < 9 && !obstacleFound ? x += 1 : x;
                            break;
                        case 'S':
                            obstacleFound = obstacles.Contains($"{x}:{y + 1}");
                            // check if rover reached plateau limit or found an obstacle
                            y = y < 9 && !obstacleFound ? y += 1 : y;
                            break;
                        case 'W':
                            obstacleFound = obstacles.Contains($"{x - 1}:{y}");
                            // check if rover reached plateau limit or found an obstacle
                            x = x > 0 && !obstacleFound ? x -= 1 : x;
                            break;
                        case 'N':
                            obstacleFound = obstacles.Contains($"{x}:{y - 1}");
                            // check if rover reached plateau limit or found an obstacle
                            y = y > 0 && !obstacleFound ? y -= 1 : y;
                            break;
                    }
                }
                else if(command == 'L')
                {
                    // get new direction
                    var currentDirectionPosition = availableDirections.IndexOf(direction);
                    if (currentDirectionPosition != 0)
                    {
                        direction = availableDirections[currentDirectionPosition-1];
                    }
                    else
                    {
                        direction = availableDirections[3];
                    }
                } else if (command == 'R')
                {
                    // get new direction
                    var currentDirectionPosition = availableDirections.IndexOf(direction);
                    if (currentDirectionPosition != 3)
                    {
                        direction = availableDirections[currentDirectionPosition+1];
                    }
                    else
                    {
                        direction = availableDirections[0];
                    }
                }
            }
        }
    }
}