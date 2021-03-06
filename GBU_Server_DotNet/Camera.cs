﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GBU_Server_DotNet
{
    public class Camera : INotifyPropertyChanged
    {
        private int _camID;
        private string _camURL;

        public int camID
        {
            get
            {
                return _camID;
            }
            set
            {
                if (value != _camID)
                {
                    _camID = value;
                    NotifyPropertyChanged("camID");
                }
            }
        }
        public string camURL
        {
            get
            {
                return _camURL;
            }
            set
            {
                if (value != _camURL)
                {
                    _camURL = value;
                    NotifyPropertyChanged("camURL");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged(String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Camera()
        {
            _camID = 0;
            //_camURL = "rtsp://admin:admin@14.52.220.82/media/video1";
            _camURL = "rtsp://admin:gbudata1234@192.168.0.16:554/Streaming/Channels/101/?transportmode=unicast";
        }

        public Camera(int id)
        {
            _camID = id;
            //_camURL = "rtsp://admin:admin@14.52.220.82/media/video1";
            _camURL = "rtsp://admin:gbudata1234@192.168.0.16:554/Streaming/Channels/101/?transportmode=unicast";
        }

        public Camera(int id, string url)
        {
            _camID = id;
            _camURL = url;
        }

    }
}
