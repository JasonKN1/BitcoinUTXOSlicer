using System;
using BitcoinUTXOSlicer;

namespace UTXOSlicerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ////I.从blk00000.dat启动
            //BitcoinUTXOSlicer_Class BitcoinUTXOSlicer = new BitcoinUTXOSlicer_Class(@"F:\data\blocks", @"F:Test\blockProcessContextFile", null,
            //                                                   @"F:Test\SliceStateFile", null, @"F:Test\opreturnOutputFile",
            //                                                   Configuration_Class.Month, 1, new DateTime(2009, 5, 3), 3500);

            ////II.恢复启动
            //BitcoinUTXOSlicer_Class BitcoinUTXOSlicer = new BitcoinUTXOSlicer_Class(@"F:\data\blocks", @"F:Test\blockProcessContextFile", "BPC_2755_2009年02月02日18时21分36秒.dat.rar",
            //                                                   @"F:Test\SliceStateFile", "UtxoSlice_2755_2009年02月02日18时21分36秒.dat.rar", @"F:Test\opreturnOutputFile",
            //                                                   Configuration_Class.Month, 1, new DateTime(2021, 2, 1), 681572);

            BitcoinUTXOSlicer.updateUTXO();
        }
    }
}
