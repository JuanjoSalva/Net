using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignProject
{
    public class Photo
    {
        public int PhotoID
        {
            get => default(int);
            set
            {
            }
        }

        public int Title
        {
            get => default(string);
            set
            {
            }
        }

        public byte PhotoFile
        {
            get => default(byte);
            set
            {
            }
        }

        public string Description
        {
            get => default(string);
            set
            {
            }
        }

        public System.DateTime CreateDate
        {
            get => default(DateTime);
            set
            {
            }
        }

        public int Owner
        {
            get => default(int);
            set
            {
            }
        }

        public Comment PhotoComments
        {
            get => default;
            set
            {
            }
        }
    }
}