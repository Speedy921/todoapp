using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    class ToDoModel
    {
        private bool _IsDone;
        private string _Text;
        public DateTime CreationDate { get; set; } = DateTime.Now;
               
        public bool IsDone
        {
            get { return _IsDone; }
            set { _IsDone = value; }
        }     

        public string Text
        {
            get { return _Text; }
            set { _Text = value; }
        }


    }
}
