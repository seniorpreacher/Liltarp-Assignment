﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Application.BusinessServiceReference;

namespace Application
{
    public partial class Default : System.Web.UI.Page
    {
        private BusinessServiceClient service;

        protected void Page_Init(object sender, EventArgs e)
        {
            service = new BusinessServiceClient();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView.DataSource = serverObject.
        }


    }
}