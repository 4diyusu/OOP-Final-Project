namespace FinalProjectEnerio.Models
{
    public class ProductModel
    {
        public string product_name {  get; set; }
        public string product_brand {  get; set; }
        public int product_price { get; set; }
        public int product_id { get; set; }
        public int quantity { get; set; }

    }

    class Parts
    {
        // Processors
        private double newIntel7;
        private double newIntel5;
        private double newIntel3;
        private double newRyzen7;
        private double newRyzen5;

        // Graphics Cards
        private double newRtx4080S;
        private double newRtx4080;
        private double newRtx4070S;
        private double newRtx4070;
        private double newRtx4060Ti;

        // Memory
        private double newFury64;
        private double newFury16;
        private double newXpg32;
        private double newXpg64;

        // Motherboards
        private double newZ790;
        private double newB760;
        private double newX760;
        private double newB650;

        // Chassis
        private double newH7;
        private double newH6;
        private double newH5;

        // Storage
        private double newHdd8TB;
        private double newHdd4TB;
        private double newWd;
        private double newTg;
        private double newSamsung;
        private double newAdata;

        // Fans
        private double newF1203White;
        private double newF1203Black;
        private double newF120White;
        private double newF120Black;
        private double newSw4;
        private double newSw2;

        // Accessories
        private double newHdmiCable;
        private double newDpCable;
        private double newSneki;
        private double newCmpaste;
        private double newCmmount;
        private double newNbarm;
        private double newTGpaste;

        // Peripherals
        private double newBlackWidowV4;
        private double newBlackWidow75;
        private double newDeathStalkerV2;
        private double newDeathAdderV3;
        private double newViperV3;
        private double newBasiliskV3;
        private double newSeirenV3;
        private double newBasiliskV2;

        // Monitors
        private double newAorus32Inch;
        private double newAorus43Inch;
        private double newAorus49Inch;

        // Power Supply
        private double newGigabyte850W;
        private double newGigabyte750W;
        private double newGigabyte650W;


        public Parts() 
        {
            // Processors
            newIntel7 = 0.0;
            newIntel5 = 0.0;
            newIntel3 = 0.0;
            newRyzen7 = 0.0;
            newRyzen5 = 0.0;

            // Graphics Cards
            newRtx4080S = 0.0;
            newRtx4080 = 0.0;
            newRtx4070S = 0.0;
            newRtx4070 = 0.0;
            newRtx4060Ti = 0.0;

            // Memory
            newFury64 = 0.0;
            newFury16 = 0.0;
            newXpg32 = 0.0;
            newXpg64 = 0.0;

            // Motherboards
            newZ790 = 0.0;
            newB760 = 0.0;
            newX760 = 0.0;
            newB650 = 0.0;

            // Chassis
            newH7 = 0.0;
            newH6 = 0.0;
            newH5 = 0.0;

            // Storage
            newHdd8TB = 0.0;
            newHdd4TB = 0.0;
            newWd = 0.0;
            newTg = 0.0;
            newSamsung = 0.0;
            newAdata = 0.0;

            // Fans
            newF1203White = 0.0;
            newF1203Black = 0.0;
            newF120White = 0.0;
            newF120Black = 0.0;
            newSw4 = 0.0;
            newSw2 = 0.0;

            // Accessories
            newHdmiCable = 0.0;
            newDpCable = 0.0;
            newSneki = 0.0;
            newCmpaste = 0.0;
            newCmmount = 0.0;
            newNbarm = 0.0;
            newTGpaste = 0.0;

            // Peripherals
            newBlackWidowV4 = 0.0;
            newBlackWidow75 = 0.0;
            newDeathStalkerV2 = 0.0;
            newDeathAdderV3 = 0.0;
            newViperV3 = 0.0;
            newBasiliskV3 = 0.0;
            newSeirenV3 = 0.0;
            newBasiliskV2 = 0.0;

            // Monitors
            newAorus32Inch = 0.0;
            newAorus43Inch = 0.0;
            newAorus49Inch = 0.0;

            // Power Supply
            newGigabyte850W = 0.0;
            newGigabyte750W = 0.0;
            newGigabyte650W = 0.0;

        }
        public Parts(double intel7, double intel5, double intel3, double ryzen7, double ryzen5, double r4080s, double r4080, double r4070s, double r4070, double r4060ti,
                    double fury64, double fury16, double xpg32, double xpg64, double z790, double b760, double x760, double b650, double h7, double h6,
                    double h5, double hdd8, double hdd4, double wd, double tg, double samsung, double adata, double f1203W, double f1203B, double f120W,
                    double f120B, double sw4, double sw2, double hdmi, double dp, double sneki, double cmpaste, double cmmount, double nbarm, double tgpaste,
                    double bwv4, double bw75, double dsv2, double dav3, double vv3, double bv3, double sv3, double bsv2, double aorus32, double aorus43, double aorus49, 
                    double g850w, double g750w, double g650w)
        {
            // Processors
            newIntel7 = intel7;
            newIntel5 = intel5;
            newIntel3 = intel3;
            newRyzen7 = ryzen7;
            newRyzen5 = ryzen5;

            // Graphics Cards
            newRtx4080S = r4080s;
            newRtx4080 = r4080;
            newRtx4070S = r4070s;
            newRtx4070 = r4070;
            newRtx4060Ti = r4060ti;

            // Memory
            newFury64 = fury64;
            newFury16 = fury16;
            newXpg32 = xpg32;
            newXpg64 = xpg64;

            // Motherboards
            newZ790 = z790;
            newB760 = b760;
            newX760 = x760;
            newB650 = b650;

            // Chassis
            newH7 = h7;
            newH6 = h6;
            newH5 = h5;

            // Storage
            newHdd8TB = hdd8;
            newHdd4TB = hdd4;
            newWd = wd;
            newTg = tg;
            newSamsung = samsung;
            newAdata = adata;

            // Fans
            newF1203White = f1203W;
            newF1203Black = f1203B;
            newF120White = f120W;
            newF120Black = f120B;
            newSw4 = sw4;
            newSw2 = sw2;

            // Accessories
            newHdmiCable = hdmi;
            newDpCable = dp;
            newSneki = sneki;
            newCmpaste = cmpaste;
            newCmmount = cmmount;
            newNbarm = nbarm;
            newTGpaste = tgpaste;

            // Peripherals
            newBlackWidowV4 = bwv4;
            newBlackWidow75 = bw75;
            newDeathStalkerV2 = dsv2;
            newDeathAdderV3 = dav3;
            newViperV3 = vv3;
            newBasiliskV3 = bv3;
            newSeirenV3 = sv3;
            newBasiliskV2 = bsv2;

            // Monitors
            newAorus32Inch = aorus32;
            newAorus43Inch = aorus43;
            newAorus49Inch = aorus49;

            // Power Supply
            newGigabyte850W = g850w;
            newGigabyte750W = g750w;
            newGigabyte650W = g650w;
        }

        // Processors
        public double getIntel7() { return newIntel7; }
        public double getIntel5() { return newIntel5; }
        public double getIntel3() { return newIntel3; }
        public double getRyzen7() { return newRyzen7; }
        public double getRyzen5() { return newRyzen5; }

        // Graphics Cards
        public double getRtx4080S() { return newRtx4080S; }
        public double getRtx4080() { return newRtx4080; }
        public double getRtx4070S() { return newRtx4070S; }
        public double getRtx4070() { return newRtx4070; }
        public double getRtx4060Ti() { return newRtx4060Ti; }

        // Memory
        public double getFury64() { return newFury64; }
        public double getFury16() { return newFury16; }
        public double getXpg32() { return newXpg32; }
        public double getXpg64() { return newXpg64; }

        // Motherboards
        public double getZ790() { return newZ790; }
        public double getB760() { return newB760; }
        public double getX760() { return newX760; }
        public double getB650() { return newB650; }

        // Chassis
        public double getH7() { return newH7; }
        public double getH6() { return newH6; }
        public double getH5() { return newH5; }

        // Storage
        public double getHdd8TB() { return newHdd8TB; }
        public double getHdd4TB() { return newHdd4TB; }
        public double getWd() { return newWd; }
        public double getTg() { return newTg; }
        public double getSamsung() { return newSamsung; }
        public double getAdata() { return newAdata; }

        // Fans
        public double getF1203White() { return newF1203White; }
        public double getF1203Black() { return newF1203Black; }
        public double getF120White() { return newF120White; }
        public double getF120Black() { return newF120Black; }
        public double getSw4() { return newSw4; }
        public double getSw2() { return newSw2; }

        // Accessories
        public double getHdmiCable() { return newHdmiCable; }
        public double getDpCable() { return newDpCable; }
        public double getSneki() { return newSneki; }
        public double getCmpaste() { return newCmpaste; }
        public double getCmmount() { return newCmmount; }
        public double getNbarm() { return newNbarm; }
        public double getTGpaste() { return newTGpaste; }

        // Peripherals
        public double getBlackWidowV4() { return newBlackWidowV4; }
        public double getBlackWidow75() { return newBlackWidow75; }
        public double getDeathStalkerV2() { return newDeathStalkerV2; }
        public double getDeathAdderV3() { return newDeathAdderV3; }
        public double getViperV3() { return newViperV3; }
        public double getBasiliskV3() { return newBasiliskV3; }
        public double getSeirenV3() { return newSeirenV3; }
        public double getBasiliskV2() { return newBasiliskV2; }

        // Monitors
        public double getAorus32Inch() { return newAorus32Inch; }
        public double getAorus43Inch() { return newAorus43Inch; }
        public double getAorus49Inch() { return newAorus49Inch; }

        // Power Supply
        public double getGigabyte850W() { return newGigabyte850W; }
        public double getGigabyte750W() { return newGigabyte750W; }
        public double getGigabyte650W() { return newGigabyte650W; }



    }
}
