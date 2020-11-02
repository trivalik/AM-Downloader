﻿// Copyright (C) 2020 Antik Mozib. Released under CC BY-NC-SA 4.0.

using System;
using System.Collections.Generic;

namespace AMDownloader.ObjectModel.Serializable
{
    [Serializable]
    public class SerializableDownloadPathHistoryList
    {
        public List<SerializableDownloadPathHistory> Objects;

        public SerializableDownloadPathHistoryList()
        {
            Objects = new List<SerializableDownloadPathHistory>();
        }
    }
}