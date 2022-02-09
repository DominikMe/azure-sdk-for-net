namespace Azure.Communication.Rooms
{
    public partial class Communication.RoomsClient
    {
        protected Communication.RoomsClient() { }
        public Communication.RoomsClient(System.Uri endpoint, Azure.Core.TokenCredential credential, Azure.Communication.Rooms.Generated.Communication.RoomsServiceClientOptions options = null) { }
        public virtual Azure.Core.Pipeline.HttpPipeline Pipeline { get { throw null; } }
    }
    public partial class Communication.RoomsClientOptions : Azure.Core.ClientOptions
    {
        public Communication.RoomsClientOptions(Azure.Communication.Rooms.Generated.Communication.RoomsServiceClientOptions.ServiceVersion version = Azure.Communication.Rooms.Generated.Communication.RoomsServiceClientOptions.ServiceVersion.V1_0_0) { }
        public enum ServiceVersion
        {
            V1_0_0 = 1,
        }
    }
}
