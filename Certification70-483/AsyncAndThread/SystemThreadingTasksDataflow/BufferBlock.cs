using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Certification70_483.AsyncAndThread.SystemThreadingTasksDataflow
{
    public class BufferBlock
    {
        public void ProccessSimpleBufferBlockReceive()
        {
            // Create a BufferBlock<int> object.
            var bufferBlock = new BufferBlock<int>();

            // Post several messages to the block.
            for (int i = 0; i < 3; i++)
            {
                bufferBlock.Post(i);
            }

            // Receive the messages back from the block.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(bufferBlock.Receive());
            }
            Console.ReadKey();
        }

        public void ProccessSimpleBufferBlockTryReceive()
        {
            var bufferBlock = new BufferBlock<int>();
            // Post more messages to the block.
            for (int i = 0; i < 3; i++)
            {
                bufferBlock.Post(i);
            }

            // Receive the messages back from the block.
            while (bufferBlock.TryReceive(out int value))
            {
                Console.WriteLine(value);
            }
        }
    }
}
