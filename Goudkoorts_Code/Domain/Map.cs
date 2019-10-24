using System;
using System.Collections.Generic;
using System.Linq;
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
            _shiproute = new BaseRail[9];
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
            Channel_Piece CP1 = new Channel_Piece();
            BaseRail NR32 = new NormalRail();
            NR30.Next = NR32;
            BaseRail NR33 = new NormalRail();
            NR31.Next = NR33;

            Channel_Piece CP2 = new Channel_Piece();
            CP1.Next = CP2;
            BaseRail NR34 = new NormalRail();
            NR32.Next = NR34;
            BaseRail NR35 = new NormalRail();
            NR33.Next = NR35;

            // The first parkRails is there... column 15
            Channel_Piece CP3 = new Channel_Piece();
            CP2.Next = CP3;
            BaseRail NR36 = new NormalRail();
            NR34.Next = NR36;
            BaseRail PR1 = new ParkRail();
            NR35.Next = PR1;

            // column 16 the Quay and Dock
            Channel_Piece CP4 = new Channel_Piece();
            Dock dock = new Dock();
            Quay quay = new Quay();
            NR36.Next = quay;
            quay.Dock = CP4;
            CP3.Next = CP4;
            BaseRail PR2 = new ParkRail();
            PR1.Next = PR2;

            // column 17 till 23 (the end of the ParkRails)
            Channel_Piece CP5 = new Channel_Piece();
            CP4.Next = CP5;
            BaseRail NR37 = new NormalRail();
            quay.Next = NR37;
            BaseRail PR3 = new ParkRail();
            PR2.Next = PR3;

            Channel_Piece CP6 = new Channel_Piece();
            CP5.Next = CP6;
            BaseRail NR38 = new NormalRail();
            NR37.Next = NR38;
            BaseRail PR4 = new ParkRail();
            PR3.Next = PR4;

            Channel_Piece CP7 = new Channel_Piece();
            CP6.Next = CP7;
            BaseRail NR39 = new NormalRail();
            NR38.Next = NR39;
            BaseRail PR5 = new ParkRail();
            PR4.Next = PR5;

            Channel_Piece CP8 = new Channel_Piece();
            CP7.Next = CP8;
            BaseRail NR40 = new NormalRail();
            NR39.Next = NR40;
            BaseRail PR6 = new ParkRail();
            PR5.Next = PR6;

            Channel_Piece CP9 = new Channel_Piece();
            CP8.Next = CP9;
            BaseRail NR41 = new NormalRail();
            NR40.Next = NR41;
            BaseRail PR7 = new ParkRail();
            PR6.Next = PR7;

            Channel_Piece CP10 = new Channel_Piece();
            CP9.Next = CP10;
            BaseRail NR42 = new NormalRail();
            NR41.Next = NR42;
            BaseRail PR8 = new ParkRail();
            PR7.Next = PR8;

            //fill shipRoute
            _shiproute[0] = CP1;
            _shiproute[1] = CP2;
            _shiproute[2] = CP3;
            _shiproute[3] = CP4;
            _shiproute[4] = CP5;
            _shiproute[5] = CP6;
            _shiproute[6] = CP7;
            _shiproute[7] = CP8;
            _shiproute[8] = CP9;
            _shiproute[9] = CP10;

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

        /* the correct one
        private WareHouse[] spawnPoints;
        private BaseSwitch[] Switches;
        private List<Vehicle> Movables;
        private BaseRail[] ShipRoute;
        private Random r;

        public BaseRail[] Row1 { get; }
        public BaseRail[] Row2 { get; }
        public BaseRail[] Row3 { get; }
        public BaseRail[] Row4 { get; }
        public BaseRail[] Row5 { get; }

        public Map()
        {
            Switches = new BaseSwitch[5];
            spawnPoints = new WareHouse[3];
            Movables = new List<Vehicle>();
            ShipRoute = new BaseRail[8];
            r = new Random();

            Row1 = new BaseRail[23];
            Row2 = new BaseRail[23];
            Row3 = new BaseRail[10];
            Row4 = new BaseRail[9];
            Row5 = new BaseRail[23];

            WareHouse SP1 = new WareHouse();
            WareHouse SP2 = new WareHouse();
            WareHouse SP3 = new WareHouse();
            spawnPoints[0] = SP1;
            spawnPoints[1] = SP2;
            spawnPoints[2] = SP3;

            NormalRail DT1 = new NormalRail();
            SP1.Next = DT1;
            NormalRail DT2 = new NormalRail();
            SP2.Next = DT2;
            NormalRail DT3 = new NormalRail();
            SP3.Next = DT3;

            NormalRail DT4 = new NormalRail();
            DT1.Next = DT4;
            NormalRail DT5 = new NormalRail();
            DT2.Next = DT5;
            NormalRail DT6 = new NormalRail();
            DT3.Next = DT6;

            NormalRail DT7 = new NormalRail();
            DT4.Next = DT7;
            NormalRail DT8 = new NormalRail();
            DT5.Next = DT8;
            NormalRail DT9 = new NormalRail();
            DT6.Next = DT9;

            InSwitch S1 = new InSwitch(DT7, DT8);
            S1.Previous = DT8;
            DT8.Next = S1;

            NormalRail DT10 = new NormalRail();
            S1.Next = DT10;

            NormalRail DT11 = new NormalRail();
            NormalRail DT12 = new NormalRail();
            OutSwitch S2 = new OutSwitch(DT11, DT12);
            DT10.Next = S2;
            S2.Next = DT11;

            NormalRail DT13 = new NormalRail();
            DT11.Next = DT13;
            NormalRail DT14 = new NormalRail();
            DT12.Next = DT14;

            NormalRail DT15 = new NormalRail();
            DT13.Next = DT15;
            NormalRail DT16 = new NormalRail();
            DT15.Next = DT16;
            NormalRail DT17 = new NormalRail();
            DT16.Next = DT17;

            NormalRail DT32 = new NormalRail();
            DT9.Next = DT32;
            NormalRail DT33 = new NormalRail();
            DT32.Next = DT33;
            NormalRail DT34 = new NormalRail();
            DT33.Next = DT34;

            InSwitch S3 = new InSwitch(DT14, DT34);
            DT14.Next = S3;
            S3.Previous = DT14;
            NormalRail DT20 = new NormalRail();
            S3.Next = DT20;

            NormalRail DT18 = new NormalRail();
            NormalRail DT19 = new NormalRail();
            DT18.Next = DT19;

            NormalRail DT35 = new NormalRail();
            OutSwitch S4 = new OutSwitch(DT18, DT35);
            S4.Next = DT35;
            DT20.Next = S4;

            NormalRail DT36 = new NormalRail();
            DT35.Next = DT36;
            NormalRail DT37 = new NormalRail();
            DT36.Next = DT37;
            NormalRail DT38 = new NormalRail();
            DT37.Next = DT38;
            NormalRail DT39 = new NormalRail();
            DT38.Next = DT39;
            NormalRail DT40 = new NormalRail();
            DT39.Next = DT40;
            NormalRail DT41 = new NormalRail();
            DT40.Next = DT41;
            ParkRail SH1 = new ParkRail();
            DT41.Next = SH1;
            ParkRail SH2 = new ParkRail();
            SH1.Next = SH2;
            ParkRail SH3 = new ParkRail();
            SH2.Next = SH3;
            ParkRail SH4 = new ParkRail();
            SH3.Next = SH4;
            ParkRail SH5 = new ParkRail();
            SH4.Next = SH5;
            ParkRail SH6 = new ParkRail();
            SH5.Next = SH6;
            ParkRail SH7 = new ParkRail();
            SH6.Next = SH7;
            ParkRail SH8 = new ParkRail();
            SH7.Next = SH8;

            InSwitch S5 = new InSwitch(DT17, DT19);
            S5.Previous = DT17;
            DT17.Next = S5;

            NormalRail DT21 = new NormalRail();
            S5.Next = DT21;
            NormalRail DT22 = new NormalRail();
            DT21.Next = DT22;
            NormalRail DT23 = new NormalRail();
            DT22.Next = DT23;
            NormalRail DT24 = new NormalRail();
            DT23.Next = DT24;
            NormalRail DT25 = new NormalRail();
            DT24.Next = DT25;
            NormalRail DT26 = new NormalRail();
            DT25.Next = DT26;
            Quay H1 = new Quay();
            DT26.Next = H1;
            NormalRail DT27 = new NormalRail();
            H1.Next = DT27;
            NormalRail DT28 = new NormalRail();
            DT27.Next = DT28;
            NormalRail DT29 = new NormalRail();
            DT28.Next = DT29;
            NormalRail DT30 = new NormalRail();
            DT29.Next = DT30;
            NormalRail DT31 = new NormalRail();
            DT30.Next = DT31;
            NormalRail EI = new NormalRail();
            DT31.Next = EI;

            //make water tiles and add to list
            Channel_Piece W1 = new Channel_Piece();
            Channel_Piece W2 = new Channel_Piece();
            Dock W3 = new Dock();
            H1.Channel_Piece = W2;
            Channel_Piece W4 = new Channel_Piece();
            Channel_Piece W5 = new Channel_Piece();
            Channel_Piece W6 = new Channel_Piece();
            Channel_Piece W7 = new Channel_Piece();
            Channel_Piece W8 = new Channel_Piece();
            ShipRoute[0] = W1;
            ShipRoute[1] = W2;
            ShipRoute[2] = W3;
            ShipRoute[3] = W4;
            ShipRoute[4] = W5;
            ShipRoute[5] = W6;
            ShipRoute[6] = W7;
            ShipRoute[7] = W8;

            W1.Next = W2;
            W2.Next = W3;
            W3.Next = W4;
            W4.Next = W5;
            W5.Next = W6;
            W6.Next = W7;
            W7.Next = W8;

            //fill switches list
            Switches[0] = S1;
            Switches[1] = S2;
            Switches[2] = S3;
            Switches[3] = S4;
            Switches[4] = S5;

            //fill rows
            Row1[0] = SP1;
            Row1[1] = DT1;
            Row1[2] = DT4;
            Row1[3] = DT7;
            Row1[4] = null;
            Row1[5] = DT11;
            Row1[6] = DT13;
            Row1[7] = DT15;
            Row1[8] = DT16;
            Row1[9] = DT17;
            Row1[10] = null;
            Row1[11] = null;
            Row1[12] = null;
            Row1[13] = null;
            Row1[14] = null;
            Row1[15] = W1;
            Row1[16] = W2;
            Row1[17] = W3;
            Row1[18] = W4;
            Row1[19] = W5;
            Row1[20] = W6;
            Row1[21] = W7;
            Row1[22] = W8;

            Row2[0] = null;
            Row2[1] = null;
            Row2[2] = null;
            Row2[3] = S1;
            Row2[4] = DT10;
            Row2[5] = S2;
            Row2[6] = null;
            Row2[7] = null;
            Row2[8] = null;
            Row2[9] = S5;
            Row2[10] = DT21;
            Row2[11] = DT22;
            Row2[12] = DT23;
            Row2[13] = DT24;
            Row2[14] = DT25;
            Row2[15] = DT26;
            Row2[16] = H1;
            Row2[17] = DT27;
            Row2[18] = DT28;
            Row2[19] = DT29;
            Row2[20] = DT30;
            Row2[21] = DT31;
            Row2[22] = EI;

            Row3[0] = SP2;
            Row3[1] = DT2;
            Row3[2] = DT5;
            Row3[3] = DT8;
            Row3[4] = null;
            Row3[5] = DT12;
            Row3[6] = DT14;
            Row3[7] = null;
            Row3[8] = DT18;
            Row3[9] = DT19;

            Row4[0] = null;
            Row4[1] = null;
            Row4[2] = null;
            Row4[3] = null;
            Row4[4] = null;
            Row4[5] = null;
            Row4[6] = S3;
            Row4[7] = DT20;
            Row4[8] = S4;

            Row5[0] = SP3;
            Row5[1] = DT3;
            Row5[2] = DT6;
            Row5[3] = DT9;
            Row5[4] = DT32;
            Row5[5] = DT33;
            Row5[6] = DT34;
            Row5[7] = null;
            Row5[8] = DT35;
            Row5[9] = DT36;
            Row5[10] = DT37;
            Row5[11] = DT38;
            Row5[12] = DT39;
            Row5[13] = DT40;
            Row5[14] = DT41;
            Row5[15] = SH1;
            Row5[16] = SH2;
            Row5[17] = SH3;
            Row5[18] = SH4;
            Row5[19] = SH5;
            Row5[20] = SH6;
            Row5[21] = SH7;
            Row5[22] = SH8;
        }
        */
    }
}
