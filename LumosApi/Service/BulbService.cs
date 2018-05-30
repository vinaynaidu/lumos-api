using LifxNet;
using LumosApi.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LumosApi.Service
{
	public class BulbService
	{
		static LifxClient client;
		private readonly LumosContext context;

		public BulbService(LumosContext lumosContext)
		{
			context = lumosContext;			
		}

		public void InitialiseBulbs()
		{
			// Wait for bulb task to warm up
			var task = LifxClient.CreateAsync();
			task.Wait();
			client = task.Result;

			// Attach discovery event handlers
			client.DeviceDiscovered += Client_DeviceDiscoveredAsync;
			client.DeviceLost += Client_DeviceLost;

			// Trigger discovery process
			client.StartDeviceDiscovery();
		}

		// Save device in memory at discovery
		private async void Client_DeviceDiscoveredAsync(object sender, LifxClient.DeviceDiscoveryEventArgs e)
		{
			var bulb = e.Device as LightBulb;
			var label = await client.GetDeviceLabelAsync(e.Device);

			await context.Bulbs.AddAsync(bulb);
		}

		// TODO: Mark device as lost?
		// Remove device from memory
		private void Client_DeviceLost(object sender, LifxClient.DeviceDiscoveryEventArgs e)
		{
			var bulb = context.Bulbs.Where(b => b.MacAddress == e.Device.MacAddress).FirstOrDefault();

			if(bulb != null)
			{
				context.Bulbs.Remove(bulb);
			}
		}

	}
}
