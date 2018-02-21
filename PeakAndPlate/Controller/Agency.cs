using System;
using System.Text.RegularExpressions;
using PeakAndPlate.Model;

namespace PeakAndPlate.Controller
{
    public class Agency
    {
        public Agency()
        {
            PPStartMorning = new TimeSpan(7, 0, 0);
            PPEndMorning = new TimeSpan(9, 30, 0);
            PPStartAfternoon = new TimeSpan(16, 0, 0);
            PPEndAfternoon = new TimeSpan(19, 30, 0);
        }

        public TimeSpan PPStartMorning { get; set; }
        public TimeSpan PPEndMorning { get; set; }
        public TimeSpan PPStartAfternoon { get; set; }
        public TimeSpan PPEndAfternoon { get; set; }

        public bool PlateValidate(Car _car)
        {
            bool _valid;

            /*
            Validate plaque by Transit Agency Format
            */
            Regex _plateFormat1 = new Regex(@"^[A-Z]{3}-[0-9]{3}$"); //Old Format
            Regex _plateFormat2 = new Regex(@"^[A-Z]{3}-[0-9]{4}$"); //New Format
            Regex _plateFormat3 = new Regex(@"^[A-Z]{2}-[0-9]{4}$"); //Diplomatic Format

            return _valid = _plateFormat1.IsMatch(_car.Plate) ? true :
                        _valid = _plateFormat2.IsMatch(_car.Plate) ? true :
                            _valid = _plateFormat3.IsMatch(_car.Plate) ? true : false;
        }

        public string PeakAndPlate (Car _car, DateTime _dateTimeSelected, TimeSpan _hourSelected)
        {
            string _confirmation = "THE CAR CAN BE ON THE ROAD";

            if (PlateValidate(_car))
            {
                int _lastNumberPlate = Convert.ToInt16(_car.Plate.Substring(_car.Plate.Length - 1, 1));

                if ((_hourSelected >= PPStartMorning && _hourSelected <= PPEndMorning) ||
                    (_hourSelected >= PPStartAfternoon && _hourSelected <= PPEndAfternoon))
                {
                    if (((_lastNumberPlate == 1 || _lastNumberPlate == 2) && _dateTimeSelected.DayOfWeek == DayOfWeek.Monday) ||
                        ((_lastNumberPlate == 3 || _lastNumberPlate == 4) && _dateTimeSelected.DayOfWeek == DayOfWeek.Tuesday) ||
                        ((_lastNumberPlate == 5 || _lastNumberPlate == 6) && _dateTimeSelected.DayOfWeek == DayOfWeek.Wednesday) ||
                        ((_lastNumberPlate == 7 || _lastNumberPlate == 8) && _dateTimeSelected.DayOfWeek == DayOfWeek.Thursday) ||
                        ((_lastNumberPlate == 9 || _lastNumberPlate == 0) && _dateTimeSelected.DayOfWeek == DayOfWeek.Friday))
                    {
                        _confirmation = "THE CAR CAN NOT BE ON THE ROAD"; ;
                    }
                }
            }
            else
            {
                _confirmation = "THE PLATE IS INVALID";
            }
            return _confirmation;
        }
    }
}
