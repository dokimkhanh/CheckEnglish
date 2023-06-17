using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckEnglish
{
    internal class CauHoi
    {
        public int _id { get; set; }
        public int _made { get; set; }
        public string _debai { get; set; }
        public string _dapanA { get; set; }
        public string _dapanB { get; set; }
        public string _dapanC { get; set; }
        public string _dapanD { get; set; }
        public string _dapanDung { get; set; }


        public CauHoi() {
            _id = 0;
            _made = 0;
            _debai = "Cau hoi demo";
            _dapanA = "huhu";
            _dapanB = "hihi";
            _dapanC = "C";
            _dapanD = "D";

            _dapanDung = "B";
        }

        public CauHoi(int p_id, int p_made, string _db, string _daA, string _daB, string _daC, string _daD, string _daDung) {
            _id = p_id;
            _made = p_made;
            _debai = _db;
            _dapanA = _daA;
            _dapanB = _daB;
            _dapanC = _daC;
            _dapanD = _daD;
            _dapanDung = _daDung;
        }

    }
}
