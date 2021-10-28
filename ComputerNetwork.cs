using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Number_13
{
    class ComputerNetwork
    {
        private string organizationName;
        private int numberWorkStation;
        private double averageDistance;
        public ComputerNetwork(string orgName,int numWorkStation, double avgDistance)
        {
            organizationName = orgName;
            numberWorkStation = numWorkStation;
            averageDistance = avgDistance;
        }
        //все расстояние
        public virtual double Q()
        {
            return numberWorkStation * averageDistance;
        }
        
        public override string ToString()
        {
            return " Название организации: "+organizationName+", число станций: "
                +numberWorkStation+", среднее растояние между станциями:"+averageDistance;
        }

    }
}
