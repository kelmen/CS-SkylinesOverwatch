using System;
using System.Collections.Generic;
using System.Threading;

using ICities;
using ColossalFramework;
using ColossalFramework.Math;
using ColossalFramework.UI;
using UnityEngine;

namespace SkylinesOverwatch
{
    public class Loader : ILoadingExtension
    {
        Helper _helper;

        public void OnCreated(ILoading loading)
        {
            _helper = Helper.Instance;

            _helper.GameLoaded = loading.loadingComplete;
        }

        public void OnLevelLoaded(LoadMode mode)
        {
            if (mode == LoadMode.NewGame || mode == LoadMode.LoadGame)
                _helper.GameLoaded = true;
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