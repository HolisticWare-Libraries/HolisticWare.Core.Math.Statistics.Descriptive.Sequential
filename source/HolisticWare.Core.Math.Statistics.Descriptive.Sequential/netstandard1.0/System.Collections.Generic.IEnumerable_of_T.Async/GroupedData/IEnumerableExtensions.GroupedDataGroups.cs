using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Math.Statistics.Descriptive
{
    /// <summary>
    ///
    /// </summary>
    public static partial class
                                        IEnumerableExtensionsGroupedDataGroups
    {
        //==============================================================================================================
        // https://stackoverflow.com/questions/17119075/do-you-have-to-put-task-run-in-a-method-to-make-it-async
        public static
            Task<Dictionary<Tuple<double, double>, uint>>
                                        GroupedDataGroupsAsync
                                        (
                                            this IEnumerable<byte> x
                                        )
        {
            TaskCompletionSource<Dictionary<Tuple<double, double>, uint>> tcs;
            tcs = new TaskCompletionSource<Dictionary<Tuple<double, double>, uint>>();
            Task.Run
                    (
                        () =>
                        {
                            Dictionary<Tuple<double, double>, uint> result = x.GroupedDataGroups();
                            tcs.SetResult(result);
                        }
                    );

            return tcs.Task;
        }
        //==============================================================================================================

    }
}
