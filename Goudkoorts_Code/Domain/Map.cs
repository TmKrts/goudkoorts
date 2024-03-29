﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Map
    {
        private WareHouse[] _WareHouse;
        private BaseSwitch[] _Switches;
        private List<Vehicle> _Vehicles;
        private BaseRail[] _Channels;
        private Random r;

        public BaseRail[] Row1 { get; }
        public BaseRail[] Row2 { get; }
        public BaseRail[] Row3 { get; }
        public BaseRail[] Row4 { get; }
        public BaseRail[] Row5 { get; }

        public Map()
        {
            _Switches = new BaseSwitch[5];
            _WareHouse = new WareHouse[3];
            _Vehicles = new List<Vehicle>();
            _Channels = new BaseRail[8];
            r = new Random();

            Row1 = new BaseRail[23];
            Row2 = new BaseRail[23];
            Row3 = new BaseRail[10];
            Row4 = new BaseRail[9];
            Row5 = new BaseRail[23];

            // column 1, 2 and 3
            WareHouse WHA = new WareHouse();
            WareHouse WHB = new WareHouse();
            WareHouse WHC = new WareHouse();
            _WareHouse[0] = WHA;
            _WareHouse[1] = WHB;
            _WareHouse[2] = WHC;

            NormalRail NR1 = new NormalRail();
            WHA.Next = NR1;
            NormalRail NR2 = new NormalRail();
            WHB.Next = NR2;
            NormalRail NR3 = new NormalRail();
            WHC.Next = NR3;

            NormalRail NR4 = new NormalRail();
            NR1.Next = NR4;
            NormalRail NR5 = new NormalRail();
            NR2.Next = NR5;
            NormalRail NR6 = new NormalRail();
            NR3.Next = NR6;

            NormalRail NR7 = new NormalRail();
            NR4.Next = NR7;
            NormalRail NR8 = new NormalRail();
            NR5.Next = NR8;
            NormalRail NR9 = new NormalRail();
            NR6.Next = NR9;

            InSwitch S1 = new InSwitch(NR7, NR8);
            S1.Previous = NR8;
            NR8.Next = S1;

            // column 4 and 5
            NormalRail NR10 = new NormalRail();
            S1.Next = NR10;
            NormalRail NR11 = new NormalRail();
            NR9.Next = NR11;

            NormalRail NR12 = new NormalRail();
            NormalRail NR13 = new NormalRail();
            NormalRail NR14 = new NormalRail();
            NR11.Next = NR14;

            OutSwitch S2 = new OutSwitch(NR12, NR13);
            NR10.Next = S2;
            S2.Next = NR12;

            // column 6
            NormalRail NR15 = new NormalRail();
            NR12.Next = NR15;
            NormalRail NR16 = new NormalRail();
            NR13.Next = NR16;
            NormalRail DT34 = new NormalRail();
            NR14.Next = DT34;

            InSwitch S3 = new InSwitch(NR16, DT34);
            NR16.Next = S3;
            S3.Previous = NR16;

            // column 7 and 8
            NormalRail NR18 = new NormalRail();
            NR15.Next = NR18;
            NormalRail NR19 = new NormalRail();
            S3.Next = NR19;

            NormalRail NR20 = new NormalRail();
            NR18.Next = NR20;
            NormalRail NR21 = new NormalRail();
            NormalRail NR22 = new NormalRail();

            OutSwitch S4 = new OutSwitch(NR21, NR22);
            S4.Next = NR22;
            NR19.Next = S4;

            // column 9
            NormalRail NR23 = new NormalRail();
            NR20.Next = NR23;
            NormalRail NR24 = new NormalRail();
            NR21.Next = NR24;
            NormalRail NR25 = new NormalRail();
            NR22.Next = NR25;

            InSwitch S5 = new InSwitch(NR23, NR24);
            S5.Previous = NR23;
            NR23.Next = S5;

            // column 10, 11 and 12
            NormalRail NR26 = new NormalRail();
            S5.Next = NR26;
            NormalRail NR27 = new NormalRail();
            NR25.Next = NR27;

            NormalRail NR28 = new NormalRail();
            NR26.Next = NR28;
            NormalRail NR29 = new NormalRail();
            NR27.Next = NR29;

            NormalRail NR30 = new NormalRail();
            NR28.Next = NR30;
            NormalRail NR31 = new NormalRail();
            NR29.Next = NR31;

            // column 13 and 14 the firts channel_piece
            NormalRail NR32 = new NormalRail();
            NR30.Next = NR32;
            NormalRail NR33 = new NormalRail();
            NR31.Next = NR33;

            NormalRail NR34 = new NormalRail();
            NR32.Next = NR34;
            NormalRail NR35 = new NormalRail();
            NR33.Next = NR35;

            // column 15 the first parkRail
            Channel ch1 = new Channel();
            NormalRail NR36 = new NormalRail();
            NR34.Next = NR36;
            ParkRail PR1 = new ParkRail();
            NR35.Next = PR1;

            // column 16 the dock and quay
            Channel ch2 = new Channel();
            ch1.Next = ch2;
            Quay quay = new Quay();
            quay.Dock = ch2;
            NR36.Next = quay;
            ParkRail PR2 = new ParkRail();
            PR1.Next = PR2;

            // column 17 till end
            Dock ch3 = new Dock();
            ch2.Next = ch3;
            NormalRail NR37 = new NormalRail();
            quay.Next = NR37;
            ParkRail PR3 = new ParkRail();
            PR2.Next = PR3;

            Channel ch4 = new Channel();
            ch3.Next = ch4;
            NormalRail NR38 = new NormalRail();
            NR37.Next = NR38;
            ParkRail PR4 = new ParkRail();
            PR3.Next = PR4;

            Channel ch5 = new Channel();
            ch4.Next = ch5;
            NormalRail NR39 = new NormalRail();
            NR38.Next = NR39;
            ParkRail PR5 = new ParkRail();
            PR4.Next = PR5;

            Channel ch6 = new Channel();
            ch5.Next = ch6;
            NormalRail NR40 = new NormalRail();
            NR39.Next = NR40;
            ParkRail PR6 = new ParkRail();
            PR5.Next = PR6;

            Channel ch7 = new Channel();
            ch6.Next = ch7;
            NormalRail NR41 = new NormalRail();
            NR40.Next = NR41;
            ParkRail PR7 = new ParkRail();
            PR6.Next = PR7;

            EndChannel ch8 = new EndChannel();
            ch8.Next = ch8;
            EndRail NR42 = new EndRail();
            NR41.Next = NR42;
            ParkRail PR8 = new ParkRail();
            PR7.Next = PR8;

            // fill shiproute
            _Channels[0] = ch1;
            _Channels[1] = ch2;
            _Channels[2] = ch3;
            _Channels[3] = ch4;
            _Channels[4] = ch5;
            _Channels[5] = ch6;
            _Channels[6] = ch7;
            _Channels[7] = ch8;

            //fill switches list
            _Switches[0] = S1;
            _Switches[1] = S2;
            _Switches[2] = S3;
            _Switches[3] = S4;
            _Switches[4] = S5;

            //fill rows
            Row1[0] = WHA;
            Row1[1] = NR1;
            Row1[2] = NR4;
            Row1[3] = NR7;
            Row1[4] = new Space();
            Row1[5] = NR12;
            Row1[6] = NR15;
            Row1[7] = NR18;
            Row1[8] = NR20;
            Row1[9] = NR23;
            Row1[10] = new Space();
            Row1[11] = new Space();
            Row1[12] = new Space();
            Row1[13] = new Space();
            Row1[14] = new Space();
            Row1[15] = ch1;
            Row1[16] = ch2;
            Row1[17] = ch3;
            Row1[18] = ch4;
            Row1[19] = ch5;
            Row1[20] = ch6;
            Row1[21] = ch7;
            Row1[22] = ch8;

            Row2[0] = new Space();
            Row2[1] = new Space();
            Row2[2] = new Space();
            Row2[3] = S1;
            Row2[4] = NR10;
            Row2[5] = S2;
            Row2[6] = new Space();
            Row2[7] = new Space();
            Row2[8] = new Space();
            Row2[9] = S5;
            Row2[10] = NR26;
            Row2[11] = NR28;
            Row2[12] = NR30;
            Row2[13] = NR32;
            Row2[14] = NR34;
            Row2[15] = NR36;
            Row2[16] = quay;
            Row2[17] = NR37;
            Row2[18] = NR38;
            Row2[19] = NR39;
            Row2[20] = NR40;
            Row2[21] = NR41;
            Row2[22] = NR42;

            Row3[0] = WHB;
            Row3[1] = NR2;
            Row3[2] = NR5;
            Row3[3] = NR8;
            Row3[4] = new Space();
            Row3[5] = NR13;
            Row3[6] = NR16;
            Row3[7] = new Space();
            Row3[8] = NR21;
            Row3[9] = NR24;

            Row4[0] = new Space();
            Row4[1] = new Space();
            Row4[2] = new Space();
            Row4[3] = new Space();
            Row4[4] = new Space();
            Row4[5] = new Space();
            Row4[6] = S3;
            Row4[7] = NR19;
            Row4[8] = S4;

            Row5[0] = WHC;
            Row5[1] = NR3;
            Row5[2] = NR6;
            Row5[3] = NR9;
            Row5[4] = NR11;
            Row5[5] = NR14;
            Row5[6] = DT34;
            Row5[7] = new Space();
            Row5[8] = NR22;
            Row5[9] = NR25;
            Row5[10] = NR27;
            Row5[11] = NR29;
            Row5[12] = NR31;
            Row5[13] = NR33;
            Row5[14] = NR35;
            Row5[15] = PR1;
            Row5[16] = PR2;
            Row5[17] = PR3;
            Row5[18] = PR4;
            Row5[19] = PR5;
            Row5[20] = PR6;
            Row5[21] = PR7;
            Row5[22] = PR8;
        }

        public void DoSwitch(int R)
        {
            _Switches[R - 1].DoSwitch();
        }

        public bool MoveVehicles()
        {
            foreach(Vehicle v in _Vehicles)
            {
                if(!v.Move())
                {
                    return false;
                }
            }
            return true;
        }

        public void SpawnCart()
        {
            int RandomNumber = r.Next(3);
            _Vehicles.Add(_WareHouse[RandomNumber].SpawnMineCart());
        }

        public void SpawnShip()
        {
            int randomNumber = r.Next(9);
            if(randomNumber == 1)
            {
                _Channels[0].Vehicle = new Boat();
                _Channels[0].Vehicle.onTrack = _Channels[0];
                _Vehicles.Add(_Channels[0].Vehicle);
            }
        }
    }
}
