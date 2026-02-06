namespace XmobiTea.GearN.Config
{
    /// <summary>
    /// Enum for specifying the peer socket version.
    /// </summary>
    public enum PeerSocketVersion
    {
        None = 0,
        /// <summary>
        /// Socket.IO version 3.
        /// </summary>
        V4_DogHappy = 2,
    }

    /// <summary>
    /// Enum for specifying the HTTP request type.
    /// </summary>
    public enum HttpRequestType
    {
        /// <summary>
        /// HttpWebRequest for HTTP requests.
        /// </summary>
        HttpClientRequest = 2,
    }

    public enum MessageType
    {
        Json = 1,
        MsgPack = 2,
    }

    /// <summary>
    /// GN Server settings configuration.
    /// </summary>
    //[CreateAssetMenu(fileName = GNServerSettings.ResourcesPath, menuName = "GN/GNServerSettings", order = 1)]
    public class GNServerSettings
    {
        private string serverAddress = "127.0.0.1";
        private int serverPort = 2202;
        private int serverSocketPort = 2901;
        private bool useSsl = false;
        private bool useSocket = true;
        private bool useHttp = true;
        private int defaultTimeoutInSeconds = 20;
        private MessageType messageType = MessageType.MsgPack;
        private int sendRate = 20;
        private int reconnectDelay = 5000;
        private float pingInterval = 20000;
        private float pingTimeout = 20000;
        private string adminSecretKey;
        private string serverSecretKey;
        private string clientSecretKey;
        private PeerSocketVersion peerSocketVersion = PeerSocketVersion.None;
        private HttpRequestType httpRequestType = HttpRequestType.HttpClientRequest;

        private GearN.Logger.LogType logType = GearN.Logger.LogType.All;

        /// <summary>
        /// Gets the server address.
        /// </summary>
        /// <returns>The server address.</returns>
        public string getServerAddress() => this.serverAddress;

        public void setServerAddress(string serverAddress) => this.serverAddress = serverAddress;

        /// <summary>
        /// Gets the server port.
        /// </summary>
        /// <returns>The server port.</returns>
        public int getServerPort() => this.serverPort;

        public void setServerPort(int serverPort) => this.serverPort = serverPort;

        /// <summary>
        /// Gets the server socket port.
        /// </summary>
        /// <returns>The server socket port.</returns>
        public int getServerSocketPort() => this.serverSocketPort;

        public void setServerSocketPort(int serverSocketPort) => this.serverSocketPort = serverSocketPort;

        /// <summary>
        /// Indicates whether SSL is used.
        /// </summary>
        /// <returns>True if SSL is used; otherwise, false.</returns>
        public bool isUseSsl() => this.useSsl;

        public void setUseSsl(bool useSsl) => this.useSsl = useSsl;

        /// <summary>
        /// Indicates whether socket communication is enabled.
        /// </summary>
        /// <returns>True if socket is used; otherwise, false.</returns>
        public bool isUseSocket() => this.useSocket;

        public void setUseSocket(bool useSocket) => this.useSocket = useSocket;

        /// <summary>
        /// Indicates whether HTTP communication is enabled.
        /// </summary>
        /// <returns>True if HTTP is used; otherwise, false.</returns>
        public bool isUseHttp() => this.useHttp;

        public void setUseHttp(bool useHttp) => this.useHttp = useHttp;

        public int getDefaultTimeoutInSeconds() => this.defaultTimeoutInSeconds;

        public void setDefaultTimeoutInSeconds(int defaultTimeoutInSeconds) => this.defaultTimeoutInSeconds = defaultTimeoutInSeconds;

        public MessageType getMessageType() => this.messageType;

        public void setMessageType(MessageType messageType) => this.messageType = messageType;

        /// <summary>
        /// Gets the message send rate.
        /// </summary>
        /// <returns>The send rate.</returns>
        public int getSendRate() => this.sendRate;

        public void setSendRate(int sendRate) => this.sendRate = sendRate;

        /// <summary>
        /// Gets the reconnect delay in milliseconds.
        /// </summary>
        /// <returns>The reconnect delay.</returns>
        public int getReconnectDelay() => this.reconnectDelay;

        public void setReconnectDelay(int reconnectDelay) => this.reconnectDelay = reconnectDelay;

        /// <summary>
        /// Gets the ping interval in milliseconds.
        /// </summary>
        /// <returns>The ping interval.</returns>
        public float getPingInterval() => this.pingInterval;

        public void setPingInterval(int pingInterval) => this.pingInterval = pingInterval;

        /// <summary>
        /// Gets the ping timeout in milliseconds.
        /// </summary>
        /// <returns>The ping timeout.</returns>
        public float getPingTimeout() => this.pingTimeout;

        public void setPingTimeout(float pingTimeout) => this.pingTimeout = pingTimeout;

        /// <summary>
        /// Gets the admin secret key.
        /// </summary>
        /// <returns>The admin secret key.</returns>
        public string getAdminSecretKey() => this.adminSecretKey;

        public void setAdminSecretKey(string adminSecretKey) => this.adminSecretKey = adminSecretKey;

        /// <summary>
        /// Gets the server secret key.
        /// </summary>
        /// <returns>The server secret key.</returns>
        public string getServerSecretKey() => this.serverSecretKey;

        public void setServerSecretKey(string serverSecretKey) => this.serverSecretKey = serverSecretKey;

        /// <summary>
        /// Gets the client secret key.
        /// </summary>
        /// <returns>The client secret key.</returns>
        public string getClientSecretKey() => this.clientSecretKey;

        public void setClientSecretKey(string clientSecretKey) => this.clientSecretKey = clientSecretKey;

        /// <summary>
        /// Gets the peer socket version.
        /// </summary>
        /// <returns>The peer socket version.</returns>
        public PeerSocketVersion getPeerSocketVersion() => this.peerSocketVersion;

        public void setPeerSocketVersion(PeerSocketVersion peerSocketVersion) => this.peerSocketVersion = peerSocketVersion;

        /// <summary>
        /// Gets the HTTP request type.
        /// </summary>
        /// <returns>The HTTP request type.</returns>
        public HttpRequestType getHttpRequestType() => this.httpRequestType;

        public void setHttpRequestType(HttpRequestType httpRequestType) => this.httpRequestType = httpRequestType;

        /// <summary>
        /// Gets the log type.
        /// </summary>
        /// <returns>The log type.</returns>
        public GearN.Logger.LogType getLogType() => this.logType;

        public void setLogType(GearN.Logger.LogType logType) => this.logType = logType;

        /// <summary>
        /// Constructs the socket URL.
        /// </summary>
        /// <returns>The socket URL.</returns>
        public string getSocketUrl() =>
            this.serverPort < 0
                ? $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}"
                : $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}:{this.serverSocketPort}";

        /// <summary>
        /// Constructs the HTTP URL.
        /// </summary>
        /// <returns>The HTTP URL.</returns>
        public string getHttpUrl() =>
            this.serverPort < 0
                ? $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}"
                : $"{(this.useSsl ? "https" : "http")}://{this.serverAddress}:{this.serverPort}";
    }
}
