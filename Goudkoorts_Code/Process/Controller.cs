using Goudkoorts_Code.Domain;
using Goudkoorts_Code.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Goudkoorts_Code.Process
{
    class Controller
    {
        private InputView _InputView;
        private OutputView _OutputView;
        private Map _Map;
        private int _Buffer = 2000;
        private Timer _Timer;
        private bool _Playing;
        public static int Score;

        public Controller()
        {
            _InputView = new InputView();
            _OutputView = new OutputView();
            _Map = new Map();
            _OutputView.ShowStartScreen();
            _OutputView.DrawMap(_Map, Score);
            _OutputView.PrintControls();

            _Timer = new Timer();
            _Timer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            _Playing = true;
            Start();
        }

        public void Start()
        {  
            _Timer.Interval = _Buffer;
            _Timer.Enabled = true;
            while (_Playing)
            {
                int result = _InputView.GetSwitchNumber();
                switch(result)
                {
                    case -1:
                        Environment.Exit(0);
                        break;
                    case 1:
                        _Map.DoSwitch(1);
                        Console.Clear();
                        _OutputView.DrawMap(_Map, Score);
                        _OutputView.PrintControls();
                        break;
                    case 2:
                        _Map.DoSwitch(2);
                        Console.Clear();
                        _OutputView.DrawMap(_Map, Score);
                        _OutputView.PrintControls();
                        break;
                    case 3:
                        _Map.DoSwitch(3);
                        Console.Clear();
                        _OutputView.DrawMap(_Map, Score);
                        _OutputView.PrintControls();
                        break;
                    case 4:
                        _Map.DoSwitch(4);
                        Console.Clear();
                        _OutputView.DrawMap(_Map, Score);
                        _OutputView.PrintControls();
                        break;
                    case 5:
                        _Map.DoSwitch(5);
                        Console.Clear();
                        _OutputView.DrawMap(_Map, Score);
                        _OutputView.PrintControls();
                        break;
                }
            }
        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            _Playing = false;
            _Timer.Enabled = false;

            bool notCrashed = _Map.MoveVehicles();
            if (!notCrashed)
            {
                _Timer.Enabled = false;
                _OutputView.ShowEndScreen();
                Console.ReadKey();
                Environment.Exit(0);
            }
            _OutputView.DrawMap(_Map, Score);
            _Map.SpawnShip();
            if (Score > 17)
            {
                _Map.SpawnCart();
            }
            else
            {
                Random r = new Random();
                int i = r.Next(3);
                if (i == 0)
                {
                    _Map.SpawnCart();
                }
            }
            _OutputView.DrawMap(_Map, Score);
            _OutputView.PrintControls();
            if (_Buffer > 1500)
            {
                _Buffer -= 100; // Fast as **** BOI
            }
            _Playing = true;
            Start();
        }
    }
}
