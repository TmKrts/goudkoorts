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

        private WareHouse[] _wareHouses;
        private BaseSwitch[] _switches;
        private BaseRail[] _shiproute;
        private List<Vehicle> _vehicles;

        public Map()
        {
            Row1 = new BaseRail[23];
            Row2 = new BaseRail[23];
            Row3 = new BaseRail[10];
            Row4 = new BaseRail[9];
            Row5 = new BaseRail[23];

            _wareHouses = new WareHouse[3];
            _switches = new BaseSwitch[5];
            _shiproute = new BaseRail[8];
            _vehicles = new List<Vehicle>();

            WareHouse WHA = new WareHouse();
            WareHouse WHB = new WareHouse();
            WareHouse WHC = new WareHouse();
            _wareHouses[0] = WHA;
            _wareHouses[1] = WHB;
            _wareHouses[2] = WHC;

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
            CP1.Next = CP2;
            BaseRail NR34 = new NormalRail();
            NR32.Next = NR34;
            BaseRail NR35 = new NormalRail();
            NR33.Next = NR35;

            // The first parkRails is there... column 15
            BaseRail CP3 = new Channel_Piece();
            CP2.Next = CP3;
            BaseRail NR36 = new NormalRail();
            NR34.Next = NR36;
            BaseRail PR1 = new ParkRail();
            NR35.Next = PR1;

            // column 16 the Quay and Dock
            Dock dock = new Dock();
            CP3.Next = dock;
            Quay quay = new Quay();
            quay.Dock = dock;
            NR36.Next = quay;
            BaseRail PR2 = new ParkRail();
            PR1.Next = PR2;

            // column 17 till 23 (the end of the ParkRails)
            BaseRail CP4 = new Channel_Piece();
            dock.Next = CP4;
            BaseRail NR37 = new NormalRail();
            quay.Next = NR37;
            BaseRail PR3 = new ParkRail();
            PR2.Next = PR3;

            BaseRail CP5 = new Channel_Piece();
            CP4.Next = CP5;
            BaseRail NR38 = new NormalRail();
            NR37.Next = NR38;
            BaseRail PR4 = new ParkRail();
            PR3.Next = PR4;

            BaseRail CP6 = new Channel_Piece();
            CP5.Next = CP6;
            BaseRail NR39 = new NormalRail();
            NR38.Next = NR39;
            BaseRail PR5 = new ParkRail();
            PR4.Next = PR5;

            BaseRail CP7 = new Channel_Piece();
            CP6.Next = CP7;
            BaseRail NR40 = new NormalRail();
            NR39.Next = NR40;
            BaseRail PR6 = new ParkRail();
            PR5.Next = PR6;

            BaseRail CP8 = new Channel_Piece();
            CP7.Next = CP8;
            BaseRail NR41 = new NormalRail();
            NR40.Next = NR41;
            BaseRail PR7 = new ParkRail();
            PR6.Next = PR7;

            BaseRail CP9 = new Channel_Piece();
            CP8.Next = CP9;
            BaseRail NR42 = new NormalRail();
            NR41.Next = NR42;
            BaseRail PR8 = new ParkRail();
            PR7.Next = PR8;

            //fill shipRoute
            _shiproute[0] = CP1;
            _shiproute[1] = CP2;
            _shiproute[2] = CP3;
            _shiproute[3] = dock;
            _shiproute[4] = CP4;
            _shiproute[5] = CP5;
            _shiproute[6] = CP6;
            _shiproute[7] = CP7;
            _shiproute[8] = CP8;

            // fill switch array
            _switches[0] = IS1;
            _switches[1] = OS1;
            _switches[2] = IS2;
            _switches[3] = OS2;
            _switches[4] = IS3;

            // fill rows
            Row1[0] = WHA;
            Row1[1] = NR1;
            Row1[2] = NR4;
            Row1[3] = NR7;
            Row1[4] = null;
            Row1[5] = NR12;
            Row1[6] = NR15;
            Row1[7] = NR18;
            Row1[8] = NR20;
            Row1[9] = NR23;
            Row1[10] = null;
            Row1[11] = null;
            Row1[12] = null;
            Row1[13] = CP1;
            Row1[14] = CP2;
            Row1[15] = CP3;
            Row1[16] = dock;
            Row1[17] = CP4;
            Row1[18] = CP5;
            Row1[19] = CP6;
            Row1[20] = CP7;
            Row1[21] = CP8;
            Row1[22] = CP9;

            Row2[0] = null;
            Row2[1] = null;
            Row2[2] = null;
            Row2[3] = IS1;
            Row2[4] = NR10;
            Row2[5] = OS1;
            Row2[6] = null;
            Row2[7] = null;
            Row2[8] = null;
            Row2[9] = IS3;
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
            Row3[4] = null;
            Row3[5] = NR13;
            Row3[6] = NR16;
            Row3[7] = null;
            Row3[8] = NR21;
            Row3[9] = NR24;

            Row4[0] = null;
            Row4[1] = null;
            Row4[2] = null;
            Row4[3] = null;
            Row4[4] = null;
            Row4[5] = null;
            Row4[6] = IS2;
            Row4[7] = NR19;
            Row4[8] = OS2;

            Row5[0] = WHC;
            Row5[1] = NR3;
            Row5[2] = NR5;
            Row5[3] = NR9;
            Row5[4] = NR11;
            Row5[5] = NR14;
            Row5[6] = NR17;
            Row5[7] = null;
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
    }
}
