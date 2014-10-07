using System;
using System.Threading;
using Common.Extensions;
using NServiceBus;

namespace NserviceBusMultiThreading.MessageHandlers
{
    public abstract class CommandHandler<T> : Handler, IHandleMessages<T>
    {
        protected abstract void OnProcess(T command);

        public virtual void Handle(T message)
        {
            try
            {
                if (Environment.UserInteractive)
                {
                    Console.WriteLine(String.Format(@"({0}){1}:{2}", Thread.CurrentThread.ManagedThreadId, typeof(T).FullName, message.ToStringLinq()));
                }

                Logger.InfoFormat(@"{0}:{1}", Thread.CurrentThread.ManagedThreadId, typeof(T).FullName, message.ToStringLinq());
                OnProcess(message);
            }
            catch (Exception ex)
            {
                Logger.Error(string.Format("Failed to Handle {0} Command:{1}", typeof(T).FullName, message.ToStringLinq()), ex);
                if (Environment.UserInteractive)
                {
                    Console.WriteLine(string.Format("Failed to Handle {0} Command:{1} ErrorMsg:{2}", typeof(T).FullName, message.ToStringLinq(), ex.ToString()));
                }
                throw;
            }
        }
    }
}
