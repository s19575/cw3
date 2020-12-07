﻿using System.Collections.Generic;

namespace cw3.DAL
{
    public interface IDbService<T>
    {
        public IEnumerable<T> GetEntries();
        public T GetEntry(int id);
        public int NextId();
        public void AddEntry(T entryToAdd);
        public void RemoveEntry(T entryToRemove);
    }
}
