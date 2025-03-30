using System.Collections.ObjectModel;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro.Controls;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public ObservableCollection<SalesData> SalesDataList { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // 더미 데이터 생성
            SalesDataList = new ObservableCollection<SalesData>
            {
                new SalesData { 날짜 = DateTime.Now.AddDays(-2), 카테고리 = "전자제품", 상품 = "스마트폰", 매출 = 100000 },
                new SalesData { 날짜 = DateTime.Now.AddDays(-1), 카테고리 = "전자제품", 상품 = "노트북", 매출 = 150000 },
                new SalesData { 날짜 = DateTime.Now, 카테고리 = "가전제품", 상품 = "냉장고", 매출 = 200000 },
                new SalesData { 날짜 = DateTime.Now, 카테고리 = "가전제품", 상품 = "세탁기", 매출 = 180000 }
            };

            // PivotGridControl에 데이터 바인딩
            pivotGridControl.DataSource = SalesDataList;
        }

        public class SalesData
        {
            public DateTime 날짜 { get; set; }
            public string 카테고리 { get; set; }
            public string 상품 { get; set; }
            public decimal 매출 { get; set; }
        }

    }
}