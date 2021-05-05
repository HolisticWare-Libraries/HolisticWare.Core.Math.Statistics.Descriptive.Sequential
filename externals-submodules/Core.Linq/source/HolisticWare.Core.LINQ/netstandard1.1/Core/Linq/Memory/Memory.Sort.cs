using System;

namespace Core.Linq.Memory
{
    public static partial class MemoryExtensions
    {
        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<byte> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<byte> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            byte pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<short> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<short> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            short pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<ushort> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<ushort> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            ushort pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<int> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<int> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            int pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<uint> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<uint> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            uint pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<long> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<long> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            long pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<ulong> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<ulong> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            ulong pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<float> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<float> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            float pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<double> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<double> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            double pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

        //---------------------------------------------------------------------------------------------------------
        public static void Sort(this Memory<decimal> memory, int left, int right)
        {
            if (left > right || left < 0 || right < 0)
            {
                return;
            }
        
            int idx = PartitionHoare(memory, left, right);

            if (idx != -1)
            {
                Sort(memory, left, idx - 1);
                Sort(memory, idx + 1, right);
            }

            return;
        }

        private static int PartitionHoare(this Memory<decimal> memory, int left, int right)
        {
            if (left > right)
            {
                return -1;
            }

            int end = left; 

            decimal pivot = memory.Span[right];
            for(int i= left; i< right; i++)
            {
                if (memory.Span[i] < pivot)
                {
                    memory.Swap(i, end);
                    end++; 
                }
            }

            memory.Swap(end, right);

            return end; 
        }
        //---------------------------------------------------------------------------------------------------------

    }
}
