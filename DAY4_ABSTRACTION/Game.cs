using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY4_ABSTRACTION
{
    public class Game
    {
        public int CurrentNumber;
        public Iplayer PlayerOne;
        public Iplayer PlayerTwo;
        public void StartNewGame();
        public void Loop();
        public void PlayerTurn(IPlayer player);
    }
}
