using System;
using System.Collections.Generic;

namespace Queues_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args)
        {
            // Players in Match
            Game myGame = new Game(50, 49);

            // Player Queue
            Queue<Player> waitingToJoinQ = new Queue<Player>();

            // Player/s in the Queue
            Player p1 = new Player(100, "Commander_Kota");
            Player p2 = new Player(100, "General_Joeback");
            Player p3 = new Player(100, "Commando_Rapi");
            Player p4 = new Player(100, "Demolitionist_Anis");

            // Player/s waiting to Join
            p1.JoinGame(myGame, waitingToJoinQ);
            p2.JoinGame(myGame, waitingToJoinQ);
            p3.JoinGame(myGame, waitingToJoinQ);
            p4.JoinGame(myGame, waitingToJoinQ);

            // Says who is in the Queue
            Console.WriteLine("Players in da Q:");

            // Shows Player/s waiting to Join
            foreach(Player player in waitingToJoinQ)
            {
                // Shows Player/s GamerTag/s
                Console.WriteLine(player);
            }

            // Kicks Players from Joining from the Queue when the game is Full
            myGame.KickPlayer();
            myGame.CheckQueue(waitingToJoinQ);

            // Says who is in the Queue
            Console.WriteLine("\nPlayers in da Q:");

            // Shows Player/s waiting to Join
            foreach (Player player in waitingToJoinQ)
            {
                // Shows Player/s GamerTag/s
                Console.WriteLine(player);
            }
        }
    }
}
