using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Strategy
    {
        private string strategyNumber;
        private string mapNumber;
        private string strategyName;
        private string strategyDescribe;

        public string StrategyNumber { get => strategyNumber; set => strategyNumber = value; }
        public string MapNumber { get => mapNumber; set => mapNumber = value; }
        public string StrategyName { get => strategyName; set => strategyName = value; }
        public string StrategyDescribe { get => strategyDescribe; set => strategyDescribe = value; }
    }
}
