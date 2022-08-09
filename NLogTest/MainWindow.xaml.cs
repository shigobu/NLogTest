using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NLogTest
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string content = button.Content.ToString();

            switch (content)
            {
                case "Trace":
                    logger.Trace("トレース");
                    break;
                case "Debug":
                    logger.Debug("デバッグ");
                    break;
                case "Info" :
                    logger.Info("インフォ");
                    break;
                case "Warn" :
                    logger.Warn("ワーニング");
                    break;
                case "Error":
                    logger.Error("エラー");
                    break;
                case "Fatal":
                    logger.Fatal("フェイタル");
                    break;
                default:
                    logger.Fatal("デフォルト");
                    break;
            }

            try
            {
                string aaaaa = (string)sender;
            }
            catch (Exception ex)
            {
                logger.Fatal(ex, "{0}", e.GetHashCode());
            }
        }
    }
}
