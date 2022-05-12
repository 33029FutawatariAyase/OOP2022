using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class InchConverter {

        private const double ratio = 0.0254;

        //メートルからインチを求める(静的メソッド)
        public static double MeterToInch(double meter) {
            return meter / ratio;
        }

        //インチからメートルを求める(静的メソッド)
        public static double InchToMeter(double inch) {
            return inch * ratio;
        }
    }
}
