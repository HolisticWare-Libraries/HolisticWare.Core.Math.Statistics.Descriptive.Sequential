using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    /// Satistics class representing summary Descriptive Statistics for IEnumerable<typeparamref name="T"/>>
    /// </summary>
    /// <example>
    /// </example>
    public partial class
                                        StatisticsDescriptive
    {
        
        public
                                        StatisticsDescriptive
                                        (
                                            IEnumerable data_input
                                        )
        {
            data = data_input;
            
            return;
        }

        private IEnumerable data;

        public
            IEnumerable
                                        Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;    
            }
        }

        /// <summary>
        /// Descriptive Statistics data of the type - double.
        /// </summary>
        /// <remarks>
        ///     -   Means
        ///     -   ....
        /// </remarks>
        /// <value>The data double.</value>
        public
            Dictionary<string,double>
                                        DataDouble
        {
            get;
            private set;
        }

        public
            double
                                        MeanArithmetic
                                        (
                                            IEnumerable<byte> data
                                        )
        {
            double mean_arithmetic = data.MeanArithmetic();

            if ( null != DataDouble)
            {
                DataDouble = new Dictionary<string, double>();
            }

            return mean_arithmetic;
        }
        

        
    }
}
