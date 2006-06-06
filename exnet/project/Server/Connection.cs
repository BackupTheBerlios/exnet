using System;
using System.Collections;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace Server
{
	[Serializable]
	public class Server
	{
		private TcpChannel _chan;
		private int _port = 9999;
		
		public void Start()
		{
			Start(_port);
		}
		
		public void Start(int port)
		{	
			BinaryClientFormatterSinkProvider clientProvider = null;
			BinaryServerFormatterSinkProvider serverProvider = new BinaryServerFormatterSinkProvider();
			serverProvider.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
				
			IDictionary props = new Hashtable();
			props["port"] = _port;
			props["typeFilterLevel"] = TypeFilterLevel.Full;
			_chan = new TcpChannel(
				props,clientProvider,serverProvider);

			ChannelServices.RegisterChannel(_chan,true);
			RegisterObjects();			
		}
			
		private void RegisterObjects()
		{			
			RemotingConfiguration.RegisterWellKnownServiceType(
			    Type.GetType("Server.RemoteObjects,Server"),
				"FirstRemote",WellKnownObjectMode.Singleton);					
		}
	}
}
