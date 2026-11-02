using System;
using System.Collections.Generic;
using System.Text;

namespace WPFMVVM.Models
{
    public class Person
    {

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _fName;

		public string Fname
		{
			get { return _fName; }
			set { _fName = value; }
		}

        private string _lName;

        public string Lname
		{

            get { return _lName; }
            set { _lName = value; }
        }

        private bool _isActive;
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

    }
}
