﻿using System;
using System.Collections.Generic;
using System.Text;
using Tizen.Applications.CoreBackend;
using static Interop.CBApplication;
using static Tizen.Applications.CoreBackend.DefaultCoreBackend;

namespace Tizen.Applications.ComponentBased.Common
{
    internal abstract class ComponentStateManger
    {
        private IList<BaseComponent> ComponentInstances { get; }
        public IEnumerable<BaseComponent> Instances => ComponentInstances;
        protected void AddComponent(BaseComponent comp)
        {
            ComponentInstances.Add(comp);
        }

        protected void RemoveComponent(BaseComponent comp)
        {
            ComponentInstances.Remove(comp);
        }
        public Type ComponentClassType { get; }
        public string ComponentId { get; }
        protected ComponentBasedApplication Parent { get; set; }

        internal ComponentStateManger(Type ctype, string id, ComponentBasedApplication parent)
        {
            ComponentClassType = ctype;
            ComponentId = id;
            ComponentInstances = new List<BaseComponent>();
            Parent = parent;
        }

        protected void OnLanguageChangedCallback(IntPtr context, string language, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    com.OnLanguageChangedCallback(language);
                }
            }
        }

        protected void OnDeviceOrientationChangedCallback(IntPtr context, int orientation, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    com.OnDeviceOrientationChangedCallback(orientation);
                }
            }
        }

        protected void OnLowBatteryCallback(IntPtr context, int status, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    com.OnLowBatteryCallback(status);
                }
            }
        }

        protected void OnLowMemoryCallback(IntPtr context, int status, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    com.OnLowMemoryCallback(status);
                }
            }
        }

        protected void OnRegionFormatChangedCallback(IntPtr context, string region, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    com.OnRegionFormatChangedCallback(region);
                }
            }
        }

        protected void OnSuspendedStateCallback(IntPtr context, int state, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    com.OnSuspendedStateCallback(state);
                }
            }
        }

        protected void OnRestoreCallback(IntPtr context, IntPtr content, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    Bundle bundle = null;

                    if (content != IntPtr.Zero)
                        bundle = new Bundle(new SafeBundleHandle(content, false));
                    com.OnRestoreContents(bundle);
                    break;
                }
            }
        }

        protected void OnSaveCallback(IntPtr context, IntPtr content, IntPtr userData)
        {
            foreach (BaseComponent com in ComponentInstances)
            {
                if (com.Handle == context)
                {
                    Bundle bundle = null;

                    if (content != IntPtr.Zero)
                        bundle = new Bundle(new SafeBundleHandle(content, false));
                    com.OnSaveContent(bundle);
                    break;
                }
            }
        }

        internal abstract IntPtr Bind(IntPtr h);
    }
}
