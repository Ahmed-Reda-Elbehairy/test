﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Bank_Management_System
{
    public partial class RecepientControl : UserControl
    {
        public RecepientControl()
        {
            InitializeComponent();
        }

        //Properties
        public TextBox txtbxHospitalProperty {
            set { txtbxHospital = value; }
            get { return txtbxHospital; }
        
        }
        public TextBox txtbxDoctorOfTheCaseProperty
        {
            set { txtbxDoctorOfTheCase = value; }
            get { return txtbxDoctorOfTheCase; }

        }
    }
}
