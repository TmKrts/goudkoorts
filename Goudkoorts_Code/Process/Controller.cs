using Goudkoorts_Code.Domain;
using Goudkoorts_Code.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Process
{
    class Controller
    {
        private OutputView outputView;
        private Game game;

        public Controller()
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
