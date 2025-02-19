using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.IO;


namespace FinalProjectEnerio.Forms
{
    using FinalProjectEnerio.Models;

    public partial class CustomerMainWindow : Form
    {


        public CustomerMainWindow()
        {
            InitializeComponent();



        }

        private void toolStripMenuForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            AccountRecoveryWindow accountRecoveryWindow = new AccountRecoveryWindow();
            accountRecoveryWindow.ShowDialog();
            this.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.ShowDialog();
            this.Close();
        }

        private void contactPCGatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Inquiries please contact PC Gato." +
                            "\nEmail - PCGatoComputers@pcgato.com" +
                            "\nHotline - #297 6217" +
                            "\nPhone - +63 915 635 8479 // +63 976 127 2589" +
                            "\n" +
                            "\nThanks for your patronage!");

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            // Processors
            double intel7 = 25995;
            double intel5 = 19995;
            double intel3 = 7995;
            double ryzen7 = 26995;
            double ryzen5 = 18995;

            // Graphics Cards
            double rtx4080s = 57995;
            double rtx4080 = 45995;
            double rtx4070s = 37995;
            double rtx4070 = 32995;
            double rtx4060ti = 24995;

            // Memory
            double fury64 = 12995;
            double fury16 = 4495;
            double xpg64 = 13995;
            double xpg32 = 6495;

            // Motherboards
            double z790 = 45995;
            double b760 = 10995;
            double x760 = 20995;
            double b650 = 11995;

            // Chassis
            double h7 = 5995;
            double h6 = 7995;
            double h5 = 4795;

            // Storage
            double hdd8tb = 7995;
            double hdd4tb = 8395;
            double wd = 12995;
            double tg = 10595;
            double samsung = 11995;
            double adata = 11995;

            // Fans
            double f1203white = 3495;
            double f1203black = 3495;
            double f120white = 1495;
            double f120black = 1495;
            double sw4 = 1995;
            double sw2 = 1495;

            // Accessories
            double hdmiCable = 495;
            double dpCable = 795;
            double sneki = 1495;
            double cmpaste = 695;
            double cmmount = 2995;
            double nbarm = 1495;
            double tgpaste = 795;

            // Peripherals
            double blackWidowV4 = 8995;
            double blackWidow75 = 7995;
            double deathStalkerV2 = 9995;
            double deathAdderV3 = 6595;
            double viperV3 = 3495;
            double basiliskV3 = 8495;
            double seirenV3 = 1295;
            double basiliskV2 = 9995;

            // Monitors
            double aorus32Inch = 32995;
            double aorus43Inch = 51995;
            double aorus49Inch = 44995;

            // Power Supply
            double gigabyte850w = 6495;
            double gigabyte750w = 5495;
            double gigabyte650w = 3995;


            double tax;
            double taxAdded;
            tax = .012;

            // Processors
            double kIntel7 = Convert.ToDouble(numericUpDown1.Value);
            double kIntel5 = Convert.ToDouble(numericUpDown2.Value);
            double kIntel3 = Convert.ToDouble(numericUpDown3.Value);
            double kRyzen7 = Convert.ToDouble(numericUpDown4.Value);
            double kRyzen5 = Convert.ToDouble(numericUpDown5.Value);

            // Graphics Cards
            double kRtx4080S = Convert.ToDouble(numericUpDown10.Value);
            double kRtx4080 = Convert.ToDouble(numericUpDown9.Value);
            double kRtx4070S = Convert.ToDouble(numericUpDown8.Value);
            double kRtx4070 = Convert.ToDouble(numericUpDown7.Value);
            double kRtx4060Ti = Convert.ToDouble(numericUpDown6.Value);

            // Memory
            double kFury64 = Convert.ToDouble(numericUpDown15.Value);
            double kFury16 = Convert.ToDouble(numericUpDown14.Value);
            double kXpg64 = Convert.ToDouble(numericUpDown13.Value);
            double kXpg32 = Convert.ToDouble(numericUpDown12.Value);

            // Motherboards
            double kZ790 = Convert.ToDouble(numericUpDown18.Value);
            double kB760 = Convert.ToDouble(numericUpDown17.Value);
            double kX760 = Convert.ToDouble(numericUpDown16.Value);
            double kB650 = Convert.ToDouble(numericUpDown11.Value);

            // Chassis
            double kH7 = Convert.ToDouble(numericUpDown22.Value);
            double kH6 = Convert.ToDouble(numericUpDown21.Value);
            double kH5 = Convert.ToDouble(numericUpDown20.Value);

            // Storage
            double kHdd8TB = Convert.ToDouble(numericUpDown25.Value);
            double kHdd4TB = Convert.ToDouble(numericUpDown24.Value);
            double kWd = Convert.ToDouble(numericUpDown23.Value);
            double kTg = Convert.ToDouble(numericUpDown19.Value);
            double kSamsung = Convert.ToDouble(numericUpDown26.Value);
            double kAdata = Convert.ToDouble(numericUpDown27.Value);

            // Fans
            double kF1203White = Convert.ToDouble(numericUpDown32.Value);
            double kF1203Black = Convert.ToDouble(numericUpDown31.Value);
            double kF120White = Convert.ToDouble(numericUpDown30.Value);
            double kF120Black = Convert.ToDouble(numericUpDown29.Value);
            double kSw4 = Convert.ToDouble(numericUpDown28.Value);
            double kSw2 = Convert.ToDouble(numericUpDown33.Value);

            // Accessories
            double kHdmiCable = Convert.ToDouble(numericUpDown34.Value);
            double kDpCable = Convert.ToDouble(numericUpDown35.Value);
            double kSneki = Convert.ToDouble(numericUpDown36.Value);
            double kCmpaste = Convert.ToDouble(numericUpDown37.Value);
            double kCmmount = Convert.ToDouble(numericUpDown38.Value);
            double kNbarm = Convert.ToDouble(numericUpDown39.Value);
            double kTGpaste = Convert.ToDouble(numericUpDown40.Value);

            // Peripherals
            double kBlackWidowV4 = Convert.ToDouble(numericUpDown47.Value);
            double kBlackWidow75 = Convert.ToDouble(numericUpDown46.Value);
            double kDeathStalkerV2 = Convert.ToDouble(numericUpDown45.Value);
            double kDeathAdderV3 = Convert.ToDouble(numericUpDown44.Value);
            double kViperV3 = Convert.ToDouble(numericUpDown43.Value);
            double kBasiliskV3 = Convert.ToDouble(numericUpDown42.Value);
            double kSeirenV3 = Convert.ToDouble(numericUpDown41.Value);
            double kBasiliskV2 = Convert.ToDouble(numericUpDown48.Value);

            // Monitors
            double kAorus32Inch = Convert.ToDouble(numericUpDown51.Value);
            double kAorus43Inch = Convert.ToDouble(numericUpDown50.Value);
            double kAorus49Inch = Convert.ToDouble(numericUpDown49.Value);

            // Power Supply
            double kGigabyte850W = Convert.ToDouble(numericUpDown54.Value);
            double kGigabyte750W = Convert.ToDouble(numericUpDown53.Value);
            double kGigabyte650W = Convert.ToDouble(numericUpDown52.Value);

            Parts buy = new Parts(kIntel7, kIntel5, kIntel3, kRyzen7, kRyzen5, kRtx4080S, kRtx4080, kRtx4070S, kRtx4070, kRtx4060Ti,
                                  kFury64, kFury16, kXpg64, kXpg32, kZ790, kB760, kX760, kB650, kH7, kH6, kH5, kHdd8TB, kHdd4TB, kWd,
                                  kTg, kSamsung, kAdata, kF1203White, kF1203Black, kF120White, kF120Black, kSw4, kSw2, kHdmiCable, kDpCable,
                                  kSneki, kCmpaste, kCmmount, kNbarm, kTGpaste, kBlackWidowV4, kBlackWidow75, kDeathStalkerV2, kDeathAdderV3,
                                  kViperV3, kBasiliskV3, kSeirenV3, kBasiliskV2, kAorus32Inch, kAorus43Inch, kAorus49Inch, kGigabyte850W, kGigabyte750W, kGigabyte650W);
            double sub_total = (intel7 * kIntel7) + (intel5 * kIntel5) + (intel3 * kIntel3) + (ryzen7 * kRyzen7) + (ryzen5 * kRyzen5) + (rtx4080s * kRtx4080S) + (rtx4080 * kRtx4080) +
                               (rtx4070s * kRtx4070S) + (rtx4070 * kRtx4070) + (rtx4060ti * kRtx4060Ti) + (fury64 * kFury64) + (fury16 * kFury16) + (xpg64 * kXpg64) + (xpg32 * kXpg32) +
                               (z790 * kZ790) + (b760 * kB760) + (x760 * kX760) + (b650 * kB650) + (h7 * kH7) + (h6 * kH6) + (h5 * kH5) + (hdd8tb * kHdd8TB) + (hdd4tb * kHdd4TB) +
                               (wd * kWd) + (tg * kTg) + (samsung * kSamsung) + (adata * kAdata) + (f1203white * kF1203White) + (f1203black * kF1203Black) + (f120white * kF120White) +
                               (f120black * kF120Black) + (sw4 * kSw4) + (sw2 * kSw2) + (hdmiCable * kHdmiCable) + (dpCable * kDpCable) + (sneki * kSneki) + (cmpaste * kCmpaste) +
                               (cmmount * kCmmount) + (nbarm * kNbarm) + (tgpaste * kTGpaste) + (blackWidowV4 * kBlackWidowV4) + (blackWidow75 * kBlackWidow75) + (deathStalkerV2 * kDeathStalkerV2) +
                               (deathAdderV3 * kDeathAdderV3) + (viperV3 * kViperV3) + (basiliskV3 * kBasiliskV3) + (seirenV3 * kSeirenV3) + (basiliskV2 * kBasiliskV2) + (aorus32Inch * kAorus32Inch) +
                               (aorus43Inch * kAorus43Inch) + (aorus49Inch * kAorus49Inch) + (gigabyte850w * kGigabyte850W) + (gigabyte750w * kGigabyte750W) + (gigabyte650w * kGigabyte650W);
            lblSubTotale.Text = Convert.ToString(sub_total);
            taxAdded = sub_total * tax;
            lblTotalPriceE.Text = Convert.ToString(sub_total + taxAdded);

            rtxtBxCart.Clear();


            rtxtBxCart.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            rtxtBxCart.AppendText("\t" + "     PC Gato - Computer Parts Store" + Environment.NewLine);
            rtxtBxCart.AppendText("-----------------------------------------------------------" + Environment.NewLine);

            // Processors
            if (numericUpDown1.Value > 0)
                rtxtBxCart.AppendText("Intel Core i7 \t\t\t" + numericUpDown1.Value + " - Php" + intel7 + Environment.NewLine);
            if (numericUpDown2.Value > 0)
                rtxtBxCart.AppendText("Intel Core i5 \t\t\t" + numericUpDown2.Value + " - Php" + intel5 + Environment.NewLine);
            if (numericUpDown3.Value > 0)
                rtxtBxCart.AppendText("Intel Core i3 \t\t\t" + numericUpDown3.Value + " - Php" + intel3 + Environment.NewLine);
            if (numericUpDown4.Value > 0)
                rtxtBxCart.AppendText("AMD Ryzen 7 \t\t\t" + numericUpDown4.Value + " - Php" + ryzen7 + Environment.NewLine);
            if (numericUpDown5.Value > 0)
                rtxtBxCart.AppendText("AMD Ryzen 5 \t\t\t" + numericUpDown5.Value + " - Php" + ryzen5 + Environment.NewLine);

            // Graphics Cards
            if (numericUpDown10.Value > 0)
                rtxtBxCart.AppendText("RTX 4080 Super \t\t\t" + numericUpDown10.Value + " - Php" + rtx4080s + Environment.NewLine);
            if (numericUpDown9.Value > 0)
                rtxtBxCart.AppendText("RTX 4080 \t\t\t" + numericUpDown9.Value + " - Php" + rtx4080 + Environment.NewLine);
            if (numericUpDown8.Value > 0)
                rtxtBxCart.AppendText("RTX 4070 Super \t\t\t" + numericUpDown8.Value + " - Php" + rtx4070s + Environment.NewLine);
            if (numericUpDown7.Value > 0)
                rtxtBxCart.AppendText("RTX 4070 \t\t\t" + numericUpDown7.Value + " - Php" + rtx4070 + Environment.NewLine);
            if (numericUpDown6.Value > 0)
                rtxtBxCart.AppendText("RTX 4060 Ti \t\t\t" + numericUpDown6.Value + " - Php" + rtx4060ti + Environment.NewLine);

            // Memory
            if (numericUpDown15.Value > 0)
                rtxtBxCart.AppendText("Fury 64GB \t\t\t" + numericUpDown15.Value + " - Php" + fury64 + Environment.NewLine);
            if (numericUpDown14.Value > 0)
                rtxtBxCart.AppendText("Fury 16GB \t\t\t" + numericUpDown14.Value + " - Php" + fury16 + Environment.NewLine);
            if (numericUpDown13.Value > 0)
                rtxtBxCart.AppendText("XPG 32GB \t\t\t" + numericUpDown13.Value + " - Php" + xpg32 + Environment.NewLine);
            if (numericUpDown12.Value > 0)
                rtxtBxCart.AppendText("XPG 64GB \t\t\t" + numericUpDown12.Value + " - Php" + xpg64 + Environment.NewLine);

            // Motherboards
            if (numericUpDown18.Value > 0)
                rtxtBxCart.AppendText("Z790 Motherboard \t\t" + numericUpDown18.Value + " - Php" + z790 + Environment.NewLine);
            if (numericUpDown17.Value > 0)
                rtxtBxCart.AppendText("B760 Motherboard \t\t" + numericUpDown17.Value + " - Php" + b760 + Environment.NewLine);
            if (numericUpDown16.Value > 0)
                rtxtBxCart.AppendText("X760 Motherboard \t\t" + numericUpDown16.Value + " - Php" + x760 + Environment.NewLine);
            if (numericUpDown11.Value > 0)
                rtxtBxCart.AppendText("B650 Motherboard \t\t" + numericUpDown11.Value + " - Php" + b650 + Environment.NewLine);

            // Chassis
            if (numericUpDown22.Value > 0)
                rtxtBxCart.AppendText("H7 Chassis \t\t\t" + numericUpDown22.Value + " - Php" + h7 + Environment.NewLine);
            if (numericUpDown21.Value > 0)
                rtxtBxCart.AppendText("H6 Chassis \t\t\t" + numericUpDown21.Value + " - Php" + h6 + Environment.NewLine);
            if (numericUpDown20.Value > 0)
                rtxtBxCart.AppendText("H5 Chassis \t\t\t" + numericUpDown20.Value + " - Php" + h5 + Environment.NewLine);

            // Storage
            if (numericUpDown25.Value > 0)
                rtxtBxCart.AppendText("HDD 8TB \t\t\t" + numericUpDown25.Value + " - Php" + hdd8tb + Environment.NewLine);
            if (numericUpDown24.Value > 0)
                rtxtBxCart.AppendText("HDD 4TB \t\t\t" + numericUpDown24.Value + " - Php" + hdd4tb + Environment.NewLine);
            if (numericUpDown23.Value > 0)
                rtxtBxCart.AppendText("WD SSD \t\t\t\t" + numericUpDown23.Value + " - Php" + wd + Environment.NewLine);
            if (numericUpDown19.Value > 0)
                rtxtBxCart.AppendText("TG SSD \t\t\t\t" + numericUpDown19.Value + " - Php" + tg + Environment.NewLine);
            if (numericUpDown26.Value > 0)
                rtxtBxCart.AppendText("Samsung SSD \t\t\t" + numericUpDown26.Value + " - Php" + samsung + Environment.NewLine);
            if (numericUpDown27.Value > 0)
                rtxtBxCart.AppendText("Adata SSD \t\t\t" + numericUpDown27.Value + " - Php" + adata + Environment.NewLine);

            // Fans
            if (numericUpDown32.Value > 0)
                rtxtBxCart.AppendText("F1203 White Fan \t\t\t" + numericUpDown32.Value + " - Php" + f1203white + Environment.NewLine);
            if (numericUpDown31.Value > 0)
                rtxtBxCart.AppendText("F1203 Black Fan \t\t\t" + numericUpDown31.Value + " - Php" + f1203black + Environment.NewLine);
            if (numericUpDown30.Value > 0)
                rtxtBxCart.AppendText("F120 White Fan \t\t\t" + numericUpDown30.Value + " - Php" + f120white + Environment.NewLine);
            if (numericUpDown29.Value > 0)
                rtxtBxCart.AppendText("F120 Black Fan \t\t\t" + numericUpDown29.Value + " - Php" + f120black + Environment.NewLine);
            if (numericUpDown28.Value > 0)
                rtxtBxCart.AppendText("SW4 Fan \t\t\t" + numericUpDown28.Value + " - Php" + sw4 + Environment.NewLine);
            if (numericUpDown33.Value > 0)
                rtxtBxCart.AppendText("SW2 Fan \t\t\t" + numericUpDown33.Value + " - Php" + sw2 + Environment.NewLine);

            //Accesories
            if (numericUpDown39.Value > 0)
                rtxtBxCart.AppendText("HDMI Cable \t\t\t" + numericUpDown39.Value + " - Php" + hdmiCable + Environment.NewLine);
            if (numericUpDown38.Value > 0)
                rtxtBxCart.AppendText("Display Port Cable 75 \t\t\t" + numericUpDown38.Value + " - Php" + dpCable + Environment.NewLine);
            if (numericUpDown37.Value > 0)
                rtxtBxCart.AppendText("Razer Sneki \t\t" + numericUpDown37.Value + " - Php" + sneki + Environment.NewLine);
            if (numericUpDown36.Value > 0)
                rtxtBxCart.AppendText("Cooler Master Mastergel \t\t" + numericUpDown36.Value + " - Php" + cmpaste + Environment.NewLine);
            if (numericUpDown35.Value > 0)
                rtxtBxCart.AppendText("Thermal Grizzly Paste \t\t\t" + numericUpDown35.Value + " - Php" + tgpaste + Environment.NewLine);
            if (numericUpDown34.Value > 0)
                rtxtBxCart.AppendText("North Bayou Arm \t\t\t" + numericUpDown34.Value + " - Php" + nbarm + Environment.NewLine);
            if (numericUpDown40.Value > 0)
                rtxtBxCart.AppendText("Cooler Master Mount \t\t\t" + numericUpDown34.Value + " - Php" + cmmount + Environment.NewLine);

            // Peripherals
            if (numericUpDown47.Value > 0)
                rtxtBxCart.AppendText("BlackWidow V4 \t\t\t" + numericUpDown47.Value + " - Php" + blackWidowV4 + Environment.NewLine);
            if (numericUpDown46.Value > 0)
                rtxtBxCart.AppendText("BlackWidow 75 \t\t\t" + numericUpDown46.Value + " - Php" + blackWidow75 + Environment.NewLine);
            if (numericUpDown45.Value > 0)
                rtxtBxCart.AppendText("DeathStalker V2 \t\t" + numericUpDown45.Value + " - Php" + deathStalkerV2 + Environment.NewLine);
            if (numericUpDown44.Value > 0)
                rtxtBxCart.AppendText("DeathAdder V3 \t\t\t" + numericUpDown44.Value + " - Php" + deathAdderV3 + Environment.NewLine);
            if (numericUpDown43.Value > 0)
                rtxtBxCart.AppendText("Viper V3 \t\t\t" + numericUpDown43.Value + " - Php" + viperV3 + Environment.NewLine);
            if (numericUpDown42.Value > 0)
                rtxtBxCart.AppendText("Basilisk V3 \t\t\t" + numericUpDown42.Value + " - Php" + basiliskV3 + Environment.NewLine);
            if (numericUpDown41.Value > 0)
                rtxtBxCart.AppendText("Seiren V3 \t\t\t" + numericUpDown41.Value + " - Php" + seirenV3 + Environment.NewLine);
            if (numericUpDown48.Value > 0)
                rtxtBxCart.AppendText("Basilisk V2 \t\t\t" + numericUpDown48.Value + " - Php" + basiliskV2 + Environment.NewLine);

            // Monitors
            if (numericUpDown51.Value > 0)
                rtxtBxCart.AppendText("Aorus 32-Inch Monitor \t\t" + numericUpDown51.Value + " - Php" + aorus32Inch + Environment.NewLine);
            if (numericUpDown50.Value > 0)
                rtxtBxCart.AppendText("Aorus 43-Inch Monitor \t\t" + numericUpDown50.Value + " - Php" + aorus43Inch + Environment.NewLine);
            if (numericUpDown49.Value > 0)
                rtxtBxCart.AppendText("Aorus 49-Inch Monitor \t\t" + numericUpDown49.Value + " - Php" + aorus49Inch + Environment.NewLine);

            // Power Supply
            if (numericUpDown54.Value > 0)
                rtxtBxCart.AppendText("Gigabyte 850W PSU \t\t" + numericUpDown54.Value + " - Php" + gigabyte850w + Environment.NewLine);
            if (numericUpDown53.Value > 0)
                rtxtBxCart.AppendText("Gigabyte 750W PSU \t\t" + numericUpDown53.Value + " - Php" + gigabyte750w + Environment.NewLine);
            if (numericUpDown52.Value > 0)
                rtxtBxCart.AppendText("Gigabyte 650W PSU \t\t" + numericUpDown52.Value + " - Php" + gigabyte650w + Environment.NewLine);


            rtxtBxCart.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            rtxtBxCart.AppendText("Tax \t\t\t\t" + "1.2%" + Environment.NewLine);
            rtxtBxCart.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            rtxtBxCart.AppendText("Sub Total \t\t\t" + "Php" + lblSubTotale.Text + Environment.NewLine);
            rtxtBxCart.AppendText("Total Cost \t\t\t" + "Php" + lblTotalPriceE.Text + Environment.NewLine);
            rtxtBxCart.AppendText("-----------------------------------------------------------" + Environment.NewLine);
            rtxtBxCart.AppendText(lblTime.Text + "\t" + lblDate.Text);

            SaveReceiptFile();
        }

        public void SaveReceiptFile()
        {
            try
            {
                string fileName = $"receipt_{DateTime.Now.ToString("yyyyMMdd_HHmmss")}.txt";
                string filePath = Path.Combine(@"S:\Visual Studio Projects\FinalProjectEnerio\Receipts", fileName);

                // Processors
                double intel7 = 25995;
                double intel5 = 19995;
                double intel3 = 7995;
                double ryzen7 = 26995;
                double ryzen5 = 18995;

                // Graphics Cards
                double rtx4080s = 57995;
                double rtx4080 = 45995;
                double rtx4070s = 37995;
                double rtx4070 = 32995;
                double rtx4060ti = 24995;

                // Memory
                double fury64 = 12995;
                double fury16 = 4495;
                double xpg64 = 13995;
                double xpg32 = 6495;

                // Motherboards
                double z790 = 45995;
                double b760 = 10995;
                double x760 = 20995;
                double b650 = 11995;

                // Chassis
                double h7 = 5995;
                double h6 = 7995;
                double h5 = 4795;

                // Storage
                double hdd8tb = 7995;
                double hdd4tb = 8395;
                double wd = 12995;
                double tg = 10595;
                double samsung = 11995;
                double adata = 11995;

                // Fans
                double f1203white = 3495;
                double f1203black = 3495;
                double f120white = 1495;
                double f120black = 1495;
                double sw4 = 1995;
                double sw2 = 1495;

                // Accessories
                double hdmiCable = 495;
                double dpCable = 795;
                double sneki = 1495;
                double cmpaste = 695;
                double cmmount = 2995;
                double nbarm = 1495;
                double tgpaste = 795;

                // Peripherals
                double blackWidowV4 = 8995;
                double blackWidow75 = 7995;
                double deathStalkerV2 = 9995;
                double deathAdderV3 = 6595;
                double viperV3 = 3495;
                double basiliskV3 = 8495;
                double seirenV3 = 1295;
                double basiliskV2 = 9995;

                // Monitors
                double aorus32Inch = 32995;
                double aorus43Inch = 51995;
                double aorus49Inch = 44995;

                // Power Supply
                double gigabyte850w = 6495;
                double gigabyte750w = 5495;
                double gigabyte650w = 3995;

                using (StreamWriter writer = new StreamWriter(filePath))
                {

                    writer.WriteLine("-----------------------------------------------------------");
                    writer.WriteLine("\t" + "     PC Gato - Computer Parts Store");
                    writer.WriteLine("-----------------------------------------------------------");

                    // Processors
                    if (numericUpDown1.Value > 0)
                        writer.WriteLine("Intel Core i7 \t\t\t" + numericUpDown1.Value + " - Php" + intel7);
                    if (numericUpDown2.Value > 0)
                        writer.WriteLine("Intel Core i5 \t\t\t" + numericUpDown2.Value + " - Php" + intel5);
                    if (numericUpDown3.Value > 0)
                        writer.WriteLine("Intel Core i3 \t\t\t" + numericUpDown3.Value + " - Php" + intel3);
                    if (numericUpDown4.Value > 0)
                        writer.WriteLine("AMD Ryzen 7 \t\t\t" + numericUpDown4.Value + " - Php" + ryzen7);
                    if (numericUpDown5.Value > 0)
                        writer.WriteLine("AMD Ryzen 5 \t\t\t" + numericUpDown5.Value + " - Php" + ryzen5);

                    // Graphics Cards
                    if (numericUpDown10.Value > 0)
                        writer.WriteLine("RTX 4080 Super \t\t\t" + numericUpDown10.Value + " - Php" + rtx4080s);
                    if (numericUpDown9.Value > 0)
                        writer.WriteLine("RTX 4080 \t\t\t" + numericUpDown9.Value + " - Php" + rtx4080);
                    if (numericUpDown8.Value > 0)
                        writer.WriteLine("RTX 4070 Super \t\t\t" + numericUpDown8.Value + " - Php" + rtx4070s);
                    if (numericUpDown7.Value > 0)
                        writer.WriteLine("RTX 4070 \t\t\t" + numericUpDown7.Value + " - Php" + rtx4070);
                    if (numericUpDown6.Value > 0)
                        writer.WriteLine("RTX 4060 Ti \t\t\t" + numericUpDown6.Value + " - Php" + rtx4060ti);

                    // Memory
                    if (numericUpDown15.Value > 0)
                        writer.WriteLine("Fury 64GB \t\t\t" + numericUpDown15.Value + " - Php" + fury64);
                    if (numericUpDown14.Value > 0)
                        writer.WriteLine("Fury 16GB \t\t\t" + numericUpDown14.Value + " - Php" + fury16);
                    if (numericUpDown13.Value > 0)
                        writer.WriteLine("XPG 32GB \t\t\t" + numericUpDown13.Value + " - Php" + xpg32);
                    if (numericUpDown12.Value > 0)
                        writer.WriteLine("XPG 64GB \t\t\t" + numericUpDown12.Value + " - Php" + xpg64);

                    // Motherboards
                    if (numericUpDown18.Value > 0)
                        writer.WriteLine("Z790 Motherboard \t\t" + numericUpDown18.Value + " - Php" + z790);
                    if (numericUpDown17.Value > 0)
                        writer.WriteLine("B760 Motherboard \t\t" + numericUpDown17.Value + " - Php" + b760);
                    if (numericUpDown16.Value > 0)
                        writer.WriteLine("X760 Motherboard \t\t" + numericUpDown16.Value + " - Php" + x760);
                    if (numericUpDown11.Value > 0)
                        writer.WriteLine("B650 Motherboard \t\t" + numericUpDown11.Value + " - Php" + b650);

                    // Chassis
                    if (numericUpDown22.Value > 0)
                        writer.WriteLine("H7 Chassis \t\t\t" + numericUpDown22.Value + " - Php" + h7);
                    if (numericUpDown21.Value > 0)
                        writer.WriteLine("H6 Chassis \t\t\t" + numericUpDown21.Value + " - Php" + h6);
                    if (numericUpDown20.Value > 0)
                        writer.WriteLine("H5 Chassis \t\t\t" + numericUpDown20.Value + " - Php" + h5);

                    // Storage
                    if (numericUpDown25.Value > 0)
                        writer.WriteLine("HDD 8TB \t\t\t" + numericUpDown25.Value + " - Php" + hdd8tb);
                    if (numericUpDown24.Value > 0)
                        writer.WriteLine("HDD 4TB \t\t\t" + numericUpDown24.Value + " - Php" + hdd4tb);
                    if (numericUpDown23.Value > 0)
                        writer.WriteLine("WD SSD \t\t\t\t" + numericUpDown23.Value + " - Php" + wd);
                    if (numericUpDown19.Value > 0)
                        writer.WriteLine("TG SSD \t\t\t\t" + numericUpDown19.Value + " - Php" + tg);
                    if (numericUpDown26.Value > 0)
                        writer.WriteLine("Samsung SSD \t\t\t" + numericUpDown26.Value + " - Php" + samsung);
                    if (numericUpDown27.Value > 0)
                        writer.WriteLine("Adata SSD \t\t\t" + numericUpDown27.Value + " - Php" + adata);

                    // Fans
                    if (numericUpDown32.Value > 0)
                        writer.WriteLine("F1203 White Fan \t\t\t" + numericUpDown32.Value + " - Php" + f1203white);
                    if (numericUpDown31.Value > 0)
                        writer.WriteLine("F1203 Black Fan \t\t\t" + numericUpDown31.Value + " - Php" + f1203black);
                    if (numericUpDown30.Value > 0)
                        writer.WriteLine("F120 White Fan \t\t\t" + numericUpDown30.Value + " - Php" + f120white);
                    if (numericUpDown29.Value > 0)
                        writer.WriteLine("F120 Black Fan \t\t\t" + numericUpDown29.Value + " - Php" + f120black);
                    if (numericUpDown28.Value > 0)
                        writer.WriteLine("SW4 Fan \t\t\t" + numericUpDown28.Value + " - Php" + sw4);
                    if (numericUpDown33.Value > 0)
                        writer.WriteLine("SW2 Fan \t\t\t" + numericUpDown33.Value + " - Php" + sw2);

                    //Accessories
                    if (numericUpDown39.Value > 0)
                        writer.WriteLine("HDMI Cable \t\t\t" + numericUpDown39.Value + " - Php" + hdmiCable);
                    if (numericUpDown38.Value > 0)
                        writer.WriteLine("Display Port Cable 75 \t\t\t" + numericUpDown38.Value + " - Php" + dpCable);
                    if (numericUpDown37.Value > 0)
                        writer.WriteLine("Razer Sneki \t\t" + numericUpDown37.Value + " - Php" + sneki);
                    if (numericUpDown36.Value > 0)
                        writer.WriteLine("Cooler Master Mastergel \t\t" + numericUpDown36.Value + " - Php" + cmpaste);
                    if (numericUpDown35.Value > 0)
                        writer.WriteLine("Thermal Grizzly Paste \t\t\t" + numericUpDown35.Value + " - Php" + tgpaste);
                    if (numericUpDown34.Value > 0)
                        writer.WriteLine("North Bayou Arm \t\t\t" + numericUpDown34.Value + " - Php" + nbarm);
                    if (numericUpDown40.Value > 0)
                        writer.WriteLine("Cooler Master Mount \t\t\t" + numericUpDown34.Value + " - Php" + cmmount);

                    // Peripherals
                    if (numericUpDown41.Value > 0)
                        writer.WriteLine("BlackWidow V4 \t\t\t" + numericUpDown41.Value + " - Php" + blackWidowV4);
                    if (numericUpDown40.Value > 0)
                        writer.WriteLine("BlackWidow 75 \t\t\t" + numericUpDown40.Value + " - Php" + blackWidow75);
                    if (numericUpDown39.Value > 0)
                        writer.WriteLine("DeathStalker V2 \t\t" + numericUpDown39.Value + " - Php" + deathStalkerV2);
                    if (numericUpDown38.Value > 0)
                        writer.WriteLine("DeathAdder V3 \t\t\t" + numericUpDown38.Value + " - Php" + deathAdderV3);
                    if (numericUpDown37.Value > 0)
                        writer.WriteLine("Viper V3 \t\t\t" + numericUpDown37.Value + " - Php" + viperV3);
                    if (numericUpDown36.Value > 0)
                        writer.WriteLine("Basilisk V3 \t\t\t" + numericUpDown36.Value + " - Php" + basiliskV3);
                    if (numericUpDown35.Value > 0)
                        writer.WriteLine("Seiren V3 \t\t\t" + numericUpDown35.Value + " - Php" + seirenV3);
                    if (numericUpDown34.Value > 0)
                        writer.WriteLine("Basilisk V2 \t\t\t" + numericUpDown34.Value + " - Php" + basiliskV2);

                    // Monitors
                    if (numericUpDown42.Value > 0)
                        writer.WriteLine("Aorus 32-Inch Monitor \t\t" + numericUpDown42.Value + " - Php" + aorus32Inch);
                    if (numericUpDown43.Value > 0)
                        writer.WriteLine("Aorus 43-Inch Monitor \t\t" + numericUpDown43.Value + " - Php" + aorus43Inch);
                    if (numericUpDown44.Value > 0)
                        writer.WriteLine("Aorus 49-Inch Monitor \t\t" + numericUpDown44.Value + " - Php" + aorus49Inch);

                    // Power Supply
                    if (numericUpDown45.Value > 0)
                        writer.WriteLine("Gigabyte 850W PSU \t\t" + numericUpDown45.Value + " - Php" + gigabyte850w);
                    if (numericUpDown46.Value > 0)
                        writer.WriteLine("Gigabyte 750W PSU \t\t" + numericUpDown46.Value + " - Php" + gigabyte850w);
                    if (numericUpDown46.Value > 0)
                        writer.WriteLine("Gigabyte 750W PSU \t\t" + numericUpDown46.Value + " - Php" + gigabyte850w);


                    writer.WriteLine("-----------------------------------------------------------");
                    writer.WriteLine("Tax \t\t\t\t" + "1.2%");
                    writer.WriteLine("-----------------------------------------------------------");
                    writer.WriteLine("Sub Total \t\t\t" + "Php " + lblSubTotale.Text);
                    writer.WriteLine("Total Cost \t\t\t" + "Php " + lblTotalPriceE.Text);
                    writer.WriteLine("-----------------------------------------------------------");
                    writer.WriteLine(lblTime.Text + "\t" + lblDate.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error");
            }
        }

        private void cBoxIntel7_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {

        }

        private void btnRemoveAllCart_Click(object sender, EventArgs e)
        {
            //Processors
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

            //Graphics Cards
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;

            //Memory
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;

            //Motherboards
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            numericUpDown18.Value = 0;

            //Chassis
            numericUpDown19.Value = 0;
            numericUpDown20.Value = 0;
            numericUpDown21.Value = 0;

            //Storage
            numericUpDown22.Value = 0;
            numericUpDown23.Value = 0;
            numericUpDown24.Value = 0;
            numericUpDown25.Value = 0;
            numericUpDown26.Value = 0;
            numericUpDown27.Value = 0;

            //Fans
            numericUpDown28.Value = 0;
            numericUpDown29.Value = 0;
            numericUpDown30.Value = 0;
            numericUpDown31.Value = 0;
            numericUpDown32.Value = 0;
            numericUpDown33.Value = 0;

            //Accessories
            numericUpDown34.Value = 0;
            numericUpDown35.Value = 0;
            numericUpDown36.Value = 0;
            numericUpDown37.Value = 0;
            numericUpDown38.Value = 0;
            numericUpDown39.Value = 0;
            numericUpDown40.Value = 0;

            //Peripherals
            numericUpDown41.Value = 0;
            numericUpDown42.Value = 0;
            numericUpDown43.Value = 0;
            numericUpDown44.Value = 0;
            numericUpDown45.Value = 0;
            numericUpDown46.Value = 0;
            numericUpDown47.Value = 0;
            numericUpDown48.Value = 0;

            //Monitors
            numericUpDown49.Value = 0;
            numericUpDown50.Value = 0;
            numericUpDown51.Value = 0;

            //Power Supply
            numericUpDown52.Value = 0;
            numericUpDown53.Value = 0;
            numericUpDown54.Value = 0;

            //------------------------------------------------------------------------------//

            //Processors
            cBoxIntel7.Checked = false;
            cBoxIntel5.Checked = false;
            cBoxIntel3.Checked = false;
            cBoxRyzen7.Checked = false;
            cBoxRyzen5.Checked = false;

            //Graphics Cards
            cBox4080s.Checked = false;
            cBox4080.Checked = false;
            cBox4070s.Checked = false;
            cBox4070.Checked = false;
            cBox4060ti.Checked = false;

            //Memory
            cBoxFury64.Checked = false;
            cBoxFury16.Checked = false;
            cBoxXPG32.Checked = false;
            cBoxXPG64.Checked = false;

            //Motherboards
            cBoxZ790.Checked = false;
            cBoxB760.Checked = false;
            cBoxX760.Checked = false;
            cBoxB650.Checked = false;

            //Chassis
            cBoxH7.Checked = false;
            cBoxH6.Checked = false;
            cBoxH5.Checked = false;

            //Storage
            cBoxHDD8.Checked = false;
            cBoxHDD4.Checked = false;
            cBoxWD.Checked = false;
            cBoxTG.Checked = false;
            cBoxSamsung.Checked = false;
            cBoxADATA.Checked = false;

            //Fans
            cBoxF1203W.Checked = false;
            cBoxF1203B.Checked = false;
            cBoxF120W.Checked = false;
            cBoxF120B.Checked = false;
            cBoxSW4.Checked = false;
            cBoxSW2.Checked = false;

            //Accessories
            cBoxHDMI.Checked = false;
            cBoxDP.Checked = false;
            cBoxSneki.Checked = false;
            cBoxCMpaste.Checked = false;
            cBoxCMmount.Checked = false;
            cBoxNBarm.Checked = false;
            cBoxTGpaste.Checked = false;

            //Peripherals
            cBoxBWv4.Checked = false;
            cBoxBW75.Checked = false;
            cBoxDSv2.Checked = false;
            cBoxDAv3.Checked = false;
            cBoxVv3.Checked = false;
            cBoxBv3.Checked = false;
            cBoxSv3.Checked = false;
            cBoxBSv2.Checked = false;

            //Monitors
            cBoxAorus32.Checked = false;
            cBoxAorus43.Checked = false;
            cBoxAorus49.Checked = false;

            //Power Supply
            cBox850w.Checked = false;
            cBox750w.Checked = false;
            cBox650w.Checked = false;
        }

        private void CustomerMainWindow_Load(object sender, EventArgs e)
        {
            timerTime.Start();
            lblDate.Text = DateTime.Now.ToLongTimeString();

            lblTime.Text = DateTime.Now.ToLongDateString();
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongTimeString();
            timerTime.Start();
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {
            PaymentWindow paymentWindow = new PaymentWindow();
            paymentWindow.SetLabelText(lblTotalPriceE.Text);
            paymentWindow.ShowDialog();
            this.Close();
        }

        private void transactionHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
