using Core.Math.Statistics.Descriptive;

namespace Core.Math.Statistic.Descriptive.MatlabOctave
{
    public partial class
        MatlabOctave
    {
        public static double median(IEnumerable<byte> x, string opt)
        {
            return x.Median();
        }
    }
}
