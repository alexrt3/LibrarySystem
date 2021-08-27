﻿using LibraryData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public interface ILibraryAsset
    {
        IEnumerable<LibraryAsset> GetAll();
        LibraryAsset GetById(int id);

        void Add(ILibraryAsset newAsset);
        string getAuthorOrDirector(int id);
        string GetDeweyIndex(int id);
        string GetType(int id);
        string GetTitle(int id);
        string GetIsbn(int id);

        LibraryBranch GetCurrentLocation(int id);

    }
}
