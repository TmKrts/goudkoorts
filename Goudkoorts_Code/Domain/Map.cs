using System;
using System.Collections.Generic;
using System.Text;

namespace Goudkoorts_Code.Domain
{
    class Map
    {
        public BaseRail[] Row1 { get; }
        public BaseRail[] Row2 { get; }
        public BaseRail[] Row3 { get; }
        public BaseRail[] Row4 { get; }
        public BaseRail[] Row5 { get; }

        private WareHouse[] wareHouses;
        private BaseSwitch[] switches;
        private BaseRail[] shiproute;
        private List<Vehicle> vehicles;

        public Map()
        {
            Row1 = new BaseRail[23];
            Row2 = new BaseRail[23];
            Row3 = new BaseRail[10];
            Row4 = new BaseRail[9];
            Row5 = new BaseRail[23];

            wareHouses = new WareHouse[3];
            switches = new BaseSwitch[5];
            shiproute = new BaseRail[8];
            vehicles = new List<Vehicle>();

            WareHouse WHA = new WareHouse();
            WareHouse WHB = new WareHouse();
            WareHouse WHC = new WareHouse();
            wareHouses[0] = WHA;
            wareHouses[1] = WHB;
            wareHouses[2] = WHC;

            // First three columns (to the first inner switch)
            BaseRail NR1 = new NormalRail();
            WHA.Next = NR1;
            BaseRail NR2 = new NormalRail();
            WHB.Next = NR2;
            BaseRail NR3 = new NormalRail();
            WHC.Next = NR3;

            BaseRail NR4 = new NormalRail();
            NR1.Next = NR4;
            BaseRail NR5 = new NormalRail();
            NR2.Next = NR5;
            BaseRail NR6 = new NormalRail();
            NR3.Next = NR6;

            BaseRail NR7 = new NormalRail();
            NR4.Next = NR7;
            BaseRail NR8 = new NormalRail();
            NR5.Next = NR8;
            BaseRail NR9 = new NormalRail();
            NR6.Next = NR9;

            InSwitch IS1 = new InSwitch(NR7, NR8);
            IS1.Previous = NR7;
            NR7.Next = IS1;

            // column 4
            BaseRail NR10 = new NormalRail();
            IS1.Next = NR10;
            BaseRail NR11 = new NormalRail();
            NR6.Next = NR11;

            // column 5
            BaseRail NR12 = new NormalRail();
            BaseRail NR13 = new NormalRail();
            OutSwitch OS1 = new OutSwitch(NR12, NR13);
            NR10.Next = OS1;
            OS1.Next = NR12;

            BaseRail NR14 = new NormalRail();
            NR11.Next = NR14;

            // column 6
            BaseRail NR15 = new NormalRail();
            NR12.Next = NR15;
            BaseRail NR16 = new NormalRail();
            NR13.Next = NR16;
            BaseRail NR17 = new NormalRail();
            NR14.Next = NR17;

            InSwitch IS2 = new InSwitch(NR16, NR17);
            IS2.Previous = NR16;
            NR16.Next = IS2;

            // column 7
            BaseRail NR18 = new NormalRail();
            NR15.Next = NR18;
            BaseRail NR19 = new NormalRail();
            IS2.Next = NR19;

            // column 8
            BaseRail NR20 = new NormalRail();
            NR18.Next = NR20;

            BaseRail NR21 = new NormalRail();
            BaseRail NR22 = new NormalRail();
            OutSwitch OS2 = new OutSwitch(NR21, NR22);
            NR19.Next = OS2;
            OS2.Next = NR21;

            // column 9
            BaseRail NR23 = new NormalRail();
            NR20.Next = NR23;
            BaseRail NR24 = new NormalRail();
            NR21.Next = NR24;
            InSwitch IS3 = new InSwitch(NR23, NR24);
            IS3.Previous = NR23;
            NR23.Next = IS3;

            BaseRail NR25 = new NormalRail();
            NR22.Next = NR25;

            // column 10 till 13
            BaseRail NR26 = new NormalRail();
            IS3.Next = NR26;
            BaseRail NR27 = new NormalRail();
            NR25.Next = NR27;

            BaseRail NR28 = new NormalRail();
            NR26.Next = NR28;
            BaseRail NR29 = new NormalRail();
            NR27.Next = NR29;

            BaseRail NR30 = new NormalRail();
            NR28.Next = NR30;
            BaseRail NR31 = new NormalRail();
            NR29.Next = NR31;


            // column 13 and 14 with the first channel_pieces
            BaseRail CP1 = new Channel_Piece();
            BaseRail NR32 = new NormalRail();
            NR30.Next = NR32;
            BaseRail NR33 = new NormalRail();
            NR31.Next = NR33;

            BaseRail CP2 = new Channel_Piece();
            BaseRail NR34 = new NormalRail();
            NR32.Next = NR34;
            BaseRail NR35 = new NormalRail();
            NR33.Next = NR35;

            // The first parkRails is there... column 15
            BaseRail CP3 = new Channel_Piece();
            BaseRail NR36 = new NormalRail();
            NR34.Next = NR36;
            BaseRail PR1 = new ParkRail();
            NR35.Next = PR1;

            // column 16 the Quay and Dock
            BaseRail dock = new Dock();

        }
    }
}
