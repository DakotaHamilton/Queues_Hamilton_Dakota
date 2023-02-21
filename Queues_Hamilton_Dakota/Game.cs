using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Hamilton_Dakota
{
    class Game
    {
        // Player Max Capacity
        public int MaxPlayers { get; }

        // Player Current Amount
        public int CurrentPlayers { get; set; }

        // Assigning Variables
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        // Kick Player/s
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        // Player Connection Queue
        public void CheckQueue(Queue<Player> playerQueue)
        {
            // Current and Max Player Comparison
            if(CurrentPlayers < MaxPlayers)
            {
                // Checks if the there are Players in the Queue
                if(playerQueue.Count > 0)
                {
                    // Dequeues the Player when the queue is Greater than 0
                    playerQueue.Dequeue();
                    
                    // Connects the Player to the Server after Queue
                    CurrentPlayers++;
                }
                
                // Player Queue Count is 0
                else
                {
                    Console.WriteLine("No player in the queue!");
                }
            }
        }


    }
}
