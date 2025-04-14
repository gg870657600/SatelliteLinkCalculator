using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace SatelliteLinkCalculator
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow() 
        {
            InitializeComponent();
            this.DataContext = this; // Set the DataContext to the current window  
        }

        // Implement INotifyPropertyChanged  
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Bindable properties for Uplink Parameters  
        public double UplinkFrequency
        {
            get => Properties.Settings.Default.UplinkFrequency;
            set
            {
                Properties.Settings.Default.UplinkFrequency = value;
                OnPropertyChanged(nameof(UplinkFrequency));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkAntennaDiameter
        {
            get => Properties.Settings.Default.UplinkAntennaDiameter;
            set
            {
                Properties.Settings.Default.UplinkAntennaDiameter = value;
                OnPropertyChanged(nameof(UplinkAntennaDiameter));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkAntennaEfficiency
        {
            get => Properties.Settings.Default.UplinkAntennaEfficiency;
            set
            {
                Properties.Settings.Default.UplinkAntennaEfficiency = value;
                OnPropertyChanged(nameof(UplinkAntennaEfficiency));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkTransmitGain
        {
            get => Properties.Settings.Default.UplinkTransmitGain;
            set
            {
                Properties.Settings.Default.UplinkTransmitGain = value;
                OnPropertyChanged(nameof(UplinkTransmitGain));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkPowerAtFeed
        {
            get => Properties.Settings.Default.UplinkPowerAtFeed;
            set
            {

                Properties.Settings.Default.UplinkPowerAtFeed = value;
                OnPropertyChanged(nameof(UplinkPowerAtFeed));
                Properties.Settings.Default.Save();

            }
        }
        
        public double TxFeedlineLoss
        {
            get => Properties.Settings.Default.TxFeedlineLoss;
            set
            {

                Properties.Settings.Default.TxFeedlineLoss = value;
                OnPropertyChanged(nameof(TxFeedlineLoss));
                Properties.Settings.Default.Save();

            }
        }
        public double UplinkEIRP
        {
            get => Properties.Settings.Default.UplinkEIRP;
            set
            {
                Properties.Settings.Default.UplinkEIRP = value;
                OnPropertyChanged(nameof(UplinkEIRP));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkRange
        {
            get => Properties.Settings.Default.UplinkRange;
            set
            {
                Properties.Settings.Default.UplinkRange = value;
                OnPropertyChanged(nameof(UplinkRange));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkPathLoss
        {
            get => Properties.Settings.Default.UplinkPathLoss;
            set
            {
                Properties.Settings.Default.UplinkPathLoss = value;
                OnPropertyChanged(nameof(UplinkPathLoss));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkPFD
        {
            get => Properties.Settings.Default.UplinkPFD;
            set
            {
                Properties.Settings.Default.UplinkPFD = value;
                OnPropertyChanged(nameof(UplinkPFD));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkNoiseBandwidth
        {
            get => Properties.Settings.Default.UplinkNoiseBandwidth;
            set
            {
                Properties.Settings.Default.UplinkNoiseBandwidth = value;
                OnPropertyChanged(nameof(UplinkNoiseBandwidth));
                Properties.Settings.Default.Save();
            }
        }
        public double SatelliteSFD
        {
            get => Properties.Settings.Default.SatelliteSFD;
            set
            {
                Properties.Settings.Default.SatelliteSFD = value;
                OnPropertyChanged(nameof(SatelliteSFD));
                Properties.Settings.Default.Save();
            }
        }
        public double UplinkBandwidth
        {
            get => Properties.Settings.Default.UplinkBandwidth;
            set
            {
                Properties.Settings.Default.UplinkBandwidth = value;
                OnPropertyChanged(nameof(UplinkBandwidth));
                Properties.Settings.Default.Save();
            }
        }
        public double UplinkEIRP2
        {
            get => Properties.Settings.Default.UplinkEIRP2;
            set
            {
                Properties.Settings.Default.UplinkEIRP2 = value;
                OnPropertyChanged(nameof(UplinkEIRP2));
                Properties.Settings.Default.Save();
            }
        }
        public double TransponderBandwidth
        {
            get => Properties.Settings.Default.TransponderBandwidth;
            set
            {
                Properties.Settings.Default.TransponderBandwidth = value;
                OnPropertyChanged(nameof(TransponderBandwidth));
                Properties.Settings.Default.Save();
            }
        }
        public double TransponderInputFallback
        {
            get => Properties.Settings.Default.TransponderInputFallback;
            set
            {
                Properties.Settings.Default.TransponderInputFallback = value;
                OnPropertyChanged(nameof(TransponderInputFallback));
                Properties.Settings.Default.Save();
            }
        }
        public double UpCarrierFallback
        {
            get => Properties.Settings.Default.UpCarrierFallback;
            set
            {
                Properties.Settings.Default.UpCarrierFallback = value;
                OnPropertyChanged(nameof(UpCarrierFallback));
                Properties.Settings.Default.Save();
            }
        }
        public double CarrierInputFallback
        {
            get => Properties.Settings.Default.CarrierInputFallback;
            set
            {
                Properties.Settings.Default.CarrierInputFallback = value;
                OnPropertyChanged(nameof(CarrierInputFallback));
                Properties.Settings.Default.Save();
            }
        }
        public double UplinkEIRP3
        {
            get => Properties.Settings.Default.UplinkEIRP3;
            set
            {
                Properties.Settings.Default.UplinkEIRP3 = value;
                OnPropertyChanged(nameof(UplinkEIRP3));
                Properties.Settings.Default.Save();
            }
        }
        public string TransponderSaturated
        {
            get => Properties.Settings.Default.TransponderSaturated;
            set
            {
                Properties.Settings.Default.TransponderSaturated = value;
                OnPropertyChanged(nameof(TransponderSaturated));
                Properties.Settings.Default.Save();
            }
        }
        public double UplinkGT
        {
            get => Properties.Settings.Default.UplinkGT;
            set
            {
                Properties.Settings.Default.UplinkGT = value;
                OnPropertyChanged(nameof(UplinkGT));
                Properties.Settings.Default.Save();
            }
        }
        public double UpOtherLoss
        {
            get => Properties.Settings.Default.UpOtherLoss;
            set
            {
                Properties.Settings.Default.UpOtherLoss = value;
                OnPropertyChanged(nameof(UpOtherLoss));
                Properties.Settings.Default.Save();
            }
        }
        public double UpTotalLoss
        {
            get => Properties.Settings.Default.UpTotalLoss;
            set
            {
                Properties.Settings.Default.UpTotalLoss = value;
                OnPropertyChanged(nameof(UpTotalLoss));
                Properties.Settings.Default.Save();
            }
        }
        public double UplinkCN
        {
            get => Properties.Settings.Default.UplinkCN;
            set
            {
                Properties.Settings.Default.UplinkCN = value;
                OnPropertyChanged(nameof(UplinkCN));
                Properties.Settings.Default.Save();
            }
        }

        // Bindable properties for Downlink Parameters  
        public double DownlinkFrequency
        {
            get => Properties.Settings.Default.DownlinkFrequency;
            set
            {
                Properties.Settings.Default.DownlinkFrequency = value;
                OnPropertyChanged(nameof(DownlinkFrequency));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkAntennaDiameter
        {
            get => Properties.Settings.Default.DownlinkAntennaDiameter;
            set
            {
                Properties.Settings.Default.DownlinkAntennaDiameter = value;
                OnPropertyChanged(nameof(DownlinkAntennaDiameter));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkAntennaEfficiency
        {
            get => Properties.Settings.Default.DownlinkAntennaEfficiency;
            set
            {
                Properties.Settings.Default.DownlinkAntennaEfficiency = value;
                OnPropertyChanged(nameof(DownlinkAntennaEfficiency));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkReceiveGain
        {
            get => Properties.Settings.Default.DownlinkReceiveGain;
            set
            {
                Properties.Settings.Default.DownlinkReceiveGain = value;
                OnPropertyChanged(nameof(DownlinkReceiveGain));
                Properties.Settings.Default.Save();
            }
        }
        public double RxAntennaNoiseTemperature
        {
            get => Properties.Settings.Default.RxAntennaNoiseTemperature;
            set
            {
                Properties.Settings.Default.RxAntennaNoiseTemperature = value;
                OnPropertyChanged(nameof(RxAntennaNoiseTemperature));
                Properties.Settings.Default.Save();
            }
        }
        public double RxFeedlineLoss
        {
            get => Properties.Settings.Default.RxFeedlineLoss;
            set
            {
                Properties.Settings.Default.RxFeedlineLoss = value;
                OnPropertyChanged(nameof(RxFeedlineLoss));
                Properties.Settings.Default.Save();
            }
        }
        public double NoiseFigure
        {
            get => Properties.Settings.Default.NoiseFigure;
            set
            {
                Properties.Settings.Default.NoiseFigure = value;
                OnPropertyChanged(nameof(NoiseFigure));
                Properties.Settings.Default.Save();
            }
        }
        public double DownlinkNoiseTemperature
        {
            get => Properties.Settings.Default.DownlinkNoiseTemperature;
            set
            {
                Properties.Settings.Default.DownlinkNoiseTemperature = value;
                OnPropertyChanged(nameof(DownlinkNoiseTemperature));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkGT
        {
            get => Properties.Settings.Default.DownlinkGT;
            set
            {
                Properties.Settings.Default.DownlinkGT = value;
                OnPropertyChanged(nameof(DownlinkGT));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkRange
        {
            get => Properties.Settings.Default.DownlinkRange;
            set
            {
                Properties.Settings.Default.DownlinkRange = value;
                OnPropertyChanged(nameof(DownlinkRange));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkPathLoss
        {
            get => Properties.Settings.Default.DownlinkPathLoss;
            set
            {
                Properties.Settings.Default.DownlinkPathLoss = value;
                OnPropertyChanged(nameof(DownlinkPathLoss));
                Properties.Settings.Default.Save();
            }
        }

        public double SatelliteEIRP
        {
            get => Properties.Settings.Default.SatelliteEIRP;
            set
            {
                Properties.Settings.Default.SatelliteEIRP = value;
                OnPropertyChanged(nameof(SatelliteEIRP));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkOtherLoss
        {
            get => Properties.Settings.Default.DownlinkOtherLoss;
            set
            {
                Properties.Settings.Default.DownlinkOtherLoss = value;
                OnPropertyChanged(nameof(DownlinkOtherLoss));
                Properties.Settings.Default.Save();
            }
        }
        public double DownlinkTotalLoss
        {
            get => Properties.Settings.Default.DownlinkTotalLoss;
            set
            {
                Properties.Settings.Default.DownlinkTotalLoss = value;
                OnPropertyChanged(nameof(DownlinkTotalLoss));
                Properties.Settings.Default.Save();
            }
        }
        public double DownlinkNoiseBandwidth
        {
            get => Properties.Settings.Default.DownlinkNoiseBandwidth;
            set
            {
                Properties.Settings.Default.DownlinkNoiseBandwidth = value;
                OnPropertyChanged(nameof(DownlinkNoiseBandwidth));
                Properties.Settings.Default.Save();
            }
        }
        public double DownlinkBandwidth
        {
            get => Properties.Settings.Default.DownlinkBandwidth;
            set
            {
                Properties.Settings.Default.DownlinkBandwidth = value;
                OnPropertyChanged(nameof(DownlinkBandwidth));
                Properties.Settings.Default.Save();
            }
        }
        public double SatelliteInPower
        {
            get => Properties.Settings.Default.SatelliteInPower;
            set
            {
                Properties.Settings.Default.SatelliteInPower = value;
                OnPropertyChanged(nameof(SatelliteInPower));
                Properties.Settings.Default.Save();
            }
        }
        public double SatelliteGain
        {
            get => Properties.Settings.Default.SatelliteGain;
            set
            {
                Properties.Settings.Default.SatelliteGain = value;
                OnPropertyChanged(nameof(SatelliteGain));
                Properties.Settings.Default.Save();
            }
        }
        public double DownlinkEIRP
        {
            get => Properties.Settings.Default.DownlinkEIRP;
            set
            {
                Properties.Settings.Default.DownlinkEIRP = value;
                OnPropertyChanged(nameof(DownlinkEIRP));
                Properties.Settings.Default.Save();
            }
        }
        public double TransponderOutputFallback
        {
            get => Properties.Settings.Default.TransponderOutputFallback;
            set
            {
                Properties.Settings.Default.TransponderOutputFallback = value;
                OnPropertyChanged(nameof(TransponderOutputFallback));
                Properties.Settings.Default.Save();
            }
        }
        public double DownCarrierFallback
        {
            get => Properties.Settings.Default.DownCarrierFallback;
            set
            {
                Properties.Settings.Default.DownCarrierFallback = value;
                OnPropertyChanged(nameof(DownCarrierFallback));
                Properties.Settings.Default.Save();
            }
        }
        public double CarrierOutputFallback
        {
            get => Properties.Settings.Default.CarrierOutputFallback;
            set
            {
                Properties.Settings.Default.CarrierOutputFallback = value;
                OnPropertyChanged(nameof(CarrierOutputFallback));
                Properties.Settings.Default.Save();
            }
        }

        public double DownlinkCN
        {
            get => Properties.Settings.Default.DownlinkCN;
            set
            {
                Properties.Settings.Default.DownlinkCN = value;
                OnPropertyChanged(nameof(DownlinkCN));
                Properties.Settings.Default.Save();
            }
        }

        public double UplinkCI
        {
            get => Properties.Settings.Default.UplinkCI;
            set
            {
                Properties.Settings.Default.UplinkCI = value;
                OnPropertyChanged(nameof(UplinkCI));
                Properties.Settings.Default.Save();
            }
        }
        public double SatelliteCI
        {
            get => Properties.Settings.Default.SatelliteCI;
            set
            {
                Properties.Settings.Default.SatelliteCI = value;
                OnPropertyChanged(nameof(SatelliteCI));
                Properties.Settings.Default.Save();
            }
        }
        public double DownlinkCI
        {
            get => Properties.Settings.Default.DownlinkCI;
            set
            {
                Properties.Settings.Default.DownlinkCI = value;
                OnPropertyChanged(nameof(DownlinkCI));
                Properties.Settings.Default.Save();
            }
        }
        public double TotalCN
        {
            get => Properties.Settings.Default.TotalCN;
            set
            {
                Properties.Settings.Default.TotalCN = value;
                OnPropertyChanged(nameof(TotalCN));
                Properties.Settings.Default.Save();
            }
        }
        public double ThresholdCNR
        {
            get => Properties.Settings.Default.ThresholdCNR;
            set
            {
                Properties.Settings.Default.ThresholdCNR = value;
                OnPropertyChanged(nameof(ThresholdCNR));
                Properties.Settings.Default.Save();
            }
        }
        public double MarginCNR
        {
            get => Properties.Settings.Default.MarginCNR;
            set
            {
                Properties.Settings.Default.MarginCNR = value;
                OnPropertyChanged(nameof(MarginCNR));
                Properties.Settings.Default.Save();
            }
        }
        public double SatelliteHeight
        {
            get => Properties.Settings.Default.SatelliteHeight;
            set
            {
                Properties.Settings.Default.SatelliteHeight = value;
                OnPropertyChanged(nameof(SatelliteHeight));
                Properties.Settings.Default.Save();
            }
        }
        public double EarthRadius
        {
            get => Properties.Settings.Default.EarthRadius;
            set
            {
                Properties.Settings.Default.EarthRadius = value;
                OnPropertyChanged(nameof(EarthRadius));
                Properties.Settings.Default.Save();
            }
        }
        public double AntennaElevation
        {
            get => Properties.Settings.Default.AntennaElevation;
            set
            {
                Properties.Settings.Default.AntennaElevation = value;
                OnPropertyChanged(nameof(AntennaElevation));
                Properties.Settings.Default.Save();
            }
        }
        public double GeocentricAngle
        {
            get => Properties.Settings.Default.GeocentricAngle;
            set
            {
                Properties.Settings.Default.GeocentricAngle = value;
                OnPropertyChanged(nameof(GeocentricAngle));
                Properties.Settings.Default.Save();
            }
        }
        public double OrbitalPosition
        {
            get => Properties.Settings.Default.OrbitalPosition;
            set
            {
                Properties.Settings.Default.OrbitalPosition = value;
                OnPropertyChanged(nameof(OrbitalPosition));
                Properties.Settings.Default.Save();
            }
        }
        public double DownGroundStationLongitude
        {
            get => Properties.Settings.Default.DownGroundStationLongitude;
            set
            {
                Properties.Settings.Default.DownGroundStationLongitude = value;
                OnPropertyChanged(nameof(DownGroundStationLongitude));
                Properties.Settings.Default.Save();
            }
        }
        public double DownGroundStationLatitude
        {
            get => Properties.Settings.Default.DownGroundStationLatitude;
            set
            {
                Properties.Settings.Default.DownGroundStationLatitude = value;
                OnPropertyChanged(nameof(DownGroundStationLatitude));
                Properties.Settings.Default.Save();
            }
        }
        public double UpGroundStationLongitude
        {
            get => Properties.Settings.Default.UpGroundStationLongitude;
            set
            {
                Properties.Settings.Default.UpGroundStationLongitude = value;
                OnPropertyChanged(nameof(UpGroundStationLongitude));
                Properties.Settings.Default.Save();
            }
        }
        public double UpGroundStationLatitude
        {
            get => Properties.Settings.Default.UpGroundStationLatitude;
            set
            {
                Properties.Settings.Default.UpGroundStationLatitude = value;
                OnPropertyChanged(nameof(UpGroundStationLatitude));
                Properties.Settings.Default.Save();
            }
        }
        public double RollOff
        {
            get => Properties.Settings.Default.RollOff;
            set
            {
                Properties.Settings.Default.RollOff = value;
                OnPropertyChanged(nameof(RollOff));
                Properties.Settings.Default.Save();
            }
        }
        public double SymbolRate
        {
            get => Properties.Settings.Default.SymbolRate;
            set
            {
                Properties.Settings.Default.SymbolRate = value;
                OnPropertyChanged(nameof(SymbolRate));
                Properties.Settings.Default.Save();
            }
        }
        public double Rate
        {
            get => Properties.Settings.Default.Rate;
            set
            {
                Properties.Settings.Default.Rate = value;
                OnPropertyChanged(nameof(Rate));
                Properties.Settings.Default.Save();
            }
        }
        public double ModulationOrder
        {
            get => Properties.Settings.Default.ModulationOrder;
            set
            {
                Properties.Settings.Default.ModulationOrder = value;
                OnPropertyChanged(nameof(ModulationOrder));
                Properties.Settings.Default.Save();
            }
        }
        public double InformationRate
        {
            get => Properties.Settings.Default.InformationRate;
            set
            {
                Properties.Settings.Default.InformationRate = value;
                OnPropertyChanged(nameof(InformationRate));
                Properties.Settings.Default.Save();
            }
        }
        public double BitRate
        {
            get => Properties.Settings.Default.BitRate;
            set
            {
                Properties.Settings.Default.BitRate = value;
                OnPropertyChanged(nameof(BitRate));
                Properties.Settings.Default.Save();
            }
        }
        public double EbN0
        {
            get => Properties.Settings.Default.EbN0;
            set
            {
                Properties.Settings.Default.EbN0 = value;
                OnPropertyChanged(nameof(EbN0));
                Properties.Settings.Default.Save();
            }
        }
        public double ThresholdEbN0
        {
            get => Properties.Settings.Default.ThresholdEbN0;
            set
            {
                Properties.Settings.Default.ThresholdEbN0 = value;
                OnPropertyChanged(nameof(ThresholdEbN0));
                Properties.Settings.Default.Save();
            }
        }
        public double MarginEbN0
        {
            get => Properties.Settings.Default.MarginEbN0;
            set
            {
                Properties.Settings.Default.MarginEbN0 = value;
                OnPropertyChanged(nameof(MarginEbN0));
                Properties.Settings.Default.Save();
            }
        }
        public string Show
        {
            get => Properties.Settings.Default.Show;
            set
            {
                Properties.Settings.Default.Show = value;
                OnPropertyChanged(nameof(Show));
                Properties.Settings.Default.Save();
            }
        }
        // Save button click event  
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Settings saved!", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Information);
        }


        private void UpCalculateButton_Click(object sender, RoutedEventArgs e)
        {
            

            

            

            // 计算上行 PFD --dBW/m^2
            UplinkPFD = Math.Round(UplinkEIRP - UplinkPathLoss +
                10 * Math.Log10(4 * Math.PI / Math.Pow((3e8 / (UplinkFrequency * 1e9)), 2)), 4);

            // 计算上行地球站饱和等效全向辐射功率EIRP(dBW)
            // 计算载波回退CBO
            UpCarrierFallback = Math.Round(10 * Math.Log10(TransponderBandwidth / UplinkBandwidth) , 4);
            // 计算载波输入回退CIBO
            CarrierInputFallback = UpCarrierFallback + TransponderInputFallback;
            UplinkEIRP2 = Math.Round(SatelliteSFD - CarrierInputFallback - 10 * Math.Log10(4 * Math.PI / Math.Pow((3e8 / (UplinkFrequency * 1e9)), 2)) +
                DownlinkPathLoss + UpOtherLoss , 4);

            //卫星有效全向辐射功率EIRP(dBW)
            if (UplinkEIRP2 <= UplinkEIRP) //卫星转发器被推饱和
            {
                UplinkEIRP3 = UplinkEIRP2;
            }
            else //卫星转发器没被推饱和
            {
                UplinkEIRP3 = UplinkEIRP;
            }

            // 计算上行载噪比 --dB (K为玻尔兹曼常数， K=-228.6dB/K•Hz)
            UplinkCN = Math.Round(UplinkEIRP3 - UplinkPathLoss - UpOtherLoss +
                UplinkGT + 228.6 - 10 * Math.Log10(UplinkNoiseBandwidth * 1e6), 4);
        }

        private void TotalCNR_Click(object sender, RoutedEventArgs e)
        {
            // 计算总的载噪比 --dB
            TotalCN = Math.Round(10 * Math.Log10(1 / (
                1 / Math.Pow(10, UplinkCN / 10) +
                1 / Math.Pow(10, DownlinkCN / 10) 
                //1 / Math.Pow(10, UplinkCI / 10) +
                //1 / Math.Pow(10, SatelliteCI / 10) +
                //1 / Math.Pow(10, DownlinkCI / 10)
                )), 4);

            // 计算链路余量 --dB
            MarginCNR = Math.Round(TotalCN - ThresholdCNR, 4);
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //string imagePath = "";
            if (sender is TextBox textBox)
            {
                
                switch (textBox.Name)
                {
                    
                    case "UplinkTransmitGainTextBox":
                        string imagePath = "/img/天线增益.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        // 设置图片的显示位置（如果需要）
                        // HoverImage.Margin = new Thickness(...);
                        break;

                    case "UplinkEIRPTextBox":
                        imagePath = "/img/天线发射EIRP.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;

                    case "UplinkRangeTextBox":
                        if (UplinkRangeComboBox.SelectedIndex == 0)
                        {
                            imagePath = "/img/星地距离.jpeg";
                            HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                            HoverImage.Visibility = Visibility.Visible;
                        }
                        else if (UplinkRangeComboBox.SelectedIndex == 1)
                        {
                            imagePath = "/img/同步卫星与地面站的距离.jpeg";
                            HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                            HoverImage.Visibility = Visibility.Visible;
                        }
                        break;
                    case "DownlinkRangeTextBox":
                        if(DownlinkRangeComboBox.SelectedIndex == 0)
                        {
                            imagePath = "/img/星地距离.jpeg";
                            HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                            HoverImage.Visibility = Visibility.Visible;
                        }
                        else if(DownlinkRangeComboBox.SelectedIndex == 1)
                        {
                            imagePath = "/img/同步卫星与地面站的距离.jpeg";
                            HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                            HoverImage.Visibility = Visibility.Visible;
                        }                        
                        break;
                    case "UplinkPathLossTextBox":
                        imagePath = "/img/自由空间损耗.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "SFDTextBlock":
                        imagePath = "/img/SFD卫星饱和通量密度.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "UplinkEIRP2TextBox":
                        imagePath = "/img/地面站有效全向辐射功率EIRP.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "UpCarrierFallbackTextBox":
                        imagePath = "/img/转发器载波回退.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;

                    case "DownlinkDeceiveGainTextBox":
                        imagePath = "/img/天线增益.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "DownlinkNoiseTemperatureTextBox":
                        imagePath = "/img/接收系统等效噪声温度.png";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "DownlinkGTTextBox":
                        imagePath = "/img/接收系统品质因素GT.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "DownlinkPathLossTextBox":
                        imagePath = "/img/自由空间损耗.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "DownCarrierFallbackTextBox":
                        imagePath = "/img/转发器载波回退.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "UplinkCNTextBox":
                        imagePath = "/img/载噪比.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "DownlinkCNTextBox":
                        imagePath = "/img/载噪比.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "TotalCNTextBox":
                        imagePath = "/img/总载噪比.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "SymbolRateTextBox":
                        imagePath = "/img/符号速率.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "ModulationOrderTextBox":
                        imagePath = "/img/调制阶数.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "InformationRateTextBox":
                        imagePath = "/img/信息速率.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;
                    case "EbN0TextBox":
                        imagePath = "/img/EbN0.jpeg";
                        HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
                        HoverImage.Visibility = Visibility.Visible;
                        break;

                    default:
                        // 默认处理逻辑（如果有）
                        break;
                }
            }

        }

        private void Button_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            // 隐藏图片  
            //HoverImage.Visibility = Visibility.Hidden;

            string imagePath = "/img/卫星通信链路.jpeg";
            HoverImage.Source = new BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
            HoverImage.Visibility = Visibility.Visible;
        }

        private void TxAntennaGain_Click(object sender, RoutedEventArgs e)
        {
            if(UplinkFrequency != 0 && UplinkAntennaDiameter != 0 && UplinkAntennaEfficiency != 0 )
            {
                // 计算上行天线发射增益 --dBi
                UplinkTransmitGain = Math.Round(10 * Math.Log10(UplinkAntennaEfficiency) +
                    20 * Math.Log10((Math.PI * UplinkAntennaDiameter * UplinkFrequency * 1e9) / 3e8), 4);
            }
            else if (UplinkAntennaDiameter == 0.0 && UplinkTransmitGain != 0 && UplinkFrequency != 0 && UplinkAntennaEfficiency != 0)
            {
                UplinkAntennaDiameter = Math.Round(Math.Pow(10, (UplinkTransmitGain - 10 * Math.Log10(UplinkAntennaEfficiency)) / 20) 
                    * 3e8 / Math.PI / UplinkFrequency / 1e9, 4);
            }
            else
            {
                MessageBox.Show("请输入相关参数");
            }
        }

        private void TxAntennaEIRP_Click(object sender, RoutedEventArgs e)
        {
            if (UplinkTransmitGain != 0 && UplinkPowerAtFeed != 0)
            {
                // 计算上行 EIRP --dBW
                UplinkEIRP = Math.Round(UplinkTransmitGain +
                    10 * Math.Log10(UplinkPowerAtFeed) - TxFeedlineLoss, 4);
            }
            else if (UplinkPowerAtFeed == 0.0 && UplinkTransmitGain != 0 && UplinkEIRP != 0)
            {
                UplinkPowerAtFeed = Math.Round(Math.Pow(10, (UplinkEIRP - UplinkTransmitGain + TxFeedlineLoss) / 10) , 4);
            }
            else if (UplinkTransmitGain == 0.0 && UplinkPowerAtFeed != 0 && UplinkEIRP != 0)
            {
                UplinkTransmitGain = Math.Round(UplinkEIRP - 10 * Math.Log10(UplinkPowerAtFeed) + TxFeedlineLoss, 4);
            }
            else 
            {
                MessageBox.Show("请输入相关参数");
            }
        }
        private void UplinkLoss_Click(object sender, RoutedEventArgs e)
        {
            //计算地面站和卫星的距离
            if (UplinkRangeComboBox.SelectedIndex == 0)
            {
                //粗计算
                //地心角
                GeocentricAngle = Math.Round(Math.Acos(EarthRadius / (EarthRadius + SatelliteHeight) *
                    Math.Cos(AntennaElevation * (Math.PI / 180))) * (180 / Math.PI) - AntennaElevation, 4);

                UplinkRange = Math.Round(Math.Sqrt(EarthRadius * EarthRadius + Math.Pow(EarthRadius + SatelliteHeight, 2) -
                    2 * EarthRadius * (EarthRadius + SatelliteHeight) * Math.Cos(GeocentricAngle * (Math.PI / 180))), 4);
            }
            else if (UplinkRangeComboBox.SelectedIndex == 1)
            {
                //精计算
                UplinkRange = Math.Round(42164.2 * Math.Sqrt(1.02288 - 0.302539 *
                    Math.Cos((UpGroundStationLongitude - OrbitalPosition) * (Math.PI / 180)) *
                    Math.Cos(UpGroundStationLatitude * (Math.PI / 180))
                    ), 4);
            }

            // 计算上行链路空间自由损耗
            UplinkPathLoss = Math.Round(20 * Math.Log10(UplinkFrequency * 1e9) +
                20 * Math.Log10(UplinkRange * 1e3) + 20 * Math.Log10(4 * Math.PI / 3e8), 4);

            //计算上行总损耗
            UpTotalLoss = UplinkPathLoss + UpOtherLoss + TxFeedlineLoss;
        }

        private void UpEIRP_CNR_Click(object sender, RoutedEventArgs e)
        {
            
            // 计算载波回退CBO
            UpCarrierFallback = Math.Round(10 * Math.Log10(TransponderBandwidth / UplinkBandwidth), 4);
            // 计算载波输入回退CIBO
            CarrierInputFallback = UpCarrierFallback + TransponderInputFallback;
            // 计算上行地球站饱和等效全向辐射功率EIRP(dBW)
            UplinkEIRP2 = Math.Round(SatelliteSFD - CarrierInputFallback - 10 * Math.Log10(4 * Math.PI / Math.Pow((3e8 / (UplinkFrequency * 1e9)), 2)) +
                UpTotalLoss, 4);

            //卫星有效全向辐射功率EIRP(dBW)
            if (UplinkEIRP2 <= UplinkEIRP) //卫星转发器被推饱和
            {
                UplinkEIRP3 = UplinkEIRP2;

                //卫星转发器饱和时下行相关控件隐藏
                Show = "Collapsed";

                TransponderSaturated = "饱和";
            }
            else //卫星转发器没被推饱和
            {
                UplinkEIRP3 = UplinkEIRP;

                //卫星转发器不饱和时下行相关控件显示
                Show = "Visible";

                TransponderSaturated = "不饱和";
            }

            // 计算上行载噪比 --dB (K为玻尔兹曼常数， K=-228.6dB/K•Hz)
            UplinkCN = Math.Round(UplinkEIRP3 - UpTotalLoss +
                UplinkGT + 228.6 - 10 * Math.Log10(UplinkNoiseBandwidth * 1e6), 4);
        }

        private void RxAntennaGain_Click(object sender, RoutedEventArgs e)
        {
            // 计算下行接收天线接收增益 --dBi
            //DownlinkReceiveGain = Math.Round(10 * Math.Log10(DownlinkAntennaEfficiency) +
            //    20 * Math.Log10((Math.PI * DownlinkAntennaDiameter * DownlinkFrequency * 1e9) / 3e8), 4);

            if (DownlinkFrequency != 0 && DownlinkAntennaDiameter != 0 && DownlinkAntennaEfficiency != 0)
            {
                // 计算上行天线发射增益 --dBi
                DownlinkReceiveGain = Math.Round(10 * Math.Log10(DownlinkAntennaEfficiency) +
                    20 * Math.Log10((Math.PI * DownlinkAntennaDiameter * DownlinkFrequency * 1e9) / 3e8), 4);
            }
            else if (DownlinkAntennaDiameter == 0.0 && DownlinkReceiveGain != 0 && DownlinkFrequency != 0 && DownlinkAntennaEfficiency != 0)
            {
                DownlinkAntennaDiameter = Math.Round(Math.Pow(10, (DownlinkReceiveGain - 10 * Math.Log10(DownlinkAntennaEfficiency)) / 20)
                    * 3e8 / Math.PI / DownlinkFrequency / 1e9, 4);
            }
            else
            {
                MessageBox.Show("请输入相关参数");
            }
        }

        private void RxAntennaGT_Click(object sender, RoutedEventArgs e)
        {
            if(RxAntennaNoiseTemperature != 0.0 && NoiseFigure != 0.0 )
            {
                DownlinkNoiseTemperature = Math.Round(RxAntennaNoiseTemperature / Math.Pow(10, RxFeedlineLoss / 10) +
                    (1 - 1 / Math.Pow(10, RxFeedlineLoss / 10)) + (Math.Pow(10, NoiseFigure / 10) - 1) * 290 ,4);
            }
            // 计算下行接收天线品质因数 G/T --dB/K
            DownlinkGT = Math.Round(DownlinkReceiveGain -
                10 * Math.Log10(DownlinkNoiseTemperature), 4);
        }

        private void DownlinkLoss_Click(object sender, RoutedEventArgs e)
        {
            //计算地面站和卫星的距离
            if (DownlinkRangeComboBox.SelectedIndex == 0)
            {
                //粗计算
                //地心角
                GeocentricAngle = Math.Round(Math.Acos(EarthRadius / (EarthRadius + SatelliteHeight) *
                    Math.Cos(AntennaElevation * (Math.PI / 180))) * (180 / Math.PI) - AntennaElevation, 4);

                DownlinkRange = Math.Round(Math.Sqrt(EarthRadius * EarthRadius + Math.Pow(EarthRadius + SatelliteHeight, 2) -
                    2 * EarthRadius * (EarthRadius + SatelliteHeight) * Math.Cos(GeocentricAngle * (Math.PI / 180))), 4);
            }
            else if (DownlinkRangeComboBox.SelectedIndex == 1)
            {
                //精计算
                DownlinkRange = Math.Round(42164.2 * Math.Sqrt(1.02288 - 0.302539 *
                    Math.Cos((DownGroundStationLongitude - OrbitalPosition) * (Math.PI / 180)) *
                    Math.Cos(DownGroundStationLatitude * (Math.PI / 180))
                    ), 4);
            }

            // 计算下行链路空间自由损耗
            DownlinkPathLoss = Math.Round(20 * Math.Log10(DownlinkFrequency * 1e9) +
                20 * Math.Log10(DownlinkRange * 1e3) + 20 * Math.Log10(4 * Math.PI / 3e8), 4);
            //下行总损耗
            DownlinkTotalLoss = DownlinkPathLoss + DownlinkOtherLoss;
        }

        private void DownEIRP_CNR_Click(object sender, RoutedEventArgs e)
        {
            // 计算下行卫星有效全向辐射功率EIRP(dBW)
            // 计算载波回退CBO
            DownCarrierFallback = Math.Round(10 * Math.Log10(TransponderBandwidth / DownlinkBandwidth), 4);
            // 计算载波输出回退COBO
            CarrierOutputFallback = DownCarrierFallback + TransponderOutputFallback;
            //UplinkEIRP2 = Math.Round(SatelliteSFD - CarrierInputFallback - 10 * Math.Log10(4 * Math.PI / Math.Pow((3e8 / (UplinkFrequency * 1e9)), 2)) +
            //    DownlinkPathLoss + UpOtherLoss, 4);
            //卫星有效全向辐射功率EIRP(dBW)
            if (UplinkEIRP2 <= UplinkEIRP) //卫星转发器被推饱和
            {
                DownlinkEIRP = SatelliteEIRP - CarrierOutputFallback;
            }
            else //卫星转发器没被推饱和
            {
                //计算卫星转发器输入端饱和功率
                SatelliteInPower = SatelliteSFD + 10 * Math.Log10(4 * Math.PI * UplinkRange * UplinkRange) - UplinkPathLoss - UpOtherLoss;
                //计算卫星转发器增益
                SatelliteGain = (SatelliteEIRP - TransponderOutputFallback) - (SatelliteInPower - TransponderInputFallback);
                DownlinkEIRP = UplinkEIRP - UplinkPathLoss - UpOtherLoss + SatelliteGain;
            }

            // 计算下行载噪比 --dB
            // 假设上下行带宽一样
            DownlinkCN = Math.Round(DownlinkEIRP - DownlinkTotalLoss + DownlinkGT + 228.6 -
                10 * Math.Log10(DownlinkNoiseBandwidth * 1e6), 4);
        }

        private void TotalEbN0_Click(object sender, RoutedEventArgs e)
        {
            //符号速率Msps
            SymbolRate = Math.Round(DownlinkBandwidth / (1 + RollOff), 4);
            //信息速率/比特率Mbps
            InformationRate = Math.Round(SymbolRate * Rate * Log2(ModulationOrder), 4);
            //信息速率/比特率（dB）
            double InformationRateDB = Math.Round(10 * Math.Log10(InformationRate * 1e6),4);
            //EbN0计算
            EbN0 = Math.Round(UplinkCN - InformationRateDB + DownlinkNoiseBandwidth , 4);
            //链路余量
            MarginEbN0 = EbN0 - ThresholdEbN0;
        }
        static double Log2(double value)
        {
            return Math.Log(value) / Math.Log(2); // 使用自然对数  
            // 或者可以使用：return Math.Log10(value) / Math.Log10(2); // 使用以 10 为底的对数  
        }
    }

    public class DoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double doubleValue)
            {
                return doubleValue.ToString(culture);
            }
            return "0"; // 默认显示为 0
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string stringValue &&
                double.TryParse(stringValue, NumberStyles.Any, culture, out double result))
            {
                return result;
            }
            return 0; // 默认值为 0
        }
    }
}