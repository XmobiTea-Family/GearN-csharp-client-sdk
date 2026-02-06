namespace XmobiTea.GearN.CSharp
{
    using System.Threading;
    using XmobiTea.GearN.Networking;

    public class ServiceUpdate
    {
        /// <summary>
        /// The NetworkingPeer instance used to perform network operations.
        /// </summary>
        internal NetworkingPeer peer;

        private Thread thread { get; }

        /// <summary>
        /// Handles the logic to update the network service.
        /// </summary>
        private void update()
        {
            // Calls the service() method of the peer object if it is not null.
            this.peer?.service();
        }

        internal void run()
        {
            this.thread.Start();
        }

        public ServiceUpdate()
        {
            this.thread = new Thread(() =>
            {
                while (true)
                {
                    this.update();
                }
            });
        }

        ~ServiceUpdate()
        {
            this.thread?.Abort();
        }

    }

}
