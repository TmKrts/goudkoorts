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
        private Map map;

        public static int Score;

        public Controller()
        {
            outputView = new OutputView();
            map = new Map();
        }

        public void Start()
        {
            outputView.ShowStartScreen();
            outputView.DrawMap(map, Score);
        }
    }
}
