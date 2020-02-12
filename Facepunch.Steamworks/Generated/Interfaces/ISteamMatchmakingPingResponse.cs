using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Steamworks.Data;


namespace Steamworks
{
	internal class ISteamMatchmakingPingResponse : SteamInterface
	{
		public override IntPtr GetInterfacePointer() => GetApi.SteamMatchmakingPingResponse();
		
		
		internal ISteamMatchmakingPingResponse()
		{
			SetupInterface();
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPingResponse_ServerResponded")]
		private static extern void _ServerResponded( IntPtr self, ref gameserveritem_t server );
		
		#endregion
		internal void ServerResponded( ref gameserveritem_t server )
		{
			_ServerResponded( Self, ref server );
		}
		
		#region FunctionMeta
		[DllImport( Platform.LibraryName, EntryPoint = "SteamAPI_ISteamMatchmakingPingResponse_ServerFailedToRespond")]
		private static extern void _ServerFailedToRespond( IntPtr self );
		
		#endregion
		internal void ServerFailedToRespond()
		{
			_ServerFailedToRespond( Self );
		}
		
	}
}