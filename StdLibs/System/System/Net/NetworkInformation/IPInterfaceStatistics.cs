
namespace System.Net.NetworkInformation
{
    public abstract class IPInterfaceStatistics
    {
        public abstract long BytesReceived
        {
            get;
        }
    
        public abstract long BytesSent
        {
            get;
        }
    
        public abstract long IncomingPacketsDiscarded
        {
            get;
        }
    
        public abstract long IncomingPacketsWithErrors
        {
            get;
        }
    
        public abstract long IncomingUnknownProtocolPackets
        {
            get;
        }
    
        public abstract long NonUnicastPacketsReceived
        {
            get;
        }
    
        public abstract long NonUnicastPacketsSent
        {
            get;
        }
    
        public abstract long OutgoingPacketsDiscarded
        {
            get;
        }
    
        public abstract long OutgoingPacketsWithErrors
        {
            get;
        }
    
        public abstract long OutputQueueLength
        {
            get;
        }
    
        public abstract long UnicastPacketsReceived
        {
            get;
        }
    
        public abstract long UnicastPacketsSent
        {
            get;
        }
    
    
        protected IPInterfaceStatistics()
        {
             throw new NotImplementedException();
        }
        
        
    }
}
