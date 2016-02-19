using Microsoft.AspNet.SignalR;
using System;
using System.Threading;
using System.Web.Hosting;
using ND.MonitorDasboard.Web.Hubs;
using ND.Services;
using ND.BO;
using System.Collections.Generic;
using ND.MonitorDasboard.Web.Models;
using ND.MonitorDasboard.Web.Config;

namespace ND.MonitorDasboard.Web.Schedule
{
    public class BackgroundServerLifeTimer : IRegisteredObject
    {
        private static Timer taskTimer;
        private IHubContext hub;
        private ClustersModel model;
        private static int refreshTime;

        private List<ClusterBO> clustersLife;

        public static int RefreshTime
        {
            get { return refreshTime; }
        }

        public static bool PingActivated { get; set; }

        public delegate void OnRefreshTimerHandler(int refreshTimeValue);


        public BackgroundServerLifeTimer()
        {
            // Register Background task
            HostingEnvironment.RegisterObject(this);

            // Load clusters conf
            model = new ClustersModel(MonitorDashoardConfiguration.Instance);
            clustersLife = model.Clusters;

            // Start without ping by default
            PingActivated = false;

            // Create Hub connection
            hub = GlobalHost.ConnectionManager.GetHubContext<MonitorHub>();

            // Generate timer to push the data to the hub
            refreshTime = 10; // init with 10s
            taskTimer = new Timer(OnTimerElapsed, null,
                TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(refreshTime)); // every x seconds

        }

        /// <summary>
        /// Delegate for refreshing Life Tests
        /// </summary>
        /// <param name="sender"></param>
        private void OnTimerElapsed(object sender)
        {
            if (PingActivated)
            {
                LifeTestService.GetLifeTest(ref clustersLife);
                MonitorService.InsertResults(clustersLife);
                hub.Clients.All.RefreshLifeTests(model, DateTime.Now.ToString());
            }
        }

        public void Stop(bool immediate)
        {
            taskTimer.Dispose();
            HostingEnvironment.UnregisterObject(this);
        }

        public static void RefreshTimer(int refreshTimeValue)
        {
            refreshTime = refreshTimeValue;
            taskTimer.Change(0, refreshTime);
        }

        public static void RefreshPing(bool pingValue)
        {
            PingActivated = pingValue;
        }
    }
}