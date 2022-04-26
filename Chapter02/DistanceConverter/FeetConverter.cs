using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    //フィートとメートルの単位変換クラス
    public static class FeetConverter {
        //メートルからフィートを求める(静的メソッド)
        public static double MeterToFeet(double meter) {
            return meter / 0.3048;
        }
        //フィートからメートルを求める(静的メソッド)
        public static double FeetToMeter(double feet) {
            return feet * 0.3048;
        }
        
    }
}
