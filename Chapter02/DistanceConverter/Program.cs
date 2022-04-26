﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        //コマンドライン引数
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1, 10);
            }else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1, 10);
            }
            
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            for (int meter = 1; meter <= 10; meter++) {
                double feet = FeetConverter.MeterToFeet(meter);
                Console.WriteLine("{0}m = {1:0.0000}ft", meter, feet);
            }
        }

        //フィートからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start,int stop) {
            for (int feet = 1; feet <= 10; feet++) { 
                double meter = FeetConverter.FeetToMeter(feet);
                Console.WriteLine("{0}ft = {1:0.0000}m", feet, meter);
            }
        }

        
    }
}
