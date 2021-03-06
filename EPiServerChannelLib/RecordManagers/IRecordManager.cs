﻿using System;

namespace EPiServerChannelLib.RecordManagers
{
    public interface IRecordManager
    {
        void Init();

        Guid GetEPiServerGuid(string key);

        void AddEPiServerGuid(string key, Guid pageGuid);

        void Close();
    }
}