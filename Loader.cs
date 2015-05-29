using System;
using System.Collections.Generic;
using System.Threading;

using ICities;
using ColossalFramework;
using ColossalFramework.Math;
using ColossalFramework.Plugins;
using ColossalFramework.UI;
using UnityEngine;

namespace SkylinesOverwatch
{
    public class Loader : ILoadingExtension
    {
        Helper _helper;

        public Loader()
        {
            _helper = Helper.Instance;
        }

        public void OnCreated(ILoading loading)
        {
            _helper.GameLoaded = loading.loadingComplete;
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.NewGame || mode == LoadMode.LoadGame)
            {
                //DebugOutputPanel.AddMessage(PluginManager.MessageType.Message, string.Format("SkylinesOverwatch.OnLevelLoaded 1.1 {0}", _helper == null));
                _helper.GameLoaded = true;
            }
        }

        public void OnLevelUnloading()
        {
            _helper.GameLoaded = false;
        }

        public void OnReleased()
        {
        }
    }
}