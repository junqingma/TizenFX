﻿// Copyright 2016 by Samsung Electronics, Inc.,
//
// This software is the confidential and proprietary information
// of Samsung Electronics, Inc. ("Confidential Information"). You
// shall not disclose such Confidential Information and shall use
// it only in accordance with the terms of the license agreement
// you entered into with Samsung.

using System;

namespace Tizen.Sensor
{
    /// <summary>
    /// LightSensor Class. Used for registering callbacks for light sensor and getting light data
    /// /// </summary>
    public class LightSensor : Sensor
    {
        private const string LightSensorKey = "http://tizen.org/feature/sensor.photometer";

        /// <summary>
        /// Gets the Level of the light.
        /// </summary>
        public float Level { get; private set; } = float.MinValue;

        /// <summary>
        /// Returns true or false based on whether light sensor is supported by device.
        /// </summary>
        public static bool IsSupported
        {
            get
            {
                Log.Info(Globals.LogTag, "Checking if the LightSensor is supported");
                return CheckIfSupported(SensorType.LightSensor, LightSensorKey);
            }
        }

        /// <summary>
        /// Returns the number of light sensors available on the device.
        /// </summary>
        public static int Count
        {
            get
            {
                Log.Info(Globals.LogTag, "Getting the count of light sensors");
                return GetCount();
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Tizen.Sensor.LightSensor"/> class.
        /// </summary>
        /// <exception cref="ArgumentException">Thrown when an invalid argument is used</exception>
        /// <exception cref="NotSupportedException">Thrown when the sensor is not supported</exception>
        /// <exception cref="InvalidOperationException">Thrown when the operation is invalid for the current state</exception>
        /// <param name='index'>
        /// Index. Default value for this is 0. Index refers to a particular light sensor in case of multiple sensors
        /// </param>
        public LightSensor(uint index = 0) : base(index)
        {
            Log.Info(Globals.LogTag, "Creating LightSensor object");
        }

        internal override SensorType GetSensorType()
        {
            return SensorType.LightSensor;
        }

        /// <summary>
        /// Event Handler for storing the callback functions for event corresponding to change in light sensor data.
        /// </summary>

        public event EventHandler<LightSensorDataUpdatedEventArgs> DataUpdated;

        private static int GetCount()
        {
            IntPtr list;
            int count;
            int error = Interop.SensorManager.GetSensorList(SensorType.LightSensor, out list, out count);
            if (error != (int)SensorError.None)
            {
                Log.Error(Globals.LogTag, "Error getting sensor list for light");
                count = 0;
            }
            else
                Interop.Libc.Free(list);
            return count;
        }

        protected override void EventListenStart()
        {
            int error = Interop.SensorListener.SetEventCallback(ListenerHandle, Interval, SensorEventCallback, IntPtr.Zero);
            if (error != (int)SensorError.None)
            {
                Log.Error(Globals.LogTag, "Error setting event callback for light sensor");
                throw SensorErrorFactory.CheckAndThrowException(error, "Unable to set event callback for light");
            }
        }

        protected override void EventListenStop()
        {
            int error = Interop.SensorListener.UnsetEventCallback(ListenerHandle);
            if (error != (int)SensorError.None)
            {
                Log.Error(Globals.LogTag, "Error unsetting event callback for light sensor");
                throw SensorErrorFactory.CheckAndThrowException(error, "Unable to unset event callback for light");
            }
        }

        private void SensorEventCallback(IntPtr sensorHandle, IntPtr sensorPtr, IntPtr data)
        {
            Interop.SensorEventStruct sensorData = Interop.IntPtrToEventStruct(sensorPtr);
            TimeSpan = new TimeSpan((Int64)sensorData.timestamp);
            Level = sensorData.values[0];

            DataUpdated?.Invoke(this, new LightSensorDataUpdatedEventArgs(sensorData.values[0]));
        }
    }
}
