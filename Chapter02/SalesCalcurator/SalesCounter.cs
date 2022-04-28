using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalcurator {
    public class SalesCounter {
        private List<Sale>_sales;//csvファイルから読み込んだデータ

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSalse() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    dict[sale.ShopName] += sale.Amount;
                else
                    dict[sale.ShopName] = sale.Amount;
            }

            return dict;

        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        public static List<Sale> ReadSales(String filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }




            return sales;
        }

    }
}
