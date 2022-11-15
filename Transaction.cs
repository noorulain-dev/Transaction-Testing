using System;

namespace Passtask3{

    public class Transaction{
        private int _transNo;
        private string _date;
        private int _amounts;
        private int _points;
        private TransactionMode _mode;
        
        public enum TransactionMode
        {
            online,
            offline
        }
        
        public Transaction(int transNo, string date, int amounts, TransactionMode mode){
            _transNo = transNo;
            _date = date;
            _amounts = amounts;
            _mode = mode;
        }

        public TransactionMode Mode{
            get{return _mode;}
            set{_mode = value;}
        }

        public int TransNo{
            get{return _transNo;}
            set{_transNo = value;}
        }
        
        public string Date{
            get{return _date;}
            set{_date = value;}
        }
        
        public int Amounts{
            get{return _amounts;}
            set{_amounts = value;}
        }
        
        public void UpdatePoints(){
            _points = _amounts/10;
        }

        public int Points{
            get{return _points;}
            set{_points = value;}
        }

        public string PrintInfo(){
            if(_mode == TransactionMode.online){
                return "That’s a wise choice with more rewards";
            }
            else{
                return "You have secured some points";
            }
        }

    }

}