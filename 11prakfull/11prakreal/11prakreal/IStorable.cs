using System;
using System.Collections.Generic;
using System.Text;

namespace _11prakreal
{
    public interface IStorable
    {
        void SaveToFile(string filePath);
        void LoadFromFile(string filePath);
    }
}