using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Number_13
{
    class HeirToTheComputerNetwork : ComputerNetwork
    {
        private double averageNetworkSpeed;
        public HeirToTheComputerNetwork(double avgNetworkSpeed,
            string orgName, int numWorkStation, double avgDistance)
            : base(orgName, numWorkStation, avgDistance)
        {
            averageNetworkSpeed = avgNetworkSpeed;
        }
        //Qp
        public override double Q()
        {
            return base.Q() * averageNetworkSpeed;
        }
        public override string ToString()
        {
            return base.ToString() + ", средняя скорость соединения:" + averageNetworkSpeed;
        }
    }
}
