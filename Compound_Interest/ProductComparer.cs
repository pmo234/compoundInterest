using System;
namespace Compound_Interest
{
	public class ProductComparer
	{

        public static string CompareProducts(
            string name,

           double Interest1,
           double Interest2
        )
        {
            if (Interest1 > Interest2) {

                double difference = Interest1 - Interest2;
            return name + ", Product 1 would give you £" +difference+ " more interest.";
            }
            if (Interest1 < Interest2)
            {

                double difference = Interest2 - Interest1;
                return name + ", Product 2 would give you £" + difference + " more interest.";
            }
            else {
                return name + ", both products give the same amount of interest.";
            }

        }

    }
}

