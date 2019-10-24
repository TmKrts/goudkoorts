using Goudkoorts_Code.Domain;
using Goudkoorts_Code.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Process
{
    class GameController
    {
        private OutputView outputView;
        private Game game;
        private Map map;
        private _buffer = 2000;
        private Timer timer;
        private bool 

        public GameController()
        {
            outputView = new OutputView();
            game = new Game();
        }

        public void Start()
        {
            outputView.ShowStartScreen();
            outputView.DrawMap();
        }
    }
}
