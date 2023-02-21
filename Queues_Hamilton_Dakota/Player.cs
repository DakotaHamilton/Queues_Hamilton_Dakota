using System;
using System.Collections.Generic;
using System.Text;

namespace Queues_Hamilton_Dakota
{
    /// <summary>
    /// Player Reference
    /// </summary>
    class Player
    {
        /* Player Health */
        public int Health { get; set; }
        
        /* Player Name */
        public string GamerTag { get; }

        // Player Assigning Variables
        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        // Player Game Connection Queue
        public void JoinGame(Game game, Queue<Player> queue)
        {
            // Checks for an available Player slot
            if(game.CurrentPlayers == game.MaxPlayers)
            {
                // Ends queue if slots are full 
                queue.Enqueue(this);
            }

            // Player slots are open
            else
            {
                // Tells the Player they are joining
                Console.WriteLine("Joining Game!");

                // Connects Player to server
                game.CurrentPlayers++;
            }
        }

        // Converts the Player/s entered name to a String
        public override string ToString()
        {
            // Returns the Player/s name as their GamerTag
            return GamerTag;
        }
    }
}
