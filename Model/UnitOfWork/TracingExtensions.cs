using System;
using EFTracingProvider;
using Model.Infrastructure;

namespace Model.Entity
{
    public class TracingExtensions
    {
        public event EventHandler<CommandExecutionEventArgs> CommandExecuting
        {
            add { this.TracingConnection.CommandExecuting += value; }
            remove { this.TracingConnection.CommandExecuting -= value; }
        }

        private EFTracingConnection TracingConnection
        {
            get { return DbContextExtensions.UnwrapConnection<EFTracingConnection>(this); }
        }

        public event EventHandler<CommandExecutionEventArgs> CommandFinished
        {
            add { this.TracingConnection.CommandFinished += value; }
            remove { this.TracingConnection.CommandFinished -= value; }
        }

        public event EventHandler<CommandExecutionEventArgs> CommandFailed
        {
            add { this.TracingConnection.CommandFailed += value; }
            remove { this.TracingConnection.CommandFailed -= value; }
        }
    }
}